using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007038 RID: 28728
	public class ISetNpcHandInHandPerformT
	{
		// Token: 0x1700D551 RID: 54609
		// (get) Token: 0x06032D28 RID: 208168 RVA: 0x006DB005 File Offset: 0x006D9205
		// (set) Token: 0x06032D29 RID: 208169 RVA: 0x006DB00D File Offset: 0x006D920D
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700D552 RID: 54610
		// (get) Token: 0x06032D2A RID: 208170 RVA: 0x006DB016 File Offset: 0x006D9216
		// (set) Token: 0x06032D2B RID: 208171 RVA: 0x006DB01E File Offset: 0x006D921E
		public IHandInHandInitiatorT Initiator { get; set; }

		// Token: 0x1700D553 RID: 54611
		// (get) Token: 0x06032D2C RID: 208172 RVA: 0x006DB027 File Offset: 0x006D9227
		// (set) Token: 0x06032D2D RID: 208173 RVA: 0x006DB02F File Offset: 0x006D922F
		public int Follower { get; set; }

		// Token: 0x06032D2E RID: 208174 RVA: 0x006DB038 File Offset: 0x006D9238
		public ISetNpcHandInHandPerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Initiator = null;
			this.Follower = 0;
		}
	}
}
