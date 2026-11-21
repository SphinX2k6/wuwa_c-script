using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001BB5 RID: 7093
public class OpenRacingBetsGamePlayViewCommand : RacingBetsCommandBase
{
	// Token: 0x17001A98 RID: 6808
	// (get) Token: 0x06011AC2 RID: 72386 RVA: 0x00535EB2 File Offset: 0x005340B2
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.GamePlayView;
		}
	}

	// Token: 0x06011AC3 RID: 72387 RVA: 0x00535EB8 File Offset: 0x005340B8
	public override UniTask OnExecute()
	{
		OpenRacingBetsGamePlayViewCommand.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<OpenRacingBetsGamePlayViewCommand.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06011AC4 RID: 72388 RVA: 0x00535EF3 File Offset: 0x005340F3
	[NullableContext(1)]
	public override string LogInfo()
	{
		return "OpenRacingBetsGamePlayViewCommand";
	}
}
