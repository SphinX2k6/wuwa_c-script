using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200624F RID: 25167
	public class IBvbPlayerOperationTypeT
	{
		// Token: 0x1700BB93 RID: 48019
		// (get) Token: 0x0602B678 RID: 177784 RVA: 0x005F9932 File Offset: 0x005F7B32
		// (set) Token: 0x0602B679 RID: 177785 RVA: 0x005F993A File Offset: 0x005F7B3A
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x0602B67A RID: 177786 RVA: 0x005F9943 File Offset: 0x005F7B43
		public IBvbPlayerOperationTypeT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
		}
	}
}
