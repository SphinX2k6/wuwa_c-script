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
	// Token: 0x02006159 RID: 24921
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeGameShopInfoItem : UiPanelBase
	{
		// Token: 0x0603EFD7 RID: 258007 RVA: 0x00F375DE File Offset: 0x00F357DE
		[NullableContext(1)]
		public void BindOnConfirm(Action cb)
		{
			this.OnConfirm = cb;
		}

		// Token: 0x0603EFD8 RID: 258008 RVA: 0x00F375E7 File Offset: 0x00F357E7
		public void SetCurrencyContext(int insideCurrencyItemId)
		{
			this.InsideCurrencyItemId = insideCurrencyItemId;
		}

		// Token: 0x0603EFD9 RID: 258009 RVA: 0x00F375F0 File Offset: 0x00F357F0
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

		// Token: 0x0603EFDA RID: 258010 RVA: 0x00F37742 File Offset: 0x00F35942
		private void OnClickConfirm()
		{
			Action onConfirm = this.OnConfirm;
			if (onConfirm == null)
			{
				return;
			}
			onConfirm();
		}

		// Token: 0x0603EFDB RID: 258011 RVA: 0x00F37754 File Offset: 0x00F35954
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

		// Token: 0x0603EFDC RID: 258012 RVA: 0x00F378A8 File Offset: 0x00F35AA8
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeGameShopInfoItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeGameShopInfoItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EFDD RID: 258013 RVA: 0x00F378EB File Offset: 0x00F35AEB
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

		// Token: 0x0603EFDE RID: 258014 RVA: 0x00F37909 File Offset: 0x00F35B09
		protected override void OnBeforeDestroy()
		{
			this.OnConfirm = null;
		}

		// Token: 0x04020DE3 RID: 134627
		private ButtonItem ConfirmBtn;

		// Token: 0x04020DE4 RID: 134628
		private RoverlikeGameShopCostItem StoreCost;

		// Token: 0x04020DE5 RID: 134629
		private Action OnConfirm;

		// Token: 0x04020DE6 RID: 134630
		private int InsideCurrencyItemId;

		// Token: 0x0200C3B7 RID: 50103
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B0EB RID: 241899
			public const int TxtName = 0;

			// Token: 0x0403B0EC RID: 241900
			public const int TxtType = 1;

			// Token: 0x0403B0ED RID: 241901
			public const int TxtDesc = 2;

			// Token: 0x0403B0EE RID: 241902
			public const int BtnConfirm = 3;

			// Token: 0x0403B0EF RID: 241903
			public const int ItemStoreCost = 4;

			// Token: 0x0403B0F0 RID: 241904
			public const int TextureCostIcon = 5;

			// Token: 0x0403B0F1 RID: 241905
			public const int TxtCost = 6;

			// Token: 0x0403B0F2 RID: 241906
			public const int TxtPlace = 7;

			// Token: 0x0403B0F3 RID: 241907
			public const int TxtItemRound = 8;
		}
	}
}
