using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A4B RID: 23115
	public class ILevelAIBehaviourSplineT
	{
		// Token: 0x1700A821 RID: 43041
		// (get) Token: 0x06025CE2 RID: 154850 RVA: 0x0052EB3A File Offset: 0x0052CD3A
		// (set) Token: 0x06025CE3 RID: 154851 RVA: 0x0052EB42 File Offset: 0x0052CD42
		public ELevelAIBehaviourType Type { get; set; }

		// Token: 0x1700A822 RID: 43042
		// (get) Token: 0x06025CE4 RID: 154852 RVA: 0x0052EB4B File Offset: 0x0052CD4B
		// (set) Token: 0x06025CE5 RID: 154853 RVA: 0x0052EB53 File Offset: 0x0052CD53
		public int SplineEntityId { get; set; }

		// Token: 0x1700A823 RID: 43043
		// (get) Token: 0x06025CE6 RID: 154854 RVA: 0x0052EB5C File Offset: 0x0052CD5C
		// (set) Token: 0x06025CE7 RID: 154855 RVA: 0x0052EB64 File Offset: 0x0052CD64
		public byte NullMask { get; set; }

		// Token: 0x06025CE8 RID: 154856 RVA: 0x0052EB6D File Offset: 0x0052CD6D
		public ILevelAIBehaviourSplineT()
		{
			this.Type = ELevelAIBehaviourType.Spline;
			this.SplineEntityId = 0;
			this.NullMask = 0;
		}
	}
}
