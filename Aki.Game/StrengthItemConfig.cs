using System;
using System.Runtime.CompilerServices;

// Token: 0x020013DF RID: 5087
[NullableContext(1)]
[Nullable(0)]
public class StrengthItemConfig
{
	// Token: 0x0600C98B RID: 51595 RVA: 0x003BEE28 File Offset: 0x003BD028
	public StrengthItemConfig(int group, int priority, Type itemClass, bool destroyWhenLowPriority)
	{
		this.Group = group;
		this.Priority = priority;
		this.ItemClass = itemClass;
		this.DestroyWhenLowPriority = destroyWhenLowPriority;
	}

	// Token: 0x04007252 RID: 29266
	public int Group;

	// Token: 0x04007253 RID: 29267
	public int Priority;

	// Token: 0x04007254 RID: 29268
	public Type ItemClass;

	// Token: 0x04007255 RID: 29269
	public bool DestroyWhenLowPriority;
}
