using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059AF RID: 22959
	public class IInitStateStandbyT
	{
		// Token: 0x1700A6B3 RID: 42675
		// (get) Token: 0x06025701 RID: 153345 RVA: 0x00522B97 File Offset: 0x00520D97
		// (set) Token: 0x06025702 RID: 153346 RVA: 0x00522B9F File Offset: 0x00520D9F
		public EInitStateType Type { get; set; }

		// Token: 0x1700A6B4 RID: 42676
		// (get) Token: 0x06025703 RID: 153347 RVA: 0x00522BA8 File Offset: 0x00520DA8
		// (set) Token: 0x06025704 RID: 153348 RVA: 0x00522BB0 File Offset: 0x00520DB0
		public List<string> StandbyTags { get; set; }

		// Token: 0x1700A6B5 RID: 42677
		// (get) Token: 0x06025705 RID: 153349 RVA: 0x00522BB9 File Offset: 0x00520DB9
		// (set) Token: 0x06025706 RID: 153350 RVA: 0x00522BC1 File Offset: 0x00520DC1
		public List<int> EmotionBubbleIds { get; set; }

		// Token: 0x1700A6B6 RID: 42678
		// (get) Token: 0x06025707 RID: 153351 RVA: 0x00522BCA File Offset: 0x00520DCA
		// (set) Token: 0x06025708 RID: 153352 RVA: 0x00522BD2 File Offset: 0x00520DD2
		public List<IConditionGroupT> Conditions { get; set; }

		// Token: 0x1700A6B7 RID: 42679
		// (get) Token: 0x06025709 RID: 153353 RVA: 0x00522BDB File Offset: 0x00520DDB
		// (set) Token: 0x0602570A RID: 153354 RVA: 0x00522BE3 File Offset: 0x00520DE3
		public EAiWanderType Wander { get; set; }

		// Token: 0x1700A6B8 RID: 42680
		// (get) Token: 0x0602570B RID: 153355 RVA: 0x00522BEC File Offset: 0x00520DEC
		// (set) Token: 0x0602570C RID: 153356 RVA: 0x00522BF4 File Offset: 0x00520DF4
		public byte NullMask { get; set; }

		// Token: 0x0602570D RID: 153357 RVA: 0x00522BFD File Offset: 0x00520DFD
		public IInitStateStandbyT()
		{
			this.Type = EInitStateType.Birth;
			this.StandbyTags = null;
			this.EmotionBubbleIds = null;
			this.Conditions = null;
			this.Wander = EAiWanderType.None;
			this.NullMask = 0;
		}
	}
}
