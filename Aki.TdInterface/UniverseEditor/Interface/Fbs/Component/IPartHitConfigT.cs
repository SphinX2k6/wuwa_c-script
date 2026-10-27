using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056BA RID: 22202
	public class IPartHitConfigT
	{
		// Token: 0x1700A53D RID: 42301
		// (get) Token: 0x06025162 RID: 151906 RVA: 0x0051F01D File Offset: 0x0051D21D
		// (set) Token: 0x06025163 RID: 151907 RVA: 0x0051F025 File Offset: 0x0051D225
		public string PartName { get; set; }

		// Token: 0x1700A53E RID: 42302
		// (get) Token: 0x06025164 RID: 151908 RVA: 0x0051F02E File Offset: 0x0051D22E
		// (set) Token: 0x06025165 RID: 151909 RVA: 0x0051F036 File Offset: 0x0051D236
		public THitBulletTypeUnion HitBullets { get; set; }

		// Token: 0x1700A53F RID: 42303
		// (get) Token: 0x06025166 RID: 151910 RVA: 0x0051F03F File Offset: 0x0051D23F
		// (set) Token: 0x06025167 RID: 151911 RVA: 0x0051F047 File Offset: 0x0051D247
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700A540 RID: 42304
		// (get) Token: 0x06025168 RID: 151912 RVA: 0x0051F050 File Offset: 0x0051D250
		// (set) Token: 0x06025169 RID: 151913 RVA: 0x0051F058 File Offset: 0x0051D258
		public byte NullMask { get; set; }

		// Token: 0x0602516A RID: 151914 RVA: 0x0051F061 File Offset: 0x0051D261
		public IPartHitConfigT()
		{
			this.PartName = null;
			this.HitBullets = null;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
