using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;

// Token: 0x020017C3 RID: 6083
[NullableContext(1)]
[Nullable(0)]
public class OnlineTeamData : IOnlinePlayerData, IPlayerData
{
	// Token: 0x170016B2 RID: 5810
	// (get) Token: 0x0600EDC3 RID: 60867 RVA: 0x0045BF2F File Offset: 0x0045A12F
	public List<PersonalCardData> CardUnlockList
	{
		get
		{
			return this._cardUnlockList;
		}
	}

	// Token: 0x170016B3 RID: 5811
	// (get) Token: 0x0600EDC4 RID: 60868 RVA: 0x0045BF37 File Offset: 0x0045A137
	public int CurUsingCardId
	{
		get
		{
			return this.CurUsingCardIdInternal;
		}
	}

	// Token: 0x0600EDC5 RID: 60869 RVA: 0x0045BF40 File Offset: 0x0045A140
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

	// Token: 0x170016B4 RID: 5812
	// (get) Token: 0x0600EDC6 RID: 60870 RVA: 0x0045C01C File Offset: 0x0045A21C
	public int PlayerId
	{
		get
		{
			return this.PlayerIdInternal;
		}
	}

	// Token: 0x170016B5 RID: 5813
	// (get) Token: 0x0600EDC7 RID: 60871 RVA: 0x0045C024 File Offset: 0x0045A224
	// (set) Token: 0x0600EDC8 RID: 60872 RVA: 0x0045C02C File Offset: 0x0045A22C
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

	// Token: 0x170016B6 RID: 5814
	// (get) Token: 0x0600EDC9 RID: 60873 RVA: 0x0045C035 File Offset: 0x0045A235
	// (set) Token: 0x0600EDCA RID: 60874 RVA: 0x0045C03D File Offset: 0x0045A23D
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

	// Token: 0x170016B7 RID: 5815
	// (get) Token: 0x0600EDCB RID: 60875 RVA: 0x0045C046 File Offset: 0x0045A246
	// (set) Token: 0x0600EDCC RID: 60876 RVA: 0x0045C04E File Offset: 0x0045A24E
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

	// Token: 0x170016B8 RID: 5816
	// (get) Token: 0x0600EDCD RID: 60877 RVA: 0x0045C057 File Offset: 0x0045A257
	public int PlayerTitleId
	{
		get
		{
			return this.PlayerTitleIdInternal;
		}
	}

	// Token: 0x170016B9 RID: 5817
	// (get) Token: 0x0600EDCE RID: 60878 RVA: 0x0045C05F File Offset: 0x0045A25F
	public int PlayerTitleStarLevel
	{
		get
		{
			return this.PlayerTitleStarLevelInternal;
		}
	}

	// Token: 0x170016BA RID: 5818
	// (get) Token: 0x0600EDCF RID: 60879 RVA: 0x0045C067 File Offset: 0x0045A267
	// (set) Token: 0x0600EDD0 RID: 60880 RVA: 0x0045C06F File Offset: 0x0045A26F
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

	// Token: 0x170016BB RID: 5819
	// (get) Token: 0x0600EDD1 RID: 60881 RVA: 0x0045C078 File Offset: 0x0045A278
	public int WorldLevel
	{
		get
		{
			return this.WorldLevelInternal;
		}
	}

	// Token: 0x0600EDD2 RID: 60882 RVA: 0x0045C080 File Offset: 0x0045A280
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

	// Token: 0x170016BC RID: 5820
	// (get) Token: 0x0600EDD3 RID: 60883 RVA: 0x0045C0C6 File Offset: 0x0045A2C6
	public string PlayerName
	{
		get
		{
			return this.GetFormationName();
		}
	}

	// Token: 0x0600EDD4 RID: 60884 RVA: 0x0045C0CE File Offset: 0x0045A2CE
	public string GetRawName()
	{
		return this.NameInternal;
	}

	// Token: 0x0600EDD5 RID: 60885 RVA: 0x0045C0D6 File Offset: 0x0045A2D6
	public string GetOnlineName()
	{
		if (!Info.Instance.IsPs5Platform())
		{
			return this.PlayerDetails.XboxOnlineId;
		}
		return this.PlayerDetails.PsnOnlineId;
	}

