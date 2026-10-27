using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.ExtraEffect
{
	// Token: 0x02007157 RID: 29015
	[NullableContext(1)]
	[Nullable(0)]
	public class AbnormalLight : PeriodExecution
	{
		// Token: 0x06046D4A RID: 290122 RVA: 0x011D9BCB File Offset: 0x011D7DCB
		public AbnormalLight(RequireAndLimits requireAndLimits) : base(requireAndLimits)
		{
		}

		// Token: 0x06046D4B RID: 290123 RVA: 0x011D9BD4 File Offset: 0x011D7DD4
		[return: Nullable(2)]
		public override object OnExecute(params object[] args)
		{
			return null;
		}
	}
}
