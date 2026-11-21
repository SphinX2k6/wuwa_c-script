using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02005F8A RID: 24458
	public class GuaranteeFadeInParams : ActionParams, IGuaranteeFadeInParams
	{
		// Token: 0x17006EF8 RID: 28408
		// (get) Token: 0x0603ACB5 RID: 240821 RVA: 0x0109F7CE File Offset: 0x0109D9CE
		// (set) Token: 0x0603ACB6 RID: 240822 RVA: 0x0109F7D6 File Offset: 0x0109D9D6
		public bool? KeepFadeAfterTreeRollBack { get; set; }
	}
}
