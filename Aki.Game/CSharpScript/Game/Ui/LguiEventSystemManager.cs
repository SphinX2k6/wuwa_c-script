using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035EA RID: 13802
	[NullableContext(2)]
	[Nullable(0)]
	public class LguiEventSystemManager : Singleton
	{
		// Token: 0x1700491F RID: 18719
		// (get) Token: 0x0602326B RID: 143979 RVA: 0x009FD3CF File Offset: 0x009FB5CF
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

		// Token: 0x0602326C RID: 143980 RVA: 0x009FD3E4 File Offset: 0x009FB5E4
		public UniTask Initialize()
		{
			LguiEventSystemManager.<Initialize>d__4 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<LguiEventSystemManager.<Initialize>d__4>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x0602326D RID: 143981 RVA: 0x009FD427 File Offset: 0x009FB627
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

		// Token: 0x0602326E RID: 143982 RVA: 0x009FD44C File Offset: 0x009FB64C
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

		// Token: 0x0602326F RID: 143983 RVA: 0x009FD4A0 File Offset: 0x009FB6A0
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

		// Token: 0x06023270 RID: 143984 RVA: 0x009FD521 File Offset: 0x009FB721
		public void RefreshCurrentInputModule()
		{
			TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
			if (lguiEventSystemActorInternal == null)
			{
				return;
			}
			lguiEventSystemActorInternal.RefreshCurrentInputModule();
		}

		// Token: 0x06023271 RID: 143985 RVA: 0x009FD533 File Offset: 0x009FB733
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

		// Token: 0x06023272 RID: 143986 RVA: 0x009FD546 File Offset: 0x009FB746
		public void InputWheelAxisByGamepad(float value)
		{
			TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
			if (lguiEventSystemActorInternal == null)
			{
				return;
			}
			lguiEventSystemActorInternal.InputScrollByGamepad(value);
		}

		// Token: 0x06023273 RID: 143987 RVA: 0x009FD559 File Offset: 0x009FB759
		public void InputTouchTrigger(bool bTouchPress, int touchId, FVector touchPosition)
		{
			TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
			if (lguiEventSystemActorInternal == null)
			{
				return;
			}
			lguiEventSystemActorInternal.InputTouchTrigger(bTouchPress, touchId, touchPosition);
		}

		// Token: 0x06023274 RID: 143988 RVA: 0x009FD56E File Offset: 0x009FB76E
		public void InputLguiTouchMove(int touchId, FVector touchPosition)
		{
			TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
			if (lguiEventSystemActorInternal == null)
			{
				return;
			}
			lguiEventSystemActorInternal.InputTouchMove(touchId, touchPosition);
		}

		// Token: 0x06023275 RID: 143989 RVA: 0x009FD582 File Offset: 0x009FB782
		public void SetEventDataPrevPosition(float x, float y)
		{
			TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
			if (lguiEventSystemActorInternal == null)
			{
				return;
			}
			lguiEventSystemActorInternal.SetPrevMousePosition(x, y);
		}

		// Token: 0x17004920 RID: 18720
		// (get) Token: 0x06023276 RID: 143990 RVA: 0x009FD596 File Offset: 0x009FB796
		public TsLguiEventSystemActor LguiEventSystemActor
		{
			get
			{
				return this.LguiEventSystemActorInternal;
			}
		}

		// Token: 0x06023277 RID: 143991 RVA: 0x009FD59E File Offset: 0x009FB79E
		public UUIItem GetNowHitComponent()
		{
			TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
			if (lguiEventSystemActorInternal == null)
			{
				return null;
			}
			return lguiEventSystemActorInternal.GetNowHitComponent();
		}

		// Token: 0x06023278 RID: 143992 RVA: 0x009FD5B4 File Offset: 0x009FB7B4
		public string GetNowHitComponentName()
		{
			UUIItem nowHitComponent = this.GetNowHitComponent();
			if (nowHitComponent == null)
			{
				return null;
			}
			return nowHitComponent.GetDisplayName();
		}

		// Token: 0x06023279 RID: 143993 RVA: 0x009FD5D3 File Offset: 0x009FB7D3
		public ULGUIPointerEventData GetPointerEventData(int pointerId, bool createIfNotExist = false)
		{
			TsLguiEventSystemActor lguiEventSystemActorInternal = this.LguiEventSystemActorInternal;
			if (lguiEventSystemActorInternal == null)
			{
				return null;
			}
			return lguiEventSystemActorInternal.GetPointerEventData((float)pointerId, createIfNotExist);
		}

		// Token: 0x0602327A RID: 143994 RVA: 0x009FD5EC File Offset: 0x009FB7EC
		public FVector? GetPointerEventDataPosition(int pointerId)
		{
			ULGUIPointerEventData pointerEventData = this.GetPointerEventData(pointerId, false);
			if (pointerEventData == null)
			{
				return null;
			}
			return new FVector?(pointerEventData.pointerPosition);
		}

		// Token: 0x0602327B RID: 143995 RVA: 0x009FD61C File Offset: 0x009FB81C
		public bool IsPressComponentIsValid(int pointerId)
		{
			ULGUIPointerEventData pointerEventData = this.GetPointerEventData(pointerId, false);
			return pointerEventData != null && pointerEventData.enterComponent != null && pointerEventData.pressComponent != null;
		}

		// Token: 0x0602327C RID: 143996 RVA: 0x009FD64C File Offset: 0x009FB84C
		public bool IsNowTriggerPressed(int pointerId)
		{
			ULGUIPointerEventData pointerEventData = this.GetPointerEventData(pointerId, false);
			return pointerEventData != null && pointerEventData.nowIsTriggerPressed;
		}

		// Token: 0x17004921 RID: 18721
		// (get) Token: 0x0602327D RID: 143997 RVA: 0x009FD66D File Offset: 0x009FB86D
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

		// Token: 0x0602327E RID: 143998 RVA: 0x009FD690 File Offset: 0x009FB890
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602327F RID: 143999 RVA: 0x009FD692 File Offset: 0x009FB892
		public static void ResetStaticDefaultValue()
		{
			LguiEventSystemManager instance = LguiEventSystemManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LguiEventSystemManager._instance = null;
		}

		// Token: 0x06023280 RID: 144000 RVA: 0x009FD6AB File Offset: 0x009FB8AB
		static LguiEventSystemManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LguiEventSystemManager.CreateStaticDefaultValue), new Action(LguiEventSystemManager.ResetStaticDefaultValue));
		}

		// Token: 0x04013D6B RID: 81259
		private TsLguiEventSystemActor LguiEventSystemActorInternal;

		// Token: 0x04013D6C RID: 81260
		private bool IsInitializing;

		// Token: 0x04013D6D RID: 81261
		private static LguiEventSystemManager _instance;
	}
}
