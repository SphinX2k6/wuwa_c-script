using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004456 RID: 17494
	public class IDaemonHackPresetCodeT
	{
		// Token: 0x17007B50 RID: 31568
		// (get) Token: 0x0601A0B4 RID: 106676 RVA: 0x003B8C7B File Offset: 0x003B6E7B
		// (set) Token: 0x0601A0B5 RID: 106677 RVA: 0x003B8C83 File Offset: 0x003B6E83
		public string Code { get; set; }

		// Token: 0x17007B51 RID: 31569
		// (get) Token: 0x0601A0B6 RID: 106678 RVA: 0x003B8C8C File Offset: 0x003B6E8C
		// (set) Token: 0x0601A0B7 RID: 106679 RVA: 0x003B8C94 File Offset: 0x003B6E94
		public bool IsCorrect { get; set; }

		// Token: 0x17007B52 RID: 31570
		// (get) Token: 0x0601A0B8 RID: 106680 RVA: 0x003B8C9D File Offset: 0x003B6E9D
		// (set) Token: 0x0601A0B9 RID: 106681 RVA: 0x003B8CA5 File Offset: 0x003B6EA5
		public int Order { get; set; }

		// Token: 0x17007B53 RID: 31571
		// (get) Token: 0x0601A0BA RID: 106682 RVA: 0x003B8CAE File Offset: 0x003B6EAE
		// (set) Token: 0x0601A0BB RID: 106683 RVA: 0x003B8CB6 File Offset: 0x003B6EB6
		public byte NullMask { get; set; }

		// Token: 0x0601A0BC RID: 106684 RVA: 0x003B8CBF File Offset: 0x003B6EBF
		public IDaemonHackPresetCodeT()
		{
			this.Code = null;
			this.IsCorrect = false;
			this.Order = 0;
			this.NullMask = 0;
		}
	}
}
