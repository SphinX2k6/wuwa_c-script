using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E29 RID: 28201
	public class IReignsChangePlayerNameT
	{
		// Token: 0x1700D22F RID: 53807
		// (get) Token: 0x06031D4B RID: 204107 RVA: 0x006BECA9 File Offset: 0x006BCEA9
		// (set) Token: 0x06031D4C RID: 204108 RVA: 0x006BECB1 File Offset: 0x006BCEB1
		public string PlayerNameId { get; set; }

		// Token: 0x06031D4D RID: 204109 RVA: 0x006BECBA File Offset: 0x006BCEBA
		public IReignsChangePlayerNameT()
		{
			this.PlayerNameId = null;
		}
	}
}
