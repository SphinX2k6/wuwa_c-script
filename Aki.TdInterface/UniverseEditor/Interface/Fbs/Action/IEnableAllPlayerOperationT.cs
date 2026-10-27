using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200664C RID: 26188
	public class IEnableAllPlayerOperationT
	{
		// Token: 0x1700C296 RID: 49814
		// (get) Token: 0x0602D7DB RID: 186331 RVA: 0x0063AF7E File Offset: 0x0063917E
		// (set) Token: 0x0602D7DC RID: 186332 RVA: 0x0063AF86 File Offset: 0x00639186
		public EPlayerOperationType Type { get; set; }

		// Token: 0x1700C297 RID: 49815
		// (get) Token: 0x0602D7DD RID: 186333 RVA: 0x0063AF8F File Offset: 0x0063918F
		// (set) Token: 0x0602D7DE RID: 186334 RVA: 0x0063AF97 File Offset: 0x00639197
		public bool IsUiFadeEffect { get; set; }

		// Token: 0x1700C298 RID: 49816
		// (get) Token: 0x0602D7DF RID: 186335 RVA: 0x0063AFA0 File Offset: 0x006391A0
		// (set) Token: 0x0602D7E0 RID: 186336 RVA: 0x0063AFA8 File Offset: 0x006391A8
		public byte NullMask { get; set; }

		// Token: 0x0602D7E1 RID: 186337 RVA: 0x0063AFB1 File Offset: 0x006391B1
		public IEnableAllPlayerOperationT()
		{
			this.Type = EPlayerOperationType.EnableAll;
			this.IsUiFadeEffect = false;
			this.NullMask = 0;
		}
	}
}
