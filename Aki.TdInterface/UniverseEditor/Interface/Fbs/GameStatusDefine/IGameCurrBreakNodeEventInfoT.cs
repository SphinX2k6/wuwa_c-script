using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B57 RID: 19287
	public class IGameCurrBreakNodeEventInfoT
	{
		// Token: 0x17008810 RID: 34832
		// (get) Token: 0x0601D47C RID: 119932 RVA: 0x0041CB78 File Offset: 0x0041AD78
		// (set) Token: 0x0601D47D RID: 119933 RVA: 0x0041CB80 File Offset: 0x0041AD80
		public long BtConfigId { get; set; }

		// Token: 0x17008811 RID: 34833
		// (get) Token: 0x0601D47E RID: 119934 RVA: 0x0041CB89 File Offset: 0x0041AD89
		// (set) Token: 0x0601D47F RID: 119935 RVA: 0x0041CB91 File Offset: 0x0041AD91
		public TBehaviorTreeType BtEditorType { get; set; }

		// Token: 0x17008812 RID: 34834
		// (get) Token: 0x0601D480 RID: 119936 RVA: 0x0041CB9A File Offset: 0x0041AD9A
		// (set) Token: 0x0601D481 RID: 119937 RVA: 0x0041CBA2 File Offset: 0x0041ADA2
		public int NodeId { get; set; }

		// Token: 0x17008813 RID: 34835
		// (get) Token: 0x0601D482 RID: 119938 RVA: 0x0041CBAB File Offset: 0x0041ADAB
		// (set) Token: 0x0601D483 RID: 119939 RVA: 0x0041CBB3 File Offset: 0x0041ADB3
		public ENodeBreakMoment BreakMoment { get; set; }

		// Token: 0x0601D484 RID: 119940 RVA: 0x0041CBBC File Offset: 0x0041ADBC
		public IGameCurrBreakNodeEventInfoT()
		{
			this.BtConfigId = 0L;
			this.BtEditorType = TBehaviorTreeType.BehaviorTreeFragment;
			this.NodeId = 0;
			this.BreakMoment = ENodeBreakMoment.Null;
		}
	}
}
