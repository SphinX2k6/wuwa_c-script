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
	// Token: 0x020043EB RID: 17387
	[NullableContext(1)]
	[Nullable(0)]
	public class MenuView : UiViewBase
	{
		// Token: 0x170057FC RID: 22524
		// (get) Token: 0x0602BEB2 RID: 179890 RVA: 0x00C5459B File Offset: 0x00C5279B
		public MenuViewData MenuViewDataExternal
		{
			get
			{
				return this.MenuViewData;
			}
		}

		// Token: 0x0602BEB3 RID: 179891 RVA: 0x00C545A3 File Offset: 0x00C527A3
		public MenuView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BEB4 RID: 179892 RVA: 0x00C545D0 File Offset: 0x00C527D0
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

		// Token: 0x0602BEB5 RID: 179893 RVA: 0x00C546E8 File Offset: 0x00C528E8
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

		// Token: 0x0602BEB6 RID: 179894 RVA: 0x00C547B0 File Offset: 0x00C529B0
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

		// Token: 0x0602BEB7 RID: 179895 RVA: 0x00C54868 File Offset: 0x00C52A68
		protected override UniTask OnBeforeStartAsync()
		{
			MenuView.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MenuView.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BEB8 RID: 179896 RVA: 0x00C548AC File Offset: 0x00C52AAC
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

		// Token: 0x0602BEB9 RID: 179897 RVA: 0x00C548E9 File Offset: 0x00C52AE9
		private MenuScrollItemData Creator()
		{
			return new MenuScrollItemData();
		}

		// Token: 0x0602BEBA RID: 179898 RVA: 0x00C548F0 File Offset: 0x00C52AF0
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

		// Token: 0x0602BEBB RID: 179899 RVA: 0x00C549AC File Offset: 0x00C52BAC
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

		// Token: 0x0602BEBC RID: 179900 RVA: 0x00C54A65 File Offset: 0x00C52C65
		private void RefreshTextLanguage(string s, string s1)
		{
			this.RefreshConfig();
		}

		// Token: 0x0602BEBD RID: 179901 RVA: 0x00C54A6D File Offset: 0x00C52C6D
		private void OnRefreshMenuSetting(EFunction functionId)
		{
			if (functionId == EFunction.IMAGEQUALITY)
			{
				this.RefreshApplyBtn();
			}
		}

		// Token: 0x0602BEBE RID: 179902 RVA: 0x00C54A7A File Offset: 0x00C52C7A
		private void OnDropDownListVisibleChanged(bool bVisible)
		{
			if (!bVisible)
			{
				return;
			}
			base.GetUIDynScrollViewComponent(0).StopMovement();
		}

		// Token: 0x0602BEBF RID: 179903 RVA: 0x00C54A8C File Offset: 0x00C52C8C
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

		// Token: 0x0602BEC0 RID: 179904 RVA: 0x00C54B34 File Offset: 0x00C52D34
		private void MobileSwitchTouch()
		{
			if (Info.Instance.IsMobileInputModel() && Info.Instance.IsInGamepad())
			{
				MobileSwitchInputController.Instance.SwitchToTouch();
			}
		}

		// Token: 0x0602BEC1 RID: 179905 RVA: 0x00C54B58 File Offset: 0x00C52D58
		private void OnClickApplyBtn(int _)
		{
			EGameQualitySettingLevel? recommendLevel = GameSettingsDeviceRender.Instance.GetRecommendQualityLv();
			if (recommendLevel == null)
			{
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ApplyImageQualityConfirm);
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				MenuModel.Instance.HasApplyRecommendData = true;
				MenuController.Instance.HandleFireSaveMenuChange(MenuModel.Instance.GetMenuDataByFunctionId(10), (float)recommendLevel.Value);
				this.RefreshApplyBtn();
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602BEC2 RID: 179906 RVA: 0x00C54BC0 File Offset: 0x00C52DC0
		private void RefreshApplyBtn()
		{
			EGameQualitySettingLevel? recommendQualityLv = GameSettingsDeviceRender.Instance.GetRecommendQualityLv();
			if (recommendQualityLv != null)
			{
				int? dataCacheOrCurValue = MenuModel.Instance.GetDataCacheOrCurValue(EFunction.IMAGEQUALITY);
				int value = (int)recommendQualityLv.Value;
				if ((dataCacheOrCurValue.GetValueOrDefault() == value & dataCacheOrCurValue != null) && !MenuModel.Instance.IsImageQualityCustom)
				{
					this.SetEnableApplyButton(false);
					return;
				}
			}
			this.SetEnableApplyButton(true);
		}

		// Token: 0x0602BEC3 RID: 179907 RVA: 0x00C54C25 File Offset: 0x00C52E25
		private void SetEnableApplyButton(bool enable)
		{
			if (this.ApplyBtnItem == null)
			{
				return;
			}
			this.ApplyBtnItem.SetEnableClick(enable);
			this.ApplyBtnItem.SetLocalTextNew(enable ? "ImageSetting_ApplyRec" : "ImageSetting_AppledRec", Array.Empty<object>());
		}

		// Token: 0x0602BEC4 RID: 179908 RVA: 0x00C54C5C File Offset: 0x00C52E5C
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

		// Token: 0x0602BEC5 RID: 179909 RVA: 0x00C54D38 File Offset: 0x00C52F38
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

		// Token: 0x0602BEC6 RID: 179910 RVA: 0x00C54DEC File Offset: 0x00C52FEC
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

		// Token: 0x170057FD RID: 22525
		// (get) Token: 0x0602BEC7 RID: 179911 RVA: 0x00C54F6C File Offset: 0x00C5316C
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

		// Token: 0x0602BEC8 RID: 179912 RVA: 0x00C54FE4 File Offset: 0x00C531E4
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

		// Token: 0x0602BEC9 RID: 179913 RVA: 0x00C55059 File Offset: 0x00C53259
		private MenuScrollSettingContainerItem OnSettingItemCreate(MenuScrollItemData data, UUIItem uiItem, int index)
		{
			MenuScrollSettingContainerItem menuScrollSettingContainerItem = new MenuScrollSettingContainerItem();
			menuScrollSettingContainerItem.BindOnToggleStateChangedCallback(new Action<MenuScrollSettingContainerItem, EToggleState>(this.OnMenuScrollSettingContainerItemToggleReleased));
			menuScrollSettingContainerItem.BindOnDetailPopOpenCallback(new Action<MenuScrollSettingContainerItem>(this.OnDetailPopOpenCallback));
			return menuScrollSettingContainerItem;
		}

		// Token: 0x0602BECA RID: 179914 RVA: 0x00C55084 File Offset: 0x00C53284
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

		// Token: 0x0602BECB RID: 179915 RVA: 0x00C551D0 File Offset: 0x00C533D0
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

		// Token: 0x0602BECC RID: 179916 RVA: 0x00C55209 File Offset: 0x00C53409
		private void RemoveNextScrollToButtonTimerHandle()
		{
			if (this.NextScrollToButtonTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.NextScrollToButtonTimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.NextScrollToButtonTimerHandle);
			}
			this.NextScrollToButtonTimerHandle = null;
		}

		// Token: 0x0602BECD RID: 179917 RVA: 0x00C55240 File Offset: 0x00C53440
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

		// Token: 0x0602BECE RID: 179918 RVA: 0x00C552B0 File Offset: 0x00C534B0
		private UniTask InitTabScroll()
		{
			MenuView.<InitTabScroll>d__50 <InitTabScroll>d__;
			<InitTabScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTabScroll>d__.<>4__this = this;
			<InitTabScroll>d__.<>1__state = -1;
			<InitTabScroll>d__.<>t__builder.Start<MenuView.<InitTabScroll>d__50>(ref <InitTabScroll>d__);
			return <InitTabScroll>d__.<>t__builder.Task;
		}

		// Token: 0x0602BECF RID: 179919 RVA: 0x00C552F3 File Offset: 0x00C534F3
		private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x0602BED0 RID: 179920 RVA: 0x00C552FC File Offset: 0x00C534FC
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

		// Token: 0x0602BED1 RID: 179921 RVA: 0x00C55368 File Offset: 0x00C53568
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

		// Token: 0x0602BED2 RID: 179922 RVA: 0x00C5557C File Offset: 0x00C5377C
		private CommonTabData GetCommonData(int index)
		{
			int typeId = this.MainTypeList[index];
			MainType targetMainInfo = MenuController.Instance.GetTargetMainInfo(typeId);
			return new CommonTabData(targetMainInfo.MainIcon, new CommonTabTitleData(targetMainInfo.MainName, Array.Empty<object>()), null);
		}

		// Token: 0x0602BED3 RID: 179923 RVA: 0x00C555C0 File Offset: 0x00C537C0
		private void RefreshCommonSetting()
		{
			this.RefreshConfig();
		}

		// Token: 0x0602BED4 RID: 179924 RVA: 0x00C555C8 File Offset: 0x00C537C8
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

		// Token: 0x0602BED5 RID: 179925 RVA: 0x00C55664 File Offset: 0x00C53864
		private void RefreshConfig()
		{
			List<MenuData> targetBaseConfigData = MenuController.Instance.GetTargetBaseConfigData(this.MenuViewData.MenuViewDataCurMainType, this.ItemFilter);
			if (this.MenuViewData.MenuViewDataCurMainType == 2)
			{
				this.RestoreUnavailableTestImageSettings();
			}
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

		// Token: 0x0602BED6 RID: 179926 RVA: 0x00C5570F File Offset: 0x00C5390F
		private void RestoreUnavailableTestImageSettings()
		{
		}

		// Token: 0x0602BED7 RID: 179927 RVA: 0x00C55714 File Offset: 0x00C53914
		private void SetLoadDesc(string desc)
		{
			UUIItem item = base.GetItem(3);
			UUIText uiText = ((item != null) ? item.GetAttachUIChildren().Get(1) : null) as UUIText;
			LguiUtil.Instance.SetLocalTextNew(uiText, desc, Array.Empty<object>());
		}

		// Token: 0x0602BED8 RID: 179928 RVA: 0x00C55754 File Offset: 0x00C53954
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

		// Token: 0x0602BED9 RID: 179929 RVA: 0x00C55954 File Offset: 0x00C53B54
		private void RecycleInfoDataArray()
		{
			foreach (MenuScrollItemData value in this.MenuInfoDataArray)
			{
				this.ScrollItemPool.Put(value);
			}
			this.MenuInfoDataArray.Clear();
		}

		// Token: 0x0602BEDA RID: 179930 RVA: 0x00C559B8 File Offset: 0x00C53BB8
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

		// Token: 0x0602BEDB RID: 179931 RVA: 0x00C559FC File Offset: 0x00C53BFC
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

		// Token: 0x0602BEDC RID: 179932 RVA: 0x00C55AB0 File Offset: 0x00C53CB0
		private void OnLateUpdate(float _)
		{
			this.ScrollView.ScrollToItemIndex(0, true, true).Forget();
			this.ScrollView.UnBindLateUpdate();
			this.IsLateUpdateDone = true;
		}

		// Token: 0x0602BEDD RID: 179933 RVA: 0x00C55AD8 File Offset: 0x00C53CD8
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

		// Token: 0x0602BEDE RID: 179934 RVA: 0x00C55B34 File Offset: 0x00C53D34
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

		// Token: 0x0602BEDF RID: 179935 RVA: 0x00C55B90 File Offset: 0x00C53D90
		private UniTask CloseMySelf()
		{
			MenuView.<CloseMySelf>d__67 <CloseMySelf>d__;
			<CloseMySelf>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseMySelf>d__.<>4__this = this;
			<CloseMySelf>d__.<>1__state = -1;
			<CloseMySelf>d__.<>t__builder.Start<MenuView.<CloseMySelf>d__67>(ref <CloseMySelf>d__);
			return <CloseMySelf>d__.<>t__builder.Task;
		}

		// Token: 0x0602BEE0 RID: 179936 RVA: 0x00C55BD3 File Offset: 0x00C53DD3
		private void RefreshLoginCacheIfNeed()
		{
			if (!GameSettingsManager.Instance.IsGameSettingsAppliedOnOpenLoading)
			{
				GameSettingsManager.Instance.RefreshLoginOverrideCache();
			}
		}

		// Token: 0x04017AAA RID: 96938
		private const int CAPACITY = 20;

		// Token: 0x04017AAB RID: 96939
		private List<int> MainTypeList = new List<int>();

		// Token: 0x04017AAC RID: 96940
		private List<MenuScrollItemData> MenuInfoDataArray = new List<MenuScrollItemData>();

		// Token: 0x04017AAD RID: 96941
		[Nullable(2)]
		private MenuScrollSettingContainerDynItem MenuScrollSettingContainerDynItem;

		// Token: 0x04017AAE RID: 96942
		private readonly MenuViewData MenuViewData = new MenuViewData();

		// Token: 0x04017AAF RID: 96943
		[Nullable(2)]
		private MenuScrollSettingContainerItem SelectedItem;

		// Token: 0x04017AB0 RID: 96944
		[Nullable(2)]
		private MenuData SelectedDetailMenuData;

		// Token: 0x04017AB1 RID: 96945
		[Nullable(2)]
		private TimerHandle NextScrollToButtonTimerHandle;

		// Token: 0x04017AB2 RID: 96946
		[Nullable(2)]
		private UiSequencePlayer ProgressSequencePlayer;

		// Token: 0x04017AB3 RID: 96947
		private bool IsClosing;

		// Token: 0x04017AB4 RID: 96948
		[Nullable(2)]
		private ButtonItem ApplyBtnItem;

		// Token: 0x04017AB5 RID: 96949
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x04017AB6 RID: 96950
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<MenuScrollSettingContainerItem, MenuScrollSettingContainerDynItem, MenuScrollItemData> ScrollView;

		// Token: 0x04017AB7 RID: 96951
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Pool<MenuScrollItemData> ScrollItemPool;

		// Token: 0x04017AB8 RID: 96952
		[Nullable(2)]
		private PcAndGamepadKeySettingPanel KeySettingPanel;

		// Token: 0x04017AB9 RID: 96953
		[Nullable(2)]
		private TMenuItemFilter ItemFilter;

		// Token: 0x04017ABA RID: 96954
		private bool IsLateUpdateDone;

		// Token: 0x04017ABB RID: 96955
		private bool? IsScrolling;

		// Token: 0x04017ABC RID: 96956
		private Dictionary<string, TGuideItemBuilder> GuideUiItemBuildersInternal;

		// Token: 0x0200A0C7 RID: 41159
		[NullableContext(0)]
		private enum EMenuViewComponent
		{
			// Token: 0x04031F4B RID: 204619
			ScrollView,
			// Token: 0x04031F4C RID: 204620
			TabComponent,
			// Token: 0x04031F4D RID: 204621
			SettingItem,
			// Token: 0x04031F4E RID: 204622
			PnlLoad,
			// Token: 0x04031F4F RID: 204623
			KeySettingPanelItem,
			// Token: 0x04031F50 RID: 204624
			CommonSettingPanelItem,
			// Token: 0x04031F51 RID: 204625
			MobileSwitchTouchBtn,
			// Token: 0x04031F52 RID: 204626
			ProgressBar,
			// Token: 0x04031F53 RID: 204627
			ProgressText,
			// Token: 0x04031F54 RID: 204628
			ApplyBtn
		}
	}
}
