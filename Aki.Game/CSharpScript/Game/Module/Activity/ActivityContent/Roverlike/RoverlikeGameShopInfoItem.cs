using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050D7 RID: 20695
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeGameShopInfoItem : UiPanelBase
	{
		// Token: 0x06033C97 RID: 212119 RVA: 0x00E7E4B2 File Offset: 0x00E7C6B2
		[NullableContext(1)]
		public void BindOnConfirm(Action cb)
		{
			this.OnConfirm = cb;
		}

		// Token: 0x06033C98 RID: 212120 RVA: 0x00E7E4BB File Offset: 0x00E7C6BB
		public void SetCurrencyContext(int insideCurrencyItemId)
		{
			this.InsideCurrencyItemId = insideCurrencyItemId;
		}

		// Token: 0x06033C99 RID: 212121 RVA: 0x00E7E4C4 File Offset: 0x00E7C6C4
		public void Refresh(IRoverlikeGameShopGridData data)
		{
			if (data == null)
			{
				base.SetUiActive(false);
				return;
			}
			RoverRogueItem? itemConfig = RoverlikeConfig.Instance.GetItemConfig(data.ShowItemId);
			if (itemConfig == null)
			{
				base.SetUiActive(false);
				return;
			}
			base.SetUiActive(true);
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, itemConfig.Value.Name, Array.Empty<object>());
			UUIText text2 = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(text2, itemConfig.Value.Type, Array.Empty<object>());
			UUIText text3 = base.GetText(2);
			LguiUtil.Instance.SetLocalTextNew(text3, itemConfig.Value.Desc, itemConfig.Value.DescParams());
			UUIText text4 = base.GetText(8);
			LguiUtil.Instance.SetLocalTextNew(text4, "RoverRogue_ItemDurationOutGame", new <>z__ReadOnlySingleElementList<object>(itemConfig.Value.RoomPassedRequired));
			text4.SetUIActive(itemConfig.Value.Classify == 2);
			int gold = RoverlikeModel.Instance.Gold;
			RoverlikeGameShopCostItem storeCost = this.StoreCost;
			if (storeCost != null)
			{
				storeCost.Refresh(data, this.InsideCurrencyItemId, gold);
			}
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(!data.IsBought);
		}

		// Token: 0x06033C9A RID: 212122 RVA: 0x00E7E616 File Offset: 0x00E7C816
		private void OnClickConfirm()
		{
			Action onConfirm = this.OnConfirm;
			if (onConfirm == null)
			{
				return;
			}
			onConfirm();
		}

		// Token: 0x06033C9B RID: 212123 RVA: 0x00E7E628 File Offset: 0x00E7C828
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033C9C RID: 212124 RVA: 0x00E7E77C File Offset: 0x00E7C97C
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeGameShopInfoItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeGameShopInfoItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033C9D RID: 212125 RVA: 0x00E7E7BF File Offset: 0x00E7C9BF
		protected override void OnStart()
		{
			ButtonItem confirmBtn = this.ConfirmBtn;
			if (confirmBtn == null)
			{
				return;
			}
			confirmBtn.SetFunction(delegate(int _)
			{
				this.OnClickConfirm();
			});
		}

		// Token: 0x06033C9E RID: 212126 RVA: 0x00E7E7DD File Offset: 0x00E7C9DD
		protected override void OnBeforeDestroy()
		{
			this.OnConfirm = null;
		}

		// Token: 0x0401B710 RID: 112400
		private ButtonItem ConfirmBtn;

		// Token: 0x0401B711 RID: 112401
		private RoverlikeGameShopCostItem StoreCost;

		// Token: 0x0401B712 RID: 112402
		private Action OnConfirm;

		// Token: 0x0401B713 RID: 112403
		private int InsideCurrencyItemId;

		// Token: 0x0200AD9E RID: 44446
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035A4C RID: 219724
			public const int TxtName = 0;

			// Token: 0x04035A4D RID: 219725
			public const int TxtType = 1;

			// Token: 0x04035A4E RID: 219726
			public const int TxtDesc = 2;

			// Token: 0x04035A4F RID: 219727
			public const int BtnConfirm = 3;

			// Token: 0x04035A50 RID: 219728
			public const int ItemStoreCost = 4;

			// Token: 0x04035A51 RID: 219729
			public const int TextureCostIcon = 5;

			// Token: 0x04035A52 RID: 219730
			public const int TxtCost = 6;

			// Token: 0x04035A53 RID: 219731
			public const int TxtPlace = 7;

			// Token: 0x04035A54 RID: 219732
			public const int TxtItemRound = 8;
		}
	}
}