	// Token: 0x0600EDD6 RID: 60886 RVA: 0x0045C0FC File Offset: 0x0045A2FC
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

	// Token: 0x170016BD RID: 5821
	// (get) Token: 0x0600EDD7 RID: 60887 RVA: 0x0045C14A File Offset: 0x0045A34A
	// (set) Token: 0x0600EDD8 RID: 60888 RVA: 0x0045C152 File Offset: 0x0045A352
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

	// Token: 0x170016BE RID: 5822
	// (get) Token: 0x0600EDD9 RID: 60889 RVA: 0x0045C15B File Offset: 0x0045A35B
	// (set) Token: 0x0600EDDA RID: 60890 RVA: 0x0045C163 File Offset: 0x0045A363
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

	// Token: 0x170016BF RID: 5823
	// (get) Token: 0x0600EDDB RID: 60891 RVA: 0x0045C16C File Offset: 0x0045A36C
	public bool IsSelf
	{
		get
		{
			int playerId = this.PlayerId;
			int? id = PlayerInfoModel.Instance.GetId();
			return playerId == id.GetValueOrDefault() & id != null;
		}
	}

	// Token: 0x170016C0 RID: 5824
	// (get) Token: 0x0600EDDC RID: 60892 RVA: 0x0045C19B File Offset: 0x0045A39B
	// (set) Token: 0x0600EDDD RID: 60893 RVA: 0x0045C1A3 File Offset: 0x0045A3A3
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

	// Token: 0x170016C1 RID: 5825
	// (get) Token: 0x0600EDDE RID: 60894 RVA: 0x0045C1AC File Offset: 0x0045A3AC
	// (set) Token: 0x0600EDDF RID: 60895 RVA: 0x0045C1B4 File Offset: 0x0045A3B4
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

	// Token: 0x170016C2 RID: 5826
	// (get) Token: 0x0600EDE0 RID: 60896 RVA: 0x0045C1BD File Offset: 0x0045A3BD
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

	// Token: 0x170016C3 RID: 5827
	// (get) Token: 0x0600EDE1 RID: 60897 RVA: 0x0045C1E2 File Offset: 0x0045A3E2
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

	// Token: 0x170016C4 RID: 5828
	// (get) Token: 0x0600EDE2 RID: 60898 RVA: 0x0045C207 File Offset: 0x0045A407
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

	// Token: 0x0600EDE3 RID: 60899 RVA: 0x0045C22C File Offset: 0x0045A42C
	public bool GetIfCanShowInHallList([Nullable(new byte[]
	{
		2,
		1
	})] Dictionary<string, bool> blockMap = null)
	{
		return blockMap == null || !blockMap.ContainsKey(this.ThirdAvoidId);
	}

	// Token: 0x0400869E RID: 34462
	private readonly int PlayerIdInternal;

	// Token: 0x0400869F RID: 34463
	private string NameInternal;

	// Token: 0x040086A0 RID: 34464
	private int HeadIdInternal;

	// Token: 0x040086A1 RID: 34465
	private int LevelInternal;

	// Token: 0x040086A2 RID: 34466
	private string SignatureInternal;

	// Token: 0x040086A3 RID: 34467
	private int PlayerTitleIdInternal;

	// Token: 0x040086A4 RID: 34468
	private int PlayerTitleStarLevelInternal;

	// Token: 0x040086A5 RID: 34469
	private int SexInternal;

	// Token: 0x040086A6 RID: 34470
	private PlayerDetails PlayerDetailsInternal;

	// Token: 0x040086A7 RID: 34471
	private List<PersonalCardData> _cardUnlockList = new List<PersonalCardData>();

	// Token: 0x040086A8 RID: 34472
	private int PlayerNumberInternal;

	// Token: 0x040086A9 RID: 34473
	private ENetPingState PingStateInternal;

	// Token: 0x040086AA RID: 34474
	private readonly int WorldLevelInternal = 1;

	// Token: 0x040086AB RID: 34475
	private int CurUsingCardIdInternal;
}
