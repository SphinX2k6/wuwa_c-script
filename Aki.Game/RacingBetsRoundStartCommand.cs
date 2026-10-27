using System;
using System.Runtime.CompilerServices;

// Token: 0x020026D9 RID: 9945
public class RacingBetsRoundStartCommand : RacingBetsCommandBase
{
	// Token: 0x17001A72 RID: 6770
	// (get) Token: 0x06014646 RID: 83526 RVA: 0x0052853E File Offset: 0x0052673E
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.RoundStart;
		}
	}

	// Token: 0x06014647 RID: 83527 RVA: 0x00528541 File Offset: 0x00526741
	[NullableContext(1)]
	public override string LogInfo()
	{
		return "RacingBetsRoundStartCommand";
	}
}
