using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x0200013F RID: 319
[NullableContext(1)]
[Nullable(0)]
internal class InputBehaviorRuntimeState
{
	// Token: 0x17000348 RID: 840
	// (get) Token: 0x060013FA RID: 5114 RVA: 0x00071AFB File Offset: 0x0006FCFB
	public SInputBehavior Config { get; }

	// Token: 0x17000349 RID: 841
	// (get) Token: 0x060013FB RID: 5115 RVA: 0x00071B03 File Offset: 0x0006FD03
	public InputBehaviorConditionContext ConditionContext { get; }

	// Token: 0x060013FC RID: 5116 RVA: 0x00071B0B File Offset: 0x0006FD0B
	public InputBehaviorRuntimeState(SInputBehavior config, InputBehaviorConditionContext conditionContext)
	{
		this.Config = config;
		this.ConditionContext = conditionContext;
	}

	// Token: 0x04000E63 RID: 3683
	public bool ConditionSatisfied;

	// Token: 0x04000E64 RID: 3684
	public bool DispatchAttempted;
}
