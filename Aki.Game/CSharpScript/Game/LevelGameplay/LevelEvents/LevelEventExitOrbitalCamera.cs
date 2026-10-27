using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.Guarantee;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B29 RID: 27433
	public class LevelEventExitOrbitalCamera : LevelEventBase
	{
		// Token: 0x06044104 RID: 278788 RVA: 0x010BC30D File Offset: 0x010BA50D
		public LevelEventExitOrbitalCamera(int id) : base(id)
		{
		}

		// Token: 0x06044105 RID: 278789 RVA: 0x010BC318 File Offset: 0x010BA518
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

		// Token: 0x06044106 RID: 278790 RVA: 0x010BC36C File Offset: 0x010BA56C
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
