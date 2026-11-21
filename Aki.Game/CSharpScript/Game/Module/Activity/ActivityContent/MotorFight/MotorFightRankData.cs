using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200537F RID: 21375
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightRankData
	{
		// Token: 0x170067B2 RID: 26546
		// (get) Token: 0x0603532B RID: 217899 RVA: 0x00EDB70C File Offset: 0x00ED990C
		// (set) Token: 0x0603532C RID: 217900 RVA: 0x00EDB714 File Offset: 0x00ED9914
		public bool IsMyRank { get; set; }

		// Token: 0x0603532D RID: 217901 RVA: 0x00EDB71D File Offset: 0x00ED991D
		public MotorFightRankData(bool isMyRank = false)
		{
			this.IsMyRank = isMyRank;
		}

		// Token: 0x0603532E RID: 217902 RVA: 0x00EDB758 File Offset: 0x00ED9958
		public void SetDataByConfig(MotorFightRank data)
		{
			RoleInfo? roleConfig = this.GetRoleConfig(data.RoleId);
			this.Name = ConfigMultiTextLang.GetLocalTextNew(roleConfig.Value.Name, null);
			this.TexturePath = roleConfig.Value.FormationRoleCard;
			this.Score = data.Score;
			this.WaveNum = data.WaveNum;
			this.KillNum = data.KillNum;
			this.DisplayThreshold = data.DisplayThreshold;
			this.BuffGateNum = data.BuffGateNum;
			foreach (DicIntInt dicIntInt in data.CollectionItemIter())
			{
				int key = dicIntInt.Key;
				int value = dicIntInt.Value;
				MotorFightItem value2 = MotorFightConfig.Instance.GetMotorFightItemConfig(key).Value;
				MotorFightItemData item = new MotorFightItemData(value2, new int?(value));
				this.ItemList.Add(item);
				if (!this.ItemNumMap.ContainsKey(value2.Type))
				{
					this.ItemNumMap[value2.Type] = new Dictionary<int, int>();
				}
				Dictionary<int, int> dictionary = this.ItemNumMap[value2.Type];
				if (!dictionary.ContainsKey(value2.Quality))
				{
					dictionary[value2.Quality] = 0;
				}
				dictionary[value2.Quality] = (dictionary.ContainsKey(value2.Quality) ? dictionary[value2.Quality] : 0) + value;
				this.ItemNumMap[value2.Type] = dictionary;
			}
			this.ItemList.Sort(new Comparison<MotorFightItemData>(this.SortItemList));
			this.HasData = true;
		}

		// Token: 0x0603532F RID: 217903 RVA: 0x00EDB938 File Offset: 0x00ED9B38
		[NullableContext(2)]
		public void SetDataByServerInfo(MotorFightPlayerRankingInfo data)
		{
			if (data == null || data.ResultCommon.TotalScore == 0)
			{
				this.Name = FunctionModel.Instance.GetPlayerName();
				int trialRoleId = MotorFightController.Instance.GetMotorFightActivityData().GetMotorFightRoleList()[0].TrialRoleId;
				this.TexturePath = this.GetRoleConfig(RoleConfig.Instance.GetTrialRoleConfig(trialRoleId).Value.ParentId).Value.FormationRoleCard;
				return;
			}
			this.Name = data.Name;
			this.Score = data.ResultCommon.TotalScore;
			this.KillNum = data.ResultCommon.KillMonsterCount;
			this.WaveNum = data.ResultCommon.PassedWaveNum;
			this.BuffGateNum = data.ResultCommon.SelectedBuffGateCount;
			this.ItemList = new List<MotorFightItemData>();
			foreach (MotorFightCollectItemInfo motorFightCollectItemInfo in data.ResultCommon.Items)
			{
				MotorFightItem value = MotorFightConfig.Instance.GetMotorFightItemConfig(motorFightCollectItemInfo.ItemId).Value;
				MotorFightItemData item = new MotorFightItemData(value, new int?(motorFightCollectItemInfo.Count));
				this.ItemList.Add(item);
				if (!this.ItemNumMap.ContainsKey(value.Type))
				{
					this.ItemNumMap[value.Type] = new Dictionary<int, int>();
				}
				Dictionary<int, int> dictionary = this.ItemNumMap[value.Type];
				if (!dictionary.ContainsKey(value.Quality))
				{
					dictionary[value.Quality] = 0;
				}
				dictionary[value.Quality] = (dictionary.ContainsKey(value.Quality) ? dictionary[value.Quality] : 0) + motorFightCollectItemInfo.Count;
				this.ItemNumMap[value.Type] = dictionary;
			}
			this.ItemList.Sort(new Comparison<MotorFightItemData>(this.SortItemList));
			MotorFightRole? motorFightRoleConfig = MotorFightConfig.Instance.GetMotorFightRoleConfig(data.ResultCommon.RoleId);
			if (motorFightRoleConfig == null)
			{
				return;
			}
			this.TexturePath = this.GetRoleConfig(RoleConfig.Instance.GetTrialRoleConfig(motorFightRoleConfig.Value.TrialRole).Value.ParentId).Value.FormationRoleCard;
			this.HasData = true;
		}

		// Token: 0x06035330 RID: 217904 RVA: 0x00EDBBDC File Offset: 0x00ED9DDC
		private RoleInfo? GetRoleConfig(int roleId)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
			if (roleConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorFightActivity;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "摩托战斗排行榜角色数据异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return roleConfig;
		}

		// Token: 0x06035331 RID: 217905 RVA: 0x00EDBC38 File Offset: 0x00ED9E38
		private int SortItemList(MotorFightItemData a, MotorFightItemData b)
		{
			if (a.Type != b.Type)
			{
				Dictionary<int, int> dictionary = this.ItemNumMap[a.Type];
				Dictionary<int, int> dictionary2 = this.ItemNumMap[b.Type];
				if (dictionary.Count != dictionary2.Count)
				{
					return dictionary2.Count - dictionary.Count;
				}
				for (int i = 5; i >= 3; i--)
				{
					int num = dictionary.ContainsKey(i) ? dictionary[i] : 0;
					int num2 = dictionary2.ContainsKey(i) ? dictionary2[i] : 0;
					if (num != num2)
					{
						return num2 - num;
					}
				}
				return a.Type - b.Type;
			}
			else
			{
				if (a.Quality != b.Quality)
				{
					return b.Quality - a.Quality;
				}
				return a.Id - b.Id;
			}
		}

		// Token: 0x0401C101 RID: 114945
		private const int HIGHEST_QUALITY = 5;

		// Token: 0x0401C102 RID: 114946
		private const int LOWEST_QUALITY = 3;

		// Token: 0x0401C103 RID: 114947
		public string Name = "";

		// Token: 0x0401C104 RID: 114948
		public bool HasData;

		// Token: 0x0401C105 RID: 114949
		public int Score;

		// Token: 0x0401C106 RID: 114950
		public string TexturePath = "";

		// Token: 0x0401C107 RID: 114951
		public int KillNum;

		// Token: 0x0401C108 RID: 114952
		public int WaveNum;

		// Token: 0x0401C109 RID: 114953
		public int BuffGateNum;

		// Token: 0x0401C10A RID: 114954
		public int DisplayThreshold;

		// Token: 0x0401C10B RID: 114955
		public Dictionary<int, Dictionary<int, int>> ItemNumMap = new Dictionary<int, Dictionary<int, int>>();

		// Token: 0x0401C10D RID: 114957
		public List<MotorFightItemData> ItemList = new List<MotorFightItemData>();
	}
}
