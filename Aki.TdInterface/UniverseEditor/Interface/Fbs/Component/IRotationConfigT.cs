using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E99 RID: 24217
	public class IRotationConfigT
	{
		// Token: 0x1700B2B9 RID: 45753
		// (get) Token: 0x06028890 RID: 166032 RVA: 0x0058AAE5 File Offset: 0x00588CE5
		// (set) Token: 0x06028891 RID: 166033 RVA: 0x0058AAED File Offset: 0x00588CED
		public ERotationType Type { get; set; }

		// Token: 0x1700B2BA RID: 45754
		// (get) Token: 0x06028892 RID: 166034 RVA: 0x0058AAF6 File Offset: 0x00588CF6
		// (set) Token: 0x06028893 RID: 166035 RVA: 0x0058AAFE File Offset: 0x00588CFE
		public float Time { get; set; }

		// Token: 0x1700B2BB RID: 45755
		// (get) Token: 0x06028894 RID: 166036 RVA: 0x0058AB07 File Offset: 0x00588D07
		// (set) Token: 0x06028895 RID: 166037 RVA: 0x0058AB0F File Offset: 0x00588D0F
		public float Cd { get; set; }

		// Token: 0x1700B2BC RID: 45756
		// (get) Token: 0x06028896 RID: 166038 RVA: 0x0058AB18 File Offset: 0x00588D18
		// (set) Token: 0x06028897 RID: 166039 RVA: 0x0058AB20 File Offset: 0x00588D20
		public string Curve { get; set; }

		// Token: 0x1700B2BD RID: 45757
		// (get) Token: 0x06028898 RID: 166040 RVA: 0x0058AB29 File Offset: 0x00588D29
		// (set) Token: 0x06028899 RID: 166041 RVA: 0x0058AB31 File Offset: 0x00588D31
		public IVectorInfoT Axis { get; set; }

		// Token: 0x1700B2BE RID: 45758
		// (get) Token: 0x0602889A RID: 166042 RVA: 0x0058AB3A File Offset: 0x00588D3A
		// (set) Token: 0x0602889B RID: 166043 RVA: 0x0058AB42 File Offset: 0x00588D42
		public float Angle { get; set; }

		// Token: 0x1700B2BF RID: 45759
		// (get) Token: 0x0602889C RID: 166044 RVA: 0x0058AB4B File Offset: 0x00588D4B
		// (set) Token: 0x0602889D RID: 166045 RVA: 0x0058AB53 File Offset: 0x00588D53
		public byte NullMask { get; set; }

		// Token: 0x0602889E RID: 166046 RVA: 0x0058AB5C File Offset: 0x00588D5C
		public IRotationConfigT()
		{
			this.Type = ERotationType.Relative;
			this.Time = 0f;
			this.Cd = 0f;
			this.Curve = null;
			this.Axis = null;
			this.Angle = 0f;
			this.NullMask = 0;
		}
	}
}
