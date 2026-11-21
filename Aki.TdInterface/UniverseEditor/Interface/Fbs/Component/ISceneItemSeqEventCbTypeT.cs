using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EDE RID: 24286
	public class ISceneItemSeqEventCbTypeT
	{
		// Token: 0x1700B37A RID: 45946
		// (get) Token: 0x06028B76 RID: 166774 RVA: 0x00590C65 File Offset: 0x0058EE65
		// (set) Token: 0x06028B77 RID: 166775 RVA: 0x00590C6D File Offset: 0x0058EE6D
		public ESceneItemSeqEventCbType Type { get; set; }

		// Token: 0x1700B37B RID: 45947
		// (get) Token: 0x06028B78 RID: 166776 RVA: 0x00590C76 File Offset: 0x0058EE76
		// (set) Token: 0x06028B79 RID: 166777 RVA: 0x00590C7E File Offset: 0x0058EE7E
		public string EventName { get; set; }

		// Token: 0x1700B37C RID: 45948
		// (get) Token: 0x06028B7A RID: 166778 RVA: 0x00590C87 File Offset: 0x0058EE87
		// (set) Token: 0x06028B7B RID: 166779 RVA: 0x00590C8F File Offset: 0x0058EE8F
		public IActionInfoT Action { get; set; }

		// Token: 0x06028B7C RID: 166780 RVA: 0x00590C98 File Offset: 0x0058EE98
		public ISceneItemSeqEventCbTypeT()
		{
			this.Type = ESceneItemSeqEventCbType.ANS;
			this.EventName = null;
			this.Action = null;
		}
	}
}
