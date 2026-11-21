using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.TurntableControl
{
	// Token: 0x02005B17 RID: 23319
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class TurntableControlController : UiControllerBase
	{
		// Token: 0x060395E1 RID: 234977 RVA: 0x01019A18 File Offset: 0x01017C18
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandleFail, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandleFail));
		}

		// Token: 0x060395E2 RID: 234978 RVA: 0x01019A36 File Offset: 0x01017C36
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandleFail, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandleFail));
		}

		// Token: 0x060395E3 RID: 234979 RVA: 0x01019A54 File Offset: 0x01017C54
		private void OnActivateUiCameraAnimationHandleFail(UiCameraHandleData _)
		{
			Log.Instance.Warn(ELogModule.SceneItem, ELogAuthor.ZYL, "[TurntableControlView] 激活UI相机Seq失败，关闭UI", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (UiManager.Instance.IsViewOpen(EUiViewName.TurntableControlView))
			{
				UiManager.Instance.CloseView(EUiViewName.TurntableControlView, null);
			}
		}

		// Token: 0x060395E4 RID: 234980 RVA: 0x01019A9E File Offset: 0x01017C9E
		public override bool Clear()
		{
			this.RemoveControllerEntityEvents();
			return base.Clear();
		}

		// Token: 0x060395E5 RID: 234981 RVA: 0x01019AAC File Offset: 0x01017CAC
		private void AddControllerEntityEvents()
		{
			TurntableControlModel instance = TurntableControlModel.Instance;
			if (((instance != null) ? instance.CurControllerEntity : null) == null)
			{
				return;
			}
			if (!EventSystem.Instance.HasWithTarget(instance.CurControllerEntity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.HandleControllerUpdateState)))
			{
				EventSystem.Instance.AddWithTarget(instance.CurControllerEntity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.HandleControllerUpdateState));
			}
		}

		// Token: 0x060395E6 RID: 234982 RVA: 0x01019B14 File Offset: 0x01017D14
		private void RemoveControllerEntityEvents()
		{
			TurntableControlModel instance = TurntableControlModel.Instance;
			if (((instance != null) ? instance.CurControllerEntity : null) == null)
			{
				return;
			}
			if (EventSystem.Instance.HasWithTarget(instance.CurControllerEntity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.HandleControllerUpdateState)))
			{
				EventSystem.Instance.RemoveWithTarget(instance.CurControllerEntity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.HandleControllerUpdateState));
			}
		}

		// Token: 0x060395E7 RID: 234983 RVA: 0x01019B7B File Offset: 0x01017D7B
		private void HandleControllerUpdateState(int stateId, bool isReady)
		{
			if (stateId == GameplayTagDefine.EGameplayTagId["关卡.Common.状态.完成"] && isReady)
			{
				this.HandleTurntableControlViewClose();
				UiManager.Instance.CloseView(EUiViewName.TurntableControlView, null);
			}
		}

		// Token: 0x060395E8 RID: 234984 RVA: 0x01019BAC File Offset: 0x01017DAC
		[NullableContext(0)]
		public UniTask<bool> OpenTurntableControlView(int controllerEntityId)
		{
			TurntableControlController.<OpenTurntableControlView>d__7 <OpenTurntableControlView>d__;
			<OpenTurntableControlView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenTurntableControlView>d__.<>4__this = this;
			<OpenTurntableControlView>d__.controllerEntityId = controllerEntityId;
			<OpenTurntableControlView>d__.<>1__state = -1;
			<OpenTurntableControlView>d__.<>t__builder.Start<TurntableControlController.<OpenTurntableControlView>d__7>(ref <OpenTurntableControlView>d__);
			return <OpenTurntableControlView>d__.<>t__builder.Task;
		}

		// Token: 0x060395E9 RID: 234985 RVA: 0x01019BF8 File Offset: 0x01017DF8
		public void HandleTurntableControlViewClose()
		{
			this.RemoveControllerEntityEvents();
			TurntableControlModel instance = TurntableControlModel.Instance;
			SceneItemTurntableControllerComponent curControllerEntityComp = instance.CurControllerEntityComp;
			if (curControllerEntityComp != null)
			{
				curControllerEntityComp.TriggerStopAllRingsRotate();
				curControllerEntityComp.DeselectAllRings(true);
				curControllerEntityComp.SetAllowRotate(false);
			}
			instance.ClearCurControllerEntity();
		}

		// Token: 0x060395EA RID: 234986 RVA: 0x01019C33 File Offset: 0x01017E33
		[NullableContext(2)]
		public Entity GetControllerEntity()
		{
			return TurntableControlModel.Instance.CurControllerEntity;
		}

		// Token: 0x060395EB RID: 234987 RVA: 0x01019C40 File Offset: 0x01017E40
		public void StartRotateSelected()
		{
			TurntableControlModel instance = TurntableControlModel.Instance;
			if (((instance != null) ? instance.CurControllerEntityComp : null) == null)
			{
				return;
			}
			instance.CurControllerEntityComp.TriggerStartSelectedRingsRotate();
		}

		// Token: 0x060395EC RID: 234988 RVA: 0x01019C70 File Offset: 0x01017E70
		public void StopAllRotate()
		{
			TurntableControlModel instance = TurntableControlModel.Instance;
			if (((instance != null) ? instance.CurControllerEntityComp : null) == null)
			{
				return;
			}
			if (instance.CurControllerEntityComp.GetControlType() == EControllerType.FreeAngle)
			{
				instance.CurControllerEntityComp.TriggerStopAllRingsRotate();
			}
		}

		// Token: 0x060395ED RID: 234989 RVA: 0x01019CAC File Offset: 0x01017EAC
		public bool IsAllRingsAtTarget()
		{
			TurntableControlModel instance = TurntableControlModel.Instance;
			return ((instance != null) ? instance.CurControllerEntityComp : null) != null && instance.CurControllerEntityComp.IsAllRingsAtTarget();
		}

		// Token: 0x060395EE RID: 234990 RVA: 0x01019CDC File Offset: 0x01017EDC
		public bool IsBusyRotating()
		{
			TurntableControlModel instance = TurntableControlModel.Instance;
			return ((instance != null) ? instance.CurControllerEntityComp : null) != null && instance.CurControllerEntityComp.IsBusyRotating();
		}

		// Token: 0x060395EF RID: 234991 RVA: 0x01019D0C File Offset: 0x01017F0C
		public void SwitchSelectedRing()
		{
			TurntableControlModel instance = TurntableControlModel.Instance;
			if (((instance != null) ? instance.CurControllerEntityComp : null) == null)
			{
				return;
			}
			int? ringsNum = instance.CurControllerEntityComp.GetRingsNum();
			for (int i = 0; i < ringsNum.Value; i++)
			{
				if (instance.CurControllerEntityComp.IsRingSelectedByIndex(i))
				{
					int index = (i + 1 >= ringsNum.Value) ? 0 : (i + 1);
					this.SelectRingByIndex(index, true);
					return;
				}
			}
			this.SelectRingByIndex(0, true);
		}

		// Token: 0x060395F0 RID: 234992 RVA: 0x01019D80 File Offset: 0x01017F80
		public void SelectRingByIndex(int index, bool exclusive)
		{
			TurntableControlModel instance = TurntableControlModel.Instance;
			if (((instance != null) ? instance.CurControllerEntityComp : null) == null)
			{
				return;
			}
			if (exclusive)
			{
				instance.CurControllerEntityComp.DeselectAllRings(false);
				instance.CurControllerEntityComp.SelectRingByIndex(index, false);
				instance.CurControllerEntityComp.UpdateAllRingsSelectedEffect();
				return;
			}
			instance.CurControllerEntityComp.SelectRingByIndex(index, true);
		}

		// Token: 0x060395F1 RID: 234993 RVA: 0x01019DD8 File Offset: 0x01017FD8
		public void DeselectRingByIndex(int index)
		{
			TurntableControlModel instance = TurntableControlModel.Instance;
			if (((instance != null) ? instance.CurControllerEntityComp : null) == null)
			{
				return;
			}
			instance.CurControllerEntityComp.DeselectRingByIndex(index, true);
		}

		// Token: 0x060395F2 RID: 234994 RVA: 0x01019E08 File Offset: 0x01018008
		public void ResetRingsAngle()
		{
			TurntableControlModel instance = TurntableControlModel.Instance;
			if (((instance != null) ? instance.CurControllerEntityComp : null) == null)
			{
				return;
			}
			instance.CurControllerEntityComp.TriggerResetAllRingsToInitAngle(false);
		}

		// Token: 0x060395F3 RID: 234995 RVA: 0x01019E38 File Offset: 0x01018038
		public EControllerType? GetControlType()
		{
			TurntableControlModel instance = TurntableControlModel.Instance;
			if (((instance != null) ? instance.CurControllerEntityComp : null) == null)
			{
				return null;
			}
			return new EControllerType?(instance.CurControllerEntityComp.GetControlType());
		}

		// Token: 0x17006D40 RID: 27968
		// (get) Token: 0x060395F4 RID: 234996 RVA: 0x01019E73 File Offset: 0x01018073
		public static TurntableControlController Instance
		{
			get
			{
				return TurntableControlController._Instance;
			}
		}

		// Token: 0x060395F5 RID: 234997 RVA: 0x01019E7A File Offset: 0x0101807A
		public static TurntableControlController GetOrCreateInstance()
		{
			if (TurntableControlController._Instance == null)
			{
				TurntableControlController.CreateInstance();
			}
			return TurntableControlController._Instance;
		}

		// Token: 0x060395F6 RID: 234998 RVA: 0x01019E8E File Offset: 0x0101808E
		public static bool CreateInstance()
		{
			if (TurntableControlController._Instance != null)
			{
				return true;
			}
			TurntableControlController._Instance = new TurntableControlController();
			return true;
		}

		// Token: 0x060395F7 RID: 234999 RVA: 0x01019EA4 File Offset: 0x010180A4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060395F8 RID: 235000 RVA: 0x01019EA6 File Offset: 0x010180A6
		public static void ResetStaticDefaultValue()
		{
			TurntableControlController._Instance = null;
		}

		// Token: 0x060395F9 RID: 235001 RVA: 0x01019EAE File Offset: 0x010180AE
		static TurntableControlController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TurntableControlController.CreateStaticDefaultValue), new Action(TurntableControlController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E417 RID: 123927
		[Nullable(2)]
		private static TurntableControlController _Instance;
	}
}
