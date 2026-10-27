using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052D4 RID: 21204
	public class IFreeAngleItemT
	{
		// Token: 0x17009B92 RID: 39826
		// (get) Token: 0x06022995 RID: 141717 RVA: 0x004CBC24 File Offset: 0x004C9E24
		// (set) Token: 0x06022996 RID: 141718 RVA: 0x004CBC2C File Offset: 0x004C9E2C
		public int InitAngle { get; set; }

		// Token: 0x17009B93 RID: 39827
		// (get) Token: 0x06022997 RID: 141719 RVA: 0x004CBC35 File Offset: 0x004C9E35
		// (set) Token: 0x06022998 RID: 141720 RVA: 0x004CBC3D File Offset: 0x004C9E3D
		public int TargetAngle { get; set; }

		// Token: 0x06022999 RID: 141721 RVA: 0x004CBC46 File Offset: 0x004C9E46
		public IFreeAngleItemT()
		{
			this.InitAngle = 0;
			this.TargetAngle = 0;
		}
	}
}
