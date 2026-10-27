using System;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02005E85 RID: 24197
	public class AudioCoolDownInfo : IAudioCoolDownInfo
	{
		// Token: 0x17008E89 RID: 36489
		// (get) Token: 0x0603D8E9 RID: 252137 RVA: 0x00EDB1BA File Offset: 0x00ED93BA
		// (set) Token: 0x0603D8EA RID: 252138 RVA: 0x00EDB1C2 File Offset: 0x00ED93C2
		public int DefaultCooldownTime { get; set; }

		// Token: 0x17008E8A RID: 36490
		// (get) Token: 0x0603D8EB RID: 252139 RVA: 0x00EDB1CB File Offset: 0x00ED93CB
		// (set) Token: 0x0603D8EC RID: 252140 RVA: 0x00EDB1D3 File Offset: 0x00ED93D3
		public double DefaultProbability { get; set; }
	}
}
