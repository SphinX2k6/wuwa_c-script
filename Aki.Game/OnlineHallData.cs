using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;

// Token: 0x020022DD RID: 8925
[NullableContext(1)]
[Nullable(0)]
public class OnlineHallData : IOnlinePlayerData, IPlayerData
{
	// Token: 0x17001660 RID: 5728
	// (get) Token: 0x0601190C RID: 71948 RVA: 0x0044EFE4 File Offset: 0x0044D1E4
	public int CurUsingCardId
	{
		get
		{
			return this.CurUsingCardIdInternal;
		}
	}

	// Token: 0x17001661 RID: 5729
	// (get) Token: 0x0601190D RID: 71949 RVA: 0x0044EFEC File Offset: 0x0044D1EC
	public List<PersonalCardData> CardUnlockList
	{
		get
		{
			return this._cardUnlockList;
		}
	}

	// Token: 0x0601190E RID: 71950 RVA: 0x0044EFF4 File Offset: 0x0044D1F4
	public OnlineHallData(PlayerDetails playerDetails)
	{
		this.PlayerDetailsInternal = playerDetails;
		foreach (int cardId in playerDetails.CardShowList)
		{
			this.CardUnlockList.Add(new PersonalCardData(cardId, true, true));
		}
		this.CurUsingCardIdInternal = playerDetails.CurCard;
	}

	// Token: 0x0601190F RID: 71951 RVA: 0x0044F074 File Offset: 0x0044D274
	public void SetApplyTime(double time)
	{
		if (time <= 0.0)
		{
			return;
		}
		this.RefuseTimestampInternal = time;
	}

	// Token: 0x17001662 RID: 5730
	// (get) Token: 0x06011910 RID: 71952 RVA: 0x0044F08A File Offset: 0x0044D28A
	public double ApplyTimeLeftTime
	{
		get
		{
			return this.RefuseTimestampInternal - TimeUtil.Instance.GetServerTime();
		}
	}

	// Token: 0x17001663 RID: 5731
	// (get) Token: 0x06011911 RID: 71953 RVA: 0x0044F09D File Offset: 0x0044D29D
	public int PlayerId
	{
		get
		{
			return this.PlayerDetailsInternal.PlayerId;
		}
	}

	// Token: 0x17001664 RID: 5732
	// (get) Token: 0x06011912 RID: 71954 RVA: 0x0044F0AA File Offset: 0x0044D2AA
	public int HeadId
	{
		get
		{
			return this.PlayerDetailsInternal.HeadId;
		}
	}

	// Token: 0x17001665 RID: 5733
	// (get) Token: 0x06011913 RID: 71955 RVA: 0x0044F0B7 File Offset: 0x0044D2B7
	public int Level
	{
		get
		{
			return this.PlayerDetailsInternal.Level;
		}
	}

	// Token: 0x17001666 RID: 5734
	// (get) Token: 0x06011914 RID: 71956 RVA: 0x0044F0C4 File Offset: 0x0044D2C4
	public int PlayerCount
	{
		get
		{
			return this.PlayerDetailsInternal.TeamMemberCount;
		}
	}

	// Token: 0x17001667 RID: 5735
	// (get) Token: 0x06011915 RID: 71957 RVA: 0x0044F0D1 File Offset: 0x0044D2D1
	public int WorldLevel
	{
		get
		{
			return this.PlayerDetailsInternal.CurWorldLevel;
		}
	}

	// Token: 0x17001668 RID: 5736
	// (get) Token: 0x06011916 RID: 71958 RVA: 0x0044F0DE File Offset: 0x0044D2DE
	public string Name
	{
		get
		{
			return this.PlayerDetailsInternal.Name;
		}
	}

	// Token: 0x17001669 RID: 5737
	// (get) Token: 0x06011917 RID: 71959 RVA: 0x0044F0EB File Offset: 0x0044D2EB
	public string PlayerName
	{
		get
		{
			return this.PlayerDetailsInternal.Name;
		}
	}

	// Token: 0x1700166A RID: 5738
	// (get) Token: 0x06011918 RID: 71960 RVA: 0x0044F0F8 File Offset: 0x0044D2F8
	public string Signature
	{
		get
		{
			return this.PlayerDetailsInternal.Signature;
		}
	}

