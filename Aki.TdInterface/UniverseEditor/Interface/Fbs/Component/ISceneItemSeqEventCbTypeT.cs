using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058D1 RID: 22737
	public class ISceneItemSeqEventCbTypeT
	{
		// Token: 0x1700AA4A RID: 43594
		// (get) Token: 0x06026614 RID: 157204 RVA: 0x0054A119 File Offset: 0x00548319
		// (set) Token: 0x06026615 RID: 157205 RVA: 0x0054A121 File Offset: 0x00548321
		public ESceneItemSeqEventCbType Type { get; set; }

		// Token: 0x1700AA4B RID: 43595
		// (get) Token: 0x06026616 RID: 157206 RVA: 0x0054A12A File Offset: 0x0054832A
		// (set) Token: 0x06026617 RID: 157207 RVA: 0x0054A132 File Offset: 0x00548332
		public string EventName { get; set; }

		// Token: 0x1700AA4C RID: 43596
		// (get) Token: 0x06026618 RID: 157208 RVA: 0x0054A13B File Offset: 0x0054833B
		// (set) Token: 0x06026619 RID: 157209 RVA: 0x0054A143 File Offset: 0x00548343
		public IActionInfoT Action { get; set; }

		// Token: 0x0602661A RID: 157210 RVA: 0x0054A14C File Offset: 0x0054834C
		public ISceneItemSeqEventCbTypeT()
		{
			this.Type = ESceneItemSeqEventCbType.ANS;
			this.EventName = null;
			this.Action = null;
		}
	}
}
