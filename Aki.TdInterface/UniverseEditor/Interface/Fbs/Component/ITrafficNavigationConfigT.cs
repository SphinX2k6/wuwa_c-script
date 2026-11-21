using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060D4 RID: 24788
	public class ITrafficNavigationConfigT
	{
		// Token: 0x1700B849 RID: 47177
		// (get) Token: 0x06029F51 RID: 171857 RVA: 0x005B9ED4 File Offset: 0x005B80D4
		// (set) Token: 0x06029F52 RID: 171858 RVA: 0x005B9EDC File Offset: 0x005B80DC
		public ERoadNetworkNavigationType Type { get; set; }

		// Token: 0x1700B84A RID: 47178
		// (get) Token: 0x06029F53 RID: 171859 RVA: 0x005B9EE5 File Offset: 0x005B80E5
		// (set) Token: 0x06029F54 RID: 171860 RVA: 0x005B9EED File Offset: 0x005B80ED
		public IVectorInfoT Size { get; set; }

		// Token: 0x1700B84B RID: 47179
		// (get) Token: 0x06029F55 RID: 171861 RVA: 0x005B9EF6 File Offset: 0x005B80F6
		// (set) Token: 0x06029F56 RID: 171862 RVA: 0x005B9EFE File Offset: 0x005B80FE
		public TTriggerShapeUnion BoundingVolume { get; set; }

		// Token: 0x1700B84C RID: 47180
		// (get) Token: 0x06029F57 RID: 171863 RVA: 0x005B9F07 File Offset: 0x005B8107
		// (set) Token: 0x06029F58 RID: 171864 RVA: 0x005B9F0F File Offset: 0x005B810F
		public float MaxSpeed { get; set; }

		// Token: 0x1700B84D RID: 47181
		// (get) Token: 0x06029F59 RID: 171865 RVA: 0x005B9F18 File Offset: 0x005B8118
		// (set) Token: 0x06029F5A RID: 171866 RVA: 0x005B9F20 File Offset: 0x005B8120
		public float Acceleration { get; set; }

		// Token: 0x1700B84E RID: 47182
		// (get) Token: 0x06029F5B RID: 171867 RVA: 0x005B9F29 File Offset: 0x005B8129
		// (set) Token: 0x06029F5C RID: 171868 RVA: 0x005B9F31 File Offset: 0x005B8131
		public string MaxSpeedCurve { get; set; }

		// Token: 0x1700B84F RID: 47183
		// (get) Token: 0x06029F5D RID: 171869 RVA: 0x005B9F3A File Offset: 0x005B813A
		// (set) Token: 0x06029F5E RID: 171870 RVA: 0x005B9F42 File Offset: 0x005B8142
		public string HitEffect { get; set; }

		// Token: 0x06029F5F RID: 171871 RVA: 0x005B9F4C File Offset: 0x005B814C
		public ITrafficNavigationConfigT()
		{
			this.Type = ERoadNetworkNavigationType.Traffic;
			this.Size = null;
			this.BoundingVolume = null;
			this.MaxSpeed = 0f;
			this.Acceleration = 0f;
			this.MaxSpeedCurve = null;
			this.HitEffect = null;
		}
	}
}
