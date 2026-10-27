using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200545C RID: 21596
	public class IInteractPlayerDiractionToLeisureT
	{
		// Token: 0x17009F07 RID: 40711
		// (get) Token: 0x0602387B RID: 145531 RVA: 0x004EA4DA File Offset: 0x004E86DA
		// (set) Token: 0x0602387C RID: 145532 RVA: 0x004EA4E2 File Offset: 0x004E86E2
		public EInteractPlayerDiractionType Type { get; set; }

		// Token: 0x17009F08 RID: 40712
		// (get) Token: 0x0602387D RID: 145533 RVA: 0x004EA4EB File Offset: 0x004E86EB
		// (set) Token: 0x0602387E RID: 145534 RVA: 0x004EA4F3 File Offset: 0x004E86F3
		public int Begin { get; set; }

		// Token: 0x17009F09 RID: 40713
		// (get) Token: 0x0602387F RID: 145535 RVA: 0x004EA4FC File Offset: 0x004E86FC
		// (set) Token: 0x06023880 RID: 145536 RVA: 0x004EA504 File Offset: 0x004E8704
		public int End { get; set; }

		// Token: 0x06023881 RID: 145537 RVA: 0x004EA50D File Offset: 0x004E870D
		public IInteractPlayerDiractionToLeisureT()
		{
			this.Type = EInteractPlayerDiractionType.Npc;
			this.Begin = 0;
			this.End = 0;
		}
	}
}