	// Token: 0x1700166B RID: 5739
	// (get) Token: 0x06011919 RID: 71961 RVA: 0x0044F105 File Offset: 0x0044D305
	public int PlayerCard
	{
		get
		{
			return this.PlayerDetailsInternal.CurCard;
		}
	}

	// Token: 0x1700166C RID: 5740
	// (get) Token: 0x0601191A RID: 71962 RVA: 0x0044F112 File Offset: 0x0044D312
	public int PlayerTitleId
	{
		get
		{
			return this.PlayerDetailsInternal.PlayerTitleId;
		}
	}

	// Token: 0x1700166D RID: 5741
	// (get) Token: 0x0601191B RID: 71963 RVA: 0x0044F11F File Offset: 0x0044D31F
	public int PlayerTitleStarLevel
	{
		get
		{
			return this.PlayerDetailsInternal.PlayerTitleExtraParam;
		}
	}

	// Token: 0x1700166E RID: 5742
	// (get) Token: 0x0601191C RID: 71964 RVA: 0x0044F12C File Offset: 0x0044D32C
	public int Sex
	{
		get
		{
			return this.PlayerDetailsInternal.Sex;
		}
	}

	// Token: 0x1700166F RID: 5743
	// (get) Token: 0x0601191D RID: 71965 RVA: 0x0044F139 File Offset: 0x0044D339
	public PlayerDetails PlayerDetails
	{
		get
		{
			return this.PlayerDetailsInternal;
		}
	}

	// Token: 0x17001670 RID: 5744
	// (get) Token: 0x0601191E RID: 71966 RVA: 0x0044F141 File Offset: 0x0044D341
	public int PlayerOriginWorldLevel
	{
		get
		{
			return this.PlayerDetailsInternal.OriginWorldLevel;
		}
	}

	// Token: 0x17001671 RID: 5745
	// (get) Token: 0x0601191F RID: 71967 RVA: 0x0044F14E File Offset: 0x0044D34E
	public bool Deactivation
	{
		get
		{
			return this.PlayerDetailsInternal.Deactivation;
		}
	}

	// Token: 0x17001672 RID: 5746
	// (get) Token: 0x06011920 RID: 71968 RVA: 0x0044F15B File Offset: 0x0044D35B
	public long PlayerLastOfflineTime
	{
		get
		{
			return this.PlayerDetailsInternal.LastOfflineTime;
		}
	}

	// Token: 0x17001673 RID: 5747
	// (get) Token: 0x06011921 RID: 71969 RVA: 0x0044F168 File Offset: 0x0044D368
	public string ThirdPartyUserId
	{
		get
		{
			if (Info.Instance.IsPs5Platform())
			{
				return this.PlayerDetailsInternal.PsnAccountId;
			}
			return this.PlayerDetailsInternal.XboxUserId;
		}
	}

	// Token: 0x17001674 RID: 5748
	// (get) Token: 0x06011922 RID: 71970 RVA: 0x0044F18D File Offset: 0x0044D38D
	public string ThirdAvoidId
	{
		get
		{
			if (Info.Instance.IsPs5Platform())
			{
				return this.PlayerDetailsInternal.PsnAccountId;
			}
			return this.PlayerDetailsInternal.XboxAccountId;
		}
	}

	// Token: 0x06011923 RID: 71971 RVA: 0x0044F1B2 File Offset: 0x0044D3B2
	public bool GetIfCanShowInHallList([Nullable(new byte[]
	{
		2,
		1
	})] Dictionary<string, bool> blockMap = null)
	{
		return (!KuroSdkController.Instance.PlayOnly() || !(this.ThirdAvoidId == "")) && (blockMap == null || !blockMap.ContainsKey(this.ThirdAvoidId));
	}

	// Token: 0x04008556 RID: 34134
	private readonly PlayerDetails PlayerDetailsInternal;

	// Token: 0x04008557 RID: 34135
	private List<PersonalCardData> _cardUnlockList = new List<PersonalCardData>();

	// Token: 0x04008558 RID: 34136
	private int CurUsingCardIdInternal;

	// Token: 0x04008559 RID: 34137
	private double RefuseTimestampInternal;
}
