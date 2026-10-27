using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051C0 RID: 20928
	public class IEntityTrackControlT
	{
		// Token: 0x17009919 RID: 39193
		// (get) Token: 0x06021EA8 RID: 138920 RVA: 0x004B48C1 File Offset: 0x004B2AC1
		// (set) Token: 0x06021EA9 RID: 138921 RVA: 0x004B48C9 File Offset: 0x004B2AC9
		public ETrackControlMode Type { get; set; }

		// Token: 0x1700991A RID: 39194
		// (get) Token: 0x06021EAA RID: 138922 RVA: 0x004B48D2 File Offset: 0x004B2AD2
		// (set) Token: 0x06021EAB RID: 138923 RVA: 0x004B48DA File Offset: 0x004B2ADA
		public int EntityId { get; set; }

		// Token: 0x1700991B RID: 39195
		// (get) Token: 0x06021EAC RID: 138924 RVA: 0x004B48E3 File Offset: 0x004B2AE3
		// (set) Token: 0x06021EAD RID: 138925 RVA: 0x004B48EB File Offset: 0x004B2AEB
		public List<IEntityTrackControlPointT> ControlPoints { get; set; }

		// Token: 0x06021EAE RID: 138926 RVA: 0x004B48F4 File Offset: 0x004B2AF4
		public IEntityTrackControlT()
		{
			this.Type = ETrackControlMode.Sequence;
			this.EntityId = 0;
			this.ControlPoints = null;
		}
	}
}
