using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000FE2 RID: 4066
public class FloroRanchEntityCreateData
{
	// Token: 0x0600A24C RID: 41548 RVA: 0x002FA7BC File Offset: 0x002F89BC
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

	// Token: 0x04005F40 RID: 24384
	public EFloroRanchEntityType EntityType;

	// Token: 0x04005F41 RID: 24385
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
