using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EB9 RID: 28345
	public class IRestorePhantomFormationT
	{
		// Token: 0x1700D2FE RID: 54014
		// (get) Token: 0x06032196 RID: 205206 RVA: 0x006C618E File Offset: 0x006C438E
		// (set) Token: 0x06032197 RID: 205207 RVA: 0x006C6196 File Offset: 0x006C4396
		public int TeleportEntityId { get; set; }

		// Token: 0x1700D2FF RID: 54015
		// (get) Token: 0x06032198 RID: 205208 RVA: 0x006C619F File Offset: 0x006C439F
		// (set) Token: 0x06032199 RID: 205209 RVA: 0x006C61A7 File Offset: 0x006C43A7
		public bool RetainPhantom { get; set; }

		// Token: 0x1700D300 RID: 54016
		// (get) Token: 0x0603219A RID: 205210 RVA: 0x006C61B0 File Offset: 0x006C43B0
		// (set) Token: 0x0603219B RID: 205211 RVA: 0x006C61B8 File Offset: 0x006C43B8
		public byte NullMask { get; set; }

		// Token: 0x0603219C RID: 205212 RVA: 0x006C61C1 File Offset: 0x006C43C1
		public IRestorePhantomFormationT()
		{
			this.TeleportEntityId = 0;
			this.RetainPhantom = false;
			this.NullMask = 0;
		}
	}
}
