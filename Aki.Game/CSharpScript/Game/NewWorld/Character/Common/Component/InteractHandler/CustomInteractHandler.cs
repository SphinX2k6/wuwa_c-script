using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.InteractHandler
{
	// Token: 0x0200710F RID: 28943
	public class CustomInteractHandler : ManipulateInteractHandlerBase
	{
		// Token: 0x06046A9E RID: 289438 RVA: 0x011CA158 File Offset: 0x011C8358
		[NullableContext(1)]
		public CustomInteractHandler(IManipulateInteractContext context) : base(context)
		{
		}

		// Token: 0x06046A9F RID: 289439 RVA: 0x011CA164 File Offset: 0x011C8364
		public override bool Start()
		{
			if (!this.Context.CheckBeforeInteract(EExploreSkillInteractType.Custom))
			{
				return false;
			}
			this.Context.SelectedTargetInternal = (this.Context.ChooseTargetOnStartSkill ?? this.Context.BestTargetInternal);
			this.Context.Interacting = true;
			SceneItemExploreInteractComponent selectedTargetInternal = this.Context.SelectedTargetInternal;
			if (selectedTargetInternal != null)
			{
				selectedTargetInternal.TryChangeManipulateInteractPointState(SceneItemExploreInteractComponent.EManipulateInteractPointState.Interacting);
			}
			return true;
		}

		// Token: 0x06046AA0 RID: 289440 RVA: 0x011CA1CA File Offset: 0x011C83CA
		public override void End()
		{
			this.Context.Interacting = false;
			SceneItemExploreInteractComponent selectedTargetInternal = this.Context.SelectedTargetInternal;
			if (selectedTargetInternal != null)
			{
				selectedTargetInternal.TryChangeManipulateInteractPointState(SceneItemExploreInteractComponent.EManipulateInteractPointState.Normal);
			}
			this.Context.RequestInteractAction();
		}
	}
}
