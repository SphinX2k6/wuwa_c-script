using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;

// Token: 0x020022DF RID: 8927
[NullableContext(1)]
[Nullable(0)]
public class OnlineTeamData : IOnlinePlayerData, IPlayerData
{
	// Token: 0x1700167B RID: 5755
	// (get) Token: 0x0601192B RID: 71979 RVA: 0x0044F263 File Offset: 0x0044D463
	public List<PersonalCardData> CardUnlockList
	{
		get
		{
			return this._cardUnlockList;
		}
	}

	// Token: 0x1700167C RID: 5756
	// (get) Token: 0x0601192C RID: 71980 RVA: 0x0044F26B File Offset: 0x0044D46B
	public int CurUsingCardId
	{
		get
		{
			return this.CurUsingCardIdInternal;
		}
	}

	// Token: 0x0601192D RID: 71981 RVA: 0x0044F274 File Offset: 0x0044D474
	public OnlineTeamData(string name, int playerId, int level, int headId, string signature, int playerNumber, PlayerDetails playerDetails, ENetPingState ping, int playerTitleId, int playerTitleStarLevel, int sex, int worldLevel)
	{
		this.NameInternal = name;
		this.PlayerIdInternal = playerId;
		this.LevelInternal = level;
		this.HeadIdInternal = headId;
		this.SignatureInternal = signature;
		this.PlayerNumber = playerNumber;
		this.PlayerDetailsInternal = playerDetails;
		this.PingStateInternal = ENetPingState.Great;
		this.PlayerTitleIdInternal = playerTitleId;
		this.PlayerTitleStarLevelInternal = playerTitleStarLevel;
		this.SexInternal = sex;
		this.WorldLevelInternal = worldLevel;
		foreach (int cardId in playerDetails.CardShowList)
		{
			this.CardUnlockList.Add(new PersonalCardData(cardId, true, true));
		}
		this.CurUsingCardIdInternal = playerDetails.CurCard;
	}

	// Token: 0x1700167D RID: 5757
	// (get) Token: 0x0601192E RID: 71982 RVA: 0x0044F350 File Offset: 0x0044D550
	public int PlayerId
	{
		get
		{
			return this.PlayerIdInternal;
		}
	}

	// Token: 0x1700167E RID: 5758
	// (get) Token: 0x0601192F RID: 71983 RVA: 0x0044F358 File Offset: 0x0044D558
	// (set) Token: 0x06011930 RID: 71984 RVA: 0x0044F360 File Offset: 0x0044D560
	public int HeadId
	{
		get
		{
			return this.HeadIdInternal;
		}
		set
		{
			this.HeadIdInternal = value;
		}
	}

	// Token: 0x1700167F RID: 5759
	// (get) Token: 0x06011931 RID: 71985 RVA: 0x0044F369 File Offset: 0x0044D569
	// (set) Token: 0x06011932 RID: 71986 RVA: 0x0044F371 File Offset: 0x0044D571
	public int Level
	{
		get
		{
			return this.LevelInternal;
		}
		set
		{
			this.LevelInternal = value;
		}
	}

	// Token: 0x17001680 RID: 5760
	// (get) Token: 0x06011933 RID: 71987 RVA: 0x0044F37A File Offset: 0x0044D57A
	// (set) Token: 0x06011934 RID: 71988 RVA: 0x0044F382 File Offset: 0x0044D582
	public string Name
	{
		get
		{
			return this.GetFormationName();
		}
		set
		{
			this.NameInternal = value;
		}
	}

	// Token: 0x17001681 RID: 5761
	// (get) Token: 0x06011935 RID: 71989 RVA: 0x0044F38B File Offset: 0x0044D58B
	public int PlayerTitleId
	{
		get
		{
			return this.PlayerTitleIdInternal;
		}
	}

	// Token: 0x17001682 RID: 5762
	// (get) Token: 0x06011936 RID: 71990 RVA: 0x0044F393 File Offset: 0x0044D593
	public int PlayerTitleStarLevel
	{
		get
		{
			return this.PlayerTitleStarLevelInternal;
		}
	}

	// Token: 0x17001683 RID: 5763
	// (get) Token: 0x06011937 RID: 71991 RVA: 0x0044F39B File Offset: 0x0044D59B
	// (set) Token: 0x06011938 RID: 71992 RVA: 0x0044F3A3 File Offset: 0x0044D5A3
	public int Sex
	{
		get
		{
			return this.SexInternal;
		}
		set
		{
			this.SexInternal = value;
		}
	}

	// Token: 0x17001684 RID: 5764
	// (get) Token: 0x06011939 RID: 71993 RVA: 0x0044F3AC File Offset: 0x0044D5AC
	public int WorldLevel
	{
		get
		{
			return this.WorldLevelInternal;
		}
	}

	// Token: 0x0601193A RID: 71994 RVA: 0x0044F3B4 File Offset: 0x0044D5B4
	public void SetPlayerTitleInfo(string playerTitleString)
	{
		if (playerTitleString.Length != 0)
		{
			string[] array = playerTitleString.Split('_', StringSplitOptions.None);
			this.PlayerTitleIdInternal = int.Parse(array[0]);
			int playerTitleStarLevelInternal = (array.Length == 2) ? int.Parse(array[1]) : 0;
			this.PlayerTitleStarLevelInternal = playerTitleStarLevelInternal;
		}
	}

	// Token: 0x17001685 RID: 5765
	// (get) Token: 0x0601193B RID: 71995 RVA: 0x0044F3FA File Offset: 0x0044D5FA
	public string PlayerName
	{
		get
		{
			return this.GetFormationName();
		}
	}

