using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075C0 RID: 30144
	public class IVisualNovelPerformanceSendAudioEventT
	{
		// Token: 0x1700E4E8 RID: 58600
		// (get) Token: 0x06036E50 RID: 224848 RVA: 0x007739EB File Offset: 0x00771BEB
		// (set) Token: 0x06036E51 RID: 224849 RVA: 0x007739F3 File Offset: 0x00771BF3
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700E4E9 RID: 58601
		// (get) Token: 0x06036E52 RID: 224850 RVA: 0x007739FC File Offset: 0x00771BFC
		// (set) Token: 0x06036E53 RID: 224851 RVA: 0x00773A04 File Offset: 0x00771C04
		public float StartTime { get; set; }

		// Token: 0x1700E4EA RID: 58602
		// (get) Token: 0x06036E54 RID: 224852 RVA: 0x00773A0D File Offset: 0x00771C0D
		// (set) Token: 0x06036E55 RID: 224853 RVA: 0x00773A15 File Offset: 0x00771C15
		public string AudioEvent { get; set; }

		// Token: 0x1700E4EB RID: 58603
		// (get) Token: 0x06036E56 RID: 224854 RVA: 0x00773A1E File Offset: 0x00771C1E
		// (set) Token: 0x06036E57 RID: 224855 RVA: 0x00773A26 File Offset: 0x00771C26
		public float EndFadeOutTime { get; set; }

		// Token: 0x1700E4EC RID: 58604
		// (get) Token: 0x06036E58 RID: 224856 RVA: 0x00773A2F File Offset: 0x00771C2F
		// (set) Token: 0x06036E59 RID: 224857 RVA: 0x00773A37 File Offset: 0x00771C37
		public bool IsNotCountTimeAndNotInterrupted { get; set; }

		// Token: 0x1700E4ED RID: 58605
		// (get) Token: 0x06036E5A RID: 224858 RVA: 0x00773A40 File Offset: 0x00771C40
		// (set) Token: 0x06036E5B RID: 224859 RVA: 0x00773A48 File Offset: 0x00771C48
		public byte NullMask { get; set; }

		// Token: 0x06036E5C RID: 224860 RVA: 0x00773A51 File Offset: 0x00771C51
		public IVisualNovelPerformanceSendAudioEventT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.AudioEvent = null;
			this.EndFadeOutTime = 0f;
			this.IsNotCountTimeAndNotInterrupted = false;
			this.NullMask = 0;
		}
	}
}
