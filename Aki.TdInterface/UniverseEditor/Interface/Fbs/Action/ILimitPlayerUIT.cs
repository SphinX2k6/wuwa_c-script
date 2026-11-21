using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070DD RID: 28893
	public class ILimitPlayerUIT
	{
		// Token: 0x1700D39C RID: 54172
		// (get) Token: 0x060322D4 RID: 205524 RVA: 0x006C9DAA File Offset: 0x006C7FAA
		// (set) Token: 0x060322D5 RID: 205525 RVA: 0x006C9DB2 File Offset: 0x006C7FB2
		public ELimitPlayOperation Type { get; set; }

		// Token: 0x060322D6 RID: 205526 RVA: 0x006C9DBB File Offset: 0x006C7FBB
		public ILimitPlayerUIT()
		{
			this.Type = ELimitPlayOperation.AllowCamera;
		}
	}
}