	// Token: 0x0601193C RID: 71996 RVA: 0x0044F402 File Offset: 0x0044D602
	public string GetRawName()
	{
		return this.NameInternal;
	}

	// Token: 0x0601193D RID: 71997 RVA: 0x0044F40A File Offset: 0x0044D60A
	public string GetOnlineName()
	{
		if (!Info.Instance.IsPs5Platform())
		{
			return this.PlayerDetails.XboxOnlineId;
		}
		return this.PlayerDetails.PsnOnlineId;
	}

	// Token: 0x0601193E RID: 71998 RVA: 0x0044F430 File Offset: 0x0044D630
	public string GetFormationName()
	{
		if (KuroSdkController.Instance.NeedShowThirdPartyId())
		{
			string text = Info.Instance.IsPs5Platform() ? this.PlayerDetails.PsnOnlineId : this.PlayerDetails.XboxOnlineId;
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
		}
		return this.NameInternal;
	}

	// Token: 0x17001686 RID: 5766
	// (get) Token: 0x0601193F RID: 71999 RVA: 0x0044F47E File Offset: 0x0044D67E
	// (set) Token: 0x06011940 RID: 72000 RVA: 0x0044F486 File Offset: 0x0044D686
	public string Signature
	{
		get
		{
			return this.SignatureInternal;
		}
		set
		{
			this.SignatureInternal = value;
		}
	}

	// Token: 0x17001687 RID: 5767
	// (get) Token: 0x06011941 RID: 72001 RVA: 0x0044F48F File Offset: 0x0044D68F
	// (set) Token: 0x06011942 RID: 72002 RVA: 0x0044F497 File Offset: 0x0044D697
	public int PlayerNumber
	{
		get
		{
			return this.PlayerNumberInternal;
		}
		set
		{
			this.PlayerNumberInternal = value;
		}
	}

	// Token: 0x17001688 RID: 5768
	// (get) Token: 0x06011943 RID: 72003 RVA: 0x0044F4A0 File Offset: 0x0044D6A0
	public bool IsSelf
	{
		get
		{
			int playerId = this.PlayerId;
			int? id = PlayerInfoModel.Instance.GetId();
			return playerId == id.GetValueOrDefault() & id != null;
		}
	}

	// Token: 0x17001689 RID: 5769
	// (get) Token: 0x06011944 RID: 72004 RVA: 0x0044F4CF File Offset: 0x0044D6CF
	// (set) Token: 0x06011945 RID: 72005 RVA: 0x0044F4D7 File Offset: 0x0044D6D7
	public ENetPingState PingState
	{
		get
		{
			return this.PingStateInternal;
		}
		set
		{
			this.PingStateInternal = value;
		}
	}

	// Token: 0x1700168A RID: 5770
	// (get) Token: 0x06011946 RID: 72006 RVA: 0x0044F4E0 File Offset: 0x0044D6E0
	// (set) Token: 0x06011947 RID: 72007 RVA: 0x0044F4E8 File Offset: 0x0044D6E8
	public PlayerDetails PlayerDetails
	{
		get
		{
			return this.PlayerDetailsInternal;
		}
		set
		{
			this.PlayerDetailsInternal = value;
		}
	}

	// Token: 0x1700168B RID: 5771
	// (get) Token: 0x06011948 RID: 72008 RVA: 0x0044F4F1 File Offset: 0x0044D6F1
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

	// Token: 0x1700168C RID: 5772
	// (get) Token: 0x06011949 RID: 72009 RVA: 0x0044F516 File Offset: 0x0044D716
	public string ThirdPartyOnlineId
	{
		get
		{
			if (Info.Instance.IsPs5Platform())
			{
				return this.PlayerDetailsInternal.PsnOnlineId;
			}
			return this.PlayerDetailsInternal.XboxOnlineId;
		}
	}

	// Token: 0x1700168D RID: 5773
	// (get) Token: 0x0601194A RID: 72010 RVA: 0x0044F53B File Offset: 0x0044D73B
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

	// Token: 0x0601194B RID: 72011 RVA: 0x0044F560 File Offset: 0x0044D760
	public bool GetIfCanShowInHallList([Nullable(new byte[]
	{
		2,
		1
	})] Dictionary<string, bool> blockMap = null)
	{
		return blockMap == null || !blockMap.ContainsKey(this.ThirdAvoidId);
	}

	// Token: 0x04008560 RID: 34144
	private readonly int PlayerIdInternal;

	// Token: 0x04008561 RID: 34145
	private string NameInternal;

	// Token: 0x04008562 RID: 34146
	private int HeadIdInternal;

	// Token: 0x04008563 RID: 34147
	private int LevelInternal;

	// Token: 0x04008564 RID: 34148
	private string SignatureInternal;

	// Token: 0x04008565 RID: 34149
	private int PlayerTitleIdInternal;

	// Token: 0x04008566 RID: 34150
	private int PlayerTitleStarLevelInternal;

	// Token: 0x04008567 RID: 34151
	private int SexInternal;

	// Token: 0x04008568 RID: 34152
	private PlayerDetails PlayerDetailsInternal;

	// Token: 0x04008569 RID: 34153
	private List<PersonalCardData> _cardUnlockList = new List<PersonalCardData>();

	// Token: 0x0400856A RID: 34154
	private int PlayerNumberInternal;

	// Token: 0x0400856B RID: 34155
	private ENetPingState PingStateInternal;

	// Token: 0x0400856C RID: 34156
	private readonly int WorldLevelInternal = 1;

	// Token: 0x0400856D RID: 34157
	private int CurUsingCardIdInternal;
}
