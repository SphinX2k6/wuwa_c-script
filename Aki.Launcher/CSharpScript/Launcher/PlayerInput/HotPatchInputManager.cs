using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.HotPatch;
using CSharpScript.Launcher.InputDevice;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.PlayerInput
{
	// Token: 0x02000124 RID: 292
	[NullableContext(1)]
	[Nullable(0)]
	public class HotPatchInputManager : Singleton
	{
		// Token: 0x0600093F RID: 2367 RVA: 0x00041D74 File Offset: 0x0003FF74
		private UniTask InitActionHandle()
		{
			HotPatchInputManager.<InitActionHandle>d__13 <InitActionHandle>d__;
			<InitActionHandle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitActionHandle>d__.<>4__this = this;
			<InitActionHandle>d__.<>1__state = -1;
			<InitActionHandle>d__.<>t__builder.Start<HotPatchInputManager.<InitActionHandle>d__13>(ref <InitActionHandle>d__);
			return <InitActionHandle>d__.<>t__builder.Task;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00041DB8 File Offset: 0x0003FFB8
		private void RegisterInputActionSettings(string actionName, string keyName)
		{
			UInputSettings inputSettings = UInputSettings.GetInputSettings();
			FName actionName2 = new FName(actionName);
			FKey key = new FKey(new FName(keyName));
			FInputActionKeyMapping item = new FInputActionKeyMapping(actionName2, false, false, false, false, key);
			inputSettings.AddActionMapping(item, true);
			this.InputActionKeyMappings.Add(item);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00041DFC File Offset: 0x0003FFFC
		private void RegisterInputAxisSettings(string axisName, [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<string, int> keyScale)
		{
			UInputSettings inputSettings = UInputSettings.GetInputSettings();
			FName axisName2 = new FName(axisName);
			FKey key = new FKey(new FName(keyScale.Item1));
			FInputAxisKeyMapping item = new FInputAxisKeyMapping(axisName2, (float)keyScale.Item2, key);
			inputSettings.AddAxisMapping(item, true);
			this.InputAxisKeyMappings.Add(item);
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00041E48 File Offset: 0x00040048
		private void RegisterAllInputSetting()
		{
			foreach (KeyValuePair<string, EMouseKey> keyValuePair in HotPatchInputDefine.Instance.pcInputMap)
			{
				this.RegisterInputActionSettings(keyValuePair.Key, keyValuePair.Value.ToString());
			}
			foreach (KeyValuePair<string, EGamepadKey> keyValuePair2 in HotPatchInputDefine.Instance.gamepadActionInputMap)
			{
				this.RegisterInputActionSettings(keyValuePair2.Key, keyValuePair2.Value.ToString());
			}
			foreach (KeyValuePair<string, ValueTuple<string, int>> keyValuePair3 in HotPatchInputDefine.Instance.gamepadAxisInputMap)
			{
				this.RegisterInputAxisSettings(keyValuePair3.Key, keyValuePair3.Value);
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00041F74 File Offset: 0x00040174
		private void UnRegisterAllInputSetting()
		{
			UInputSettings inputSettings = UInputSettings.GetInputSettings();
			for (int i = 0; i < this.InputActionKeyMappings.Count; i++)
			{
				FInputActionKeyMapping finputActionKeyMapping = this.InputActionKeyMappings[i];
				if (inputSettings != null)
				{
					inputSettings.RemoveActionMapping(finputActionKeyMapping, true);
				}
			}
			for (int j = 0; j < this.InputAxisKeyMappings.Count; j++)
			{
				FInputAxisKeyMapping finputAxisKeyMapping = this.InputAxisKeyMappings[j];
				if (inputSettings != null)
				{
					inputSettings.RemoveAxisMapping(finputAxisKeyMapping, true);
				}
			}
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00041FE8 File Offset: 0x000401E8
		private void NewActionHandle(string actionName)
		{
			TsHotFixActionHandle_C tsHotFixActionHandle_C = new TsHotFixActionHandle_C(this.WorldContext, null, EObjectFlags.RF_NoFlags);
			tsHotFixActionHandle_C.OnPressActionCallback.Add(new Action<bool, string, FKey>(this.InputActionCallback));
			tsHotFixActionHandle_C.AddPressBinding(actionName, this.PlayerController);
			tsHotFixActionHandle_C.AddReleaseBinding(actionName, this.PlayerController);
			this.ActionHandleMap[actionName] = tsHotFixActionHandle_C;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00042044 File Offset: 0x00040244
		private void NewAxisHandle(string axisName)
		{
			TsHotFixActionHandle_C tsHotFixActionHandle_C = new TsHotFixActionHandle_C(this.WorldContext, null, EObjectFlags.RF_NoFlags);
			tsHotFixActionHandle_C.OnAxisCallback.Add(new Action<float, string>(this.InputAxisCallback));
			tsHotFixActionHandle_C.AddAxisBinding(axisName, this.PlayerController);
			this.AxisHandleMap[axisName] = tsHotFixActionHandle_C;
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00042090 File Offset: 0x00040290
		private void RegisterPcAndGamepadInput()
		{
			foreach (KeyValuePair<string, EMouseKey> keyValuePair in HotPatchInputDefine.Instance.pcInputMap)
			{
				this.NewActionHandle(keyValuePair.Key);
			}
			foreach (KeyValuePair<string, EGamepadKey> keyValuePair2 in HotPatchInputDefine.Instance.gamepadActionInputMap)
			{
				this.NewActionHandle(keyValuePair2.Key);
			}
			foreach (KeyValuePair<string, ValueTuple<string, int>> keyValuePair3 in HotPatchInputDefine.Instance.gamepadAxisInputMap)
			{
				this.NewAxisHandle(keyValuePair3.Key);
			}
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00042188 File Offset: 0x00040388
		private void RegisterMobileInput()
		{
			TsHotFixActionHandle_C tsHotFixActionHandle_C = new TsHotFixActionHandle_C(this.WorldContext, null, EObjectFlags.RF_NoFlags);
			tsHotFixActionHandle_C.OnTouchActionCallback.Add(new Action<bool, TEnumAsByte<ETouchIndex>, FVector>(this.OnTouchActionCallback));
			tsHotFixActionHandle_C.OnTouchMovedActionCallback.Add(new Action<TEnumAsByte<ETouchIndex>, FVector>(this.OnTouchMovedActionCallback));
			tsHotFixActionHandle_C.AddTouchPressBinding(this.PlayerController);
			tsHotFixActionHandle_C.AddTouchReleaseBinding(this.PlayerController);
			tsHotFixActionHandle_C.AddTouchMoveBinding(this.PlayerController);
			this.TouchHandle = tsHotFixActionHandle_C;
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x000421FC File Offset: 0x000403FC
		private void RegsiterAnyKeyInput()
		{
			TsHotFixActionHandle_C tsHotFixActionHandle_C = new TsHotFixActionHandle_C(this.WorldContext, null, EObjectFlags.RF_NoFlags);
			tsHotFixActionHandle_C.OnAnyKeyPressCallback.Add(new Action<FKey>(this.OnAnyKeyPress));
			tsHotFixActionHandle_C.AddAnyKeyPress(this.PlayerController, new FInputChord(new FKey(new FName("AnyKey")), false, false, false, false));
			this.AnyKeyHandle = tsHotFixActionHandle_C;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0004225C File Offset: 0x0004045C
		private void InputActionCallback(bool isPress, string actionName, FKey key)
		{
			HashSet<TInputAction> hashSet;
			if (!this.InputActionMap.TryGetValue(actionName, out hashSet))
			{
				return;
			}
			foreach (TInputAction tinputAction in hashSet)
			{
				tinputAction(isPress, actionName);
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x000422BC File Offset: 0x000404BC
		private void InputAxisCallback(float value, string axisName)
		{
			HashSet<TInputAxis> hashSet;
			if (!this.InputAxisMap.TryGetValue(axisName, out hashSet))
			{
				return;
			}
			foreach (TInputAxis tinputAxis in hashSet)
			{
				tinputAxis(value, axisName);
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0004231C File Offset: 0x0004051C
		[NullableContext(0)]
		private void OnTouchActionCallback(bool isPress, TEnumAsByte<ETouchIndex> touchIndex, FVector position)
		{
			TTouchAction touchAction = this.TouchAction;
			if (touchAction == null)
			{
				return;
			}
			touchAction(isPress, (int)touchIndex, position);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00042336 File Offset: 0x00040536
		[NullableContext(0)]
		private void OnTouchMovedActionCallback(TEnumAsByte<ETouchIndex> touchIndex, FVector position)
		{
			TTouchMovedAction touchMovedAction = this.TouchMovedAction;
			if (touchMovedAction == null)
			{
				return;
			}
			touchMovedAction((int)touchIndex, position);
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0004234F File Offset: 0x0004054F
		private void InputChangeDelegate(EInputControllerType _, EInputControllerType __)
		{
			this.CurrentPanelConfig.RefreshTexture();
			this.PlayerController.bShowMouseCursor = InputDevice.Instance.IsInKeyBoard();
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00042374 File Offset: 0x00040574
		private void OnAnyKeyPress(FKey key)
		{
			if (Platform.Instance.IsMobilePlatform())
			{
				string text = key.KeyName.ToString();
				if (text != null && (text.Contains("Android") || text.Contains("OpenHarmony")))
				{
					return;
				}
			}
			if (UKismetInputLibrary.Key_IsGamepadKey(key))
			{
				HotPatchEventSystem.Instance.SwitchToNavigationInputType();
			}
			InputDevice.Instance.SwitchInputControllerTypeByKey(key);
			Action waitingAnyKeyPressCallBack = this.WaitingAnyKeyPressCallBack;
			if (waitingAnyKeyPressCallBack == null)
			{
				return;
			}
			waitingAnyKeyPressCallBack();
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x000423F0 File Offset: 0x000405F0
		public UniTask WaitAnyKeyPress()
		{
			UniTaskCompletionSource tcs = new UniTaskCompletionSource();
			this.WaitingAnyKeyPressCallBack = delegate()
			{
				this.WaitingAnyKeyPressCallBack = null;
				tcs.TrySetResult();
			};
			return tcs.Task;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00042434 File Offset: 0x00040634
		public UniTask Init(UObject worldContext)
		{
			HotPatchInputManager.<Init>d__30 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.worldContext = worldContext;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<HotPatchInputManager.<Init>d__30>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00042480 File Offset: 0x00040680
		public void RegisterInputAction(string actionName, TInputAction inputActionFunc)
		{
			HashSet<TInputAction> hashSet;
			if (!this.InputActionMap.TryGetValue(actionName, out hashSet))
			{
				hashSet = new HashSet<TInputAction>();
				this.InputActionMap[actionName] = hashSet;
			}
			hashSet.Add(inputActionFunc);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x000424B8 File Offset: 0x000406B8
		public void UnRegisterInputAction(string actionName, TInputAction inputActionFunc)
		{
			HashSet<TInputAction> hashSet;
			if (!this.InputActionMap.TryGetValue(actionName, out hashSet))
			{
				return;
			}
			if (hashSet.Remove(inputActionFunc) && hashSet.Count == 0)
			{
				this.InputActionMap.Remove(actionName);
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x000424F4 File Offset: 0x000406F4
		public void RegisterInputAxis(string axisName, TInputAxis inputAxisFunc)
		{
			HashSet<TInputAxis> hashSet;
			if (!this.InputAxisMap.TryGetValue(axisName, out hashSet))
			{
				hashSet = new HashSet<TInputAxis>();
				this.InputAxisMap[axisName] = hashSet;
			}
			hashSet.Add(inputAxisFunc);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0004252C File Offset: 0x0004072C
		public void UnRegisterInputAxis(string axisName, TInputAxis inputAxisFunc)
		{
			HashSet<TInputAxis> hashSet;
			if (!this.InputAxisMap.TryGetValue(axisName, out hashSet))
			{
				return;
			}
			if (hashSet.Remove(inputAxisFunc) && hashSet.Count == 0)
			{
				this.InputAxisMap.Remove(axisName);
			}
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00042568 File Offset: 0x00040768
		public void RegisterOnTouchAction(TTouchAction touchAction)
		{
			this.TouchAction = touchAction;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00042571 File Offset: 0x00040771
		public void UnRegisterOnTouchAction()
		{
			this.TouchAction = null;
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0004257A File Offset: 0x0004077A
		public void RegisterOnTouchMovedAction(TTouchMovedAction touchMovedAction)
		{
			this.TouchMovedAction = touchMovedAction;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00042583 File Offset: 0x00040783
		public void UnRegisterOnTouchMovedAction()
		{
			this.TouchMovedAction = null;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0004258C File Offset: 0x0004078C
		public void Destroy()
		{
			InputDevice.Instance.UnRegisterInputChangeDelegate(new Action<EInputControllerType, EInputControllerType>(this.InputChangeDelegate));
			this.UnRegisterAllInputSetting();
			this.ClearTypeCache();
			this.ClearTexture();
			foreach (TsHotFixActionHandle_C tsHotFixActionHandle_C in this.ActionHandleMap.Values)
			{
				tsHotFixActionHandle_C.ClearActionBinding(this.PlayerController);
				tsHotFixActionHandle_C.OnPressActionCallback.Clear();
			}
			this.ActionHandleMap.Clear();
			foreach (TsHotFixActionHandle_C tsHotFixActionHandle_C2 in this.AxisHandleMap.Values)
			{
				tsHotFixActionHandle_C2.ClearAxisBinding(this.PlayerController);
				tsHotFixActionHandle_C2.OnAxisCallback.Clear();
			}
			this.AxisHandleMap.Clear();
			if (this.TouchHandle != null)
			{
				this.TouchHandle.OnTouchActionCallback.Clear();
				this.TouchHandle.OnTouchMovedActionCallback.Clear();
				this.TouchHandle = null;
			}
			if (this.AnyKeyHandle != null)
			{
				this.AnyKeyHandle.ClearKeyBinding(this.PlayerController);
				this.AnyKeyHandle = null;
			}
			this.WorldContext = null;
			this.PlayerController = null;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x000426E4 File Offset: 0x000408E4
		private UniTask InitHotPatchPanelConfigType()
		{
			HotPatchInputManager.<InitHotPatchPanelConfigType>d__43 <InitHotPatchPanelConfigType>d__;
			<InitHotPatchPanelConfigType>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitHotPatchPanelConfigType>d__.<>4__this = this;
			<InitHotPatchPanelConfigType>d__.<>1__state = -1;
			<InitHotPatchPanelConfigType>d__.<>t__builder.Start<HotPatchInputManager.<InitHotPatchPanelConfigType>d__43>(ref <InitHotPatchPanelConfigType>d__);
			return <InitHotPatchPanelConfigType>d__.<>t__builder.Task;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00042727 File Offset: 0x00040927
		private void ClearTypeCache()
		{
			this.TypeCache.Clear();
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00042734 File Offset: 0x00040934
		public void InsertPanelConfig(TsHotPatchPanelConfig panelConfig)
		{
			TsHotPatchPanelConfig currentPanelConfig = this.CurrentPanelConfig;
			if (currentPanelConfig != null)
			{
				currentPanelConfig.HideTexture();
			}
			TsHotPatchPanelConfig currentPanelConfig2 = this.CurrentPanelConfig;
			if (currentPanelConfig2 != null)
			{
				currentPanelConfig2.UnRegisterActionAndAxis();
			}
			this.PanelConfigList.Add(panelConfig);
			this.CurrentPanelConfig = panelConfig;
			panelConfig.RefreshTexture();
			panelConfig.RegisterActionAndAxis();
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00042784 File Offset: 0x00040984
		public void RemovePanelConfig(TsHotPatchPanelConfig panelConfig)
		{
			panelConfig.HideTexture();
			panelConfig.UnRegisterActionAndAxis();
			int num = this.PanelConfigList.IndexOf(panelConfig);
			int count = this.PanelConfigList.Count;
			this.PanelConfigList.RemoveAt(num);
			if (num == count - 1 && this.PanelConfigList.Count > 0)
			{
				int count2 = this.PanelConfigList.Count;
				this.CurrentPanelConfig = this.PanelConfigList[count2 - 1];
				TsHotPatchPanelConfig currentPanelConfig = this.CurrentPanelConfig;
				if (currentPanelConfig != null)
				{
					currentPanelConfig.RefreshTexture();
				}
				TsHotPatchPanelConfig currentPanelConfig2 = this.CurrentPanelConfig;
				if (currentPanelConfig2 == null)
				{
					return;
				}
				currentPanelConfig2.RegisterActionAndAxis();
			}
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00042818 File Offset: 0x00040A18
		private UniTask LoadGamepadTexture()
		{
			HotPatchInputManager.<LoadGamepadTexture>d__49 <LoadGamepadTexture>d__;
			<LoadGamepadTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadGamepadTexture>d__.<>4__this = this;
			<LoadGamepadTexture>d__.<>1__state = -1;
			<LoadGamepadTexture>d__.<>t__builder.Start<HotPatchInputManager.<LoadGamepadTexture>d__49>(ref <LoadGamepadTexture>d__);
			return <LoadGamepadTexture>d__.<>t__builder.Task;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0004285C File Offset: 0x00040A5C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<UTexture> LoadXboxTextureAsync(EGamepadKey key, string path)
		{
			UniTaskCompletionSource<UTexture> tcs = new UniTaskCompletionSource<UTexture>();
			LauncherResourceLib.Instance.LoadAsync<UTexture>(path, delegate([Nullable(2)] UTexture asset, string _)
			{
				tcs.TrySetResult(asset);
				if (asset != null)
				{
					this.XboxKeyAndTextureMap[key] = asset;
				}
			}, 0, "Launch.Ui");
			return tcs.Task;
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x000428B4 File Offset: 0x00040AB4
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<UTexture> LoadPsTextureAsync(EGamepadKey key, string path)
		{
			UniTaskCompletionSource<UTexture> tcs = new UniTaskCompletionSource<UTexture>();
			LauncherResourceLib.Instance.LoadAsync<UTexture>(path, delegate([Nullable(2)] UTexture asset, string _)
			{
				tcs.TrySetResult(asset);
				if (asset != null)
				{
					this.PsKeyAndTextureMap[key] = asset;
				}
			}, 0, "Launch.Ui");
			return tcs.Task;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00042909 File Offset: 0x00040B09
		private void ClearTexture()
		{
			this.XboxKeyAndTextureMap.Clear();
			this.PsKeyAndTextureMap.Clear();
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00042924 File Offset: 0x00040B24
		[return: Nullable(2)]
		public UTexture GetTextureByActionName(string actionName)
		{
			EGamepadKey key;
			if (!HotPatchInputDefine.Instance.gamepadActionInputMap.TryGetValue(actionName, out key))
			{
				return null;
			}
			if (InputDevice.Instance.IsPsGamepad())
			{
				UTexture result;
				if (this.PsKeyAndTextureMap.TryGetValue(key, out result))
				{
					return result;
				}
				return null;
			}
			else
			{
				UTexture result2;
				if (this.XboxKeyAndTextureMap.TryGetValue(key, out result2))
				{
					return result2;
				}
				return null;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x0004297A File Offset: 0x00040B7A
		public static HotPatchInputManager Instance
		{
			get
			{
				if (HotPatchInputManager._instance == null)
				{
					HotPatchInputManager._instance = new HotPatchInputManager();
					HotPatchInputManager._instance.OnInit();
				}
				return HotPatchInputManager._instance;
			}
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0004299D File Offset: 0x00040B9D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0004299F File Offset: 0x00040B9F
		public static void ResetStaticDefaultValue()
		{
			HotPatchInputManager instance = HotPatchInputManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			HotPatchInputManager._instance = null;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x000429B8 File Offset: 0x00040BB8
		static HotPatchInputManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotPatchInputManager.CreateStaticDefaultValue), new Action(HotPatchInputManager.ResetStaticDefaultValue));
		}

		// Token: 0x0400055D RID: 1373
		[Nullable(2)]
		private UObject WorldContext;

		// Token: 0x0400055E RID: 1374
		[Nullable(2)]
		private APlayerController PlayerController;

		// Token: 0x0400055F RID: 1375
		private readonly Dictionary<string, HashSet<TInputAction>> InputActionMap = new Dictionary<string, HashSet<TInputAction>>();

		// Token: 0x04000560 RID: 1376
		private readonly Dictionary<string, HashSet<TInputAxis>> InputAxisMap = new Dictionary<string, HashSet<TInputAxis>>();

		// Token: 0x04000561 RID: 1377
		private readonly Dictionary<string, TsHotFixActionHandle_C> ActionHandleMap = new Dictionary<string, TsHotFixActionHandle_C>();

		// Token: 0x04000562 RID: 1378
		private readonly Dictionary<string, TsHotFixActionHandle_C> AxisHandleMap = new Dictionary<string, TsHotFixActionHandle_C>();

		// Token: 0x04000563 RID: 1379
		[Nullable(2)]
		private TsHotFixActionHandle_C TouchHandle;

		// Token: 0x04000564 RID: 1380
		[Nullable(2)]
		private TsHotFixActionHandle_C AnyKeyHandle;

		// Token: 0x04000565 RID: 1381
		[Nullable(2)]
		private TTouchAction TouchAction;

		// Token: 0x04000566 RID: 1382
		[Nullable(2)]
		private TTouchMovedAction TouchMovedAction;

		// Token: 0x04000567 RID: 1383
		private readonly List<FInputActionKeyMapping> InputActionKeyMappings = new List<FInputActionKeyMapping>();

		// Token: 0x04000568 RID: 1384
		private readonly List<FInputAxisKeyMapping> InputAxisKeyMappings = new List<FInputAxisKeyMapping>();

		// Token: 0x04000569 RID: 1385
		[Nullable(2)]
		private Action WaitingAnyKeyPressCallBack;

		// Token: 0x0400056A RID: 1386
		private readonly List<TsHotPatchPanelConfig> PanelConfigList = new List<TsHotPatchPanelConfig>();

		// Token: 0x0400056B RID: 1387
		private TsHotPatchPanelConfig CurrentPanelConfig;

		// Token: 0x0400056C RID: 1388
		private readonly Dictionary<string, UObject> TypeCache = new Dictionary<string, UObject>();

		// Token: 0x0400056D RID: 1389
		private readonly Dictionary<EGamepadKey, UTexture> XboxKeyAndTextureMap = new Dictionary<EGamepadKey, UTexture>();

		// Token: 0x0400056E RID: 1390
		private readonly Dictionary<EGamepadKey, UTexture> PsKeyAndTextureMap = new Dictionary<EGamepadKey, UTexture>();

		// Token: 0x0400056F RID: 1391
		[Nullable(2)]
		private static HotPatchInputManager _instance;
	}
}
