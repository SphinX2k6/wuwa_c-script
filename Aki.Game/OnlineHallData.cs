using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;

// Token: 0x020017C1 RID: 6081
[NullableContext(1)]
[Nullable(0)]
public class OnlineHallData : IOnlinePlayerData, IPlayerData
{
	// Token: 0x17001697 RID: 5783
	// (get) Token: 0x0600EDA4 RID: 60836 RVA: 0x0045BCB0 File Offset: 0x00459EB0
	public int CurUsingCardId
	{
		get
		{
			return this.CurUsingCardIdInternal;
		}
	}

	// Token: 0x17001698 RID: 5784
	// (get) Token: 0x0600EDA5 RID: 60837 RVA: 0x0045BCB8 File Offset: 0x00459EB8
	public List<PersonalCardData> CardUnlockList
	{
		get
		{
			return this._cardUnlockList;
		}
	}

	// Token: 0x0600EDA6 RID: 60838 RVA: 0x0045BCC0 File Offset: 0x00459EC0
	public OnlineHallData(PlayerDetails playerDetails)
	{
		this.PlayerDetailsInternal = playerDetails;
		foreach (int cardId in playerDetails.CardShowList)
		{
			this.CardUnlockList.Add(new PersonalCardData(cardId, true, true));
		}
		this.CurUsingCardIdInternal = playerDetails.CurCard;
	}

	// Token: 0x0600EDA7 RID: 60839 RVA: 0x0045BD40 File Offset: 0x00459F40
	public void SetApplyTime(double time)
	{
		if (time <= 0.0)
		{
			return;
		}
		this.RefuseTimestampInternal = time;
	}

	// Token: 0x17001699 RID: 5785
	// (get) Token: 0x0600EDA8 RID: 60840 RVA: 0x0045BD56 File Offset: 0x00459F56
	public double ApplyTimeLeftTime
	{
		get
		{
			return this.RefuseTimestampInternal - TimeUtil.Instance.GetServerTime();
		}
	}

	// Token: 0x1700169A RID: 5786
	// (get) Token: 0x0600EDA9 RID: 60841 RVA: 0x0045BD69 File Offset: 0x00459F69
	public int PlayerId
	{
		get
		{
			return this.PlayerDetailsInternal.PlayerId;
		}
	}

	// Token: 0x1700169B RID: 5787
	// (get) Token: 0x0600EDAA RID: 60842 RVA: 0x0045BD76 File Offset: 0x00459F76
	public int HeadId
	{
		get
		{
			return this.PlayerDetailsInternal.HeadId;
		}
	}

	// Token: 0x1700169C RID: 5788
	// (get) Token: 0x0600EDAB RID: 60843 RVA: 0x0045BD83 File Offset: 0x00459F83
	public int Level
	{
		get
		{
			return this.PlayerDetailsInternal.Level;
		}
	}

	// Token: 0x1700169D RID: 5789
	// (get) Token: 0x0600EDAC RID: 60844 RVA: 0x0045BD90 File Offset: 0x00459F90
	public int PlayerCount
	{
		get
		{
			return this.PlayerDetailsInternal.TeamMemberCount;
		}
	}

	// Token: 0x1700169E RID: 5790
	// (get) Token: 0x0600EDAD RID: 60845 RVA: 0x0045BD9D File Offset: 0x00459F9D
	public int WorldLevel
	{
		get
		{
			return this.PlayerDetailsInternal.CurWorldLevel;
		}
	}

	// Token: 0x1700169F RID: 5791
	// (get) Token: 0x0600EDAE RID: 60846 RVA: 0x0045BDAA File Offset: 0x00459FAA
	public string Name
	{
		get
		{
			return this.PlayerDetailsInternal.Name;
		}
	}

	// Token: 0x170016A0 RID: 5792
	// (get) Token: 0x0600EDAF RID: 60847 RVA: 0x0045BDB7 File Offset: 0x00459FB7
	public string PlayerName
	{
		get
		{
			return this.PlayerDetailsInternal.Name;
		}
	}

