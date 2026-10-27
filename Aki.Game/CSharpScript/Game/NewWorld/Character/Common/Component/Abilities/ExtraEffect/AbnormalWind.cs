using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.ExtraEffect
{
	// Token: 0x02007156 RID: 29014
	[NullableContext(1)]
	[Nullable(0)]
	public class AbnormalWind : PeriodExecution
	{
		// Token: 0x06046D48 RID: 290120 RVA: 0x011D9BBF File Offset: 0x011D7DBF
		public AbnormalWind(RequireAndLimits requireAndLimits) : base(requireAndLimits)
		{
		}

		// Token: 0x06046D49 RID: 290121 RVA: 0x011D9BC8 File Offset: 0x011D7DC8
		[return: Nullable(2)]
		public override object OnExecute(params object[] args)
		{
			return null;
		}
	}
}
