using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004AF0 RID: 19184
	[NullableContext(1)]
	[Nullable(0)]
	public class MaterialItem : UiPanelBase
	{
		// Token: 0x0602FFCA RID: 196554 RVA: 0x00D62BF8 File Offset: 0x00D60DF8
		public MaterialItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602FFCB RID: 196555 RVA: 0x00D62C10 File Offset: 0x00D60E10
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602FFCC RID: 196556 RVA: 0x00D62D1C File Offset: 0x00D60F1C
		public void Update(ISingleItemInfo info, int index)
		{
			this.ItemData = info;
			this.Index = index;
			if (this.ItemData.Proto_ItemId != 0)
			{
				this.ItemInfo = ItemConfig.Instance.GetConfig(this.ItemData.Proto_ItemId);
			}
			else
			{
				this.ItemInfo = null;
			}
			this.RefreshNeed(1);
			this.RefreshHave();
			this.RefreshIcon();
			this.RefreshQuality();
		}

		// Token: 0x0602FFCD RID: 196557 RVA: 0x00D62D88 File Offset: 0x00D60F88
		public void RefreshNeed(int num = 1)
		{
			int num2 = this.ItemData.Proto_ItemNum;
			if (num != 1)
			{
				num2 = num * num2;
			}
			base.GetText(2).SetText(num2.ToString(), true);
		}

		// Token: 0x0602FFCE RID: 196558 RVA: 0x00D62DC0 File Offset: 0x00D60FC0
		protected void RefreshHave()
		{
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(this.ItemData.Proto_ItemId, 0);
			string newText;
			if (this.ItemData.Proto_IsUnlock)
			{
				if (commonItemCount < this.ItemData.Proto_ItemNum)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
					defaultInterpolatedStringHandler.AppendLiteral("<color=#");
					defaultInterpolatedStringHandler.AppendFormatted("ece5d8");
					defaultInterpolatedStringHandler.AppendLiteral(">");
					defaultInterpolatedStringHandler.AppendFormatted<int>(commonItemCount);
					defaultInterpolatedStringHandler.AppendLiteral("</color>");
					newText = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
					defaultInterpolatedStringHandler.AppendLiteral("<color=#");
					defaultInterpolatedStringHandler.AppendFormatted("aa9b6a");
					defaultInterpolatedStringHandler.AppendLiteral(">");
					defaultInterpolatedStringHandler.AppendFormatted<int>(commonItemCount);
					defaultInterpolatedStringHandler.AppendLiteral("</color>");
					newText = defaultInterpolatedStringHandler.ToStringAndClear();
				}
			}
			else
			{
				newText = "<color=#aa9b6a>--</color>";
			}
			base.GetText(1).SetText(newText, true);
		}

		// Token: 0x0602FFCF RID: 196559 RVA: 0x00D62EB0 File Offset: 0x00D610B0
		private void RefreshIcon()
		{
			if (this.ItemData.Proto_IsUnlock)
			{
				base.GetTexture(3).SetUIActive(true);
				base.SetTextureByPath(this.ItemInfo.Value.Icon, base.GetTexture(3), null, null);
				return;
			}
			base.GetTexture(3).SetUIActive(false);
		}

		// Token: 0x0602FFD0 RID: 196560 RVA: 0x00D62F10 File Offset: 0x00D61110
		private void RefreshQuality()
		{
			if (this.ItemData.Proto_IsUnlock)
			{
				base.GetSprite(4).SetUIActive(true);
				base.SetItemQualityIcon(base.GetSprite(4), this.ItemData.Proto_ItemId, null, global::CommonDefine.EQualityIconType.BackgroundSprite, null);
				return;
			}
			base.GetSprite(4).SetUIActive(false);
		}

		// Token: 0x0602FFD1 RID: 196561 RVA: 0x00D62F68 File Offset: 0x00D61168
		public void BindOnClickedCallback(Action<ISingleItemInfo, int> onItemButtonClicked)
		{
			this.OnClickedCallback = onItemButtonClicked;
		}

		// Token: 0x0602FFD2 RID: 196562 RVA: 0x00D62F71 File Offset: 0x00D61171
		private void OnClick(EToggleState state)
		{
			if (this.OnClickedCallback != null)
			{
				this.OnClickedCallback(this.ItemData, this.Index);
			}
		}

		// Token: 0x04019763 RID: 104291
		[Nullable(2)]
		protected ISingleItemInfo ItemData;

		// Token: 0x04019764 RID: 104292
		protected ItemInfo? ItemInfo;

		// Token: 0x04019765 RID: 104293
		protected int Index;

		// Token: 0x04019766 RID: 104294
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ISingleItemInfo, int> OnClickedCallback;

		// Token: 0x0200A756 RID: 42838
		[NullableContext(0)]
		public enum EMaterialDefine
		{
			// Token: 0x04033B4D RID: 211789
			MaterialExtendToggle,
			// Token: 0x04033B4E RID: 211790
			HaveText,
			// Token: 0x04033B4F RID: 211791
			NeedText,
			// Token: 0x04033B50 RID: 211792
			MaterialIconTexture,
			// Token: 0x04033B51 RID: 211793
			MaterialQualitySprite
		}
	}
}
