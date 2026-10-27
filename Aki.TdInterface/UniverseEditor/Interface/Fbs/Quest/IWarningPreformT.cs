using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200428D RID: 17037
	public class IWarningPreformT
	{
		// Token: 0x170078FF RID: 30975
		// (get) Token: 0x060193E1 RID: 103393 RVA: 0x003A063D File Offset: 0x0039E83D
		// (set) Token: 0x060193E2 RID: 103394 RVA: 0x003A0645 File Offset: 0x0039E845
		public TWarningPreformConfigUnion Type { get; set; }

		// Token: 0x060193E3 RID: 103395 RVA: 0x003A064E File Offset: 0x0039E84E
		public IWarningPreformT()
		{
			this.Type = null;
		}
	}
}
