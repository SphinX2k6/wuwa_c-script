using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075A8 RID: 30120
	public class IVisualNovelPerformanceEnterBlackScreenT
	{
		// Token: 0x1700E482 RID: 58498
		// (get) Token: 0x06036D18 RID: 224536 RVA: 0x00771107 File Offset: 0x0076F307
		// (set) Token: 0x06036D19 RID: 224537 RVA: 0x0077110F File Offset: 0x0076F30F
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700E483 RID: 58499
		// (get) Token: 0x06036D1A RID: 224538 RVA: 0x00771118 File Offset: 0x0076F318
		// (set) Token: 0x06036D1B RID: 224539 RVA: 0x00771120 File Offset: 0x0076F320
		public float StartTime { get; set; }

		// Token: 0x1700E484 RID: 58500
		// (get) Token: 0x06036D1C RID: 224540 RVA: 0x00771129 File Offset: 0x0076F329
		// (set) Token: 0x06036D1D RID: 224541 RVA: 0x00771131 File Offset: 0x0076F331
		public TEaseCurveTypeUnion EaseCurve { get; set; }

		// Token: 0x1700E485 RID: 58501
		// (get) Token: 0x06036D1E RID: 224542 RVA: 0x0077113A File Offset: 0x0076F33A
		// (set) Token: 0x06036D1F RID: 224543 RVA: 0x00771142 File Offset: 0x0076F342
		public float FadeInTime { get; set; }

		// Token: 0x1700E486 RID: 58502
		// (get) Token: 0x06036D20 RID: 224544 RVA: 0x0077114B File Offset: 0x0076F34B
		// (set) Token: 0x06036D21 RID: 224545 RVA: 0x00771153 File Offset: 0x0076F353
		public EVisualNovelBlackScreenType ScreenType { get; set; }

		// Token: 0x1700E487 RID: 58503
		// (get) Token: 0x06036D22 RID: 224546 RVA: 0x0077115C File Offset: 0x0076F35C
		// (set) Token: 0x06036D23 RID: 224547 RVA: 0x00771164 File Offset: 0x0076F364
		public byte NullMask { get; set; }

		// Token: 0x06036D24 RID: 224548 RVA: 0x0077116D File Offset: 0x0076F36D
		public IVisualNovelPerformanceEnterBlackScreenT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.EaseCurve = null;
			this.FadeInTime = 0f;
			this.ScreenType = EVisualNovelBlackScreenType.Black;
			this.NullMask = 0;
		}
	}
}
