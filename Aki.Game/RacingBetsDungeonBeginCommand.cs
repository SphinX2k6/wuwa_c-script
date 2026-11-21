using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001BC0 RID: 7104
public class RacingBetsDungeonBeginCommand : RacingBetsCommandBase
{
	// Token: 0x17001AA6 RID: 6822
	// (get) Token: 0x06011B10 RID: 72464 RVA: 0x00536A76 File Offset: 0x00534C76
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.DungeonBegin;
		}
	}

	// Token: 0x06011B11 RID: 72465 RVA: 0x00536A7C File Offset: 0x00534C7C
	public override UniTask OnExecute()
	{
		RacingBetsDungeonBeginCommand.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsDungeonBeginCommand.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06011B12 RID: 72466 RVA: 0x00536AB7 File Offset: 0x00534CB7
	[NullableContext(1)]
	public override string LogInfo()
	{
		return "RacingBetsDungeonBeginCommand";
	}
}
