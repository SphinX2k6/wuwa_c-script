using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02005B0D RID: 23309
	[NullableContext(1)]
	[Nullable(0)]
	public class CookingIngredientsView : UiPanelBase
	{
		// Token: 0x0603B037 RID: 241719 RVA: 0x00E111F8 File Offset: 0x00E0F3F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirmButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B038 RID: 241720 RVA: 0x00E11364 File Offset: 0x00E0F564
		private void OnClickConfirmButton()
		{
			if (!base.GetButton(3).GetSelfInteractive())
			{
				GenericPromptController.Instance.ShowPromptByCode("MaterialShort", Array.Empty<object>());
				return;
			}
			if (CookModel.Instance.CurrentCookListType == ECookListType.Cooking)
			{
				CookModel.Instance.CleanAddExp();
				CookController.Instance.SendCookFoodRequest(this.CookingItemData.ItemId, CookModel.Instance.CurrentCookRoleId.Value, this.VerticalTextView.CurrentSetCount);
				return;
			}
			CookController.Instance.SendFoodProcessRequest(this.MachiningItemData.ItemId, CookModel.Instance.GetTmpMachiningItemList(), this.VerticalTextView.CurrentSetCount);
		}

		// Token: 0x0603B039 RID: 241721 RVA: 0x00E11408 File Offset: 0x00E0F608
		protected override UniTask OnBeforeStartAsync()
		{
			CookingIngredientsView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CookingIngredientsView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B03A RID: 241722 RVA: 0x00E1144B File Offset: 0x00E0F64B
		protected override void OnStart()
		{
			this.VerticalTextView.OnChangeMaterialSelectionDelegate = new Action(this.OnChangeMaterialSelection);
			base.GetButton(3).SetCanClickWhenDisable(true);
		}

		// Token: 0x0603B03B RID: 241723 RVA: 0x00E11471 File Offset: 0x00E0F671
		public void RefreshTips(ICookingData itemData)
		{
			this.CookingItemData = itemData;
			this.MachiningItemData = null;
			this.RefreshCommon();
			this.RefreshCooking();
		}

		// Token: 0x0603B03C RID: 241724 RVA: 0x00E1148D File Offset: 0x00E0F68D
		public void RefreshTips(IMachiningData itemData)
		{
			this.MachiningItemData = itemData;
			this.CookingItemData = null;
			this.RefreshCommon();
			this.RefreshMachining();
		}

		// Token: 0x0603B03D RID: 241725 RVA: 0x00E114A9 File Offset: 0x00E0F6A9
		public void OnSecondTimerRefresh()
		{
			if (this.CookingItemData == null && this.MachiningItemData == null)
			{
				return;
			}
			CookingIngredientsVerticalView verticalTextView = this.VerticalTextView;
			if (verticalTextView == null)
			{
				return;
			}
			verticalTextView.OnSecondTimerRefresh();
		}

		// Token: 0x0603B03E RID: 241726 RVA: 0x00E114CC File Offset: 0x00E0F6CC
		public void RefreshTipsWithSavedData()
		{
			if (this.CookingItemData != null)
			{
				this.RefreshTips(this.CookingItemData);
				return;
			}
			if (this.MachiningItemData != null)
			{
				this.RefreshTips(this.MachiningItemData);
			}
		}

		// Token: 0x0603B03F RID: 241727 RVA: 0x00E114F7 File Offset: 0x00E0F6F7
		private void RefreshCommon()
		{
			this.RefreshName();
		}

		// Token: 0x0603B040 RID: 241728 RVA: 0x00E11500 File Offset: 0x00E0F700
		private void RefreshName()
		{
			if (this.CookingItemData != null)
			{
				CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(this.CookingItemData.ItemId);
				string newText = ItemConfig.Instance.GetItemName(cookFormulaById.FoodItemId) ?? "";
				base.GetText(0).SetText(newText, true);
				return;
			}
			if (this.MachiningItemData != null)
			{
				CookProcessed cookProcessedById = CookConfig.Instance.GetCookProcessedById(this.MachiningItemData.ItemId);
				string newText2 = ItemConfig.Instance.GetItemName(cookProcessedById.FinalItemId) ?? "";
				base.GetText(0).SetText(newText2, true);
			}
		}

		// Token: 0x0603B041 RID: 241729 RVA: 0x00E1159C File Offset: 0x00E0F79C
		private void OnChangeMaterialSelection()
		{
			this.CheckCanInteractConfirm();
		}

		// Token: 0x0603B042 RID: 241730 RVA: 0x00E115A4 File Offset: 0x00E0F7A4
		private void RefreshMachining()
		{
			CookProcessed cookProcessedById = CookConfig.Instance.GetCookProcessedById(this.MachiningItemData.ItemId);
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(cookProcessedById.FinalItemId, 0);
			LguiUtil.Instance.SetLocalText(base.GetText(1), "Have", new <>z__ReadOnlySingleElementList<object>(commonItemCount));
			this.VerticalTextView.RefreshMachining(this.MachiningItemData);
			this.CheckCanInteractConfirm();
			if (this.MachiningItemData.IsUnLock)
			{
				LguiUtil.Instance.SetLocalText(base.GetText(5), "CookButtonText", Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalText(base.GetText(5), "Research", Array.Empty<object>());
		}

		// Token: 0x0603B043 RID: 241731 RVA: 0x00E11658 File Offset: 0x00E0F858
		public void RefreshCooking()
		{
			CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(this.CookingItemData.ItemId);
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(cookFormulaById.FoodItemId, 0);
			LguiUtil.Instance.SetLocalText(base.GetText(1), "Have", new <>z__ReadOnlySingleElementList<object>(commonItemCount));
			this.VerticalTextView.RefreshCooking(this.CookingItemData);
			this.CheckCanInteractConfirm();
			LguiUtil.Instance.SetLocalText(base.GetText(5), "CookButtonText", Array.Empty<object>());
		}

		// Token: 0x0603B044 RID: 241732 RVA: 0x00E116E4 File Offset: 0x00E0F8E4
		private void CheckCanInteractConfirm()
		{
			ICookingData cookingItemData = this.CookingItemData;
			bool flag;
			if (cookingItemData == null)
			{
				IMachiningData machiningItemData = this.MachiningItemData;
				flag = (machiningItemData != null && machiningItemData.IsUnLock);
			}
			else
			{
				flag = cookingItemData.IsUnLock;
			}
			bool flag2 = flag;
			bool isCoinEnough = true;
			bool flag3 = true;
			bool flag4;
			if (CookModel.Instance.CurrentCookListType == ECookListType.Cooking)
			{
				flag4 = CookModel.Instance.CheckMaterialEnough(this.CookingItemData.ItemId);
				isCoinEnough = CookModel.Instance.CheckCoinEnough(this.CookingItemData.ItemId);
				flag3 = CookModel.Instance.CheckLimitCount(this.CookingItemData.ItemId);
			}
			else
			{
				bool flag5 = true;
				using (List<ISingleItemInfo>.Enumerator enumerator = CookModel.Instance.GetTmpMachiningItemList().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!enumerator.Current.Proto_IsUnlock)
						{
							flag5 = false;
						}
					}
				}
				flag4 = (CookModel.Instance.CheckCanProcessedNew(this.MachiningItemData.ItemId) && flag5);
			}
			base.GetText(7).SetText(this.GetDisableText(flag2, flag4, isCoinEnough, flag3), true);
			base.GetItem(6).SetUIActive(!flag4 || !flag3 || !flag2);
			base.GetButton(3).GetRootComponent().SetUIActive(flag4 && flag3 && flag2);
		}

		// Token: 0x0603B045 RID: 241733 RVA: 0x00E11818 File Offset: 0x00E0FA18
		private string GetDisableText(bool isUnlock, bool isEnable, bool isCoinEnough, bool isCookCountEnough)
		{
			if (!isUnlock)
			{
				return ConfigMultiTextLang.GetLocalTextNew("GenericPrompt_Unlocked_TipsText", null);
			}
			if (!isEnable)
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew("LackMakeMaterial", null);
				if (!isCoinEnough)
				{
					return StringUtils.Format(localTextNew, new string[]
					{
						ItemConfig.Instance.GetItemName(CookController.Instance.CookCoinId)
					});
				}
				return StringUtils.Format(localTextNew, new string[]
				{
					ConfigMultiTextLang.GetLocalTextNew("Material_Text", null)
				});
			}
			else
			{
				if (isCookCountEnough)
				{
					return "";
				}
				string refreshLimitTime = CookModel.Instance.GetRefreshLimitTime();
				if (refreshLimitTime != null)
				{
					return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("LackMakeCount", null), new string[]
					{
						refreshLimitTime
					});
				}
				return ConfigMultiTextLang.GetLocalTextNew("LackMakeCountWithoutTime", null);
			}
		}

		// Token: 0x0401ECA0 RID: 126112
		[Nullable(2)]
		private ICookingData CookingItemData;

		// Token: 0x0401ECA1 RID: 126113
		[Nullable(2)]
		private IMachiningData MachiningItemData;

		// Token: 0x0401ECA2 RID: 126114
		[Nullable(2)]
		private CookingIngredientsVerticalView VerticalTextView;

		// Token: 0x0200BD4A RID: 48458
		[NullableContext(0)]
		private enum ECookIngredientsDefine
		{
			// Token: 0x0403916B RID: 233835
			TxtName,
			// Token: 0x0403916C RID: 233836
			TxtHaveNum,
			// Token: 0x0403916D RID: 233837
			PanelBuy,
			// Token: 0x0403916E RID: 233838
			BtnConfirm,
			// Token: 0x0403916F RID: 233839
			PanelVertical,
			// Token: 0x04039170 RID: 233840
			TxtConfirm,
			// Token: 0x04039171 RID: 233841
			PnlActivate,
			// Token: 0x04039172 RID: 233842
			TxtActivate
		}
	}
}
