using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054F8 RID: 21752
	public class ILifePointCenterComponentT
	{
		// Token: 0x1700A086 RID: 41094
		// (get) Token: 0x06023E8B RID: 147083 RVA: 0x004F6F1C File Offset: 0x004F511C
		// (set) Token: 0x06023E8C RID: 147084 RVA: 0x004F6F24 File Offset: 0x004F5124
		public bool Disabled { get; set; }

		// Token: 0x1700A087 RID: 41095
		// (get) Token: 0x06023E8D RID: 147085 RVA: 0x004F6F2D File Offset: 0x004F512D
		// (set) Token: 0x06023E8E RID: 147086 RVA: 0x004F6F35 File Offset: 0x004F5135
		public byte NullMask { get; set; }

		// Token: 0x06023E8F RID: 147087 RVA: 0x004F6F3E File Offset: 0x004F513E
		public ILifePointCenterComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
