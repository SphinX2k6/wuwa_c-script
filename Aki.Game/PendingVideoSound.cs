using System;
using Aki.Config;

// Token: 0x0200224A RID: 8778
public class PendingVideoSound
{
	// Token: 0x06015AE9 RID: 88809 RVA: 0x0064894B File Offset: 0x00646B4B
	public PendingVideoSound(VideoSound soundConf, double startMomentMs)
	{
		this.SoundConf = soundConf;
		this.StartMomentMs = startMomentMs;
	}

	// Token: 0x0400B6FE RID: 46846
	public VideoSound SoundConf;

	// Token: 0x0400B6FF RID: 46847
	public double StartMomentMs;
}
