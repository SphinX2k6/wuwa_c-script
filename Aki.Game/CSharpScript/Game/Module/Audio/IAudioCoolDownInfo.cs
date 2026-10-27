using System;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02005E83 RID: 24195
	public interface IAudioCoolDownInfo
	{
		// Token: 0x17008E86 RID: 36486
		// (get) Token: 0x0603D8E3 RID: 252131
		// (set) Token: 0x0603D8E4 RID: 252132
		int DefaultCooldownTime { get; set; }

		// Token: 0x17008E87 RID: 36487
		// (get) Token: 0x0603D8E5 RID: 252133
		// (set) Token: 0x0603D8E6 RID: 252134
		double DefaultProbability { get; set; }
	}
}
