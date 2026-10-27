using System;
using CSharpScript.Game.NewWorld.Pawn.Component;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02004555 RID: 17749
	public class TimeScaleUtils
	{
		// Token: 0x0602DDAE RID: 187822 RVA: 0x00A8BEB6 File Offset: 0x00A8A0B6
		public static int GetTimeScalePriority(ETimeScaleSourceType type)
		{
			return (int)(type * (ETimeScaleSourceType)100);
		}

		// Token: 0x040187E9 RID: 100329
		private const int PRIORITY_EXTEND = 100;
	}
}
