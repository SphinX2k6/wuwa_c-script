using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Module.Manufacture.Common.Item;
using CSharpScript.Game.Module.Manufacture.Compose;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Forging.View
{
	// Token: 0x02004629 RID: 17961
	[NullableContext(1)]
	[Nullable(0)]
	public class ForgingRootView : UiViewBase
	{
		// Token: 0x0602D1F2 RID: 184818 RVA: 0x00C9D930 File Offset: 0x00C9BB30
		public ForgingRootView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602D1F3 RID: 184819 RVA: 0x00C9D94C File Offset: 0x00C9BB4C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.GetForgingData, new Action(this.ShowForgingRootView));
			EventSystem.Instance.Add(EEventName.OpenHelpRole, new Action<int>(this.OpenRoleView));
			EventSystem.Instance.Add(EEventName.ForgingSuccess, new Action(this.OnForgingResponse));
			EventSystem.Instance.Add(EEventName.ForgingFail, new Action(this.OnForgingResponse));
			this.RefreshTimer = TimerSystem.Instance.Forever(new TTimerAction(this.OnSecondTimerRefresh), 1000f, 1f, null, null, true);
		}

		// Token: 0x0602D1F4 RID: 184820 RVA: 0x00C9D9F4 File Offset: 0x00C9BBF4
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.GetForgingData, new Action(this.ShowForgingRootView));
			EventSystem.Instance.Remove(EEventName.OpenHelpRole, new Action<int>(this.OpenRoleView));
			EventSystem.Instance.Remove(EEventName.ForgingSuccess, new Action(this.RefreshItemScrollView));
			EventSystem.Instance.Remove(EEventName.ForgingFail, new Action(this.RefreshItemScrollView));
			if (this.RefreshTimer != null && TimerSystem.Instance.Has(this.RefreshTimer))
			{
				TimerSystem.Instance.Remove(this.RefreshTimer);
				this.RefreshTimer = null;
			}
		}

		// Token: 0x0602D1F5 RID: 184821 RVA: 0x00C9DAA3 File Offset: 0x00C9BCA3
		private void OnSecondTimerRefresh(float _)
		{
			this.RefreshBottomText();
			if (this.CheckIsLimitCountRefresh())
			{
				this.<OnSecondTimerRefresh>g__Temp|26_0().Forget();
				return;
			}
			if (this.CheckHasItemTimeOut())
			{
				this.<OnSecondTimerRefresh>g__Temp|26_1().Forget();
			}
		}

		// Token: 0x0602D1F6 RID: 184822 RVA: 0x00C9DAD2 File Offset: 0x00C9BCD2
		private void RefreshBottomText()
		{
			this.NeedShowBottomText = false;
			this.RefreshItemRefreshTime();
			this.RefreshLimitCount();
			UUIItem item = base.GetItem(29);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.NeedShowBottomText);
		}

		// Token: 0x0602D1F7 RID: 184823 RVA: 0x00C9DB00 File Offset: 0x00C9BD00
		private void RefreshItemRefreshTime()
		{
			string refreshLimitTime = ForgingModel.Instance.GetRefreshLimitTime();
			if (!string.IsNullOrEmpty(refreshLimitTime))
			{
				this.NeedShowBottomText = true;
				UUIText text = base.GetText(26);
				if (text != null)
				{
					text.SetUIActive(true);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(26), "RefreshTime", new <>z__ReadOnlySingleElementList<object>(refreshLimitTime));
				return;
			}
			UUIText text2 = base.GetText(26);
			if (text2 == null)
			{
				return;
			}
			text2.SetUIActive(false);
		}

		// Token: 0x0602D1F8 RID: 184824 RVA: 0x00C9DB6C File Offset: 0x00C9BD6C
		private bool CheckIsLimitCountRefresh()
		{
			return ForgingModel.Instance.GetRefreshLimitTimeValue() <= 0.0;
		}

		// Token: 0x0602D1F9 RID: 184825 RVA: 0x00C9DB88 File Offset: 0x00C9BD88
		private bool CheckHasItemTimeOut()
		{
			List<IWeaponForgingData> itemList = this.GetItemList(true);
			if (itemList == null)
			{
				return false;
			}
			foreach (IWeaponForgingData weaponForgingData in itemList)
			{
				if (weaponForgingData.ExistEndTime > 0.0 && !TimeUtil.Instance.IsInTimeSpan(weaponForgingData.ExistStartTime, weaponForgingData.ExistEndTime))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602D1FA RID: 184826 RVA: 0x00C9DC0C File Offset: 0x00C9BE0C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 35;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(34, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(27, new Action(this.OnClickConfirmButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602D1FB RID: 184827 RVA: 0x00C9E110 File Offset: 0x00C9C310
		protected override UniTask OnBeforeStartAsync()
		{
			ForgingRootView.<OnBeforeStartAsync>d__32 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ForgingRootView.<OnBeforeStartAsync>d__32>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D1FC RID: 184828 RVA: 0x00C9E154 File Offset: 0x00C9C354
		protected override void OnStart()
		{
			this.FilterComponent = new FilterEntrance<IWeaponForgingData>(base.GetItem(3), new TUpdateDataListFunction<IWeaponForgingData>(this.OnFilterSortRefresh));
			this.SortComponent = new SortEntrance<IWeaponForgingData>(base.GetItem(4), new TUpdateDataListFunction<IWeaponForgingData>(this.OnFilterSortRefresh));
			this.FilterComponent.SetActive(false);
			this.ForgingItemScrollView = new LoopScrollView<ForgingMediumItemGrid, IWeaponForgingData>(base.GetLoopScrollViewComponent(1), base.GetLoopScrollViewComponent(1).TemplateGrid, new Func<ForgingMediumItemGrid>(this.OnGridProxyCreate), false);
			ForgingController.Instance.RegisterCurrentInteractionEntity();
			CommonManager.Instance.SetCurrentSystem(ESystemType.ForgingSystem);
			ForgingModel.Instance.CurrentForgingViewType = EForgingViewType.ForgingMainType;
			ForgingModel.Instance.CurrentInteractCreatureDataLongId = InteractionModel.Instance.InteractCreatureDataLongId;
			if (InteractionModel.Instance.CurrentInteractEntityId == null)
			{
				Log.Instance.Info(ELogModule.Forging, ELogAuthor.WZ, "[LevelEventOpenSystem] 打开合成界面时找不到交互对象，直接关闭界面", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.CloseMe(null);
			}
		}

		// Token: 0x0602D1FD RID: 184829 RVA: 0x00C9E247 File Offset: 0x00C9C447
		protected override void OnBeforeShow()
		{
			this.UpdateForgingItemScroll();
			this.ShowForgingRootView();
		}

		// Token: 0x0602D1FE RID: 184830 RVA: 0x00C9E258 File Offset: 0x00C9C458
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnExecuteUiCameraSequenceEvent, new Action<string>(this.OnExecuteUiCameraSequenceEvent));
			this.FilterComponent.Destroy(null);
			this.SortComponent.Destroy(null);
			ForgingController.Instance.PlayLeaveForgingAudio();
			ForgingController.Instance.ClearCurrentInteractionEntityDisplay();
			ForgingModel.Instance.CurrentForgingRoleId = 0;
		}

		// Token: 0x0602D1FF RID: 184831 RVA: 0x00C9E2B8 File Offset: 0x00C9C4B8
		private void ShowForgingRootView()
		{
			this.SortComponent.UpdateData(EFilterSortGroupId.ForgingList, this.GetItemList(true), Array.Empty<object>());
		}

		// Token: 0x0602D200 RID: 184832 RVA: 0x00C9E2D3 File Offset: 0x00C9C4D3
		private void OnExecuteUiCameraSequenceEvent(string sequenceEventName)
		{
			if (sequenceEventName != "OnBlackScreen")
			{
				return;
			}
			ForgingController.Instance.PlayForgingEnterDisplay(null);
		}

		// Token: 0x0602D201 RID: 184833 RVA: 0x00C9E2EE File Offset: 0x00C9C4EE
		private ForgingMediumItemGrid OnGridProxyCreate()
		{
			ForgingMediumItemGrid forgingMediumItemGrid = new ForgingMediumItemGrid();
			forgingMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnComposeItemClick));
			return forgingMediumItemGrid;
		}

		// Token: 0x0602D202 RID: 184834 RVA: 0x00C9E308 File Offset: 0x00C9C508
		private void OnComposeItemClick(MediumItemGridExtendCallback callbackParameter)
		{
			IWeaponForgingData weaponForgingData = (IWeaponForgingData)callbackParameter.Data;
			this.ForgingItemScrollView.DeselectCurrentGridProxy(false);
			this.SelectedForgingIndex = this.WeaponForgingDataList.IndexOf(weaponForgingData);
			this.SelectedForgingData = weaponForgingData;
			if (!this.ForgingItemScrollView.IsGridDisplaying(this.SelectedForgingIndex))
			{
				return;
			}
			if (weaponForgingData.IsNew)
			{
				weaponForgingData.IsNew = false;
				NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.ForgingLevelKey, weaponForgingData.ItemId);
			}
			this.ForgingItemScrollView.SelectGridProxy(this.SelectedForgingIndex, false);
			this.ForgingItemScrollView.RefreshGridProxy(this.SelectedForgingIndex);
			this.RefreshItemTips(weaponForgingData);
			this.CheckCanInteractConfirm(weaponForgingData);
			this.RefreshForging(weaponForgingData);
		}

		// Token: 0x0602D203 RID: 184835 RVA: 0x00C9E3B4 File Offset: 0x00C9C5B4
		private void RefreshItemTips(IWeaponForgingData data)
		{
			ForgeFormula? forgeFormulaById = ForgingConfig.Instance.GetForgeFormulaById(data.ItemId);
			WeaponConf? weaponConfigByItemId = global::WeaponConfig.Instance.GetWeaponConfigByItemId(forgeFormulaById.Value.ItemId);
			base.GetText(8).ShowTextNew(((weaponConfigByItemId != null) ? weaponConfigByItemId.GetValueOrDefault().WeaponName : null) ?? "");
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(forgeFormulaById.Value.ItemId, 0);
			LguiUtil.Instance.SetLocalText(base.GetText(7), "Have", new <>z__ReadOnlySingleElementList<object>(itemCountByConfigId));
		}

		// Token: 0x0602D204 RID: 184836 RVA: 0x00C9E45C File Offset: 0x00C9C65C
		private void CheckCanInteractConfirm(IWeaponForgingData data)
		{
			bool flag = true;
			ForgingModel instance = ForgingModel.Instance;
			bool flag2 = instance.CheckUnlock(data);
			bool isCoinEnough = instance.CheckCoinEnough(data.ItemId);
			bool flag3 = instance.CheckLimitCount(data);
			string textById;
			if (flag2)
			{
				textById = TextConfig.Instance.GetTextById("WeaponMaking");
				flag = instance.CheckMaterialEnough(data.ItemId);
			}
			else
			{
				textById = TextConfig.Instance.GetTextById("UnlockWeapon");
			}
			base.GetText(30).SetText(textById, true);
			base.GetText(31).SetText(this.GetDisableText(flag2, flag, isCoinEnough, flag3), true);
			base.GetItem(28).SetUIActive(!flag2 || !flag || !flag3);
			base.GetButton(27).RootUIComp.Get().SetUIActive(flag2 && flag && flag3);
		}

		// Token: 0x0602D205 RID: 184837 RVA: 0x00C9E52C File Offset: 0x00C9C72C
		private string GetDisableText(bool isUnlock, bool isMatEnough, bool isCoinEnough, bool isMakeCountEnough)
		{
			if (!isUnlock)
			{
				return ConfigMultiTextLang.GetLocalTextNew("GenericPrompt_Unlocked_TipsText", null);
			}
			if (!isMatEnough)
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew("LackMakeMaterial", null);
				if (!isCoinEnough)
				{
					return StringUtils.Format(localTextNew, new string[]
					{
						CSharpScript.Game.Module.Item.ItemConfig.Instance.GetItemName(ForgingController.Instance.ForgingCostId)
					});
				}
				return StringUtils.Format(localTextNew, new string[]
				{
					ConfigMultiTextLang.GetLocalTextNew("Material_Text", null)
				});
			}
			else
			{
				if (isMakeCountEnough)
				{
					return "";
				}
				string refreshLimitTime = ForgingModel.Instance.GetRefreshLimitTime();
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

		// Token: 0x0602D206 RID: 184838 RVA: 0x00C9E5D7 File Offset: 0x00C9C7D7
		private ForgingRootView.StarItem InitStarItem()
		{
			return new ForgingRootView.StarItem();
		}

		// Token: 0x0602D207 RID: 184839 RVA: 0x00C9E5E0 File Offset: 0x00C9C7E0
		private ManufactureMaterialItem OnMaterialItemCreate()
		{
			ManufactureMaterialItem manufactureMaterialItem = new ManufactureMaterialItem();
			manufactureMaterialItem.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			manufactureMaterialItem.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback callbackParameter)
			{
				ISingleItemInfo singleItemInfo = (ISingleItemInfo)callbackParameter.Data;
				ItemController.Instance.OpenItemTipsByItemId(singleItemInfo.Proto_ItemId, true, null, false);
			});
			return manufactureMaterialItem;
		}

		// Token: 0x0602D208 RID: 184840 RVA: 0x00C9E63C File Offset: 0x00C9C83C
		private void SetSum(int sum)
		{
			this.Count = sum;
			if (this.ItemData != null)
			{
				int maxCreateCount = ForgingController.Instance.GetMaxCreateCount(this.ItemData.ItemId);
				this.NumberSelect.SetAddButtonInteractive(sum < maxCreateCount);
				this.NumberSelect.SetReduceButtonInteractive(sum > 1);
			}
			string numberSelectTipsText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_ItemSelectForgeQuantityTip_text", null), new string[]
			{
				this.Count.ToString()
			});
			this.NumberSelect.SetNumberSelectTipsText(numberSelectTipsText);
			this.RefreshMaterialNeedNum();
		}

		// Token: 0x0602D209 RID: 184841 RVA: 0x00C9E6C4 File Offset: 0x00C9C8C4
		private void RefreshMaterialNeedNum()
		{
			this.RefreshCost(this.HasCoin, this.SingleNeedCoinCount * this.Count);
			GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> materialScrollView = this.MaterialScrollView;
			List<ManufactureMaterialItem> list = (materialScrollView != null) ? materialScrollView.GetScrollItemList() : null;
			if (list == null)
			{
				return;
			}
			foreach (ManufactureMaterialItem manufactureMaterialItem in list)
			{
				manufactureMaterialItem.SetTimes(this.Count);
			}
		}

		// Token: 0x0602D20A RID: 184842 RVA: 0x00C9E748 File Offset: 0x00C9C948
		private void RefreshCommon(IWeaponForgingData data)
		{
			this.ItemData = data;
			this.Count = 1;
			int maxCreateCount = CommonManager.Instance.GetMaxCreateCount(this.ItemData.ItemId);
			this.NumberSelect.Refresh(maxCreateCount);
			this.NumberSelect.SetAddReduceButtonActive(true);
			this.NumberSelect.SetReduceButtonInteractive(false);
			ForgeFormula? forgeFormulaById = ForgingConfig.Instance.GetForgeFormulaById(data.ItemId);
			WeaponConf? weaponItemConfig = InventoryConfig.Instance.GetWeaponItemConfig(forgeFormulaById.Value.ItemId);
			string[] weaponConfigDescParams = WeaponModel.Instance.GetWeaponConfigDescParams(weaponItemConfig.Value, 1);
			string newText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(weaponItemConfig.Value.Desc, null), weaponConfigDescParams);
			base.GetText(20).SetText(newText, true);
		}

		// Token: 0x0602D20B RID: 184843 RVA: 0x00C9E80C File Offset: 0x00C9CA0C
		[return: TupleElementNames(new string[]
		{
			"hasCoin",
			"coinCount",
			"list"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private ValueTuple<bool, int, List<ISingleItemInfo>> FilterMaterialList(List<ISingleItemInfo> list)
		{
			bool item = false;
			int item2 = 0;
			List<ISingleItemInfo> list2 = new List<ISingleItemInfo>(list.Count);
			foreach (ISingleItemInfo singleItemInfo in list)
			{
				if (singleItemInfo.Proto_ItemId != ComposeController.Instance.ComposeCoinId)
				{
					list2.Add(singleItemInfo);
				}
				else
				{
					item = true;
					item2 = singleItemInfo.Proto_ItemNum;
				}
			}
			return new ValueTuple<bool, int, List<ISingleItemInfo>>(item, item2, list2);
		}

		// Token: 0x0602D20C RID: 184844 RVA: 0x00C9E894 File Offset: 0x00C9CA94
		private void RefreshMaterial()
		{
			if (this.ItemData.IsUnlock > 0)
			{
				this.UnlockMaterialComponent.SetUiActive(false);
				this.MaterialScrollView.SetActive(true);
				List<ISingleItemInfo> forgingMaterialList = ForgingModel.Instance.GetForgingMaterialList(this.ItemData.ItemId);
				ValueTuple<bool, int, List<ISingleItemInfo>> valueTuple = this.FilterMaterialList(forgingMaterialList);
				this.HasCoin = valueTuple.Item1;
				this.SingleNeedCoinCount = valueTuple.Item2;
				this.MaterialScrollView.RefreshByData(valueTuple.Item3, new Action(this.RefreshMaterialNeedNum), false);
				return;
			}
			this.UnlockMaterialComponent.SetUiActive(true);
			this.MaterialScrollView.SetActive(false);
			ForgeFormula? forgeFormulaById = ForgingConfig.Instance.GetForgeFormulaById(this.ItemData.ItemId);
			ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(forgeFormulaById.Value.FormulaItemId);
			if (itemConfig == null)
			{
				return;
			}
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				Data = forgeFormulaById.Value.FormulaItemId,
				ItemConfigId = new int?(forgeFormulaById.Value.FormulaItemId),
				BottomTextId = itemConfig.Value.Name,
				IsProhibit = new bool?(true),
				IsOmitBottomText = new bool?(true)
			};
			this.UnlockMaterialComponent.Apply<PropMediumItemGrid>(parameters);
		}

		// Token: 0x0602D20D RID: 184845 RVA: 0x00C9E9E8 File Offset: 0x00C9CBE8
		private void RefreshCost(bool hasCoin, int count)
		{
			base.GetItem(32).GetParentAsUIItem().SetUIActive(hasCoin);
			if (hasCoin)
			{
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(ComposeController.Instance.ComposeCoinId, 0);
				ItemInfo? config = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfig(ComposeController.Instance.ComposeCoinId);
				if (itemCountByConfigId < count)
				{
					base.GetText(33).SetText(StringUtils.Format("<color=#c25757>{0}</color>", new string[]
					{
						count.ToString()
					}), true);
				}
				else
				{
					base.GetText(33).SetText(count.ToString(), true);
				}
				base.SetTextureByPath(config.Value.IconSmall, base.GetTexture(34), null, null);
			}
		}

		// Token: 0x0602D20E RID: 184846 RVA: 0x00C9EAA4 File Offset: 0x00C9CCA4
		private void RefreshLimitCount()
		{
			IWeaponForgingData itemData = this.ItemData;
			if (((itemData != null) ? itemData.TotalMakeCountInLimitTime : 0) > 0)
			{
				this.NeedShowBottomText = true;
				UUIText text = base.GetText(25);
				if (text != null)
				{
					text.SetUIActive(true);
				}
				int num = this.ItemData.TotalMakeCountInLimitTime - this.ItemData.MadeCountInLimitTime;
				this.NumberSelect.SetLimitMaxValue(Math.Max(1, num));
				string text2 = num.ToString();
				if (num == 0)
				{
					text2 = StringUtils.Format("<color=#c25757>{0}</color>", new string[]
					{
						num.ToString()
					});
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(25), "MakeLimit", new <>z__ReadOnlyArray<object>(new object[]
				{
					text2,
					this.ItemData.TotalMakeCountInLimitTime
				}));
				return;
			}
			this.NumberSelect.ResetLimitMaxValue();
			UUIText text3 = base.GetText(25);
			if (text3 == null)
			{
				return;
			}
			text3.SetUIActive(false);
		}

		// Token: 0x0602D20F RID: 184847 RVA: 0x00C9EB89 File Offset: 0x00C9CD89
		private void UpdateForgingItemScroll()
		{
			this.SortComponent.UpdateData(EFilterSortGroupId.ForgingList, this.GetItemList(true), Array.Empty<object>());
		}

		// Token: 0x0602D210 RID: 184848 RVA: 0x00C9EBA4 File Offset: 0x00C9CDA4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IWeaponForgingData> GetItemList(bool needFilter = true)
		{
			List<IWeaponForgingData> list = ForgingModel.Instance.GetForgingDataList();
			if (list != null && needFilter)
			{
				List<IWeaponForgingData> list2 = new List<IWeaponForgingData>(list.Count);
				foreach (IWeaponForgingData weaponForgingData in list)
				{
					if (weaponForgingData.IsUnlock > 0 || weaponForgingData.FormulaItemId > 0)
					{
						list2.Add(weaponForgingData);
					}
				}
				list = list2;
			}
			return list;
		}

		// Token: 0x0602D211 RID: 184849 RVA: 0x00C9EC28 File Offset: 0x00C9CE28
		private void RefreshItemScrollView()
		{
			this.ForgingItemScrollView.ReloadData(this.WeaponForgingDataList, false);
		}

		// Token: 0x0602D212 RID: 184850 RVA: 0x00C9EC3C File Offset: 0x00C9CE3C
		private void OnForgingResponse()
		{
			this.SortComponent.UpdateData(EFilterSortGroupId.ForgingList, this.GetItemList(true), Array.Empty<object>());
		}

		// Token: 0x0602D213 RID: 184851 RVA: 0x00C9EC58 File Offset: 0x00C9CE58
		private void OnClickConfirmButton()
		{
			if (!base.GetButton(27).IsSelfInteractive)
			{
				ForgingController.Instance.PlayForgingFailDisplay(delegate
				{
					ForgingController.Instance.PlayForgingLoopDisplay();
				});
				return;
			}
			if (this.ItemData.IsUnlock == 0)
			{
				ForgingController.Instance.SendForgeFormulaUnlockRequest(this.ItemData.ItemId);
				return;
			}
			CommonManager.Instance.SendManufacture(this.ItemData.ItemId, this.Count);
		}

		// Token: 0x0602D214 RID: 184852 RVA: 0x00C9ECDC File Offset: 0x00C9CEDC
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602D215 RID: 184853 RVA: 0x00C9ECE8 File Offset: 0x00C9CEE8
		private void OnFilterSortRefresh(List<IWeaponForgingData> list, bool isOutSideChange, EFilterSortType operationType)
		{
			this.WeaponForgingDataList = list;
			List<IWeaponForgingData> list2 = new List<IWeaponForgingData>(list.Count);
			foreach (IWeaponForgingData weaponForgingData in list)
			{
				if (weaponForgingData.ExistStartTime <= 0.0 || TimeUtil.Instance.IsInTimeSpan(weaponForgingData.ExistStartTime, weaponForgingData.ExistEndTime))
				{
					list2.Add(weaponForgingData);
				}
			}
			this.WeaponForgingDataList = list2;
			this.RefreshItemScrollView();
			if (this.WeaponForgingDataList.Count == 0)
			{
				return;
			}
			this.SetSelectedForgingItem(true);
		}

		// Token: 0x0602D216 RID: 184854 RVA: 0x00C9ED94 File Offset: 0x00C9CF94
		private void OpenRoleView(int itemId)
		{
			UiManager.Instance.OpenView(EUiViewName.ManufactureHelpRoleView, this.SelectedForgingData.ItemId, null);
		}

		// Token: 0x0602D217 RID: 184855 RVA: 0x00C9EDB6 File Offset: 0x00C9CFB6
		private void RefreshForging(IWeaponForgingData data)
		{
			this.RefreshCommon(data);
			this.RefreshMaterial();
			this.RefreshBottomText();
			this.RefreshWeaponTips();
			this.NumberSelect.SetUiActive(data.IsUnlock > 0);
		}

		// Token: 0x0602D218 RID: 184856 RVA: 0x00C9EDE8 File Offset: 0x00C9CFE8
		private void SetSelectedForgingItem(bool isNeedScroll = false)
		{
			this.ForgingItemScrollView.DeselectCurrentGridProxy(false);
			if (isNeedScroll)
			{
				this.ForgingItemScrollView.ScrollToGridIndex(this.SelectedForgingIndex, true);
			}
			this.ForgingItemScrollView.SelectGridProxy(this.SelectedForgingIndex, false);
			IWeaponForgingData data = this.WeaponForgingDataList[this.SelectedForgingIndex];
			this.RefreshItemTips(data);
			this.CheckCanInteractConfirm(data);
			this.RefreshForging(data);
		}

		// Token: 0x0602D219 RID: 184857 RVA: 0x00C9EE50 File Offset: 0x00C9D050
		private void RefreshWeaponTips()
		{
			ForgeFormula? forgeFormulaById = ForgingConfig.Instance.GetForgeFormulaById(this.ItemData.ItemId);
			this.WeaponConfig = global::WeaponConfig.Instance.GetWeaponConfigByItemId(forgeFormulaById.Value.ItemId);
			this.WeaponBreachConfig = global::WeaponConfig.Instance.GetWeaponBreach(this.WeaponConfig.Value.BreachId, 1);
			this.RefreshSkillNameText();
			this.RefreshWeaponLevel();
			this.RefreshStar();
			this.RefreshWeaponAttribute();
			this.RefreshWeaponItem();
		}

		// Token: 0x0602D21A RID: 184858 RVA: 0x00C9EED4 File Offset: 0x00C9D0D4
		private void RefreshSkillNameText()
		{
			WeaponReson? weaponResonanceConfig = global::WeaponConfig.Instance.GetWeaponResonanceConfig(this.WeaponConfig.Value.ResonId, 1);
			if (weaponResonanceConfig != null)
			{
				base.GetText(19).ShowTextNew(weaponResonanceConfig.Value.Name);
			}
		}

		// Token: 0x0602D21B RID: 184859 RVA: 0x00C9EF28 File Offset: 0x00C9D128
		private void RefreshWeaponLevel()
		{
			int num = 1;
			int levelLimit = this.WeaponBreachConfig.Value.LevelLimit;
			LguiUtil.Instance.SetLocalText(base.GetText(9), "ForgingWeaponLevel", new <>z__ReadOnlyArray<object>(new object[]
			{
				num,
				levelLimit
			}));
		}

		// Token: 0x0602D21C RID: 184860 RVA: 0x00C9EF80 File Offset: 0x00C9D180
		private void RefreshStar()
		{
			EStartState[] array = new EStartState[WeaponModel.Instance.GetWeaponBreachMaxLevel(this.WeaponConfig.Value.BreachId)];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = EStartState.OFF;
			}
			this.StarView.RefreshByData(array, null, false);
		}

		// Token: 0x0602D21D RID: 184861 RVA: 0x00C9EFD0 File Offset: 0x00C9D1D0
		private void RefreshWeaponAttribute()
		{
			PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(this.WeaponConfig.Value.FirstPropId.Value.Id);
			UUIText text = base.GetText(13);
			if (text != null)
			{
				text.ShowTextNew(propertyIndexInfo.Value.Name);
			}
			base.SetTextureByPath(propertyIndexInfo.Value.Icon, base.GetTexture(12), null, null);
			float curveValue = WeaponModel.Instance.GetCurveValue(this.WeaponConfig.Value.FirstCurve, this.WeaponConfig.Value.FirstPropId.Value.Value, 1, 0);
			string formatAttributeValueString = AttributeModel.Instance.GetFormatAttributeValueString(this.WeaponConfig.Value.FirstPropId.Value.Id, (double)curveValue, this.WeaponConfig.Value.FirstPropId.Value.IsRatio);
			UUIText text2 = base.GetText(14);
			if (text2 != null)
			{
				text2.SetText(formatAttributeValueString, true);
			}
			PropertyIndex? propertyIndexInfo2 = PropertyIndexConfig.Instance.GetPropertyIndexInfo(this.WeaponConfig.Value.SecondPropId.Value.Id);
			UUIText text3 = base.GetText(16);
			if (text3 != null)
			{
				text3.ShowTextNew(propertyIndexInfo2.Value.Name);
			}
			base.SetTextureByPath(propertyIndexInfo.Value.Icon, base.GetTexture(15), null, null);
			float curveValue2 = WeaponModel.Instance.GetCurveValue(this.WeaponConfig.Value.SecondCurve, this.WeaponConfig.Value.SecondPropId.Value.Value, 1, 0);
			string formatAttributeValueString2 = AttributeModel.Instance.GetFormatAttributeValueString(this.WeaponConfig.Value.SecondPropId.Value.Id, (double)curveValue2, this.WeaponConfig.Value.SecondPropId.Value.IsRatio);
			UUIText text4 = base.GetText(17);
			if (text4 != null)
			{
				text4.SetText(formatAttributeValueString2, true);
			}
			LguiUtil.Instance.SetLocalText(base.GetText(18), "WeaponResonanceItemLevelText", new <>z__ReadOnlySingleElementList<object>("1"));
		}

		// Token: 0x0602D21E RID: 184862 RVA: 0x00C9F268 File Offset: 0x00C9D468
		private void RefreshWeaponItem()
		{
			base.SetTextureByPath(this.WeaponConfig.Value.Icon, base.GetTexture(6), null, null);
			QualityInfo? qualityConfig = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetQualityConfig(this.WeaponConfig.Value.QualityId);
			if (qualityConfig == null)
			{
				return;
			}
			this.SetSpriteByPath(qualityConfig.Value.ComposeQualityBg, base.GetSprite(5), false, null, null);
		}

		// Token: 0x0602D21F RID: 184863 RVA: 0x00C9F2F0 File Offset: 0x00C9D4F0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			LoopScrollView<ForgingMediumItemGrid, IWeaponForgingData> forgingItemScrollView = this.ForgingItemScrollView;
			if (forgingItemScrollView == null || !forgingItemScrollView.DataInited)
			{
				return null;
			}
			int displayIndex = int.Parse(configParams[0]);
			UUIItem gridByDisplayIndex = this.ForgingItemScrollView.GetGridByDisplayIndex(displayIndex);
			if (gridByDisplayIndex != null)
			{
				return new UUIItem[]
				{
					gridByDisplayIndex,
					gridByDisplayIndex
				};
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.JT;
			string message = "印造界面聚焦引导的额外参数配置错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x0602D220 RID: 184864 RVA: 0x00C9F368 File Offset: 0x00C9D568
		[CompilerGenerated]
		private UniTask <OnSecondTimerRefresh>g__Temp|26_0()
		{
			ForgingRootView.<<OnSecondTimerRefresh>g__Temp|26_0>d <<OnSecondTimerRefresh>g__Temp|26_0>d;
			<<OnSecondTimerRefresh>g__Temp|26_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnSecondTimerRefresh>g__Temp|26_0>d.<>4__this = this;
			<<OnSecondTimerRefresh>g__Temp|26_0>d.<>1__state = -1;
			<<OnSecondTimerRefresh>g__Temp|26_0>d.<>t__builder.Start<ForgingRootView.<<OnSecondTimerRefresh>g__Temp|26_0>d>(ref <<OnSecondTimerRefresh>g__Temp|26_0>d);
			return <<OnSecondTimerRefresh>g__Temp|26_0>d.<>t__builder.Task;
		}

		// Token: 0x0602D221 RID: 184865 RVA: 0x00C9F3AC File Offset: 0x00C9D5AC
		[CompilerGenerated]
		private UniTask <OnSecondTimerRefresh>g__Temp|26_1()
		{
			ForgingRootView.<<OnSecondTimerRefresh>g__Temp|26_1>d <<OnSecondTimerRefresh>g__Temp|26_1>d;
			<<OnSecondTimerRefresh>g__Temp|26_1>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnSecondTimerRefresh>g__Temp|26_1>d.<>4__this = this;
			<<OnSecondTimerRefresh>g__Temp|26_1>d.<>1__state = -1;
			<<OnSecondTimerRefresh>g__Temp|26_1>d.<>t__builder.Start<ForgingRootView.<<OnSecondTimerRefresh>g__Temp|26_1>d>(ref <<OnSecondTimerRefresh>g__Temp|26_1>d);
			return <<OnSecondTimerRefresh>g__Temp|26_1>d.<>t__builder.Task;
		}

		// Token: 0x04018363 RID: 99171
		private const int TIMERGAP = 1000;

		// Token: 0x04018364 RID: 99172
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04018365 RID: 99173
		private int SelectedForgingIndex;

		// Token: 0x04018366 RID: 99174
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<ForgingMediumItemGrid, IWeaponForgingData> ForgingItemScrollView;

		// Token: 0x04018367 RID: 99175
		private List<IWeaponForgingData> WeaponForgingDataList = new List<IWeaponForgingData>();

		// Token: 0x04018368 RID: 99176
		[Nullable(2)]
		private IWeaponForgingData SelectedForgingData;

		// Token: 0x04018369 RID: 99177
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FilterEntrance<IWeaponForgingData> FilterComponent;

		// Token: 0x0401836A RID: 99178
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private SortEntrance<IWeaponForgingData> SortComponent;

		// Token: 0x0401836B RID: 99179
		[Nullable(2)]
		private TimerHandle RefreshTimer;

		// Token: 0x0401836C RID: 99180
		[Nullable(2)]
		private NumberSelectComponent NumberSelect;

		// Token: 0x0401836D RID: 99181
		private bool NeedShowBottomText;

		// Token: 0x0401836E RID: 99182
		private int Count = 1;

		// Token: 0x0401836F RID: 99183
		[Nullable(2)]
		private IWeaponForgingData ItemData;

		// Token: 0x04018370 RID: 99184
		private bool HasCoin;

		// Token: 0x04018371 RID: 99185
		private int SingleNeedCoinCount;

		// Token: 0x04018372 RID: 99186
		[Nullable(2)]
		private MediumItemGrid UnlockMaterialComponent;

		// Token: 0x04018373 RID: 99187
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> MaterialScrollView;

		// Token: 0x04018374 RID: 99188
		private WeaponConf? WeaponConfig;

		// Token: 0x04018375 RID: 99189
		private WeaponBreach? WeaponBreachConfig;

		// Token: 0x04018376 RID: 99190
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<ForgingRootView.StarItem, EStartState> StarView;

		// Token: 0x04018377 RID: 99191
		private const int CurrentLevel = 1;

		// Token: 0x04018378 RID: 99192
		private const int CurrentBreach = 0;

		// Token: 0x0200A236 RID: 41526
		[NullableContext(0)]
		private enum EForgingRootDefine
		{
			// Token: 0x04032512 RID: 206098
			CaptionItem,
			// Token: 0x04032513 RID: 206099
			ItemLoopScroll,
			// Token: 0x04032514 RID: 206100
			LoopScrollItem,
			// Token: 0x04032515 RID: 206101
			FilterItem,
			// Token: 0x04032516 RID: 206102
			SortItem,
			// Token: 0x04032517 RID: 206103
			ItemQualitySprite,
			// Token: 0x04032518 RID: 206104
			ItemTexture,
			// Token: 0x04032519 RID: 206105
			ItemNumberText,
			// Token: 0x0403251A RID: 206106
			ItemNameText,
			// Token: 0x0403251B RID: 206107
			ItemLevelText,
			// Token: 0x0403251C RID: 206108
			StarLayout,
			// Token: 0x0403251D RID: 206109
			StarItem,
			// Token: 0x0403251E RID: 206110
			WeaponFirstAttributeIconTexture,
			// Token: 0x0403251F RID: 206111
			WeaponFirstAttributeNameText,
			// Token: 0x04032520 RID: 206112
			WeaponFirstAttributeNumberText,
			// Token: 0x04032521 RID: 206113
			WeaponSecondAttributeIconTexture,
			// Token: 0x04032522 RID: 206114
			WeaponSecondAttributeNameText,
			// Token: 0x04032523 RID: 206115
			WeaponSecondAttributeNumberText,
			// Token: 0x04032524 RID: 206116
			WeaponRankText,
			// Token: 0x04032525 RID: 206117
			WeaponRankDesText,
			// Token: 0x04032526 RID: 206118
			WeaponMainText,
			// Token: 0x04032527 RID: 206119
			MaterialItem,
			// Token: 0x04032528 RID: 206120
			MaterialScrollView,
			// Token: 0x04032529 RID: 206121
			MaterialScrollContent,
			// Token: 0x0403252A RID: 206122
			NumberSelectItem,
			// Token: 0x0403252B RID: 206123
			BottomLeftText,
			// Token: 0x0403252C RID: 206124
			BottomTimeText,
			// Token: 0x0403252D RID: 206125
			ConfirmBtn,
			// Token: 0x0403252E RID: 206126
			LockItem,
			// Token: 0x0403252F RID: 206127
			BottomTextRootItem,
			// Token: 0x04032530 RID: 206128
			ConfirmText,
			// Token: 0x04032531 RID: 206129
			LockText,
			// Token: 0x04032532 RID: 206130
			CostItem,
			// Token: 0x04032533 RID: 206131
			CostCountText,
			// Token: 0x04032534 RID: 206132
			CostIconTexture
		}

		// Token: 0x0200A237 RID: 41527
		[NullableContext(0)]
		private enum EStarItemComponents
		{
			// Token: 0x04032536 RID: 206134
			ImgStarOn,
			// Token: 0x04032537 RID: 206135
			ImgStarOff
		}

		// Token: 0x0200A238 RID: 41528
		[Nullable(0)]
		public class StarItem : UiPanelBase, IGridProxy<EStartState>
		{
			// Token: 0x17007958 RID: 31064
			// (get) Token: 0x06045905 RID: 284933 RVA: 0x014E77C6 File Offset: 0x014E59C6
			// (set) Token: 0x06045906 RID: 284934 RVA: 0x014E77CE File Offset: 0x014E59CE
			[Nullable(new byte[]
			{
				2,
				1
			})]
			public IScrollViewDelegate<IGridProxy<EStartState>, EStartState> ScrollViewDelegate { [return: Nullable(new byte[]
			{
				2,
				1
			})] get; [param: Nullable(new byte[]
			{
				2,
				1
			})] set; }

			// Token: 0x17007959 RID: 31065
			// (get) Token: 0x06045907 RID: 284935 RVA: 0x014E77D7 File Offset: 0x014E59D7
			// (set) Token: 0x06045908 RID: 284936 RVA: 0x014E77DF File Offset: 0x014E59DF
			public int GridIndex { get; set; }

			// Token: 0x1700795A RID: 31066
			// (get) Token: 0x06045909 RID: 284937 RVA: 0x014E77E8 File Offset: 0x014E59E8
			// (set) Token: 0x0604590A RID: 284938 RVA: 0x014E77F0 File Offset: 0x014E59F0
			public int DisplayIndex { get; set; }

			// Token: 0x0604590B RID: 284939 RVA: 0x014E77F9 File Offset: 0x014E59F9
			public void Refresh(EStartState data, bool isSelected, int gridIndex)
			{
				if (data == EStartState.ON)
				{
					base.GetSprite(0).SetUIActive(true);
					base.GetSprite(1).SetUIActive(false);
					return;
				}
				base.GetSprite(0).SetUIActive(false);
				base.GetSprite(1).SetUIActive(true);
			}

			// Token: 0x0604590C RID: 284940 RVA: 0x014E7836 File Offset: 0x014E5A36
			public void Clear()
			{
			}

			// Token: 0x0604590D RID: 284941 RVA: 0x014E7838 File Offset: 0x014E5A38
			public void OnSelected(bool fireEvent)
			{
			}

			// Token: 0x0604590E RID: 284942 RVA: 0x014E783A File Offset: 0x014E5A3A
			public void OnDeselected(bool fireEvent)
			{
			}

			// Token: 0x0604590F RID: 284943 RVA: 0x014E783C File Offset: 0x014E5A3C
			public void CreateThenShowByActor(AActor actor)
			{
				base.CreateThenShowByActor(actor, null);
			}

			// Token: 0x06045910 RID: 284944 RVA: 0x014E7848 File Offset: 0x014E5A48
			public UniTask CreateThenShowByActorAsync(AActor actor)
			{
				ForgingRootView.StarItem.<CreateThenShowByActorAsync>d__17 <CreateThenShowByActorAsync>d__;
				<CreateThenShowByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<CreateThenShowByActorAsync>d__.<>4__this = this;
				<CreateThenShowByActorAsync>d__.actor = actor;
				<CreateThenShowByActorAsync>d__.<>1__state = -1;
				<CreateThenShowByActorAsync>d__.<>t__builder.Start<ForgingRootView.StarItem.<CreateThenShowByActorAsync>d__17>(ref <CreateThenShowByActorAsync>d__);
				return <CreateThenShowByActorAsync>d__.<>t__builder.Task;
			}

			// Token: 0x06045911 RID: 284945 RVA: 0x014E7894 File Offset: 0x014E5A94
			public UniTask CreateByActorAsync(AActor actor)
			{
				ForgingRootView.StarItem.<CreateByActorAsync>d__18 <CreateByActorAsync>d__;
				<CreateByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<CreateByActorAsync>d__.<>4__this = this;
				<CreateByActorAsync>d__.actor = actor;
				<CreateByActorAsync>d__.<>1__state = -1;
				<CreateByActorAsync>d__.<>t__builder.Start<ForgingRootView.StarItem.<CreateByActorAsync>d__18>(ref <CreateByActorAsync>d__);
				return <CreateByActorAsync>d__.<>t__builder.Task;
			}

			// Token: 0x06045912 RID: 284946 RVA: 0x014E78DF File Offset: 0x014E5ADF
			public object GetKey(EStartState data, int gridIndex)
			{
				return data;
			}

			// Token: 0x06045913 RID: 284947 RVA: 0x014E78E8 File Offset: 0x014E5AE8
			protected unsafe override void OnRegisterComponent()
			{
				int num = 2;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
				this.ComponentRegisterInfos = list;
				this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
			}

			// Token: 0x06045914 RID: 284948 RVA: 0x014E795C File Offset: 0x014E5B5C
			public void SetState(bool isOn)
			{
			}
		}
	}
}
