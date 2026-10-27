using System;

// Token: 0x02002CEF RID: 11503
public class VideoSoundPlay
{
	// Token: 0x06018259 RID: 98905 RVA: 0x00622C58 File Offset: 0x00620E58
	public VideoSoundPlay(int handle, double endMomentMs)
	{
		this.Handle = handle;
		this.EndMomentMs = endMomentMs;
	}

	// Token: 0x0400B388 RID: 45960
	public int Handle;

	// Token: 0x0400B389 RID: 45961
	public double EndMomentMs;
}
