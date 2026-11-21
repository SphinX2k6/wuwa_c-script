using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D86 RID: 23942
	public class OpenSystemRegionQuest : OpenSystemBase
	{
		// Token: 0x0603A594 RID: 238996 RVA: 0x0107C292 File Offset: 0x0107A492
		[NullableContext(1)]
		public OpenSystemRegionQuest(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A595 RID: 238997 RVA: 0x0107C29B File Offset: 0x0107A49B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.RegionalQuestView);
		}
	}
}
