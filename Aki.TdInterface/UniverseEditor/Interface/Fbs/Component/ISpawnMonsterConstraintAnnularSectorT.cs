using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005954 RID: 22868
	public class ISpawnMonsterConstraintAnnularSectorT
	{
		// Token: 0x1700ABAC RID: 43948
		// (get) Token: 0x06026B5B RID: 158555 RVA: 0x00554B2C File Offset: 0x00552D2C
		// (set) Token: 0x06026B5C RID: 158556 RVA: 0x00554B34 File Offset: 0x00552D34
		public ESpawnMonsterConstraint Type { get; set; }

		// Token: 0x1700ABAD RID: 43949
		// (get) Token: 0x06026B5D RID: 158557 RVA: 0x00554B3D File Offset: 0x00552D3D
		// (set) Token: 0x06026B5E RID: 158558 RVA: 0x00554B45 File Offset: 0x00552D45
		public float InnerRadius { get; set; }

		// Token: 0x1700ABAE RID: 43950
		// (get) Token: 0x06026B5F RID: 158559 RVA: 0x00554B4E File Offset: 0x00552D4E
		// (set) Token: 0x06026B60 RID: 158560 RVA: 0x00554B56 File Offset: 0x00552D56
		public float OuterRadius { get; set; }

		// Token: 0x1700ABAF RID: 43951
		// (get) Token: 0x06026B61 RID: 158561 RVA: 0x00554B5F File Offset: 0x00552D5F
		// (set) Token: 0x06026B62 RID: 158562 RVA: 0x00554B67 File Offset: 0x00552D67
		public float Angle { get; set; }

		// Token: 0x06026B63 RID: 158563 RVA: 0x00554B70 File Offset: 0x00552D70
		public ISpawnMonsterConstraintAnnularSectorT()
		{
			this.Type = ESpawnMonsterConstraint.CharacterForwardAnnularSector;
			this.InnerRadius = 0f;
			this.OuterRadius = 0f;
			this.Angle = 0f;
		}
	}
}
