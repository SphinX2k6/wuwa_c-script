using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055F9 RID: 22009
	public class IDollComboCameraConfigT
	{
		// Token: 0x17009DBE RID: 40382
		// (get) Token: 0x0602311F RID: 143647 RVA: 0x004D3D13 File Offset: 0x004D1F13
		// (set) Token: 0x06023120 RID: 143648 RVA: 0x004D3D1B File Offset: 0x004D1F1B
		public int ComboId { get; set; }

		// Token: 0x17009DBF RID: 40383
		// (get) Token: 0x06023121 RID: 143649 RVA: 0x004D3D24 File Offset: 0x004D1F24
		// (set) Token: 0x06023122 RID: 143650 RVA: 0x004D3D2C File Offset: 0x004D1F2C
		public IPosAndRotT PosAndRot { get; set; }

		// Token: 0x06023123 RID: 143651 RVA: 0x004D3D35 File Offset: 0x004D1F35
		public IDollComboCameraConfigT()
		{
			this.ComboId = 0;
			this.PosAndRot = null;
		}
	}
}
