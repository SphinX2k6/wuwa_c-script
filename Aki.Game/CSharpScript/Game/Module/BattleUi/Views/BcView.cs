using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CFF RID: 23807
	public class BcView : UiViewBase
	{
		// Token: 0x0603C4C3 RID: 246979 RVA: 0x00E70C8E File Offset: 0x00E6EE8E
		[NullableContext(1)]
		public BcView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603C4C4 RID: 246980 RVA: 0x00E70CA4 File Offset: 0x00E6EEA4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			this.CurrentCode = new Code12();
		}

		// Token: 0x0603C4C5 RID: 246981 RVA: 0x00E70DE0 File Offset: 0x00E6EFE0
		protected override void OnStart()
		{
			if ((KuroApplication.IsBuildShipping() && KuroApplication.GetAppReleaseType() == "Product") || UKuroLauncherLibrary.GetAppInternalUseType() == "Marketing")
			{
				return;
			}
			string text = LoginModel.Instance.GetLoginUid();
			int num;
			if (!int.TryParse(text, out num) || num.ToString() != text)
			{
				text = "1";
				if (FunctionModel.Instance.PlayerId != 0)
				{
					text = FunctionModel.Instance.PlayerId.ToString();
				}
				else
				{
					TArray<int> tarray = new TArray<int>();
					UKuroStaticLibrary.GetLocalAdapterAddressesUint32(ref tarray);
					if (tarray.Num() > 0)
					{
						text = tarray.Get(0).ToString();
					}
				}
			}
			string contentString = text;
			UUIItem item = base.GetItem(0);
			UUIItem item2 = base.GetItem(1);
			this.InitContent(item, item2, contentString, BcView.EBcOrientation.Horizontal);
			UUIItem item3 = base.GetItem(2);
			UUIItem item4 = base.GetItem(3);
			this.InitContent(item3, item4, contentString, BcView.EBcOrientation.Horizontal);
			UUIItem item5 = base.GetItem(4);
			UUIItem item6 = base.GetItem(5);
			this.InitContent(item5, item6, contentString, BcView.EBcOrientation.Vertical);
			UUIItem item7 = base.GetItem(6);
			UUIItem item8 = base.GetItem(7);
			this.InitContent(item7, item8, contentString, BcView.EBcOrientation.Vertical);
		}

		// Token: 0x0603C4C6 RID: 246982 RVA: 0x00E70F08 File Offset: 0x00E6F108
		[NullableContext(1)]
		private void InitContent(UUIItem parentItem, UUIItem barItem, string contentString, BcView.EBcOrientation orientation)
		{
			parentItem.SetAlpha(0.4f);
			float num = (orientation == BcView.EBcOrientation.Horizontal) ? UiLayer.Instance.UiRootItem.GetWidth() : UiLayer.Instance.UiRootItem.GetHeight();
			string text = "+" + contentString + "-";
			int num2 = this.CurrentCode.SingleCodeLength();
			int num3 = text.Length * num2;
			int num4 = num3 * 14;
			int num5 = (int)Math.Floor((double)(num / (float)num4));
			int num6 = 1;
			int num8;
			if (num5 > 1)
			{
				int num7 = (int)Math.Floor((double)(num / (float)(num3 * 10)));
				if (num7 > 1)
				{
					int val = (int)Math.Floor((double)(num / (float)(num3 * num7)));
					num8 = Math.Max(10, val);
					num6 = num7;
				}
				else
				{
					num8 = 14;
					num6 = num5;
				}
			}
			else
			{
				num8 = (int)Math.Floor((double)(num / (float)num3));
			}
			if (orientation == BcView.EBcOrientation.Horizontal)
			{
				barItem.SetWidth((float)num8);
			}
			else
			{
				barItem.SetHeight((float)num8);
			}
			int num9 = num6 * num3;
			List<UUIItem> list = new List<UUIItem>();
			list.Add(barItem);
			for (int i = 1; i < num9; i++)
			{
				AActor aactor = LguiUtil.Instance.DuplicateActor(barItem.GetOwner(), parentItem);
				list.Add(aactor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
			}
			Dictionary<string, int[]> codeTable = this.CurrentCode.GetCodeTable();
			for (int j = 0; j < num6; j++)
			{
				for (int k = 0; k < num3; k++)
				{
					UUIItem uuiitem = list[k + j * num3];
					string key = text[(int)Math.Floor((double)((float)k / (float)num2))].ToString();
					int num10 = k % num2;
					int[] array = codeTable[key];
					int num11 = (num10 > num2 - 1) ? 0 : array[num10];
					uuiitem.SetAlpha(num11 > 0);
					int num12 = 0;
					if (num11 != 1)
					{
						if (num11 == 2)
						{
							num12 = 7;
						}
					}
					else
					{
						num12 = 5;
					}
					if (orientation == BcView.EBcOrientation.Horizontal)
					{
						uuiitem.SetHeight((float)num12);
					}
					else
					{
						uuiitem.SetWidth((float)num12);
					}
				}
			}
		}

		// Token: 0x0401F69A RID: 128666
		private const int ITEM_WIDTH_MIN = 10;

		// Token: 0x0401F69B RID: 128667
		private const int ITEM_WIDTH_MAX = 14;

		// Token: 0x0401F69C RID: 128668
		private const int ITEM_HEIGHT_1 = 5;

		// Token: 0x0401F69D RID: 128669
		private const int ITEM_HEIGHT_2 = 7;

		// Token: 0x0401F69E RID: 128670
		[Nullable(1)]
		private CodeNBase CurrentCode = new Code54();

		// Token: 0x0200BF72 RID: 49010
		private enum EBcComponents
		{
			// Token: 0x04039BB9 RID: 236473
			BcContainerTop,
			// Token: 0x04039BBA RID: 236474
			ItemTop,
			// Token: 0x04039BBB RID: 236475
			BcContainerBottom,
			// Token: 0x04039BBC RID: 236476
			ItemBottom,
			// Token: 0x04039BBD RID: 236477
			BcContainerLeft,
			// Token: 0x04039BBE RID: 236478
			ItemLeft,
			// Token: 0x04039BBF RID: 236479
			BcContainerRight,
			// Token: 0x04039BC0 RID: 236480
			ItemRight,
			// Token: 0x04039BC1 RID: 236481
			ItemMask
		}

		// Token: 0x0200BF73 RID: 49011
		private enum EBcOrientation
		{
			// Token: 0x04039BC3 RID: 236483
			Horizontal,
			// Token: 0x04039BC4 RID: 236484
			Vertical
		}
	}
}
