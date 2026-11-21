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
	// Token: 0x02000128 RID: 296
	[NullableContext(1)]
	[Nullable(0)]
	public class HotPatchInputManager : Singleton
	{
		// Token: 0x06000973 RID: 2419 RVA: 0x0004413C File Offset: 0x0004233C
		private UniTask InitActionHandle()
		{
			HotPatchInputManager.<InitActionHandle>d__13 <InitActionHandle>d__;
			<InitActionHandle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitActionHandle>d__.<>4__this = this;
			<InitActionHandle>d__.<>1__state = -1;
			<InitActionHandle>d__.<>t__builder.Start<HotPatchInputManager.<InitActionHandle>d__13>(ref <InitActionHandle>d__);
			return <InitActionHandle>d__.<>t__builder.Task;
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00044180 File Offset: 0x00042380
		private void RegisterInputActionSettings(string actionName, string keyName)
		{
			UInputSettings inputSettings = UInputSettings.GetInputSettings();
			FInputActionKeyMapping item = new FInputActionKeyMapping
			{
				ActionName = actionName,
				Key = new FKey
				{
					KeyName = keyName
				}
			};
			inputSettings.AddActionMapping(item, true);
			this.InputActionKeyMappings.Add(item);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x000441D0 File Offset: 0x000423D0
		private void RegisterInputAxisSettings(string axisName, [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<string, int> keyScale)
		{
			UInputSettings inputSettings = UInputSettings.GetInputSettings();
			FInputAxisKeyMapping item = new FInputAxisKeyMapping
			{
				AxisName = axisName,
				Scale = (float)keyScale.Item2,
				Key = new FKey
				{
					KeyName = keyScale.Item1
				}
			};
			inputSettings.AddAxisMapping(item, true);
			this.InputAxisKeyMappings.Add(item);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00044234 File Offset: 0x00042434
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

		// Token: 0x06000977 RID: 2423 RVA: 0x00044360 File Offset: 0x00042560
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

		// Token: 0x06000978 RID: 2424 RVA: 0x000443D4 File Offset: 0x000425D4
		private void NewActionHandle(string actionName)
		{
			TsHotFixActionHandle_C tsHotFixActionHandle_C = new TsHotFixActionHandle_C(this.WorldContext, null, EObjectFlags.RF_NoFlags);
			tsHotFixActionHandle_C.OnPressActionCallback.Add(new Action<bool, string, FKey>(this.InputActionCallback));
			tsHotFixActionHandle_C.AddPressBinding(actionName, this.PlayerController);
			tsHotFixActionHandle_C.AddReleaseBinding(actionName, this.PlayerController);
			this.ActionHandleMap[actionName] = tsHotFixActionHandle_C;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00044430 File Offset: 0x00042630
		private void NewAxisHandle(string axisName)
		{
			TsHotFixActionHandle_C tsHotFixActionHandle_C = new TsHotFixActionHandle_C(this.WorldContext, null, EObjectFlags.RF_NoFlags);
			tsHotFixActionHandle_C.OnAxisCallback.Add(new Action<float, string>(this.InputAxisCallback));
			tsHotFixActionHandle_C.AddAxisBinding(axisName, this.PlayerController);
			this.AxisHandleMap[axisName] = tsHotFixActionHandle_C;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0004447C File Offset: 0x0004267C
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

		// Token: 0x0600097B RID: 2427 RVA: 0x00044574 File Offset: 0x00042774
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

		// Token: 0x0600097C RID: 2428 RVA: 0x000445E8 File Offset: 0x000427E8
		private void RegsiterAnyKeyInput()
		{
			TsHotFixActionHandle_C tsHotFixActionHandle_C = new TsHotFixActionHandle_C(this.WorldContext, null, EObjectFlags.RF_NoFlags);
			tsHotFixActionHandle_C.OnAnyKeyPressCallback.Add(new Action<FKey>(this.OnAnyKeyPress));
			tsHotFixActionHandle_C.AddAnyKeyPress(this.PlayerController, new FInputChord
			{
				Key = new FKey
				{
					KeyName = "AnyKey"
				}
			});
			this.AnyKeyHandle = tsHotFixActionHandle_C;
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00044650 File Offset: 0x00042850
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

		// Token: 0x0600097E RID: 2430 RVA: 0x000446B0 File Offset: 0x000428B0
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

		// Token: 0x0600097F RID: 2431 RVA: 0x00044710 File Offset: 0x00042910
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

		// Token: 0x06000980 RID: 2432 RVA: 0x0004472A File Offset: 0x0004292A
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

		// Token: 0x06000981 RID: 2433 RVA: 0x00044743 File Offset: 0x00042943
		private void InputChangeDelegate(EInputControllerType _, EInputControllerType __)
		{
			this.CurrentPanelConfig.RefreshTexture();
			this.PlayerController.bShowMouseCursor = InputDevice.Instance.IsInKeyBoard();
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00044768 File Offset: 0x00042968
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

		// Token: 0x06000983 RID: 2435 RVA: 0x000447E4 File Offset: 0x000429E4
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

		// Token: 0x06000984 RID: 2436 RVA: 0x00044828 File Offset: 0x00042A28
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

		// Token: 0x06000985 RID: 2437 RVA: 0x00044874 File Offset: 0x00042A74
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

		// Token: 0x06000986 RID: 2438 RVA: 0x000448AC File Offset: 0x00042AAC
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

		// Token: 0x06000987 RID: 2439 RVA: 0x000448E8 File Offset: 0x00042AE8
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

		// Token: 0x06000988 RID: 2440 RVA: 0x00044920 File Offset: 0x00042B20
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

		// Token: 0x06000989 RID: 2441 RVA: 0x0004495C File Offset: 0x00042B5C
		public void RegisterOnTouchAction(TTouchAction touchAction)
		{
			this.TouchAction = touchAction;
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00044965 File Offset: 0x00042B65
		public void UnRegisterOnTouchAction()
		{
			this.TouchAction = null;
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0004496E File Offset: 0x00042B6E
		public void RegisterOnTouchMovedAction(TTouchMovedAction touchMovedAction)
		{
			this.TouchMovedAction = touchMovedAction;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00044977 File Offset: 0x00042B77
		public void UnRegisterOnTouchMovedAction()
		{
			this.TouchMovedAction = null;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00044980 File Offset: 0x00042B80
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

		// Token: 0x0600098E RID: 2446 RVA: 0x00044AD8 File Offset: 0x00042CD8
		private UniTask InitHotPatchPanelConfigType()
		{
			HotPatchInputManager.<InitHotPatchPanelConfigType>d__43 <InitHotPatchPanelConfigType>d__;
			<InitHotPatchPanelConfigType>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitHotPatchPanelConfigType>d__.<>4__this = this;
			<InitHotPatchPanelConfigType>d__.<>1__state = -1;
			<InitHotPatchPanelConfigType>d__.<>t__builder.Start<HotPatchInputManager.<InitHotPatchPanelConfigType>d__43>(ref <InitHotPatchPanelConfigType>d__);
			return <InitHotPatchPanelConfigType>d__.<>t__builder.Task;
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00044B1B File Offset: 0x00042D1B
		private void ClearTypeCache()
		{
			this.TypeCache.Clear();
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00044B28 File Offset: 0x00042D28
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

		// Token: 0x06000991 RID: 2449 RVA: 0x00044B78 File Offset: 0x00042D78
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

		// Token: 0x06000992 RID: 2450 RVA: 0x00044C0C File Offset: 0x00042E0C
		private UniTask LoadGamepadTexture()
		{
			HotPatchInputManager.<LoadGamepadTexture>d__49 <LoadGamepadTexture>d__;
			<LoadGamepadTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadGamepadTexture>d__.<>4__this = this;
			<LoadGamepadTexture>d__.<>1__state = -1;
			<LoadGamepadTexture>d__.<>t__builder.Start<HotPatchInputManager.<LoadGamepadTexture>d__49>(ref <LoadGamepadTexture>d__);
			return <LoadGamepadTexture>d__.<>t__builder.Task;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00044C50 File Offset: 0x00042E50
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

		// Token: 0x06000994 RID: 2452 RVA: 0x00044CA8 File Offset: 0x00042EA8
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

		// Token: 0x06000995 RID: 2453 RVA: 0x00044CFD File Offset: 0x00042EFD
		private void ClearTexture()
		{
			this.XboxKeyAndTextureMap.Clear();
			this.PsKeyAndTextureMap.Clear();
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00044D18 File Offset: 0x00042F18
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x00044D6E File Offset: 0x00042F6E
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

		// Token: 0x06000998 RID: 2456 RVA: 0x00044D91 File Offset: 0x00042F91
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00044D93 File Offset: 0x00042F93
		public static void ResetStaticDefaultValue()
		{
			HotPatchInputManager instance = HotPatchInputManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			HotPatchInputManager._instance = null;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00044DAC File Offset: 0x00042FAC
		static HotPatchInputManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotPatchInputManager.CreateStaticDefaultValue), new Action(HotPatchInputManager.ResetStaticDefaultValue));
		}

		// Token: 0x04000598 RID: 1432
		[Nullable(2)]
		private UObject WorldContext;

		// Token: 0x04000599 RID: 1433
		[Nullable(2)]
		private APlayerController PlayerController;

		// Token: 0x0400059A RID: 1434
		private readonly Dictionary<string, HashSet<TInputAction>> InputActionMap = new Dictionary<string, HashSet<TInputAction>>();

		// Token: 0x0400059B RID: 1435
		private readonly Dictionary<string, HashSet<TInputAxis>> InputAxisMap = new Dictionary<string, HashSet<TInputAxis>>();

		// Token: 0x0400059C RID: 1436
		private readonly Dictionary<string, TsHotFixActionHandle_C> ActionHandleMap = new Dictionary<string, TsHotFixActionHandle_C>();

		// Token: 0x0400059D RID: 1437
		private readonly Dictionary<string, TsHotFixActionHandle_C> AxisHandleMap = new Dictionary<string, TsHotFixActionHandle_C>();

		// Token: 0x0400059E RID: 1438
		[Nullable(2)]
		private TsHotFixActionHandle_C TouchHandle;

		// Token: 0x0400059F RID: 1439
		[Nullable(2)]
		private TsHotFixActionHandle_C AnyKeyHandle;

		// Token: 0x040005A0 RID: 1440
		[Nullable(2)]
		private TTouchAction TouchAction;

		// Token: 0x040005A1 RID: 1441
		[Nullable(2)]
		private TTouchMovedAction TouchMovedAction;

		// Token: 0x040005A2 RID: 1442
		private readonly List<FInputActionKeyMapping> InputActionKeyMappings = new List<FInputActionKeyMapping>();

		// Token: 0x040005A3 RID: 1443
		private readonly List<FInputAxisKeyMapping> InputAxisKeyMappings = new List<FInputAxisKeyMapping>();

		// Token: 0x040005A4 RID: 1444
		[Nullable(2)]
		private Action WaitingAnyKeyPressCallBack;

		// Token: 0x040005A5 RID: 1445
		private readonly List<TsHotPatchPanelConfig> PanelConfigList = new List<TsHotPatchPanelConfig>();

		// Token: 0x040005A6 RID: 1446
		private TsHotPatchPanelConfig CurrentPanelConfig;

		// Token: 0x040005A7 RID: 1447
		private readonly Dictionary<string, UObject> TypeCache = new Dictionary<string, UObject>();

		// Token: 0x040005A8 RID: 1448
		private readonly Dictionary<EGamepadKey, UTexture> XboxKeyAndTextureMap = new Dictionary<EGamepadKey, UTexture>();

		// Token: 0x040005A9 RID: 1449
		private readonly Dictionary<EGamepadKey, UTexture> PsKeyAndTextureMap = new Dictionary<EGamepadKey, UTexture>();

		// Token: 0x040005AA RID: 1450
		[Nullable(2)]
		private static HotPatchInputManager _instance;
	}
}
