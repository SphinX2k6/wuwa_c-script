using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B58 RID: 27480
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelEventPlotInterludeAction : LevelEventBase
	{
		// Token: 0x060441D0 RID: 278992 RVA: 0x010C3635 File Offset: 0x010C1835
		public LevelEventPlotInterludeAction(int id) : base(id)
		{
		}

		// Token: 0x060441D1 RID: 278993 RVA: 0x010C3640 File Offset: 0x010C1840
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			this.Param = (inParams as ActionPlotInterludeAction);
			this.Context = context;
			this.Color = new FLinearColor?(new FLinearColor(0f, 0f, 0f, 1f));
			this.CameraManager = Global.CharacterCameraManager;
			if (!ObjectUtils.IsValid(this.CameraManager))
			{
				base.FinishExecute(false, false, true);
				return;
			}
			this.CameraManager.StartCameraFade(0f, 1f, this.Param.FadeInTime, this.Color.Value, false, true, ECameraFadeMode.CFM_Linear);
			TimerSystem.Instance.Delay(new TTimerAction(this.OnFadeInEnded), this.Param.FadeInTime * 1000f, null, null, true, 1f);
		}

		// Token: 0x060441D2 RID: 278994 RVA: 0x010C3711 File Offset: 0x010C1911
		private void OnFadeInEnded(float _)
		{
			LevelGeneralController.Instance.ExecuteActionsNew(this.Param.ActionList, GeneralContext.Copy(this.Context), delegate(ELevelEventState _)
			{
				TimerSystem.Instance.Delay(new TTimerAction(this.OnActionDone), 2000f, null, null, true, 1f);
			});
		}

		// Token: 0x060441D3 RID: 278995 RVA: 0x010C3740 File Offset: 0x010C1940
		private void OnActionDone(float _)
		{
			if (!ObjectUtils.IsValid(this.CameraManager))
			{
				base.FinishExecute(false, false, true);
				return;
			}
			this.CameraManager.StartCameraFade(1f, 0f, this.Param.FadeOutTime, this.Color.Value, false, false, ECameraFadeMode.CFM_Linear);
			TimerSystem.Instance.Delay(new TTimerAction(this.OnInterludeEnded), this.Param.FadeOutTime, null, null, true, 1f);
		}

		// Token: 0x060441D4 RID: 278996 RVA: 0x010C37BC File Offset: 0x010C19BC
		private void OnInterludeEnded(float _)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x060441D5 RID: 278997 RVA: 0x010C37C7 File Offset: 0x010C19C7
		protected override void OnReset()
		{
			this.Param = null;
			this.Context = null;
			this.Color = null;
			this.CameraManager = null;
		}

		// Token: 0x04023938 RID: 145720
		private ActionPlotInterludeAction Param;

		// Token: 0x04023939 RID: 145721
		private GeneralContext Context;

		// Token: 0x0402393A RID: 145722
		private FLinearColor? Color;

		// Token: 0x0402393B RID: 145723
		private APlayerCameraManager CameraManager;
	}
}
