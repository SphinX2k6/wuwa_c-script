using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001C31 RID: 7217
[NullableContext(2)]
[Nullable(0)]
public class FriendApplyData
{
	// Token: 0x0600D908 RID: 55560 RVA: 0x00324E14 File Offset: 0x00323014
	[NullableContext(1)]
	public UniTask InitializeFriendApply(FriendApply friendApply)
	{
		FriendApplyData.<InitializeFriendApply>d__4 <InitializeFriendApply>d__;
		<InitializeFriendApply>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeFriendApply>d__.<>4__this = this;
		<InitializeFriendApply>d__.friendApply = friendApply;
		<InitializeFriendApply>d__.<>1__state = -1;
		<InitializeFriendApply>d__.<>t__builder.Start<FriendApplyData.<InitializeFriendApply>d__4>(ref <InitializeFriendApply>d__);
		return <InitializeFriendApply>d__.<>t__builder.Task;
	}

	// Token: 0x170011BB RID: 4539
	// (get) Token: 0x0600D909 RID: 55561 RVA: 0x00324E5F File Offset: 0x0032305F
	// (set) Token: 0x0600D90A RID: 55562 RVA: 0x00324E67 File Offset: 0x00323067
	public long ApplyCreatedTime
	{
		get
		{
			return this.CreatedTime;
		}
		set
		{
			this.CreatedTime = value;
		}
	}

	// Token: 0x170011BC RID: 4540
	// (get) Token: 0x0600D90B RID: 55563 RVA: 0x00324E70 File Offset: 0x00323070
	// (set) Token: 0x0600D90C RID: 55564 RVA: 0x00324E78 File Offset: 0x00323078
	public FriendData ApplyPlayerData
	{
		get
		{
			return this.PlayerData;
		}
		set
		{
			this.PlayerData = value;
		}
	}

	// Token: 0x170011BD RID: 4541
	// (get) Token: 0x0600D90D RID: 55565 RVA: 0x00324E81 File Offset: 0x00323081
	// (set) Token: 0x0600D90E RID: 55566 RVA: 0x00324E94 File Offset: 0x00323094
	public double ApplyTimeLeftTime
	{
		get
		{
			return this.ApplyTimeUpTime - TimeUtil.Instance.GetServerTime();
		}
		set
		{
			this.ApplyTimeUpTime = value + (double)FriendModel.Instance.ApplyCdTime;
		}
	}

	// Token: 0x040062E9 RID: 25321
	private FriendData PlayerData;

	// Token: 0x040062EA RID: 25322
	private long CreatedTime;

	// Token: 0x040062EB RID: 25323
	public bool Fresh = true;

	// Token: 0x040062EC RID: 25324
	private double ApplyTimeUpTime;
}
