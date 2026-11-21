using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AC8 RID: 15048
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRankItemData
	{
		// Token: 0x17004F01 RID: 20225
		// (get) Token: 0x06026A93 RID: 158355 RVA: 0x00AD4465 File Offset: 0x00AD2665
		public bool IsEmpty
		{
			get
			{
				return this.ServerData.PlayerPassInfo.Count == 0;
			}
		}

		// Token: 0x17004F02 RID: 20226
		// (get) Token: 0x06026A94 RID: 158356 RVA: 0x00AD447A File Offset: 0x00AD267A
		public int PassScore
		{
			get
			{
				if (this.IsDifficult)
				{
					return this.ServerData.PassTime;
				}
				return this.ServerData.Score;
			}
		}

		// Token: 0x17004F03 RID: 20227
		// (get) Token: 0x06026A95 RID: 158357 RVA: 0x00AD449B File Offset: 0x00AD269B
		public int PassTime
		{
			get
			{
				return this.ServerData.PassTime;
			}
		}

		// Token: 0x06026A96 RID: 158358 RVA: 0x00AD44A8 File Offset: 0x00AD26A8
		public TowerDefenseRankItemData(bool isOnline, bool isDifficult, TowerDefencePassInfo data)
		{
			this.IsOnline = isOnline;
			this.IsDifficult = isDifficult;
			this.ServerData = data;
			this.InitRoleDataList();
			this.InitPlayerNameList();
			this.IsSelfInData = this.GetIsInSelfData();
		}

		// Token: 0x06026A97 RID: 158359 RVA: 0x00AD4508 File Offset: 0x00AD2708
		private void InitRoleDataList()
		{
			if (this.IsOnline)
			{
				int i = 0;
				int count = this.ServerData.PlayerPassInfo.Count;
				while (i < count)
				{
					foreach (TowerDefenceRolePassInfo towerDefenceRolePassInfo in this.ServerData.PlayerPassInfo[i].RoleList)
					{
						TowerDefenseRankRoleData towerDefenseRankRoleData = new TowerDefenseRankRoleData();
						towerDefenseRankRoleData.RoleSkinId = towerDefenceRolePassInfo.RoleSkinId;
						towerDefenseRankRoleData.RoleLevel = towerDefenceRolePassInfo.RoleLevel;
						towerDefenseRankRoleData.PhantomId = towerDefenceRolePassInfo.PhantomId;
						towerDefenseRankRoleData.IsOnline = true;
						towerDefenseRankRoleData.IsEmpty = false;
						towerDefenseRankRoleData.Pos = i;
						this.RoleDataList.Add(towerDefenseRankRoleData);
					}
					i++;
				}
				for (int j = this.RoleDataList.Count; j < 3; j++)
				{
					TowerDefenseRankRoleData item = new TowerDefenseRankRoleData();
					this.RoleDataList.Add(item);
				}
				return;
			}
			if (this.ServerData.PlayerPassInfo.Count > 0)
			{
				foreach (TowerDefenceRolePassInfo towerDefenceRolePassInfo2 in this.ServerData.PlayerPassInfo[0].RoleList)
				{
					TowerDefenseRankRoleData towerDefenseRankRoleData2 = new TowerDefenseRankRoleData();
					towerDefenseRankRoleData2.RoleSkinId = towerDefenceRolePassInfo2.RoleSkinId;
					towerDefenseRankRoleData2.RoleLevel = towerDefenceRolePassInfo2.RoleLevel;
					towerDefenseRankRoleData2.PhantomId = towerDefenceRolePassInfo2.PhantomId;
					towerDefenseRankRoleData2.IsOnline = false;
					towerDefenseRankRoleData2.IsEmpty = false;
					this.RoleDataList.Add(towerDefenseRankRoleData2);
				}
				for (int k = this.RoleDataList.Count; k < 3; k++)
				{
					TowerDefenseRankRoleData item2 = new TowerDefenseRankRoleData();
					this.RoleDataList.Add(item2);
				}
			}
		}

		// Token: 0x06026A98 RID: 158360 RVA: 0x00AD46E8 File Offset: 0x00AD28E8
		private void InitPlayerNameList()
		{
			foreach (TowerDefencePassPlayerInfo towerDefencePassPlayerInfo in this.ServerData.PlayerPassInfo)
			{
				this.PlayerNameMap[towerDefencePassPlayerInfo.PlayerId] = towerDefencePassPlayerInfo.Name;
			}
		}

		// Token: 0x06026A99 RID: 158361 RVA: 0x00AD474C File Offset: 0x00AD294C
		private bool GetIsInSelfData()
		{
			int? id = PlayerInfoModel.Instance.GetId();
			foreach (TowerDefencePassPlayerInfo towerDefencePassPlayerInfo in this.ServerData.PlayerPassInfo)
			{
				int playerId = towerDefencePassPlayerInfo.PlayerId;
				int? num = id;
				if (playerId == num.GetValueOrDefault() & num != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06026A9A RID: 158362 RVA: 0x00AD47C4 File Offset: 0x00AD29C4
		public List<ITowerDefenseRankPlayerName> GetPlayerNameList()
		{
			List<ITowerDefenseRankPlayerName> list = new List<ITowerDefenseRankPlayerName>();
			foreach (TowerDefencePassPlayerInfo towerDefencePassPlayerInfo in this.ServerData.PlayerPassInfo)
			{
				string playerName = this.PlayerNameMap[towerDefencePassPlayerInfo.PlayerId];
				list.Add(new TowerDefenseRankPlayerName
				{
					PlayerId = towerDefencePassPlayerInfo.PlayerId,
					PlayerName = playerName
				});
			}
			return list;
		}

		// Token: 0x06026A9B RID: 158363 RVA: 0x00AD4848 File Offset: 0x00AD2A48
		public void RefreshPlayerName(bool isIsOpenAnonymousName)
		{
			int value = PlayerInfoModel.Instance.GetId().Value;
			if (this.PlayerNameMap.ContainsKey(value))
			{
				string value2 = isIsOpenAnonymousName ? "" : PlayerInfoModel.Instance.GetAccountName(true);
				this.PlayerNameMap[value] = value2;
			}
		}

		// Token: 0x17004F04 RID: 20228
		// (get) Token: 0x06026A9C RID: 158364 RVA: 0x00AD4899 File Offset: 0x00AD2A99
		public string TopThreeNumColor
		{
			get
			{
				if (this.IsFirst)
				{
					return "CB9C38FF";
				}
				if (this.IsSecond)
				{
					return "6A7E9DFF";
				}
				if (this.IsThird)
				{
					return "997E76FF";
				}
				return "FFFFFFFF";
			}
		}

		// Token: 0x17004F05 RID: 20229
		// (get) Token: 0x06026A9D RID: 158365 RVA: 0x00AD48CA File Offset: 0x00AD2ACA
		public string RankBg
		{
			get
			{
				if (this.IsFirst)
				{
					return "T_TipItemBgGold";
				}
				if (this.IsSecond)
				{
					return "T_TipItemBgSilver";
				}
				if (this.IsThird)
				{
					return "T_TipItemBgCopper";
				}
				return "T_TipItemBgMask";
			}
		}

		// Token: 0x17004F06 RID: 20230
		// (get) Token: 0x06026A9E RID: 158366 RVA: 0x00AD48FB File Offset: 0x00AD2AFB
		public bool IsFirst
		{
			get
			{
				return this.Rank == 1 && this.IsInRank;
			}
		}

		// Token: 0x17004F07 RID: 20231
		// (get) Token: 0x06026A9F RID: 158367 RVA: 0x00AD490E File Offset: 0x00AD2B0E
		public bool IsSecond
		{
			get
			{
				return this.Rank == 2 && this.IsInRank;
			}
		}

		// Token: 0x17004F08 RID: 20232
		// (get) Token: 0x06026AA0 RID: 158368 RVA: 0x00AD4921 File Offset: 0x00AD2B21
		public bool IsThird
		{
			get
			{
				return this.Rank == 3 && this.IsInRank;
			}
		}

		// Token: 0x17004F09 RID: 20233
		// (get) Token: 0x06026AA1 RID: 158369 RVA: 0x00AD4934 File Offset: 0x00AD2B34
		public bool IsTopThree
		{
			get
			{
				return this.IsFirst || this.IsSecond || this.IsThird;
			}
		}

		// Token: 0x040152A6 RID: 86694
		public const string FIRSTPLAYER_COLOR = "CB9C38FF";

		// Token: 0x040152A7 RID: 86695
		public const string SECONDPLAYER_COLOR = "6A7E9DFF";

		// Token: 0x040152A8 RID: 86696
		public const string THIRDPLAYER_COLOR = "997E76FF";

		// Token: 0x040152A9 RID: 86697
		public const string FIRST_RANKBG = "T_TipItemBgGold";

		// Token: 0x040152AA RID: 86698
		public const string SECOND_RANKBG = "T_TipItemBgSilver";

		// Token: 0x040152AB RID: 86699
		public const string THIRD_RANKBG = "T_TipItemBgCopper";

		// Token: 0x040152AC RID: 86700
		public const string OTHER_RANKBG = "T_TipItemBgMask";

		// Token: 0x040152AD RID: 86701
		public const int MAX_COUNT = 3;

		// Token: 0x040152AE RID: 86702
		public readonly bool IsSelfInData;

		// Token: 0x040152AF RID: 86703
		public TowerDefencePassInfo ServerData;

		// Token: 0x040152B0 RID: 86704
		public bool IsOnline;

		// Token: 0x040152B1 RID: 86705
		public bool IsDifficult;

		// Token: 0x040152B2 RID: 86706
		public bool IsInRank = true;

		// Token: 0x040152B3 RID: 86707
		public bool IsSelf;

		// Token: 0x040152B4 RID: 86708
		public int Rank;

		// Token: 0x040152B5 RID: 86709
		public readonly List<TowerDefenseRankRoleData> RoleDataList = new List<TowerDefenseRankRoleData>();

		// Token: 0x040152B6 RID: 86710
		private readonly Dictionary<int, string> PlayerNameMap = new Dictionary<int, string>();
	}
}
