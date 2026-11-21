using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Datas;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity.Component;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity;
using Cysharp.Threading.Tasks;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056A5 RID: 22181
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityDangoBrawlData : ActivityBaseData
	{
		// Token: 0x06036BFB RID: 224251 RVA: 0x00F46B6E File Offset: 0x00F44D6E
		protected override void OnInit(ActivityData data)
		{
			this.OutGameData = new DangoBrawlOutGameData();
		}

		// Token: 0x06036BFC RID: 224252 RVA: 0x00F46B7C File Offset: 0x00F44D7C
		protected override void PhraseEx(ActivityData data)
		{
			DangoBrawlActivityInfo dangoBrawlActivityInfo = data.DangoBrawlActivityInfo;
			if (dangoBrawlActivityInfo == null)
			{
				return;
			}
			DangoBrawlOutGameData outGameData = this.OutGameData;
			if (outGameData != null)
			{
				outGameData.PhraseEx(base.Id, dangoBrawlActivityInfo);
			}
			this.EnsureUnlockReadInitialized();
		}

		// Token: 0x06036BFD RID: 224253 RVA: 0x00F46BB2 File Offset: 0x00F44DB2
		protected override bool GetExDataFinishShowState()
		{
			return this.OutGameData != null && this.OutGameData.IsAllLimitRewardClaimed() && this.OutGameData.IsAllShopGoodsSoldOut();
		}

		// Token: 0x06036BFE RID: 224254 RVA: 0x00F46BD8 File Offset: 0x00F44DD8
		public override bool GetExDataRedPointShowState()
		{
			return this.CheckAllFunctionRedDot();
		}

		// Token: 0x06036BFF RID: 224255 RVA: 0x00F46BE0 File Offset: 0x00F44DE0
		public bool CheckAllFunctionRedDot()
		{
			return base.IsUnLock() && (this.HasFirstOpenPageRedDot() || this.HasNewLevelRedDot(null) || this.HasShopRedDot() || this.HasLimitRewardRedDot());
		}

		// Token: 0x06036C00 RID: 224256 RVA: 0x00F46C20 File Offset: 0x00F44E20
		[NullableContext(2)]
		public DangoBrawlOutGameData GetOutGameData()
		{
			return this.OutGameData;
		}

		// Token: 0x06036C01 RID: 224257 RVA: 0x00F46C28 File Offset: 0x00F44E28
		private int ToUnlockCacheId(int entityId)
		{
			if (entityId < 10000)
			{
				return entityId * 10;
			}
			return entityId % 10000;
		}

		// Token: 0x06036C02 RID: 224258 RVA: 0x00F46C3E File Offset: 0x00F44E3E
		private bool IsUnlockUnread(ActivityDangoBrawlData.EDangoBrawlStorageKey key, int entityId)
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, (int)key, 0, this.ToUnlockCacheId(entityId)) == 0;
		}

		// Token: 0x06036C03 RID: 224259 RVA: 0x00F46C5D File Offset: 0x00F44E5D
		private void SaveUnlockRead(ActivityDangoBrawlData.EDangoBrawlStorageKey key, int entityId)
		{
			ActivityModel.Instance.SaveActivityData(base.Id, (int)key, 0, this.ToUnlockCacheId(entityId), 1);
		}

		// Token: 0x06036C04 RID: 224260 RVA: 0x00F46C79 File Offset: 0x00F44E79
		private void SaveUnlockUnread(ActivityDangoBrawlData.EDangoBrawlStorageKey key, int entityId)
		{
			ActivityModel.Instance.SaveActivityData(base.Id, (int)key, 0, this.ToUnlockCacheId(entityId), 0);
		}

		// Token: 0x06036C05 RID: 224261 RVA: 0x00F46C95 File Offset: 0x00F44E95
		private bool IsUnlockReadInitialized()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 4, 0, 0) == 1;
		}

		// Token: 0x06036C06 RID: 224262 RVA: 0x00F46CB0 File Offset: 0x00F44EB0
		public void EnsureUnlockReadInitialized()
		{
			if (this.OutGameData == null || this.IsUnlockReadInitialized())
			{
				return;
			}
			foreach (DangoBrawlLevelData dangoBrawlLevelData in this.OutGameData.GetAllLevelDataList())
			{
				if (!dangoBrawlLevelData.IsLocked && !dangoBrawlLevelData.IsPassed)
				{
					this.SaveUnlockRead(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewLevelRead, dangoBrawlLevelData.Id);
				}
			}
			foreach (int entityId in this.OutGameData.GetUnlockedRoleIds())
			{
				this.SaveUnlockRead(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewRoleRead, entityId);
			}
			foreach (int entityId2 in this.OutGameData.GetUnlockedItemIds())
			{
				this.SaveUnlockRead(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewItemRead, entityId2);
			}
			ActivityModel.Instance.SaveActivityData(base.Id, 4, 0, 0, 1);
		}

		// Token: 0x06036C07 RID: 224263 RVA: 0x00F46DCC File Offset: 0x00F44FCC
		public void OnNewRolesUnlocked(IReadOnlyList<int> newRoleIds)
		{
			this.EnsureUnlockReadInitialized();
			foreach (int entityId in newRoleIds)
			{
				this.SaveUnlockUnread(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewRoleRead, entityId);
			}
		}

		// Token: 0x06036C08 RID: 224264 RVA: 0x00F46E1C File Offset: 0x00F4501C
		public void OnNewItemsUnlocked(IReadOnlyList<int> newItemIds)
		{
			this.EnsureUnlockReadInitialized();
			foreach (int entityId in newItemIds)
			{
				this.SaveUnlockUnread(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewItemRead, entityId);
			}
		}

		// Token: 0x06036C09 RID: 224265 RVA: 0x00F46E6C File Offset: 0x00F4506C
		public void OnNewLevelsUnlocked(IReadOnlyList<int> newLevelIds)
		{
			this.EnsureUnlockReadInitialized();
			foreach (int entityId in newLevelIds)
			{
				this.SaveUnlockUnread(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewLevelRead, entityId);
			}
		}

		// Token: 0x06036C0A RID: 224266 RVA: 0x00F46EBC File Offset: 0x00F450BC
		public bool HasFirstOpenPageRedDot()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 0, 0, 0) == 0;
		}

		// Token: 0x06036C0B RID: 224267 RVA: 0x00F46ED5 File Offset: 0x00F450D5
		public void SetFirstOpenPageRedDot(bool hasRedDot)
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 0, 0, 0, (!hasRedDot) ? 1 : 0);
			if (!hasRedDot)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			}
		}

		// Token: 0x06036C0C RID: 224268 RVA: 0x00F46F08 File Offset: 0x00F45108
		public bool HasNewLevelRedDot(bool? isNormalMode = null)
		{
			if (this.OutGameData == null)
			{
				return false;
			}
			foreach (DangoBrawlLevelData dangoBrawlLevelData in ((isNormalMode != null) ? this.OutGameData.GetLevelDataList(isNormalMode.Value) : this.OutGameData.GetAllLevelDataList()))
			{
				if (!dangoBrawlLevelData.IsLocked && !dangoBrawlLevelData.IsPassed && this.IsUnlockUnread(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewLevelRead, dangoBrawlLevelData.Id))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06036C0D RID: 224269 RVA: 0x00F46FA8 File Offset: 0x00F451A8
		public bool HasNewLevelRedDot(int levelId)
		{
			DangoBrawlOutGameData outGameData = this.OutGameData;
			DangoBrawlLevelData dangoBrawlLevelData = (outGameData != null) ? outGameData.GetLevelData(levelId) : null;
			return dangoBrawlLevelData != null && !dangoBrawlLevelData.IsLocked && !dangoBrawlLevelData.IsPassed && this.IsUnlockUnread(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewLevelRead, levelId);
		}

		// Token: 0x06036C0E RID: 224270 RVA: 0x00F46FE8 File Offset: 0x00F451E8
		public void MarkNewLevelRead(int? levelId = null, bool? isNormalMode = null)
		{
			if (this.OutGameData == null)
			{
				return;
			}
			if (levelId != null)
			{
				this.SaveUnlockRead(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewLevelRead, levelId.Value);
			}
			else
			{
				foreach (DangoBrawlLevelData dangoBrawlLevelData in ((isNormalMode != null) ? this.OutGameData.GetLevelDataList(isNormalMode.Value) : this.OutGameData.GetAllLevelDataList()))
				{
					if (!dangoBrawlLevelData.IsLocked && !dangoBrawlLevelData.IsPassed)
					{
						this.SaveUnlockRead(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewLevelRead, dangoBrawlLevelData.Id);
					}
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06036C0F RID: 224271 RVA: 0x00F470AC File Offset: 0x00F452AC
		public bool HasNewRoleRedDot()
		{
			if (this.OutGameData == null)
			{
				return false;
			}
			foreach (int entityId in this.OutGameData.GetUnlockedRoleIds())
			{
				if (this.IsUnlockUnread(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewRoleRead, entityId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06036C10 RID: 224272 RVA: 0x00F47114 File Offset: 0x00F45314
		public bool HasNewRoleRedDot(int roleId)
		{
			return this.OutGameData != null && this.OutGameData.IsRoleUnlocked(roleId) && this.IsUnlockUnread(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewRoleRead, roleId);
		}

		// Token: 0x06036C11 RID: 224273 RVA: 0x00F47138 File Offset: 0x00F45338
		public void MarkNewRoleRead(int? roleId = null)
		{
			if (this.OutGameData == null)
			{
				return;
			}
			if (roleId != null)
			{
				this.SaveUnlockRead(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewRoleRead, roleId.Value);
				int oppositePlayerRoleId = this.OutGameData.GetOppositePlayerRoleId(roleId.Value);
				if (oppositePlayerRoleId > 0)
				{
					this.SaveUnlockRead(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewRoleRead, oppositePlayerRoleId);
				}
			}
			else
			{
				foreach (int entityId in this.OutGameData.GetUnlockedRoleIds())
				{
					this.SaveUnlockRead(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewRoleRead, entityId);
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06036C12 RID: 224274 RVA: 0x00F471E4 File Offset: 0x00F453E4
		public bool HasNewItemRedDot(int? itemType = null)
		{
			if (this.OutGameData == null)
			{
				return false;
			}
			bool flag = (itemType ?? 0) == 0;
			int? num = flag ? null : itemType;
			foreach (int num2 in this.OutGameData.GetUnlockedItemIds())
			{
				if (this.IsUnlockUnread(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewItemRead, num2))
				{
					if (num == null)
					{
						return true;
					}
					DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(num2);
					int? num3 = (dangoBrawlItemById != null) ? new int?(dangoBrawlItemById.GetValueOrDefault().Type) : null;
					int value = num.Value;
					if (num3.GetValueOrDefault() == value & num3 != null)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06036C13 RID: 224275 RVA: 0x00F472DC File Offset: 0x00F454DC
		public bool HasNewItemUnlockAnim(int itemId)
		{
			return this.NewItemUnlockAnimCache.Contains(itemId);
		}

		// Token: 0x06036C14 RID: 224276 RVA: 0x00F472EA File Offset: 0x00F454EA
		public bool RemoveNewItemUnlockAnim(int itemId)
		{
			return this.NewItemUnlockAnimCache.Remove(itemId);
		}

		// Token: 0x06036C15 RID: 224277 RVA: 0x00F472F8 File Offset: 0x00F454F8
		public void CollectNewItemRedDotOnTabOpen(int? itemType = null)
		{
			this.NewItemUnlockAnimCache.Clear();
			if (this.OutGameData == null)
			{
				return;
			}
			int? num = ((itemType ?? 0) == 0) ? null : itemType;
			foreach (int num2 in this.OutGameData.GetUnlockedItemIds())
			{
				if (this.IsUnlockUnread(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewItemRead, num2))
				{
					if (num != null)
					{
						DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(num2);
						int? num3 = (dangoBrawlItemById != null) ? new int?(dangoBrawlItemById.GetValueOrDefault().Type) : null;
						int value = num.Value;
						if (!(num3.GetValueOrDefault() == value & num3 != null))
						{
							continue;
						}
					}
					this.NewItemUnlockAnimCache.Add(num2);
					this.SaveUnlockRead(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewItemRead, num2);
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06036C16 RID: 224278 RVA: 0x00F47420 File Offset: 0x00F45620
		public void MarkNewItemRead(int? itemType = null)
		{
			if (this.OutGameData == null)
			{
				return;
			}
			int? num = ((itemType ?? 0) == 0) ? null : itemType;
			foreach (int num2 in this.OutGameData.GetUnlockedItemIds())
			{
				if (num != null)
				{
					DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(num2);
					int? num3 = (dangoBrawlItemById != null) ? new int?(dangoBrawlItemById.GetValueOrDefault().Type) : null;
					int value = num.Value;
					if (!(num3.GetValueOrDefault() == value & num3 != null))
					{
						continue;
					}
				}
				this.SaveUnlockRead(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewItemRead, num2);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06036C17 RID: 224279 RVA: 0x00F4751C File Offset: 0x00F4571C
		public bool HasShopRedDot()
		{
			return this.HasFirstOpenShopRedDot() || this.HasShopNewGoodsRedDot();
		}

		// Token: 0x06036C18 RID: 224280 RVA: 0x00F4752E File Offset: 0x00F4572E
		private bool HasFirstOpenShopRedDot()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 5, 0, 0) == 0;
		}

		// Token: 0x06036C19 RID: 224281 RVA: 0x00F47548 File Offset: 0x00F45748
		private bool HasShopNewGoodsRedDot()
		{
			DangoBrawlActivity? activityConfigById = DangoBrawlConfig.Instance.GetActivityConfigById(base.Id);
			if (activityConfigById == null)
			{
				return false;
			}
			int shopId = activityConfigById.Value.ShopId;
			return shopId > 0 && PayShopModel.Instance.CheckShopItemCheckFlag((PayShopDefine.EPayShopTabType)shopId, 1);
		}

		// Token: 0x06036C1A RID: 224282 RVA: 0x00F47593 File Offset: 0x00F45793
		public void SetShopRedDot(bool hasRedDot)
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 5, 0, 0, (!hasRedDot) ? 1 : 0);
			if (!hasRedDot)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			}
		}

		// Token: 0x06036C1B RID: 224283 RVA: 0x00F475C5 File Offset: 0x00F457C5
		public void MarkShopRead()
		{
			if (!this.HasFirstOpenShopRedDot())
			{
				return;
			}
			this.SetShopRedDot(false);
		}

		// Token: 0x06036C1C RID: 224284 RVA: 0x00F475D8 File Offset: 0x00F457D8
		public bool HasLimitRewardRedDot()
		{
			DangoBrawlOutGameData outGameData = this.OutGameData;
			if (outGameData == null || !outGameData.IsTaskHasRedDot(null))
			{
				DangoBrawlOutGameData outGameData2 = this.OutGameData;
				return outGameData2 != null && outGameData2.IsScoreRewardHasRedDot();
			}
			return true;
		}

		// Token: 0x06036C1D RID: 224285 RVA: 0x00F47615 File Offset: 0x00F45815
		public IReadOnlyDictionary<int, int> GetSettleRewardedItems()
		{
			return this.SettleRewardedItems;
		}

		// Token: 0x06036C1E RID: 224286 RVA: 0x00F47620 File Offset: 0x00F45820
		public void ProtoInstBaseNotify(DangoBrawlInstBaseNotify resp)
		{
			DangoBrawlModel.Instance.InitBattleManager();
			this.InstBase = resp;
			this.ShopServerData.Init(resp.Shop);
			this.FightersServerData.Init(resp.Fighters);
			DangoBrawlNormalBagItemInfo[] array = new DangoBrawlNormalBagItemInfo[resp.Bag.NormalItems.Count];
			resp.Bag.NormalItems.CopyTo(array, 0);
			this.BackPackServerData.MyInfoList = array;
			DangoBrawlNormalBagItemInfo[] array2 = new DangoBrawlNormalBagItemInfo[resp.OpponentBagItems.Count];
			resp.OpponentBagItems.CopyTo(array2, 0);
			this.OpponentBackPackServerData.MyInfoList = array2;
			DangoBrawlBenchItemInfo[] array3 = new DangoBrawlBenchItemInfo[resp.Bag.BenchItems.Count];
			resp.Bag.BenchItems.CopyTo(array3, 0);
			this.BenchServerData.MyInfoList = array3;
			if (resp.Phase == DangoBrawlPhase.EventSelect)
			{
				this.EventSelectServerData.CurrentEventSelectInfo = resp.Event;
			}
			this.BagpackData = new DangoBrawlBackpackData();
			this.BagpackData.Init(base.Id, this.BackPackServerData);
			this.BenchData = new DangoBrawlBenchData();
			this.BenchData.Init(base.Id, this.BenchServerData);
			this.BackpackViewData = new DangoBrawlBackpackViewData();
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return;
			}
			battleManager.OnBaseNotify(resp);
		}

		// Token: 0x06036C1F RID: 224287 RVA: 0x00F47770 File Offset: 0x00F45970
		public void ProtoInstPrepareNotify(DangoBrawlInstPrepareNotify resp)
		{
		}

		// Token: 0x06036C20 RID: 224288 RVA: 0x00F47772 File Offset: 0x00F45972
		public void ProtoInstEventSelectNotify(DangoBrawlInstEventSelectNotify resp)
		{
		}

		// Token: 0x06036C21 RID: 224289 RVA: 0x00F47774 File Offset: 0x00F45974
		public void ProtoRoundSwitchNotify(DangoBrawlRoundSwitchNotify resp)
		{
			this.RoundGiveCoinDelta.Clear();
			if (this.InstBase != null)
			{
				this.InstBase.WinCount = resp.WinCount;
				this.InstBase.LoseCount = resp.LoseCount;
				this.InstBase.RoundNum = resp.RoundNum;
				this.InstBase.Coin = resp.Coin;
				this.InstBase.ActiveEventIds.Clear();
				this.InstBase.ActiveEventIds.AddRange(resp.ActiveEventIds);
			}
			this.ShopServerData.UpdateShopInfo(resp.Shop);
			this.FightersServerData.UpdateFighters(resp.Fighters);
			DangoBrawlNormalBagItemInfo[] array = new DangoBrawlNormalBagItemInfo[resp.OpponentBagItems.Count];
			resp.OpponentBagItems.CopyTo(array, 0);
			this.OpponentBackPackServerData.MyInfoList = array;
			if (resp.Event != null)
			{
				this.EventSelectServerData.CurrentEventSelectInfo = resp.Event;
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return;
			}
			battleManager.CacheRoundSwitch(resp);
			DangoBrawlFsm battleFsm = battleManager.GetBattleFsm();
			if (((battleFsm != null) ? new EDangoBrawlFsmState?(battleFsm.GetCurrentStateType()) : null).GetValueOrDefault() == EDangoBrawlFsmState.ShopState)
			{
				Log.Instance.Error(ELogModule.DangoBrawl, ELogAuthor.WHJ, "[ProtoRoundSwitchNotify] Shipping 包出现 ShopState→ShopState 非法流程", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (battleManager.IsForceEnterFinalState)
			{
				DangoBrawlFsm battleFsm2 = battleManager.GetBattleFsm();
				if (battleFsm2 == null)
				{
					return;
				}
				battleFsm2.ChangeState(EDangoBrawlFsmState.FinalSettle).Forget();
				return;
			}
			else
			{
				DangoBrawlFsm battleFsm3 = battleManager.GetBattleFsm();
				if (battleFsm3 == null)
				{
					return;
				}
				battleFsm3.ChangeState(EDangoBrawlFsmState.ShopState).Forget();
				return;
			}
		}

		// Token: 0x06036C22 RID: 224290 RVA: 0x00F478FA File Offset: 0x00F45AFA
		public void ProtoCoinUpdateNotify(DangoBrawlCoinUpdateNotify resp)
		{
			if (this.InstBase != null)
			{
				this.InstBase.Coin = resp.Coin;
			}
		}

		// Token: 0x06036C23 RID: 224291 RVA: 0x00F47918 File Offset: 0x00F45B18
		public void ProtoBagUpdateNotify(DangoBrawlBagUpdateNotify resp)
		{
			DangoBrawlBagInfo bag = resp.Bag;
			if (bag != null)
			{
				DangoBrawlNormalBagItemInfo[] array = new DangoBrawlNormalBagItemInfo[bag.NormalItems.Count];
				bag.NormalItems.CopyTo(array, 0);
				this.BackPackServerData.MyInfoList = array;
				DangoBrawlBenchItemInfo[] array2 = new DangoBrawlBenchItemInfo[bag.BenchItems.Count];
				bag.BenchItems.CopyTo(array2, 0);
				this.BenchServerData.MyInfoList = array2;
				this.BagpackData = new DangoBrawlBackpackData();
				this.BagpackData.Init(base.Id, this.BackPackServerData);
				Dictionary<int, ValueTuple<FVector2D?, EDangoBrawlRotate>> dictionary = new Dictionary<int, ValueTuple<FVector2D?, EDangoBrawlRotate>>();
				if (this.BenchData != null)
				{
					foreach (DangoBrawlBenchItemData dangoBrawlBenchItemData in this.BenchData.GetItemList())
					{
						dictionary[dangoBrawlBenchItemData.MyUid] = new ValueTuple<FVector2D?, EDangoBrawlRotate>(dangoBrawlBenchItemData.MyDropLguiPos, dangoBrawlBenchItemData.MyRotation);
					}
				}
				this.BenchData = new DangoBrawlBenchData();
				this.BenchData.Init(base.Id, this.BenchServerData);
				foreach (KeyValuePair<int, ValueTuple<FVector2D?, EDangoBrawlRotate>> keyValuePair in dictionary)
				{
					int num;
					ValueTuple<FVector2D?, EDangoBrawlRotate> valueTuple;
					keyValuePair.Deconstruct(out num, out valueTuple);
					int uid = num;
					ValueTuple<FVector2D?, EDangoBrawlRotate> valueTuple2 = valueTuple;
					if (this.BenchData.GetItem(uid) != null)
					{
						this.BenchData.MoveItem(uid, valueTuple2.Item1, new EDangoBrawlRotate?(valueTuple2.Item2), true);
					}
				}
			}
			if (resp.Shop != null)
			{
				this.ShopServerData.UpdateShopInfo(resp.Shop);
			}
			if (this.BackpackViewData != null)
			{
				this.BackpackViewData.PendingBenchDropLguiPos = null;
			}
		}

		// Token: 0x06036C24 RID: 224292 RVA: 0x00F47AEC File Offset: 0x00F45CEC
		public void ProtoSettleNotify(DangoBrawlSettleNotify resp)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			if (battleManager != null)
			{
				battleManager.FinalWin = resp.IsWin;
			}
			if (this.InstBase != null)
			{
				this.InstBase.WinCount = resp.WinCount;
				this.InstBase.LoseCount = resp.LoseCount;
			}
			this.SettleRewardedItems.Clear();
			foreach (KeyValuePair<int, int> keyValuePair in resp.RewardedItems)
			{
				this.SettleRewardedItems[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x06036C25 RID: 224293 RVA: 0x00F47B9C File Offset: 0x00F45D9C
		public void OnDangoBrawlItemGiveCoinNotify(DangoBrawlItemGiveCoinNotify message)
		{
			if (this.InstBase != null)
			{
				this.InstBase.Coin = message.Coin;
			}
			foreach (DangoBrawlItemGiveCoinInfo dangoBrawlItemGiveCoinInfo in message.Infos)
			{
				if (dangoBrawlItemGiveCoinInfo.ItemUId > 0)
				{
					int num;
					this.RoundGiveCoinDelta[dangoBrawlItemGiveCoinInfo.ItemUId] = (this.RoundGiveCoinDelta.TryGetValue(dangoBrawlItemGiveCoinInfo.ItemUId, out num) ? (num + dangoBrawlItemGiveCoinInfo.Delta) : dangoBrawlItemGiveCoinInfo.Delta);
				}
			}
		}

		// Token: 0x06036C26 RID: 224294 RVA: 0x00F47C3C File Offset: 0x00F45E3C
		public void OnDangoBrawlLoseCountChange(DangoBrawlLoseCountUpdateNotify message)
		{
			if (this.InstBase != null)
			{
				this.InstBase.LoseCount = message.LoseCount;
			}
		}

		// Token: 0x06036C27 RID: 224295 RVA: 0x00F47C57 File Offset: 0x00F45E57
		public void OnDangoBrawlFighterAttrChange(DangoBrawlFighterAttrChangeNotify message)
		{
			DangoBrawlFighterServerData fighter = this.FightersServerData.GetFighter(message.FighterUId);
			if (fighter != null)
			{
				fighter.SetFinalAttrs(message.FinalAttrs);
			}
			this.SyncAttrToEntity(message.FighterUId, message.FinalAttrs);
		}

		// Token: 0x06036C28 RID: 224296 RVA: 0x00F47C90 File Offset: 0x00F45E90
		private void SyncAttrToEntity(int fighterUid, MapField<int, int> finalAttrs)
		{
			DangoBrawlFighterServerData fighter = this.FightersServerData.GetFighter(fighterUid);
			if (fighter == null)
			{
				return;
			}
			bool isSelf = fighter.Camp == DangoBrawlFightCamp.Player;
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			DangoAttributeComponent dangoAttributeComponent;
			if (battleManager == null)
			{
				dangoAttributeComponent = null;
			}
			else
			{
				ActivityGameplayEntity entity = battleManager.GetEntity(isSelf);
				dangoAttributeComponent = ((entity != null) ? entity.GetComponent<DangoAttributeComponent>() : null);
			}
			DangoAttributeComponent dangoAttributeComponent2 = dangoAttributeComponent;
			if (dangoAttributeComponent2 == null)
			{
				return;
			}
			foreach (KeyValuePair<int, int> keyValuePair in finalAttrs)
			{
				dangoAttributeComponent2.SetAttribute(keyValuePair.Key, keyValuePair.Value);
			}
		}

		// Token: 0x06036C29 RID: 224297 RVA: 0x00F47D2C File Offset: 0x00F45F2C
		public void OnStartFightFighters(IReadOnlyList<DangoBrawlFighterInfo> fighters)
		{
			this.FightersServerData.UpdateFighters(fighters);
		}

		// Token: 0x06036C2A RID: 224298 RVA: 0x00F47D3A File Offset: 0x00F45F3A
		[NullableContext(2)]
		public void OnShopRefreshed(DangoBrawlShopInfo shop)
		{
			if (shop != null)
			{
				this.ShopServerData.UpdateShopInfo(shop);
			}
		}

		// Token: 0x06036C2B RID: 224299 RVA: 0x00F47D4B File Offset: 0x00F45F4B
		public bool OnShopSlotLocked(int uid, bool locked)
		{
			return this.ShopServerData.SetSlotLocked(uid, locked);
		}

		// Token: 0x06036C2C RID: 224300 RVA: 0x00F47D5C File Offset: 0x00F45F5C
		[NullableContext(2)]
		public int OnShopBought(int slotUid, int configId, bool toBench, DangoBrawlBagSlotInfo bagSlot)
		{
			if (configId <= 0)
			{
				return -1;
			}
			int result = this.ShopServerData.RemoveSlot(slotUid);
			if (toBench || bagSlot == null)
			{
				if (toBench)
				{
					DangoBrawlBenchItemServerData serverData = DangoBrawlBenchServerData.MakeData(slotUid, configId);
					DangoBrawlBackpackViewData backpackViewData = this.BackpackViewData;
					DragTargetBench? dragTargetBench = (backpackViewData != null) ? backpackViewData.PendingBenchDropLguiPos : null;
					if (backpackViewData != null)
					{
						backpackViewData.PendingBenchDropLguiPos = null;
					}
					DangoBrawlBenchData benchData = this.BenchData;
					if (benchData == null)
					{
						return result;
					}
					benchData.AddItemDataToMap(serverData, (dragTargetBench != null) ? dragTargetBench.GetValueOrDefault().LguiPos : null, EDangoBrawlRotate.Direction0, true);
				}
				return result;
			}
			DangoBrawlBackPackItemServerData serverData2 = DangoBrawlBackPackItemServerData.MakeData(slotUid, configId, new PanelPos(bagSlot.Y, bagSlot.X), (EDangoBrawlRotate)bagSlot.Rotation);
			DangoBrawlBackpackData bagpackData = this.BagpackData;
			if (bagpackData == null)
			{
				return result;
			}
			bagpackData.AddItemData(new DangoBrawlBackpackItemData(serverData2), true);
			return result;
		}

		// Token: 0x06036C2D RID: 224301 RVA: 0x00F47E28 File Offset: 0x00F46028
		public void OnShopSold(int itemUid)
		{
			DangoBrawlBackpackData bagpackData = this.BagpackData;
			if (bagpackData != null)
			{
				bagpackData.RemoveItemData(itemUid, true);
			}
			DangoBrawlBenchData benchData = this.BenchData;
			if (benchData == null)
			{
				return;
			}
			benchData.DelItemDataFromMap(itemUid, true);
		}

		// Token: 0x06036C2E RID: 224302 RVA: 0x00F47E50 File Offset: 0x00F46050
		public void OnShopComposed(int[] sourceUids, EDragSourceKind[] sourceKinds, int newItemUid, int resultItemId, bool toBench, [Nullable(2)] DangoBrawlBagSlotInfo bagSlot)
		{
			if (resultItemId <= 0)
			{
				return;
			}
			for (int i = 0; i < sourceUids.Length; i++)
			{
				int uid = sourceUids[i];
				if (i < sourceKinds.Length && sourceKinds[i] == EDragSourceKind.Bench)
				{
					DangoBrawlBenchData benchData = this.BenchData;
					if (benchData != null)
					{
						benchData.DelItemDataFromMap(uid, true);
					}
				}
				else
				{
					DangoBrawlBackpackData bagpackData = this.BagpackData;
					if (bagpackData != null)
					{
						bagpackData.RemoveItemData(uid, true);
					}
				}
			}
			if (!toBench && bagSlot != null)
			{
				DangoBrawlBackPackItemServerData serverData = DangoBrawlBackPackItemServerData.MakeData(newItemUid, resultItemId, new PanelPos(bagSlot.Y, bagSlot.X), (EDangoBrawlRotate)bagSlot.Rotation);
				DangoBrawlBackpackData bagpackData2 = this.BagpackData;
				if (bagpackData2 == null)
				{
					return;
				}
				bagpackData2.AddItemData(new DangoBrawlBackpackItemData(serverData), true);
				return;
			}
			else
			{
				DangoBrawlBenchItemServerData serverData2 = DangoBrawlBenchServerData.MakeData(newItemUid, resultItemId);
				DangoBrawlBackpackViewData backpackViewData = this.BackpackViewData;
				DragTargetBench? dragTargetBench = (backpackViewData != null) ? backpackViewData.PendingBenchDropLguiPos : null;
				if (backpackViewData != null)
				{
					backpackViewData.PendingBenchDropLguiPos = null;
				}
				DangoBrawlBenchData benchData2 = this.BenchData;
				if (benchData2 == null)
				{
					return;
				}
				benchData2.AddItemDataToMap(serverData2, (dragTargetBench != null) ? dragTargetBench.GetValueOrDefault().LguiPos : null, EDangoBrawlRotate.Direction0, true);
				return;
			}
		}

		// Token: 0x170069AA RID: 27050
		// (get) Token: 0x06036C2F RID: 224303 RVA: 0x00F47F62 File Offset: 0x00F46162
		public int ShopCoin
		{
			get
			{
				DangoBrawlInstBaseNotify instBase = this.InstBase;
				if (instBase == null)
				{
					return 0;
				}
				return instBase.Coin;
			}
		}

		// Token: 0x170069AB RID: 27051
		// (get) Token: 0x06036C30 RID: 224304 RVA: 0x00F47F75 File Offset: 0x00F46175
		public int ShopRefreshCost
		{
			get
			{
				DangoBrawlShopInfo myShopInfo = this.ShopServerData.MyShopInfo;
				if (myShopInfo == null)
				{
					return 0;
				}
				return myShopInfo.NextRefreshCost;
			}
		}

		// Token: 0x170069AC RID: 27052
		// (get) Token: 0x06036C31 RID: 224305 RVA: 0x00F47F8D File Offset: 0x00F4618D
		public RepeatedField<DangoBrawlShopSlotInfo> ShopSlots
		{
			get
			{
				DangoBrawlShopInfo myShopInfo = this.ShopServerData.MyShopInfo;
				return ((myShopInfo != null) ? myShopInfo.Slots : null) ?? new RepeatedField<DangoBrawlShopSlotInfo>();
			}
		}

		// Token: 0x170069AD RID: 27053
		// (get) Token: 0x06036C32 RID: 224306 RVA: 0x00F47FAF File Offset: 0x00F461AF
		public int MyFighterMaxHp
		{
			get
			{
				DangoBrawlFighterServerData selfFighter = this.FightersServerData.GetSelfFighter();
				if (selfFighter == null)
				{
					return 0;
				}
				return selfFighter.MaxHp;
			}
		}

		// Token: 0x06036C33 RID: 224307 RVA: 0x00F47FC7 File Offset: 0x00F461C7
		public int GetBagWeight()
		{
			DangoBrawlBackpackData bagpackData = this.BagpackData;
			if (bagpackData == null)
			{
				return 0;
			}
			return bagpackData.GetCurrentWeight();
		}

		// Token: 0x06036C34 RID: 224308 RVA: 0x00F47FDA File Offset: 0x00F461DA
		public int GetShopGoodsSlotIndex(int uid)
		{
			return this.ShopServerData.GetSlotIndex(uid);
		}

		// Token: 0x06036C35 RID: 224309 RVA: 0x00F47FE8 File Offset: 0x00F461E8
		public int GetShopRound()
		{
			DangoBrawlInstBaseNotify instBase = this.InstBase;
			if (instBase == null)
			{
				return 1;
			}
			return instBase.RoundNum;
		}

		// Token: 0x06036C36 RID: 224310 RVA: 0x00F47FFC File Offset: 0x00F461FC
		public int GetShopRoundConfigId()
		{
			DangoBrawlInstBaseNotify instBase = this.InstBase;
			int id = (instBase != null) ? instBase.ChallengeId : 0;
			DangoBrawlChallenge? challengeConfigById = DangoBrawlConfig.Instance.GetChallengeConfigById(id);
			if (challengeConfigById == null || challengeConfigById.Value.RoundListLength <= 0)
			{
				return 0;
			}
			int j = Math.Clamp(this.GetShopRound() - 1, 0, challengeConfigById.Value.RoundListLength - 1);
			return challengeConfigById.Value.RoundList(j);
		}

		// Token: 0x06036C37 RID: 224311 RVA: 0x00F48075 File Offset: 0x00F46275
		public int GetRoleId()
		{
			DangoBrawlInstBaseNotify instBase = this.InstBase;
			if (instBase == null)
			{
				return 0;
			}
			return instBase.RoleId;
		}

		// Token: 0x06036C38 RID: 224312 RVA: 0x00F48088 File Offset: 0x00F46288
		public List<int> GetTaskCanClaimableIdListByTabId(int tabId)
		{
			List<int> list = new List<int>();
			DangoBrawlOutGameData outGameData = this.GetOutGameData();
			if (outGameData == null)
			{
				return list;
			}
			foreach (DangoBrawlTaskData dangoBrawlTaskData in outGameData.GetTaskDataList(new int?(tabId)))
			{
				if (dangoBrawlTaskData.Status == EActivityTaskState.FinishedAndUnclaimed)
				{
					list.Add(dangoBrawlTaskData.ConfigId);
				}
			}
			return list;
		}

		// Token: 0x06036C39 RID: 224313 RVA: 0x00F48104 File Offset: 0x00F46304
		public int ConsumeRoundGiveCoinDelta(int itemUid)
		{
			int result;
			if (this.RoundGiveCoinDelta.TryGetValue(itemUid, out result))
			{
				this.RoundGiveCoinDelta.Remove(itemUid);
				return result;
			}
			return 0;
		}

		// Token: 0x0401CE9C RID: 118428
		[Nullable(2)]
		private DangoBrawlOutGameData OutGameData;

		// Token: 0x0401CE9D RID: 118429
		private const int CacheUnread = 0;

		// Token: 0x0401CE9E RID: 118430
		private const int CacheRead = 1;

		// Token: 0x0401CE9F RID: 118431
		private const int UnlockCacheIdMod = 10000;

		// Token: 0x0401CEA0 RID: 118432
		private const int UnlockCacheIdMulti = 10;

		// Token: 0x0401CEA1 RID: 118433
		private readonly HashSet<int> NewItemUnlockAnimCache = new HashSet<int>();

		// Token: 0x0401CEA2 RID: 118434
		[Nullable(2)]
		public DangoBrawlInstBaseNotify InstBase;

		// Token: 0x0401CEA3 RID: 118435
		private readonly Dictionary<int, int> SettleRewardedItems = new Dictionary<int, int>();

		// Token: 0x0401CEA4 RID: 118436
		private readonly Dictionary<int, int> RoundGiveCoinDelta = new Dictionary<int, int>();

		// Token: 0x0401CEA5 RID: 118437
		private DangoBrawlBackPackServerData BackPackServerData = new DangoBrawlBackPackServerData();

		// Token: 0x0401CEA6 RID: 118438
		private DangoBrawlBenchServerData BenchServerData = new DangoBrawlBenchServerData();

		// Token: 0x0401CEA7 RID: 118439
		public DangoBrawlShopServerData ShopServerData = new DangoBrawlShopServerData();

		// Token: 0x0401CEA8 RID: 118440
		public DangoBrawlBackPackServerData OpponentBackPackServerData = new DangoBrawlBackPackServerData();

		// Token: 0x0401CEA9 RID: 118441
		public DangoBrawlFightersServerData FightersServerData = new DangoBrawlFightersServerData();

		// Token: 0x0401CEAA RID: 118442
		public DangoBrawlEventSelectServerData EventSelectServerData = new DangoBrawlEventSelectServerData();

		// Token: 0x0401CEAB RID: 118443
		[Nullable(2)]
		public DangoBrawlBackpackData BagpackData;

		// Token: 0x0401CEAC RID: 118444
		[Nullable(2)]
		public DangoBrawlBenchData BenchData;

		// Token: 0x0401CEAD RID: 118445
		[Nullable(2)]
		public DangoBrawlBackpackViewData BackpackViewData;

		// Token: 0x0200B2B2 RID: 45746
		[NullableContext(0)]
		private enum EDangoBrawlStorageKey
		{
			// Token: 0x04037366 RID: 226150
			FirstOpenPage,
			// Token: 0x04037367 RID: 226151
			NewLevelRead,
			// Token: 0x04037368 RID: 226152
			NewRoleRead,
			// Token: 0x04037369 RID: 226153
			NewItemRead,
			// Token: 0x0403736A RID: 226154
			UnlockReadInitialized,
			// Token: 0x0403736B RID: 226155
			FirstOpenShop
		}
	}
}
