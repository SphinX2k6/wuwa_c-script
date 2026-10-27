using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02006E03 RID: 28163
	public class GuaranteeActionInfo : ActionParams
	{
		// Token: 0x04023BDE RID: 146398
		public EGuaranteeAction Name;

		// Token: 0x04023BDF RID: 146399
		[Nullable(2)]
		public ActionParams Params;
	}
}
