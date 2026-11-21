using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A2F RID: 31279
	public class ISwitchEffectStateT
	{
		// Token: 0x1700E530 RID: 58672
		// (get) Token: 0x060371EC RID: 225772 RVA: 0x0075D637 File Offset: 0x0075B837
		// (set) Token: 0x060371ED RID: 225773 RVA: 0x0075D63F File Offset: 0x0075B83F
		public EEffectType Type { get; set; }

		// Token: 0x1700E531 RID: 58673
		// (get) Token: 0x060371EE RID: 225774 RVA: 0x0075D648 File Offset: 0x0075B848
		// (set) Token: 0x060371EF RID: 225775 RVA: 0x0075D650 File Offset: 0x0075B850
		public string Path { get; set; }

		// Token: 0x1700E532 RID: 58674
		// (get) Token: 0x060371F0 RID: 225776 RVA: 0x0075D659 File Offset: 0x0075B859
		// (set) Token: 0x060371F1 RID: 225777 RVA: 0x0075D661 File Offset: 0x0075B861
		public TSwitchEffectStateEffectTypeUnion EffectType { get; set; }

		// Token: 0x1700E533 RID: 58675
		// (get) Token: 0x060371F2 RID: 225778 RVA: 0x0075D66A File Offset: 0x0075B86A
		// (set) Token: 0x060371F3 RID: 225779 RVA: 0x0075D672 File Offset: 0x0075B872
		public int TargetStateIndex { get; set; }

		// Token: 0x060371F4 RID: 225780 RVA: 0x0075D67B File Offset: 0x0075B87B
		public ISwitchEffectStateT()
		{
			this.Type = EEffectType.Effect;
			this.Path = null;
			this.EffectType = null;
			this.TargetStateIndex = 0;
		}
	}
}
