using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B63 RID: 27491
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventRestoreCameraLookAtPosition : LevelEventBase
	{
		// Token: 0x060441F6 RID: 279030 RVA: 0x010C4F06 File Offset: 0x010C3106
		public LevelEventRestoreCameraLookAtPosition(int id) : base(id)
		{
		}

		// Token: 0x060441F7 RID: 279031 RVA: 0x010C4F18 File Offset: 0x010C3118
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

		// Token: 0x060441F8 RID: 279032 RVA: 0x010C4F77 File Offset: 0x010C3177
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x04023940 RID: 145728
		private readonly bool EnableDebugLog = true;
	}
}
