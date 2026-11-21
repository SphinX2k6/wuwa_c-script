using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.GameSettings;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.Common.InputView.Controller;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Menu.SubViews;
using CSharpScript.Game.Module.Menu.SubViews.EyeProtect;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.PackageUpdate;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043C5 RID: 17349
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MenuController : UiControllerBase
	{
		// Token: 0x17005798 RID: 22424
		// (get) Token: 0x0602BDB8 RID: 179640 RVA: 0x00C51328 File Offset: 0x00C4F528
		private HashSet<EFunction> MakeImageQualityCustomSet
		{
			get
			{
				return MenuDefine.makeImageQualityCustomSet;
			}
		}

		// Token: 0x0602BDB9 RID: 179641 RVA: 0x00C5132F File Offset: 0x00C4F52F
		protected override bool OnInit()
		{
			this.RegisterOpenViewFunc();
			this.InitGamepadConnect();
			return true;
		}

		// Token: 0x0602BDBA RID: 179642 RVA: 0x00C5133E File Offset: 0x00C4F53E
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x0602BDBB RID: 179643 RVA: 0x00C51344 File Offset: 0x00C4F544
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<bool, int, int>(EEventName.ControllerConnectChange, new Action<bool, int, int>(this.ControllerConnectChange));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.HandleInputControllerChange));
			EventSystem.Instance.Add<bool>(EEventName.OnSdkFocusStateChange, new Action<bool>(this.TrySwitchTouchInputByDisconnectGamepad));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.HandleWorldDone));
		}

		// Token: 0x0602BDBC RID: 179644 RVA: 0x00C513C4 File Offset: 0x00C4F5C4
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.ControllerConnectChange, new Action<bool, int, int>(this.ControllerConnectChange));
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.HandleInputControllerChange));
			EventSystem.Instance.Remove(EEventName.OnSdkFocusStateChange, new Action<bool>(this.TrySwitchTouchInputByDisconnectGamepad));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.HandleWorldDone));
		}

		// Token: 0x0602BDBD RID: 179645 RVA: 0x00C51444 File Offset: 0x00C4F644
		private unsafe void ControllerConnectChange(bool bIsConnected, int platformUserId, int controllerId)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MobileInputSwitch;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "刷新手柄连接状态";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("bIsConnected", bIsConnected);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("platformUserId", platformUserId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("controllerId", controllerId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.RefreshGamepadConnect();
		}

		// Token: 0x0602BDBE RID: 179646 RVA: 0x00C514D4 File Offset: 0x00C4F6D4
		private void HandleInputControllerChange(EInputControllerType eInputControllerType, EInputControllerType inputControllerType)
		{
			if (Info.Instance.IsInGamepad())
			{
				LocalStorage.SetGlobal<EInputControllerType>(ELocalStorageGlobalKey.LastGamepadEnum, Info.Instance.InputControllerType);
			}
		}

		// Token: 0x0602BDBF RID: 179647 RVA: 0x00C514F7 File Offset: 0x00C4F6F7
		private void TrySwitchTouchInputByDisconnectGamepad(bool sdkGetFocusState)
		{
			if (sdkGetFocusState)
			{
				return;
			}
			this.RefreshGamepadConnect();
		}

		// Token: 0x0602BDC0 RID: 179648 RVA: 0x00C51503 File Offset: 0x00C4F703
		private void HandleWorldDone()
		{
			EyeProtectController.Instance.ApplyEyeProtectSetting();
			FilterSettingController.Instance.ApplyFilterSetting();
			GameSettingsUtils.ApplyImageDisplayMode(GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.ImageDisplayMode, 0, true));
		}

		// Token: 0x0602BDC1 RID: 179649 RVA: 0x00C51530 File Offset: 0x00C4F730
		public void CloseAllFilter()
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.KuroEnableScreenFilter 0", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Tonemapper.BrightnessAndTextureDisable 1", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.BlueLightFilter.Disable 1", null);
		}

		// Token: 0x0602BDC2 RID: 179650 RVA: 0x00C51562 File Offset: 0x00C4F762
		public void OpenAllFilter()
		{
			GameSettingsUtils.ApplyImageDisplayMode(GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.ImageDisplayMode, 0, true));
		}

		// Token: 0x0602BDC3 RID: 179651 RVA: 0x00C5157C File Offset: 0x00C4F77C
		public void HandleFireSaveMenuChange(MenuData menuData, float value)
		{
			EFunction functionId = menuData.FunctionId;
			int targetValue = (int)value;
			bool flag = this.NeedRedMagicFpsConfirmBox(targetValue);
			if (functionId == EFunction.IMAGEQUALITY)
			{
				MenuModel.Instance.IsImageQualityCustom = false;
			}
			else if (this.MakeImageQualityCustomSet.Contains(functionId) && (!Info.Instance.IsMobilePlatform() || !MenuDefine.mobileQualityUnRelativeSet.Contains(functionId)))
			{
				MenuModel.Instance.IsImageQualityCustom = true;
			}
			if (menuData.IsDataCache)
			{
				MenuModel.Instance.AddDataToTempCache(functionId, value);
			}
			else
			{
				GameSettingsManager.Instance.HandleNumericValueChange(functionId, value, EGameSettingsApplyReason.WhenUi);
			}
			this.HandleAffectedMenuData(menuData);
			this.RefreshAffectedMenuDataEnable(menuData);
			this.ShowMenuTips(menuData, value);
			if (MenuDefine.noticeConfigSet.Contains(functionId))
			{
				if (functionId == EFunction.HIGHESTFPS)
				{
					EventSystem.Instance.Emit<bool>(EEventName.ConfigLoadChange, !flag);
				}
				else
				{
					EventSystem.Instance.Emit<bool>(EEventName.ConfigLoadChange, true);
				}
			}
			MenuModel.Instance.IsEdited = true;
		}

		// Token: 0x0602BDC4 RID: 179652 RVA: 0x00C5165C File Offset: 0x00C4F85C
		private void HandleRaytracingMenuData(int rayTracingCurrentValue)
		{
			if (GameSettingsManager.Instance.IsValid(EFunction.RayTracedGI, true))
			{
				MenuModel.Instance.AddDataToTempOrSetValue(EFunction.RayTracedGI, (rayTracingCurrentValue > 0) ? 1 : 0);
			}
			else
			{
				GameSettingsManager.Instance.ForceSaveValue(EFunction.RayTracedGI, (rayTracingCurrentValue > 0) ? 1 : 0);
			}
			if (GameSettingsManager.Instance.IsValid(EFunction.RayTracedReflection, true))
			{
				MenuModel.Instance.AddDataToTempOrSetValue(EFunction.RayTracedReflection, (rayTracingCurrentValue > 0) ? 1 : 0);
			}
			else
			{
				GameSettingsManager.Instance.ForceSaveValue(EFunction.RayTracedReflection, (rayTracingCurrentValue > 0) ? 1 : 0);
			}
			if (GameSettingsManager.Instance.IsValid(EFunction.RayTracedShadow, true))
			{
				MenuModel.Instance.AddDataToTempOrSetValue(EFunction.RayTracedShadow, (rayTracingCurrentValue > 0) ? 1 : 0);
				return;
			}
			GameSettingsManager.Instance.ForceSaveValue(EFunction.RayTracedShadow, (rayTracingCurrentValue > 0) ? 1 : 0);
		}

		// Token: 0x0602BDC5 RID: 179653 RVA: 0x00C5171C File Offset: 0x00C4F91C
		private void HandleAffectedMenuData(MenuData menuData)
		{
			MenuModel instance = MenuModel.Instance;
			EFunction functionId = menuData.FunctionId;
			if (functionId == EFunction.IMAGEQUALITY)
			{
				int? dataCacheOrCurValue = instance.GetDataCacheOrCurValue(functionId);
				if (dataCacheOrCurValue == null)
				{
					return;
				}
				DeviceRenderFeature? deviceRenderFeature = GameSettingsDeviceRender.Instance.GetDeviceRenderFeature((EGameQualitySettingLevel)dataCacheOrCurValue.Value);
				if (deviceRenderFeature != null)
				{
					foreach (KeyValuePair<EFunction, int> keyValuePair in GameSettingsDeviceRender.Instance.GetOtherChangedValue(deviceRenderFeature.Value))
					{
						EFunction key = keyValuePair.Key;
						int value = keyValuePair.Value;
						if ((key != EFunction.MOBILERESOLUTION || Info.Instance.IsMobilePlatform()) && (key != EFunction.PCVSYNC || Info.Instance.IsPcOrGamepadPlatform()) && (key != EFunction.NPCDENSITY || !UKuroStaticLibrary.IsLowMemoryDevice()) && key != EFunction.RayTracing)
						{
							EFunction efunction = key;
							int num = value;
							if (key == EFunction.SUPERRESOLUTION && Info.Instance.IsPcPlatform())
							{
								EFunction efunction2 = key;
								ValueTuple<EFunction, EFunction, int> valueTuple = GameSettingsDeviceRender.Instance.MapSuperResolutionRecommendValue(efunction2, efunction, num);
								efunction2 = valueTuple.Item1;
								efunction = valueTuple.Item2;
								num = valueTuple.Item3;
								MenuModel.Instance.AddDataToTempCache(efunction2, 1f);
								MenuData menuDataByFunctionId = MenuModel.Instance.GetMenuDataByFunctionId((int)efunction2);
								if (menuDataByFunctionId != null)
								{
									this.RefreshAffectedMenuDataEnable(menuDataByFunctionId);
								}
							}
							MenuModel.Instance.AddDataToTempCache(efunction, (float)num);
							MenuData menuDataByFunctionId2 = MenuModel.Instance.GetMenuDataByFunctionId((int)efunction);
							if (menuDataByFunctionId2 != null)
							{
								this.RefreshAffectedMenuDataEnable(menuDataByFunctionId2);
							}
						}
					}
					foreach (KeyValuePair<EFunction, float> keyValuePair2 in GameSettingsDeviceRender.Instance.GetOtherChangedFloatValue(deviceRenderFeature.Value))
					{
						EFunction efunction3;
						float num2;
						keyValuePair2.Deconstruct(out efunction3, out num2);
						EFunction efunction4 = efunction3;
						float value2 = num2;
						if (GameSettingsManager.Instance.ValidApplyConfigMap.ContainsKey(efunction4))
						{
							instance.AddDataToTempCache(efunction4, value2);
							MenuData menuDataByFunctionId3 = instance.GetMenuDataByFunctionId((int)efunction4);
							if (menuDataByFunctionId3 != null)
							{
								this.RefreshAffectedMenuDataEnable(menuDataByFunctionId3);
							}
						}
					}
				}
			}
			if (this.MakeImageQualityCustomSet.Contains(functionId))
			{
				EventSystem.Instance.Emit<EFunction>(EEventName.RefreshMenuSetting, EFunction.IMAGEQUALITY);
			}
			if (functionId == EFunction.RayTracing)
			{
				int? dataCacheOrCurValue2 = instance.GetDataCacheOrCurValue(EFunction.RayTracing);
				if (dataCacheOrCurValue2 != null && MenuModel.Instance.NeedRayTracingSubChange)
				{
					this.HandleRaytracingMenuData(dataCacheOrCurValue2.Value);
				}
			}
			if (functionId == EFunction.NVIDIADLSS)
			{
				int? dataCacheOrCurValue3 = instance.GetDataCacheOrCurValue(functionId);
				if (dataCacheOrCurValue3 != null && dataCacheOrCurValue3.Value == 0)
				{
					MenuModel.Instance.AddDataToTempCache(EFunction.NVIDIADLSSFG, 0f);
				}
			}
			if (functionId == EFunction.JoystickMode || functionId == EFunction.MotorMobileButtonLayout)
			{
				int? dataCacheOrCurValue4 = instance.GetDataCacheOrCurValue(EFunction.MotorMobileButtonLayout);
				int? dataCacheOrCurValue5 = instance.GetDataCacheOrCurValue(EFunction.JoystickMode);
				if (dataCacheOrCurValue4 != null && dataCacheOrCurValue4.Value == 0 && dataCacheOrCurValue5 != null)
				{
					GameSettingsManager.Instance.HandleValueChange(EFunction.MotorIsDynamicJoystick, dataCacheOrCurValue5.Value, EGameSettingsApplyReason.WhenUi);
				}
			}
			float? dataCacheOrCurValueFloat = instance.GetDataCacheOrCurValueFloat(functionId);
			if (dataCacheOrCurValueFloat == null)
			{
				return;
			}
			if (!menuData.CanAffectedFunction(dataCacheOrCurValueFloat.Value))
			{
				return;
			}
			foreach (KeyValuePair<int, int> keyValuePair3 in menuData.AffectedFunction)
			{
				int key2 = keyValuePair3.Key;
				int value3 = keyValuePair3.Value;
				if (GameSettingsManager.Instance.ValidApplyConfigMap.ContainsKey((EFunction)key2))
				{
					MenuModel.Instance.AddDataToTempCache((EFunction)key2, (float)value3);
				}
			}
		}

		// Token: 0x0602BDC6 RID: 179654 RVA: 0x00C51AD8 File Offset: 0x00C4FCD8
		private void RefreshAffectedMenuDataEnable(MenuData menuData)
		{
			if (menuData.FunctionId == EFunction.ImageDisplayMode)
			{
				EventSystem.Instance.Emit<EFunction>(EEventName.RefreshMenuSetting, EFunction.Filter);
				EventSystem.Instance.Emit<EFunction>(EEventName.RefreshMenuSetting, EFunction.EyeProtection);
			}
			if (!menuData.HasDisableFunction())
			{
				return;
			}
			foreach (int p in menuData.DisableFunction)
			{
				EventSystem.Instance.Emit<EFunction>(EEventName.RefreshMenuSetting, (EFunction)p);
			}
		}

		// Token: 0x0602BDC7 RID: 179655 RVA: 0x00C51B50 File Offset: 0x00C4FD50
		private void ShowMenuTips(MenuData menuData, float value)
		{
			EFunction functionId = menuData.FunctionId;
			if (functionId == EFunction.NVIDIADLSSFG || functionId == EFunction.RESOLUTION || functionId == EFunction.DISPLAYMODE)
			{
				if (!GameSettingsDeviceRender.Instance.IsNvidia4060())
				{
					return;
				}
				MenuModel instance = MenuModel.Instance;
				int? dataCacheOrCurValue = instance.GetDataCacheOrCurValue(EFunction.DISPLAYMODE);
				int? dataCacheOrCurValue2 = instance.GetDataCacheOrCurValue(EFunction.RESOLUTION);
				int? dataCacheOrCurValue3 = instance.GetDataCacheOrCurValue(EFunction.NVIDIADLSSFG);
				if (dataCacheOrCurValue == null || dataCacheOrCurValue2 == null || dataCacheOrCurValue3 == null)
				{
					return;
				}
				int index = (dataCacheOrCurValue.Value == 0) ? 0 : dataCacheOrCurValue2.Value;
				FIntPoint resolutionByList = GameSettingsDeviceRender.Instance.GetResolutionByList(index);
				if (dataCacheOrCurValue3.Value > 0 && resolutionByList.X >= 3840 && resolutionByList.Y >= 2160)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Change4KWarning_Text", Array.Empty<object>());
				}
				return;
			}
			else
			{
				if (functionId == EFunction.RayTracing)
				{
					if (value > 0f && GameSettingsDeviceRender.Instance.IsDriverNeedUpdateForRayTracing())
					{
						ScrollingTipsController.Instance.ShowTipsByTextId("UpdateGraphicsCardDriver_Text", Array.Empty<object>());
					}
					return;
				}
				int num = (int)value;
				string promptId;
				if ((float)num != value || !menuData.ValueTipsMap.TryGetValue(num, out promptId))
				{
					return;
				}
				GenericPromptController.Instance.ShowPromptByCode(promptId, Array.Empty<object>());
				return;
			}
		}

		// Token: 0x0602BDC8 RID: 179656 RVA: 0x00C51C74 File Offset: 0x00C4FE74
		private unsafe void InitGamepadConnect()
		{
			if (Info.Instance.IsMobileInputModel())
			{
				bool flag = PlatformModel.Instance.IsGamepadAttached();
				GameSettingsManager.Instance.HandleValueChange(EFunction.MobileGamepadMode, (flag > false) ? 1 : 0, EGameSettingsApplyReason.WhenUi);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MobileInputSwitch;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "初始化手柄连接状态";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isGamepadAttach", flag);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MobileGamepadMode", GameSettingsManager.Instance.GetCurrentValue(EFunction.MobileGamepadMode, true, true));
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				if (flag)
				{
					EInputControllerType currentDeviceInputController = PlatformModel.Instance.GetCurrentDeviceInputController();
					Info.Instance.SwitchInputControllerType(currentDeviceInputController, "InitGamepadConnect");
					LocalStorage.SetGlobal<EInputControllerType>(ELocalStorageGlobalKey.LastGamepadEnum, Info.Instance.InputControllerType);
				}
				PlatformModel.Instance.LastGamepadAttachedState = flag;
			}
		}

		// Token: 0x0602BDC9 RID: 179657 RVA: 0x00C51D60 File Offset: 0x00C4FF60
		public unsafe void RefreshGamepadConnect()
		{
			if (Info.Instance.IsMobileInputModel())
			{
				bool flag = PlatformModel.Instance.IsGamepadAttached();
				bool lastGamepadAttachedState = PlatformModel.Instance.LastGamepadAttachedState;
				GameSettingsManager.Instance.HandleValueChange(EFunction.MobileGamepadMode, (flag > false) ? 1 : 0, EGameSettingsApplyReason.WhenUi);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MobileInputSwitch;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "刷新手柄连接状态";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isGamepadAttach", flag);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("lastState", lastGamepadAttachedState);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("MobileGamepadMode", GameSettingsManager.Instance.GetCurrentValue(EFunction.MobileGamepadMode, true, true));
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				if (!flag && lastGamepadAttachedState)
				{
					Log.Instance.Info(ELogModule.MobileInputSwitch, ELogAuthor.XXJ, "手柄重置回触屏模式,手柄断联", default(ReadOnlySpan<ValueTuple<string, object>>));
					if (MobileSwitchInputController.Instance.SwitchToTouchByDisconnectGamepad())
					{
						PlatformModel.Instance.LastGamepadAttachedState = flag;
						return;
					}
				}
				else
				{
					PlatformModel.Instance.LastGamepadAttachedState = flag;
				}
			}
		}

		// Token: 0x0602BDCA RID: 179658 RVA: 0x00C51E80 File Offset: 0x00C50080
		public List<int> GetMainTypeList([Nullable(2)] TMenuItemFilter filter = null)
		{
			int[] mainTypeList = MenuModel.Instance.GetMainTypeList(filter);
			List<int> list = new List<int>();
			for (int i = 0; i < mainTypeList.Length; i++)
			{
				list.Add(mainTypeList[i]);
			}
			return list;
		}

		// Token: 0x0602BDCB RID: 179659 RVA: 0x00C51EB8 File Offset: 0x00C500B8
		public MainType GetTargetMainInfo(int typeId)
		{
			return MenuModel.Instance.GetTargetMainInfo(typeId).Value;
		}

		// Token: 0x0602BDCC RID: 179660 RVA: 0x00C51ED8 File Offset: 0x00C500D8
		public List<MenuData> GetTargetBaseConfigData(int mainType, [Nullable(2)] TMenuItemFilter filter = null)
		{
			return MenuModel.Instance.GetTargetConfigData(mainType, filter) ?? new List<MenuData>();
		}

		// Token: 0x0602BDCD RID: 179661 RVA: 0x00C51EF0 File Offset: 0x00C500F0
		public unsafe int GetTargetConfig(EFunction functionId)
		{
			int? dataCacheOrCurValue = MenuModel.Instance.GetDataCacheOrCurValue(functionId);
			if (dataCacheOrCurValue == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Menu;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "Menu中获取选项值失败，返回缺省值0";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("functionId", functionId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Menu;
			ELogAuthor author2 = ELogAuthor.WZ;
			string message2 = "Menu中获取选项值";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", functionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("result", dataCacheOrCurValue);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return dataCacheOrCurValue.Value;
		}

		// Token: 0x0602BDCE RID: 179662 RVA: 0x00C51FA4 File Offset: 0x00C501A4
		public unsafe float GetTargetConfigFloat(EFunction functionId)
		{
			float? dataCacheOrCurValueFloat = MenuModel.Instance.GetDataCacheOrCurValueFloat(functionId);
			if (dataCacheOrCurValueFloat == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Menu;
				ELogAuthor author = ELogAuthor.TZJ;
				string message = "Menu中获取小数选项值失败，返回缺省值0";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("functionId", functionId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0f;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Menu;
			ELogAuthor author2 = ELogAuthor.TZJ;
			string message2 = "Menu中获取小数选项值";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", functionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("result", dataCacheOrCurValueFloat);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return dataCacheOrCurValueFloat.Value;
		}

		// Token: 0x0602BDCF RID: 179663 RVA: 0x00C5205C File Offset: 0x00C5025C
		private string GetCurrentResolutionString()
		{
			if (Info.Instance.IsMobilePlatform())
			{
				return this.GetTargetConfig(EFunction.MOBILERESOLUTION).ToString();
			}
			int targetConfig = this.GetTargetConfig(EFunction.RESOLUTION);
			return GameSettingsDeviceRender.Instance.GetResolutionByList(targetConfig).ToString();
		}

		// Token: 0x0602BDD0 RID: 179664 RVA: 0x00C520A8 File Offset: 0x00C502A8
		[NullableContext(2)]
		private float GetFilterSettingLogValue(float[] values, EFilterSettingValueIndex valueIndex)
		{
			if (values == null)
			{
				return -1f;
			}
			if (valueIndex >= (EFilterSettingValueIndex)values.Length)
			{
				return -1f;
			}
			return values[(int)valueIndex];
		}

		// Token: 0x0602BDD1 RID: 179665 RVA: 0x00C520D0 File Offset: 0x00C502D0
		public void ReportSettingMenuLogEvent()
		{
			Log.Instance.Info(ELogModule.Menu, ELogAuthor.WZ, "上报设置系统埋点数据[Start]", default(ReadOnlySpan<ValueTuple<string, object>>));
			SettingMenuLogEvent settingMenuLogEvent = new SettingMenuLogEvent();
			settingMenuLogEvent.i_image_quality = (MenuModel.Instance.IsImageQualityCustom ? 99 : this.GetTargetConfig(EFunction.IMAGEQUALITY));
			settingMenuLogEvent.i_display_mode = this.GetTargetConfig(EFunction.DISPLAYMODE);
			settingMenuLogEvent.s_resolution = this.GetCurrentResolutionString();
			settingMenuLogEvent.i_brightness = this.GetTargetConfig(EFunction.BRIGHTNESS);
			settingMenuLogEvent.i_highest_fps = this.GetTargetConfig(EFunction.HIGHESTFPS);
			settingMenuLogEvent.i_shadow_quality = this.GetTargetConfig(EFunction.SHADOWQUALITY);
			settingMenuLogEvent.i_niagara_quality = this.GetTargetConfig(EFunction.NIAGARAQUALITY);
			settingMenuLogEvent.i_fsr = this.GetTargetConfig(EFunction.FSR);
			settingMenuLogEvent.i_image_detail = this.GetTargetConfig(EFunction.IMAGEDETAIL);
			settingMenuLogEvent.i_scene_ao = this.GetTargetConfig(EFunction.SCENEAO);
			settingMenuLogEvent.i_volume_Fog = this.GetTargetConfig(EFunction.VOLUMEFOG);
			settingMenuLogEvent.i_volume_light = this.GetTargetConfig(EFunction.VOLUMELIGHT);
			settingMenuLogEvent.i_motion_blur = this.GetTargetConfig(EFunction.MOTIONBLUR);
			settingMenuLogEvent.i_anti_aliasing = this.GetTargetConfig(EFunction.ANTIALISING);
			settingMenuLogEvent.i_pcv_sync = this.GetTargetConfig(EFunction.PCVSYNC);
			settingMenuLogEvent.i_horizontal_view_sensitivity = this.GetTargetConfig(EFunction.HorizontalViewSensitivity);
			settingMenuLogEvent.i_vertical_view_sensitivity = this.GetTargetConfig(EFunction.VerticalViewSensitivity);
			settingMenuLogEvent.i_aim_horizontal_view_sensitivity = this.GetTargetConfig(EFunction.AimHorizontalViewSensitivity);
			settingMenuLogEvent.i_aim_vertical_view_sensitivity = this.GetTargetConfig(EFunction.AimVerticalViewSensitivity);
			settingMenuLogEvent.f_camera_shake_strength = this.GetTargetConfigFloat(EFunction.CameraShakeStrength);
			settingMenuLogEvent.i_common_spring_arm_length = this.GetTargetConfig(EFunction.CommonSpringArmLength);
			settingMenuLogEvent.i_fight_spring_arm_length = this.GetTargetConfig(EFunction.FightSpringArmLength);
			settingMenuLogEvent.i_reset_focus_enable = this.GetTargetConfig(EFunction.ResetFocusEnable);
			settingMenuLogEvent.i_side_step_camera_enable = this.GetTargetConfig(EFunction.IsSidestepCameraEnable);
			settingMenuLogEvent.i_soft_lock_camera_enable = this.GetTargetConfig(EFunction.IsSoftLockCameraEnable);
			settingMenuLogEvent.i_joystick_shake_strength = this.GetTargetConfig(EFunction.JoystickShakeStrength);
			settingMenuLogEvent.i_joystick_shake_type = this.GetTargetConfig(EFunction.JoystickShakeType);
			settingMenuLogEvent.f_walk_or_run_rate = this.GetTargetConfigFloat(EFunction.WalkOrRunRate);
			settingMenuLogEvent.i_advice_setting = this.GetTargetConfig(EFunction.ADVICESETTING);
			settingMenuLogEvent.i_enemy_id = this.GetTargetConfig(EFunction.SkillLockEnemyMode);
			settingMenuLogEvent.i_crowd_density = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.NPCDENSITY, 0, true);
			settingMenuLogEvent.i_hit_material_effects = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.EnemyHitDisplayMode, 0, true);
			settingMenuLogEvent.i_auto_adjust = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.AutoAdjustImageQuality, 0, true);
			settingMenuLogEvent.i_damage_numbers = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.ShowDamage, 0, true);
			settingMenuLogEvent.i_fluttering_animation = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.DynamicBones, 0, true);
			settingMenuLogEvent.i_cinematic_quality = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.FlowAdaptation, 0, true);
			settingMenuLogEvent.i_teammate_effects = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.TeammateFx, 0, true);
			settingMenuLogEvent.i_injury_effects = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.SkinDamageMode, 0, true);
			settingMenuLogEvent.i_environment_interaction = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.WaterInteract, 0, true);
			settingMenuLogEvent.i_foliage_blur = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.VegetationDither, 0, true);
			settingMenuLogEvent.i_auto_exposure = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.AutoExposure, 0, true);
			settingMenuLogEvent.i_hdr = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.HDR, 0, true);
			settingMenuLogEvent.i_ui_Brightness = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.UiBrightness, 0, true);
			settingMenuLogEvent.i_peak_Brightness = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.PeakBrightness, 0, true);
			int global = LocalStorage.GetGlobal<int>(ELocalStorageGlobalKey.FilterSettingId, -1);
			Dictionary<int, float[]> global2 = LocalStorage.GetGlobal<Dictionary<int, float[]>>(ELocalStorageGlobalKey.FilterSettingValues, null);
			float[] values = null;
			if (global2 != null)
			{
				global2.TryGetValue(global, out values);
			}
			SettingMenuLogEvent settingMenuLogEvent2 = settingMenuLogEvent;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(145, 14);
			defaultInterpolatedStringHandler.AppendLiteral("id:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(global);
			defaultInterpolatedStringHandler.AppendLiteral("-intense:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.GetFilterSettingLogValue(values, EFilterSettingValueIndex.Intensity));
			defaultInterpolatedStringHandler.AppendLiteral("-x:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.GetFilterSettingLogValue(values, EFilterSettingValueIndex.Horizontal));
			defaultInterpolatedStringHandler.AppendLiteral("-y:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.GetFilterSettingLogValue(values, EFilterSettingValueIndex.Vertical));
			defaultInterpolatedStringHandler.AppendLiteral("-SharpenIntensity:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.GetFilterSettingLogValue(values, EFilterSettingValueIndex.SharpenIntensity));
			defaultInterpolatedStringHandler.AppendLiteral("-Brightness:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.GetFilterSettingLogValue(values, EFilterSettingValueIndex.Brightness));
			defaultInterpolatedStringHandler.AppendLiteral("-Contrast:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.GetFilterSettingLogValue(values, EFilterSettingValueIndex.Contrast));
			defaultInterpolatedStringHandler.AppendLiteral("-ColorTemperature:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.GetFilterSettingLogValue(values, EFilterSettingValueIndex.ColorTemperature));
			defaultInterpolatedStringHandler.AppendLiteral("-Saturation:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.GetFilterSettingLogValue(values, EFilterSettingValueIndex.Saturation));
			defaultInterpolatedStringHandler.AppendLiteral("-Bloom:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.GetFilterSettingLogValue(values, EFilterSettingValueIndex.Bloom));
			defaultInterpolatedStringHandler.AppendLiteral("-Gamma:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.GetFilterSettingLogValue(values, EFilterSettingValueIndex.Gamma));
			defaultInterpolatedStringHandler.AppendLiteral("-ShadowIntensity:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.GetFilterSettingLogValue(values, EFilterSettingValueIndex.ShadowIntensity));
			defaultInterpolatedStringHandler.AppendLiteral("-NoiseIntensity:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.GetFilterSettingLogValue(values, EFilterSettingValueIndex.NoiseIntensity));
			defaultInterpolatedStringHandler.AppendLiteral("-Halation:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.GetFilterSettingLogValue(values, EFilterSettingValueIndex.Halation));
			settingMenuLogEvent2.i_filter_list = defaultInterpolatedStringHandler.ToStringAndClear();
			settingMenuLogEvent.i_image_mode = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.ImageDisplayMode, 0, true);
			settingMenuLogEvent.eyeprotect_mode = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.EyeProtectionMode, 0, true);
			if (settingMenuLogEvent.eyeprotect_mode == 2)
			{
				SettingMenuLogEvent settingMenuLogEvent3 = settingMenuLogEvent;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 4);
				defaultInterpolatedStringHandler.AppendLiteral("temp:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(GameSettingsManager.Instance.GetCurrentValueSafelyFloat(EFunction.EyeProtectionTemp, 0f, true));
				defaultInterpolatedStringHandler.AppendLiteral("-strength:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(GameSettingsManager.Instance.GetCurrentValueSafelyFloat(EFunction.EyeProtectionStrength, 0f, true));
				defaultInterpolatedStringHandler.AppendLiteral("-brightness:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(GameSettingsManager.Instance.GetCurrentValueSafelyFloat(EFunction.EyeProtectionBrightness, 0f, true));
				defaultInterpolatedStringHandler.AppendLiteral("-texture:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(GameSettingsManager.Instance.GetCurrentValueSafelyFloat(EFunction.EyeProtectionTexture, 0f, true));
				settingMenuLogEvent3.eyeprotect_list = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			settingMenuLogEvent.i_recommend_config = ((MenuModel.Instance != null && MenuModel.Instance.HasApplyRecommendData) ? 1 : 0);
			int currentValueSafely = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.AnisoLevel, 99999, true);
			settingMenuLogEvent.anisotropic_sampling = currentValueSafely;
			settingMenuLogEvent.render_distance = 99999;
			settingMenuLogEvent.f_wp_loadingRangeScale = this.GetTargetConfigFloat(EFunction.LOADINGRANGESCALELEVEL);
			if (GameSettingsDeviceRender.Instance.IsDlssGpuDevice())
			{
				int currentValueSafely2 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.NVIDIADLSS, 99999, true);
				settingMenuLogEvent.dlss = currentValueSafely2;
			}
			if (GameSettingsDeviceRender.Instance.IsFsrDevice())
			{
				int currentValueSafely3 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.FSR3, 99999, true);
				settingMenuLogEvent.fsr = currentValueSafely3;
			}
			if (GameSettingsDeviceRender.Instance.IsXess2Supported())
			{
				int currentValueSafely4 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.XESS2, 99999, true);
				settingMenuLogEvent.xess = currentValueSafely4;
			}
			if (GameSettingsDeviceRender.Instance.IsDlssGpuDevice())
			{
				int currentValueSafely5 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.NVIDIADLSSQUALITY, 99999, true);
				settingMenuLogEvent.super_resolution = currentValueSafely5;
			}
			else if (GameSettingsDeviceRender.Instance.IsFsrDevice())
			{
				int currentValueSafely6 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.FSR3_QUALITY, 99999, true);
				settingMenuLogEvent.super_resolution = currentValueSafely6;
			}
			else if (GameSettingsDeviceRender.Instance.IsXess2Supported())
			{
				int currentValueSafely7 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.XESS2_QUALITY, 99999, true);
				settingMenuLogEvent.super_resolution = currentValueSafely7;
			}
			if (UKuroRenderingRuntimeBPPluginBPLibrary.GetRayTracingSupportedType() == URayTracingSupport.Supported)
			{
				int currentValueSafely8 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.RayTracing, 99999, true);
				int currentValueSafely9 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.RayTracedReflection, 99999, true);
				int currentValueSafely10 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.RayTracedGI, 99999, true);
				int currentValueSafely11 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.RayTracedShadow, 99999, true);
				settingMenuLogEvent.ray_tracing = currentValueSafely8;
				settingMenuLogEvent.rt_reflection = currentValueSafely9;
				settingMenuLogEvent.rt_global_illumination = currentValueSafely10;
				settingMenuLogEvent.rt_shadow = currentValueSafely11;
			}
			if (Info.Instance.IsPcPlatform())
			{
				int currentValueSafely12 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.Vulkan, 99999, true);
				settingMenuLogEvent.vulkan = currentValueSafely12;
			}
			if (Info.Instance.IsPcPlatform())
			{
				if (GameSettingsDeviceRender.Instance.IsDlss3GpuDevice())
				{
					int currentValueSafely13 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.NVIDIADLSSFG, 99999, true);
					settingMenuLogEvent.pc_frame_interpolation = currentValueSafely13;
				}
				else if (GameSettingsDeviceRender.Instance.IsFsrDevice())
				{
					int currentValueSafely14 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.FSR3_FG, 99999, true);
					settingMenuLogEvent.pc_frame_interpolation = currentValueSafely14;
				}
				else if (GameSettingsDeviceRender.Instance.IsXeFGSupported())
				{
					int currentValueSafely15 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.XESS2_FG, 99999, true);
					settingMenuLogEvent.pc_frame_interpolation = currentValueSafely15;
				}
			}
			if (Info.Instance.IsMobilePlatform())
			{
				int currentValueSafely16 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.AdrenoFME, 99999, true);
				settingMenuLogEvent.mob_frame_interpolation = currentValueSafely16;
			}
			int currentValueSafely17 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.IRX, 99999, true);
			settingMenuLogEvent.self_dev_interpolation = currentValueSafely17;
			settingMenuLogEvent.game_language = LocalStorage.GetGlobal<int?>(ELocalStorageGlobalKey.TextLanguage, null).GetValueOrDefault(99999);
			settingMenuLogEvent.game_voice = LocalStorage.GetGlobal<int?>(ELocalStorageGlobalKey.VoiceLanguage, null).GetValueOrDefault(99999);
			settingMenuLogEvent.i_asset_grade = (int)HotFixManager.GetLocalResourceQualityTier();
			Log.Instance.Info(ELogModule.Menu, ELogAuthor.WZ, "上报设置系统埋点数据[Data Collect Done]", default(ReadOnlySpan<ValueTuple<string, object>>));
			LogReportController.Instance.LogReport(settingMenuLogEvent);
		}

		// Token: 0x0602BDD2 RID: 179666 RVA: 0x00C529FD File Offset: 0x00C50BFD
		public void BeforeViewClose()
		{
			GameSettingsManager.Instance.ReApply(EFunction.NVIDIADLSSQUALITY, EGameSettingsApplyReason.WhenUi, true);
			GameSettingsManager.SetIsUsingQualityPreset(!MenuModel.Instance.IsImageQualityCustom);
		}

		// Token: 0x0602BDD3 RID: 179667 RVA: 0x00C52A24 File Offset: 0x00C50C24
		private void RegisterOpenViewFunc()
		{
			this.OpenViewFuncMap[EUiViewName.LogUploadView] = new Action(this.OpenLogUploadView);
			this.OpenViewFuncMap[EUiViewName.CdKeyInputView] = new Action(this.OpenCdKeyInputView);
			this.OpenViewFuncMap[EUiViewName.MobileSwitchInputView] = new Action(this.OpenMobileSwitchInputView);
			this.OpenViewFuncMap[EUiViewName.SubPackageDownLoadView] = new Action(this.OpenResDownLoadView);
			this.OpenViewFuncMap[EUiViewName.SubPackageDownLoadClearTipsView] = new Action(this.OpenSubPackageDownLoadClearTipsView);
			this.OpenViewFuncMap[EUiViewName.FilterSettingView] = new Action(this.OpenFilterSettingView);
			this.OpenViewFuncMap[EUiViewName.EyeProtectView] = new Action(this.OpenEyeProtectView);
			this.OpenViewFuncMap[EUiViewName.VersionCheckView] = new Action(this.OpenVersionCheckView);
		}

		// Token: 0x0602BDD4 RID: 179668 RVA: 0x00C52B14 File Offset: 0x00C50D14
		private void OpenLogUploadView()
		{
			LogUploadOpenParam param = new LogUploadOpenParam
			{
				OpenSourceType = new EKuroSdkOpenCustomerServerType?(EKuroSdkOpenCustomerServerType.Setting),
				AutoStartUpload = new bool?(false)
			};
			UiManager.Instance.OpenView(EUiViewName.LogUploadView, param, null);
		}

		// Token: 0x0602BDD5 RID: 179669 RVA: 0x00C52B50 File Offset: 0x00C50D50
		private void OpenCdKeyInputView()
		{
			CommonInputViewController.Instance.OpenCdKeyInputView();
		}

		// Token: 0x0602BDD6 RID: 179670 RVA: 0x00C52B5C File Offset: 0x00C50D5C
		private void OpenVersionCheckView()
		{
			PackageUpdateController.Instance.TryOpenParallelPackageUpdateUrl();
		}

		// Token: 0x0602BDD7 RID: 179671 RVA: 0x00C52B68 File Offset: 0x00C50D68
		private void OpenMobileSwitchInputView()
		{
			MobileSwitchInputController.Instance.SwitchToGamepadByMenuSetting();
		}

		// Token: 0x0602BDD8 RID: 179672 RVA: 0x00C52B74 File Offset: 0x00C50D74
		private void OpenResDownLoadView()
		{
			if (RecallQuestModel.Instance.IsInRecallInstance())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Download_BanDownloadSystem", Array.Empty<object>());
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.SubPackageDownLoadView, null, null);
		}

		// Token: 0x0602BDD9 RID: 179673 RVA: 0x00C52BA8 File Offset: 0x00C50DA8
		private void OpenSubPackageDownLoadClearTipsView()
		{
			if (RecallQuestModel.Instance.IsInRecallInstance())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Download_BanCleanSystem", Array.Empty<object>());
				return;
			}
			if (GameModeModel.Instance.IsMulti)
			{
				SubPackageDownLoadModel.Instance.OpenMultiBanCleanConfirm();
				return;
			}
			if (ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
			{
				UiManager.Instance.OpenView(EUiViewName.SubPackageDownLoadMobileClearPopView, null, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.SubPackageDownLoadClearTipsView, null, null);
		}

		// Token: 0x0602BDDA RID: 179674 RVA: 0x00C52C1C File Offset: 0x00C50E1C
		public bool IsInputControllerTypeIncludeKey(EInputControllerType inputControllerType, string keyName)
		{
			switch (inputControllerType)
			{
			case EInputControllerType.Keyboard:
				return InputSettings.Instance.IsKeyboardKey(keyName) || InputSettings.Instance.IsMouseButton(keyName);
			case EInputControllerType.Gamepad:
				return InputSettings.Instance.IsGamepadKey(keyName);
			}
			return false;
		}

		// Token: 0x0602BDDB RID: 179675 RVA: 0x00C52C5C File Offset: 0x00C50E5C
		public void OpenChangeLockView()
		{
			InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding("锁定目标");
			if (actionBinding == null)
			{
				return;
			}
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			actionBinding.GetPcKeyNameList(list);
			actionBinding.GetGamepadKeyNameList(list2);
			string keyName = list[0];
			string keyName2 = list2[0];
			string keyIconPath = InputSettings.Instance.GetKeyIconPath(keyName);
			string keyIconPath2 = InputSettings.Instance.GetKeyIconPath(keyName2);
			ChangeKeyModeRow changeKeyModeRow = new ChangeKeyModeRow();
			changeKeyModeRow.RowSpriteResourceId = "SP_SwitchType1";
			changeKeyModeRow.DescriptionA = "LockEnemyModeText_1";
			ChangeKeyModeRow changeKeyModeRow2 = changeKeyModeRow;
			object[] array = new string[]
			{
				"<texture=" + keyIconPath + "/>"
			};
			changeKeyModeRow2.DescriptionParametersA = array;
			changeKeyModeRow.DescriptionB = "LockEnemyModeText_3";
			ChangeKeyModeRow changeKeyModeRow3 = changeKeyModeRow;
			array = new string[]
			{
				"<texture=" + keyIconPath + "/>"
			};
			changeKeyModeRow3.DescriptionParametersB = array;
			ChangeKeyModeRow changeKeyModeRow4 = changeKeyModeRow;
			changeKeyModeRow = new ChangeKeyModeRow();
			changeKeyModeRow.RowSpriteResourceId = "SP_SwitchType2";
			changeKeyModeRow.DescriptionA = "LockEnemyModeText_2";
			ChangeKeyModeRow changeKeyModeRow5 = changeKeyModeRow;
			array = new string[]
			{
				"<texture=" + keyIconPath + "/>"
			};
			changeKeyModeRow5.DescriptionParametersA = array;
			changeKeyModeRow.DescriptionB = "LockEnemyModeText_4";
			ChangeKeyModeRow changeKeyModeRow6 = changeKeyModeRow;
			changeKeyModeRow = new ChangeKeyModeRow();
			changeKeyModeRow.RowSpriteResourceId = "SP_SwitchType1";
			changeKeyModeRow.DescriptionA = "LockEnemyModeText_1";
			ChangeKeyModeRow changeKeyModeRow7 = changeKeyModeRow;
			array = new string[]
			{
				"<texture=" + keyIconPath2 + "/>"
			};
			changeKeyModeRow7.DescriptionParametersA = array;
			changeKeyModeRow.DescriptionB = "LockEnemyModeText_3";
			ChangeKeyModeRow changeKeyModeRow8 = changeKeyModeRow;
			array = new string[]
			{
				"<texture=" + keyIconPath2 + "/>"
			};
			changeKeyModeRow8.DescriptionParametersB = array;
			ChangeKeyModeRow changeKeyModeRow9 = changeKeyModeRow;
			changeKeyModeRow = new ChangeKeyModeRow();
			changeKeyModeRow.RowSpriteResourceId = "SP_SwitchType2";
			changeKeyModeRow.DescriptionA = "LockEnemyModeText_2";
			ChangeKeyModeRow changeKeyModeRow10 = changeKeyModeRow;
			array = new string[]
			{
				"<texture=" + keyIconPath2 + "/>"
			};
			changeKeyModeRow10.DescriptionParametersA = array;
			changeKeyModeRow.DescriptionB = "LockEnemyModeText_6";
			ChangeKeyModeRow changeKeyModeRow11 = changeKeyModeRow;
			int valueOrDefault = GameSettingsManager.Instance.GetCurrentValue(EFunction.KeyboardLockEnemyMode, true, true).GetValueOrDefault();
			int valueOrDefault2 = GameSettingsManager.Instance.GetCurrentValue(EFunction.GamepadLockEnemyMode, true, true).GetValueOrDefault();
			ChangeKeyModeGroup changeKeyModeGroup = new ChangeKeyModeGroup();
			changeKeyModeGroup.GroupName = "LockEnemyModeType_1";
			changeKeyModeGroup.DefaultKeyModeRowIndex = valueOrDefault;
			ChangeKeyModeGroup changeKeyModeGroup2 = changeKeyModeGroup;
			IChangeKeyModeRow[] changeKeyModeRowList = new ChangeKeyModeRow[]
			{
				changeKeyModeRow4,
				changeKeyModeRow6
			};
			changeKeyModeGroup2.ChangeKeyModeRowList = changeKeyModeRowList;
			ChangeKeyModeGroup changeKeyModeGroup3 = changeKeyModeGroup;
			changeKeyModeGroup = new ChangeKeyModeGroup();
			changeKeyModeGroup.GroupName = "LockEnemyModeType_2";
			changeKeyModeGroup.DefaultKeyModeRowIndex = valueOrDefault2;
			ChangeKeyModeGroup changeKeyModeGroup4 = changeKeyModeGroup;
			changeKeyModeRowList = new ChangeKeyModeRow[]
			{
				changeKeyModeRow9,
				changeKeyModeRow11
			};
			changeKeyModeGroup4.ChangeKeyModeRowList = changeKeyModeRowList;
			ChangeKeyModeGroup changeKeyModeGroup5 = changeKeyModeGroup;
			ChangeKeyMode changeKeyMode = new ChangeKeyMode();
			changeKeyMode.TitleName = "LockEnemyModeTitle";
			changeKeyMode.DefaultGroupIndex = ((MenuModel.Instance.KeySettingInputControllerType == EInputControllerType.Gamepad) ? 1 : 0);
			ChangeKeyMode changeKeyMode2 = changeKeyMode;
			IChangeKeyModeGroup[] changeKeyModeGroupList = new ChangeKeyModeGroup[]
			{
				changeKeyModeGroup3,
				changeKeyModeGroup5
			};
			changeKeyMode2.ChangeKeyModeGroupList = changeKeyModeGroupList;
			changeKeyMode.OnConfirmCallback = new Action<Dictionary<int, int>>(this.OnChangeLockEnemyMode);
			ChangeKeyMode param = changeKeyMode;
			UiManager.Instance.OpenView(EUiViewName.ChangeModeTipsView, param, null);
		}

		// Token: 0x0602BDDC RID: 179676 RVA: 0x00C52F78 File Offset: 0x00C51178
		private void OnChangeLockEnemyMode(Dictionary<int, int> editRowIndexMap)
		{
			foreach (KeyValuePair<int, int> keyValuePair in editRowIndexMap)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (key == 0)
				{
					GameSettingsManager.Instance.HandleValueChange(EFunction.KeyboardLockEnemyMode, value, EGameSettingsApplyReason.WhenUi);
				}
				else if (key == 1)
				{
					GameSettingsManager.Instance.HandleValueChange(EFunction.GamepadLockEnemyMode, value, EGameSettingsApplyReason.WhenUi);
				}
			}
		}

		// Token: 0x0602BDDD RID: 179677 RVA: 0x00C52FFC File Offset: 0x00C511FC
		public void OpenImageOverloadConfirmBox()
		{
			int? dataCacheOrCurValue = MenuModel.Instance.GetDataCacheOrCurValue(EFunction.AutoAdjustImageQuality);
			if (dataCacheOrCurValue == null)
			{
				return;
			}
			if (dataCacheOrCurValue.Value == 1)
			{
				this.OpenImageQualityOverloadConfirmBox();
				return;
			}
			this.OpenImageQualityAdjustConfirmBox();
		}

		// Token: 0x0602BDDE RID: 179678 RVA: 0x00C5303C File Offset: 0x00C5123C
		private void OpenImageQualityAdjustConfirmBox()
		{
			bool imageQualityAdjustEnable = false;
			Action<bool> toggleFunction = delegate(bool isSelectOn)
			{
				imageQualityAdjustEnable = isSelectOn;
			};
			Action value = delegate()
			{
				GameSettingsManager.Instance.HandleValueChange(EFunction.AutoAdjustImageQuality, (imageQualityAdjustEnable > false) ? 1 : 0, EGameSettingsApplyReason.WhenUi);
			};
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ImageQualityAdjustConfirm);
			confirmBoxDataNew.HasToggle = true;
			confirmBoxDataNew.ToggleText = (ConfigMultiTextLang.GetLocalTextNew("MenuConfig_145_Set_Tips", null) ?? "");
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.SetToggleFunction(toggleFunction);
			confirmBoxDataNew.FunctionMap.Add(2, value);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602BDDF RID: 179679 RVA: 0x00C530C4 File Offset: 0x00C512C4
		public void OpenImageQualityOverloadConfirmBox()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PictureConfigOverload);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602BDE0 RID: 179680 RVA: 0x00C530E8 File Offset: 0x00C512E8
		public void OpenFilterSettingView()
		{
			FilterSettingController.Instance.TryOpenExternalPreparedAsync().Forget<bool>();
		}

		// Token: 0x0602BDE1 RID: 179681 RVA: 0x00C530F9 File Offset: 0x00C512F9
		public void OpenEyeProtectView()
		{
			EyeProtectController.Instance.OpenEyeProtectView().Forget<bool>();
		}

		// Token: 0x0602BDE2 RID: 179682 RVA: 0x00C5310C File Offset: 0x00C5130C
		public bool NeedRedMagicFpsConfirmBox(int targetValue)
		{
			if (GameSettingsDeviceRender.Instance.IsRedMagic() && targetValue == 2)
			{
				int? dataCacheOrCurValue = MenuModel.Instance.GetDataCacheOrCurValue(EFunction.Vulkan);
				int num = 0;
				return dataCacheOrCurValue.GetValueOrDefault() == num & dataCacheOrCurValue != null;
			}
			return false;
		}

		// Token: 0x17005799 RID: 22425
		// (get) Token: 0x0602BDE3 RID: 179683 RVA: 0x00C5314F File Offset: 0x00C5134F
		public static MenuController Instance
		{
			get
			{
				return MenuController._Instance;
			}
		}

		// Token: 0x0602BDE4 RID: 179684 RVA: 0x00C53156 File Offset: 0x00C51356
		public static MenuController GetOrCreateInstance()
		{
			if (MenuController._Instance == null)
			{
				MenuController.CreateInstance();
			}
			return MenuController._Instance;
		}

		// Token: 0x0602BDE5 RID: 179685 RVA: 0x00C5316A File Offset: 0x00C5136A
		public static bool CreateInstance()
		{
			if (MenuController._Instance != null)
			{
				return true;
			}
			MenuController._Instance = new MenuController();
			return true;
		}

		// Token: 0x0602BDE6 RID: 179686 RVA: 0x00C53180 File Offset: 0x00C51380
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602BDE7 RID: 179687 RVA: 0x00C53182 File Offset: 0x00C51382
		public static void ResetStaticDefaultValue()
		{
			MenuController._Instance = null;
		}

		// Token: 0x0602BDE8 RID: 179688 RVA: 0x00C5318A File Offset: 0x00C5138A
		static MenuController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MenuController.CreateStaticDefaultValue), new Action(MenuController.ResetStaticDefaultValue));
		}

		// Token: 0x04017A07 RID: 96775
		private const int SettingLogDefaultValue = 99999;

		// Token: 0x04017A08 RID: 96776
		private const int REPORT_IMAGE_QUALITY_VALUE_FOR_CUSTOM = 99;

		// Token: 0x04017A09 RID: 96777
		public readonly Dictionary<EUiViewName, Action> OpenViewFuncMap = new Dictionary<EUiViewName, Action>();

		// Token: 0x04017A0A RID: 96778
		[Nullable(2)]
		private static MenuController _Instance;
	}
}
