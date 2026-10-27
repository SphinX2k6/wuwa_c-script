using System;
using System.Runtime.CompilerServices;

// Token: 0x02001F1D RID: 7965
[NullableContext(1)]
[Nullable(0)]
public class StrengthItemConfig
{
	// Token: 0x0600F56C RID: 62828 RVA: 0x003B333C File Offset: 0x003B153C
	public StrengthItemConfig(int group, int priority, Type itemClass, bool destroyWhenLowPriority)
	{
		this.Group = group;
		this.Priority = priority;
		this.ItemClass = itemClass;
		this.DestroyWhenLowPriority = destroyWhenLowPriority;
	}

	// Token: 0x04007171 RID: 29041
	public int Group;

	// Token: 0x04007172 RID: 29042
	public int Priority;

	// Token: 0x04007173 RID: 29043
	public Type ItemClass;

	// Token: 0x04007174 RID: 29044
	public bool DestroyWhenLowPriority;
}
