using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200578C RID: 22412
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlSuccessSettleView : UiViewBase
	{
		// Token: 0x17006A8F RID: 27279
		// (get) Token: 0x060374F2 RID: 226546 RVA: 0x00F723CD File Offset: 0x00F705CD
		[Nullable(2)]
		private ActivityDangoBrawlData ActData
		{
			[NullableContext(2)]
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData;
			}
		}

		// Token: 0x17006A90 RID: 27280
		// (get) Token: 0x060374F3 RID: 226547 RVA: 0x00F723D9 File Offset: 0x00F705D9
		[Nullable(2)]
		private DangoBrawlOutGameData OutGameData
		{
			[NullableContext(2)]
			get
			{
				ActivityDangoBrawlData actData = this.ActData;
				if (actData == null)
				{
					return null;
				}
				return actData.GetOutGameData();
			}
		}

		// Token: 0x060374F4 RID: 226548 RVA: 0x00F723EC File Offset: 0x00F705EC
		public DangoBrawlSuccessSettleView(UiViewInfo viewInfo)
		{
			Dictionary<EDangoBrawlSettleBtnText, string> dictionary = new Dictionary<EDangoBrawlSettleBtnText, string>();
			dictionary[EDangoBrawlSettleBtnText.Back] = "DangoBrawlBattleUIText_032";
			dictionary[EDangoBrawlSettleBtnText.NextLevel] = "DangoBrawlBattleUIText_033";
			dictionary[EDangoBrawlSettleBtnText.GoAdventure] = "DangoBrawlBattleUIText_034";
			this.btnTextMap = dictionary;
			base..ctor(viewInfo);
		}

		// Token: 0x060374F5 RID: 226549 RVA: 0x00F7243C File Offset: 0x00F7063C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action<EToggleState>(this.OnClickBackpackDetail));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060374F6 RID: 226550 RVA: 0x00F72610 File Offset: 0x00F70810
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlSuccessSettleView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlSuccessSettleView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060374F7 RID: 226551 RVA: 0x00F72653 File Offset: 0x00F70853
		protected override void OnStart()
		{
			this.InitLevelInfo();
			this.InitRewardDataList();
			this.RefreshInfo();
		}

		// Token: 0x060374F8 RID: 226552 RVA: 0x00F72667 File Offset: 0x00F70867
		protected override void OnBeforeDestroy()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			if (battleManager != null)
			{
				DangoBrawlFsm battleFsm = battleManager.GetBattleFsm();
				if (battleFsm != null)
				{
					battleFsm.ChangeState(EDangoBrawlFsmState.GameExit).Forget();
				}
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x060374F9 RID: 226553 RVA: 0x00F72696 File Offset: 0x00F70896
		private DangoBrawlRetryCountItem CreateRetryCountItem()
		{
			return new DangoBrawlRetryCountItem();
		}

		// Token: 0x060374FA RID: 226554 RVA: 0x00F7269D File Offset: 0x00F7089D
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = new Func<TItem, bool>(this.OnShowRewardReceivedCallBack)
			};
		}

		// Token: 0x060374FB RID: 226555 RVA: 0x00F726B6 File Offset: 0x00F708B6
		private bool OnShowRewardReceivedCallBack(TItem _)
		{
			return this.IsRewardClaimed;
		}

		// Token: 0x060374FC RID: 226556 RVA: 0x00F726C0 File Offset: 0x00F708C0
		private void InitRewardDataList()
		{
			this.RewardDataList.Clear();
			this.IsRewardClaimed = false;
			ActivityDangoBrawlData actData = this.ActData;
			IReadOnlyDictionary<int, int> readOnlyDictionary = (actData != null) ? actData.GetSettleRewardedItems() : null;
			if (readOnlyDictionary == null)
			{
				return;
			}
			if (readOnlyDictionary.Count == 0)
			{
				this.IsRewardClaimed = true;
				DangoBrawlOutGameData outGameData = this.OutGameData;
				int? num;
				if (outGameData == null)
				{
					num = null;
				}
				else
				{
					DangoBrawlLevelData levelData = outGameData.GetLevelData(this.CurrentLevelId);
					num = ((levelData != null) ? new int?(levelData.FirstClearDropId) : null);
				}
				int? num2 = num;
				int valueOrDefault = num2.GetValueOrDefault();
				if (valueOrDefault > 0)
				{
					this.RewardDataList.AddRange(RewardConfig.Instance.GetDropPackagePreviewItemList(valueOrDefault));
				}
				return;
			}
			DangoBrawlOutGameData outGameData2 = this.OutGameData;
			int[] array;
			if (outGameData2 == null)
			{
				array = null;
			}
			else
			{
				DangoBrawlLevelData levelData2 = outGameData2.GetLevelData(this.CurrentLevelId);
				array = ((levelData2 != null) ? levelData2.UnlockRoleIdList : null);
			}
			int[] array2 = array ?? Array.Empty<int>();
			foreach (KeyValuePair<int, int> keyValuePair in readOnlyDictionary)
			{
				if (Array.IndexOf<int>(array2, keyValuePair.Key) < 0)
				{
					this.RewardDataList.Add(new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value));
				}
			}
		}

		// Token: 0x060374FD RID: 226557 RVA: 0x00F72800 File Offset: 0x00F70A00
		private void InitLevelInfo()
		{
			ActivityDangoBrawlData actData = this.ActData;
			DangoBrawlInstBaseNotify dangoBrawlInstBaseNotify = (actData != null) ? actData.InstBase : null;
			int currentLevelId = (dangoBrawlInstBaseNotify != null) ? dangoBrawlInstBaseNotify.ChallengeId : 0;
			DangoBrawlOutGameData outGameData = this.OutGameData;
			DangoBrawlLevelData dangoBrawlLevelData = (outGameData != null) ? outGameData.GetLevelData(currentLevelId) : null;
			bool flag = dangoBrawlLevelData == null || dangoBrawlLevelData.IsNormalMode;
			this.CurrentLevelId = currentLevelId;
			if (flag)
			{
				DangoBrawlOutGameData outGameData2 = this.OutGameData;
				List<DangoBrawlLevelData> list = ((outGameData2 != null) ? outGameData2.GetLevelDataList(true) : null) ?? new List<DangoBrawlLevelData>();
				int num = list.FindIndex((DangoBrawlLevelData l) => l.Id == currentLevelId);
				DangoBrawlLevelData dangoBrawlLevelData2 = (num >= 0 && num < list.Count - 1) ? list[num + 1] : null;
				if (dangoBrawlLevelData2 != null)
				{
					this.CurrentLevelMode = EDangoBrawlSuccessSettleBtnMode.Normal;
					this.NextLevelId = dangoBrawlLevelData2.Id;
					return;
				}
				this.CurrentLevelMode = EDangoBrawlSuccessSettleBtnMode.NormalLastLevel;
				DangoBrawlOutGameData outGameData3 = this.OutGameData;
				List<DangoBrawlLevelData> list2 = ((outGameData3 != null) ? outGameData3.GetLevelDataList(false) : null) ?? new List<DangoBrawlLevelData>();
				this.NextLevelId = ((list2.Count > 0) ? list2[0].Id : 0);
				return;
			}
			else
			{
				DangoBrawlOutGameData outGameData4 = this.OutGameData;
				List<DangoBrawlLevelData> list3 = ((outGameData4 != null) ? outGameData4.GetLevelDataList(false) : null) ?? new List<DangoBrawlLevelData>();
				int num2 = list3.FindIndex((DangoBrawlLevelData l) => l.Id == currentLevelId);
				DangoBrawlLevelData dangoBrawlLevelData3 = (num2 >= 0 && num2 < list3.Count - 1) ? list3[num2 + 1] : null;
				if (dangoBrawlLevelData3 != null)
				{
					this.CurrentLevelMode = EDangoBrawlSuccessSettleBtnMode.Normal;
					this.NextLevelId = dangoBrawlLevelData3.Id;
					return;
				}
				this.CurrentLevelMode = EDangoBrawlSuccessSettleBtnMode.AdventureLastLevel;
				this.NextLevelId = 0;
				return;
			}
		}

		// Token: 0x060374FE RID: 226558 RVA: 0x00F72998 File Offset: 0x00F70B98
		private void RefreshInfo()
		{
			ActivityDangoBrawlData actData = this.ActData;
			DangoBrawlInstBaseNotify dangoBrawlInstBaseNotify = (actData != null) ? actData.InstBase : null;
			int levelId = (dangoBrawlInstBaseNotify != null) ? dangoBrawlInstBaseNotify.ChallengeId : 0;
			DangoBrawlOutGameData outGameData = this.OutGameData;
			DangoBrawlLevelData dangoBrawlLevelData = (outGameData != null) ? outGameData.GetLevelData(levelId) : null;
			int value = (dangoBrawlInstBaseNotify != null) ? dangoBrawlInstBaseNotify.WinCount : 0;
			int usedCount = (dangoBrawlInstBaseNotify != null) ? dangoBrawlInstBaseNotify.LoseCount : 0;
			int maxHp = (dangoBrawlLevelData != null) ? dangoBrawlLevelData.MaxRetryCount : 0;
			int num = (dangoBrawlLevelData != null) ? dangoBrawlLevelData.WinCount : 0;
			int num2 = (dangoBrawlLevelData != null) ? dangoBrawlLevelData.AdditionRound : 0;
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			bool flag = battleManager != null && battleManager.HasEnteredAdditionRound;
			int value2 = num + (flag ? num2 : 0);
			UUIText text = base.GetText(0);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			DangoBrawlOutGameData outGameData2 = this.OutGameData;
			ValueTuple<string, int> valueTuple = (outGameData2 != null) ? outGameData2.GetLevelModeInfo(levelId) : new ValueTuple<string, int>("", 0);
			string item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "DangoBrawlBattleUIText_042", new <>z__ReadOnlyArray<object>(new object[]
			{
				item,
				item2
			}));
			GenericLayout<DangoBrawlRetryCountItem, DangoBrawlRetryCountInfo> heartLayout = this.HeartLayout;
			if (heartLayout != null)
			{
				heartLayout.RefreshByData(DangoBrawlUtil.BuildRetryHeartList(maxHp, usedCount, false), null, false);
			}
			this.RefreshButtonDisplay();
			this.RefreshRewardDisplay(this.RewardDataList);
		}

		// Token: 0x060374FF RID: 226559 RVA: 0x00F72B10 File Offset: 0x00F70D10
		private void RefreshButtonDisplay()
		{
			bool flag3;
			if (this.NextLevelId > 0)
			{
				DangoBrawlOutGameData outGameData = this.OutGameData;
				bool? flag;
				if (outGameData == null)
				{
					flag = null;
				}
				else
				{
					DangoBrawlLevelData levelData = outGameData.GetLevelData(this.NextLevelId);
					flag = ((levelData != null) ? new bool?(levelData.IsPassed) : null);
				}
				bool? flag2 = flag;
				flag3 = !flag2.GetValueOrDefault();
			}
			else
			{
				flag3 = false;
			}
			bool uiactive = flag3;
			switch (this.CurrentLevelMode)
			{
			case EDangoBrawlSuccessSettleBtnMode.Normal:
			{
				DangoBrawlFinalSettleButton nextBtn = this.NextBtn;
				if (nextBtn != null)
				{
					nextBtn.SetUiActive(true);
				}
				DangoBrawlFinalSettleButton nextBtn2 = this.NextBtn;
				if (nextBtn2 != null)
				{
					nextBtn2.SetConfirmText(this.btnTextMap[EDangoBrawlSettleBtnText.NextLevel]);
				}
				UUIItem item = base.GetItem(5);
				if (item != null)
				{
					item.SetUIActive(uiactive);
				}
				break;
			}
			case EDangoBrawlSuccessSettleBtnMode.NormalLastLevel:
			{
				DangoBrawlFinalSettleButton nextBtn3 = this.NextBtn;
				if (nextBtn3 != null)
				{
					nextBtn3.SetUiActive(true);
				}
				DangoBrawlFinalSettleButton nextBtn4 = this.NextBtn;
				if (nextBtn4 != null)
				{
					nextBtn4.SetConfirmText(this.btnTextMap[EDangoBrawlSettleBtnText.GoAdventure]);
				}
				UUIItem item2 = base.GetItem(5);
				if (item2 != null)
				{
					item2.SetUIActive(uiactive);
				}
				break;
			}
			case EDangoBrawlSuccessSettleBtnMode.AdventureLastLevel:
			{
				DangoBrawlFinalSettleButton nextBtn5 = this.NextBtn;
				if (nextBtn5 != null)
				{
					nextBtn5.SetUiActive(false);
				}
				UUIItem item3 = base.GetItem(5);
				if (item3 != null)
				{
					item3.SetUIActive(false);
				}
				break;
			}
			}
			DangoBrawlFinalSettleButton backBtn = this.BackBtn;
			if (backBtn != null)
			{
				backBtn.SetUiActive(true);
			}
			DangoBrawlFinalSettleButton backBtn2 = this.BackBtn;
			if (backBtn2 == null)
			{
				return;
			}
			backBtn2.SetConfirmText(this.btnTextMap[EDangoBrawlSettleBtnText.Back]);
		}

		// Token: 0x06037500 RID: 226560 RVA: 0x00F72C67 File Offset: 0x00F70E67
		private void RefreshRewardDisplay(List<TItem> rewardDataList)
		{
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardScrollView = this.RewardScrollView;
			if (rewardScrollView == null)
			{
				return;
			}
			rewardScrollView.RefreshByData(rewardDataList, null, false);
		}

		// Token: 0x06037501 RID: 226561 RVA: 0x00F72C7C File Offset: 0x00F70E7C
		private void OnClickBack()
		{
			DangoBrawlOutGameData outGameData = this.OutGameData;
			DangoBrawlLevelData dangoBrawlLevelData = (outGameData != null) ? outGameData.GetLevelData(this.CurrentLevelId) : null;
			bool isNormalMode = dangoBrawlLevelData == null || dangoBrawlLevelData.IsNormalMode;
			AfterLeaveInstanceDungeonOpenViewParam openParam = new AfterLeaveInstanceDungeonOpenViewParam
			{
				OpenViewName = EDangoBrawlViewName.LevelView,
				LevelId = this.CurrentLevelId,
				IsNormalMode = isNormalMode
			};
			ActivityDangoBrawlController.Instance.RequestLeaveInstanceDungeon(openParam).Forget<bool>();
		}

		// Token: 0x06037502 RID: 226562 RVA: 0x00F72CE4 File Offset: 0x00F70EE4
		private void OnClickNext()
		{
			if (this.NextLevelId <= 0)
			{
				return;
			}
			AfterLeaveInstanceDungeonOpenViewParam openParam = new AfterLeaveInstanceDungeonOpenViewParam
			{
				OpenViewName = EDangoBrawlViewName.RoleSelectView,
				LevelId = this.NextLevelId
			};
			ActivityDangoBrawlController.Instance.RequestLeaveInstanceDungeon(openParam).Forget<bool>();
		}

		// Token: 0x06037503 RID: 226563 RVA: 0x00F72D29 File Offset: 0x00F70F29
		private void OnClickBackpackDetail(EToggleState state)
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlSettleRoleBagDetailView, null, null);
			UUIExtendToggle extendToggle = base.GetExtendToggle(8);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0401D37D RID: 119677
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRetryCountItem, DangoBrawlRetryCountInfo> HeartLayout;

		// Token: 0x0401D37E RID: 119678
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x0401D37F RID: 119679
		[Nullable(2)]
		private DangoBrawlFinalSettleButton BackBtn;

		// Token: 0x0401D380 RID: 119680
		[Nullable(2)]
		private DangoBrawlFinalSettleButton NextBtn;

		// Token: 0x0401D381 RID: 119681
		private readonly List<TItem> RewardDataList = new List<TItem>();

		// Token: 0x0401D382 RID: 119682
		private bool IsRewardClaimed;

		// Token: 0x0401D383 RID: 119683
		private EDangoBrawlSuccessSettleBtnMode CurrentLevelMode;

		// Token: 0x0401D384 RID: 119684
		private int CurrentLevelId;

		// Token: 0x0401D385 RID: 119685
		private int NextLevelId;

		// Token: 0x0401D386 RID: 119686
		private readonly Dictionary<EDangoBrawlSettleBtnText, string> btnTextMap;

		// Token: 0x0200B3CB RID: 46027
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04037983 RID: 227715
			TxtNum,
			// Token: 0x04037984 RID: 227716
			PnlHeartLayout,
			// Token: 0x04037985 RID: 227717
			SprHeart,
			// Token: 0x04037986 RID: 227718
			SvInfo,
			// Token: 0x04037987 RID: 227719
			Uiitem_TuJianPageBItem2,
			// Token: 0x04037988 RID: 227720
			PnlTipsNext,
			// Token: 0x04037989 RID: 227721
			BtnBack,
			// Token: 0x0403798A RID: 227722
			BtnNext,
			// Token: 0x0403798B RID: 227723
			TogDetail,
			// Token: 0x0403798C RID: 227724
			PnlSelf,
			// Token: 0x0403798D RID: 227725
			TxtTitle
		}
	}
}
