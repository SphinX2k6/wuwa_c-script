using System;

// Token: 0x02000004 RID: 4
public class PackageSpaceModel
{
	// Token: 0x06000004 RID: 4 RVA: 0x00002057 File Offset: 0x00000257
	public void Reset()
	{
		this.DownloadSize = 0L;
		this.SavedSize = 0L;
		this.PatchPeak = 0L;
		this.PatchNetDelta = 0L;
		this.CopySize = 0L;
	}

	// Token: 0x04000002 RID: 2
	public long DownloadSize;

	// Token: 0x04000003 RID: 3
	public long SavedSize;

	// Token: 0x04000004 RID: 4
	public long PatchPeak;

	// Token: 0x04000005 RID: 5
	public long PatchNetDelta;

	// Token: 0x04000006 RID: 6
	public long CopySize;
}
