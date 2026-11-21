using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020010F1 RID: 4337
[NullableContext(1)]
[Nullable(0)]
public class RecentlyTeamData
{
	// Token: 0x0600AD26 RID: 44326 RVA: 0x003302B8 File Offset: 0x0032E4B8
	public UniTask InitData(RecentlyTeamInfo data)
	{
		RecentlyTeamData.<InitData>d__2 <InitData>d__;
		<InitData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitData>d__.<>4__this = this;
		<InitData>d__.data = data;
		<InitData>d__.<>1__state = -1;
		<InitData>d__.<>t__builder.Start<RecentlyTeamData.<InitData>d__2>(ref <InitData>d__);
		return <InitData>d__.<>t__builder.Task;
	}

	// Token: 0x0600AD27 RID: 44327 RVA: 0x00330304 File Offset: 0x0032E504
	public int GetOfflineDay()
	{
		long teamTime = this.TeamTime;
		return TimeUtil.Instance.CalculateDayTimeStampGapBetweenNow((double)teamTime, false);
	}

	// Token: 0x040063BF RID: 25535
	public FriendData PlayerData = new FriendData();

	// Token: 0x040063C0 RID: 25536
	public long TeamTime;
}
