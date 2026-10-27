using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C0D RID: 27661
	public class OpenSystemRegionQuest : OpenSystemBase
	{
		// Token: 0x0604443C RID: 279612 RVA: 0x010D233E File Offset: 0x010D053E
		[NullableContext(1)]
		public OpenSystemRegionQuest(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604443D RID: 279613 RVA: 0x010D2347 File Offset: 0x010D0547
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.RegionalQuestView);
		}
	}
}
