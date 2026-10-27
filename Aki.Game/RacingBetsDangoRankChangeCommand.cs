using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020026D1 RID: 9937
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDangoRankChangeCommand : RacingBetsCommandBase
{
	// Token: 0x17001A6A RID: 6762
	// (get) Token: 0x06014613 RID: 83475 RVA: 0x005276A2 File Offset: 0x005258A2
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.RankChange;
		}
	}

	// Token: 0x06014614 RID: 83476 RVA: 0x005276A6 File Offset: 0x005258A6
	public void Init(List<int> rankList)
	{
		this.RankList = rankList;
	}

	// Token: 0x06014615 RID: 83477 RVA: 0x005276B0 File Offset: 0x005258B0
	public override UniTask OnExecute()
	{
		RacingBetsDangoRankChangeCommand.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsDangoRankChangeCommand.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06014616 RID: 83478 RVA: 0x005276F3 File Offset: 0x005258F3
	public override string LogInfo()
	{
		return "RacingBetsDangoRankChangeCommand";
	}

	// Token: 0x0400991D RID: 39197
	private List<int> RankList = new List<int>();
}
