using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020010F0 RID: 4336
[NullableContext(2)]
[Nullable(0)]
public class FriendApplyData
{
	// Token: 0x0600AD1E RID: 44318 RVA: 0x00330214 File Offset: 0x0032E414
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

	// Token: 0x170011E1 RID: 4577
	// (get) Token: 0x0600AD1F RID: 44319 RVA: 0x0033025F File Offset: 0x0032E45F
	// (set) Token: 0x0600AD20 RID: 44320 RVA: 0x00330267 File Offset: 0x0032E467
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

	// Token: 0x170011E2 RID: 4578
	// (get) Token: 0x0600AD21 RID: 44321 RVA: 0x00330270 File Offset: 0x0032E470
	// (set) Token: 0x0600AD22 RID: 44322 RVA: 0x00330278 File Offset: 0x0032E478
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

	// Token: 0x170011E3 RID: 4579
	// (get) Token: 0x0600AD23 RID: 44323 RVA: 0x00330281 File Offset: 0x0032E481
	// (set) Token: 0x0600AD24 RID: 44324 RVA: 0x00330294 File Offset: 0x0032E494
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

	// Token: 0x040063BB RID: 25531
	private FriendData PlayerData;

	// Token: 0x040063BC RID: 25532
	private long CreatedTime;

	// Token: 0x040063BD RID: 25533
	public bool Fresh = true;

	// Token: 0x040063BE RID: 25534
	private double ApplyTimeUpTime;
}
