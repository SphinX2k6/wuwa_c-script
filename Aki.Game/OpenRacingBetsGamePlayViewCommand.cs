using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020026CA RID: 9930
public class OpenRacingBetsGamePlayViewCommand : RacingBetsCommandBase
{
	// Token: 0x17001A60 RID: 6752
	// (get) Token: 0x060145E0 RID: 83424 RVA: 0x0052717A File Offset: 0x0052537A
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.GamePlayView;
		}
	}

	// Token: 0x060145E1 RID: 83425 RVA: 0x00527180 File Offset: 0x00525380
	public override UniTask OnExecute()
	{
		OpenRacingBetsGamePlayViewCommand.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<OpenRacingBetsGamePlayViewCommand.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x060145E2 RID: 83426 RVA: 0x005271BB File Offset: 0x005253BB
	[NullableContext(1)]
	public override string LogInfo()
	{
		return "OpenRacingBetsGamePlayViewCommand";
	}
}
