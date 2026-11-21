using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CDB RID: 23771
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventRestoreCameraLookAtPosition : LevelEventBase
	{
		// Token: 0x0603A348 RID: 238408 RVA: 0x0106EAD6 File Offset: 0x0106CCD6
		public LevelEventRestoreCameraLookAtPosition(int id) : base(id)
		{
		}

		// Token: 0x0603A349 RID: 238409 RVA: 0x0106EAE8 File Offset: 0x0106CCE8
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (this.EnableDebugLog)
			{
				global::Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "[CameraLookAt] LevelEventRestoreCameraLookAtPosition Start", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			if (fightCamera != null)
			{
				FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
				if (logicComponent != null)
				{
					logicComponent.ExitCameraGuide();
				}
			}
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A34A RID: 238410 RVA: 0x0106EB47 File Offset: 0x0106CD47
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0401EBE2 RID: 125922
		private readonly bool EnableDebugLog = true;
	}
}
