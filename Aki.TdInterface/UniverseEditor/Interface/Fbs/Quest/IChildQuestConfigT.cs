using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041A3 RID: 16803
	public class IChildQuestConfigT
	{
		// Token: 0x17007210 RID: 29200
		// (get) Token: 0x0601733A RID: 95034 RVA: 0x003500B4 File Offset: 0x0034E2B4
		// (set) Token: 0x0601733B RID: 95035 RVA: 0x003500BC File Offset: 0x0034E2BC
		public EOnlineParticipateRule OnlineParticipateRule { get; set; }

		// Token: 0x17007211 RID: 29201
		// (get) Token: 0x0601733C RID: 95036 RVA: 0x003500C5 File Offset: 0x0034E2C5
		// (set) Token: 0x0601733D RID: 95037 RVA: 0x003500CD File Offset: 0x0034E2CD
		public byte NullMask { get; set; }

		// Token: 0x0601733E RID: 95038 RVA: 0x003500D6 File Offset: 0x0034E2D6
		public IChildQuestConfigT()
		{
			this.OnlineParticipateRule = EOnlineParticipateRule.AnyPlayer;
			this.NullMask = 0;
		}
	}
}
