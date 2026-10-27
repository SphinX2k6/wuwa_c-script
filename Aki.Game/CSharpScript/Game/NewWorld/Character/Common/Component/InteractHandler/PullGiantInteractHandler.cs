using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.InteractHandler
{
	// Token: 0x02007114 RID: 28948
	public class PullGiantInteractHandler : ManipulateInteractHandlerBase
	{
		// Token: 0x06046ABC RID: 289468 RVA: 0x011CA3E6 File Offset: 0x011C85E6
		[NullableContext(1)]
		public PullGiantInteractHandler(IManipulateInteractContext context) : base(context)
		{
		}

		// Token: 0x06046ABD RID: 289469 RVA: 0x011CA3F0 File Offset: 0x011C85F0
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

		// Token: 0x06046ABE RID: 289470 RVA: 0x011CA480 File Offset: 0x011C8680
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

		// Token: 0x04025189 RID: 151945
		private const int BUFF_REMOVE_DELAY_MS = 200;
	}
}
