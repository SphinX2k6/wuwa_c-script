using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D61 RID: 23905
	public class OpenSystemGravityFlip : OpenSystemBase
	{
		// Token: 0x0603A525 RID: 238885 RVA: 0x0107B33F File Offset: 0x0107953F
		[NullableContext(1)]
		public OpenSystemGravityFlip(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A526 RID: 238886 RVA: 0x0107B348 File Offset: 0x01079548
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.GravityFlipView);
		}
	}
}
