using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F30 RID: 20272
	public class ICheckHonamiStoryUnlockMascotT
	{
		// Token: 0x170090CD RID: 37069
		// (get) Token: 0x0601F82D RID: 129069 RVA: 0x0046294A File Offset: 0x00460B4A
		// (set) Token: 0x0601F82E RID: 129070 RVA: 0x00462952 File Offset: 0x00460B52
		public ECondition Type { get; set; }

		// Token: 0x170090CE RID: 37070
		// (get) Token: 0x0601F82F RID: 129071 RVA: 0x0046295B File Offset: 0x00460B5B
		// (set) Token: 0x0601F830 RID: 129072 RVA: 0x00462963 File Offset: 0x00460B63
		public int MascotId { get; set; }

		// Token: 0x170090CF RID: 37071
		// (get) Token: 0x0601F831 RID: 129073 RVA: 0x0046296C File Offset: 0x00460B6C
		// (set) Token: 0x0601F832 RID: 129074 RVA: 0x00462974 File Offset: 0x00460B74
		public bool IsUnlocked { get; set; }

		// Token: 0x0601F833 RID: 129075 RVA: 0x0046297D File Offset: 0x00460B7D
		public ICheckHonamiStoryUnlockMascotT()
		{
			this.Type = ECondition.CompareVar;
			this.MascotId = 0;
			this.IsUnlocked = false;
		}
	}
}
