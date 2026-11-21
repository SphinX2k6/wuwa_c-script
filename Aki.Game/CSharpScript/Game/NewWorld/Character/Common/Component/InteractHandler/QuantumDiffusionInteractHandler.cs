using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.InteractHandler
{
	// Token: 0x02006343 RID: 25411
	public class QuantumDiffusionInteractHandler : ManipulateInteractHandlerBase
	{
		// Token: 0x0603D905 RID: 252165 RVA: 0x011D3330 File Offset: 0x011D1530
		[NullableContext(1)]
		public QuantumDiffusionInteractHandler(IManipulateInteractContext context) : base(context)
		{
		}

		// Token: 0x0603D906 RID: 252166 RVA: 0x011D333C File Offset: 0x011D153C
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

		// Token: 0x0603D907 RID: 252167 RVA: 0x011D338A File Offset: 0x011D158A
		public override void End()
		{
		}
	}
}
