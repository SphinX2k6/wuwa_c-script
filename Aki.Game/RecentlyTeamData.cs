using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001C32 RID: 7218
[NullableContext(1)]
[Nullable(0)]
public class RecentlyTeamData
{
	// Token: 0x0600D910 RID: 55568 RVA: 0x00324EB8 File Offset: 0x003230B8
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

	// Token: 0x0600D911 RID: 55569 RVA: 0x00324F04 File Offset: 0x00323104
	public int GetOfflineDay()
	{
		long teamTime = this.TeamTime;
		return TimeUtil.Instance.CalculateDayTimeStampGapBetweenNow((double)teamTime, false);
	}

	// Token: 0x040062ED RID: 25325
	public FriendData PlayerData = new FriendData();

	// Token: 0x040062EE RID: 25326
	public long TeamTime;
}
