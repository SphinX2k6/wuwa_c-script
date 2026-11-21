using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B63 RID: 19299
	public class IHideRangeSourceT
	{
		// Token: 0x17008832 RID: 34866
		// (get) Token: 0x0601D51C RID: 120092 RVA: 0x0041DE8C File Offset: 0x0041C08C
		// (set) Token: 0x0601D51D RID: 120093 RVA: 0x0041DE94 File Offset: 0x0041C094
		public TBehaviorTreeType TreeType { get; set; }

		// Token: 0x17008833 RID: 34867
		// (get) Token: 0x0601D51E RID: 120094 RVA: 0x0041DE9D File Offset: 0x0041C09D
		// (set) Token: 0x0601D51F RID: 120095 RVA: 0x0041DEA5 File Offset: 0x0041C0A5
		public int TreeId { get; set; }

		// Token: 0x17008834 RID: 34868
		// (get) Token: 0x0601D520 RID: 120096 RVA: 0x0041DEAE File Offset: 0x0041C0AE
		// (set) Token: 0x0601D521 RID: 120097 RVA: 0x0041DEB6 File Offset: 0x0041C0B6
		public int LevelId { get; set; }

		// Token: 0x17008835 RID: 34869
		// (get) Token: 0x0601D522 RID: 120098 RVA: 0x0041DEBF File Offset: 0x0041C0BF
		// (set) Token: 0x0601D523 RID: 120099 RVA: 0x0041DEC7 File Offset: 0x0041C0C7
		public int NodeId { get; set; }

		// Token: 0x17008836 RID: 34870
		// (get) Token: 0x0601D524 RID: 120100 RVA: 0x0041DED0 File Offset: 0x0041C0D0
		// (set) Token: 0x0601D525 RID: 120101 RVA: 0x0041DED8 File Offset: 0x0041C0D8
		public int ActionId { get; set; }

		// Token: 0x17008837 RID: 34871
		// (get) Token: 0x0601D526 RID: 120102 RVA: 0x0041DEE1 File Offset: 0x0041C0E1
		// (set) Token: 0x0601D527 RID: 120103 RVA: 0x0041DEE9 File Offset: 0x0041C0E9
		public byte NullMask { get; set; }

		// Token: 0x0601D528 RID: 120104 RVA: 0x0041DEF2 File Offset: 0x0041C0F2
		public IHideRangeSourceT()
		{
			this.TreeType = TBehaviorTreeType.BehaviorTreeFragment;
			this.TreeId = 0;
			this.LevelId = 0;
			this.NodeId = 0;
			this.ActionId = 0;
			this.NullMask = 0;
		}
	}
}
