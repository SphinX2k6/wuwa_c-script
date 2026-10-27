using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
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
	// Token: 0x02006755 RID: 26453
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityDangoBrawlData : ActivityBaseData
	{
		// Token: 0x060420A9 RID: 270505 RVA: 0x01005746 File Offset: 0x01003946
		protected override void OnInit(ActivityData data)
		{
			this.OutGameData = new DangoBrawlOutGameData();
		}

		// Token: 0x060420AA RID: 270506 RVA: 0x01005754 File Offset: 0x01003954
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

		// Token: 0x060420AB RID: 270507 RVA: 0x0100578A File Offset: 0x0100398A
		protected override bool GetExDataFinishShowState()
		{
			return this.OutGameData != null && this.OutGameData.IsAllLimitRewardClaimed() && this.OutGameData.IsAllShopGoodsSoldOut();
		}

		// Token: 0x060420AC RID: 270508 RVA: 0x010057B0 File Offset: 0x010039B0
		public override bool GetExDataRedPointShowState()
		{
			return this.CheckAllFunctionRedDot();
		}

		// Token: 0x060420AD RID: 270509 RVA: 0x010057B8 File Offset: 0x010039B8
		public bool CheckAllFunctionRedDot()
		{
			return base.IsUnLock() && (this.HasFirstOpenPageRedDot() || this.HasNewLevelRedDot(null) || this.HasShopRedDot() || this.HasLimitRewardRedDot());
		}

		// Token: 0x060420AE RID: 270510 RVA: 0x010057F8 File Offset: 0x010039F8
		[NullableContext(2)]
		public DangoBrawlOutGameData GetOutGameData()
		{
			return this.OutGameData;
		}

		// Token: 0x060420AF RID: 270511 RVA: 0x01005800 File Offset: 0x01003A00
		private int ToUnlockCacheId(int entityId)
		{
			if (entityId < 10000)
			{
				return entityId * 10;
			}
			return entityId % 10000;
		}

		// Token: 0x060420B0 RID: 270512 RVA: 0x01005816 File Offset: 0x01003A16
		private bool IsUnlockUnread(ActivityDangoBrawlData.EDangoBrawlStorageKey key, int entityId)
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, (int)key, 0, this.ToUnlockCacheId(entityId)) == 0;
		}

		// Token: 0x060420B1 RID: 270513 RVA: 0x01005835 File Offset: 0x01003A35
		private void SaveUnlockRead(ActivityDangoBrawlData.EDangoBrawlStorageKey key, int entityId)
		{
			ActivityModel.Instance.SaveActivityData(base.Id, (int)key, 0, this.ToUnlockCacheId(entityId), 1);
		}

		// Token: 0x060420B2 RID: 270514 RVA: 0x01005851 File Offset: 0x01003A51
		private void SaveUnlockUnread(ActivityDangoBrawlData.EDangoBrawlStorageKey key, int entityId)
		{
			ActivityModel.Instance.SaveActivityData(base.Id, (int)key, 0, this.ToUnlockCacheId(entityId), 0);
		}

		// Token: 0x060420B3 RID: 270515 RVA: 0x0100586D File Offset: 0x01003A6D
		private bool IsUnlockReadInitialized()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 4, 0, 0) == 1;
		}

		// Token: 0x060420B4 RID: 270516 RVA: 0x01005888 File Offset: 0x01003A88
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

		// Token: 0x060420B5 RID: 270517 RVA: 0x010059A4 File Offset: 0x01003BA4
		public void OnNewRolesUnlocked(IReadOnlyList<int> newRoleIds)
		{
			this.EnsureUnlockReadInitialized();
			foreach (int entityId in newRoleIds)
			{
				this.SaveUnlockUnread(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewRoleRead, entityId);
			}
		}

		// Token: 0x060420B6 RID: 270518 RVA: 0x010059F4 File Offset: 0x01003BF4
		public void OnNewItemsUnlocked(IReadOnlyList<int> newItemIds)
		{
			this.EnsureUnlockReadInitialized();
			foreach (int entityId in newItemIds)
			{
				this.SaveUnlockUnread(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewItemRead, entityId);
			}
		}

		// Token: 0x060420B7 RID: 270519 RVA: 0x01005A44 File Offset: 0x01003C44
		public void OnNewLevelsUnlocked(IReadOnlyList<int> newLevelIds)
		{
			this.EnsureUnlockReadInitialized();
			foreach (int entityId in newLevelIds)
			{
				this.SaveUnlockUnread(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewLevelRead, entityId);
			}
		}

		// Token: 0x060420B8 RID: 270520 RVA: 0x01005A94 File Offset: 0x01003C94
		public bool HasFirstOpenPageRedDot()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 0, 0, 0) == 0;
		}

		// Token: 0x060420B9 RID: 270521 RVA: 0x01005AAD File Offset: 0x01003CAD
		public void SetFirstOpenPageRedDot(bool hasRedDot)
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 0, 0, 0, (!hasRedDot) ? 1 : 0);
			if (!hasRedDot)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			}
		}

		// Token: 0x060420BA RID: 270522 RVA: 0x01005AE0 File Offset: 0x01003CE0
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

		// Token: 0x060420BB RID: 270523 RVA: 0x01005B80 File Offset: 0x01003D80
		public bool HasNewLevelRedDot(int levelId)
		{
			DangoBrawlOutGameData outGameData = this.OutGameData;
			DangoBrawlLevelData dangoBrawlLevelData = (outGameData != null) ? outGameData.GetLevelData(levelId) : null;
			return dangoBrawlLevelData != null && !dangoBrawlLevelData.IsLocked && !dangoBrawlLevelData.IsPassed && this.IsUnlockUnread(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewLevelRead, levelId);
		}

		// Token: 0x060420BC RID: 270524 RVA: 0x01005BC0 File Offset: 0x01003DC0
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

		// Token: 0x060420BD RID: 270525 RVA: 0x01005C84 File Offset: 0x01003E84
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

		// Token: 0x060420BE RID: 270526 RVA: 0x01005CEC File Offset: 0x01003EEC
		public bool HasNewRoleRedDot(int roleId)
		{
			return this.OutGameData != null && this.OutGameData.IsRoleUnlocked(roleId) && this.IsUnlockUnread(ActivityDangoBrawlData.EDangoBrawlStorageKey.NewRoleRead, roleId);
		}

		// Token: 0x060420BF RID: 270527 RVA: 0x01005D10 File Offset: 0x01003F10
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

		// Token: 0x060420C0 RID: 270528 RVA: 0x01005DBC File Offset: 0x01003FBC
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

		// Token: 0x060420C1 RID: 270529 RVA: 0x01005EB4 File Offset: 0x010040B4
		public bool HasNewItemUnlockAnim(int itemId)
		{
			return this.NewItemUnlockAnimCache.Contains(itemId);
		}

		// Token: 0x060420C2 RID: 270530 RVA: 0x01005EC2 File Offset: 0x010040C2
		public bool RemoveNewItemUnlockAnim(int itemId)
		{
			return this.NewItemUnlockAnimCache.Remove(itemId);
		}

		// Token: 0x060420C3 RID: 270531 RVA: 0x01005ED0 File Offset: 0x010040D0
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

		// Token: 0x060420C4 RID: 270532 RVA: 0x01005FF8 File Offset: 0x010041F8
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

		// Token: 0x060420C5 RID: 270533 RVA: 0x010060F4 File Offset: 0x010042F4
		public bool HasShopRedDot()
		{
			return this.HasFirstOpenShopRedDot() || this.HasShopNewGoodsRedDot();
		}

		// Token: 0x060420C6 RID: 270534 RVA: 0x01006106 File Offset: 0x01004306
		private bool HasFirstOpenShopRedDot()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 5, 0, 0) == 0;
		}

		// Token: 0x060420C7 RID: 270535 RVA: 0x01006120 File Offset: 0x01004320
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

		// Token: 0x060420C8 RID: 270536 RVA: 0x0100616B File Offset: 0x0100436B
		public void SetShopRedDot(bool hasRedDot)
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 5, 0, 0, (!hasRedDot) ? 1 : 0);
			if (!hasRedDot)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			}
		}

		// Token: 0x060420C9 RID: 270537 RVA: 0x0100619D File Offset: 0x0100439D
		public void MarkShopRead()
		{
			if (!this.HasFirstOpenShopRedDot())
			{
				return;
			}
			this.SetShopRedDot(false);
		}

		// Token: 0x060420CA RID: 270538 RVA: 0x010061B0 File Offset: 0x010043B0
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

		// Token: 0x060420CB RID: 270539 RVA: 0x010061ED File Offset: 0x010043ED
		public IReadOnlyDictionary<int, int> GetSettleRewardedItems()
		{
			return this.SettleRewardedItems;
		}

		// Token: 0x060420CC RID: 270540 RVA: 0x010061F8 File Offset: 0x010043F8
		public void ProtoInstBaseNotify(DangoBrawlInstBaseNotify resp)
		{
			DangoBrawlModel.Instance.InitBattleManager();
			this.InstBase = resp;
			this.ShopServerData.Init(resp.Shop);
			this.FightersServerData.Init(resp.Fighters);
			this.BackPackServerData.MyInfoList = resp.Bag.NormalItems.ToArray<DangoBrawlNormalBagItemInfo>();
			this.OpponentBackPackServerData.MyInfoList = resp.OpponentBagItems.ToArray<DangoBrawlNormalBagItemInfo>();
			this.BenchServerData.MyInfoList = resp.Bag.BenchItems.ToArray<DangoBrawlBenchItemInfo>();
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

		// Token: 0x060420CD RID: 270541 RVA: 0x01006302 File Offset: 0x01004502
		public void ProtoInstPrepareNotify(DangoBrawlInstPrepareNotify resp)
		{
		}

		// Token: 0x060420CE RID: 270542 RVA: 0x01006304 File Offset: 0x01004504
		public void ProtoInstEventSelectNotify(DangoBrawlInstEventSelectNotify resp)
		{
		}

		// Token: 0x060420CF RID: 270543 RVA: 0x01006308 File Offset: 0x01004508
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
			this.OpponentBackPackServerData.MyInfoList = resp.OpponentBagItems.ToArray<DangoBrawlNormalBagItemInfo>();
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
				if (Info.Instance.IsBuildShipping)
				{
					Log.Instance.Error(ELogModule.DangoBrawl, ELogAuthor.WHJ, "[ProtoRoundSwitchNotify] Shipping 包出现 ShopState→ShopState 非法流程", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				ActivityDangoBrawlData myActivityData = ActivityDangoBrawlController.Instance.MyActivityData;
				if (myActivityData != null)
				{
					DangoBrawlModel.Instance.CreateViewData(myActivityData);
					return;
				}
			}
			else if (battleManager.IsForceEnterFinalState)
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
			}
		}

		// Token: 0x060420D0 RID: 270544 RVA: 0x010064A2 File Offset: 0x010046A2
		public void ProtoCoinUpdateNotify(DangoBrawlCoinUpdateNotify resp)
		{
			if (this.InstBase != null)
			{
				this.InstBase.Coin = resp.Coin;
			}
		}

		// Token: 0x060420D1 RID: 270545 RVA: 0x010064C0 File Offset: 0x010046C0
		public void ProtoBagUpdateNotify(DangoBrawlBagUpdateNotify resp)
		{
			DangoBrawlBagInfo bag = resp.Bag;
			if (bag != null)
			{
				this.BackPackServerData.MyInfoList = bag.NormalItems.ToArray<DangoBrawlNormalBagItemInfo>();
				this.BenchServerData.MyInfoList = bag.BenchItems.ToArray<DangoBrawlBenchItemInfo>();
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

		// Token: 0x060420D2 RID: 270546 RVA: 0x01006668 File Offset: 0x01004868
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

		// Token: 0x060420D3 RID: 270547 RVA: 0x01006718 File Offset: 0x01004918
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

		// Token: 0x060420D4 RID: 270548 RVA: 0x010067B8 File Offset: 0x010049B8
		public void OnDangoBrawlLoseCountChange(DangoBrawlLoseCountUpdateNotify message)
		{
			if (this.InstBase != null)
			{
				this.InstBase.LoseCount = message.LoseCount;
			}
		}

		// Token: 0x060420D5 RID: 270549 RVA: 0x010067D3 File Offset: 0x010049D3
		public void OnDangoBrawlFighterAttrChange(DangoBrawlFighterAttrChangeNotify message)
		{
			DangoBrawlFighterServerData fighter = this.FightersServerData.GetFighter(message.FighterUId);
			if (fighter != null)
			{
				fighter.SetFinalAttrs(message.FinalAttrs);
			}
			this.SyncAttrToEntity(message.FighterUId, message.FinalAttrs);
		}

		// Token: 0x060420D6 RID: 270550 RVA: 0x0100680C File Offset: 0x01004A0C
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

		// Token: 0x060420D7 RID: 270551 RVA: 0x010068A8 File Offset: 0x01004AA8
		public void OnStartFightFighters(IReadOnlyList<DangoBrawlFighterInfo> fighters)
		{
			this.FightersServerData.UpdateFighters(fighters);
		}

		// Token: 0x060420D8 RID: 270552 RVA: 0x010068B6 File Offset: 0x01004AB6
		[NullableContext(2)]
		public void OnShopRefreshed(DangoBrawlShopInfo shop)
		{
			if (shop != null)
			{
				this.ShopServerData.UpdateShopInfo(shop);
			}
		}

		// Token: 0x060420D9 RID: 270553 RVA: 0x010068C7 File Offset: 0x01004AC7
		public bool OnShopSlotLocked(int uid, bool locked)
		{
			return this.ShopServerData.SetSlotLocked(uid, locked);
		}

		// Token: 0x060420DA RID: 270554 RVA: 0x010068D8 File Offset: 0x01004AD8
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

		// Token: 0x060420DB RID: 270555 RVA: 0x010069A4 File Offset: 0x01004BA4
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

		// Token: 0x060420DC RID: 270556 RVA: 0x010069CC File Offset: 0x01004BCC
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

		// Token: 0x1700966B RID: 38507
		// (get) Token: 0x060420DD RID: 270557 RVA: 0x01006ADE File Offset: 0x01004CDE
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

		// Token: 0x1700966C RID: 38508
		// (get) Token: 0x060420DE RID: 270558 RVA: 0x01006AF1 File Offset: 0x01004CF1
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

		// Token: 0x1700966D RID: 38509
		// (get) Token: 0x060420DF RID: 270559 RVA: 0x01006B09 File Offset: 0x01004D09
		public RepeatedField<DangoBrawlShopSlotInfo> ShopSlots
		{
			get
			{
				DangoBrawlShopInfo myShopInfo = this.ShopServerData.MyShopInfo;
				return ((myShopInfo != null) ? myShopInfo.Slots : null) ?? new RepeatedField<DangoBrawlShopSlotInfo>();
			}
		}

		// Token: 0x1700966E RID: 38510
		// (get) Token: 0x060420E0 RID: 270560 RVA: 0x01006B2B File Offset: 0x01004D2B
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

		// Token: 0x060420E1 RID: 270561 RVA: 0x01006B43 File Offset: 0x01004D43
		public int GetBagWeight()
		{
			DangoBrawlBackpackData bagpackData = this.BagpackData;
			if (bagpackData == null)
			{
				return 0;
			}
			return bagpackData.GetCurrentWeight();
		}

		// Token: 0x060420E2 RID: 270562 RVA: 0x01006B56 File Offset: 0x01004D56
		public int GetShopGoodsSlotIndex(int uid)
		{
			return this.ShopServerData.GetSlotIndex(uid);
		}

		// Token: 0x060420E3 RID: 270563 RVA: 0x01006B64 File Offset: 0x01004D64
		public int GetShopRound()
		{
			DangoBrawlInstBaseNotify instBase = this.InstBase;
			if (instBase == null)
			{
				return 1;
			}
			return instBase.RoundNum;
		}

		// Token: 0x060420E4 RID: 270564 RVA: 0x01006B78 File Offset: 0x01004D78
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

		// Token: 0x060420E5 RID: 270565 RVA: 0x01006BF1 File Offset: 0x01004DF1
		public int GetRoleId()
		{
			DangoBrawlInstBaseNotify instBase = this.InstBase;
			if (instBase == null)
			{
				return 0;
			}
			return instBase.RoleId;
		}

		// Token: 0x060420E6 RID: 270566 RVA: 0x01006C04 File Offset: 0x01004E04
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

		// Token: 0x060420E7 RID: 270567 RVA: 0x01006C80 File Offset: 0x01004E80
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

		// Token: 0x04022643 RID: 140867
		[Nullable(2)]
		private DangoBrawlOutGameData OutGameData;

		// Token: 0x04022644 RID: 140868
		private const int CacheUnread = 0;

		// Token: 0x04022645 RID: 140869
		private const int CacheRead = 1;

		// Token: 0x04022646 RID: 140870
		private const int UnlockCacheIdMod = 10000;

		// Token: 0x04022647 RID: 140871
		private const int UnlockCacheIdMulti = 10;

		// Token: 0x04022648 RID: 140872
		private readonly HashSet<int> NewItemUnlockAnimCache = new HashSet<int>();

		// Token: 0x04022649 RID: 140873
		[Nullable(2)]
		public DangoBrawlInstBaseNotify InstBase;

		// Token: 0x0402264A RID: 140874
		private readonly Dictionary<int, int> SettleRewardedItems = new Dictionary<int, int>();

		// Token: 0x0402264B RID: 140875
		private readonly Dictionary<int, int> RoundGiveCoinDelta = new Dictionary<int, int>();

		// Token: 0x0402264C RID: 140876
		private DangoBrawlBackPackServerData BackPackServerData = new DangoBrawlBackPackServerData();

		// Token: 0x0402264D RID: 140877
		private DangoBrawlBenchServerData BenchServerData = new DangoBrawlBenchServerData();

		// Token: 0x0402264E RID: 140878
		public DangoBrawlShopServerData ShopServerData = new DangoBrawlShopServerData();

		// Token: 0x0402264F RID: 140879
		public DangoBrawlBackPackServerData OpponentBackPackServerData = new DangoBrawlBackPackServerData();

		// Token: 0x04022650 RID: 140880
		public DangoBrawlFightersServerData FightersServerData = new DangoBrawlFightersServerData();

		// Token: 0x04022651 RID: 140881
		public DangoBrawlEventSelectServerData EventSelectServerData = new DangoBrawlEventSelectServerData();

		// Token: 0x04022652 RID: 140882
		[Nullable(2)]
		public DangoBrawlBackpackData BagpackData;

		// Token: 0x04022653 RID: 140883
		[Nullable(2)]
		public DangoBrawlBenchData BenchData;

		// Token: 0x04022654 RID: 140884
		[Nullable(2)]
		public DangoBrawlBackpackViewData BackpackViewData;

		// Token: 0x0200C8E3 RID: 51427
		[NullableContext(0)]
		private enum EDangoBrawlStorageKey
		{
			// Token: 0x0403CA6C RID: 248428
			FirstOpenPage,
			// Token: 0x0403CA6D RID: 248429
			NewLevelRead,
			// Token: 0x0403CA6E RID: 248430
			NewRoleRead,
			// Token: 0x0403CA6F RID: 248431
			NewItemRead,
			// Token: 0x0403CA70 RID: 248432
			UnlockReadInitialized,
			// Token: 0x0403CA71 RID: 248433
			FirstOpenShop
		}
	}
}
