using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CD0 RID: 23760
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelEventPlotInterludeAction : LevelEventBase
	{
		// Token: 0x0603A322 RID: 238370 RVA: 0x0106D1E9 File Offset: 0x0106B3E9
		public LevelEventPlotInterludeAction(int id) : base(id)
		{
		}

		// Token: 0x0603A323 RID: 238371 RVA: 0x0106D1F4 File Offset: 0x0106B3F4
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

		// Token: 0x0603A324 RID: 238372 RVA: 0x0106D2C5 File Offset: 0x0106B4C5
		private void OnFadeInEnded(float _)
		{
			LevelGeneralController.Instance.ExecuteActionsNew(this.Param.ActionList, GeneralContext.Copy(this.Context), delegate(ELevelEventState _)
			{
				TimerSystem.Instance.Delay(new TTimerAction(this.OnActionDone), 2000f, null, null, true, 1f);
			});
		}

		// Token: 0x0603A325 RID: 238373 RVA: 0x0106D2F4 File Offset: 0x0106B4F4
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

		// Token: 0x0603A326 RID: 238374 RVA: 0x0106D370 File Offset: 0x0106B570
		private void OnInterludeEnded(float _)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A327 RID: 238375 RVA: 0x0106D37B File Offset: 0x0106B57B
		protected override void OnReset()
		{
			this.Param = null;
			this.Context = null;
			this.Color = null;
			this.CameraManager = null;
		}

		// Token: 0x0401EBDA RID: 125914
		private ActionPlotInterludeAction Param;

		// Token: 0x0401EBDB RID: 125915
		private GeneralContext Context;

		// Token: 0x0401EBDC RID: 125916
		private FLinearColor? Color;

		// Token: 0x0401EBDD RID: 125917
		private APlayerCameraManager CameraManager;
	}
}
