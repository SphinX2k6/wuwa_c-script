using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000ED7 RID: 3799
[NullableContext(1)]
[Nullable(0)]
public class AbyssChallengeInfo
{
	// Token: 0x06009825 RID: 38949 RVA: 0x002D17B4 File Offset: 0x002CF9B4
	public void RefreshPlayerName(bool mode)
	{
		int value = PlayerInfoModel.Instance.GetId().Value;
		if (this.PlayerNameMap.ContainsKey(value))
		{
			string value2 = (!mode) ? "" : PlayerInfoModel.Instance.GetAccountName(true);
			this.PlayerNameMap[value] = value2;
		}
	}

	// Token: 0x06009826 RID: 38950 RVA: 0x002D1808 File Offset: 0x002CFA08
	public DangoAbyssRankRoleData[] GetDangoAbyssRankRoleData()
	{
		if (this.RankRoleDataList.Length == 0)
		{
			List<DangoAbyssRankRoleData> list = new List<DangoAbyssRankRoleData>();
			if (!this.GetIsSingle())
			{
				int i = 0;
				int num = this.PlayerInfoList.Length;
				while (i < num)
				{
					foreach (AbyssChallengePassRoleInfo abyssChallengePassRoleInfo in this.PlayerInfoList[i].GetPassRoleInfoList())
					{
						list.Add(new DangoAbyssRankRoleData
						{
							RoleSkinId = abyssChallengePassRoleInfo.GetRoleSkinId(),
							RoleLevel = abyssChallengePassRoleInfo.GetRoleLevel(),
							DangoId = abyssChallengePassRoleInfo.GetDangoId(),
							DangoEquipIds = abyssChallengePassRoleInfo.GetEquipmentList(),
							IsOnline = true,
							IsEmpty = false,
							Pos = i
						});
					}
					i++;
				}
				for (int k = list.Count; k < 3; k++)
				{
					DangoAbyssRankRoleData item = new DangoAbyssRankRoleData();
					list.Add(item);
				}
			}
			else if (this.PlayerInfoList.Length != 0)
			{
				foreach (AbyssChallengePassRoleInfo abyssChallengePassRoleInfo2 in this.PlayerInfoList[0].GetPassRoleInfoList())
				{
					list.Add(new DangoAbyssRankRoleData
					{
						RoleSkinId = abyssChallengePassRoleInfo2.GetRoleSkinId(),
						RoleLevel = abyssChallengePassRoleInfo2.GetRoleLevel(),
						DangoId = abyssChallengePassRoleInfo2.GetDangoId(),
						DangoEquipIds = abyssChallengePassRoleInfo2.GetEquipmentList(),
						IsOnline = false,
						IsEmpty = false
					});
				}
				for (int l = list.Count; l < 3; l++)
				{
					DangoAbyssRankRoleData item2 = new DangoAbyssRankRoleData();
					list.Add(item2);
				}
			}
			this.RankRoleDataList = list.ToArray();
		}
		return this.RankRoleDataList;
	}

	// Token: 0x17001073 RID: 4211
	// (get) Token: 0x06009827 RID: 38951 RVA: 0x002D19BA File Offset: 0x002CFBBA
	public bool IsEmpty
	{
		get
		{
			return this.PlayerInfoList.Length == 0;
		}
	}

	// Token: 0x06009828 RID: 38952 RVA: 0x002D19C6 File Offset: 0x002CFBC6
	public global::AbyssChallengePassPlayerInfo[] GetPlayerInfoList()
	{
		return this.PlayerInfoList;
	}

	// Token: 0x06009829 RID: 38953 RVA: 0x002D19CE File Offset: 0x002CFBCE
	public int GetPassTime()
	{
		return this.PassTime;
	}

	// Token: 0x0600982A RID: 38954 RVA: 0x002D19D6 File Offset: 0x002CFBD6
	public int GetProgress()
	{
		return this.PassWave;
	}

	// Token: 0x0600982B RID: 38955 RVA: 0x002D19DE File Offset: 0x002CFBDE
	public int GetChallengeId()
	{
		return this.ChallengeId;
	}

	// Token: 0x0600982C RID: 38956 RVA: 0x002D19E6 File Offset: 0x002CFBE6
	public bool GetIsSingle()
	{
		return this.IsSingle;
	}

	// Token: 0x0600982D RID: 38957 RVA: 0x002D19EE File Offset: 0x002CFBEE
	public bool GetShowName()
	{
		return this.ShowName;
	}

	// Token: 0x0600982E RID: 38958 RVA: 0x002D19F6 File Offset: 0x002CFBF6
	public int GetOwnerId()
	{
		return this.OwnerId;
	}

	// Token: 0x0600982F RID: 38959 RVA: 0x002D19FE File Offset: 0x002CFBFE
	public void SetNameMode(bool mode)
	{
		this.ShowName = mode;
	}

