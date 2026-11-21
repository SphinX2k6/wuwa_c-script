using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x020026AF RID: 9903
[NullableContext(1)]
[Nullable(0)]
public class InputBehaviorConditionContext
{
	// Token: 0x1700276F RID: 10095
	// (get) Token: 0x06018D2E RID: 101678 RVA: 0x007898B7 File Offset: 0x00787AB7
	public bool[] Results { get; }

	// Token: 0x17002770 RID: 10096
	// (get) Token: 0x06018D2F RID: 101679 RVA: 0x007898BF File Offset: 0x00787ABF
	public int[] HoldTriggeredPressIds { get; }

	// Token: 0x17002771 RID: 10097
	// (get) Token: 0x06018D30 RID: 101680 RVA: 0x007898C7 File Offset: 0x00787AC7
	public List<IPendingHoldConsumption> PendingHoldConsumptions { get; } = new List<IPendingHoldConsumption>();

	// Token: 0x17002772 RID: 10098
	// (get) Token: 0x06018D31 RID: 101681 RVA: 0x007898CF File Offset: 0x00787ACF
	public SInputBehavior Behavior { get; }

	// Token: 0x17002773 RID: 10099
	// (get) Token: 0x06018D32 RID: 101682 RVA: 0x007898D7 File Offset: 0x00787AD7
	[Nullable(2)]
	public ConditionArray FormulaSolver { [NullableContext(2)] get; }

	// Token: 0x06018D33 RID: 101683 RVA: 0x007898DF File Offset: 0x00787ADF
	public InputBehaviorConditionContext(SInputBehavior behavior, bool[] results, [Nullable(2)] ConditionArray formulaSolver)
	{
		this.Behavior = behavior;
		this.Results = results;
		this.FormulaSolver = formulaSolver;
		this.HoldTriggeredPressIds = new int[this.Results.Length];
	}
}
