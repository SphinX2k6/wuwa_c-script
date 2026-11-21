using System;

// Token: 0x02002249 RID: 8777
public class VideoSoundPlay
{
	// Token: 0x06015AE8 RID: 88808 RVA: 0x00648935 File Offset: 0x00646B35
	public VideoSoundPlay(int handle, double endMomentMs)
	{
		this.Handle = handle;
		this.EndMomentMs = endMomentMs;
	}

	// Token: 0x0400B6FC RID: 46844
	public int Handle;

	// Token: 0x0400B6FD RID: 46845
	public double EndMomentMs;
}
