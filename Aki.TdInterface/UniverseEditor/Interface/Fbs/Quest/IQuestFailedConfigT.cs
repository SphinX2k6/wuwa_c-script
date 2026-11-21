using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200442B RID: 17451
	public class IQuestFailedConfigT
	{
		// Token: 0x170078D3 RID: 30931
		// (get) Token: 0x06018F72 RID: 102258 RVA: 0x0038F5B8 File Offset: 0x0038D7B8
		// (set) Token: 0x06018F73 RID: 102259 RVA: 0x0038F5C0 File Offset: 0x0038D7C0
		public EOnlineParticipateRule OnlineParticipateRule { get; set; }

		// Token: 0x170078D4 RID: 30932
		// (get) Token: 0x06018F74 RID: 102260 RVA: 0x0038F5C9 File Offset: 0x0038D7C9
		// (set) Token: 0x06018F75 RID: 102261 RVA: 0x0038F5D1 File Offset: 0x0038D7D1
		public byte NullMask { get; set; }

		// Token: 0x06018F76 RID: 102262 RVA: 0x0038F5DA File Offset: 0x0038D7DA
		public IQuestFailedConfigT()
		{
			this.OnlineParticipateRule = EOnlineParticipateRule.AnyPlayer;
			this.NullMask = 0;
		}
	}
}
