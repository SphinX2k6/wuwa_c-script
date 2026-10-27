using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060D9 RID: 24793
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeActivityData : ActivityBaseData
	{
		// Token: 0x0603EABA RID: 256698 RVA: 0x00F22F5C File Offset: 0x00F2115C
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

		// Token: 0x0603EABB RID: 256699 RVA: 0x00F23230 File Offset: 0x00F21430
		private void SyncLevelSelectLootFromEquipped()
		{
			RoverlikeLevelSelectData levelSelectDataInternal = this.LevelSelectDataInternal;
			if (levelSelectDataInternal == null)
			{
				return;
			}
			levelSelectDataInternal.SelectedLootId = this.EquippedLootIdInternal;
		}

		// Token: 0x0603EABC RID: 256700 RVA: 0x00F23254 File Offset: 0x00F21454
		protected override bool GetExDataFinishShowState()
		{
			return this.QuestData.IsAllTaken() && this.IsAllShopGoodsBought();
		}

		// Token: 0x0603EABD RID: 256701 RVA: 0x00F2326C File Offset: 0x00F2146C
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

		// Token: 0x0603EABE RID: 256702 RVA: 0x00F23344 File Offset: 0x00F21544
		public override bool GetExDataRedPointShowState()
		{
			return this.QuestData.HasRedDot() || this.HasShopRedDot() || this.HasNewLevelUnlockRedDot();
		}

		// Token: 0x0603EABF RID: 256703 RVA: 0x00F23364 File Offset: 0x00F21564
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

		// Token: 0x0603EAC0 RID: 256704 RVA: 0x00F23468 File Offset: 0x00F21668
		public RoverRogueActivity? GetParamConfig()
		{
			return RoverlikeConfig.Instance.GetActivityParamConfig(base.Id);
		}

		// Token: 0x0603EAC1 RID: 256705 RVA: 0x00F2347A File Offset: 0x00F2167A
		public bool IsRoleTypeUnlocked(int roleTypeId)
		{
			return this.UnlockRoleTypeSetInternal.Contains(roleTypeId);
		}

		// Token: 0x0603EAC2 RID: 256706 RVA: 0x00F23488 File Offset: 0x00F21688
		public void AddUnlockRoleType(int roleTypeId)
		{
			this.UnlockRoleTypeSetInternal.Add(roleTypeId);
		}

		// Token: 0x0603EAC3 RID: 256707 RVA: 0x00F23497 File Offset: 0x00F21697
		public bool IsBlessRoleUnlocked(int blessRoleId)
		{
			return this.UnlockBlessRoleIdSetInternal.Contains(blessRoleId);
		}

		// Token: 0x0603EAC4 RID: 256708 RVA: 0x00F234A5 File Offset: 0x00F216A5
		public void AddUnlockBlessRole(int blessRoleId)
		{
			this.UnlockBlessRoleIdSetInternal.Add(blessRoleId);
		}

		// Token: 0x0603EAC5 RID: 256709 RVA: 0x00F234B4 File Offset: 0x00F216B4
		public bool IsLootUnlocked(int lootId)
		{
			return this.UnlockLootIdSetInternal.Contains(lootId);
		}

		// Token: 0x0603EAC6 RID: 256710 RVA: 0x00F234C2 File Offset: 0x00F216C2
		public void AddUnlockLoot(int lootId)
		{
			this.UnlockLootIdSetInternal.Add(lootId);
		}

		// Token: 0x0603EAC7 RID: 256711 RVA: 0x00F234D1 File Offset: 0x00F216D1
		public bool IsLootFeatureUnlocked()
		{
			return this.EquippedLootIdInternal > 0;
		}

		// Token: 0x0603EAC8 RID: 256712 RVA: 0x00F234DC File Offset: 0x00F216DC
		public int GetEquippedLootId()
		{
			return this.EquippedLootIdInternal;
		}

		// Token: 0x0603EAC9 RID: 256713 RVA: 0x00F234E4 File Offset: 0x00F216E4
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

		// Token: 0x0603EACA RID: 256714 RVA: 0x00F23526 File Offset: 0x00F21726
		public bool IsBlessUnlocked(int blessId)
		{
			return this.UnlockBlessIdSetInternal.Contains(blessId);
		}

		// Token: 0x0603EACB RID: 256715 RVA: 0x00F23534 File Offset: 0x00F21734
		public bool IsItemUnlocked(int itemId)
		{
			return this.UnlockItemIdSetInternal.Contains(itemId);
		}

		// Token: 0x0603EACC RID: 256716 RVA: 0x00F23544 File Offset: 0x00F21744
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

		// Token: 0x17009125 RID: 37157
		// (get) Token: 0x0603EACD RID: 256717 RVA: 0x00F235C0 File Offset: 0x00F217C0
		[Nullable(2)]
		public RoverRogueHistoryInsInfo HistoryInsInfo
		{
			[NullableContext(2)]
			get
			{
				return this.HistoryInsInfoInternal;
			}
		}

		// Token: 0x0603EACE RID: 256718 RVA: 0x00F235C8 File Offset: 0x00F217C8
		public bool HasSaveProgress()
		{
			RoverRogueHistoryInsInfo historyInsInfoInternal = this.HistoryInsInfoInternal;
			return ((historyInsInfoInternal != null) ? historyInsInfoInternal.CurInsId : 0) > 0;
		}

		// Token: 0x17009126 RID: 37158
		// (get) Token: 0x0603EACF RID: 256719 RVA: 0x00F235DF File Offset: 0x00F217DF
		public RoverlikeTalentTreeData TalentTreeData
		{
			get
			{
				return this.TalentTreeDataInternal;
			}
		}

		// Token: 0x17009127 RID: 37159
		// (get) Token: 0x0603EAD0 RID: 256720 RVA: 0x00F235E7 File Offset: 0x00F217E7
		public RoverlikeLevelSelectData LevelSelectData
		{
			get
			{
				return this.LevelSelectDataInternal;
			}
		}

		// Token: 0x0603EAD1 RID: 256721 RVA: 0x00F235EF File Offset: 0x00F217EF
		public bool HasNewLevelUnlockRedDot()
		{
			return this.HasNewLevelUnlockRedDotInternal;
		}

		// Token: 0x0603EAD2 RID: 256722 RVA: 0x00F235F8 File Offset: 0x00F217F8
		public void RefreshNewLevelUnlockRedDot()
		{
			RoverlikeLevelSelectData levelSelectDataInternal = this.LevelSelectDataInternal;
			if (levelSelectDataInternal == null)
			{
				return;
			}
			List<int> unlockedInsIdList = levelSelectDataInternal.GetUnlockedInsIdList();
			HashSet<int> seenIds = this.GetSeenUnlockedInsIds();
			if (seenIds == null)
			{
				this.SaveSeenUnlockedInsIds(new HashSet<int>(unlockedInsIdList));
				this.SetNewLevelUnlockRedDot(false);
				return;
			}
			bool newLevelUnlockRedDot = unlockedInsIdList.Any((int instId) => !seenIds.Contains(instId));
			this.SetNewLevelUnlockRedDot(newLevelUnlockRedDot);
		}

		// Token: 0x0603EAD3 RID: 256723 RVA: 0x00F23660 File Offset: 0x00F21860
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

		// Token: 0x0603EAD4 RID: 256724 RVA: 0x00F23690 File Offset: 0x00F21890
		private void SetNewLevelUnlockRedDot(bool value)
		{
			if (this.HasNewLevelUnlockRedDotInternal == value)
			{
				return;
			}
			this.HasNewLevelUnlockRedDotInternal = value;
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603EAD5 RID: 256725 RVA: 0x00F236B9 File Offset: 0x00F218B9
		[NullableContext(2)]
		private HashSet<int> GetSeenUnlockedInsIds()
		{
			return LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoverRogueSeenUnlockedInsIds, null);
		}

		// Token: 0x0603EAD6 RID: 256726 RVA: 0x00F236C6 File Offset: 0x00F218C6
		private void SaveSeenUnlockedInsIds(HashSet<int> ids)
		{
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoverRogueSeenUnlockedInsIds, ids);
		}

		// Token: 0x0603EAD7 RID: 256727 RVA: 0x00F236D4 File Offset: 0x00F218D4
		public bool HasNewBlessUnlockRedDot()
		{
			return this.HasNewBlessUnlockRedDotInternal;
		}

		// Token: 0x0603EAD8 RID: 256728 RVA: 0x00F236DC File Offset: 0x00F218DC
		public IReadOnlySet<int> GetNewUnlockedBlessIds()
		{
			return this.NewUnlockedBlessIdSetInternal;
		}

		// Token: 0x0603EAD9 RID: 256729 RVA: 0x00F236E4 File Offset: 0x00F218E4
		public bool IsBlessNewUnlocked(int blessId)
		{
			return this.NewUnlockedBlessIdSetInternal.Contains(blessId);
		}

		// Token: 0x0603EADA RID: 256730 RVA: 0x00F236F4 File Offset: 0x00F218F4
		public void RefreshNewBlessUnlockRedDot()
		{
			List<int> list = this.UnlockBlessIdSetInternal.ToList<int>();
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

		// Token: 0x0603EADB RID: 256731 RVA: 0x00F237A8 File Offset: 0x00F219A8
		public void MarkBlessUnlockRedDotRead()
		{
			this.SaveSeenUnlockedBlessIds(new HashSet<int>(this.UnlockBlessIdSetInternal));
			this.SetNewBlessUnlockRedDot(false);
		}

		// Token: 0x0603EADC RID: 256732 RVA: 0x00F237C2 File Offset: 0x00F219C2
		public void ClearNewUnlockedBlessIds()
		{
			this.NewUnlockedBlessIdSetInternal.Clear();
		}

		// Token: 0x0603EADD RID: 256733 RVA: 0x00F237CF File Offset: 0x00F219CF
		public void MarkBlessNewUnlockedRead(int blessId)
		{
			this.NewUnlockedBlessIdSetInternal.Remove(blessId);
		}

		// Token: 0x0603EADE RID: 256734 RVA: 0x00F237DE File Offset: 0x00F219DE
		private void SetNewBlessUnlockRedDot(bool value)
		{
			if (this.HasNewBlessUnlockRedDotInternal == value)
			{
				return;
			}
			this.HasNewBlessUnlockRedDotInternal = value;
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603EADF RID: 256735 RVA: 0x00F23807 File Offset: 0x00F21A07
		[NullableContext(2)]
		private HashSet<int> GetSeenUnlockedBlessIds()
		{
			return LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoverRogueSeenUnlockedBlessIds, null);
		}

		// Token: 0x0603EAE0 RID: 256736 RVA: 0x00F23814 File Offset: 0x00F21A14
		private void SaveSeenUnlockedBlessIds(HashSet<int> ids)
		{
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoverRogueSeenUnlockedBlessIds, ids);
		}

		// Token: 0x0603EAE1 RID: 256737 RVA: 0x00F23822 File Offset: 0x00F21A22
		public bool HasNewLootUnlockRedDot()
		{
			return this.IsLootFeatureUnlocked() && this.HasNewLootUnlockRedDotInternal;
		}

		// Token: 0x0603EAE2 RID: 256738 RVA: 0x00F23834 File Offset: 0x00F21A34
		public IReadOnlySet<int> GetNewUnlockedLootIds()
		{
			return this.NewUnlockedLootIdSetInternal;
		}

		// Token: 0x0603EAE3 RID: 256739 RVA: 0x00F2383C File Offset: 0x00F21A3C
		public bool IsLootNewUnlocked(int lootId)
		{
			return this.NewUnlockedLootIdSetInternal.Contains(lootId);
		}

		// Token: 0x0603EAE4 RID: 256740 RVA: 0x00F2384C File Offset: 0x00F21A4C
		public void RefreshNewLootUnlockRedDot()
		{
			List<int> list = this.UnlockLootIdSetInternal.ToList<int>();
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

		// Token: 0x0603EAE5 RID: 256741 RVA: 0x00F23900 File Offset: 0x00F21B00
		public void MarkLootUnlockRedDotRead()
		{
			this.SaveSeenUnlockedLootIds(new HashSet<int>(this.UnlockLootIdSetInternal));
			this.SetNewLootUnlockRedDot(false);
		}

		// Token: 0x0603EAE6 RID: 256742 RVA: 0x00F2391A File Offset: 0x00F21B1A
		public void ClearNewUnlockedLootIds()
		{
			this.NewUnlockedLootIdSetInternal.Clear();
		}

		// Token: 0x0603EAE7 RID: 256743 RVA: 0x00F23927 File Offset: 0x00F21B27
		public void MarkLootNewUnlockedRead(int lootId)
		{
			this.NewUnlockedLootIdSetInternal.Remove(lootId);
		}

		// Token: 0x0603EAE8 RID: 256744 RVA: 0x00F23936 File Offset: 0x00F21B36
		private void SetNewLootUnlockRedDot(bool value)
		{
			if (this.HasNewLootUnlockRedDotInternal == value)
			{
				return;
			}
			this.HasNewLootUnlockRedDotInternal = value;
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603EAE9 RID: 256745 RVA: 0x00F2395F File Offset: 0x00F21B5F
		[NullableContext(2)]
		private HashSet<int> GetSeenUnlockedLootIds()
		{
			return LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoverRogueSeenUnlockedLootIds, null);
		}

		// Token: 0x0603EAEA RID: 256746 RVA: 0x00F2396C File Offset: 0x00F21B6C
		private void SaveSeenUnlockedLootIds(HashSet<int> ids)
		{
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoverRogueSeenUnlockedLootIds, ids);
		}

		// Token: 0x17009128 RID: 37160
		// (get) Token: 0x0603EAEB RID: 256747 RVA: 0x00F2397C File Offset: 0x00F21B7C
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

		// Token: 0x0603EAEC RID: 256748 RVA: 0x00F239A4 File Offset: 0x00F21BA4
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

		// Token: 0x0603EAED RID: 256749 RVA: 0x00F239CC File Offset: 0x00F21BCC
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

		// Token: 0x04020C35 RID: 134197
		private readonly HashSet<int> UnlockRoleTypeSetInternal = new HashSet<int>();

		// Token: 0x04020C36 RID: 134198
		private readonly HashSet<int> UnlockBlessRoleIdSetInternal = new HashSet<int>();

		// Token: 0x04020C37 RID: 134199
		private readonly HashSet<int> UnlockLootIdSetInternal = new HashSet<int>();

		// Token: 0x04020C38 RID: 134200
		private int EquippedLootIdInternal;

		// Token: 0x04020C39 RID: 134201
		private readonly HashSet<int> UnlockBlessIdSetInternal = new HashSet<int>();

		// Token: 0x04020C3A RID: 134202
		private readonly HashSet<int> UnlockItemIdSetInternal = new HashSet<int>();

		// Token: 0x04020C3B RID: 134203
		[Nullable(2)]
		private RoverRogueHistoryInsInfo HistoryInsInfoInternal;

		// Token: 0x04020C3C RID: 134204
		[Nullable(2)]
		private RoverlikeTalentTreeData TalentTreeDataInternal;

		// Token: 0x04020C3D RID: 134205
		[Nullable(2)]
		private RoverlikeLevelSelectData LevelSelectDataInternal;

		// Token: 0x04020C3E RID: 134206
		private bool HasNewLevelUnlockRedDotInternal;

		// Token: 0x04020C3F RID: 134207
		private bool HasNewBlessUnlockRedDotInternal;

		// Token: 0x04020C40 RID: 134208
		private readonly HashSet<int> NewUnlockedBlessIdSetInternal = new HashSet<int>();

		// Token: 0x04020C41 RID: 134209
		private bool HasNewLootUnlockRedDotInternal;

		// Token: 0x04020C42 RID: 134210
		private readonly HashSet<int> NewUnlockedLootIdSetInternal = new HashSet<int>();

		// Token: 0x04020C43 RID: 134211
		[Nullable(2)]
		private RoverlikeQuestData QuestDataInternal;
	}
}
