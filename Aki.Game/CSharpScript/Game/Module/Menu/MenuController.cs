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
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020053E2 RID: 21474
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MenuController : UiControllerBase
	{
		// Token: 0x170083CC RID: 33740
		// (get) Token: 0x06036E71 RID: 224881 RVA: 0x00D02244 File Offset: 0x00D00444
		private HashSet<EFunction> MakeImageQualityCustomSet
		{
			get
			{
				return MenuDefine.makeImageQualityCustomSet;
			}
		}

		// Token: 0x06036E72 RID: 224882 RVA: 0x00D0224B File Offset: 0x00D0044B
		protected override bool OnInit()
		{
			this.RegisterOpenViewFunc();
			this.InitGamepadConnect();
			return true;
		}

		// Token: 0x06036E73 RID: 224883 RVA: 0x00D0225A File Offset: 0x00D0045A
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x06036E74 RID: 224884 RVA: 0x00D02260 File Offset: 0x00D00460
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<bool, int, int>(EEventName.ControllerConnectChange, new Action<bool, int, int>(this.ControllerConnectChange));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.HandleInputControllerChange));
			EventSystem.Instance.Add<bool>(EEventName.OnSdkFocusStateChange, new Action<bool>(this.TrySwitchTouchInputByDisconnectGamepad));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.HandleWorldDone));
		}

		// Token: 0x06036E75 RID: 224885 RVA: 0x00D022E0 File Offset: 0x00D004E0
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.ControllerConnectChange, new Action<bool, int, int>(this.ControllerConnectChange));
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.HandleInputControllerChange));
			EventSystem.Instance.Remove(EEventName.OnSdkFocusStateChange, new Action<bool>(this.TrySwitchTouchInputByDisconnectGamepad));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.HandleWorldDone));
		}

		// Token: 0x06036E76 RID: 224886 RVA: 0x00D02360 File Offset: 0x00D00560
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

		// Token: 0x06036E77 RID: 224887 RVA: 0x00D023F0 File Offset: 0x00D005F0
		private void HandleInputControllerChange(EInputControllerType eInputControllerType, EInputControllerType inputControllerType)
		{
			if (Info.Instance.IsInGamepad())
			{
				LocalStorage.SetGlobal<EInputControllerType>(ELocalStorageGlobalKey.LastGamepadEnum, Info.Instance.InputControllerType);
			}
		}

		// Token: 0x06036E78 RID: 224888 RVA: 0x00D02413 File Offset: 0x00D00613
		private void TrySwitchTouchInputByDisconnectGamepad(bool sdkGetFocusState)
		{
			if (sdkGetFocusState)
			{
				return;
			}
			this.RefreshGamepadConnect();
		}

		// Token: 0x06036E79 RID: 224889 RVA: 0x00D0241F File Offset: 0x00D0061F
		private void HandleWorldDone()
		{
			EyeProtectController.Instance.ApplyEyeProtectSetting();
			FilterSettingController.Instance.ApplyFilterSetting();
			GameSettingsUtils.ApplyImageDisplayMode(GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.ImageDisplayMode, 0, true));
		}

		// Token: 0x06036E7A RID: 224890 RVA: 0x00D0244C File Offset: 0x00D0064C
		public void CloseAllFilter()
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.KuroEnableScreenFilter 0", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Tonemapper.BrightnessAndTextureDisable 1", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.BlueLightFilter.Disable 1", null);
		}

		// Token: 0x06036E7B RID: 224891 RVA: 0x00D0247E File Offset: 0x00D0067E
		public void OpenAllFilter()
		{
			GameSettingsUtils.ApplyImageDisplayMode(GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.ImageDisplayMode, 0, true));
		}

		// Token: 0x06036E7C RID: 224892 RVA: 0x00D02498 File Offset: 0x00D00698
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

		// Token: 0x06036E7D RID: 224893 RVA: 0x00D02578 File Offset: 0x00D00778
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

		// Token: 0x06036E7E RID: 224894 RVA: 0x00D02638 File Offset: 0x00D00838
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
			foreach (KeyValuePair<int, int> keyValuePair2 in menuData.AffectedFunction)
			{
				int key2 = keyValuePair2.Key;
				int value2 = keyValuePair2.Value;
				if (GameSettingsManager.Instance.ValidApplyConfigMap.ContainsKey((EFunction)key2))
				{
					MenuModel.Instance.AddDataToTempCache((EFunction)key2, (float)value2);
				}
			}
		}

		// Token: 0x06036E7F RID: 224895 RVA: 0x00D02958 File Offset: 0x00D00B58
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

		// Token: 0x06036E80 RID: 224896 RVA: 0x00D029D0 File Offset: 0x00D00BD0
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

		// Token: 0x06036E81 RID: 224897 RVA: 0x00D02AF4 File Offset: 0x00D00CF4
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

		// Token: 0x06036E82 RID: 224898 RVA: 0x00D02BE0 File Offset: 0x00D00DE0
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

		// Token: 0x06036E83 RID: 224899 RVA: 0x00D02D00 File Offset: 0x00D00F00
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

		// Token: 0x06036E84 RID: 224900 RVA: 0x00D02D38 File Offset: 0x00D00F38
		public MainType GetTargetMainInfo(int typeId)
		{
			return MenuModel.Instance.GetTargetMainInfo(typeId).Value;
		}

		// Token: 0x06036E85 RID: 224901 RVA: 0x00D02D58 File Offset: 0x00D00F58
		public List<MenuData> GetTargetBaseConfigData(int mainType, [Nullable(2)] TMenuItemFilter filter = null)
		{
			return MenuModel.Instance.GetTargetConfigData(mainType, filter) ?? new List<MenuData>();
		}

		// Token: 0x06036E86 RID: 224902 RVA: 0x00D02D70 File Offset: 0x00D00F70
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

		// Token: 0x06036E87 RID: 224903 RVA: 0x00D02E24 File Offset: 0x00D01024
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

		// Token: 0x06036E88 RID: 224904 RVA: 0x00D02EDC File Offset: 0x00D010DC
		private string GetCurrentResolutionString()
		{
			if (Info.Instance.IsMobilePlatform())
			{
				return this.GetTargetConfig(EFunction.MOBILERESOLUTION).ToString();
			}
			int targetConfig = this.GetTargetConfig(EFunction.RESOLUTION);
			return GameSettingsDeviceRender.Instance.GetResolutionByList(targetConfig).ToString();
		}

		// Token: 0x06036E89 RID: 224905 RVA: 0x00D02F28 File Offset: 0x00D01128
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

		// Token: 0x06036E8A RID: 224906 RVA: 0x00D02F50 File Offset: 0x00D01150
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
			int currentValueSafely2 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.LOADINGRANGESCALELEVEL, 99999, true);
			settingMenuLogEvent.render_distance = currentValueSafely2;
			if (GameSettingsDeviceRender.Instance.IsDlssGpuDevice())
			{
				int currentValueSafely3 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.NVIDIADLSS, 99999, true);
				settingMenuLogEvent.dlss = currentValueSafely3;
			}
			if (GameSettingsDeviceRender.Instance.IsFsrDevice())
			{
				int currentValueSafely4 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.FSR3, 99999, true);
				settingMenuLogEvent.fsr = currentValueSafely4;
			}
			if (GameSettingsDeviceRender.Instance.IsXess2Supported())
			{
				int currentValueSafely5 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.XESS2, 99999, true);
				settingMenuLogEvent.xess = currentValueSafely5;
			}
			if (GameSettingsDeviceRender.Instance.IsDlssGpuDevice())
			{
				int currentValueSafely6 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.NVIDIADLSSQUALITY, 99999, true);
				settingMenuLogEvent.super_resolution = currentValueSafely6;
			}
			else if (GameSettingsDeviceRender.Instance.IsFsrDevice())
			{
				int currentValueSafely7 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.FSR3_QUALITY, 99999, true);
				settingMenuLogEvent.super_resolution = currentValueSafely7;
			}
			else if (GameSettingsDeviceRender.Instance.IsXess2Supported())
			{
				int currentValueSafely8 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.XESS2_QUALITY, 99999, true);
				settingMenuLogEvent.super_resolution = currentValueSafely8;
			}
			if (UKuroRenderingRuntimeBPPluginBPLibrary.GetRayTracingSupportedType() == URayTracingSupport.Supported)
			{
				int currentValueSafely9 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.RayTracing, 99999, true);
				int currentValueSafely10 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.RayTracedReflection, 99999, true);
				int currentValueSafely11 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.RayTracedGI, 99999, true);
				int currentValueSafely12 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.RayTracedShadow, 99999, true);
				settingMenuLogEvent.ray_tracing = currentValueSafely9;
				settingMenuLogEvent.rt_reflection = currentValueSafely10;
				settingMenuLogEvent.rt_global_illumination = currentValueSafely11;
				settingMenuLogEvent.rt_shadow = currentValueSafely12;
			}
			if (Info.Instance.IsPcPlatform())
			{
				int currentValueSafely13 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.Vulkan, 99999, true);
				settingMenuLogEvent.vulkan = currentValueSafely13;
			}
			if (Info.Instance.IsPcPlatform())
			{
				if (GameSettingsDeviceRender.Instance.IsDlss3GpuDevice())
				{
					int currentValueSafely14 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.NVIDIADLSSFG, 99999, true);
					settingMenuLogEvent.pc_frame_interpolation = currentValueSafely14;
				}
				else if (GameSettingsDeviceRender.Instance.IsFsrDevice())
				{
					int currentValueSafely15 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.FSR3_FG, 99999, true);
					settingMenuLogEvent.pc_frame_interpolation = currentValueSafely15;
				}
				else if (GameSettingsDeviceRender.Instance.IsXeFGSupported())
				{
					int currentValueSafely16 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.XESS2_FG, 99999, true);
					settingMenuLogEvent.pc_frame_interpolation = currentValueSafely16;
				}
			}
			if (Info.Instance.IsMobilePlatform())
			{
				int currentValueSafely17 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.AdrenoFME, 99999, true);
				settingMenuLogEvent.mob_frame_interpolation = currentValueSafely17;
			}
			int currentValueSafely18 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.IRX, 99999, true);
			settingMenuLogEvent.self_dev_interpolation = currentValueSafely18;
			settingMenuLogEvent.game_language = LocalStorage.GetGlobal<int?>(ELocalStorageGlobalKey.TextLanguage, null).GetValueOrDefault(99999);
			settingMenuLogEvent.game_voice = LocalStorage.GetGlobal<int?>(ELocalStorageGlobalKey.VoiceLanguage, null).GetValueOrDefault(99999);
			settingMenuLogEvent.i_asset_grade = (int)HotFixManager.GetLocalResourceQualityTier();
			Log.Instance.Info(ELogModule.Menu, ELogAuthor.WZ, "上报设置系统埋点数据[Data Collect Done]", default(ReadOnlySpan<ValueTuple<string, object>>));
			LogReportController.Instance.LogReport(settingMenuLogEvent);
		}

		// Token: 0x06036E8B RID: 224907 RVA: 0x00D03880 File Offset: 0x00D01A80
		public void BeforeViewClose()
		{
			GameSettingsManager.Instance.ReApply(EFunction.NVIDIADLSSQUALITY, EGameSettingsApplyReason.WhenUi, true);
			GameSettingsManager.SetIsUsingQualityPreset(!MenuModel.Instance.IsImageQualityCustom);
		}

		// Token: 0x06036E8C RID: 224908 RVA: 0x00D038A8 File Offset: 0x00D01AA8
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

		// Token: 0x06036E8D RID: 224909 RVA: 0x00D03998 File Offset: 0x00D01B98
		private void OpenLogUploadView()
		{
			LogUploadOpenParam param = new LogUploadOpenParam
			{
				OpenSourceType = new EKuroSdkOpenCustomerServerType?(EKuroSdkOpenCustomerServerType.Setting),
				AutoStartUpload = new bool?(false)
			};
			UiManager.Instance.OpenView(EUiViewName.LogUploadView, param, null);
		}

		// Token: 0x06036E8E RID: 224910 RVA: 0x00D039D4 File Offset: 0x00D01BD4
		private void OpenCdKeyInputView()
		{
			CommonInputViewController.Instance.OpenCdKeyInputView();
		}

		// Token: 0x06036E8F RID: 224911 RVA: 0x00D039E0 File Offset: 0x00D01BE0
		private void OpenVersionCheckView()
		{
			PackageUpdateController.Instance.TryOpenParallelPackageUpdateUrl();
		}

		// Token: 0x06036E90 RID: 224912 RVA: 0x00D039EC File Offset: 0x00D01BEC
		private void OpenMobileSwitchInputView()
		{
			MobileSwitchInputController.Instance.SwitchToGamepadByMenuSetting();
		}

		// Token: 0x06036E91 RID: 224913 RVA: 0x00D039F8 File Offset: 0x00D01BF8
		private void OpenResDownLoadView()
		{
			if (RecallQuestModel.Instance.IsInRecallInstance())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Download_BanDownloadSystem", Array.Empty<object>());
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.SubPackageDownLoadView, null, null);
		}

		// Token: 0x06036E92 RID: 224914 RVA: 0x00D03A2C File Offset: 0x00D01C2C
		private void OpenSubPackageDownLoadClearTipsView()
		{
			if (RecallQuestModel.Instance.IsInRecallInstance())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Download_BanCleanSystem", Array.Empty<object>());
				return;
			}
			if (!Info.Instance.IsMobilePlatform())
			{
				UiManager.Instance.OpenView(EUiViewName.SubPackageDownLoadClearTipsView, null, null);
				return;
			}
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ConnectBanCleanResource", Array.Empty<object>());
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.SubPackageDownLoadMobileClearPopView, null, null);
		}

		// Token: 0x06036E93 RID: 224915 RVA: 0x00D03AAA File Offset: 0x00D01CAA
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

		// Token: 0x06036E94 RID: 224916 RVA: 0x00D03AE8 File Offset: 0x00D01CE8
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

		// Token: 0x06036E95 RID: 224917 RVA: 0x00D03E04 File Offset: 0x00D02004
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

		// Token: 0x06036E96 RID: 224918 RVA: 0x00D03E88 File Offset: 0x00D02088
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

		// Token: 0x06036E97 RID: 224919 RVA: 0x00D03EC8 File Offset: 0x00D020C8
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

		// Token: 0x06036E98 RID: 224920 RVA: 0x00D03F50 File Offset: 0x00D02150
		public void OpenImageQualityOverloadConfirmBox()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PictureConfigOverload);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06036E99 RID: 224921 RVA: 0x00D03F74 File Offset: 0x00D02174
		public void OpenFilterSettingView()
		{
			FilterSettingController.Instance.TryOpenExternalPreparedAsync().Forget<bool>();
		}

		// Token: 0x06036E9A RID: 224922 RVA: 0x00D03F85 File Offset: 0x00D02185
		public void OpenEyeProtectView()
		{
			EyeProtectController.Instance.OpenEyeProtectView().Forget<bool>();
		}

		// Token: 0x06036E9B RID: 224923 RVA: 0x00D03F98 File Offset: 0x00D02198
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

		// Token: 0x170083CD RID: 33741
		// (get) Token: 0x06036E9C RID: 224924 RVA: 0x00D03FDB File Offset: 0x00D021DB
		public static MenuController Instance
		{
			get
			{
				return MenuController._Instance;
			}
		}

		// Token: 0x06036E9D RID: 224925 RVA: 0x00D03FE2 File Offset: 0x00D021E2
		public static MenuController GetOrCreateInstance()
		{
			if (MenuController._Instance == null)
			{
				MenuController.CreateInstance();
			}
			return MenuController._Instance;
		}

		// Token: 0x06036E9E RID: 224926 RVA: 0x00D03FF6 File Offset: 0x00D021F6
		public static bool CreateInstance()
		{
			if (MenuController._Instance != null)
			{
				return true;
			}
			MenuController._Instance = new MenuController();
			return true;
		}

		// Token: 0x06036E9F RID: 224927 RVA: 0x00D0400C File Offset: 0x00D0220C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036EA0 RID: 224928 RVA: 0x00D0400E File Offset: 0x00D0220E
		public static void ResetStaticDefaultValue()
		{
			MenuController._Instance = null;
		}

		// Token: 0x06036EA1 RID: 224929 RVA: 0x00D04016 File Offset: 0x00D02216
		static MenuController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MenuController.CreateStaticDefaultValue), new Action(MenuController.ResetStaticDefaultValue));
		}

		// Token: 0x0401CF6F RID: 118639
		private const int SettingLogDefaultValue = 99999;

		// Token: 0x0401CF70 RID: 118640
		private const int REPORT_IMAGE_QUALITY_VALUE_FOR_CUSTOM = 99;

		// Token: 0x0401CF71 RID: 118641
		public readonly Dictionary<EUiViewName, Action> OpenViewFuncMap = new Dictionary<EUiViewName, Action>();

		// Token: 0x0401CF72 RID: 118642
		[Nullable(2)]
		private static MenuController _Instance;
	}
}
