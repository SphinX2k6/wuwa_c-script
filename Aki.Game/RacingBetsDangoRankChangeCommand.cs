using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001BBC RID: 7100
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDangoRankChangeCommand : RacingBetsCommandBase
{
	// Token: 0x17001AA2 RID: 6818
	// (get) Token: 0x06011AF5 RID: 72437 RVA: 0x005363DA File Offset: 0x005345DA
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.RankChange;
		}
	}

	// Token: 0x06011AF6 RID: 72438 RVA: 0x005363DE File Offset: 0x005345DE
	public void Init(List<int> rankList)
	{
		this.RankList = rankList;
	}

	// Token: 0x06011AF7 RID: 72439 RVA: 0x005363E8 File Offset: 0x005345E8
	public override UniTask OnExecute()
	{
		RacingBetsDangoRankChangeCommand.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsDangoRankChangeCommand.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06011AF8 RID: 72440 RVA: 0x0053642B File Offset: 0x0053462B
	public override string LogInfo()
	{
		return "RacingBetsDangoRankChangeCommand";
	}

	// Token: 0x04009A75 RID: 39541
	private List<int> RankList = new List<int>();
}
