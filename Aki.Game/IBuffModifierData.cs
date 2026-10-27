using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002E8E RID: 11918
[NullableContext(1)]
public interface IBuffModifierData
{
	// Token: 0x17002321 RID: 8993
	// (get) Token: 0x060197B0 RID: 104368
	EAttributeType AttributeId { get; }

	// Token: 0x17002322 RID: 8994
	// (get) Token: 0x060197B1 RID: 104369
	float[] Value1 { get; }

	// Token: 0x17002323 RID: 8995
	// (get) Token: 0x060197B2 RID: 104370
	float[] Value2 { get; }

	// Token: 0x17002324 RID: 8996
	// (get) Token: 0x060197B3 RID: 104371
	int[] CalculationPolicy { get; }
}
