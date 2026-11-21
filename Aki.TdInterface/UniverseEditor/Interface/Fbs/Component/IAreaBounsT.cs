using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053E0 RID: 21472
	public class IAreaBounsT
	{
		// Token: 0x170097F4 RID: 38900
		// (get) Token: 0x060218C5 RID: 137413 RVA: 0x004A044E File Offset: 0x0049E64E
		// (set) Token: 0x060218C6 RID: 137414 RVA: 0x004A0456 File Offset: 0x0049E656
		public EWorldLevelBonus Type { get; set; }

		// Token: 0x060218C7 RID: 137415 RVA: 0x004A045F File Offset: 0x0049E65F
		public IAreaBounsT()
		{
			this.Type = EWorldLevelBonus.WorldLevelTable;
		}
	}
}
