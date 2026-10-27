using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x02005294 RID: 21140
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleData
	{
		// Token: 0x060360EF RID: 221423 RVA: 0x00CCB100 File Offset: 0x00CC9300
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

		// Token: 0x060360F0 RID: 221424 RVA: 0x00CCB1A0 File Offset: 0x00CC93A0
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

		// Token: 0x060360F1 RID: 221425 RVA: 0x00CCB240 File Offset: 0x00CC9440
		public List<long> GetNpcEntityIdList()
		{
			List<long> list = new List<long>();
			foreach (long item in this.NpcMonsterEntityIncIdMap.Values)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060360F2 RID: 221426 RVA: 0x00CCB2A0 File Offset: 0x00CC94A0
		public List<long> GetPlayerEntityIdList()
		{
			List<long> list = new List<long>();
			foreach (long item in this.PlayerEntityIncIdListMap.Values)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060360F3 RID: 221427 RVA: 0x00CCB300 File Offset: 0x00CC9500
		public List<long> GetPlayerEntityIdListBySort()
		{
			List<long> playerEntityIdList = this.GetPlayerEntityIdList();
			playerEntityIdList.Sort(new Comparison<long>(this.SortByCost));
			return playerEntityIdList;
		}

		// Token: 0x060360F4 RID: 221428 RVA: 0x00CCB31A File Offset: 0x00CC951A
		public List<long> GetNpcEntityIdListBySort()
		{
			List<long> npcEntityIdList = this.GetNpcEntityIdList();
			npcEntityIdList.Sort(new Comparison<long>(this.SortByCost));
			return npcEntityIdList;
		}

		// Token: 0x060360F5 RID: 221429 RVA: 0x00CCB334 File Offset: 0x00CC9534
		public List<long> GetAllEntityIdList()
		{
			List<long> list = new List<long>();
			list.AddRange(this.GetNpcEntityIdList());
			list.AddRange(this.GetPlayerEntityIdList());
			return list;
		}

		// Token: 0x060360F6 RID: 221430 RVA: 0x00CCB353 File Offset: 0x00CC9553
		public PhantomCardData GetCardDataByEntityId(long entityId)
		{
			if (!this.EntityIdCardDataMap.ContainsKey(entityId))
			{
				return null;
			}
			return this.EntityIdCardDataMap[entityId];
		}

		// Token: 0x060360F7 RID: 221431 RVA: 0x00CCB371 File Offset: 0x00CC9571
		public void CreatePrepareLoadingPromise()
		{
			this.PrepareLoadingPromise = new CustomPromise();
		}

		// Token: 0x060360F8 RID: 221432 RVA: 0x00CCB37E File Offset: 0x00CC957E
		public void FinishPrepareLoadingPromise()
		{
			CustomPromise prepareLoadingPromise = this.PrepareLoadingPromise;
			if (prepareLoadingPromise != null)
			{
				prepareLoadingPromise.SetResult();
			}
			this.PrepareLoadingPromise = null;
		}

		// Token: 0x060360F9 RID: 221433 RVA: 0x00CCB398 File Offset: 0x00CC9598
		public void Clear()
		{
			this.NpcMonsterEntityIncIdMap.Clear();
			this.PlayerEntityIncIdListMap.Clear();
			this.EntityIdCardDataMap.Clear();
		}

		// Token: 0x060360FA RID: 221434 RVA: 0x00CCB3BC File Offset: 0x00CC95BC
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

		// Token: 0x0401C9F2 RID: 117234
		private readonly Dictionary<int, long> NpcMonsterEntityIncIdMap = new Dictionary<int, long>();

		// Token: 0x0401C9F3 RID: 117235
		private readonly Dictionary<int, long> PlayerEntityIncIdListMap = new Dictionary<int, long>();

		// Token: 0x0401C9F4 RID: 117236
		private readonly Dictionary<long, PhantomCardData> EntityIdCardDataMap = new Dictionary<long, PhantomCardData>();

		// Token: 0x0401C9F5 RID: 117237
		[Nullable(2)]
		public CustomPromise PrepareLoadingPromise;
	}
}
