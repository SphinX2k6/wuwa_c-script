using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Launcher.InputDevice;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.PlayerInput
{
	// Token: 0x0200011C RID: 284
	[NullableContext(2)]
	[Nullable(0)]
	public class HotPatchEventSystem : Singleton
	{
		// Token: 0x06000940 RID: 2368 RVA: 0x00043A70 File Offset: 0x00041C70
		private void InitStandaloneInputModule()
		{
			this.StandaloneInputModule = (this.EventSystem.GetComponentByClass(ULGUI_StandaloneInputModule.StaticClass()) as ULGUI_StandaloneInputModule);
			FLGUIPointerInputChange_DynamicDelegate flguipointerInputChange_DynamicDelegate = DelegateUtils.ToManualReleaseDelegate<FLGUIPointerInputChange_DynamicDelegate>(new Action<ELGUIPointerInputType>(this.ChangeController));
			this.HandleWrapper = this.StandaloneInputModule.RegisterInputChangeEvent(flguipointerInputChange_DynamicDelegate);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00043AC2 File Offset: 0x00041CC2
		private void DestroyStandaloneInputModule()
		{
			this.StandaloneInputModule.UnregisterInputChangeEvent(this.HandleWrapper);
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<ELGUIPointerInputType>(this.ChangeController));
			this.HandleWrapper = null;
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00043AED File Offset: 0x00041CED
		private void InitCurrentInputModule()
		{
			if (InputDevice.Instance.IsInTouch())
			{
				this.CurrentInputModule = this.TouchInputModule;
			}
			else
			{
				this.CurrentInputModule = this.StandaloneInputModule;
				this.SetWindowCursorStyle();
			}
			this.CurrentInputModule.Activate(false);
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00043B28 File Offset: 0x00041D28
		private void SetWindowCursorStyle()
		{
			FVector2D hotSpot = new FVector2D(0f, 0f);
			UObject worldContext = this.WorldContext;
			FName cursorName;
			FName cursorName2;
			FName cursorName3;
			if (UKuroStaticLibrary.IsEditor(worldContext))
			{
				cursorName = new FName("Aki/UI/Module/Cursor/SourceResource/CursorNor");
				cursorName2 = new FName("Aki/UI/Module/Cursor/SourceResource/CursorHi");
				cursorName3 = new FName("Aki/UI/Module/Cursor/SourceResource/CursorPre");
			}
			else
			{
				cursorName = new FName("Aki/Cursor/CursorNor");
				cursorName2 = new FName("Aki/Cursor/CursorHi");
				cursorName3 = new FName("Aki/Cursor/CursorPre");
			}
			UWidgetBlueprintLibrary.SetHardwareCursor(worldContext, EMouseCursor.Default, cursorName, hotSpot);
			UWidgetBlueprintLibrary.SetHardwareCursor(worldContext, EMouseCursor.CursorEnter, cursorName2, hotSpot);
			UWidgetBlueprintLibrary.SetHardwareCursor(worldContext, EMouseCursor.CursorPress, cursorName3, hotSpot);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00043BC0 File Offset: 0x00041DC0
		private void RegisterInput()
		{
			HotPatchInputManager.Instance.RegisterInputAction("UI左键点击", new TInputAction(this.OnPressActionCallback));
			HotPatchInputManager.Instance.RegisterOnTouchAction(new TTouchAction(this.OnTouchActionCallback));
			HotPatchInputManager.Instance.RegisterOnTouchMovedAction(new TTouchMovedAction(this.OnTouchMovedActionCallback));
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00043C14 File Offset: 0x00041E14
		private void UnRegisterInput()
		{
			HotPatchInputManager.Instance.UnRegisterInputAction("UI左键点击", new TInputAction(this.OnPressActionCallback));
			HotPatchInputManager.Instance.UnRegisterOnTouchAction();
			HotPatchInputManager.Instance.UnRegisterOnTouchMovedAction();
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00043C45 File Offset: 0x00041E45
		[NullableContext(1)]
		private void OnPressActionCallback(bool bPress, string type)
		{
			this.StandaloneInputModule.InputTrigger(bPress, EMouseButtonType.Left);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00043C54 File Offset: 0x00041E54
		private void OnTouchActionCallback(bool inTouchPress, int inTouchId, FVector inTouchPointPosition)
		{
			this.TouchInputModule.InputTouchTrigger(inTouchPress, inTouchId, inTouchPointPosition);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00043C65 File Offset: 0x00041E65
		private void OnTouchMovedActionCallback(int inTouchId, FVector inTouchPointPosition)
		{
			this.TouchInputModule.InputTouchMoved(inTouchId, inTouchPointPosition);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00043C75 File Offset: 0x00041E75
		private void InputChangeDelegate(EInputControllerType _, EInputControllerType __)
		{
			if (InputDevice.Instance.IsInTouch())
			{
				this.CurrentInputModule = this.TouchInputModule;
			}
			else
			{
				this.CurrentInputModule = this.StandaloneInputModule;
			}
			this.CurrentInputModule.Activate(false);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00043CA9 File Offset: 0x00041EA9
		private void ChangeController(ELGUIPointerInputType type)
		{
			if (type == ELGUIPointerInputType.Pointer)
			{
				this.InputType = ELGUIPointerInputType.Pointer;
				InputDevice.Instance.SwitchInputControllerTypeByMouseMove();
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00043CC0 File Offset: 0x00041EC0
		[NullableContext(1)]
		public UniTask InitRuntimeEventSystemActor(UObject worldContext)
		{
			HotPatchEventSystem.<InitRuntimeEventSystemActor>d__19 <InitRuntimeEventSystemActor>d__;
			<InitRuntimeEventSystemActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRuntimeEventSystemActor>d__.<>4__this = this;
			<InitRuntimeEventSystemActor>d__.worldContext = worldContext;
			<InitRuntimeEventSystemActor>d__.<>1__state = -1;
			<InitRuntimeEventSystemActor>d__.<>t__builder.Start<HotPatchEventSystem.<InitRuntimeEventSystemActor>d__19>(ref <InitRuntimeEventSystemActor>d__);
			return <InitRuntimeEventSystemActor>d__.<>t__builder.Task;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00043D0C File Offset: 0x00041F0C
		[NullableContext(1)]
		public bool SimulationPointerDownUp(UUIItem uiItem, bool isPress)
		{
			if (LauncherSdk.Get().GetSdkFocusState())
			{
				return false;
			}
			if (this.CurrentInputModule == this.StandaloneInputModule)
			{
				ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
				int pointerID = 999;
				FVector2D? fvector2D = null;
				return standaloneInputModule.SimulationPointerDownUp(pointerID, uiItem, isPress, fvector2D);
			}
			return false;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00043D52 File Offset: 0x00041F52
		public void SwitchToNavigationInputType()
		{
			if (this.CurrentInputModule == null)
			{
				return;
			}
			if (this.InputType == ELGUIPointerInputType.Navigation)
			{
				return;
			}
			this.InputType = ELGUIPointerInputType.Navigation;
			this.CurrentInputModule.SwitchToNavigationInputType();
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00043D7C File Offset: 0x00041F7C
		public void Destroy()
		{
			InputDevice.Instance.UnRegisterInputChangeDelegate(new Action<EInputControllerType, EInputControllerType>(this.InputChangeDelegate));
			this.DestroyStandaloneInputModule();
			this.UnRegisterInput();
			if (this.EventSystem != null)
			{
				this.EventSystem.PreDestroy();
				ULGUIBPLibrary.DestroyActorWithHierarchy(this.EventSystem, true);
				UKismetSystemLibrary.CollectGarbage();
				this.EventSystem = null;
			}
			this.CurrentInputModule = null;
			this.TouchInputModule = null;
			this.WorldContext = null;
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00043DEB File Offset: 0x00041FEB
		[Nullable(1)]
		public static HotPatchEventSystem Instance
		{
			[NullableContext(1)]
			get
			{
				if (HotPatchEventSystem._instance == null)
				{
					HotPatchEventSystem._instance = new HotPatchEventSystem();
					HotPatchEventSystem._instance.OnInit();
				}
				return HotPatchEventSystem._instance;
			}
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00043E0E File Offset: 0x0004200E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00043E10 File Offset: 0x00042010
		public static void ResetStaticDefaultValue()
		{
			HotPatchEventSystem instance = HotPatchEventSystem._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			HotPatchEventSystem._instance = null;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00043E29 File Offset: 0x00042029
		static HotPatchEventSystem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotPatchEventSystem.CreateStaticDefaultValue), new Action(HotPatchEventSystem.ResetStaticDefaultValue));
		}

		// Token: 0x04000561 RID: 1377
		private const int GAMEPAD_ID = 999;

		// Token: 0x04000562 RID: 1378
		private ALGUIEventSystemActor EventSystem;

		// Token: 0x04000563 RID: 1379
		private UObject WorldContext;

		// Token: 0x04000564 RID: 1380
		private ULGUI_PointerInputModule CurrentInputModule;

		// Token: 0x04000565 RID: 1381
		private ULGUI_StandaloneInputModule StandaloneInputModule;

		// Token: 0x04000566 RID: 1382
		private ULGUI_TouchInputModule TouchInputModule;

		// Token: 0x04000567 RID: 1383
		private FLGUIDelegateHandleWrapper HandleWrapper;

		// Token: 0x04000568 RID: 1384
		private ELGUIPointerInputType InputType = ELGUIPointerInputType.None;

		// Token: 0x04000569 RID: 1385
		private static HotPatchEventSystem _instance;
	}
}