	// Token: 0x06009830 RID: 38960 RVA: 0x002D1A08 File Offset: 0x002CFC08
	public void Phrase(Aki.Protocol.AbyssChallengeInfo data)
	{
		this.PlayerInfoList = Array.Empty<global::AbyssChallengePassPlayerInfo>();
		this.RankRoleDataList = Array.Empty<DangoAbyssRankRoleData>();
		List<global::AbyssChallengePassPlayerInfo> list = new List<global::AbyssChallengePassPlayerInfo>();
		int count = data.PlayerInfos.Count;
		int? id = PlayerInfoModel.Instance.GetId();
		this.PlayerNameMap.Clear();
		for (int i = 0; i < count; i++)
		{
			global::AbyssChallengePassPlayerInfo abyssChallengePassPlayerInfo = new global::AbyssChallengePassPlayerInfo();
			abyssChallengePassPlayerInfo.Phrase(data.PlayerInfos[i]);
			list.Add(abyssChallengePassPlayerInfo);
			this.PlayerNameMap[abyssChallengePassPlayerInfo.GetPlayerId()] = abyssChallengePassPlayerInfo.GetName();
			int? num = id;
			int playerId = abyssChallengePassPlayerInfo.GetPlayerId();
			if (num.GetValueOrDefault() == playerId & num != null)
			{
				this.IsSelfInData = true;
			}
		}
		this.PlayerInfoList = list.ToArray();
		this.PassTime = data.PassTime;
		this.ChallengeId = data.ChallengeId;
		this.IsSingle = data.IsSingle;
		this.ShowName = data.ShowName;
		this.OwnerId = data.OwnerId;
		this.PassWave = data.PassWave;
	}

	// Token: 0x17001074 RID: 4212
	// (get) Token: 0x06009831 RID: 38961 RVA: 0x002D1B16 File Offset: 0x002CFD16
	public string RankBg
	{
		get
		{
			if (this.IsFirst)
			{
				return "T_AnniversaryCelebrationRankBg_1";
			}
			if (this.IsSecond)
			{
				return "T_AnniversaryCelebrationRankBg_2";
			}
			if (this.IsThird)
			{
				return "T_AnniversaryCelebrationRankBg_3";
			}
			return "T_AnniversaryCelebrationRankBgOther";
		}
	}

	// Token: 0x17001075 RID: 4213
	// (get) Token: 0x06009832 RID: 38962 RVA: 0x002D1B47 File Offset: 0x002CFD47
	public bool IsFirst
	{
		get
		{
			return this.Rank == 1 && this.IsInRank;
		}
	}

	// Token: 0x17001076 RID: 4214
	// (get) Token: 0x06009833 RID: 38963 RVA: 0x002D1B5A File Offset: 0x002CFD5A
	public bool IsSecond
	{
		get
		{
			return this.Rank == 2 && this.IsInRank;
		}
	}

	// Token: 0x17001077 RID: 4215
	// (get) Token: 0x06009834 RID: 38964 RVA: 0x002D1B6D File Offset: 0x002CFD6D
	public bool IsThird
	{
		get
		{
			return this.Rank == 3 && this.IsInRank;
		}
	}

	// Token: 0x06009835 RID: 38965 RVA: 0x002D1B80 File Offset: 0x002CFD80
	public Dictionary<int, string> GetPlayerNameMap()
	{
		return this.PlayerNameMap;
	}

	// Token: 0x04005B42 RID: 23362
	public bool IsSelf;

	// Token: 0x04005B43 RID: 23363
	public bool IsSelfInData;

	// Token: 0x04005B44 RID: 23364
	public bool IsInRank = true;

	// Token: 0x04005B45 RID: 23365
	private readonly Dictionary<int, string> PlayerNameMap = new Dictionary<int, string>();

	// Token: 0x04005B46 RID: 23366
	private global::AbyssChallengePassPlayerInfo[] PlayerInfoList = Array.Empty<global::AbyssChallengePassPlayerInfo>();

	// Token: 0x04005B47 RID: 23367
	private int PassTime;

	// Token: 0x04005B48 RID: 23368
	private int ChallengeId;

	// Token: 0x04005B49 RID: 23369
	private bool IsSingle;

	// Token: 0x04005B4A RID: 23370
	private bool ShowName;

	// Token: 0x04005B4B RID: 23371
	private int OwnerId;

	// Token: 0x04005B4C RID: 23372
	private int PassWave;

	// Token: 0x04005B4D RID: 23373
	public int Rank;

	// Token: 0x04005B4E RID: 23374
	private DangoAbyssRankRoleData[] RankRoleDataList = Array.Empty<DangoAbyssRankRoleData>();
}
