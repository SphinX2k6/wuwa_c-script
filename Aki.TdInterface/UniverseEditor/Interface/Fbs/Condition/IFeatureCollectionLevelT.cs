using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005116 RID: 20758
	public class IFeatureCollectionLevelT
	{
		// Token: 0x170094C1 RID: 38081
		// (get) Token: 0x06020A1D RID: 133661 RVA: 0x004860F8 File Offset: 0x004842F8
		// (set) Token: 0x06020A1E RID: 133662 RVA: 0x00486100 File Offset: 0x00484300
		public EFormationRoleInfoType Type { get; set; }

		// Token: 0x170094C2 RID: 38082
		// (get) Token: 0x06020A1F RID: 133663 RVA: 0x00486109 File Offset: 0x00484309
		// (set) Token: 0x06020A20 RID: 133664 RVA: 0x00486111 File Offset: 0x00484311
		public int Id { get; set; }

		// Token: 0x170094C3 RID: 38083
		// (get) Token: 0x06020A21 RID: 133665 RVA: 0x0048611A File Offset: 0x0048431A
		// (set) Token: 0x06020A22 RID: 133666 RVA: 0x00486122 File Offset: 0x00484322
		public ECompare Compare { get; set; }

		// Token: 0x170094C4 RID: 38084
		// (get) Token: 0x06020A23 RID: 133667 RVA: 0x0048612B File Offset: 0x0048432B
		// (set) Token: 0x06020A24 RID: 133668 RVA: 0x00486133 File Offset: 0x00484333
		public int Level { get; set; }

		// Token: 0x06020A25 RID: 133669 RVA: 0x0048613C File Offset: 0x0048433C
		public IFeatureCollectionLevelT()
		{
			this.Type = EFormationRoleInfoType.RoleLevel;
			this.Id = 0;
			this.Compare = ECompare.Eq;
			this.Level = 0;
		}
	}
}
