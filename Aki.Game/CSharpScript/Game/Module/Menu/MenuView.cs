using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Menu.KeySettingsView;
using CSharpScript.Game.Module.Menu.Views;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x02005408 RID: 21512
	[NullableContext(1)]
	[Nullable(0)]
	public class MenuView : UiViewBase
	{
		// Token: 0x17008430 RID: 33840
		// (get) Token: 0x06036F6A RID: 225130 RVA: 0x00D05157 File Offset: 0x00D03357
		public MenuViewData MenuViewDataExternal
		{
			get
			{
				return this.MenuViewData;
			}
		}

		// Token: 0x06036F6B RID: 225131 RVA: 0x00D0515F File Offset: 0x00D0335F
		public MenuView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036F6C RID: 225132 RVA: 0x00D0518C File Offset: 0x00D0338C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIDynScrollViewComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(6, new Action(this.MobileSwitchTouch))
			};
		}

		// Token: 0x06036F6D RID: 225133 RVA: 0x00D052A4 File Offset: 0x00D034A4
		protected override void OnStart()
		{
			if (CloudGameManager.Instance.IsCloudGame || Info.Instance.IsHomeConsolePlatform())
			{
				UUIItem item = base.GetItem(9);
				if (item != null)
				{
					item.SetUIActive(false);
				}
			}
			else
			{
				this.ApplyBtnItem = new ButtonItem(base.GetItem(9));
				this.ApplyBtnItem.SetFunction(new Action<int>(this.OnClickApplyBtn));
				this.RefreshApplyBtn();
			}
			this.TabComponent.SelectToggleByIndex(0, true);
			UUIButtonComponent button = base.GetButton(6);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(Info.Instance.IsMobileInputModel() && Info.Instance.IsInGamepad() && GameSettingsManager.Instance.IsGameSettingsAppliedOnOpenLoading);
			}
			MenuModel.Instance.HasApplyRecommendData = false;
		}

		// Token: 0x06036F6E RID: 225134 RVA: 0x00D0536C File Offset: 0x00D0356C
		protected override void OnBeforeDestroy()
		{
			if (this.TabComponent != null)
			{
				this.TabComponent.Destroy(null);
				this.TabComponent = null;
			}
			if (this.ScrollItemPool != null)
			{
				this.ScrollItemPool.Clear();
			}
			if (this.MenuInfoDataArray != null)
			{
				this.MenuInfoDataArray.Clear();
			}
			if (this.ScrollView != null)
			{
				this.ScrollView.ClearChildren();
				this.ScrollView = null;
			}
			if (this.MenuScrollSettingContainerDynItem != null)
			{
				this.MenuScrollSettingContainerDynItem = null;
			}
			MenuModel instance = MenuModel.Instance;
			if (instance.IsEdited)
			{
				MenuController.Instance.ReportSettingMenuLogEvent();
				instance.IsEdited = false;
			}
			instance.IsImageQualityCustomNullable = null;
			this.RemoveNextScrollToButtonTimerHandle();
			instance.ClearMenuDataMap();
			instance.HasApplyRecommendData = false;
		}

		// Token: 0x06036F6F RID: 225135 RVA: 0x00D05424 File Offset: 0x00D03624
		protected override UniTask OnBeforeStartAsync()
		{
			MenuView.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MenuView.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036F70 RID: 225136 RVA: 0x00D05468 File Offset: 0x00D03668
		[NullableContext(2)]
		private TMenuItemFilter GetItemFilterByOpenScene(EMenuViewOpenScene? openScene)
		{
			EMenuViewOpenScene valueOrDefault = openScene.GetValueOrDefault();
			if (valueOrDefault != EMenuViewOpenScene.Default && valueOrDefault == EMenuViewOpenScene.Login)
			{
				return (MenuData data) => data.CanShowInLogin;
			}
			return null;
		}

		// Token: 0x06036F71 RID: 225137 RVA: 0x00D054A5 File Offset: 0x00D036A5
		private MenuScrollItemData Creator()
		{
			return new MenuScrollItemData();
		}

		// Token: 0x06036F72 RID: 225138 RVA: 0x00D054AC File Offset: 0x00D036AC
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<bool>(EEventName.OnDropDownListVisibleChanged, new Action<bool>(this.OnDropDownListVisibleChanged));
			EventSystem.Instance.Add<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.RefreshTextLanguage));
			EventSystem.Instance.Add<EFunction>(EEventName.RefreshMenuSetting, new Action<EFunction>(this.OnRefreshMenuSetting));
			if (Platform.Instance.IsMobilePlatform() || Platform.Instance.IsPcPlatform())
			{
				EventSystem.Instance.Add<bool>(EEventName.ConfigLoadChange, new Action<bool>(this.RefreshGameQualityLoad));
			}
			UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
			if (gameUserSettings == null)
			{
				return;
			}
			gameUserSettings.OnGameUserSettingsUINeedsUpdate.Add(new Action(GameSettingsController.Instance.OnGameUserSettingsUINeedsUpdate));
		}

		// Token: 0x06036F73 RID: 225139 RVA: 0x00D05568 File Offset: 0x00D03768
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnDropDownListVisibleChanged, new Action<bool>(this.OnDropDownListVisibleChanged));
			EventSystem.Instance.Remove(EEventName.TextLanguageChange, new Action<string, string>(this.RefreshTextLanguage));
			EventSystem.Instance.Remove(EEventName.RefreshMenuSetting, new Action<EFunction>(this.OnRefreshMenuSetting));
			if (Platform.Instance.IsMobilePlatform() || Platform.Instance.IsPcPlatform())
			{
				EventSystem.Instance.Remove<bool>(EEventName.ConfigLoadChange, new Action<bool>(this.RefreshGameQualityLoad));
			}
			UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
			if (gameUserSettings == null)
			{
				return;
			}
			gameUserSettings.OnGameUserSettingsUINeedsUpdate.Remove(new Action(GameSettingsController.Instance.OnGameUserSettingsUINeedsUpdate));
		}

		// Token: 0x06036F74 RID: 225140 RVA: 0x00D05621 File Offset: 0x00D03821
		private void RefreshTextLanguage(string s, string s1)
		{
			this.RefreshConfig();
		}

		// Token: 0x06036F75 RID: 225141 RVA: 0x00D05629 File Offset: 0x00D03829
		private void OnRefreshMenuSetting(EFunction functionId)
		{
			if (functionId == EFunction.IMAGEQUALITY)
			{
				this.RefreshApplyBtn();
			}
		}

		// Token: 0x06036F76 RID: 225142 RVA: 0x00D05636 File Offset: 0x00D03836
		private void OnDropDownListVisibleChanged(bool bVisible)
		{
			if (!bVisible)
			{
				return;
			}
			base.GetUIDynScrollViewComponent(0).StopMovement();
		}

		// Token: 0x06036F77 RID: 225143 RVA: 0x00D05648 File Offset: 0x00D03848
		private void RefreshGameQualityLoad(bool needLoadConfirmBox = true)
		{
			if (!Platform.Instance.IsMobilePlatform() && !Platform.Instance.IsPcPlatform())
			{
				return;
			}
			MenuModel instance = MenuModel.Instance;
			GameQualityLoadInfo gameQualityLoadInfo = instance.GetGameQualityLoadInfo();
			int percentage = gameQualityLoadInfo.Percentage;
			if (percentage > 80 && needLoadConfirmBox && (!instance.IsOpenedImageOverloadConfirmBox || instance.QualityInfoPercentage < 80f))
			{
				if (Platform.Instance.IsIOSPlatform())
				{
					MenuController.Instance.OpenImageQualityOverloadConfirmBox();
				}
				else
				{
					MenuController.Instance.OpenImageOverloadConfirmBox();
				}
				instance.IsOpenedImageOverloadConfirmBox = true;
			}
			instance.QualityInfoPercentage = (float)percentage;
			this.SetLoadPercentage((float)gameQualityLoadInfo.Percentage, gameQualityLoadInfo.BarColor);
			this.SetLoadDesc(gameQualityLoadInfo.Desc);
		}

		// Token: 0x06036F78 RID: 225144 RVA: 0x00D056F0 File Offset: 0x00D038F0
		private void MobileSwitchTouch()
		{
			if (Info.Instance.IsMobileInputModel() && Info.Instance.IsInGamepad())
			{
				MobileSwitchInputController.Instance.SwitchToTouch();
			}
		}

		// Token: 0x06036F79 RID: 225145 RVA: 0x00D05714 File Offset: 0x00D03914
		private void OnClickApplyBtn(int _)
		{
			EGameQualitySettingLevel? recommendQualityLv = GameSettingsDeviceRender.Instance.GetRecommendQualityLv();
			if (recommendQualityLv == null)
			{
				return;
			}
			EGameQualitySettingLevel targetLevel = GameSettingsManager.Instance.ClampQualityByResourceTier(recommendQualityLv.Value);
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ApplyImageQualityConfirm);
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				MenuModel.Instance.HasApplyRecommendData = true;
				MenuController.Instance.HandleFireSaveMenuChange(MenuModel.Instance.GetMenuDataByFunctionId(10), (float)targetLevel);
				this.RefreshApplyBtn();
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06036F7A RID: 225146 RVA: 0x00D0578C File Offset: 0x00D0398C
		private void RefreshApplyBtn()
		{
			EGameQualitySettingLevel? recommendQualityLv = GameSettingsDeviceRender.Instance.GetRecommendQualityLv();
			EGameQualitySettingLevel? egameQualitySettingLevel = (recommendQualityLv != null) ? new EGameQualitySettingLevel?(GameSettingsManager.Instance.ClampQualityByResourceTier(recommendQualityLv.Value)) : null;
			if (egameQualitySettingLevel != null)
			{
				int? dataCacheOrCurValue = MenuModel.Instance.GetDataCacheOrCurValue(EFunction.IMAGEQUALITY);
				int value = (int)egameQualitySettingLevel.Value;
				if ((dataCacheOrCurValue.GetValueOrDefault() == value & dataCacheOrCurValue != null) && !MenuModel.Instance.IsImageQualityCustom)
				{
					this.SetEnableApplyButton(false);
					return;
				}
			}
			this.SetEnableApplyButton(true);
		}

		// Token: 0x06036F7B RID: 225147 RVA: 0x00D0581E File Offset: 0x00D03A1E
		private void SetEnableApplyButton(bool enable)
		{
			if (this.ApplyBtnItem == null)
			{
				return;
			}
			this.ApplyBtnItem.SetEnableClick(enable);
			this.ApplyBtnItem.SetLocalTextNew(enable ? "ImageSetting_ApplyRec" : "ImageSetting_AppledRec", Array.Empty<object>());
		}

		// Token: 0x06036F7C RID: 225148 RVA: 0x00D05854 File Offset: 0x00D03A54
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForTabType(string[] configParams)
		{
			if (configParams.Length < 2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "引导配置MenuView时参数不足";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ForTabType应有2个参数，但是实际只有", configParams.Length);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			int num = int.Parse(configParams[1]);
			int num2 = 0;
			for (int i = 0; i < this.MainTypeList.Count; i++)
			{
				if (this.MainTypeList[i] == num)
				{
					num2 = i;
					break;
				}
			}
			CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(num2);
			if (tabItemByIndex == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Guide;
				ELogAuthor author2 = ELogAuthor.WZ;
				string message2 = "引导配置MenuView时，未找到指定页签";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("targetIndex", num2);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return null;
			}
			this.TabComponent.ScrollToToggleByIndex(num2);
			UUIItem rootItem = tabItemByIndex.GetRootItem();
			return new UUIItem[]
			{
				rootItem,
				rootItem
			};
		}

		// Token: 0x06036F7D RID: 225149 RVA: 0x00D05930 File Offset: 0x00D03B30
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForKeySetting(string[] configParams)
		{
			if (configParams.Length < 2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "引导配置MenuView时参数不足";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ForKeySetting应有2个参数，但是实际只有", configParams.Length);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			int num = int.Parse(configParams[1]);
			KeySetting? config = ConfigKeySettingById.GetConfig(num, true);
			UUIItem guideItemByKeySettingId = this.KeySettingPanel.GetGuideItemByKeySettingId(num, new bool?(false));
			if (config == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Guide;
				ELogAuthor author2 = ELogAuthor.WZ;
				string message2 = "引导配置MenuView时找不到key setting";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("key setting id", num);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return null;
			}
			if (guideItemByKeySettingId == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				guideItemByKeySettingId,
				guideItemByKeySettingId
			};
		}

		// Token: 0x06036F7E RID: 225150 RVA: 0x00D059E4 File Offset: 0x00D03BE4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForMenuConfig(string[] configParams)
		{
			if (configParams.Length < 2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "引导配置MenuView时参数不足";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ForMenuConfig应有2个参数，但是实际只有", configParams.Length);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			int num = int.Parse(configParams[1]);
			int num2 = -1;
			for (int i = 0; i < this.MenuInfoDataArray.Count; i++)
			{
				MenuScrollItemData menuScrollItemData = this.MenuInfoDataArray[i];
				MenuData data = menuScrollItemData.Data;
				if (((data != null) ? new EFunction?(data.FunctionId) : null).Value == (EFunction)num && menuScrollItemData.Type == EMenuScrollItemType.SubItem)
				{
					num2 = i;
					break;
				}
			}
			if (num2 < 0)
			{
				return null;
			}
			if (!this.IsLateUpdateDone)
			{
				return null;
			}
			if (this.IsScrolling == null)
			{
				this.IsScrolling = new bool?(true);
				this.ScrollView.ScrollToItemIndex(num2, false, false).ContinueWith(delegate()
				{
					this.IsScrolling = new bool?(false);
				}).Forget();
			}
			if (this.IsScrolling.GetValueOrDefault())
			{
				return null;
			}
			int displayGridStartIndex = this.ScrollView.GetDisplayGridStartIndex();
			int displayGridEndIndex = this.ScrollView.GetDisplayGridEndIndex();
			if (num2 < displayGridStartIndex || num2 > displayGridEndIndex)
			{
				return null;
			}
			UUIItem grid = this.ScrollView.GetGrid(num2);
			if (grid != null)
			{
				this.ScrollView.AddListenerOnItemClear(num2, delegate
				{
					EventSystem.Instance.Emit<string>(EEventName.FinishGuideStepByEvent, "MenuView");
				});
				return new UUIItem[]
				{
					grid,
					grid
				};
			}
			return null;
		}

		// Token: 0x17008431 RID: 33841
		// (get) Token: 0x06036F7F RID: 225151 RVA: 0x00D05B64 File Offset: 0x00D03D64
		private Dictionary<string, TGuideItemBuilder> GuideUiItemBuilders
		{
			get
			{
				if (this.GuideUiItemBuildersInternal == null || this.GuideUiItemBuildersInternal.Count == 0)
				{
					this.GuideUiItemBuildersInternal = new Dictionary<string, TGuideItemBuilder>
					{
						{
							"TabType",
							new TGuideItemBuilder(this.BuilderForTabType)
						},
						{
							"KeySetting",
							new TGuideItemBuilder(this.BuilderForKeySetting)
						},
						{
							"MenuConfig",
							new TGuideItemBuilder(this.BuilderForMenuConfig)
						}
					};
				}
				return this.GuideUiItemBuildersInternal;
			}
		}

		// Token: 0x06036F80 RID: 225152 RVA: 0x00D05BDC File Offset: 0x00D03DDC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length < 1)
			{
				Log.Instance.Error(ELogModule.Guide, ELogAuthor.WZ, "引导配置MenuView时，必须要有Extra参数", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			TGuideItemBuilder tguideItemBuilder;
			if (this.GuideUiItemBuilders.TryGetValue(configParams[0], out tguideItemBuilder))
			{
				return tguideItemBuilder(configParams);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "引导配置MenuView，Extra键值与代码不匹配";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("配置中的值", configParams[0]);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x06036F81 RID: 225153 RVA: 0x00D05C51 File Offset: 0x00D03E51
		private MenuScrollSettingContainerItem OnSettingItemCreate(MenuScrollItemData data, UUIItem uiItem, int index)
		{
			MenuScrollSettingContainerItem menuScrollSettingContainerItem = new MenuScrollSettingContainerItem();
			menuScrollSettingContainerItem.BindOnToggleStateChangedCallback(new Action<MenuScrollSettingContainerItem, EToggleState>(this.OnMenuScrollSettingContainerItemToggleReleased));
			menuScrollSettingContainerItem.BindOnDetailPopOpenCallback(new Action<MenuScrollSettingContainerItem>(this.OnDetailPopOpenCallback));
			return menuScrollSettingContainerItem;
		}

		// Token: 0x06036F82 RID: 225154 RVA: 0x00D05C7C File Offset: 0x00D03E7C
		private void OnMenuScrollSettingContainerItemToggleReleased(MenuScrollSettingContainerItem item, EToggleState state)
		{
			EMenuScrollItemType? type = item.Type;
			EMenuScrollItemType emenuScrollItemType = EMenuScrollItemType.TitleItem;
			if (type.GetValueOrDefault() == emenuScrollItemType & type != null)
			{
				return;
			}
			MenuData menuData = item.GetMenuData();
			if (menuData == null)
			{
				return;
			}
			if (state == EToggleState.ETT_UnChecked)
			{
				this.ClearSelectedDisplay(item);
				return;
			}
			this.RemoveNextScrollToButtonTimerHandle();
			MenuScrollSettingContainerItem selectedItem = this.SelectedItem;
			bool flag;
			if (selectedItem == null)
			{
				flag = false;
			}
			else
			{
				MenuData menuData2 = selectedItem.GetMenuData();
				flag = ((menuData2 != null) ? new bool?(menuData2.GetEnable()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				MenuScrollSettingContainerItem selectedItem2 = this.SelectedItem;
				if (selectedItem2 != null)
				{
					selectedItem2.SetSelected(false);
				}
			}
			MenuScrollSettingContainerItem selectedItem3 = this.SelectedItem;
			if (selectedItem3 != null)
			{
				selectedItem3.SetDetailVisible(false);
			}
			item.SetDetailVisible(!menuData.GetIsDetailTextVisible());
			item.SetSelected(true);
			this.SelectedItem = item;
			this.SelectedDetailMenuData = menuData;
			MenuScrollItemData menuScrollItemData = item.MenuScrollItemData;
			if (menuData.HasDetailText() && menuScrollItemData != null && this.MenuInfoDataArray.IndexOf(menuScrollItemData) >= this.MenuInfoDataArray.Count - 1)
			{
				this.NextScrollToButtonTimerHandle = TimerSystem.GameplayTimeInstance.Next(delegate(float _)
				{
					this.ScrollView.ScrollToBottom(item.GetRootItem());
				}, null, null);
			}
		}

		// Token: 0x06036F83 RID: 225155 RVA: 0x00D05DC8 File Offset: 0x00D03FC8
		private void OnDetailPopOpenCallback(MenuScrollSettingContainerItem item)
		{
			MenuData menuData = item.GetMenuData();
			if (menuData == null)
			{
				return;
			}
			int detailPopId = menuData.GetDetailPopId();
			if (detailPopId > 0)
			{
				UiManager.Instance.OpenView(EUiViewName.MenuDetailPopView, detailPopId, null);
			}
		}

		// Token: 0x06036F84 RID: 225156 RVA: 0x00D05E01 File Offset: 0x00D04001
		private void RemoveNextScrollToButtonTimerHandle()
		{
			if (this.NextScrollToButtonTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.NextScrollToButtonTimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.NextScrollToButtonTimerHandle);
			}
			this.NextScrollToButtonTimerHandle = null;
		}

		// Token: 0x06036F85 RID: 225157 RVA: 0x00D05E38 File Offset: 0x00D04038
		[NullableContext(2)]
		private void ClearSelectedDisplay(MenuScrollSettingContainerItem selectedItem)
		{
			if (selectedItem != this.SelectedItem)
			{
				if (selectedItem != null)
				{
					selectedItem.SetDetailVisible(false);
				}
				if (selectedItem != null)
				{
					selectedItem.SetSelected(false);
				}
			}
			else
			{
				MenuScrollSettingContainerItem selectedItem2 = this.SelectedItem;
				if (selectedItem2 != null)
				{
					selectedItem2.SetDetailVisible(false);
				}
				MenuScrollSettingContainerItem selectedItem3 = this.SelectedItem;
				if (selectedItem3 != null)
				{
					selectedItem3.SetSelected(false);
				}
			}
			MenuData selectedDetailMenuData = this.SelectedDetailMenuData;
			if (selectedDetailMenuData != null)
			{
				selectedDetailMenuData.SetDetailTextVisible(false);
			}
			this.SelectedItem = null;
			this.SelectedDetailMenuData = null;
		}

		// Token: 0x06036F86 RID: 225158 RVA: 0x00D05EA8 File Offset: 0x00D040A8
		private UniTask InitTabScroll()
		{
			MenuView.<InitTabScroll>d__50 <InitTabScroll>d__;
			<InitTabScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTabScroll>d__.<>4__this = this;
			<InitTabScroll>d__.<>1__state = -1;
			<InitTabScroll>d__.<>t__builder.Start<MenuView.<InitTabScroll>d__50>(ref <InitTabScroll>d__);
			return <InitTabScroll>d__.<>t__builder.Task;
		}

		// Token: 0x06036F87 RID: 225159 RVA: 0x00D05EEB File Offset: 0x00D040EB
		private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x06036F88 RID: 225160 RVA: 0x00D05EF4 File Offset: 0x00D040F4
		private List<CommonTabItemData> CreateTabItemData()
		{
			List<CommonTabItemData> list = new List<CommonTabItemData>();
			for (int i = 0; i < this.MainTypeList.Count; i++)
			{
				CommonTabItemData commonTabItemData = new CommonTabItemData();
				commonTabItemData.Index = i;
				commonTabItemData.Data = this.GetCommonData(i);
				if (this.MainTypeList[i] == 5)
				{
					commonTabItemData.RedDotName = new ERedDotName?(ERedDotName.RedDotVersionCheck);
				}
				list.Add(commonTabItemData);
			}
			return list;
		}

		// Token: 0x06036F89 RID: 225161 RVA: 0x00D05F60 File Offset: 0x00D04160
		private void OnClickedItem(int index)
		{
			int num = this.MainTypeList[index];
			this.MenuViewData.MenuViewDataCurMainType = num;
			MainType? mainTypeConfigById = MenuBaseConfig.Instance.GetMainTypeConfigById(num);
			UUIItem item = base.GetItem(5);
			UUIItem item2 = base.GetItem(4);
			if (mainTypeConfigById == null)
			{
				item.SetUIActive(false);
				item2.SetUIActive(false);
				return;
			}
			int num2 = mainTypeConfigById.Value.TabPanelType;
			if (Info.Instance.IsPcPlatform() && !Info.Instance.IsWinGDKPlatform())
			{
				if (CloudGameManager.Instance.IsCloudGame)
				{
					if (Info.Instance.IsInGamepad())
					{
						num2 = mainTypeConfigById.Value.PsTabPanelType;
					}
					else if (Info.Instance.IsMobileInputModel())
					{
						num2 = mainTypeConfigById.Value.TabPanelType;
					}
					else if (Info.Instance.IsPcInputModel())
					{
						num2 = mainTypeConfigById.Value.PcTabPanelType;
					}
				}
				else
				{
					num2 = mainTypeConfigById.Value.PcTabPanelType;
				}
			}
			else if (Info.Instance.IsPs5Platform())
			{
				num2 = mainTypeConfigById.Value.PsTabPanelType;
			}
			else if (Info.Instance.IsXboxPlatform())
			{
				num2 = mainTypeConfigById.Value.XboxTabPanelType;
			}
			else if (Info.Instance.IsMobilePlatform() && Info.Instance.IsInGamepad())
			{
				num2 = mainTypeConfigById.Value.PsTabPanelType;
			}
			if (num == 2)
			{
				ButtonItem applyBtnItem = this.ApplyBtnItem;
				if (applyBtnItem != null)
				{
					applyBtnItem.SetUiActive(true);
				}
			}
			else
			{
				ButtonItem applyBtnItem2 = this.ApplyBtnItem;
				if (applyBtnItem2 != null)
				{
					applyBtnItem2.SetUiActive(false);
				}
			}
			ESettingTabPanelType esettingTabPanelType = (ESettingTabPanelType)num2;
			if (esettingTabPanelType != ESettingTabPanelType.CommonSetting)
			{
				if (esettingTabPanelType != ESettingTabPanelType.KeySetting)
				{
					item.SetUIActive(false);
					item2.SetUIActive(false);
				}
				else
				{
					this.RefreshKeySetting();
					item.SetUIActive(false);
					item2.SetUIActive(true);
				}
			}
			else
			{
				this.RefreshCommonSetting();
				item.SetUIActive(true);
				item2.SetUIActive(false);
			}
			this.ClearSelectedDisplay(this.SelectedItem);
			EventSystem.Instance.Emit<string>(EEventName.FinishGuideStepByEvent, "MenuView");
		}

		// Token: 0x06036F8A RID: 225162 RVA: 0x00D06174 File Offset: 0x00D04374
		private CommonTabData GetCommonData(int index)
		{
			int typeId = this.MainTypeList[index];
			MainType targetMainInfo = MenuController.Instance.GetTargetMainInfo(typeId);
			return new CommonTabData(targetMainInfo.MainIcon, new CommonTabTitleData(targetMainInfo.MainName, Array.Empty<object>()), null);
		}

		// Token: 0x06036F8B RID: 225163 RVA: 0x00D061B8 File Offset: 0x00D043B8
		private void RefreshCommonSetting()
		{
			this.RefreshConfig();
		}

		// Token: 0x06036F8C RID: 225164 RVA: 0x00D061C0 File Offset: 0x00D043C0
		private void RefreshKeySetting()
		{
			EInputControllerType inputControllerType = EInputControllerType.None;
			if (Info.Instance.IsInKeyBoard())
			{
				inputControllerType = EInputControllerType.Keyboard;
			}
			else if (Info.Instance.IsInGamepad())
			{
				inputControllerType = EInputControllerType.Gamepad;
			}
			if (this.KeySettingPanel == null)
			{
				this.KeySettingPanel = new PcAndGamepadKeySettingPanel();
				this.KeySettingPanel.CreateThenShowByResourceIdAsync("UiItem_HandleSet", base.GetItem(4), false).ContinueWith(delegate()
				{
					this.KeySettingPanel.Refresh(inputControllerType);
				}).Forget();
				return;
			}
			this.KeySettingPanel.Refresh(inputControllerType);
		}

		// Token: 0x06036F8D RID: 225165 RVA: 0x00D0625C File Offset: 0x00D0445C
		private void RefreshConfig()
		{
			List<MenuData> targetBaseConfigData = MenuController.Instance.GetTargetBaseConfigData(this.MenuViewData.MenuViewDataCurMainType, this.ItemFilter);
			if (this.MenuViewData.MenuViewDataCurMainType == 2 && (Platform.Instance.IsMobilePlatform() || Platform.Instance.IsPcPlatform()))
			{
				UUIItem item = base.GetItem(3);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				this.RefreshGameQualityLoad(true);
			}
			else
			{
				UUIItem item2 = base.GetItem(3);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
			}
			this.MenuViewData.MenuViewDataLastSubType = 0;
			this.RecycleInfoDataArray();
			this.RefreshMenuInfoDataArray(targetBaseConfigData);
		}

		// Token: 0x06036F8E RID: 225166 RVA: 0x00D062F4 File Offset: 0x00D044F4
		private void SetLoadDesc(string desc)
		{
			UUIItem item = base.GetItem(3);
			UUIText uiText = ((item != null) ? item.GetAttachUIChildren().Get(1) : null) as UUIText;
			LguiUtil.Instance.SetLocalTextNew(uiText, desc, Array.Empty<object>());
		}

		// Token: 0x06036F8F RID: 225167 RVA: 0x00D06334 File Offset: 0x00D04534
		private void SetLoadPercentage(float val, string color)
		{
			UUIItem item = base.GetItem(3);
			UUIItem uuiitem = (item != null) ? item.GetAttachUIChildren().Get(3) : null;
			if (uuiitem == null)
			{
				return;
			}
			TArray<UUIItem> attachUIChildren = uuiitem.GetAttachUIChildren();
			UUIItem uuiitem2 = (item != null) ? item.GetAttachUIChildren().Get(4) : null;
			if (uuiitem2 == null)
			{
				return;
			}
			float width = uuiitem2.Width;
			float[] array = new float[5];
			if (val >= 100f)
			{
				for (int i = 0; i < attachUIChildren.Num(); i++)
				{
					array[i] = width;
				}
			}
			else if (val >= 80f)
			{
				for (int j = 0; j < attachUIChildren.Num() - 1; j++)
				{
					array[j] = width;
				}
				float num = (val - 80f) * 5f;
				array[4] = width * (num / 100f);
			}
			else if (val >= 60f)
			{
				for (int k = 0; k < attachUIChildren.Num() - 2; k++)
				{
					array[k] = width;
				}
				float num2 = (val - 60f) * 5f;
				array[3] = width * (num2 / 100f);
			}
			else if (val >= 40f)
			{
				for (int l = 0; l < attachUIChildren.Num() - 3; l++)
				{
					array[l] = width;
				}
				float num3 = (val - 40f) * 5f;
				array[2] = width * (num3 / 100f);
			}
			else if (val >= 20f)
			{
				for (int m = 0; m < attachUIChildren.Num() - 4; m++)
				{
					array[m] = width;
				}
				float num4 = (val - 20f) * 5f;
				array[1] = width * (num4 / 100f);
			}
			else
			{
				float num5 = val * 5f;
				array[0] = width * (num5 / 100f);
			}
			for (int n = 0; n < attachUIChildren.Num(); n++)
			{
				UUISprite uuisprite = attachUIChildren.Get(n) as UUISprite;
				uuisprite.SetWidth(array[n]);
				this.SetSpriteByPath(color, uuisprite, false, null, null);
			}
		}

		// Token: 0x06036F90 RID: 225168 RVA: 0x00D06534 File Offset: 0x00D04734
		private void RecycleInfoDataArray()
		{
			foreach (MenuScrollItemData value in this.MenuInfoDataArray)
			{
				this.ScrollItemPool.Put(value);
			}
			this.MenuInfoDataArray.Clear();
		}

		// Token: 0x06036F91 RID: 225169 RVA: 0x00D06598 File Offset: 0x00D04798
		private void GetMenuScrollItemData(MenuData data, EMenuScrollItemType itemType)
		{
			MenuScrollItemData menuScrollItemData = this.ScrollItemPool.Get();
			if (menuScrollItemData == null)
			{
				menuScrollItemData = this.ScrollItemPool.Create();
			}
			menuScrollItemData.Type = itemType;
			menuScrollItemData.Data = data;
			this.MenuInfoDataArray.Add(menuScrollItemData);
		}

		// Token: 0x06036F92 RID: 225170 RVA: 0x00D065DC File Offset: 0x00D047DC
		private void RefreshMenuInfoDataArray(List<MenuData> menuDataArray)
		{
			foreach (MenuData menuData in menuDataArray)
			{
				if (menuData.SubType != this.MenuViewData.MenuViewDataLastSubType)
				{
					this.MenuViewData.MenuViewDataLastSubType = menuData.SubType;
					this.GetMenuScrollItemData(menuData, EMenuScrollItemType.TitleItem);
				}
				this.GetMenuScrollItemData(menuData, EMenuScrollItemType.SubItem);
			}
			this.IsLateUpdateDone = false;
			this.ScrollView.RefreshByData(this.MenuInfoDataArray.ToArray(), false, true);
			this.ScrollView.BindLateUpdate(new Action<float>(this.OnLateUpdate));
		}

		// Token: 0x06036F93 RID: 225171 RVA: 0x00D06690 File Offset: 0x00D04890
		private void OnLateUpdate(float _)
		{
			this.ScrollView.ScrollToItemIndex(0, true, true).Forget();
			this.ScrollView.UnBindLateUpdate();
			this.IsLateUpdateDone = true;
		}

		// Token: 0x06036F94 RID: 225172 RVA: 0x00D066B8 File Offset: 0x00D048B8
		private void OnCloseView()
		{
			MenuModel instance = MenuModel.Instance;
			GameQualityLoadInfo gameQualityLoadInfo = (instance != null) ? instance.GetGameQualityLoadInfo() : null;
			if (((gameQualityLoadInfo != null) ? gameQualityLoadInfo.Desc : null) == "Text_SettingLoadOver_text")
			{
				MenuModel instance2 = MenuModel.Instance;
				if (instance2 != null && instance2.HasDataCache())
				{
					this.OpenConfirmBox();
					return;
				}
			}
			this.CloseMySelf().Forget();
		}

		// Token: 0x06036F95 RID: 225173 RVA: 0x00D06714 File Offset: 0x00D04914
		public void OpenConfirmBox()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.GameQualityLoadOver);
			confirmBoxDataNew.FunctionMap.Add(1, delegate
			{
				this.CloseMySelf().Forget();
			});
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				this.TabComponent.SelectToggleByIndex(1, false);
			});
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06036F96 RID: 225174 RVA: 0x00D06770 File Offset: 0x00D04970
		private UniTask CloseMySelf()
		{
			MenuView.<CloseMySelf>d__66 <CloseMySelf>d__;
			<CloseMySelf>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseMySelf>d__.<>4__this = this;
			<CloseMySelf>d__.<>1__state = -1;
			<CloseMySelf>d__.<>t__builder.Start<MenuView.<CloseMySelf>d__66>(ref <CloseMySelf>d__);
			return <CloseMySelf>d__.<>t__builder.Task;
		}

		// Token: 0x06036F97 RID: 225175 RVA: 0x00D067B3 File Offset: 0x00D049B3
		private void RefreshLoginCacheIfNeed()
		{
			if (!GameSettingsManager.Instance.IsGameSettingsAppliedOnOpenLoading)
			{
				GameSettingsManager.Instance.RefreshLoginOverrideCache();
			}
		}

		// Token: 0x0401D011 RID: 118801
		private const int CAPACITY = 20;

		// Token: 0x0401D012 RID: 118802
		private List<int> MainTypeList = new List<int>();

		// Token: 0x0401D013 RID: 118803
		private List<MenuScrollItemData> MenuInfoDataArray = new List<MenuScrollItemData>();

		// Token: 0x0401D014 RID: 118804
		[Nullable(2)]
		private MenuScrollSettingContainerDynItem MenuScrollSettingContainerDynItem;

		// Token: 0x0401D015 RID: 118805
		private readonly MenuViewData MenuViewData = new MenuViewData();

		// Token: 0x0401D016 RID: 118806
		[Nullable(2)]
		private MenuScrollSettingContainerItem SelectedItem;

		// Token: 0x0401D017 RID: 118807
		[Nullable(2)]
		private MenuData SelectedDetailMenuData;

		// Token: 0x0401D018 RID: 118808
		[Nullable(2)]
		private TimerHandle NextScrollToButtonTimerHandle;

		// Token: 0x0401D019 RID: 118809
		[Nullable(2)]
		private UiSequencePlayer ProgressSequencePlayer;

		// Token: 0x0401D01A RID: 118810
		private bool IsClosing;

		// Token: 0x0401D01B RID: 118811
		[Nullable(2)]
		private ButtonItem ApplyBtnItem;

		// Token: 0x0401D01C RID: 118812
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401D01D RID: 118813
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<MenuScrollSettingContainerItem, MenuScrollSettingContainerDynItem, MenuScrollItemData> ScrollView;

		// Token: 0x0401D01E RID: 118814
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Pool<MenuScrollItemData> ScrollItemPool;

		// Token: 0x0401D01F RID: 118815
		[Nullable(2)]
		private PcAndGamepadKeySettingPanel KeySettingPanel;

		// Token: 0x0401D020 RID: 118816
		[Nullable(2)]
		private TMenuItemFilter ItemFilter;

		// Token: 0x0401D021 RID: 118817
		private bool IsLateUpdateDone;

		// Token: 0x0401D022 RID: 118818
		private bool? IsScrolling;

		// Token: 0x0401D023 RID: 118819
		private Dictionary<string, TGuideItemBuilder> GuideUiItemBuildersInternal;

		// Token: 0x0200B68F RID: 46735
		[NullableContext(0)]
		private enum EMenuViewComponent
		{
			// Token: 0x040374F6 RID: 226550
			ScrollView,
			// Token: 0x040374F7 RID: 226551
			TabComponent,
			// Token: 0x040374F8 RID: 226552
			SettingItem,
			// Token: 0x040374F9 RID: 226553
			PnlLoad,
			// Token: 0x040374FA RID: 226554
			KeySettingPanelItem,
			// Token: 0x040374FB RID: 226555
			CommonSettingPanelItem,
			// Token: 0x040374FC RID: 226556
			MobileSwitchTouchBtn,
			// Token: 0x040374FD RID: 226557
			ProgressBar,
			// Token: 0x040374FE RID: 226558
			ProgressText,
			// Token: 0x040374FF RID: 226559
			ApplyBtn
		}
	}
}
