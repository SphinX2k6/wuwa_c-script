using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005653 RID: 22099
	[NullableContext(1)]
	[Nullable(0)]
	public class ForgingRootView : UiViewBase
	{
		// Token: 0x060382F4 RID: 230132 RVA: 0x00D4FBA4 File Offset: 0x00D4DDA4
		public ForgingRootView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060382F5 RID: 230133 RVA: 0x00D4FBC0 File Offset: 0x00D4DDC0
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.GetForgingData, new Action(this.ShowForgingRootView));
			EventSystem.Instance.Add(EEventName.OpenHelpRole, new Action<int>(this.OpenRoleView));
			EventSystem.Instance.Add(EEventName.ForgingSuccess, new Action(this.OnForgingResponse));
			EventSystem.Instance.Add(EEventName.ForgingFail, new Action(this.OnForgingResponse));
			this.RefreshTimer = TimerSystem.Instance.Forever(new TTimerAction(this.OnSecondTimerRefresh), 1000f, 1f, null, null, true);
		}

		// Token: 0x060382F6 RID: 230134 RVA: 0x00D4FC68 File Offset: 0x00D4DE68
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

		// Token: 0x060382F7 RID: 230135 RVA: 0x00D4FD17 File Offset: 0x00D4DF17
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

		// Token: 0x060382F8 RID: 230136 RVA: 0x00D4FD46 File Offset: 0x00D4DF46
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

		// Token: 0x060382F9 RID: 230137 RVA: 0x00D4FD74 File Offset: 0x00D4DF74
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

		// Token: 0x060382FA RID: 230138 RVA: 0x00D4FDE0 File Offset: 0x00D4DFE0
		private bool CheckIsLimitCountRefresh()
		{
			return ForgingModel.Instance.GetRefreshLimitTimeValue() <= 0.0;
		}

		// Token: 0x060382FB RID: 230139 RVA: 0x00D4FDFC File Offset: 0x00D4DFFC
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

		// Token: 0x060382FC RID: 230140 RVA: 0x00D4FE80 File Offset: 0x00D4E080
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

		// Token: 0x060382FD RID: 230141 RVA: 0x00D50384 File Offset: 0x00D4E584
		protected override UniTask OnBeforeStartAsync()
		{
			ForgingRootView.<OnBeforeStartAsync>d__32 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ForgingRootView.<OnBeforeStartAsync>d__32>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060382FE RID: 230142 RVA: 0x00D503C8 File Offset: 0x00D4E5C8
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

		// Token: 0x060382FF RID: 230143 RVA: 0x00D504BB File Offset: 0x00D4E6BB
		protected override void OnBeforeShow()
		{
			this.UpdateForgingItemScroll();
			this.ShowForgingRootView();
		}

		// Token: 0x06038300 RID: 230144 RVA: 0x00D504CC File Offset: 0x00D4E6CC
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnExecuteUiCameraSequenceEvent, new Action<string>(this.OnExecuteUiCameraSequenceEvent));
			this.FilterComponent.Destroy(null);
			this.SortComponent.Destroy(null);
			ForgingController.Instance.PlayLeaveForgingAudio();
			ForgingController.Instance.ClearCurrentInteractionEntityDisplay();
			ForgingModel.Instance.CurrentForgingRoleId = 0;
		}

		// Token: 0x06038301 RID: 230145 RVA: 0x00D5052C File Offset: 0x00D4E72C
		private void ShowForgingRootView()
		{
			this.SortComponent.UpdateData(EFilterSortGroupId.ForgingList, this.GetItemList(true), Array.Empty<object>());
		}

		// Token: 0x06038302 RID: 230146 RVA: 0x00D50547 File Offset: 0x00D4E747
		private void OnExecuteUiCameraSequenceEvent(string sequenceEventName)
		{
			if (sequenceEventName != "OnBlackScreen")
			{
				return;
			}
			ForgingController.Instance.PlayForgingEnterDisplay(null);
		}

		// Token: 0x06038303 RID: 230147 RVA: 0x00D50562 File Offset: 0x00D4E762
		private ForgingMediumItemGrid OnGridProxyCreate()
		{
			ForgingMediumItemGrid forgingMediumItemGrid = new ForgingMediumItemGrid();
			forgingMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnComposeItemClick));
			return forgingMediumItemGrid;
		}

		// Token: 0x06038304 RID: 230148 RVA: 0x00D5057C File Offset: 0x00D4E77C
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

		// Token: 0x06038305 RID: 230149 RVA: 0x00D50628 File Offset: 0x00D4E828
		private void RefreshItemTips(IWeaponForgingData data)
		{
			ForgeFormula? forgeFormulaById = ForgingConfig.Instance.GetForgeFormulaById(data.ItemId);
			WeaponConf? weaponConfigByItemId = global::WeaponConfig.Instance.GetWeaponConfigByItemId(forgeFormulaById.Value.ItemId);
			base.GetText(8).ShowTextNew(((weaponConfigByItemId != null) ? weaponConfigByItemId.GetValueOrDefault().WeaponName : null) ?? "");
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(forgeFormulaById.Value.ItemId, 0);
			LguiUtil.Instance.SetLocalText(base.GetText(7), "Have", new <>z__ReadOnlySingleElementList<object>(itemCountByConfigId));
		}

		// Token: 0x06038306 RID: 230150 RVA: 0x00D506D0 File Offset: 0x00D4E8D0
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

		// Token: 0x06038307 RID: 230151 RVA: 0x00D507A0 File Offset: 0x00D4E9A0
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

		// Token: 0x06038308 RID: 230152 RVA: 0x00D5084B File Offset: 0x00D4EA4B
		private ForgingRootView.StarItem InitStarItem()
		{
			return new ForgingRootView.StarItem();
		}

		// Token: 0x06038309 RID: 230153 RVA: 0x00D50854 File Offset: 0x00D4EA54
		private ManufactureMaterialItem OnMaterialItemCreate()
		{
			ManufactureMaterialItem manufactureMaterialItem = new ManufactureMaterialItem();
			manufactureMaterialItem.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			manufactureMaterialItem.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback callbackParameter)
			{
				ISingleItemInfo singleItemInfo = (ISingleItemInfo)callbackParameter.Data;
				ItemController.Instance.OpenItemTipsByItemId(singleItemInfo.Proto_ItemId, true, null);
			});
			return manufactureMaterialItem;
		}

		// Token: 0x0603830A RID: 230154 RVA: 0x00D508B0 File Offset: 0x00D4EAB0
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

		// Token: 0x0603830B RID: 230155 RVA: 0x00D50938 File Offset: 0x00D4EB38
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

		// Token: 0x0603830C RID: 230156 RVA: 0x00D509BC File Offset: 0x00D4EBBC
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

		// Token: 0x0603830D RID: 230157 RVA: 0x00D50A80 File Offset: 0x00D4EC80
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
			bool hasCoin = false;
			int coinCount = 0;
			List<ISingleItemInfo> item = list.Where(delegate(ISingleItemInfo value)
			{
				if (value.Proto_ItemId != ComposeController.Instance.ComposeCoinId)
				{
					return true;
				}
				hasCoin = true;
				coinCount = value.Proto_ItemNum;
				return false;
			}).ToList<ISingleItemInfo>();
			return new ValueTuple<bool, int, List<ISingleItemInfo>>(hasCoin, coinCount, item);
		}

		// Token: 0x0603830E RID: 230158 RVA: 0x00D50ACC File Offset: 0x00D4ECCC
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

		// Token: 0x0603830F RID: 230159 RVA: 0x00D50C20 File Offset: 0x00D4EE20
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

		// Token: 0x06038310 RID: 230160 RVA: 0x00D50CDC File Offset: 0x00D4EEDC
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

		// Token: 0x06038311 RID: 230161 RVA: 0x00D50DC1 File Offset: 0x00D4EFC1
		private void UpdateForgingItemScroll()
		{
			this.SortComponent.UpdateData(EFilterSortGroupId.ForgingList, this.GetItemList(true), Array.Empty<object>());
		}

		// Token: 0x06038312 RID: 230162 RVA: 0x00D50DDC File Offset: 0x00D4EFDC
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
				list = (from value in list
				where value.IsUnlock > 0 || value.FormulaItemId > 0
				select value).ToList<IWeaponForgingData>();
			}
			return list;
		}

		// Token: 0x06038313 RID: 230163 RVA: 0x00D50E28 File Offset: 0x00D4F028
		private void RefreshItemScrollView()
		{
			this.ForgingItemScrollView.ReloadData(this.WeaponForgingDataList, false);
		}

		// Token: 0x06038314 RID: 230164 RVA: 0x00D50E3C File Offset: 0x00D4F03C
		private void OnForgingResponse()
		{
			this.SortComponent.UpdateData(EFilterSortGroupId.ForgingList, this.GetItemList(true), Array.Empty<object>());
		}

		// Token: 0x06038315 RID: 230165 RVA: 0x00D50E58 File Offset: 0x00D4F058
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

		// Token: 0x06038316 RID: 230166 RVA: 0x00D50EDC File Offset: 0x00D4F0DC
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06038317 RID: 230167 RVA: 0x00D50EE8 File Offset: 0x00D4F0E8
		private void OnFilterSortRefresh(List<IWeaponForgingData> list, bool isOutSideChange, EFilterSortType operationType)
		{
			this.WeaponForgingDataList = list;
			this.WeaponForgingDataList = (from value in this.WeaponForgingDataList
			where value.ExistStartTime <= 0.0 || TimeUtil.Instance.IsInTimeSpan(value.ExistStartTime, value.ExistEndTime)
			select value).ToList<IWeaponForgingData>();
			this.RefreshItemScrollView();
			if (this.WeaponForgingDataList.Count == 0)
			{
				return;
			}
			this.SetSelectedForgingItem(true);
		}

		// Token: 0x06038318 RID: 230168 RVA: 0x00D50F4C File Offset: 0x00D4F14C
		private void OpenRoleView(int itemId)
		{
			UiManager.Instance.OpenView(EUiViewName.ManufactureHelpRoleView, this.SelectedForgingData.ItemId, null);
		}

		// Token: 0x06038319 RID: 230169 RVA: 0x00D50F6E File Offset: 0x00D4F16E
		private void RefreshForging(IWeaponForgingData data)
		{
			this.RefreshCommon(data);
			this.RefreshMaterial();
			this.RefreshBottomText();
			this.RefreshWeaponTips();
			this.NumberSelect.SetUiActive(data.IsUnlock > 0);
		}

		// Token: 0x0603831A RID: 230170 RVA: 0x00D50FA0 File Offset: 0x00D4F1A0
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

		// Token: 0x0603831B RID: 230171 RVA: 0x00D51008 File Offset: 0x00D4F208
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

		// Token: 0x0603831C RID: 230172 RVA: 0x00D5108C File Offset: 0x00D4F28C
		private void RefreshSkillNameText()
		{
			WeaponReson? weaponResonanceConfig = global::WeaponConfig.Instance.GetWeaponResonanceConfig(this.WeaponConfig.Value.ResonId, 1);
			if (weaponResonanceConfig != null)
			{
				base.GetText(19).ShowTextNew(weaponResonanceConfig.Value.Name);
			}
		}

		// Token: 0x0603831D RID: 230173 RVA: 0x00D510E0 File Offset: 0x00D4F2E0
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

		// Token: 0x0603831E RID: 230174 RVA: 0x00D51138 File Offset: 0x00D4F338
		private void RefreshStar()
		{
			int weaponBreachMaxLevel = WeaponModel.Instance.GetWeaponBreachMaxLevel(this.WeaponConfig.Value.BreachId);
			EStartState[] data = Enumerable.Repeat<EStartState>(EStartState.OFF, weaponBreachMaxLevel).ToArray<EStartState>();
			this.StarView.RefreshByData(data, null, false);
		}

		// Token: 0x0603831F RID: 230175 RVA: 0x00D51180 File Offset: 0x00D4F380
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

		// Token: 0x06038320 RID: 230176 RVA: 0x00D51418 File Offset: 0x00D4F618
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

		// Token: 0x06038321 RID: 230177 RVA: 0x00D514A0 File Offset: 0x00D4F6A0
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

		// Token: 0x06038322 RID: 230178 RVA: 0x00D51518 File Offset: 0x00D4F718
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

		// Token: 0x06038323 RID: 230179 RVA: 0x00D5155C File Offset: 0x00D4F75C
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

		// Token: 0x0401D8D8 RID: 121048
		private const int TIMERGAP = 1000;

		// Token: 0x0401D8D9 RID: 121049
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401D8DA RID: 121050
		private int SelectedForgingIndex;

		// Token: 0x0401D8DB RID: 121051
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<ForgingMediumItemGrid, IWeaponForgingData> ForgingItemScrollView;

		// Token: 0x0401D8DC RID: 121052
		private List<IWeaponForgingData> WeaponForgingDataList = new List<IWeaponForgingData>();

		// Token: 0x0401D8DD RID: 121053
		[Nullable(2)]
		private IWeaponForgingData SelectedForgingData;

		// Token: 0x0401D8DE RID: 121054
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FilterEntrance<IWeaponForgingData> FilterComponent;

		// Token: 0x0401D8DF RID: 121055
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private SortEntrance<IWeaponForgingData> SortComponent;

		// Token: 0x0401D8E0 RID: 121056
		[Nullable(2)]
		private TimerHandle RefreshTimer;

		// Token: 0x0401D8E1 RID: 121057
		[Nullable(2)]
		private NumberSelectComponent NumberSelect;

		// Token: 0x0401D8E2 RID: 121058
		private bool NeedShowBottomText;

		// Token: 0x0401D8E3 RID: 121059
		private int Count = 1;

		// Token: 0x0401D8E4 RID: 121060
		[Nullable(2)]
		private IWeaponForgingData ItemData;

		// Token: 0x0401D8E5 RID: 121061
		private bool HasCoin;

		// Token: 0x0401D8E6 RID: 121062
		private int SingleNeedCoinCount;

		// Token: 0x0401D8E7 RID: 121063
		[Nullable(2)]
		private MediumItemGrid UnlockMaterialComponent;

		// Token: 0x0401D8E8 RID: 121064
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> MaterialScrollView;

		// Token: 0x0401D8E9 RID: 121065
		private WeaponConf? WeaponConfig;

		// Token: 0x0401D8EA RID: 121066
		private WeaponBreach? WeaponBreachConfig;

		// Token: 0x0401D8EB RID: 121067
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<ForgingRootView.StarItem, EStartState> StarView;

		// Token: 0x0401D8EC RID: 121068
		private const int CurrentLevel = 1;

		// Token: 0x0401D8ED RID: 121069
		private const int CurrentBreach = 0;

		// Token: 0x0200B80C RID: 47116
		[NullableContext(0)]
		private enum EForgingRootDefine
		{
			// Token: 0x04037AEA RID: 228074
			CaptionItem,
			// Token: 0x04037AEB RID: 228075
			ItemLoopScroll,
			// Token: 0x04037AEC RID: 228076
			LoopScrollItem,
			// Token: 0x04037AED RID: 228077
			FilterItem,
			// Token: 0x04037AEE RID: 228078
			SortItem,
			// Token: 0x04037AEF RID: 228079
			ItemQualitySprite,
			// Token: 0x04037AF0 RID: 228080
			ItemTexture,
			// Token: 0x04037AF1 RID: 228081
			ItemNumberText,
			// Token: 0x04037AF2 RID: 228082
			ItemNameText,
			// Token: 0x04037AF3 RID: 228083
			ItemLevelText,
			// Token: 0x04037AF4 RID: 228084
			StarLayout,
			// Token: 0x04037AF5 RID: 228085
			StarItem,
			// Token: 0x04037AF6 RID: 228086
			WeaponFirstAttributeIconTexture,
			// Token: 0x04037AF7 RID: 228087
			WeaponFirstAttributeNameText,
			// Token: 0x04037AF8 RID: 228088
			WeaponFirstAttributeNumberText,
			// Token: 0x04037AF9 RID: 228089
			WeaponSecondAttributeIconTexture,
			// Token: 0x04037AFA RID: 228090
			WeaponSecondAttributeNameText,
			// Token: 0x04037AFB RID: 228091
			WeaponSecondAttributeNumberText,
			// Token: 0x04037AFC RID: 228092
			WeaponRankText,
			// Token: 0x04037AFD RID: 228093
			WeaponRankDesText,
			// Token: 0x04037AFE RID: 228094
			WeaponMainText,
			// Token: 0x04037AFF RID: 228095
			MaterialItem,
			// Token: 0x04037B00 RID: 228096
			MaterialScrollView,
			// Token: 0x04037B01 RID: 228097
			MaterialScrollContent,
			// Token: 0x04037B02 RID: 228098
			NumberSelectItem,
			// Token: 0x04037B03 RID: 228099
			BottomLeftText,
			// Token: 0x04037B04 RID: 228100
			BottomTimeText,
			// Token: 0x04037B05 RID: 228101
			ConfirmBtn,
			// Token: 0x04037B06 RID: 228102
			LockItem,
			// Token: 0x04037B07 RID: 228103
			BottomTextRootItem,
			// Token: 0x04037B08 RID: 228104
			ConfirmText,
			// Token: 0x04037B09 RID: 228105
			LockText,
			// Token: 0x04037B0A RID: 228106
			CostItem,
			// Token: 0x04037B0B RID: 228107
			CostCountText,
			// Token: 0x04037B0C RID: 228108
			CostIconTexture
		}

		// Token: 0x0200B80D RID: 47117
		[NullableContext(0)]
		private enum EStarItemComponents
		{
			// Token: 0x04037B0E RID: 228110
			ImgStarOn,
			// Token: 0x04037B0F RID: 228111
			ImgStarOff
		}

		// Token: 0x0200B80E RID: 47118
		[Nullable(0)]
		public class StarItem : UiPanelBase, IGridProxy<EStartState>
		{
			// Token: 0x1700A1BB RID: 41403
			// (get) Token: 0x0604F32D RID: 324397 RVA: 0x0152DD96 File Offset: 0x0152BF96
			// (set) Token: 0x0604F32E RID: 324398 RVA: 0x0152DD9E File Offset: 0x0152BF9E
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

			// Token: 0x1700A1BC RID: 41404
			// (get) Token: 0x0604F32F RID: 324399 RVA: 0x0152DDA7 File Offset: 0x0152BFA7
			// (set) Token: 0x0604F330 RID: 324400 RVA: 0x0152DDAF File Offset: 0x0152BFAF
			public int GridIndex { get; set; }

			// Token: 0x1700A1BD RID: 41405
			// (get) Token: 0x0604F331 RID: 324401 RVA: 0x0152DDB8 File Offset: 0x0152BFB8
			// (set) Token: 0x0604F332 RID: 324402 RVA: 0x0152DDC0 File Offset: 0x0152BFC0
			public int DisplayIndex { get; set; }

			// Token: 0x0604F333 RID: 324403 RVA: 0x0152DDC9 File Offset: 0x0152BFC9
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

			// Token: 0x0604F334 RID: 324404 RVA: 0x0152DE06 File Offset: 0x0152C006
			public void Clear()
			{
			}

			// Token: 0x0604F335 RID: 324405 RVA: 0x0152DE08 File Offset: 0x0152C008
			public void OnSelected(bool fireEvent)
			{
			}

			// Token: 0x0604F336 RID: 324406 RVA: 0x0152DE0A File Offset: 0x0152C00A
			public void OnDeselected(bool fireEvent)
			{
			}

			// Token: 0x0604F337 RID: 324407 RVA: 0x0152DE0C File Offset: 0x0152C00C
			public void CreateThenShowByActor(AActor actor)
			{
				base.CreateThenShowByActor(actor, null);
			}

			// Token: 0x0604F338 RID: 324408 RVA: 0x0152DE18 File Offset: 0x0152C018
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

			// Token: 0x0604F339 RID: 324409 RVA: 0x0152DE64 File Offset: 0x0152C064
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

			// Token: 0x0604F33A RID: 324410 RVA: 0x0152DEAF File Offset: 0x0152C0AF
			public object GetKey(EStartState data, int gridIndex)
			{
				return data;
			}

			// Token: 0x0604F33B RID: 324411 RVA: 0x0152DEB8 File Offset: 0x0152C0B8
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

			// Token: 0x0604F33C RID: 324412 RVA: 0x0152DF2C File Offset: 0x0152C12C
			public void SetState(bool isOn)
			{
			}
		}
	}
}
