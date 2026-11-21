using System;
using CSharpScript.Game.NewWorld.Pawn.Component;

namespace CSharpScript.Game.Utils
{
	// Token: 0x0200347D RID: 13437
	public class TimeScaleUtils
	{
		// Token: 0x06022490 RID: 140432 RVA: 0x009B75CE File Offset: 0x009B57CE
		public static int GetTimeScalePriority(ETimeScaleSourceType type)
		{
			return (int)(type * (ETimeScaleSourceType)100);
		}

		// Token: 0x04012E23 RID: 77347
		private const int PRIORITY_EXTEND = 100;
	}
}
