using System;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02004E68 RID: 20072
	public interface IAudioCoolDownInfo
	{
		// Token: 0x17006258 RID: 25176
		// (get) Token: 0x06032873 RID: 206963
		// (set) Token: 0x06032874 RID: 206964
		int DefaultCooldownTime { get; set; }

		// Token: 0x17006259 RID: 25177
		// (get) Token: 0x06032875 RID: 206965
		// (set) Token: 0x06032876 RID: 206966
		double DefaultProbability { get; set; }
	}
}
