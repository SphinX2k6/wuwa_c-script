using System;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02004E6A RID: 20074
	public class AudioCoolDownInfo : IAudioCoolDownInfo
	{
		// Token: 0x1700625B RID: 25179
		// (get) Token: 0x06032879 RID: 206969 RVA: 0x00E2C746 File Offset: 0x00E2A946
		// (set) Token: 0x0603287A RID: 206970 RVA: 0x00E2C74E File Offset: 0x00E2A94E
		public int DefaultCooldownTime { get; set; }

		// Token: 0x1700625C RID: 25180
		// (get) Token: 0x0603287B RID: 206971 RVA: 0x00E2C757 File Offset: 0x00E2A957
		// (set) Token: 0x0603287C RID: 206972 RVA: 0x00E2C75F File Offset: 0x00E2A95F
		public double DefaultProbability { get; set; }
	}
}
