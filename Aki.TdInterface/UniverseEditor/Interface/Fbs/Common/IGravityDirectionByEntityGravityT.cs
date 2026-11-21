using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006432 RID: 25650
	public class IGravityDirectionByEntityGravityT
	{
		// Token: 0x1700BD68 RID: 48488
		// (get) Token: 0x0602B954 RID: 178516 RVA: 0x005EF1C8 File Offset: 0x005ED3C8
		// (set) Token: 0x0602B955 RID: 178517 RVA: 0x005EF1D0 File Offset: 0x005ED3D0
		public EGravityDirectionType Type { get; set; }

		// Token: 0x1700BD69 RID: 48489
		// (get) Token: 0x0602B956 RID: 178518 RVA: 0x005EF1D9 File Offset: 0x005ED3D9
		// (set) Token: 0x0602B957 RID: 178519 RVA: 0x005EF1E1 File Offset: 0x005ED3E1
		public int EntityId { get; set; }

		// Token: 0x0602B958 RID: 178520 RVA: 0x005EF1EA File Offset: 0x005ED3EA
		public IGravityDirectionByEntityGravityT()
		{
			this.Type = EGravityDirectionType.SelfRotation;
			this.EntityId = 0;
		}
	}
}
