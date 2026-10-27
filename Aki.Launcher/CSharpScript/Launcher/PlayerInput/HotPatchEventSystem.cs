using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Launcher.InputDevice;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.PlayerInput
{
	// Token: 0x02000118 RID: 280
	[NullableContext(2)]
	[Nullable(0)]
	public class HotPatchEventSystem : Singleton
	{
		// Token: 0x0600090C RID: 2316 RVA: 0x000416A8 File Offset: 0x0003F8A8
		private void InitStandaloneInputModule()
		{
			this.StandaloneInputModule = (this.EventSystem.GetComponentByClass(ULGUI_StandaloneInputModule.StaticClass()) as ULGUI_StandaloneInputModule);
			FLGUIPointerInputChange_DynamicDelegate flguipointerInputChange_DynamicDelegate = DelegateUtils.ToManualReleaseDelegate<FLGUIPointerInputChange_DynamicDelegate>(new Action<ELGUIPointerInputType>(this.ChangeController));
			this.HandleWrapper = this.StandaloneInputModule.RegisterInputChangeEvent(flguipointerInputChange_DynamicDelegate);
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x000416FA File Offset: 0x0003F8FA
		private void DestroyStandaloneInputModule()
		{
			this.StandaloneInputModule.UnregisterInputChangeEvent(this.HandleWrapper);
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<ELGUIPointerInputType>(this.ChangeController));
			this.HandleWrapper = null;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00041725 File Offset: 0x0003F925
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

		// Token: 0x0600090F RID: 2319 RVA: 0x00041760 File Offset: 0x0003F960
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

		// Token: 0x06000910 RID: 2320 RVA: 0x000417F8 File Offset: 0x0003F9F8
		private void RegisterInput()
		{
			HotPatchInputManager.Instance.RegisterInputAction("UI左键点击", new TInputAction(this.OnPressActionCallback));
			HotPatchInputManager.Instance.RegisterOnTouchAction(new TTouchAction(this.OnTouchActionCallback));
			HotPatchInputManager.Instance.RegisterOnTouchMovedAction(new TTouchMovedAction(this.OnTouchMovedActionCallback));
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0004184C File Offset: 0x0003FA4C
		private void UnRegisterInput()
		{
			HotPatchInputManager.Instance.UnRegisterInputAction("UI左键点击", new TInputAction(this.OnPressActionCallback));
			HotPatchInputManager.Instance.UnRegisterOnTouchAction();
			HotPatchInputManager.Instance.UnRegisterOnTouchMovedAction();
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0004187D File Offset: 0x0003FA7D
		[NullableContext(1)]
		private void OnPressActionCallback(bool bPress, string type)
		{
			this.StandaloneInputModule.InputTrigger(bPress, EMouseButtonType.Left);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0004188C File Offset: 0x0003FA8C
		private void OnTouchActionCallback(bool inTouchPress, int inTouchId, FVector inTouchPointPosition)
		{
			this.TouchInputModule.InputTouchTrigger(inTouchPress, inTouchId, inTouchPointPosition);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0004189D File Offset: 0x0003FA9D
		private void OnTouchMovedActionCallback(int inTouchId, FVector inTouchPointPosition)
		{
			this.TouchInputModule.InputTouchMoved(inTouchId, inTouchPointPosition);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x000418AD File Offset: 0x0003FAAD
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

		// Token: 0x06000916 RID: 2326 RVA: 0x000418E1 File Offset: 0x0003FAE1
		private void ChangeController(ELGUIPointerInputType type)
		{
			if (type == ELGUIPointerInputType.Pointer)
			{
				this.InputType = ELGUIPointerInputType.Pointer;
				InputDevice.Instance.SwitchInputControllerTypeByMouseMove();
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x000418F8 File Offset: 0x0003FAF8
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

		// Token: 0x06000918 RID: 2328 RVA: 0x00041944 File Offset: 0x0003FB44
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

		// Token: 0x06000919 RID: 2329 RVA: 0x0004198A File Offset: 0x0003FB8A
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

		// Token: 0x0600091A RID: 2330 RVA: 0x000419B4 File Offset: 0x0003FBB4
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

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x00041A23 File Offset: 0x0003FC23
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

		// Token: 0x0600091C RID: 2332 RVA: 0x00041A46 File Offset: 0x0003FC46
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00041A48 File Offset: 0x0003FC48
		public static void ResetStaticDefaultValue()
		{
			HotPatchEventSystem instance = HotPatchEventSystem._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			HotPatchEventSystem._instance = null;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00041A61 File Offset: 0x0003FC61
		static HotPatchEventSystem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotPatchEventSystem.CreateStaticDefaultValue), new Action(HotPatchEventSystem.ResetStaticDefaultValue));
		}

		// Token: 0x04000526 RID: 1318
		private const int GAMEPAD_ID = 999;

		// Token: 0x04000527 RID: 1319
		private ALGUIEventSystemActor EventSystem;

		// Token: 0x04000528 RID: 1320
		private UObject WorldContext;

		// Token: 0x04000529 RID: 1321
		private ULGUI_PointerInputModule CurrentInputModule;

		// Token: 0x0400052A RID: 1322
		private ULGUI_StandaloneInputModule StandaloneInputModule;

		// Token: 0x0400052B RID: 1323
		private ULGUI_TouchInputModule TouchInputModule;

		// Token: 0x0400052C RID: 1324
		private FLGUIDelegateHandleWrapper HandleWrapper;

		// Token: 0x0400052D RID: 1325
		private ELGUIPointerInputType InputType = ELGUIPointerInputType.None;

		// Token: 0x0400052E RID: 1326
		private static HotPatchEventSystem _instance;
	}
}
