using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001C33 RID: 7219
[NullableContext(1)]
[Nullable(0)]
public class FriendData : IPlayerData
{
	// Token: 0x170011BE RID: 4542
	// (get) Token: 0x0600D913 RID: 55571 RVA: 0x00324F38 File Offset: 0x00323138
	// (set) Token: 0x0600D914 RID: 55572 RVA: 0x00324F40 File Offset: 0x00323140
	public string Signature { get; set; } = "";

	// Token: 0x0600D915 RID: 55573 RVA: 0x00324F4C File Offset: 0x0032314C
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

	// Token: 0x0600D916 RID: 55574 RVA: 0x00324F98 File Offset: 0x00323198
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

	// Token: 0x0600D917 RID: 55575 RVA: 0x00324FE4 File Offset: 0x003231E4
	public UniTask RefreshSdkBlockState()
	{
		FriendData.<RefreshSdkBlockState>d__32 <RefreshSdkBlockState>d__;
		<RefreshSdkBlockState>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSdkBlockState>d__.<>4__this = this;
		<RefreshSdkBlockState>d__.<>1__state = -1;
		<RefreshSdkBlockState>d__.<>t__builder.Start<FriendData.<RefreshSdkBlockState>d__32>(ref <RefreshSdkBlockState>d__);
		return <RefreshSdkBlockState>d__.<>t__builder.Task;
	}

	// Token: 0x170011BF RID: 4543
	// (get) Token: 0x0600D918 RID: 55576 RVA: 0x00325027 File Offset: 0x00323227
	// (set) Token: 0x0600D919 RID: 55577 RVA: 0x0032502F File Offset: 0x0032322F
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

	// Token: 0x170011C0 RID: 4544
	// (get) Token: 0x0600D91A RID: 55578 RVA: 0x00325038 File Offset: 0x00323238
	// (set) Token: 0x0600D91B RID: 55579 RVA: 0x00325040 File Offset: 0x00323240
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

	// Token: 0x170011C1 RID: 4545
	// (get) Token: 0x0600D91C RID: 55580 RVA: 0x00325049 File Offset: 0x00323249
	// (set) Token: 0x0600D91D RID: 55581 RVA: 0x00325051 File Offset: 0x00323251
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

	// Token: 0x170011C2 RID: 4546
	// (get) Token: 0x0600D91E RID: 55582 RVA: 0x0032505A File Offset: 0x0032325A
	public int PlayerHeadPhoto
	{
		get
		{
			return this.HeadPhoto;
		}
	}

	// Token: 0x170011C3 RID: 4547
	// (get) Token: 0x0600D91F RID: 55583 RVA: 0x00325062 File Offset: 0x00323262
	public int PlayerHeadFrame
	{
		get
		{
			return this.HeadFrame;
		}
	}

	// Token: 0x170011C4 RID: 4548
	// (get) Token: 0x0600D920 RID: 55584 RVA: 0x0032506A File Offset: 0x0032326A
	public int PlayerTitleId
	{
		get
		{
			return this.TitleId;
		}
	}

	// Token: 0x170011C5 RID: 4549
	// (get) Token: 0x0600D921 RID: 55585 RVA: 0x00325072 File Offset: 0x00323272
	public int PlayerTitleStarLevel
	{
		get
		{
			return this.TitleStarLevel;
		}
	}

	// Token: 0x170011C6 RID: 4550
	// (get) Token: 0x0600D922 RID: 55586 RVA: 0x0032507A File Offset: 0x0032327A
	public int PlayerSex
	{
		get
		{
			return this.Sex;
		}
	}

	// Token: 0x170011C7 RID: 4551
	// (get) Token: 0x0600D923 RID: 55587 RVA: 0x00325082 File Offset: 0x00323282
	// (set) Token: 0x0600D924 RID: 55588 RVA: 0x0032508A File Offset: 0x0032328A
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

	// Token: 0x170011C8 RID: 4552
	// (get) Token: 0x0600D925 RID: 55589 RVA: 0x00325093 File Offset: 0x00323293
	// (set) Token: 0x0600D926 RID: 55590 RVA: 0x0032509B File Offset: 0x0032329B
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

	// Token: 0x0600D927 RID: 55591 RVA: 0x003250A4 File Offset: 0x003232A4
	public int GetOfflineDay()
	{
		long playerLastOfflineTime = this.PlayerLastOfflineTime;
		return TimeUtil.Instance.CalculateDayTimeStampGapBetweenNow((double)playerLastOfflineTime, false);
	}

