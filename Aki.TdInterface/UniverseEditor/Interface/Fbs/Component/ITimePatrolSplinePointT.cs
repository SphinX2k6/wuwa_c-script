using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006099 RID: 24729
	public class ITimePatrolSplinePointT
	{
		// Token: 0x1700B7D2 RID: 47058
		// (get) Token: 0x06029D45 RID: 171333 RVA: 0x005B5FA7 File Offset: 0x005B41A7
		// (set) Token: 0x06029D46 RID: 171334 RVA: 0x005B5FAF File Offset: 0x005B41AF
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700B7D3 RID: 47059
		// (get) Token: 0x06029D47 RID: 171335 RVA: 0x005B5FB8 File Offset: 0x005B41B8
		// (set) Token: 0x06029D48 RID: 171336 RVA: 0x005B5FC0 File Offset: 0x005B41C0
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x1700B7D4 RID: 47060
		// (get) Token: 0x06029D49 RID: 171337 RVA: 0x005B5FC9 File Offset: 0x005B41C9
		// (set) Token: 0x06029D4A RID: 171338 RVA: 0x005B5FD1 File Offset: 0x005B41D1
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x1700B7D5 RID: 47061
		// (get) Token: 0x06029D4B RID: 171339 RVA: 0x005B5FDA File Offset: 0x005B41DA
		// (set) Token: 0x06029D4C RID: 171340 RVA: 0x005B5FE2 File Offset: 0x005B41E2
		public ESplineLine LineType { get; set; }

		// Token: 0x1700B7D6 RID: 47062
		// (get) Token: 0x06029D4D RID: 171341 RVA: 0x005B5FEB File Offset: 0x005B41EB
		// (set) Token: 0x06029D4E RID: 171342 RVA: 0x005B5FF3 File Offset: 0x005B41F3
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x1700B7D7 RID: 47063
		// (get) Token: 0x06029D4F RID: 171343 RVA: 0x005B5FFC File Offset: 0x005B41FC
		// (set) Token: 0x06029D50 RID: 171344 RVA: 0x005B6004 File Offset: 0x005B4204
		public int Hours { get; set; }

		// Token: 0x1700B7D8 RID: 47064
		// (get) Token: 0x06029D51 RID: 171345 RVA: 0x005B600D File Offset: 0x005B420D
		// (set) Token: 0x06029D52 RID: 171346 RVA: 0x005B6015 File Offset: 0x005B4215
		public int Minutes { get; set; }

		// Token: 0x1700B7D9 RID: 47065
		// (get) Token: 0x06029D53 RID: 171347 RVA: 0x005B601E File Offset: 0x005B421E
		// (set) Token: 0x06029D54 RID: 171348 RVA: 0x005B6026 File Offset: 0x005B4226
		public int Second { get; set; }

		// Token: 0x1700B7DA RID: 47066
		// (get) Token: 0x06029D55 RID: 171349 RVA: 0x005B602F File Offset: 0x005B422F
		// (set) Token: 0x06029D56 RID: 171350 RVA: 0x005B6037 File Offset: 0x005B4237
		public byte NullMask { get; set; }

		// Token: 0x06029D57 RID: 171351 RVA: 0x005B6040 File Offset: 0x005B4240
		public ITimePatrolSplinePointT()
		{
			this.Position = null;
			this.ArriveTangent = null;
			this.LeaveTangent = null;
			this.LineType = ESplineLine.Linear;
			this.Rotation = null;
			this.Hours = 0;
			this.Minutes = 0;
			this.Second = 0;
			this.NullMask = 0;
		}
	}
}
