using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x0200407B RID: 16507
	public class FlowActionCameraLookAt : FlowActionLevelAsyncAction
	{
		// Token: 0x06029DA5 RID: 171429 RVA: 0x00BD5A8D File Offset: 0x00BD3C8D
		protected override void OnBackgroundExecute()
		{
			base.FinishExecute(true, true);
		}

		// Token: 0x06029DA6 RID: 171430 RVA: 0x00BD5A98 File Offset: 0x00BD3C98
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