	// Token: 0x170016A1 RID: 5793
	// (get) Token: 0x0600EDB0 RID: 60848 RVA: 0x0045BDC4 File Offset: 0x00459FC4
	public string Signature
	{
		get
		{
			return this.PlayerDetailsInternal.Signature;
		}
	}

	// Token: 0x170016A2 RID: 5794
	// (get) Token: 0x0600EDB1 RID: 60849 RVA: 0x0045BDD1 File Offset: 0x00459FD1
	public int PlayerCard
	{
		get
		{
			return this.PlayerDetailsInternal.CurCard;
		}
	}

	// Token: 0x170016A3 RID: 5795
	// (get) Token: 0x0600EDB2 RID: 60850 RVA: 0x0045BDDE File Offset: 0x00459FDE
	public int PlayerTitleId
	{
		get
		{
			return this.PlayerDetailsInternal.PlayerTitleId;
		}
	}

	// Token: 0x170016A4 RID: 5796
	// (get) Token: 0x0600EDB3 RID: 60851 RVA: 0x0045BDEB File Offset: 0x00459FEB
	public int PlayerTitleStarLevel
	{
		get
		{
			return this.PlayerDetailsInternal.PlayerTitleExtraParam;
		}
	}

	// Token: 0x170016A5 RID: 5797
	// (get) Token: 0x0600EDB4 RID: 60852 RVA: 0x0045BDF8 File Offset: 0x00459FF8
	public int Sex
	{
		get
		{
			return this.PlayerDetailsInternal.Sex;
		}
	}

	// Token: 0x170016A6 RID: 5798
	// (get) Token: 0x0600EDB5 RID: 60853 RVA: 0x0045BE05 File Offset: 0x0045A005
	public PlayerDetails PlayerDetails
	{
		get
		{
			return this.PlayerDetailsInternal;
		}
	}

	// Token: 0x170016A7 RID: 5799
	// (get) Token: 0x0600EDB6 RID: 60854 RVA: 0x0045BE0D File Offset: 0x0045A00D
	public int PlayerOriginWorldLevel
	{
		get
		{
			return this.PlayerDetailsInternal.OriginWorldLevel;
		}
	}

	// Token: 0x170016A8 RID: 5800
	// (get) Token: 0x0600EDB7 RID: 60855 RVA: 0x0045BE1A File Offset: 0x0045A01A
	public bool Deactivation
	{
		get
		{
			return this.PlayerDetailsInternal.Deactivation;
		}
	}

	// Token: 0x170016A9 RID: 5801
	// (get) Token: 0x0600EDB8 RID: 60856 RVA: 0x0045BE27 File Offset: 0x0045A027
	public long PlayerLastOfflineTime
	{
		get
		{
			return this.PlayerDetailsInternal.LastOfflineTime;
		}
	}

	// Token: 0x170016AA RID: 5802
	// (get) Token: 0x0600EDB9 RID: 60857 RVA: 0x0045BE34 File Offset: 0x0045A034
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

	// Token: 0x170016AB RID: 5803
	// (get) Token: 0x0600EDBA RID: 60858 RVA: 0x0045BE59 File Offset: 0x0045A059
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

	// Token: 0x0600EDBB RID: 60859 RVA: 0x0045BE7E File Offset: 0x0045A07E
	public bool GetIfCanShowInHallList([Nullable(new byte[]
	{
		2,
		1
	})] Dictionary<string, bool> blockMap = null)
	{
		return (!KuroSdkController.Instance.PlayOnly() || !(this.ThirdAvoidId == "")) && (blockMap == null || !blockMap.ContainsKey(this.ThirdAvoidId));
	}

	// Token: 0x04008694 RID: 34452
	private readonly PlayerDetails PlayerDetailsInternal;

	// Token: 0x04008695 RID: 34453
	private List<PersonalCardData> _cardUnlockList = new List<PersonalCardData>();

	// Token: 0x04008696 RID: 34454
	private int CurUsingCardIdInternal;

	// Token: 0x04008697 RID: 34455
	private double RefuseTimestampInternal;
}
