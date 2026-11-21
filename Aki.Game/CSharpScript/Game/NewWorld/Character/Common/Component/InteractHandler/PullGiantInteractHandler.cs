using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.InteractHandler
{
	// Token: 0x02006342 RID: 25410
	public class PullGiantInteractHandler : ManipulateInteractHandlerBase
	{
		// Token: 0x0603D901 RID: 252161 RVA: 0x011D31EA File Offset: 0x011D13EA
		[NullableContext(1)]
		public PullGiantInteractHandler(IManipulateInteractContext context) : base(context)
		{
		}

		// Token: 0x0603D902 RID: 252162 RVA: 0x011D31F4 File Offset: 0x011D13F4
		public override bool Start()
		{
			if (!this.Context.CheckBeforeInteract(EExploreSkillInteractType.PullGiant))
			{
				return false;
			}
			this.Context.SelectedTargetInternal = (this.Context.ChooseTargetOnStartSkill ?? this.Context.BestTargetInternal);
			this.Context.Interacting = true;
			this.Context.TagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.拉取巨物"]));
			SceneItemExploreInteractComponent selectedTargetInternal = this.Context.SelectedTargetInternal;
			if (selectedTargetInternal != null)
			{
				selectedTargetInternal.TryChangeManipulateInteractPointState(SceneItemExploreInteractComponent.EManipulateInteractPointState.Interacting);
			}
			base.ApplyInteractBuff();
			return true;
		}

		// Token: 0x0603D903 RID: 252163 RVA: 0x011D3284 File Offset: 0x011D1484
		public override void End()
		{
			this.Context.Interacting = false;
			this.Context.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.拉取巨物"]));
			this.Context.SpawnEffect();
			if (this.Context.CurBuffId != null)
			{
				TimerSystem.Instance.Delay(delegate(float _)
				{
					base.RemoveInteractBuffImmediate();
				}, 200f, null, null, true, 1f);
			}
			SceneItemExploreInteractComponent selectedTargetInternal = this.Context.SelectedTargetInternal;
			if (selectedTargetInternal != null)
			{
				selectedTargetInternal.TryChangeManipulateInteractPointState(SceneItemExploreInteractComponent.EManipulateInteractPointState.Normal);
			}
			this.Context.RequestInteractAction();
		}

		// Token: 0x04020A69 RID: 133737
		private const int BUFF_REMOVE_DELAY_MS = 200;
	}
}
