using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020026D5 RID: 9941
public class RacingBetsDungeonBeginCommand : RacingBetsCommandBase
{
	// Token: 0x17001A6E RID: 6766
	// (get) Token: 0x0601462E RID: 83502 RVA: 0x00527D3E File Offset: 0x00525F3E
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.DungeonBegin;
		}
	}

	// Token: 0x0601462F RID: 83503 RVA: 0x00527D44 File Offset: 0x00525F44
	public override UniTask OnExecute()
	{
		RacingBetsDungeonBeginCommand.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsDungeonBeginCommand.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06014630 RID: 83504 RVA: 0x00527D7F File Offset: 0x00525F7F
	[NullableContext(1)]
	public override string LogInfo()
	{
		return "RacingBetsDungeonBeginCommand";
	}
}
