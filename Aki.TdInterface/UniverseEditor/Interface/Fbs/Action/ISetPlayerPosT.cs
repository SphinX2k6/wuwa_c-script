using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007822 RID: 30754
	public class ISetPlayerPosT
	{
		// Token: 0x1700E17F RID: 57727
		// (get) Token: 0x060360FF RID: 221439 RVA: 0x0073E0EB File Offset: 0x0073C2EB
		// (set) Token: 0x06036100 RID: 221440 RVA: 0x0073E0F3 File Offset: 0x0073C2F3
		public TTeleportConfigUnion TelePortConfig { get; set; }

		// Token: 0x1700E180 RID: 57728
		// (get) Token: 0x06036101 RID: 221441 RVA: 0x0073E0FC File Offset: 0x0073C2FC
		// (set) Token: 0x06036102 RID: 221442 RVA: 0x0073E104 File Offset: 0x0073C304
		public ITelePortAfterTimeOutT TeammateTeleportConfig { get; set; }

		// Token: 0x1700E181 RID: 57729
		// (get) Token: 0x06036103 RID: 221443 RVA: 0x0073E10D File Offset: 0x0073C30D
		// (set) Token: 0x06036104 RID: 221444 RVA: 0x0073E115 File Offset: 0x0073C315
		public TTeleportTransitionOptionUnion TransitionOption { get; set; }

		// Token: 0x1700E182 RID: 57730
		// (get) Token: 0x06036105 RID: 221445 RVA: 0x0073E11E File Offset: 0x0073C31E
		// (set) Token: 0x06036106 RID: 221446 RVA: 0x0073E126 File Offset: 0x0073C326
		public bool DisableAutoFadeInScreen { get; set; }

		// Token: 0x1700E183 RID: 57731
		// (get) Token: 0x06036107 RID: 221447 RVA: 0x0073E12F File Offset: 0x0073C32F
		// (set) Token: 0x06036108 RID: 221448 RVA: 0x0073E137 File Offset: 0x0073C337
		public bool OnlinePreciseTransport { get; set; }

		// Token: 0x1700E184 RID: 57732
		// (get) Token: 0x06036109 RID: 221449 RVA: 0x0073E140 File Offset: 0x0073C340
		// (set) Token: 0x0603610A RID: 221450 RVA: 0x0073E148 File Offset: 0x0073C348
		public bool IsBanMapSound { get; set; }

		// Token: 0x1700E185 RID: 57733
		// (get) Token: 0x0603610B RID: 221451 RVA: 0x0073E151 File Offset: 0x0073C351
		// (set) Token: 0x0603610C RID: 221452 RVA: 0x0073E159 File Offset: 0x0073C359
		public byte NullMask { get; set; }

		// Token: 0x0603610D RID: 221453 RVA: 0x0073E162 File Offset: 0x0073C362
		public ISetPlayerPosT()
		{
			this.TelePortConfig = null;
			this.TeammateTeleportConfig = null;
			this.TransitionOption = null;
			this.DisableAutoFadeInScreen = false;
			this.OnlinePreciseTransport = false;
			this.IsBanMapSound = false;
			this.NullMask = 0;
		}
	}
}
