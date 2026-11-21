using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D6A RID: 19818
	public abstract class PendingProcessControllerRuleConfigBase
	{
		// Token: 0x06031BB7 RID: 203703
		public abstract bool IsActive();

		// Token: 0x06031BB8 RID: 203704
		[NullableContext(1)]
		public abstract bool PendingProgressExCheck(TPendingProcess process);
	}
}
