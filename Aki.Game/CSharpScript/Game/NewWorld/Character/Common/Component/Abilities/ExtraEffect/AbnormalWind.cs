using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.ExtraEffect
{
	// Token: 0x02006384 RID: 25476
	[NullableContext(1)]
	[Nullable(0)]
	public class AbnormalWind : PeriodExecution
	{
		// Token: 0x0603DBA2 RID: 252834 RVA: 0x011E2D9B File Offset: 0x011E0F9B
		public AbnormalWind(RequireAndLimits requireAndLimits) : base(requireAndLimits)
		{
		}

		// Token: 0x0603DBA3 RID: 252835 RVA: 0x011E2DA4 File Offset: 0x011E0FA4
		[return: Nullable(2)]
		public override object OnExecute(params object[] args)
		{
			return null;
		}
	}
}
