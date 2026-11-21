using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC4 RID: 28356
	public class IFocusObjectRotationConfigT
	{
		// Token: 0x1700D005 RID: 53253
		// (get) Token: 0x06031107 RID: 200967 RVA: 0x006A756F File Offset: 0x006A576F
		// (set) Token: 0x06031108 RID: 200968 RVA: 0x006A7577 File Offset: 0x006A5777
		public IVectorInfoT TargetRotation { get; set; }

		// Token: 0x1700D006 RID: 53254
		// (get) Token: 0x06031109 RID: 200969 RVA: 0x006A7580 File Offset: 0x006A5780
		// (set) Token: 0x0603110A RID: 200970 RVA: 0x006A7588 File Offset: 0x006A5788
		public string SpeedCurve { get; set; }

		// Token: 0x0603110B RID: 200971 RVA: 0x006A7591 File Offset: 0x006A5791
		public IFocusObjectRotationConfigT()
		{
			this.TargetRotation = null;
			this.SpeedCurve = null;
		}
	}
}
