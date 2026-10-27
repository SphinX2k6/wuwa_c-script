using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075CF RID: 30159
	public class IVisualNovelPortraitPosPresetT
	{
		// Token: 0x1700E51C RID: 58652
		// (get) Token: 0x06036EFA RID: 225018 RVA: 0x00774D21 File Offset: 0x00772F21
		// (set) Token: 0x06036EFB RID: 225019 RVA: 0x00774D29 File Offset: 0x00772F29
		public string Name { get; set; }

		// Token: 0x1700E51D RID: 58653
		// (get) Token: 0x06036EFC RID: 225020 RVA: 0x00774D32 File Offset: 0x00772F32
		// (set) Token: 0x06036EFD RID: 225021 RVA: 0x00774D3A File Offset: 0x00772F3A
		public int PosX { get; set; }

		// Token: 0x1700E51E RID: 58654
		// (get) Token: 0x06036EFE RID: 225022 RVA: 0x00774D43 File Offset: 0x00772F43
		// (set) Token: 0x06036EFF RID: 225023 RVA: 0x00774D4B File Offset: 0x00772F4B
		public int PosY { get; set; }

		// Token: 0x06036F00 RID: 225024 RVA: 0x00774D54 File Offset: 0x00772F54
		public IVisualNovelPortraitPosPresetT()
		{
			this.Name = null;
			this.PosX = 0;
			this.PosY = 0;
		}
	}
}
