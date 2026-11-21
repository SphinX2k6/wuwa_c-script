using System;
using System.Runtime.CompilerServices;

// Token: 0x020006E4 RID: 1764
[NullableContext(1)]
public interface IDangoMonopolyRoundBuffData
{
	// Token: 0x17000AC0 RID: 2752
	// (get) Token: 0x06005176 RID: 20854
	int DangoId { get; }

	// Token: 0x17000AC1 RID: 2753
	// (get) Token: 0x06005177 RID: 20855
	int PropertyId { get; }

	// Token: 0x17000AC2 RID: 2754
	// (get) Token: 0x06005178 RID: 20856
	int GridId { get; }

	// Token: 0x17000AC3 RID: 2755
	// (get) Token: 0x06005179 RID: 20857
	bool IsActive { get; }

	// Token: 0x17000AC4 RID: 2756
	// (get) Token: 0x0600517A RID: 20858
	string DangoIcon { get; }

	// Token: 0x17000AC5 RID: 2757
	// (get) Token: 0x0600517B RID: 20859
	string DangoName { get; }

	// Token: 0x17000AC6 RID: 2758
	// (get) Token: 0x0600517C RID: 20860
	string PropertyDesc { get; }

	// Token: 0x17000AC7 RID: 2759
	// (get) Token: 0x0600517D RID: 20861
	string PropertyTitle { get; }
}
