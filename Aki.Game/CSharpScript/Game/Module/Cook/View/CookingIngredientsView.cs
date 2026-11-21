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
	// Token: 0x02004AEE RID: 19182
	[NullableContext(1)]
	[Nullable(0)]
	public class CookingIngredientsView : UiPanelBase
	{
		// Token: 0x0602FFA9 RID: 196521 RVA: 0x00D61F10 File Offset: 0x00D60110
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

		// Token: 0x0602FFAA RID: 196522 RVA: 0x00D6207C File Offset: 0x00D6027C
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

		// Token: 0x0602FFAB RID: 196523 RVA: 0x00D62120 File Offset: 0x00D60320
		protected override UniTask OnBeforeStartAsync()
		{
			CookingIngredientsView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CookingIngredientsView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFAC RID: 196524 RVA: 0x00D62163 File Offset: 0x00D60363
		protected override void OnStart()
		{
			this.VerticalTextView.OnChangeMaterialSelectionDelegate = new Action(this.OnChangeMaterialSelection);
			base.GetButton(3).SetCanClickWhenDisable(true);
		}

		// Token: 0x0602FFAD RID: 196525 RVA: 0x00D62189 File Offset: 0x00D60389
		public void RefreshTips(ICookingData itemData)
		{
			this.CookingItemData = itemData;
			this.MachiningItemData = null;
			this.RefreshCommon();
			this.RefreshCooking();
		}

		// Token: 0x0602FFAE RID: 196526 RVA: 0x00D621A5 File Offset: 0x00D603A5
		public void RefreshTips(IMachiningData itemData)
		{
			this.MachiningItemData = itemData;
			this.CookingItemData = null;
			this.RefreshCommon();
			this.RefreshMachining();
		}

		// Token: 0x0602FFAF RID: 196527 RVA: 0x00D621C1 File Offset: 0x00D603C1
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

		// Token: 0x0602FFB0 RID: 196528 RVA: 0x00D621E4 File Offset: 0x00D603E4
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

		// Token: 0x0602FFB1 RID: 196529 RVA: 0x00D6220F File Offset: 0x00D6040F
		private void RefreshCommon()
		{
			this.RefreshName();
		}

		// Token: 0x0602FFB2 RID: 196530 RVA: 0x00D62218 File Offset: 0x00D60418
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

		// Token: 0x0602FFB3 RID: 196531 RVA: 0x00D622B4 File Offset: 0x00D604B4
		private void OnChangeMaterialSelection()
		{
			this.CheckCanInteractConfirm();
		}

		// Token: 0x0602FFB4 RID: 196532 RVA: 0x00D622BC File Offset: 0x00D604BC
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

		// Token: 0x0602FFB5 RID: 196533 RVA: 0x00D62370 File Offset: 0x00D60570
		public void RefreshCooking()
		{
			CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(this.CookingItemData.ItemId);
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(cookFormulaById.FoodItemId, 0);
			LguiUtil.Instance.SetLocalText(base.GetText(1), "Have", new <>z__ReadOnlySingleElementList<object>(commonItemCount));
			this.VerticalTextView.RefreshCooking(this.CookingItemData);
			this.CheckCanInteractConfirm();
			LguiUtil.Instance.SetLocalText(base.GetText(5), "CookButtonText", Array.Empty<object>());
		}

		// Token: 0x0602FFB6 RID: 196534 RVA: 0x00D623FC File Offset: 0x00D605FC
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

		// Token: 0x0602FFB7 RID: 196535 RVA: 0x00D62530 File Offset: 0x00D60730
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

		// Token: 0x0401975C RID: 104284
		[Nullable(2)]
		private ICookingData CookingItemData;

		// Token: 0x0401975D RID: 104285
		[Nullable(2)]
		private IMachiningData MachiningItemData;

		// Token: 0x0401975E RID: 104286
		[Nullable(2)]
		private CookingIngredientsVerticalView VerticalTextView;

		// Token: 0x0200A753 RID: 42835
		[NullableContext(0)]
		private enum ECookIngredientsDefine
		{
			// Token: 0x04033B37 RID: 211767
			TxtName,
			// Token: 0x04033B38 RID: 211768
			TxtHaveNum,
			// Token: 0x04033B39 RID: 211769
			PanelBuy,
			// Token: 0x04033B3A RID: 211770
			BtnConfirm,
			// Token: 0x04033B3B RID: 211771
			PanelVertical,
			// Token: 0x04033B3C RID: 211772
			TxtConfirm,
			// Token: 0x04033B3D RID: 211773
			PnlActivate,
			// Token: 0x04033B3E RID: 211774
			TxtActivate
		}
	}
}
