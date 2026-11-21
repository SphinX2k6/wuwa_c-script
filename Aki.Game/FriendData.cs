using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020010F2 RID: 4338
[NullableContext(1)]
[Nullable(0)]
public class FriendData : IPlayerData
{
	// Token: 0x170011E4 RID: 4580
	// (get) Token: 0x0600AD29 RID: 44329 RVA: 0x00330338 File Offset: 0x0032E538
	// (set) Token: 0x0600AD2A RID: 44330 RVA: 0x00330340 File Offset: 0x0032E540
	public string Signature { get; set; } = "";

	// Token: 0x0600AD2B RID: 44331 RVA: 0x0033034C File Offset: 0x0032E54C
	public UniTask SetFriendDataAttribute(FriendInfo friendInfo)
	{
		FriendData.<SetFriendDataAttribute>d__30 <SetFriendDataAttribute>d__;
		<SetFriendDataAttribute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetFriendDataAttribute>d__.<>4__this = this;
		<SetFriendDataAttribute>d__.friendInfo = friendInfo;
		<SetFriendDataAttribute>d__.<>1__state = -1;
		<SetFriendDataAttribute>d__.<>t__builder.Start<FriendData.<SetFriendDataAttribute>d__30>(ref <SetFriendDataAttribute>d__);
		return <SetFriendDataAttribute>d__.<>t__builder.Task;
	}

	// Token: 0x0600AD2C RID: 44332 RVA: 0x00330398 File Offset: 0x0032E598
	public UniTask SetPlayerBasicInfo(PlayerDetails friendInfo)
	{
		FriendData.<SetPlayerBasicInfo>d__31 <SetPlayerBasicInfo>d__;
		<SetPlayerBasicInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetPlayerBasicInfo>d__.<>4__this = this;
		<SetPlayerBasicInfo>d__.friendInfo = friendInfo;
		<SetPlayerBasicInfo>d__.<>1__state = -1;
		<SetPlayerBasicInfo>d__.<>t__builder.Start<FriendData.<SetPlayerBasicInfo>d__31>(ref <SetPlayerBasicInfo>d__);
		return <SetPlayerBasicInfo>d__.<>t__builder.Task;
	}

	// Token: 0x0600AD2D RID: 44333 RVA: 0x003303E4 File Offset: 0x0032E5E4
	public UniTask RefreshSdkBlockState()
	{
		FriendData.<RefreshSdkBlockState>d__32 <RefreshSdkBlockState>d__;
		<RefreshSdkBlockState>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSdkBlockState>d__.<>4__this = this;
		<RefreshSdkBlockState>d__.<>1__state = -1;
		<RefreshSdkBlockState>d__.<>t__builder.Start<FriendData.<RefreshSdkBlockState>d__32>(ref <RefreshSdkBlockState>d__);
		return <RefreshSdkBlockState>d__.<>t__builder.Task;
	}

	// Token: 0x170011E5 RID: 4581
	// (get) Token: 0x0600AD2E RID: 44334 RVA: 0x00330427 File Offset: 0x0032E627
	// (set) Token: 0x0600AD2F RID: 44335 RVA: 0x0033042F File Offset: 0x0032E62F
	public int PlayerId
	{
		get
		{
			return this.Id;
		}
		set
		{
			this.Id = value;
		}
	}

	// Token: 0x170011E6 RID: 4582
	// (get) Token: 0x0600AD30 RID: 44336 RVA: 0x00330438 File Offset: 0x0032E638
	// (set) Token: 0x0600AD31 RID: 44337 RVA: 0x00330440 File Offset: 0x0032E640
	public string PlayerName
	{
		get
		{
			return this.Name;
		}
		set
		{
			this.Name = value;
		}
	}

	// Token: 0x170011E7 RID: 4583
	// (get) Token: 0x0600AD32 RID: 44338 RVA: 0x00330449 File Offset: 0x0032E649
	// (set) Token: 0x0600AD33 RID: 44339 RVA: 0x00330451 File Offset: 0x0032E651
	public int PlayerLevel
	{
		get
		{
			return this.Level;
		}
		set
		{
			this.Level = value;
		}
	}

	// Token: 0x170011E8 RID: 4584
	// (get) Token: 0x0600AD34 RID: 44340 RVA: 0x0033045A File Offset: 0x0032E65A
	public int PlayerHeadPhoto
	{
		get
		{
			return this.HeadPhoto;
		}
	}

	// Token: 0x170011E9 RID: 4585
	// (get) Token: 0x0600AD35 RID: 44341 RVA: 0x00330462 File Offset: 0x0032E662
	public int PlayerHeadFrame
	{
		get
		{
			return this.HeadFrame;
		}
	}

	// Token: 0x170011EA RID: 4586
	// (get) Token: 0x0600AD36 RID: 44342 RVA: 0x0033046A File Offset: 0x0032E66A
	public int PlayerTitleId
	{
		get
		{
			return this.TitleId;
		}
	}

	// Token: 0x170011EB RID: 4587
	// (get) Token: 0x0600AD37 RID: 44343 RVA: 0x00330472 File Offset: 0x0032E672
	public int PlayerTitleStarLevel
	{
		get
		{
			return this.TitleStarLevel;
		}
	}

	// Token: 0x170011EC RID: 4588
	// (get) Token: 0x0600AD38 RID: 44344 RVA: 0x0033047A File Offset: 0x0032E67A
	public int PlayerSex
	{
		get
		{
			return this.Sex;
		}
	}

