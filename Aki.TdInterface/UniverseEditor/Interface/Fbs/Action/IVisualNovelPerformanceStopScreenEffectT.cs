using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075C3 RID: 30147
	public class IVisualNovelPerformanceStopScreenEffectT
	{
		// Token: 0x1700E4F3 RID: 58611
		// (get) Token: 0x06036E74 RID: 224884 RVA: 0x00773D9B File Offset: 0x00771F9B
		// (set) Token: 0x06036E75 RID: 224885 RVA: 0x00773DA3 File Offset: 0x00771FA3
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700E4F4 RID: 58612
		// (get) Token: 0x06036E76 RID: 224886 RVA: 0x00773DAC File Offset: 0x00771FAC
		// (set) Token: 0x06036E77 RID: 224887 RVA: 0x00773DB4 File Offset: 0x00771FB4
		public float StartTime { get; set; }

		// Token: 0x1700E4F5 RID: 58613
		// (get) Token: 0x06036E78 RID: 224888 RVA: 0x00773DBD File Offset: 0x00771FBD
		// (set) Token: 0x06036E79 RID: 224889 RVA: 0x00773DC5 File Offset: 0x00771FC5
		public string ScreenEffectDa { get; set; }

		// Token: 0x1700E4F6 RID: 58614
		// (get) Token: 0x06036E7A RID: 224890 RVA: 0x00773DCE File Offset: 0x00771FCE
		// (set) Token: 0x06036E7B RID: 224891 RVA: 0x00773DD6 File Offset: 0x00771FD6
		public byte NullMask { get; set; }

		// Token: 0x06036E7C RID: 224892 RVA: 0x00773DDF File Offset: 0x00771FDF
		public IVisualNovelPerformanceStopScreenEffectT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.ScreenEffectDa = null;
			this.NullMask = 0;
		}
	}
}
