using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005025 RID: 20517
	public class IContinuesVariableSpeedSplinePointT
	{
		// Token: 0x170094DE RID: 38110
		// (get) Token: 0x06020DBB RID: 134587 RVA: 0x00491B00 File Offset: 0x0048FD00
		// (set) Token: 0x06020DBC RID: 134588 RVA: 0x00491B08 File Offset: 0x0048FD08
		public IVectorInfoT Position { get; set; }

		// Token: 0x170094DF RID: 38111
		// (get) Token: 0x06020DBD RID: 134589 RVA: 0x00491B11 File Offset: 0x0048FD11
		// (set) Token: 0x06020DBE RID: 134590 RVA: 0x00491B19 File Offset: 0x0048FD19
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x170094E0 RID: 38112
		// (get) Token: 0x06020DBF RID: 134591 RVA: 0x00491B22 File Offset: 0x0048FD22
		// (set) Token: 0x06020DC0 RID: 134592 RVA: 0x00491B2A File Offset: 0x0048FD2A
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x170094E1 RID: 38113
		// (get) Token: 0x06020DC1 RID: 134593 RVA: 0x00491B33 File Offset: 0x0048FD33
		// (set) Token: 0x06020DC2 RID: 134594 RVA: 0x00491B3B File Offset: 0x0048FD3B
		public ESplineLine LineType { get; set; }

		// Token: 0x170094E2 RID: 38114
		// (get) Token: 0x06020DC3 RID: 134595 RVA: 0x00491B44 File Offset: 0x0048FD44
		// (set) Token: 0x06020DC4 RID: 134596 RVA: 0x00491B4C File Offset: 0x0048FD4C
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x170094E3 RID: 38115
		// (get) Token: 0x06020DC5 RID: 134597 RVA: 0x00491B55 File Offset: 0x0048FD55
		// (set) Token: 0x06020DC6 RID: 134598 RVA: 0x00491B5D File Offset: 0x0048FD5D
		public ITimePathConfigT IntervalTimePathConfig { get; set; }

		// Token: 0x170094E4 RID: 38116
		// (get) Token: 0x06020DC7 RID: 134599 RVA: 0x00491B66 File Offset: 0x0048FD66
		// (set) Token: 0x06020DC8 RID: 134600 RVA: 0x00491B6E File Offset: 0x0048FD6E
		public List<IConditionActionT> ConditionActions { get; set; }

		// Token: 0x170094E5 RID: 38117
		// (get) Token: 0x06020DC9 RID: 134601 RVA: 0x00491B77 File Offset: 0x0048FD77
		// (set) Token: 0x06020DCA RID: 134602 RVA: 0x00491B7F File Offset: 0x0048FD7F
		public float KeepSpeed { get; set; }

		// Token: 0x170094E6 RID: 38118
		// (get) Token: 0x06020DCB RID: 134603 RVA: 0x00491B88 File Offset: 0x0048FD88
		// (set) Token: 0x06020DCC RID: 134604 RVA: 0x00491B90 File Offset: 0x0048FD90
		public byte NullMask { get; set; }

		// Token: 0x06020DCD RID: 134605 RVA: 0x00491B9C File Offset: 0x0048FD9C
		public IContinuesVariableSpeedSplinePointT()
		{
			this.Position = null;
			this.ArriveTangent = null;
			this.LeaveTangent = null;
			this.LineType = ESplineLine.Linear;
			this.Rotation = null;
			this.IntervalTimePathConfig = null;
			this.ConditionActions = null;
			this.KeepSpeed = 0f;
			this.NullMask = 0;
		}
	}
}
