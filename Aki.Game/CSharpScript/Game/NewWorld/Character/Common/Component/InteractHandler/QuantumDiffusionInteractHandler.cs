using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.InteractHandler
{
	// Token: 0x02007115 RID: 28949
	public class QuantumDiffusionInteractHandler : ManipulateInteractHandlerBase
	{
		// Token: 0x06046AC0 RID: 289472 RVA: 0x011CA52C File Offset: 0x011C872C
		[NullableContext(1)]
		public QuantumDiffusionInteractHandler(IManipulateInteractContext context) : base(context)
		{
		}

		// Token: 0x06046AC1 RID: 289473 RVA: 0x011CA538 File Offset: 0x011C8738
		public override bool Start()
		{
			if (!this.Context.CheckBeforeInteract(EExploreSkillInteractType.QuantumDiffusion))
			{
				return false;
			}
			this.Context.SelectedTargetInternal = (this.Context.ChooseTargetOnStartSkill ?? this.Context.BestTargetInternal);
			this.Context.RequestInteractAction();
			return true;
		}

		// Token: 0x06046AC2 RID: 289474 RVA: 0x011CA586 File Offset: 0x011C8786
		public override void End()
		{
		}
	}
}
