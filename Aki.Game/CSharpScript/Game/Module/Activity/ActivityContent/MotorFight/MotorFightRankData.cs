using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006401 RID: 25601
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightRankData
	{
		// Token: 0x17009450 RID: 37968
		// (get) Token: 0x0604066A RID: 263786 RVA: 0x00F9476C File Offset: 0x00F9296C
		// (set) Token: 0x0604066B RID: 263787 RVA: 0x00F94774 File Offset: 0x00F92974
		public bool IsMyRank { get; set; }

		// Token: 0x0604066C RID: 263788 RVA: 0x00F9477D File Offset: 0x00F9297D
		public MotorFightRankData(bool isMyRank = false)
		{
			this.IsMyRank = isMyRank;
		}

		// Token: 0x0604066D RID: 263789 RVA: 0x00F947B8 File Offset: 0x00F929B8
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

		// Token: 0x0604066E RID: 263790 RVA: 0x00F94998 File Offset: 0x00F92B98
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

		// Token: 0x0604066F RID: 263791 RVA: 0x00F94C3C File Offset: 0x00F92E3C
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

		// Token: 0x06040670 RID: 263792 RVA: 0x00F94C98 File Offset: 0x00F92E98
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

		// Token: 0x040217D2 RID: 137170
		private const int HIGHEST_QUALITY = 5;

		// Token: 0x040217D3 RID: 137171
		private const int LOWEST_QUALITY = 3;

		// Token: 0x040217D4 RID: 137172
		public string Name = "";

		// Token: 0x040217D5 RID: 137173
		public bool HasData;

		// Token: 0x040217D6 RID: 137174
		public int Score;

		// Token: 0x040217D7 RID: 137175
		public string TexturePath = "";

		// Token: 0x040217D8 RID: 137176
		public int KillNum;

		// Token: 0x040217D9 RID: 137177
		public int WaveNum;

		// Token: 0x040217DA RID: 137178
		public int BuffGateNum;

		// Token: 0x040217DB RID: 137179
		public int DisplayThreshold;

		// Token: 0x040217DC RID: 137180
		public Dictionary<int, Dictionary<int, int>> ItemNumMap = new Dictionary<int, Dictionary<int, int>>();

		// Token: 0x040217DE RID: 137182
		public List<MotorFightItemData> ItemList = new List<MotorFightItemData>();
	}
}
