using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BD0 RID: 27600
	public class OpenSystemContributionLevel : OpenSystemBase
	{
		// Token: 0x06044386 RID: 279430 RVA: 0x010D0A6C File Offset: 0x010CEC6C
		[NullableContext(1)]
		public OpenSystemContributionLevel(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044387 RID: 279431 RVA: 0x010D0A75 File Offset: 0x010CEC75
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.RegionalQuestView);
		}
	}
}
