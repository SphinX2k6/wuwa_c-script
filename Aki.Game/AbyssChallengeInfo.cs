using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001A18 RID: 6680
[NullableContext(1)]
[Nullable(0)]
public class AbyssChallengeInfo
{
	// Token: 0x0600C415 RID: 50197 RVA: 0x002C6730 File Offset: 0x002C4930
	public void RefreshPlayerName(bool mode)
	{
		int value = PlayerInfoModel.Instance.GetId().Value;
		if (this.PlayerNameMap.ContainsKey(value))
		{
			string value2 = (!mode) ? "" : PlayerInfoModel.Instance.GetAccountName(true);
			this.PlayerNameMap[value] = value2;
		}
	}

	// Token: 0x0600C416 RID: 50198 RVA: 0x002C6784 File Offset: 0x002C4984
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

	// Token: 0x1700104E RID: 4174
	// (get) Token: 0x0600C417 RID: 50199 RVA: 0x002C6936 File Offset: 0x002C4B36
	public bool IsEmpty
	{
		get
		{
			return this.PlayerInfoList.Length == 0;
		}
	}

	// Token: 0x0600C418 RID: 50200 RVA: 0x002C6942 File Offset: 0x002C4B42
	public global::AbyssChallengePassPlayerInfo[] GetPlayerInfoList()
	{
		return this.PlayerInfoList;
	}

	// Token: 0x0600C419 RID: 50201 RVA: 0x002C694A File Offset: 0x002C4B4A
	public int GetPassTime()
	{
		return this.PassTime;
	}

	// Token: 0x0600C41A RID: 50202 RVA: 0x002C6952 File Offset: 0x002C4B52
	public int GetProgress()
	{
		return this.PassWave;
	}

	// Token: 0x0600C41B RID: 50203 RVA: 0x002C695A File Offset: 0x002C4B5A
	public int GetChallengeId()
	{
		return this.ChallengeId;
	}

	// Token: 0x0600C41C RID: 50204 RVA: 0x002C6962 File Offset: 0x002C4B62
	public bool GetIsSingle()
	{
		return this.IsSingle;
	}

	// Token: 0x0600C41D RID: 50205 RVA: 0x002C696A File Offset: 0x002C4B6A
	public bool GetShowName()
	{
		return this.ShowName;
	}

	// Token: 0x0600C41E RID: 50206 RVA: 0x002C6972 File Offset: 0x002C4B72
	public int GetOwnerId()
	{
		return this.OwnerId;
	}

	// Token: 0x0600C41F RID: 50207 RVA: 0x002C697A File Offset: 0x002C4B7A
	public void SetNameMode(bool mode)
	{
		this.ShowName = mode;
	}

	// Token: 0x0600C420 RID: 50208 RVA: 0x002C6984 File Offset: 0x002C4B84
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

	// Token: 0x1700104F RID: 4175
	// (get) Token: 0x0600C421 RID: 50209 RVA: 0x002C6A92 File Offset: 0x002C4C92
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

	// Token: 0x17001050 RID: 4176
	// (get) Token: 0x0600C422 RID: 50210 RVA: 0x002C6AC3 File Offset: 0x002C4CC3
	public bool IsFirst
	{
		get
		{
			return this.Rank == 1 && this.IsInRank;
		}
	}

	// Token: 0x17001051 RID: 4177
	// (get) Token: 0x0600C423 RID: 50211 RVA: 0x002C6AD6 File Offset: 0x002C4CD6
	public bool IsSecond
	{
		get
		{
			return this.Rank == 2 && this.IsInRank;
		}
	}

	// Token: 0x17001052 RID: 4178
	// (get) Token: 0x0600C424 RID: 50212 RVA: 0x002C6AE9 File Offset: 0x002C4CE9
	public bool IsThird
	{
		get
		{
			return this.Rank == 3 && this.IsInRank;
		}
	}

	// Token: 0x0600C425 RID: 50213 RVA: 0x002C6AFC File Offset: 0x002C4CFC
	public Dictionary<int, string> GetPlayerNameMap()
	{
		return this.PlayerNameMap;
	}

	// Token: 0x04005A73 RID: 23155
	public bool IsSelf;

	// Token: 0x04005A74 RID: 23156
	public bool IsSelfInData;

	// Token: 0x04005A75 RID: 23157
	public bool IsInRank = true;

	// Token: 0x04005A76 RID: 23158
	private readonly Dictionary<int, string> PlayerNameMap = new Dictionary<int, string>();

	// Token: 0x04005A77 RID: 23159
	private global::AbyssChallengePassPlayerInfo[] PlayerInfoList = Array.Empty<global::AbyssChallengePassPlayerInfo>();

	// Token: 0x04005A78 RID: 23160
	private int PassTime;

	// Token: 0x04005A79 RID: 23161
	private int ChallengeId;

	// Token: 0x04005A7A RID: 23162
	private bool IsSingle;

	// Token: 0x04005A7B RID: 23163
	private bool ShowName;

	// Token: 0x04005A7C RID: 23164
	private int OwnerId;

	// Token: 0x04005A7D RID: 23165
	private int PassWave;

	// Token: 0x04005A7E RID: 23166
	public int Rank;

	// Token: 0x04005A7F RID: 23167
	private DangoAbyssRankRoleData[] RankRoleDataList = Array.Empty<DangoAbyssRankRoleData>();
}
