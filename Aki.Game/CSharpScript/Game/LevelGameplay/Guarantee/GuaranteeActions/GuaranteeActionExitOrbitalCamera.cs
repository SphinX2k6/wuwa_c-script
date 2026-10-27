using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02006E13 RID: 28179
	public class GuaranteeActionExitOrbitalCamera : GuaranteeActionBase
	{
		// Token: 0x06044B6C RID: 281452 RVA: 0x010F5AE7 File Offset: 0x010F3CE7
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
