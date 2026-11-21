using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x02004264 RID: 16996
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleData
	{
		// Token: 0x0602AFEA RID: 176106 RVA: 0x00C18804 File Offset: 0x00C16A04
		public void SetNpcMonsterEntityData(Dictionary<int, long> data)
		{
			this.NpcMonsterEntityIncIdMap.Clear();
			foreach (KeyValuePair<int, long> keyValuePair in data)
			{
				int key = keyValuePair.Key;
				long num = MathUtils.Instance.LongToNumber(keyValuePair.Value);
				this.NpcMonsterEntityIncIdMap[key] = num;
				PhantomCardData cardDataByFightId = PhantomArenaBattleModel.Instance.OpponentData.GetCardDataByFightId(key);
				if (cardDataByFightId != null)
				{
					this.EntityIdCardDataMap[num] = cardDataByFightId;
				}
			}
		}

		// Token: 0x0602AFEB RID: 176107 RVA: 0x00C188A4 File Offset: 0x00C16AA4
		public void SetPlayerEntityData(Dictionary<int, long> data)
		{
			this.PlayerEntityIncIdListMap.Clear();
			foreach (KeyValuePair<int, long> keyValuePair in data)
			{
				int key = keyValuePair.Key;
				long num = MathUtils.Instance.LongToNumber(keyValuePair.Value);
				this.PlayerEntityIncIdListMap[key] = num;
				PhantomCardData cardDataByFightId = PhantomArenaBattleModel.Instance.OwnData.GetCardDataByFightId(key);
				if (cardDataByFightId != null)
				{
					this.EntityIdCardDataMap[num] = cardDataByFightId;
				}
			}
		}

		// Token: 0x0602AFEC RID: 176108 RVA: 0x00C18944 File Offset: 0x00C16B44
		public List<long> GetNpcEntityIdList()
		{
			List<long> list = new List<long>();
			foreach (long item in this.NpcMonsterEntityIncIdMap.Values)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x0602AFED RID: 176109 RVA: 0x00C189A4 File Offset: 0x00C16BA4
		public List<long> GetPlayerEntityIdList()
		{
			List<long> list = new List<long>();
			foreach (long item in this.PlayerEntityIncIdListMap.Values)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x0602AFEE RID: 176110 RVA: 0x00C18A04 File Offset: 0x00C16C04
		public List<long> GetPlayerEntityIdListBySort()
		{
			List<long> playerEntityIdList = this.GetPlayerEntityIdList();
			playerEntityIdList.Sort(new Comparison<long>(this.SortByCost));
			return playerEntityIdList;
		}

		// Token: 0x0602AFEF RID: 176111 RVA: 0x00C18A1E File Offset: 0x00C16C1E
		public List<long> GetNpcEntityIdListBySort()
		{
			List<long> npcEntityIdList = this.GetNpcEntityIdList();
			npcEntityIdList.Sort(new Comparison<long>(this.SortByCost));
			return npcEntityIdList;
		}

		// Token: 0x0602AFF0 RID: 176112 RVA: 0x00C18A38 File Offset: 0x00C16C38
		public List<long> GetAllEntityIdList()
		{
			List<long> list = new List<long>();
			list.AddRange(this.GetNpcEntityIdList());
			list.AddRange(this.GetPlayerEntityIdList());
			return list;
		}

		// Token: 0x0602AFF1 RID: 176113 RVA: 0x00C18A57 File Offset: 0x00C16C57
		public PhantomCardData GetCardDataByEntityId(long entityId)
		{
			if (!this.EntityIdCardDataMap.ContainsKey(entityId))
			{
				return null;
			}
			return this.EntityIdCardDataMap[entityId];
		}

		// Token: 0x0602AFF2 RID: 176114 RVA: 0x00C18A75 File Offset: 0x00C16C75
		public void CreatePrepareLoadingPromise()
		{
			this.PrepareLoadingPromise = new CustomPromise();
		}

		// Token: 0x0602AFF3 RID: 176115 RVA: 0x00C18A82 File Offset: 0x00C16C82
		public void FinishPrepareLoadingPromise()
		{
			CustomPromise prepareLoadingPromise = this.PrepareLoadingPromise;
			if (prepareLoadingPromise != null)
			{
				prepareLoadingPromise.SetResult();
			}
			this.PrepareLoadingPromise = null;
		}

		// Token: 0x0602AFF4 RID: 176116 RVA: 0x00C18A9C File Offset: 0x00C16C9C
		public void Clear()
		{
			this.NpcMonsterEntityIncIdMap.Clear();
			this.PlayerEntityIncIdListMap.Clear();
			this.EntityIdCardDataMap.Clear();
		}

		// Token: 0x0602AFF5 RID: 176117 RVA: 0x00C18AC0 File Offset: 0x00C16CC0
		private int SortByCost(long aEntityId, long bEntityId)
		{
			PhantomCardData phantomCardData = this.EntityIdCardDataMap.ContainsKey(aEntityId) ? this.EntityIdCardDataMap[aEntityId] : null;
			PhantomCardData phantomCardData2 = this.EntityIdCardDataMap.ContainsKey(bEntityId) ? this.EntityIdCardDataMap[bEntityId] : null;
			if (phantomCardData == null || phantomCardData2 == null)
			{
				return -1;
			}
			if (phantomCardData.ConfigCost == phantomCardData2.ConfigCost)
			{
				return -1;
			}
			return phantomCardData2.ConfigCost - phantomCardData.ConfigCost;
		}

		// Token: 0x04017427 RID: 95271
		private readonly Dictionary<int, long> NpcMonsterEntityIncIdMap = new Dictionary<int, long>();

		// Token: 0x04017428 RID: 95272
		private readonly Dictionary<int, long> PlayerEntityIncIdListMap = new Dictionary<int, long>();

		// Token: 0x04017429 RID: 95273
		private readonly Dictionary<long, PhantomCardData> EntityIdCardDataMap = new Dictionary<long, PhantomCardData>();

		// Token: 0x0401742A RID: 95274
		[Nullable(2)]
		public CustomPromise PrepareLoadingPromise;
	}
}
