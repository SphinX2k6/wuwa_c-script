using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200646F RID: 25711
	public class ICommonBtOverrideTaskInfoBaseT
	{
		// Token: 0x1700BF55 RID: 48981
		// (get) Token: 0x0602C88D RID: 182413 RVA: 0x0061D576 File Offset: 0x0061B776
		// (set) Token: 0x0602C88E RID: 182414 RVA: 0x0061D57E File Offset: 0x0061B77E
		public ECommonBtPlaceholderTargetType Type { get; set; }

		// Token: 0x0602C88F RID: 182415 RVA: 0x0061D587 File Offset: 0x0061B787
		public ICommonBtOverrideTaskInfoBaseT()
		{
			this.Type = ECommonBtPlaceholderTargetType.Action;
		}
	}
}
