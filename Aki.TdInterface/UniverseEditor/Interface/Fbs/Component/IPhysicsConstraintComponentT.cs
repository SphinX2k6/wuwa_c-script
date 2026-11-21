using System;
using Aki.UniverseEditor.Interface.Fbs.Physics;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D3B RID: 23867
	public class IPhysicsConstraintComponentT
	{
		// Token: 0x1700AF8B RID: 44939
		// (get) Token: 0x06027B21 RID: 162593 RVA: 0x0056E63C File Offset: 0x0056C83C
		// (set) Token: 0x06027B22 RID: 162594 RVA: 0x0056E644 File Offset: 0x0056C844
		public bool Disabled { get; set; }

		// Token: 0x1700AF8C RID: 44940
		// (get) Token: 0x06027B23 RID: 162595 RVA: 0x0056E64D File Offset: 0x0056C84D
		// (set) Token: 0x06027B24 RID: 162596 RVA: 0x0056E655 File Offset: 0x0056C855
		public string EffectPath { get; set; }

		// Token: 0x1700AF8D RID: 44941
		// (get) Token: 0x06027B25 RID: 162597 RVA: 0x0056E65E File Offset: 0x0056C85E
		// (set) Token: 0x06027B26 RID: 162598 RVA: 0x0056E666 File Offset: 0x0056C866
		public TPhysicsAttachTargetUnion AttachTarget { get; set; }

		// Token: 0x1700AF8E RID: 44942
		// (get) Token: 0x06027B27 RID: 162599 RVA: 0x0056E66F File Offset: 0x0056C86F
		// (set) Token: 0x06027B28 RID: 162600 RVA: 0x0056E677 File Offset: 0x0056C877
		public IPhysicsAngularLimitT AngularLimit { get; set; }

		// Token: 0x1700AF8F RID: 44943
		// (get) Token: 0x06027B29 RID: 162601 RVA: 0x0056E680 File Offset: 0x0056C880
		// (set) Token: 0x06027B2A RID: 162602 RVA: 0x0056E688 File Offset: 0x0056C888
		public float DampingCoefficient { get; set; }

		// Token: 0x1700AF90 RID: 44944
		// (get) Token: 0x06027B2B RID: 162603 RVA: 0x0056E691 File Offset: 0x0056C891
		// (set) Token: 0x06027B2C RID: 162604 RVA: 0x0056E699 File Offset: 0x0056C899
		public byte NullMask { get; set; }

		// Token: 0x06027B2D RID: 162605 RVA: 0x0056E6A2 File Offset: 0x0056C8A2
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
