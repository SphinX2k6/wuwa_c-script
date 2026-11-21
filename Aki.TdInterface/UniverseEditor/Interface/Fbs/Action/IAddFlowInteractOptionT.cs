using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200678E RID: 26510
	public class IAddFlowInteractOptionT
	{
		// Token: 0x1700C0C2 RID: 49346
		// (get) Token: 0x0602CF46 RID: 184134 RVA: 0x006250FD File Offset: 0x006232FD
		// (set) Token: 0x0602CF47 RID: 184135 RVA: 0x00625105 File Offset: 0x00623305
		public IInteractOptionT Option { get; set; }

		// Token: 0x1700C0C3 RID: 49347
		// (get) Token: 0x0602CF48 RID: 184136 RVA: 0x0062510E File Offset: 0x0062330E
		// (set) Token: 0x0602CF49 RID: 184137 RVA: 0x00625116 File Offset: 0x00623316
		public int EntityId { get; set; }

		// Token: 0x1700C0C4 RID: 49348
		// (get) Token: 0x0602CF4A RID: 184138 RVA: 0x0062511F File Offset: 0x0062331F
		// (set) Token: 0x0602CF4B RID: 184139 RVA: 0x00625127 File Offset: 0x00623327
		public bool DelayRemoveByQuestEnd { get; set; }

		// Token: 0x1700C0C5 RID: 49349
		// (get) Token: 0x0602CF4C RID: 184140 RVA: 0x00625130 File Offset: 0x00623330
		// (set) Token: 0x0602CF4D RID: 184141 RVA: 0x00625138 File Offset: 0x00623338
		public string InteractToken { get; set; }

		// Token: 0x1700C0C6 RID: 49350
		// (get) Token: 0x0602CF4E RID: 184142 RVA: 0x00625141 File Offset: 0x00623341
		// (set) Token: 0x0602CF4F RID: 184143 RVA: 0x00625149 File Offset: 0x00623349
		public byte NullMask { get; set; }

		// Token: 0x0602CF50 RID: 184144 RVA: 0x00625152 File Offset: 0x00623352
		public IAddFlowInteractOptionT()
		{
			this.Option = null;
			this.EntityId = 0;
			this.DelayRemoveByQuestEnd = false;
			this.InteractToken = null;
			this.NullMask = 0;
		}
	}
}