	// Token: 0x170011C9 RID: 4553
	// (get) Token: 0x0600D928 RID: 55592 RVA: 0x003250C5 File Offset: 0x003232C5
	// (set) Token: 0x0600D929 RID: 55593 RVA: 0x003250CD File Offset: 0x003232CD
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

	// Token: 0x170011CA RID: 4554
	// (get) Token: 0x0600D92A RID: 55594 RVA: 0x003250D6 File Offset: 0x003232D6
	public bool IsDeactivation
	{
		get
		{
			return this.Deactivation;
		}
	}

	// Token: 0x0600D92B RID: 55595 RVA: 0x003250DE File Offset: 0x003232DE
	[NullableContext(2)]
	public string GetSdkOnlineId()
	{
		return this.SdkOnlineId;
	}

	// Token: 0x0600D92C RID: 55596 RVA: 0x003250E6 File Offset: 0x003232E6
	public string GetSdkUserId()
	{
		return this.SdkUserId;
	}

	// Token: 0x0600D92D RID: 55597 RVA: 0x003250EE File Offset: 0x003232EE
	public string GetAvoidId()
	{
		return this.SdkAvoidId;
	}

	// Token: 0x0600D92E RID: 55598 RVA: 0x003250F8 File Offset: 0x003232F8
	public bool IfSdkCanShowFriend()
	{
		bool sdkFriendOnlyState = KuroSdkController.Instance.GetSdkFriendOnlyState();
		bool flag = KuroSdkController.Instance.PlayOnly();
		return (!sdkFriendOnlyState && !flag) || (!sdkFriendOnlyState && !flag) || !(this.SdkUserId == "");
	}

	// Token: 0x0600D92F RID: 55599 RVA: 0x0032513E File Offset: 0x0032333E
	public bool GetBlockBySdk()
	{
		return this.BlockBySdk;
	}

	// Token: 0x0600D930 RID: 55600 RVA: 0x00325146 File Offset: 0x00323346
	public bool CanShowInFriendList()
	{
		return !this.GetBlockBySdk() && this.IfSdkCanShowFriend();
	}

	// Token: 0x040062EF RID: 25327
	private int Id;

	// Token: 0x040062F0 RID: 25328
	private string Name = "";

	// Token: 0x040062F1 RID: 25329
	private int Level;

	// Token: 0x040062F2 RID: 25330
	private int HeadPhoto;

	// Token: 0x040062F3 RID: 25331
	private int HeadFrame;

	// Token: 0x040062F4 RID: 25332
	private int TitleId;

	// Token: 0x040062F5 RID: 25333
	private int TitleStarLevel;

	// Token: 0x040062F6 RID: 25334
	private int Sex;

	// Token: 0x040062F7 RID: 25335
	private bool IsOnline;

	// Token: 0x040062F8 RID: 25336
	private long LastOfflineTime;

	// Token: 0x040062F9 RID: 25337
	[Nullable(2)]
	private string Remark;

	// Token: 0x040062FA RID: 25338
	public bool Debug;

	// Token: 0x040062FB RID: 25339
	public int WorldLevel;

	// Token: 0x040062FC RID: 25340
	public int TeamMemberCount;

	// Token: 0x040062FE RID: 25342
	public int CurCard;

	// Token: 0x040062FF RID: 25343
	public List<global::RoleShowEntry> RoleShowList = new List<global::RoleShowEntry>();

	// Token: 0x04006300 RID: 25344
	public List<int> CardShowList = new List<int>();

	// Token: 0x04006301 RID: 25345
	public int Birthday;

	// Token: 0x04006302 RID: 25346
	public bool IsBirthdayDisplay;

	// Token: 0x04006303 RID: 25347
	public bool Deactivation;

	// Token: 0x04006304 RID: 25348
	public List<PersonalCardData> CardUnlockList = new List<PersonalCardData>();

	// Token: 0x04006305 RID: 25349
	private string SdkUserId = "";

	// Token: 0x04006306 RID: 25350
	[Nullable(2)]
	private string SdkOnlineId = "";

	// Token: 0x04006307 RID: 25351
	private bool BlockBySdk;

	// Token: 0x04006308 RID: 25352
	private string SdkAccountId = "";

	// Token: 0x04006309 RID: 25353
	private string SdkAvoidId = "";
}
