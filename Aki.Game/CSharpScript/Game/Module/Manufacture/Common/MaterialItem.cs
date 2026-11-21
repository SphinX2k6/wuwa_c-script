using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02004661 RID: 18017
	[NullableContext(1)]
	[Nullable(0)]
	public class MaterialItem : UiPanelBase
	{
		// Token: 0x0602D4EB RID: 185579 RVA: 0x00CB012F File Offset: 0x00CAE32F
		public MaterialItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602D4EC RID: 185580 RVA: 0x00CB0144 File Offset: 0x00CAE344
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

		// Token: 0x0602D4ED RID: 185581 RVA: 0x00CB0250 File Offset: 0x00CAE450
		public void Update(ISingleItemInfo info)
		{
			this.ItemData = info;
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

		// Token: 0x0602D4EE RID: 185582 RVA: 0x00CB02B4 File Offset: 0x00CAE4B4
		public void RefreshNeed(int num = 1)
		{
			int num2 = this.ItemData.Proto_ItemNum;
			if (num != 1)
			{
				num2 = num * num2;
			}
			base.GetText(2).SetText(num2.ToString(), true);
		}

		// Token: 0x0602D4EF RID: 185583 RVA: 0x00CB02EC File Offset: 0x00CAE4EC
		protected void RefreshHave()
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.ItemData.Proto_ItemId, 0);
			string newText;
			if (this.ItemData.Proto_IsUnlock)
			{
				if (itemCountByConfigId < this.ItemData.Proto_ItemNum)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
					defaultInterpolatedStringHandler.AppendLiteral("<color=#dc0300>");
					defaultInterpolatedStringHandler.AppendFormatted<int>(itemCountByConfigId);
					defaultInterpolatedStringHandler.AppendLiteral("</color>");
					newText = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
					defaultInterpolatedStringHandler.AppendLiteral("<color=#ffffff>");
					defaultInterpolatedStringHandler.AppendFormatted<int>(itemCountByConfigId);
					defaultInterpolatedStringHandler.AppendLiteral("</color>");
					newText = defaultInterpolatedStringHandler.ToStringAndClear();
				}
			}
			else
			{
				newText = "<color=#ffffff>--</color>";
			}
			base.GetText(1).SetText(newText, true);
		}

		// Token: 0x0602D4F0 RID: 185584 RVA: 0x00CB03AC File Offset: 0x00CAE5AC
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

		// Token: 0x0602D4F1 RID: 185585 RVA: 0x00CB040C File Offset: 0x00CAE60C
		private void RefreshQuality()
		{
			if (this.ItemData.Proto_IsUnlock)
			{
				base.GetSprite(4).SetUIActive(true);
				base.SetItemQualityIcon(base.GetSprite(4), this.ItemInfo.Value.Id, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
				return;
			}
			base.GetSprite(4).SetUIActive(false);
		}

		// Token: 0x0602D4F2 RID: 185586 RVA: 0x00CB046C File Offset: 0x00CAE66C
		public void BindOnClickedCallback(Action<ISingleItemInfo> onItemButtonClicked)
		{
			this.OnClickedCallback = onItemButtonClicked;
		}

		// Token: 0x0602D4F3 RID: 185587 RVA: 0x00CB0475 File Offset: 0x00CAE675
		protected void OnClick(EToggleState state)
		{
			if (this.OnClickedCallback != null)
			{
				this.OnClickedCallback(this.ItemData);
			}
		}

		// Token: 0x04018486 RID: 99462
		[Nullable(2)]
		protected ISingleItemInfo ItemData;

		// Token: 0x04018487 RID: 99463
		protected ItemInfo? ItemInfo;

		// Token: 0x04018488 RID: 99464
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ISingleItemInfo> OnClickedCallback;

		// Token: 0x0200A27B RID: 41595
		[NullableContext(0)]
		private class EMaterialDefine
		{
			// Token: 0x040326C2 RID: 206530
			public const int MaterialExtendToggle = 0;

			// Token: 0x040326C3 RID: 206531
			public const int HaveText = 1;

			// Token: 0x040326C4 RID: 206532
			public const int NeedText = 2;

			// Token: 0x040326C5 RID: 206533
			public const int MaterialIconTexture = 3;

			// Token: 0x040326C6 RID: 206534
			public const int MaterialQualitySprite = 4;
		}
	}
}
