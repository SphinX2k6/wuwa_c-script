using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D49 RID: 23881
	public class OpenSystemContributionLevel : OpenSystemBase
	{
		// Token: 0x0603A4DE RID: 238814 RVA: 0x0107A9C0 File Offset: 0x01078BC0
		[NullableContext(1)]
		public OpenSystemContributionLevel(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A4DF RID: 238815 RVA: 0x0107A9C9 File Offset: 0x01078BC9
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.RegionalQuestView);
		}
	}
}
