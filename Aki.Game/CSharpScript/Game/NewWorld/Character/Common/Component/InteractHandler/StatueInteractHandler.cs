using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.InteractHandler
{
	// Token: 0x02007117 RID: 28951
	public class StatueInteractHandler : ManipulateInteractHandlerBase
	{
		// Token: 0x06046ADC RID: 289500 RVA: 0x011CB29D File Offset: 0x011C949D
		[NullableContext(1)]
		public StatueInteractHandler(IManipulateInteractContext context) : base(context)
		{
		}

		// Token: 0x06046ADD RID: 289501 RVA: 0x011CB2A8 File Offset: 0x011C94A8
		public override bool Start()
		{
			this.Context.SelectedTargetInternal = (this.Context.ChooseTargetOnStartSkill ?? this.Context.BestTargetInternal);
			if (!this.Context.CheckBeforeInteract(EExploreSkillInteractType.StatueInteractPoint))
			{
				return false;
			}
			this.Context.Interacting = true;
			SceneItemExploreInteractComponent selectedTargetInternal = this.Context.SelectedTargetInternal;
			if (selectedTargetInternal != null)
			{
				selectedTargetInternal.TryChangeManipulateInteractPointState(SceneItemExploreInteractComponent.EManipulateInteractPointState.Interacting);
			}
			base.ApplyInteractBuff();
			return true;
		}

		// Token: 0x06046ADE RID: 289502 RVA: 0x011CB314 File Offset: 0x011C9514
		public override void End()
		{
			SceneItemExploreInteractComponent curTarget = this.Context.SelectedTargetInternal;
			TimerSystem.Instance.Delay(delegate(float _)
			{
				this.Context.Interacting = false;
				SceneItemExploreInteractComponent curTarget3 = curTarget;
				if (curTarget3 != null)
				{
					curTarget3.EndInteractPullStatue();
				}
				this.RemoveInteractBuffImmediate();
			}, 200f, null, null, true, 1f);
			SceneItemExploreInteractComponent curTarget4 = curTarget;
			if (curTarget4 != null)
			{
				curTarget4.TryChangeManipulateInteractPointState(SceneItemExploreInteractComponent.EManipulateInteractPointState.Normal);
			}
			SceneItemExploreInteractComponent curTarget2 = curTarget;
			if (curTarget2 != null)
			{
				curTarget2.MoveToOutlet();
			}
			this.Context.SelectedTargetInternal = null;
		}
	}
}
