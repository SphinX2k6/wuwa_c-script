using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DB4 RID: 3508
[NullableContext(1)]
[Nullable(0)]
public class SequenceData
{
	// Token: 0x06008F61 RID: 36705 RVA: 0x002B25C0 File Offset: 0x002B07C0
	public SequenceData(string sequenceName, bool isBlock, string tag, [Nullable(2)] CustomPromise<bool> stopPromise = null)
	{
		this.SequenceName = sequenceName;
		this.IsBlock = isBlock;
		this.Tag = tag;
		this.StopPromise = stopPromise;
	}

	// Token: 0x040055BC RID: 21948
	public readonly string SequenceName = "";

	// Token: 0x040055BD RID: 21949
	public readonly bool IsBlock;

	// Token: 0x040055BE RID: 21950
	public readonly string Tag = "";

	// Token: 0x040055BF RID: 21951
	public bool NeedFinishEvent = true;

	// Token: 0x040055C0 RID: 21952
	[Nullable(2)]
	public CustomPromise<bool> StopPromise;
}
