using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006084 RID: 24708
	public class ITimedStrikeDeviceT
	{
		// Token: 0x1700B796 RID: 46998
		// (get) Token: 0x06029C55 RID: 171093 RVA: 0x005B3F58 File Offset: 0x005B2158
		// (set) Token: 0x06029C56 RID: 171094 RVA: 0x005B3F60 File Offset: 0x005B2160
		public EProgressBarControlType Type { get; set; }

		// Token: 0x1700B797 RID: 46999
		// (get) Token: 0x06029C57 RID: 171095 RVA: 0x005B3F69 File Offset: 0x005B2169
		// (set) Token: 0x06029C58 RID: 171096 RVA: 0x005B3F71 File Offset: 0x005B2171
		public int MaxValue { get; set; }

		// Token: 0x1700B798 RID: 47000
		// (get) Token: 0x06029C59 RID: 171097 RVA: 0x005B3F7A File Offset: 0x005B217A
		// (set) Token: 0x06029C5A RID: 171098 RVA: 0x005B3F82 File Offset: 0x005B2182
		public int InitValue { get; set; }

		// Token: 0x1700B799 RID: 47001
		// (get) Token: 0x06029C5B RID: 171099 RVA: 0x005B3F8B File Offset: 0x005B218B
		// (set) Token: 0x06029C5C RID: 171100 RVA: 0x005B3F93 File Offset: 0x005B2193
		public int ProgressPerformanceAttribute { get; set; }

		// Token: 0x1700B79A RID: 47002
		// (get) Token: 0x06029C5D RID: 171101 RVA: 0x005B3F9C File Offset: 0x005B219C
		// (set) Token: 0x06029C5E RID: 171102 RVA: 0x005B3FA4 File Offset: 0x005B21A4
		public int AddValue { get; set; }

		// Token: 0x1700B79B RID: 47003
		// (get) Token: 0x06029C5F RID: 171103 RVA: 0x005B3FAD File Offset: 0x005B21AD
		// (set) Token: 0x06029C60 RID: 171104 RVA: 0x005B3FB5 File Offset: 0x005B21B5
		public int Timeout { get; set; }

		// Token: 0x1700B79C RID: 47004
		// (get) Token: 0x06029C61 RID: 171105 RVA: 0x005B3FBE File Offset: 0x005B21BE
		// (set) Token: 0x06029C62 RID: 171106 RVA: 0x005B3FC6 File Offset: 0x005B21C6
		public int FallbackValue { get; set; }

		// Token: 0x1700B79D RID: 47005
		// (get) Token: 0x06029C63 RID: 171107 RVA: 0x005B3FCF File Offset: 0x005B21CF
		// (set) Token: 0x06029C64 RID: 171108 RVA: 0x005B3FD7 File Offset: 0x005B21D7
		public int FallbackInterval { get; set; }

		// Token: 0x1700B79E RID: 47006
		// (get) Token: 0x06029C65 RID: 171109 RVA: 0x005B3FE0 File Offset: 0x005B21E0
		// (set) Token: 0x06029C66 RID: 171110 RVA: 0x005B3FE8 File Offset: 0x005B21E8
		public int ZeroValuePerformanceAttribute { get; set; }

		// Token: 0x1700B79F RID: 47007
		// (get) Token: 0x06029C67 RID: 171111 RVA: 0x005B3FF1 File Offset: 0x005B21F1
		// (set) Token: 0x06029C68 RID: 171112 RVA: 0x005B3FF9 File Offset: 0x005B21F9
		public int AscendPerformanceAttribute { get; set; }

		// Token: 0x1700B7A0 RID: 47008
		// (get) Token: 0x06029C69 RID: 171113 RVA: 0x005B4002 File Offset: 0x005B2202
		// (set) Token: 0x06029C6A RID: 171114 RVA: 0x005B400A File Offset: 0x005B220A
		public int DescendPerformanceAttribute { get; set; }

		// Token: 0x1700B7A1 RID: 47009
		// (get) Token: 0x06029C6B RID: 171115 RVA: 0x005B4013 File Offset: 0x005B2213
		// (set) Token: 0x06029C6C RID: 171116 RVA: 0x005B401B File Offset: 0x005B221B
		public byte NullMask { get; set; }

		// Token: 0x06029C6D RID: 171117 RVA: 0x005B4024 File Offset: 0x005B2224
		public ITimedStrikeDeviceT()
		{
			this.Type = EProgressBarControlType.CaptureStrategicPoint;
			this.MaxValue = 0;
			this.InitValue = 0;
			this.ProgressPerformanceAttribute = 0;
			this.AddValue = 0;
			this.Timeout = 0;
			this.FallbackValue = 0;
			this.FallbackInterval = 0;
			this.ZeroValuePerformanceAttribute = 0;
			this.AscendPerformanceAttribute = 0;
			this.DescendPerformanceAttribute = 0;
			this.NullMask = 0;
		}
	}
}
