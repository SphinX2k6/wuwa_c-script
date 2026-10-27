using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.InteractHandler
{
	// Token: 0x02007113 RID: 28947
	public class MechascoutDragInteractHandler : ManipulateInteractHandlerBase
	{
		// Token: 0x06046AB9 RID: 289465 RVA: 0x011CA347 File Offset: 0x011C8547
		[NullableContext(1)]
		public MechascoutDragInteractHandler(IManipulateInteractContext context) : base(context)
		{
		}

		// Token: 0x06046ABA RID: 289466 RVA: 0x011CA350 File Offset: 0x011C8550
		public override bool Start()
		{
			if (!this.Context.CheckBeforeInteract(EExploreSkillInteractType.MechascoutDrag))
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

		// Token: 0x06046ABB RID: 289467 RVA: 0x011CA3B6 File Offset: 0x011C85B6
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