	// Token: 0x170011ED RID: 4589
	// (get) Token: 0x0600AD39 RID: 44345 RVA: 0x00330482 File Offset: 0x0032E682
	// (set) Token: 0x0600AD3A RID: 44346 RVA: 0x0033048A File Offset: 0x0032E68A
	public bool PlayerIsOnline
	{
		get
		{
			return this.IsOnline;
		}
		set
		{
			this.IsOnline = value;
		}
	}

	// Token: 0x170011EE RID: 4590
	// (get) Token: 0x0600AD3B RID: 44347 RVA: 0x00330493 File Offset: 0x0032E693
	// (set) Token: 0x0600AD3C RID: 44348 RVA: 0x0033049B File Offset: 0x0032E69B
	public long PlayerLastOfflineTime
	{
		get
		{
			return this.LastOfflineTime;
		}
		set
		{
			this.LastOfflineTime = value;
		}
	}

	// Token: 0x0600AD3D RID: 44349 RVA: 0x003304A4 File Offset: 0x0032E6A4
	public int GetOfflineDay()
	{
		long playerLastOfflineTime = this.PlayerLastOfflineTime;
		return TimeUtil.Instance.CalculateDayTimeStampGapBetweenNow((double)playerLastOfflineTime, false);
	}

	// Token: 0x170011EF RID: 4591
	// (get) Token: 0x0600AD3E RID: 44350 RVA: 0x003304C5 File Offset: 0x0032E6C5
	// (set) Token: 0x0600AD3F RID: 44351 RVA: 0x003304CD File Offset: 0x0032E6CD
	[Nullable(2)]
	public string FriendRemark
	{
		[NullableContext(2)]
		get
		{
			return this.Remark;
		}
		[NullableContext(2)]
		set
		{
			this.Remark = value;
		}
	}

	// Token: 0x170011F0 RID: 4592
	// (get) Token: 0x0600AD40 RID: 44352 RVA: 0x003304D6 File Offset: 0x0032E6D6
	public bool IsDeactivation
	{
		get
		{
			return this.Deactivation;
		}
	}

	// Token: 0x0600AD41 RID: 44353 RVA: 0x003304DE File Offset: 0x0032E6DE
	[NullableContext(2)]
	public string GetSdkOnlineId()
	{
		return this.SdkOnlineId;
	}

	// Token: 0x0600AD42 RID: 44354 RVA: 0x003304E6 File Offset: 0x0032E6E6
	public string GetSdkUserId()
	{
		return this.SdkUserId;
	}

	// Token: 0x0600AD43 RID: 44355 RVA: 0x003304EE File Offset: 0x0032E6EE
	public string GetAvoidId()
	{
		return this.SdkAvoidId;
	}

	// Token: 0x0600AD44 RID: 44356 RVA: 0x003304F8 File Offset: 0x0032E6F8
	public bool IfSdkCanShowFriend()
	{
		bool sdkFriendOnlyState = KuroSdkController.Instance.GetSdkFriendOnlyState();
		bool flag = KuroSdkController.Instance.PlayOnly();
		return (!sdkFriendOnlyState && !flag) || (!sdkFriendOnlyState && !flag) || !(this.SdkUserId == "");
	}

	// Token: 0x0600AD45 RID: 44357 RVA: 0x0033053E File Offset: 0x0032E73E
	public bool GetBlockBySdk()
	{
		return this.BlockBySdk;
	}

	// Token: 0x0600AD46 RID: 44358 RVA: 0x00330546 File Offset: 0x0032E746
	public bool CanShowInFriendList()
	{
		return !this.GetBlockBySdk() && this.IfSdkCanShowFriend();
	}

	// Token: 0x040063C1 RID: 25537
	private int Id;

	// Token: 0x040063C2 RID: 25538
	private string Name = "";

	// Token: 0x040063C3 RID: 25539
	private int Level;

	// Token: 0x040063C4 RID: 25540
	private int HeadPhoto;

	// Token: 0x040063C5 RID: 25541
	private int HeadFrame;

	// Token: 0x040063C6 RID: 25542
	private int TitleId;

	// Token: 0x040063C7 RID: 25543
	private int TitleStarLevel;

	// Token: 0x040063C8 RID: 25544
	private int Sex;

	// Token: 0x040063C9 RID: 25545
	private bool IsOnline;

	// Token: 0x040063CA RID: 25546
	private long LastOfflineTime;

	// Token: 0x040063CB RID: 25547
	[Nullable(2)]
	private string Remark;

	// Token: 0x040063CC RID: 25548
	public bool Debug;

	// Token: 0x040063CD RID: 25549
	public int WorldLevel;

	// Token: 0x040063CE RID: 25550
	public int TeamMemberCount;

	// Token: 0x040063D0 RID: 25552
	public int CurCard;

	// Token: 0x040063D1 RID: 25553
	public List<global::RoleShowEntry> RoleShowList = new List<global::RoleShowEntry>();

	// Token: 0x040063D2 RID: 25554
	public List<int> CardShowList = new List<int>();

	// Token: 0x040063D3 RID: 25555
	public int Birthday;

	// Token: 0x040063D4 RID: 25556
	public bool IsBirthdayDisplay;

	// Token: 0x040063D5 RID: 25557
	public bool Deactivation;

	// Token: 0x040063D6 RID: 25558
	public List<PersonalCardData> CardUnlockList = new List<PersonalCardData>();

	// Token: 0x040063D7 RID: 25559
	private string SdkUserId = "";

	// Token: 0x040063D8 RID: 25560
	[Nullable(2)]
	private string SdkOnlineId = "";

	// Token: 0x040063D9 RID: 25561
	private bool BlockBySdk;

	// Token: 0x040063DA RID: 25562
	private string SdkAccountId = "";

	// Token: 0x040063DB RID: 25563
	private string SdkAvoidId = "";
}
