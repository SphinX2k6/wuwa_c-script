using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001B23 RID: 6947
public class FloroRanchEntityCreateData
{
	// Token: 0x0600CE3B RID: 52795 RVA: 0x002EF6DC File Offset: 0x002ED8DC
	public FloroRanchEntityCreateData(EFloroRanchEntityType entityType, [TupleElementNames(new string[]
	{
		"ComponentType",
		"Ctor"
	})] [Nullable(new byte[]
	{
		1,
		0,
		1,
		1,
		1
	})] List<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>> components)
	{
		this.EntityType = entityType;
		this.Components = components;
	}

	// Token: 0x04005E71 RID: 24177
	public EFloroRanchEntityType EntityType;

	// Token: 0x04005E72 RID: 24178
	[TupleElementNames(new string[]
	{
		"ComponentType",
		"Ctor"
	})]
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1,
		1
	})]
	public List<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>> Components;
}
