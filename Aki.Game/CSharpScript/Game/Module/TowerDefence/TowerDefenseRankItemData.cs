using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B20 RID: 19232
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRankItemData
	{
		// Token: 0x17007B54 RID: 31572
		// (get) Token: 0x06031D03 RID: 204035 RVA: 0x00B90401 File Offset: 0x00B8E601
		public bool IsEmpty
		{
			get
			{
				return this.ServerData.PlayerPassInfo.Count == 0;
			}
		}

		// Token: 0x17007B55 RID: 31573
		// (get) Token: 0x06031D04 RID: 204036 RVA: 0x00B90416 File Offset: 0x00B8E616
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

		// Token: 0x17007B56 RID: 31574
		// (get) Token: 0x06031D05 RID: 204037 RVA: 0x00B90437 File Offset: 0x00B8E637
		public int PassTime
		{
			get
			{
				return this.ServerData.PassTime;
			}
		}

		// Token: 0x06031D06 RID: 204038 RVA: 0x00B90444 File Offset: 0x00B8E644
		public TowerDefenseRankItemData(bool isOnline, bool isDifficult, TowerDefencePassInfo data)
		{
			this.IsOnline = isOnline;
			this.IsDifficult = isDifficult;
			this.ServerData = data;
			this.InitRoleDataList();
			this.InitPlayerNameList();
			this.IsSelfInData = this.GetIsInSelfData();
		}

		// Token: 0x06031D07 RID: 204039 RVA: 0x00B904A4 File Offset: 0x00B8E6A4
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

		// Token: 0x06031D08 RID: 204040 RVA: 0x00B90684 File Offset: 0x00B8E884
		private void InitPlayerNameList()
		{
			foreach (TowerDefencePassPlayerInfo towerDefencePassPlayerInfo in this.ServerData.PlayerPassInfo)
			{
				this.PlayerNameMap[towerDefencePassPlayerInfo.PlayerId] = towerDefencePassPlayerInfo.Name;
			}
		}

		// Token: 0x06031D09 RID: 204041 RVA: 0x00B906E8 File Offset: 0x00B8E8E8
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

		// Token: 0x06031D0A RID: 204042 RVA: 0x00B90760 File Offset: 0x00B8E960
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

		// Token: 0x06031D0B RID: 204043 RVA: 0x00B907E4 File Offset: 0x00B8E9E4
		public void RefreshPlayerName(bool isIsOpenAnonymousName)
		{
			int value = PlayerInfoModel.Instance.GetId().Value;
			if (this.PlayerNameMap.ContainsKey(value))
			{
				string value2 = isIsOpenAnonymousName ? "" : PlayerInfoModel.Instance.GetAccountName(true);
				this.PlayerNameMap[value] = value2;
			}
		}

		// Token: 0x17007B57 RID: 31575
		// (get) Token: 0x06031D0C RID: 204044 RVA: 0x00B90835 File Offset: 0x00B8EA35
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

		// Token: 0x17007B58 RID: 31576
		// (get) Token: 0x06031D0D RID: 204045 RVA: 0x00B90866 File Offset: 0x00B8EA66
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

		// Token: 0x17007B59 RID: 31577
		// (get) Token: 0x06031D0E RID: 204046 RVA: 0x00B90897 File Offset: 0x00B8EA97
		public bool IsFirst
		{
			get
			{
				return this.Rank == 1 && this.IsInRank;
			}
		}

		// Token: 0x17007B5A RID: 31578
		// (get) Token: 0x06031D0F RID: 204047 RVA: 0x00B908AA File Offset: 0x00B8EAAA
		public bool IsSecond
		{
			get
			{
				return this.Rank == 2 && this.IsInRank;
			}
		}

		// Token: 0x17007B5B RID: 31579
		// (get) Token: 0x06031D10 RID: 204048 RVA: 0x00B908BD File Offset: 0x00B8EABD
		public bool IsThird
		{
			get
			{
				return this.Rank == 3 && this.IsInRank;
			}
		}

		// Token: 0x17007B5C RID: 31580
		// (get) Token: 0x06031D11 RID: 204049 RVA: 0x00B908D0 File Offset: 0x00B8EAD0
		public bool IsTopThree
		{
			get
			{
				return this.IsFirst || this.IsSecond || this.IsThird;
			}
		}

		// Token: 0x0401A954 RID: 108884
		public const string FIRSTPLAYER_COLOR = "CB9C38FF";

		// Token: 0x0401A955 RID: 108885
		public const string SECONDPLAYER_COLOR = "6A7E9DFF";

		// Token: 0x0401A956 RID: 108886
		public const string THIRDPLAYER_COLOR = "997E76FF";

		// Token: 0x0401A957 RID: 108887
		public const string FIRST_RANKBG = "T_TipItemBgGold";

		// Token: 0x0401A958 RID: 108888
		public const string SECOND_RANKBG = "T_TipItemBgSilver";

		// Token: 0x0401A959 RID: 108889
		public const string THIRD_RANKBG = "T_TipItemBgCopper";

		// Token: 0x0401A95A RID: 108890
		public const string OTHER_RANKBG = "T_TipItemBgMask";

		// Token: 0x0401A95B RID: 108891
		public const int MAX_COUNT = 3;

		// Token: 0x0401A95C RID: 108892
		public readonly bool IsSelfInData;

		// Token: 0x0401A95D RID: 108893
		public TowerDefencePassInfo ServerData;

		// Token: 0x0401A95E RID: 108894
		public bool IsOnline;

		// Token: 0x0401A95F RID: 108895
		public bool IsDifficult;

		// Token: 0x0401A960 RID: 108896
		public bool IsInRank = true;

		// Token: 0x0401A961 RID: 108897
		public bool IsSelf;

		// Token: 0x0401A962 RID: 108898
		public int Rank;

		// Token: 0x0401A963 RID: 108899
		public readonly List<TowerDefenseRankRoleData> RoleDataList = new List<TowerDefenseRankRoleData>();

		// Token: 0x0401A964 RID: 108900
		private readonly Dictionary<int, string> PlayerNameMap = new Dictionary<int, string>();
	}
}
