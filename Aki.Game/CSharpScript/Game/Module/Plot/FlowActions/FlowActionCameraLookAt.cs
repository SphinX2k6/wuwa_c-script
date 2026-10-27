using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050AB RID: 20651
	public class FlowActionCameraLookAt : FlowActionLevelAsyncAction
	{
		// Token: 0x06034EAC RID: 216748 RVA: 0x00C887D0 File Offset: 0x00C869D0
		protected override void OnBackgroundExecute()
		{
			base.FinishExecute(true, true);
		}

		// Token: 0x06034EAD RID: 216749 RVA: 0x00C887DC File Offset: 0x00C869DC
		protected override void OnInterruptExecute()
		{
			global::Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "[CameraLookAt] FlowActionCameraLookAt", default(ReadOnlySpan<ValueTuple<string, object>>));
			CharacterInputComponent component = SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<CharacterInputComponent>();
			CameraLookAt cameraLookAt = this.ActionInfo.Params as CameraLookAt;
			CameraController.Instance.MainModel.FightCamera.LogicComponent.ExitCameraGuide();
			if (cameraLookAt != null && cameraLookAt.BanInput.GetValueOrDefault())
			{
				InputController.Instance.AddInputHandler(component);
				CameraController.Instance.SetInputEnable(Global.BaseCharacter, true, "MainCamera");
			}
			base.OnInterruptExecute();
		}
	}
}
