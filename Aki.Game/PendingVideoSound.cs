using System;
using Aki.Config;

// Token: 0x02002CF0 RID: 11504
public class PendingVideoSound
{
	// Token: 0x0601825A RID: 98906 RVA: 0x00622C6E File Offset: 0x00620E6E
	public PendingVideoSound(VideoSound soundConf, double startMomentMs)
	{
		this.SoundConf = soundConf;
		this.StartMomentMs = startMomentMs;
	}

	// Token: 0x0400B38A RID: 45962
	public VideoSound SoundConf;

	// Token: 0x0400B38B RID: 45963
	public double StartMomentMs;
}
