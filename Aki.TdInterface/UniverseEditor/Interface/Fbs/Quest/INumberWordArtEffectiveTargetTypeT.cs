using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200439E RID: 17310
	public class INumberWordArtEffectiveTargetTypeT
	{
		// Token: 0x170076C4 RID: 30404
		// (get) Token: 0x060187A2 RID: 100258 RVA: 0x0037CE22 File Offset: 0x0037B022
		// (set) Token: 0x060187A3 RID: 100259 RVA: 0x0037CE2A File Offset: 0x0037B02A
		public EWordArtEffectiveTargetType Type { get; set; }

		// Token: 0x170076C5 RID: 30405
		// (get) Token: 0x060187A4 RID: 100260 RVA: 0x0037CE33 File Offset: 0x0037B033
		// (set) Token: 0x060187A5 RID: 100261 RVA: 0x0037CE3B File Offset: 0x0037B03B
		public bool ShowUiMotion { get; set; }

		// Token: 0x170076C6 RID: 30406
		// (get) Token: 0x060187A6 RID: 100262 RVA: 0x0037CE44 File Offset: 0x0037B044
		// (set) Token: 0x060187A7 RID: 100263 RVA: 0x0037CE4C File Offset: 0x0037B04C
		public byte NullMask { get; set; }

		// Token: 0x060187A8 RID: 100264 RVA: 0x0037CE55 File Offset: 0x0037B055
		public INumberWordArtEffectiveTargetTypeT()
		{
			this.Type = EWordArtEffectiveTargetType.Number;
			this.ShowUiMotion = false;
			this.NullMask = 0;
		}
	}
}
