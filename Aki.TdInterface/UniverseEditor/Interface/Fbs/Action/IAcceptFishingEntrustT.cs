using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066D1 RID: 26321
	public class IAcceptFishingEntrustT
	{
		// Token: 0x1700BF56 RID: 48982
		// (get) Token: 0x0602C392 RID: 181138 RVA: 0x00605B06 File Offset: 0x00603D06
		// (set) Token: 0x0602C393 RID: 181139 RVA: 0x00605B0E File Offset: 0x00603D0E
		public int EntrustId { get; set; }

		// Token: 0x1700BF57 RID: 48983
		// (get) Token: 0x0602C394 RID: 181140 RVA: 0x00605B17 File Offset: 0x00603D17
		// (set) Token: 0x0602C395 RID: 181141 RVA: 0x00605B1F File Offset: 0x00603D1F
		public bool IsAutoTracking { get; set; }

		// Token: 0x1700BF58 RID: 48984
		// (get) Token: 0x0602C396 RID: 181142 RVA: 0x00605B28 File Offset: 0x00603D28
		// (set) Token: 0x0602C397 RID: 181143 RVA: 0x00605B30 File Offset: 0x00603D30
		public byte NullMask { get; set; }

		// Token: 0x0602C398 RID: 181144 RVA: 0x00605B39 File Offset: 0x00603D39
		public IAcceptFishingEntrustT()
		{
			this.EntrustId = 0;
			this.IsAutoTracking = false;
			this.NullMask = 0;
		}
	}
}
