using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A80 RID: 31360
	public class ITalkEffectActionTypeT
	{
		// Token: 0x1700E5B5 RID: 58805
		// (get) Token: 0x0603746D RID: 226413 RVA: 0x00761952 File Offset: 0x0075FB52
		// (set) Token: 0x0603746E RID: 226414 RVA: 0x0076195A File Offset: 0x0075FB5A
		public ETalkEffectActionType Type { get; set; }

		// Token: 0x0603746F RID: 226415 RVA: 0x00761963 File Offset: 0x0075FB63
		public ITalkEffectActionTypeT()
		{
			this.Type = ETalkEffectActionType.Play;
		}
	}
}
