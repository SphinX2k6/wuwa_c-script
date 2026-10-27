using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EA2 RID: 20130
	public class IAngularVelocityConfigT
	{
		// Token: 0x1700905D RID: 36957
		// (get) Token: 0x0601FAF8 RID: 129784 RVA: 0x00469822 File Offset: 0x00467A22
		// (set) Token: 0x0601FAF9 RID: 129785 RVA: 0x0046982A File Offset: 0x00467A2A
		public IRangedRandomT X { get; set; }

		// Token: 0x1700905E RID: 36958
		// (get) Token: 0x0601FAFA RID: 129786 RVA: 0x00469833 File Offset: 0x00467A33
		// (set) Token: 0x0601FAFB RID: 129787 RVA: 0x0046983B File Offset: 0x00467A3B
		public IRangedRandomT Y { get; set; }

		// Token: 0x1700905F RID: 36959
		// (get) Token: 0x0601FAFC RID: 129788 RVA: 0x00469844 File Offset: 0x00467A44
		// (set) Token: 0x0601FAFD RID: 129789 RVA: 0x0046984C File Offset: 0x00467A4C
		public IRangedRandomT Z { get; set; }

		// Token: 0x0601FAFE RID: 129790 RVA: 0x00469855 File Offset: 0x00467A55
		public IAngularVelocityConfigT()
		{
			this.X = null;
			this.Y = null;
			this.Z = null;
		}
	}
}
