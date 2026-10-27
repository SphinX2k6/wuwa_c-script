using System;
using System.Runtime.CompilerServices;

// Token: 0x020018FB RID: 6395
[NullableContext(1)]
[Nullable(0)]
public class SequenceData
{
	// Token: 0x0600BB77 RID: 47991 RVA: 0x002A7E64 File Offset: 0x002A6064
	public SequenceData(string sequenceName, bool isBlock, string tag, [Nullable(2)] CustomPromise<bool> stopPromise = null)
	{
		this.SequenceName = sequenceName;
		this.IsBlock = isBlock;
		this.Tag = tag;
		this.StopPromise = stopPromise;
	}

	// Token: 0x04005511 RID: 21777
	public readonly string SequenceName = "";

	// Token: 0x04005512 RID: 21778
	public readonly bool IsBlock;

	// Token: 0x04005513 RID: 21779
	public readonly string Tag = "";

	// Token: 0x04005514 RID: 21780
	public bool NeedFinishEvent = true;

	// Token: 0x04005515 RID: 21781
	[Nullable(2)]
	public CustomPromise<bool> StopPromise;
}
