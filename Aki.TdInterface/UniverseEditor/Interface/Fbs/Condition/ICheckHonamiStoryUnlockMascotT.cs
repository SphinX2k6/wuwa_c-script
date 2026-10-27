using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A6A RID: 19050
	public class ICheckHonamiStoryUnlockMascotT
	{
		// Token: 0x170089F1 RID: 35313
		// (get) Token: 0x0601DD8A RID: 122250 RVA: 0x004317BE File Offset: 0x0042F9BE
		// (set) Token: 0x0601DD8B RID: 122251 RVA: 0x004317C6 File Offset: 0x0042F9C6
		public ECondition Type { get; set; }

		// Token: 0x170089F2 RID: 35314
		// (get) Token: 0x0601DD8C RID: 122252 RVA: 0x004317CF File Offset: 0x0042F9CF
		// (set) Token: 0x0601DD8D RID: 122253 RVA: 0x004317D7 File Offset: 0x0042F9D7
		public int MascotId { get; set; }

		// Token: 0x170089F3 RID: 35315
		// (get) Token: 0x0601DD8E RID: 122254 RVA: 0x004317E0 File Offset: 0x0042F9E0
		// (set) Token: 0x0601DD8F RID: 122255 RVA: 0x004317E8 File Offset: 0x0042F9E8
		public bool IsUnlocked { get; set; }

		// Token: 0x0601DD90 RID: 122256 RVA: 0x004317F1 File Offset: 0x0042F9F1
		public ICheckHonamiStoryUnlockMascotT()
		{
			this.Type = ECondition.CompareVar;
			this.MascotId = 0;
			this.IsUnlocked = false;
		}
	}
}
