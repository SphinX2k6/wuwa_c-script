using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054C5 RID: 21701
	public class ILevelAIBehaviourSplineT
	{
		// Token: 0x17009FE7 RID: 40935
		// (get) Token: 0x06023C2A RID: 146474 RVA: 0x004F1AC6 File Offset: 0x004EFCC6
		// (set) Token: 0x06023C2B RID: 146475 RVA: 0x004F1ACE File Offset: 0x004EFCCE
		public ELevelAIBehaviourType Type { get; set; }

		// Token: 0x17009FE8 RID: 40936
		// (get) Token: 0x06023C2C RID: 146476 RVA: 0x004F1AD7 File Offset: 0x004EFCD7
		// (set) Token: 0x06023C2D RID: 146477 RVA: 0x004F1ADF File Offset: 0x004EFCDF
		public int SplineEntityId { get; set; }

		// Token: 0x17009FE9 RID: 40937
		// (get) Token: 0x06023C2E RID: 146478 RVA: 0x004F1AE8 File Offset: 0x004EFCE8
		// (set) Token: 0x06023C2F RID: 146479 RVA: 0x004F1AF0 File Offset: 0x004EFCF0
		public byte NullMask { get; set; }

		// Token: 0x06023C30 RID: 146480 RVA: 0x004F1AF9 File Offset: 0x004EFCF9
		public ILevelAIBehaviourSplineT()
		{
			this.Type = ELevelAIBehaviourType.Spline;
			this.SplineEntityId = 0;
			this.NullMask = 0;
		}
	}
}
