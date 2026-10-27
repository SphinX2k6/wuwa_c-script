using System;
using Aki.UniverseEditor.Interface.Fbs.Physics;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005734 RID: 22324
	public class IPhysicsConstraintComponentT
	{
		// Token: 0x1700A667 RID: 42599
		// (get) Token: 0x06025601 RID: 153089 RVA: 0x005284B0 File Offset: 0x005266B0
		// (set) Token: 0x06025602 RID: 153090 RVA: 0x005284B8 File Offset: 0x005266B8
		public bool Disabled { get; set; }

		// Token: 0x1700A668 RID: 42600
		// (get) Token: 0x06025603 RID: 153091 RVA: 0x005284C1 File Offset: 0x005266C1
		// (set) Token: 0x06025604 RID: 153092 RVA: 0x005284C9 File Offset: 0x005266C9
		public string EffectPath { get; set; }

		// Token: 0x1700A669 RID: 42601
		// (get) Token: 0x06025605 RID: 153093 RVA: 0x005284D2 File Offset: 0x005266D2
		// (set) Token: 0x06025606 RID: 153094 RVA: 0x005284DA File Offset: 0x005266DA
		public TPhysicsAttachTargetUnion AttachTarget { get; set; }

		// Token: 0x1700A66A RID: 42602
		// (get) Token: 0x06025607 RID: 153095 RVA: 0x005284E3 File Offset: 0x005266E3
		// (set) Token: 0x06025608 RID: 153096 RVA: 0x005284EB File Offset: 0x005266EB
		public IPhysicsAngularLimitT AngularLimit { get; set; }

		// Token: 0x1700A66B RID: 42603
		// (get) Token: 0x06025609 RID: 153097 RVA: 0x005284F4 File Offset: 0x005266F4
		// (set) Token: 0x0602560A RID: 153098 RVA: 0x005284FC File Offset: 0x005266FC
		public float DampingCoefficient { get; set; }

		// Token: 0x1700A66C RID: 42604
		// (get) Token: 0x0602560B RID: 153099 RVA: 0x00528505 File Offset: 0x00526705
		// (set) Token: 0x0602560C RID: 153100 RVA: 0x0052850D File Offset: 0x0052670D
		public byte NullMask { get; set; }

		// Token: 0x0602560D RID: 153101 RVA: 0x00528516 File Offset: 0x00526716
		public IPhysicsConstraintComponentT()
		{
			this.Disabled = false;
			this.EffectPath = null;
			this.AttachTarget = null;
			this.AngularLimit = null;
			this.DampingCoefficient = 0f;
			this.NullMask = 0;
		}
	}
}
