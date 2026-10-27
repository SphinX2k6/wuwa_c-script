using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.TurntableControl
{
	// Token: 0x020069BB RID: 27067
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class TurntableControlController : UiControllerBase
	{
		// Token: 0x060435A5 RID: 275877 RVA: 0x01075584 File Offset: 0x01073784
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandleFail, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandleFail));
		}

		// Token: 0x060435A6 RID: 275878 RVA: 0x010755A2 File Offset: 0x010737A2
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandleFail, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandleFail));
		}

		// Token: 0x060435A7 RID: 275879 RVA: 0x010755C0 File Offset: 0x010737C0
		private void OnActivateUiCameraAnimationHandleFail(UiCameraHandleData _)
		{
			Log.Instance.Warn(ELogModule.SceneItem, ELogAuthor.ZYL, "[TurntableControlView] 激活UI相机Seq失败，关闭UI", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (UiManager.Instance.IsViewOpen(EUiViewName.TurntableControlView))
			{
				UiManager.Instance.CloseView(EUiViewName.TurntableControlView, null);
			}
		}

		// Token: 0x060435A8 RID: 275880 RVA: 0x0107560A File Offset: 0x0107380A
		public override bool Clear()
		{
			this.RemoveControllerEntityEvents();
			return base.Clear();
		}

		// Token: 0x060435A9 RID: 275881 RVA: 0x01075618 File Offset: 0x01073818
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

		// Token: 0x060435AA RID: 275882 RVA: 0x01075680 File Offset: 0x01073880
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

		// Token: 0x060435AB RID: 275883 RVA: 0x010756E7 File Offset: 0x010738E7
		private void HandleControllerUpdateState(int stateId, bool isReady)
		{
			if (stateId == GameplayTagDefine.EGameplayTagId["关卡.Common.状态.完成"] && isReady)
			{
				this.HandleTurntableControlViewClose();
				UiManager.Instance.CloseView(EUiViewName.TurntableControlView, null);
			}
		}

		// Token: 0x060435AC RID: 275884 RVA: 0x01075718 File Offset: 0x01073918
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

		// Token: 0x060435AD RID: 275885 RVA: 0x01075764 File Offset: 0x01073964
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

		// Token: 0x060435AE RID: 275886 RVA: 0x0107579F File Offset: 0x0107399F
		[NullableContext(2)]
		public Entity GetControllerEntity()
		{
			return TurntableControlModel.Instance.CurControllerEntity;
		}

		// Token: 0x060435AF RID: 275887 RVA: 0x010757AC File Offset: 0x010739AC
		public void StartRotateSelected()
		{
			TurntableControlModel instance = TurntableControlModel.Instance;
			if (((instance != null) ? instance.CurControllerEntityComp : null) == null)
			{
				return;
			}
			instance.CurControllerEntityComp.TriggerStartSelectedRingsRotate();
		}

		// Token: 0x060435B0 RID: 275888 RVA: 0x010757DC File Offset: 0x010739DC
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

		// Token: 0x060435B1 RID: 275889 RVA: 0x01075818 File Offset: 0x01073A18
		public bool IsAllRingsAtTarget()
		{
			TurntableControlModel instance = TurntableControlModel.Instance;
			return ((instance != null) ? instance.CurControllerEntityComp : null) != null && instance.CurControllerEntityComp.IsAllRingsAtTarget();
		}

		// Token: 0x060435B2 RID: 275890 RVA: 0x01075848 File Offset: 0x01073A48
		public bool IsBusyRotating()
		{
			TurntableControlModel instance = TurntableControlModel.Instance;
			return ((instance != null) ? instance.CurControllerEntityComp : null) != null && instance.CurControllerEntityComp.IsBusyRotating();
		}

		// Token: 0x060435B3 RID: 275891 RVA: 0x01075878 File Offset: 0x01073A78
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

		// Token: 0x060435B4 RID: 275892 RVA: 0x010758EC File Offset: 0x01073AEC
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

		// Token: 0x060435B5 RID: 275893 RVA: 0x01075944 File Offset: 0x01073B44
		public void DeselectRingByIndex(int index)
		{
			TurntableControlModel instance = TurntableControlModel.Instance;
			if (((instance != null) ? instance.CurControllerEntityComp : null) == null)
			{
				return;
			}
			instance.CurControllerEntityComp.DeselectRingByIndex(index, true);
		}

		// Token: 0x060435B6 RID: 275894 RVA: 0x01075974 File Offset: 0x01073B74
		public void ResetRingsAngle()
		{
			TurntableControlModel instance = TurntableControlModel.Instance;
			if (((instance != null) ? instance.CurControllerEntityComp : null) == null)
			{
				return;
			}
			instance.CurControllerEntityComp.TriggerResetAllRingsToInitAngle(false);
		}

		// Token: 0x060435B7 RID: 275895 RVA: 0x010759A4 File Offset: 0x01073BA4
		public EControllerType? GetControlType()
		{
			TurntableControlModel instance = TurntableControlModel.Instance;
			if (((instance != null) ? instance.CurControllerEntityComp : null) == null)
			{
				return null;
			}
			return new EControllerType?(instance.CurControllerEntityComp.GetControlType());
		}

		// Token: 0x17009860 RID: 39008
		// (get) Token: 0x060435B8 RID: 275896 RVA: 0x010759DF File Offset: 0x01073BDF
		public static TurntableControlController Instance
		{
			get
			{
				return TurntableControlController._Instance;
			}
		}

		// Token: 0x060435B9 RID: 275897 RVA: 0x010759E6 File Offset: 0x01073BE6
		public static TurntableControlController GetOrCreateInstance()
		{
			if (TurntableControlController._Instance == null)
			{
				TurntableControlController.CreateInstance();
			}
			return TurntableControlController._Instance;
		}

		// Token: 0x060435BA RID: 275898 RVA: 0x010759FA File Offset: 0x01073BFA
		public static bool CreateInstance()
		{
			if (TurntableControlController._Instance != null)
			{
				return true;
			}
			TurntableControlController._Instance = new TurntableControlController();
			return true;
		}

		// Token: 0x060435BB RID: 275899 RVA: 0x01075A10 File Offset: 0x01073C10
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060435BC RID: 275900 RVA: 0x01075A12 File Offset: 0x01073C12
		public static void ResetStaticDefaultValue()
		{
			TurntableControlController._Instance = null;
		}

		// Token: 0x060435BD RID: 275901 RVA: 0x01075A1A File Offset: 0x01073C1A
		static TurntableControlController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TurntableControlController.CreateStaticDefaultValue), new Action(TurntableControlController.ResetStaticDefaultValue));
		}

		// Token: 0x04023227 RID: 143911
		[Nullable(2)]
		private static TurntableControlController _Instance;
	}
}
