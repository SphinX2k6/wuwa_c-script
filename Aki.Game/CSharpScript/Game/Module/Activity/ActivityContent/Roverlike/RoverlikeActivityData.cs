using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005057 RID: 20567
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeActivityData : ActivityBaseData
	{
		// Token: 0x0603377E RID: 210814 RVA: 0x00E69D24 File Offset: 0x00E67F24
		protected override void PhraseEx(ActivityData data)
		{
			RoverRogueActivityData roverRogueActivityData = data.RoverRogueActivityData;
			if (roverRogueActivityData == null)
			{
				return;
			}
			this.HistoryInsInfoInternal = roverRogueActivityData.HistoryInsInfo;
			this.UnlockRoleTypeSetInternal.Clear();
			if (roverRogueActivityData.UnlockRoleType != null)
			{
				foreach (int item in roverRogueActivityData.UnlockRoleType)
				{
					this.UnlockRoleTypeSetInternal.Add(item);
				}
			}
			this.UnlockLootIdSetInternal.Clear();
			if (roverRogueActivityData.UnlockLootIdList != null)
			{
				foreach (int item2 in roverRogueActivityData.UnlockLootIdList)
				{
					this.UnlockLootIdSetInternal.Add(item2);
				}
			}
			this.UnlockBlessRoleIdSetInternal.Clear();
			if (roverRogueActivityData.UnlockBlessRoleIdList != null)
			{
				foreach (int item3 in roverRogueActivityData.UnlockBlessRoleIdList)
				{
					this.UnlockBlessRoleIdSetInternal.Add(item3);
				}
			}
			this.SetEquippedLoot(roverRogueActivityData.EquippedLoot);
			this.UnlockBlessIdSetInternal.Clear();
			if (roverRogueActivityData.UnlockBlessIdList != null)
			{
				foreach (int item4 in roverRogueActivityData.UnlockBlessIdList)
				{
					this.UnlockBlessIdSetInternal.Add(item4);
				}
			}
			this.UnlockItemIdSetInternal.Clear();
			if (roverRogueActivityData.UnlockItemIdList != null)
			{
				foreach (int item5 in roverRogueActivityData.UnlockItemIdList)
				{
					this.UnlockItemIdSetInternal.Add(item5);
				}
			}
			RoverRogueActivity value = this.GetParamConfig().Value;
			if (this.TalentTreeDataInternal == null)
			{
				this.TalentTreeDataInternal = new RoverlikeTalentTreeData();
			}
			this.TalentTreeDataInternal.PhraseEx(base.Id, value.TalentPointItemId, roverRogueActivityData);
			if (this.LevelSelectDataInternal == null)
			{
				this.LevelSelectDataInternal = new RoverlikeLevelSelectData();
			}
			this.LevelSelectDataInternal.PhraseEx(base.Id, roverRogueActivityData);
			this.SyncLevelSelectLootFromEquipped();
			if (this.QuestDataInternal == null)
			{
				this.QuestDataInternal = new RoverlikeQuestData();
			}
			this.QuestDataInternal.PhraseEx(base.Id, roverRogueActivityData);
			if (value.TalentPointItemId > 0)
			{
				RoverlikeModel instance = RoverlikeModel.Instance;
				if (instance != null)
				{
					instance.UpdateCurrencyByItemId(value.TalentPointItemId, roverRogueActivityData.TalentItem);
				}
			}
			if (value.TokenItemId > 0)
			{
				RoverlikeModel instance2 = RoverlikeModel.Instance;
				if (instance2 != null)
				{
					instance2.UpdateCurrencyByItemId(value.TokenItemId, roverRogueActivityData.TokenItem);
				}
			}
			this.RefreshNewLevelUnlockRedDot();
			this.RefreshNewBlessUnlockRedDot();
			this.RefreshNewLootUnlockRedDot();
		}

		// Token: 0x0603377F RID: 210815 RVA: 0x00E69FF8 File Offset: 0x00E681F8
		private void SyncLevelSelectLootFromEquipped()
		{
			RoverlikeLevelSelectData levelSelectDataInternal = this.LevelSelectDataInternal;
			if (levelSelectDataInternal == null)
			{
				return;
			}
			levelSelectDataInternal.SelectedLootId = this.EquippedLootIdInternal;
		}

		// Token: 0x06033780 RID: 210816 RVA: 0x00E6A01C File Offset: 0x00E6821C
		protected override bool GetExDataFinishShowState()
		{
			return this.QuestData.IsAllTaken() && this.IsAllShopGoodsBought();
		}

		// Token: 0x06033781 RID: 210817 RVA: 0x00E6A034 File Offset: 0x00E68234
		public bool IsAllShopGoodsBought()
		{
			RoverRogueActivity? paramConfig = this.GetParamConfig();
			if (paramConfig == null)
			{
				return false;
			}
			int shopId = paramConfig.Value.ShopId;
			int tokenItemId = paramConfig.Value.TokenItemId;
			if (shopId <= 0 || tokenItemId <= 0)
			{
				return false;
			}
			PayShopModel instance = PayShopModel.Instance;
			if (instance == null)
			{
				return false;
			}
			bool result = false;
			foreach (PayShopGoods payShopGoods in instance.GetPayShopGoodsByTabType((PayShopDefine.EPayShopTabType)shopId, 1))
			{
				PayShopGoodsData goodsData = payShopGoods.GetGoodsData();
				if (goodsData != null && goodsData.Price.Id == tokenItemId && goodsData.BuyLimit > 0)
				{
					result = true;
					if (!payShopGoods.IsSoldOut())
					{
						return false;
					}
				}
			}
			return result;
		}

		// Token: 0x06033782 RID: 210818 RVA: 0x00E6A10C File Offset: 0x00E6830C
		public override bool GetExDataRedPointShowState()
		{
			return this.QuestData.HasRedDot() || this.HasShopRedDot() || this.HasNewLevelUnlockRedDot();
		}

		// Token: 0x06033783 RID: 210819 RVA: 0x00E6A12C File Offset: 0x00E6832C
		public bool HasShopRedDot()
		{
			RoverRogueActivity? paramConfig = this.GetParamConfig();
			if (paramConfig == null)
			{
				return false;
			}
			int shopId = paramConfig.Value.ShopId;
			int tokenItemId = paramConfig.Value.TokenItemId;
			if (shopId <= 0 || tokenItemId <= 0)
			{
				return false;
			}
			PayShopModel instance = PayShopModel.Instance;
			if (instance == null)
			{
				return false;
			}
			int shopRedDotPrice = paramConfig.Value.ShopRedDotPrice;
			foreach (PayShopGoods payShopGoods in instance.GetPayShopGoodsByTabType((PayShopDefine.EPayShopTabType)shopId, 1))
			{
				PayShopGoodsData goodsData = payShopGoods.GetGoodsData();
				if (goodsData != null && goodsData.Price.Id == tokenItemId && !payShopGoods.IsSoldOut() && !payShopGoods.IsLocked() && payShopGoods.IfCanBuy() && goodsData.GetNowPrice() > shopRedDotPrice && payShopGoods.GetPriceData().Enough)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06033784 RID: 210820 RVA: 0x00E6A230 File Offset: 0x00E68430
		public RoverRogueActivity? GetParamConfig()
		{
			return RoverlikeConfig.Instance.GetActivityParamConfig(base.Id);
		}

		// Token: 0x06033785 RID: 210821 RVA: 0x00E6A242 File Offset: 0x00E68442
		public bool IsRoleTypeUnlocked(int roleTypeId)
		{
			return this.UnlockRoleTypeSetInternal.Contains(roleTypeId);
		}

		// Token: 0x06033786 RID: 210822 RVA: 0x00E6A250 File Offset: 0x00E68450
		public void AddUnlockRoleType(int roleTypeId)
		{
			this.UnlockRoleTypeSetInternal.Add(roleTypeId);
		}

		// Token: 0x06033787 RID: 210823 RVA: 0x00E6A25F File Offset: 0x00E6845F
		public bool IsBlessRoleUnlocked(int blessRoleId)
		{
			return this.UnlockBlessRoleIdSetInternal.Contains(blessRoleId);
		}

		// Token: 0x06033788 RID: 210824 RVA: 0x00E6A26D File Offset: 0x00E6846D
		public void AddUnlockBlessRole(int blessRoleId)
		{
			this.UnlockBlessRoleIdSetInternal.Add(blessRoleId);
		}

		// Token: 0x06033789 RID: 210825 RVA: 0x00E6A27C File Offset: 0x00E6847C
		public bool IsLootUnlocked(int lootId)
		{
			return this.UnlockLootIdSetInternal.Contains(lootId);
		}

		// Token: 0x0603378A RID: 210826 RVA: 0x00E6A28A File Offset: 0x00E6848A
		public void AddUnlockLoot(int lootId)
		{
			this.UnlockLootIdSetInternal.Add(lootId);
		}

		// Token: 0x0603378B RID: 210827 RVA: 0x00E6A299 File Offset: 0x00E68499
		public bool IsLootFeatureUnlocked()
		{
			return this.EquippedLootIdInternal > 0;
		}

		// Token: 0x0603378C RID: 210828 RVA: 0x00E6A2A4 File Offset: 0x00E684A4
		public int GetEquippedLootId()
		{
			return this.EquippedLootIdInternal;
		}

		// Token: 0x0603378D RID: 210829 RVA: 0x00E6A2AC File Offset: 0x00E684AC
		public void SetEquippedLoot(int lootId)
		{
			int num = (lootId > 0) ? lootId : 0;
			bool flag = this.EquippedLootIdInternal != num;
			this.EquippedLootIdInternal = num;
			this.SyncLevelSelectLootFromEquipped();
			if (flag)
			{
				EventSystem.Instance.Emit<int>(EEventName.RoverlikeEquippedLootChange, num);
			}
		}

		// Token: 0x0603378E RID: 210830 RVA: 0x00E6A2EE File Offset: 0x00E684EE
		public bool IsBlessUnlocked(int blessId)
		{
			return this.UnlockBlessIdSetInternal.Contains(blessId);
		}

		// Token: 0x0603378F RID: 210831 RVA: 0x00E6A2FC File Offset: 0x00E684FC
		public bool IsItemUnlocked(int itemId)
		{
			return this.UnlockItemIdSetInternal.Contains(itemId);
		}

		// Token: 0x06033790 RID: 210832 RVA: 0x00E6A30C File Offset: 0x00E6850C
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"Unlocked",
			"Total"
		})]
		public ValueTuple<int, int> GetItemUnlockProgress()
		{
			int num = 0;
			int num2 = 0;
			foreach (RoverRogueItem roverRogueItem in RoverlikeConfig.Instance.GetItemConfigList())
			{
				if (roverRogueItem.Classify == 2)
				{
					num++;
					if (this.UnlockItemIdSetInternal.Contains(roverRogueItem.Id))
					{
						num2++;
					}
				}
			}
			return new ValueTuple<int, int>(num2, num);
		}

		// Token: 0x17006487 RID: 25735
		// (get) Token: 0x06033791 RID: 210833 RVA: 0x00E6A388 File Offset: 0x00E68588
		[Nullable(2)]
		public RoverRogueHistoryInsInfo HistoryInsInfo
		{
			[NullableContext(2)]
			get
			{
				return this.HistoryInsInfoInternal;
			}
		}

		// Token: 0x06033792 RID: 210834 RVA: 0x00E6A390 File Offset: 0x00E68590
		public bool HasSaveProgress()
		{
			RoverRogueHistoryInsInfo historyInsInfoInternal = this.HistoryInsInfoInternal;
			return ((historyInsInfoInternal != null) ? historyInsInfoInternal.CurInsId : 0) > 0;
		}

		// Token: 0x17006488 RID: 25736
		// (get) Token: 0x06033793 RID: 210835 RVA: 0x00E6A3A7 File Offset: 0x00E685A7
		public RoverlikeTalentTreeData TalentTreeData
		{
			get
			{
				return this.TalentTreeDataInternal;
			}
		}

		// Token: 0x17006489 RID: 25737
		// (get) Token: 0x06033794 RID: 210836 RVA: 0x00E6A3AF File Offset: 0x00E685AF
		public RoverlikeLevelSelectData LevelSelectData
		{
			get
			{
				return this.LevelSelectDataInternal;
			}
		}

		// Token: 0x06033795 RID: 210837 RVA: 0x00E6A3B7 File Offset: 0x00E685B7
		public bool HasNewLevelUnlockRedDot()
		{
			return this.HasNewLevelUnlockRedDotInternal;
		}

		// Token: 0x06033796 RID: 210838 RVA: 0x00E6A3C0 File Offset: 0x00E685C0
		public void RefreshNewLevelUnlockRedDot()
		{
			RoverlikeLevelSelectData levelSelectDataInternal = this.LevelSelectDataInternal;
			if (levelSelectDataInternal == null)
			{
				return;
			}
			List<int> unlockedInsIdList = levelSelectDataInternal.GetUnlockedInsIdList();
			HashSet<int> seenUnlockedInsIds = this.GetSeenUnlockedInsIds();
			if (seenUnlockedInsIds == null)
			{
				this.SaveSeenUnlockedInsIds(new HashSet<int>(unlockedInsIdList));
				this.SetNewLevelUnlockRedDot(false);
				return;
			}
			bool newLevelUnlockRedDot = false;
			foreach (int item in unlockedInsIdList)
			{
				if (!seenUnlockedInsIds.Contains(item))
				{
					newLevelUnlockRedDot = true;
					break;
				}
			}
			this.SetNewLevelUnlockRedDot(newLevelUnlockRedDot);
		}

		// Token: 0x06033797 RID: 210839 RVA: 0x00E6A450 File Offset: 0x00E68650
		public void MarkLevelUnlockRedDotRead()
		{
			RoverlikeLevelSelectData levelSelectDataInternal = this.LevelSelectDataInternal;
			if (levelSelectDataInternal == null)
			{
				return;
			}
			this.SaveSeenUnlockedInsIds(new HashSet<int>(levelSelectDataInternal.GetUnlockedInsIdList()));
			this.SetNewLevelUnlockRedDot(false);
		}

		// Token: 0x06033798 RID: 210840 RVA: 0x00E6A480 File Offset: 0x00E68680
		private void SetNewLevelUnlockRedDot(bool value)
		{
			if (this.HasNewLevelUnlockRedDotInternal == value)
			{
				return;
			}
			this.HasNewLevelUnlockRedDotInternal = value;
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06033799 RID: 210841 RVA: 0x00E6A4A9 File Offset: 0x00E686A9
		[NullableContext(2)]
		private HashSet<int> GetSeenUnlockedInsIds()
		{
			return LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoverRogueSeenUnlockedInsIds, null);
		}

		// Token: 0x0603379A RID: 210842 RVA: 0x00E6A4B6 File Offset: 0x00E686B6
		private void SaveSeenUnlockedInsIds(HashSet<int> ids)
		{
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoverRogueSeenUnlockedInsIds, ids);
		}

		// Token: 0x0603379B RID: 210843 RVA: 0x00E6A4C4 File Offset: 0x00E686C4
		public bool HasNewBlessUnlockRedDot()
		{
			return this.HasNewBlessUnlockRedDotInternal;
		}

		// Token: 0x0603379C RID: 210844 RVA: 0x00E6A4CC File Offset: 0x00E686CC
		public IReadOnlySet<int> GetNewUnlockedBlessIds()
		{
			return this.NewUnlockedBlessIdSetInternal;
		}

		// Token: 0x0603379D RID: 210845 RVA: 0x00E6A4D4 File Offset: 0x00E686D4
		public bool IsBlessNewUnlocked(int blessId)
		{
			return this.NewUnlockedBlessIdSetInternal.Contains(blessId);
		}

		// Token: 0x0603379E RID: 210846 RVA: 0x00E6A4E4 File Offset: 0x00E686E4
		public void RefreshNewBlessUnlockRedDot()
		{
			List<int> list = new List<int>(this.UnlockBlessIdSetInternal);
			HashSet<int> seenUnlockedBlessIds = this.GetSeenUnlockedBlessIds();
			if (seenUnlockedBlessIds == null)
			{
				this.SaveSeenUnlockedBlessIds(new HashSet<int>(list));
				this.NewUnlockedBlessIdSetInternal.Clear();
				this.SetNewBlessUnlockRedDot(false);
				return;
			}
			this.NewUnlockedBlessIdSetInternal.Clear();
			foreach (int item in list)
			{
				if (!seenUnlockedBlessIds.Contains(item))
				{
					this.NewUnlockedBlessIdSetInternal.Add(item);
				}
			}
			this.SetNewBlessUnlockRedDot(this.NewUnlockedBlessIdSetInternal.Count > 0);
		}

		// Token: 0x0603379F RID: 210847 RVA: 0x00E6A598 File Offset: 0x00E68798
		public void MarkBlessUnlockRedDotRead()
		{
			this.SaveSeenUnlockedBlessIds(new HashSet<int>(this.UnlockBlessIdSetInternal));
			this.SetNewBlessUnlockRedDot(false);
		}

		// Token: 0x060337A0 RID: 210848 RVA: 0x00E6A5B2 File Offset: 0x00E687B2
		public void ClearNewUnlockedBlessIds()
		{
			this.NewUnlockedBlessIdSetInternal.Clear();
		}

		// Token: 0x060337A1 RID: 210849 RVA: 0x00E6A5BF File Offset: 0x00E687BF
		public void MarkBlessNewUnlockedRead(int blessId)
		{
			this.NewUnlockedBlessIdSetInternal.Remove(blessId);
		}

		// Token: 0x060337A2 RID: 210850 RVA: 0x00E6A5CE File Offset: 0x00E687CE
		private void SetNewBlessUnlockRedDot(bool value)
		{
			if (this.HasNewBlessUnlockRedDotInternal == value)
			{
				return;
			}
			this.HasNewBlessUnlockRedDotInternal = value;
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x060337A3 RID: 210851 RVA: 0x00E6A5F7 File Offset: 0x00E687F7
		[NullableContext(2)]
		private HashSet<int> GetSeenUnlockedBlessIds()
		{
			return LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoverRogueSeenUnlockedBlessIds, null);
		}

		// Token: 0x060337A4 RID: 210852 RVA: 0x00E6A604 File Offset: 0x00E68804
		private void SaveSeenUnlockedBlessIds(HashSet<int> ids)
		{
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoverRogueSeenUnlockedBlessIds, ids);
		}

		// Token: 0x060337A5 RID: 210853 RVA: 0x00E6A612 File Offset: 0x00E68812
		public bool HasNewLootUnlockRedDot()
		{
			return this.IsLootFeatureUnlocked() && this.HasNewLootUnlockRedDotInternal;
		}

		// Token: 0x060337A6 RID: 210854 RVA: 0x00E6A624 File Offset: 0x00E68824
		public IReadOnlySet<int> GetNewUnlockedLootIds()
		{
			return this.NewUnlockedLootIdSetInternal;
		}

		// Token: 0x060337A7 RID: 210855 RVA: 0x00E6A62C File Offset: 0x00E6882C
		public bool IsLootNewUnlocked(int lootId)
		{
			return this.NewUnlockedLootIdSetInternal.Contains(lootId);
		}

		// Token: 0x060337A8 RID: 210856 RVA: 0x00E6A63C File Offset: 0x00E6883C
		public void RefreshNewLootUnlockRedDot()
		{
			List<int> list = new List<int>(this.UnlockLootIdSetInternal);
			HashSet<int> seenUnlockedLootIds = this.GetSeenUnlockedLootIds();
			if (seenUnlockedLootIds == null)
			{
				this.SaveSeenUnlockedLootIds(new HashSet<int>(list));
				this.NewUnlockedLootIdSetInternal.Clear();
				this.SetNewLootUnlockRedDot(false);
				return;
			}
			this.NewUnlockedLootIdSetInternal.Clear();
			foreach (int item in list)
			{
				if (!seenUnlockedLootIds.Contains(item))
				{
					this.NewUnlockedLootIdSetInternal.Add(item);
				}
			}
			this.SetNewLootUnlockRedDot(this.NewUnlockedLootIdSetInternal.Count > 0);
		}

		// Token: 0x060337A9 RID: 210857 RVA: 0x00E6A6F0 File Offset: 0x00E688F0
		public void MarkLootUnlockRedDotRead()
		{
			this.SaveSeenUnlockedLootIds(new HashSet<int>(this.UnlockLootIdSetInternal));
			this.SetNewLootUnlockRedDot(false);
		}

		// Token: 0x060337AA RID: 210858 RVA: 0x00E6A70A File Offset: 0x00E6890A
		public void ClearNewUnlockedLootIds()
		{
			this.NewUnlockedLootIdSetInternal.Clear();
		}

		// Token: 0x060337AB RID: 210859 RVA: 0x00E6A717 File Offset: 0x00E68917
		public void MarkLootNewUnlockedRead(int lootId)
		{
			this.NewUnlockedLootIdSetInternal.Remove(lootId);
		}

		// Token: 0x060337AC RID: 210860 RVA: 0x00E6A726 File Offset: 0x00E68926
		private void SetNewLootUnlockRedDot(bool value)
		{
			if (this.HasNewLootUnlockRedDotInternal == value)
			{
				return;
			}
			this.HasNewLootUnlockRedDotInternal = value;
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x060337AD RID: 210861 RVA: 0x00E6A74F File Offset: 0x00E6894F
		[NullableContext(2)]
		private HashSet<int> GetSeenUnlockedLootIds()
		{
			return LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoverRogueSeenUnlockedLootIds, null);
		}

		// Token: 0x060337AE RID: 210862 RVA: 0x00E6A75C File Offset: 0x00E6895C
		private void SaveSeenUnlockedLootIds(HashSet<int> ids)
		{
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoverRogueSeenUnlockedLootIds, ids);
		}

		// Token: 0x1700648A RID: 25738
		// (get) Token: 0x060337AF RID: 210863 RVA: 0x00E6A76C File Offset: 0x00E6896C
		public RoverlikeQuestData QuestData
		{
			get
			{
				RoverlikeQuestData result;
				if ((result = this.QuestDataInternal) == null)
				{
					result = (this.QuestDataInternal = new RoverlikeQuestData());
				}
				return result;
			}
		}

		// Token: 0x060337B0 RID: 210864 RVA: 0x00E6A794 File Offset: 0x00E68994
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"Finished",
			"Total"
		})]
		public ValueTuple<int, int> GetQuestProgress()
		{
			RoverlikeQuestData questData = this.QuestData;
			return new ValueTuple<int, int>(questData.GetTakenCount(), questData.GetTotalCount());
		}

		// Token: 0x060337B1 RID: 210865 RVA: 0x00E6A7BC File Offset: 0x00E689BC
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"Spent",
			"Total"
		})]
		public ValueTuple<int, int> GetShopProgress()
		{
			RoverRogueActivity? paramConfig = this.GetParamConfig();
			if (paramConfig == null)
			{
				return new ValueTuple<int, int>(0, 0);
			}
			int shopId = paramConfig.Value.ShopId;
			int tokenItemId = paramConfig.Value.TokenItemId;
			if (shopId <= 0 || tokenItemId <= 0)
			{
				return new ValueTuple<int, int>(0, 0);
			}
			PayShopModel instance = PayShopModel.Instance;
			if (instance == null)
			{
				return new ValueTuple<int, int>(0, 0);
			}
			int num = 0;
			int num2 = 0;
			foreach (PayShopGoods payShopGoods in instance.GetPayShopGoodsByTabType((PayShopDefine.EPayShopTabType)shopId, 1))
			{
				PayShopGoodsData goodsData = payShopGoods.GetGoodsData();
				if (goodsData != null && goodsData.Price.Id == tokenItemId)
				{
					int buyLimit = goodsData.BuyLimit;
					if (buyLimit > 0)
					{
						int nowPrice = goodsData.GetNowPrice();
						num += nowPrice * goodsData.BoughtCount;
						num2 += nowPrice * buyLimit;
					}
				}
			}
			return new ValueTuple<int, int>(num, num2);
		}

		// Token: 0x0401B562 RID: 111970
		private readonly HashSet<int> UnlockRoleTypeSetInternal = new HashSet<int>();

		// Token: 0x0401B563 RID: 111971
		private readonly HashSet<int> UnlockBlessRoleIdSetInternal = new HashSet<int>();

		// Token: 0x0401B564 RID: 111972
		private readonly HashSet<int> UnlockLootIdSetInternal = new HashSet<int>();

		// Token: 0x0401B565 RID: 111973
		private int EquippedLootIdInternal;

		// Token: 0x0401B566 RID: 111974
		private readonly HashSet<int> UnlockBlessIdSetInternal = new HashSet<int>();

		// Token: 0x0401B567 RID: 111975
		private readonly HashSet<int> UnlockItemIdSetInternal = new HashSet<int>();

		// Token: 0x0401B568 RID: 111976
		[Nullable(2)]
		private RoverRogueHistoryInsInfo HistoryInsInfoInternal;

		// Token: 0x0401B569 RID: 111977
		[Nullable(2)]
		private RoverlikeTalentTreeData TalentTreeDataInternal;

		// Token: 0x0401B56A RID: 111978
		[Nullable(2)]
		private RoverlikeLevelSelectData LevelSelectDataInternal;

		// Token: 0x0401B56B RID: 111979
		private bool HasNewLevelUnlockRedDotInternal;

		// Token: 0x0401B56C RID: 111980
		private bool HasNewBlessUnlockRedDotInternal;

		// Token: 0x0401B56D RID: 111981
		private readonly HashSet<int> NewUnlockedBlessIdSetInternal = new HashSet<int>();

		// Token: 0x0401B56E RID: 111982
		private bool HasNewLootUnlockRedDotInternal;

		// Token: 0x0401B56F RID: 111983
		private readonly HashSet<int> NewUnlockedLootIdSetInternal = new HashSet<int>();

		// Token: 0x0401B570 RID: 111984
		[Nullable(2)]
		private RoverlikeQuestData QuestDataInternal;
	}
}
