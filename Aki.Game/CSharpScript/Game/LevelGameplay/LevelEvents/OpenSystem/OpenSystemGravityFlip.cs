using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BE8 RID: 27624
	public class OpenSystemGravityFlip : OpenSystemBase
	{
		// Token: 0x060443CD RID: 279501 RVA: 0x010D13EB File Offset: 0x010CF5EB
		[NullableContext(1)]
		public OpenSystemGravityFlip(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443CE RID: 279502 RVA: 0x010D13F4 File Offset: 0x010CF5F4
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.GravityFlipView);
		}
	}
}
