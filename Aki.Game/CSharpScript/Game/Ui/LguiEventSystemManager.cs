using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046B9 RID: 18105
	[NullableContext(2)]
	[Nullable(0)]
	public class LguiEventSystemManager : Singleton
	{
		// Token: 0x17007663 RID: 30307
		// (get) Token: 0x0602EB1F RID: 191263 RVA: 0x00ACEAFB File Offset: 0x00ACCCFB
		public ULGUIEventSystem LguiEventSystem
		{
			get
			{
				TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
				if (lguiEventSystemActorInternal == null)
				{
					return null;
				}
				return lguiEventSystemActorInternal.EventSystem;
			}
		}

		// Token: 0x0602EB20 RID: 191264 RVA: 0x00ACEB10 File Offset: 0x00ACCD10
		public UniTask Initialize()
		{
			LguiEventSystemManager.<Initialize>d__4 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<LguiEventSystemManager.<Initialize>d__4>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x0602EB21 RID: 191265 RVA: 0x00ACEB53 File Offset: 0x00ACCD53
		public void Clear()
		{
			EventSystem.Instance.Emit(EEventName.DestroyLguiEventSystemActor);
			TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
			if (lguiEventSystemActorInternal == null)
			{
				return;
			}
			lguiEventSystemActorInternal.ResetLguiEventSystemActor();
		}

		// Token: 0x0602EB22 RID: 191266 RVA: 0x00ACEB78 File Offset: 0x00ACCD78
		[NullableContext(1)]
		public void ClickedMouse(string actionName, InputDistributeDefine.EActionType actionType)
		{
			TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
			if (lguiEventSystemActorInternal == null || !lguiEventSystemActorInternal.IsValid())
			{
				return;
			}
			bool triggerPress = actionType == InputDistributeDefine.EActionType.Press;
			if (actionName == "UI左键点击")
			{
				lguiEventSystemActorInternal.InputTrigger(triggerPress, EMouseButtonType.Left);
				return;
			}
			if (!(actionName == "UI右键点击"))
			{
				return;
			}
			lguiEventSystemActorInternal.InputTrigger(triggerPress, EMouseButtonType.Right);
		}

		// Token: 0x0602EB23 RID: 191267 RVA: 0x00ACEBCC File Offset: 0x00ACCDCC
		[NullableContext(1)]
		public void InputNavigation(string actionName, InputDistributeDefine.EActionType actionType)
		{
			TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
			if (lguiEventSystemActorInternal == null || !lguiEventSystemActorInternal.IsValid())
			{
				return;
			}
			bool pressOrRelease = actionType == InputDistributeDefine.EActionType.Press;
			if (actionName == "UI方向上")
			{
				lguiEventSystemActorInternal.InputNavigation(ELGUINavigationDirection.Up, pressOrRelease, false);
				return;
			}
			if (actionName == "UI方向下")
			{
				lguiEventSystemActorInternal.InputNavigation(ELGUINavigationDirection.Down, pressOrRelease, false);
				return;
			}
			if (actionName == "UI方向左")
			{
				lguiEventSystemActorInternal.InputNavigation(ELGUINavigationDirection.Left, pressOrRelease, false);
				return;
			}
			if (!(actionName == "UI方向右"))
			{
				return;
			}
			lguiEventSystemActorInternal.InputNavigation(ELGUINavigationDirection.Right, pressOrRelease, false);
		}

		// Token: 0x0602EB24 RID: 191268 RVA: 0x00ACEC4D File Offset: 0x00ACCE4D
		public void RefreshCurrentInputModule()
		{
			TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
			if (lguiEventSystemActorInternal == null)
			{
				return;
			}
			lguiEventSystemActorInternal.RefreshCurrentInputModule();
		}

		// Token: 0x0602EB25 RID: 191269 RVA: 0x00ACEC5F File Offset: 0x00ACCE5F
		[NullableContext(1)]
		public void InputWheelAxis(string axisName, float value)
		{
			TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
			if (lguiEventSystemActorInternal == null)
			{
				return;
			}
			lguiEventSystemActorInternal.InputScroll(value);
		}

		// Token: 0x0602EB26 RID: 191270 RVA: 0x00ACEC72 File Offset: 0x00ACCE72
		public void InputWheelAxisByGamepad(float value)
		{
			TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
			if (lguiEventSystemActorInternal == null)
			{
				return;
			}
			lguiEventSystemActorInternal.InputScrollByGamepad(value);
		}

		// Token: 0x0602EB27 RID: 191271 RVA: 0x00ACEC85 File Offset: 0x00ACCE85
		public void InputTouchTrigger(bool bTouchPress, int touchId, FVector touchPosition)
		{
			TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
			if (lguiEventSystemActorInternal == null)
			{
				return;
			}
			lguiEventSystemActorInternal.InputTouchTrigger(bTouchPress, touchId, touchPosition);
		}

		// Token: 0x0602EB28 RID: 191272 RVA: 0x00ACEC9A File Offset: 0x00ACCE9A
		public void InputLguiTouchMove(int touchId, FVector touchPosition)
		{
			TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
			if (lguiEventSystemActorInternal == null)
			{
				return;
			}
			lguiEventSystemActorInternal.InputTouchMove(touchId, touchPosition);
		}

		// Token: 0x0602EB29 RID: 191273 RVA: 0x00ACECAE File Offset: 0x00ACCEAE
		public void SetEventDataPrevPosition(float x, float y)
		{
			TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
			if (lguiEventSystemActorInternal == null)
			{
				return;
			}
			lguiEventSystemActorInternal.SetPrevMousePosition(x, y);
		}

		// Token: 0x17007664 RID: 30308
		// (get) Token: 0x0602EB2A RID: 191274 RVA: 0x00ACECC2 File Offset: 0x00ACCEC2
		public TsLguiEventSystemActor LguiEventSystemActor
		{
			get
			{
				return this.LguiEventSystemActorInternal;
			}
		}

		// Token: 0x0602EB2B RID: 191275 RVA: 0x00ACECCA File Offset: 0x00ACCECA
		public UUIItem GetNowHitComponent()
		{
			TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
			if (lguiEventSystemActorInternal == null)
			{
				return null;
			}
			return lguiEventSystemActorInternal.GetNowHitComponent();
		}

		// Token: 0x0602EB2C RID: 191276 RVA: 0x00ACECE0 File Offset: 0x00ACCEE0
		public string GetNowHitComponentName()
		{
			UUIItem nowHitComponent = this.GetNowHitComponent();
			if (nowHitComponent == null)
			{
				return null;
			}
			return nowHitComponent.GetDisplayName();
		}

		// Token: 0x0602EB2D RID: 191277 RVA: 0x00ACECFF File Offset: 0x00ACCEFF
		public ULGUIPointerEventData GetPointerEventData(int pointerId, bool createIfNotExist = false)
		{
			TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
			if (lguiEventSystemActorInternal == null)
			{
				return null;
			}
			return lguiEventSystemActorInternal.GetPointerEventData((float)pointerId, createIfNotExist);
		}

		// Token: 0x0602EB2E RID: 191278 RVA: 0x00ACED18 File Offset: 0x00ACCF18
		public FVector? GetPointerEventDataPosition(int pointerId)
		{
			ULGUIPointerEventData pointerEventData = this.GetPointerEventData(pointerId, false);
			if (pointerEventData == null)
			{
				return null;
			}
			return new FVector?(pointerEventData.pointerPosition);
		}

		// Token: 0x0602EB2F RID: 191279 RVA: 0x00ACED48 File Offset: 0x00ACCF48
		public bool IsPressComponentIsValid(int pointerId)
		{
			ULGUIPointerEventData pointerEventData = this.GetPointerEventData(pointerId, false);
			return pointerEventData != null && pointerEventData.enterComponent != null && pointerEventData.pressComponent != null;
		}

		// Token: 0x0602EB30 RID: 191280 RVA: 0x00ACED78 File Offset: 0x00ACCF78
		public bool IsNowTriggerPressed(int pointerId)
		{
			ULGUIPointerEventData pointerEventData = this.GetPointerEventData(pointerId, false);
			return pointerEventData != null && pointerEventData.nowIsTriggerPressed;
		}

		// Token: 0x17007665 RID: 30309
		// (get) Token: 0x0602EB31 RID: 191281 RVA: 0x00ACED99 File Offset: 0x00ACCF99
		[Nullable(1)]
		public static LguiEventSystemManager Instance
		{
			[NullableContext(1)]
			get
			{
				if (LguiEventSystemManager._instance == null)
				{
					LguiEventSystemManager._instance = new LguiEventSystemManager();
					LguiEventSystemManager._instance.OnInit();
				}
				return LguiEventSystemManager._instance;
			}
		}

		// Token: 0x0602EB32 RID: 191282 RVA: 0x00ACEDBC File Offset: 0x00ACCFBC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EB33 RID: 191283 RVA: 0x00ACEDBE File Offset: 0x00ACCFBE
		public static void ResetStaticDefaultValue()
		{
			LguiEventSystemManager instance = LguiEventSystemManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LguiEventSystemManager._instance = null;
		}

		// Token: 0x0602EB34 RID: 191284 RVA: 0x00ACEDD7 File Offset: 0x00ACCFD7
		static LguiEventSystemManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LguiEventSystemManager.CreateStaticDefaultValue), new Action(LguiEventSystemManager.ResetStaticDefaultValue));
		}

		// Token: 0x040196C6 RID: 104134
		private TsLguiEventSystemActor LguiEventSystemActorInternal;

		// Token: 0x040196C7 RID: 104135
		private bool IsInitializing;

		// Token: 0x040196C8 RID: 104136
		private static LguiEventSystemManager _instance;
	}
}
