using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.InteractHandler
{
	// Token: 0x02006341 RID: 25409
	public class MechascoutDragInteractHandler : ManipulateInteractHandlerBase
	{
		// Token: 0x0603D8FE RID: 252158 RVA: 0x011D314B File Offset: 0x011D134B
		[NullableContext(1)]
		public MechascoutDragInteractHandler(IManipulateInteractContext context) : base(context)
		{
		}

		// Token: 0x0603D8FF RID: 252159 RVA: 0x011D3154 File Offset: 0x011D1354
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

		// Token: 0x0603D900 RID: 252160 RVA: 0x011D31BA File Offset: 0x011D13BA
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
