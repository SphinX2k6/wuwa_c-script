using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053DD RID: 21469
	public class IAnsEventT
	{
		// Token: 0x170097EE RID: 38894
		// (get) Token: 0x060218AD RID: 137389 RVA: 0x004A023F File Offset: 0x0049E43F
		// (set) Token: 0x060218AE RID: 137390 RVA: 0x004A0247 File Offset: 0x0049E447
		public ESceneItemSeqEventCbType Type { get; set; }

		// Token: 0x170097EF RID: 38895
		// (get) Token: 0x060218AF RID: 137391 RVA: 0x004A0250 File Offset: 0x0049E450
		// (set) Token: 0x060218B0 RID: 137392 RVA: 0x004A0258 File Offset: 0x0049E458
		public string EventName { get; set; }

		// Token: 0x170097F0 RID: 38896
		// (get) Token: 0x060218B1 RID: 137393 RVA: 0x004A0261 File Offset: 0x0049E461
		// (set) Token: 0x060218B2 RID: 137394 RVA: 0x004A0269 File Offset: 0x0049E469
		public IActionInfoT Action { get; set; }

		// Token: 0x170097F1 RID: 38897
		// (get) Token: 0x060218B3 RID: 137395 RVA: 0x004A0272 File Offset: 0x0049E472
		// (set) Token: 0x060218B4 RID: 137396 RVA: 0x004A027A File Offset: 0x0049E47A
		public float Duration { get; set; }

		// Token: 0x060218B5 RID: 137397 RVA: 0x004A0283 File Offset: 0x0049E483
		public IAnsEventT()
		{
			this.Type = ESceneItemSeqEventCbType.ANS;
			this.EventName = null;
			this.Action = null;
			this.Duration = 0f;
		}
	}
}
