using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BC4 RID: 7108
public class RacingBetsRoundStartCommand : RacingBetsCommandBase
{
	// Token: 0x17001AAA RID: 6826
	// (get) Token: 0x06011B28 RID: 72488 RVA: 0x00537276 File Offset: 0x00535476
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.RoundStart;
		}
	}

	// Token: 0x06011B29 RID: 72489 RVA: 0x00537279 File Offset: 0x00535479
	[NullableContext(1)]
	public override string LogInfo()
	{
		return "RacingBetsRoundStartCommand";
	}
}
