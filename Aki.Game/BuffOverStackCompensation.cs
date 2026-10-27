using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F50 RID: 12112
[NullableContext(1)]
[Nullable(0)]
public class BuffOverStackCompensation : BuffEffect
{
	// Token: 0x06019C77 RID: 105591 RVA: 0x006B8CDD File Offset: 0x006B6EDD
	public BuffOverStackCompensation(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019C78 RID: 105592 RVA: 0x006B8CEC File Offset: 0x006B6EEC
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}
}
