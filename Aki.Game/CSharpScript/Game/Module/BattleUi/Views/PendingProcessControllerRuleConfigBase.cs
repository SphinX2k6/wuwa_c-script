using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D88 RID: 23944
	public abstract class PendingProcessControllerRuleConfigBase
	{
		// Token: 0x0603CC5B RID: 248923
		public abstract bool IsActive();

		// Token: 0x0603CC5C RID: 248924
		[NullableContext(1)]
		public abstract bool PendingProgressExCheck(TPendingProcess process);
	}
}
