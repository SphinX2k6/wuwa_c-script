using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.ExtraEffect
{
	// Token: 0x02006385 RID: 25477
	[NullableContext(1)]
	[Nullable(0)]
	public class AbnormalLight : PeriodExecution
	{
		// Token: 0x0603DBA4 RID: 252836 RVA: 0x011E2DA7 File Offset: 0x011E0FA7
		public AbnormalLight(RequireAndLimits requireAndLimits) : base(requireAndLimits)
		{
		}

		// Token: 0x0603DBA5 RID: 252837 RVA: 0x011E2DB0 File Offset: 0x011E0FB0
		[return: Nullable(2)]
		public override object OnExecute(params object[] args)
		{
			return null;
		}
	}
}
