using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020023E0 RID: 9184
[NullableContext(1)]
public interface IBuffModifierData
{
	// Token: 0x170023AC RID: 9132
	// (get) Token: 0x06017086 RID: 94342
	EAttributeType AttributeId { get; }

	// Token: 0x170023AD RID: 9133
	// (get) Token: 0x06017087 RID: 94343
	float[] Value1 { get; }

	// Token: 0x170023AE RID: 9134
	// (get) Token: 0x06017088 RID: 94344
	float[] Value2 { get; }

	// Token: 0x170023AF RID: 9135
	// (get) Token: 0x06017089 RID: 94345
	int[] CalculationPolicy { get; }
}
