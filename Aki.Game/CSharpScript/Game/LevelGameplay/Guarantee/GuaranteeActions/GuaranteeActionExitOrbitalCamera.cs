using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02005F93 RID: 24467
	public class GuaranteeActionExitOrbitalCamera : GuaranteeActionBase
	{
		// Token: 0x0603ACD3 RID: 240851 RVA: 0x0109FF1B File Offset: 0x0109E11B
		[NullableContext(2)]
		protected override void OnExecute(ActionParams @params)
		{
			if (PlotModel.Instance.PlotProgressSequence.IsPlaying)
			{
				PlotModel.Instance.PlotProgressSequence.Stop();
				return;
			}
			CameraController.Instance.MainModel.OrbitalCamera.PlayerComponent.StopCameraOrbital();
		}
	}
}
