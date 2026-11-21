using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.Guarantee;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CA1 RID: 23713
	public class LevelEventExitOrbitalCamera : LevelEventBase
	{
		// Token: 0x0603A256 RID: 238166 RVA: 0x01065B99 File Offset: 0x01063D99
		public LevelEventExitOrbitalCamera(int id) : base(id)
		{
		}

		// Token: 0x0603A257 RID: 238167 RVA: 0x01065BA4 File Offset: 0x01063DA4
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			if (PlotModel.Instance.PlotProgressSequence.IsPlaying)
			{
				PlotModel.Instance.PlotProgressSequence.Stop();
				return;
			}
			CameraController.Instance.MainModel.OrbitalCamera.PlayerComponent.StopCameraOrbital();
		}

		// Token: 0x0603A258 RID: 238168 RVA: 0x01065BF8 File Offset: 0x01063DF8
		protected override void OnUpdateGuarantee()
		{
			GuaranteeActionInfo p = new GuaranteeActionInfo
			{
				Name = EGuaranteeAction.ExitOrbitalCamera
			};
			EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.RemGuaranteeAction, this.Type, this.BaseContext, p, null);
		}
	}
}
