using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B5B RID: 31579
	public class ITelePortAfterTimeOutT
	{
		// Token: 0x1700EC71 RID: 60529
		// (get) Token: 0x06038DDF RID: 232927 RVA: 0x007B0254 File Offset: 0x007AE454
		// (set) Token: 0x06038DE0 RID: 232928 RVA: 0x007B025C File Offset: 0x007AE45C
		public ETeammateTeleportType Type { get; set; }

		// Token: 0x1700EC72 RID: 60530
		// (get) Token: 0x06038DE1 RID: 232929 RVA: 0x007B0265 File Offset: 0x007AE465
		// (set) Token: 0x06038DE2 RID: 232930 RVA: 0x007B026D File Offset: 0x007AE46D
		public int TimeOut { get; set; }

		// Token: 0x06038DE3 RID: 232931 RVA: 0x007B0276 File Offset: 0x007AE476
		public ITelePortAfterTimeOutT()
		{
			this.Type = ETeammateTeleportType.TelePortAfterTimeOut;
			this.TimeOut = 0;
		}
	}
}
