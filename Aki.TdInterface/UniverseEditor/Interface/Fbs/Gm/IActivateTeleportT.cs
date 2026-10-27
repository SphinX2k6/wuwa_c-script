using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200462B RID: 17963
	public class IActivateTeleportT
	{
		// Token: 0x17007F7F RID: 32639
		// (get) Token: 0x0601B34B RID: 111435 RVA: 0x003DFB9C File Offset: 0x003DDD9C
		// (set) Token: 0x0601B34C RID: 111436 RVA: 0x003DFBA4 File Offset: 0x003DDDA4
		public EGmCommand Type { get; set; }

		// Token: 0x17007F80 RID: 32640
		// (get) Token: 0x0601B34D RID: 111437 RVA: 0x003DFBAD File Offset: 0x003DDDAD
		// (set) Token: 0x0601B34E RID: 111438 RVA: 0x003DFBB5 File Offset: 0x003DDDB5
		public int TeleportId { get; set; }

		// Token: 0x0601B34F RID: 111439 RVA: 0x003DFBBE File Offset: 0x003DDDBE
		public IActivateTeleportT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.TeleportId = 0;
		}
	}
}
