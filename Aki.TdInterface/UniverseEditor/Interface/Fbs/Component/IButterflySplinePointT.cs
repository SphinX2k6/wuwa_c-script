using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F4A RID: 20298
	public class IButterflySplinePointT
	{
		// Token: 0x17009253 RID: 37459
		// (get) Token: 0x06020259 RID: 131673 RVA: 0x00479103 File Offset: 0x00477303
		// (set) Token: 0x0602025A RID: 131674 RVA: 0x0047910B File Offset: 0x0047730B
		public IVectorInfoT Position { get; set; }

		// Token: 0x17009254 RID: 37460
		// (get) Token: 0x0602025B RID: 131675 RVA: 0x00479114 File Offset: 0x00477314
		// (set) Token: 0x0602025C RID: 131676 RVA: 0x0047911C File Offset: 0x0047731C
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x17009255 RID: 37461
		// (get) Token: 0x0602025D RID: 131677 RVA: 0x00479125 File Offset: 0x00477325
		// (set) Token: 0x0602025E RID: 131678 RVA: 0x0047912D File Offset: 0x0047732D
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x17009256 RID: 37462
		// (get) Token: 0x0602025F RID: 131679 RVA: 0x00479136 File Offset: 0x00477336
		// (set) Token: 0x06020260 RID: 131680 RVA: 0x0047913E File Offset: 0x0047733E
		public ESplineLine LineType { get; set; }

		// Token: 0x17009257 RID: 37463
		// (get) Token: 0x06020261 RID: 131681 RVA: 0x00479147 File Offset: 0x00477347
		// (set) Token: 0x06020262 RID: 131682 RVA: 0x0047914F File Offset: 0x0047734F
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x17009258 RID: 37464
		// (get) Token: 0x06020263 RID: 131683 RVA: 0x00479158 File Offset: 0x00477358
		// (set) Token: 0x06020264 RID: 131684 RVA: 0x00479160 File Offset: 0x00477360
		public int MoveSpeed { get; set; }

		// Token: 0x17009259 RID: 37465
		// (get) Token: 0x06020265 RID: 131685 RVA: 0x00479169 File Offset: 0x00477369
		// (set) Token: 0x06020266 RID: 131686 RVA: 0x00479171 File Offset: 0x00477371
		public bool IgnorePoint { get; set; }

		// Token: 0x06020267 RID: 131687 RVA: 0x0047917A File Offset: 0x0047737A
		public IButterflySplinePointT()
		{
			this.Position = null;
			this.ArriveTangent = null;
			this.LeaveTangent = null;
			this.LineType = ESplineLine.Linear;
			this.Rotation = null;
			this.MoveSpeed = 0;
			this.IgnorePoint = false;
		}
	}
}
