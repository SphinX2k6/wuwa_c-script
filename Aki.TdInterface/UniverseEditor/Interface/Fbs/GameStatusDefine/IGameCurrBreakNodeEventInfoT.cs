using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046EF RID: 18159
	public class IGameCurrBreakNodeEventInfoT
	{
		// Token: 0x170081CF RID: 33231
		// (get) Token: 0x0601BCA7 RID: 113831 RVA: 0x003F08DC File Offset: 0x003EEADC
		// (set) Token: 0x0601BCA8 RID: 113832 RVA: 0x003F08E4 File Offset: 0x003EEAE4
		public long BtConfigId { get; set; }

		// Token: 0x170081D0 RID: 33232
		// (get) Token: 0x0601BCA9 RID: 113833 RVA: 0x003F08ED File Offset: 0x003EEAED
		// (set) Token: 0x0601BCAA RID: 113834 RVA: 0x003F08F5 File Offset: 0x003EEAF5
		public TBehaviorTreeType BtEditorType { get; set; }

		// Token: 0x170081D1 RID: 33233
		// (get) Token: 0x0601BCAB RID: 113835 RVA: 0x003F08FE File Offset: 0x003EEAFE
		// (set) Token: 0x0601BCAC RID: 113836 RVA: 0x003F0906 File Offset: 0x003EEB06
		public int NodeId { get; set; }

		// Token: 0x170081D2 RID: 33234
		// (get) Token: 0x0601BCAD RID: 113837 RVA: 0x003F090F File Offset: 0x003EEB0F
		// (set) Token: 0x0601BCAE RID: 113838 RVA: 0x003F0917 File Offset: 0x003EEB17
		public ENodeBreakMoment BreakMoment { get; set; }

		// Token: 0x0601BCAF RID: 113839 RVA: 0x003F0920 File Offset: 0x003EEB20
		public IGameCurrBreakNodeEventInfoT()
		{
			this.BtConfigId = 0L;
			this.BtEditorType = TBehaviorTreeType.BehaviorTreeFragment;
			this.NodeId = 0;
			this.BreakMoment = ENodeBreakMoment.Null;
		}
	}
}
