using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x0200683C RID: 26684
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlSuccessSettleView : UiViewBase
	{
		// Token: 0x1700974E RID: 38734
		// (get) Token: 0x0604299E RID: 272798 RVA: 0x01030EC1 File Offset: 0x0102F0C1
		[Nullable(2)]
		private ActivityDangoBrawlData ActData
		{
			[NullableContext(2)]
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData;
			}
		}

		// Token: 0x1700974F RID: 38735
		// (get) Token: 0x0604299F RID: 272799 RVA: 0x01030ECD File Offset: 0x0102F0CD
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

		// Token: 0x060429A0 RID: 272800 RVA: 0x01030EE0 File Offset: 0x0102F0E0
		public DangoBrawlSuccessSettleView(UiViewInfo viewInfo)
		{
			Dictionary<EDangoBrawlSettleBtnText, string> dictionary = new Dictionary<EDangoBrawlSettleBtnText, string>();
			dictionary[EDangoBrawlSettleBtnText.Back] = "DangoBrawlBattleUIText_032";
			dictionary[EDangoBrawlSettleBtnText.NextLevel] = "DangoBrawlBattleUIText_033";
			dictionary[EDangoBrawlSettleBtnText.GoAdventure] = "DangoBrawlBattleUIText_034";
			this.btnTextMap = dictionary;
			base..ctor(viewInfo);
		}

		// Token: 0x060429A1 RID: 272801 RVA: 0x01030F30 File Offset: 0x0102F130
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

		// Token: 0x060429A2 RID: 272802 RVA: 0x01031104 File Offset: 0x0102F304
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlSuccessSettleView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlSuccessSettleView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060429A3 RID: 272803 RVA: 0x01031147 File Offset: 0x0102F347
		protected override void OnStart()
		{
			this.InitLevelInfo();
			this.InitRewardDataList();
			this.RefreshInfo();
		}

		// Token: 0x060429A4 RID: 272804 RVA: 0x0103115B File Offset: 0x0102F35B
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

		// Token: 0x060429A5 RID: 272805 RVA: 0x0103118A File Offset: 0x0102F38A
		private DangoBrawlRetryCountItem CreateRetryCountItem()
		{
			return new DangoBrawlRetryCountItem();
		}

		// Token: 0x060429A6 RID: 272806 RVA: 0x01031191 File Offset: 0x0102F391
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = new Func<TItem, bool>(this.OnShowRewardReceivedCallBack)
			};
		}

		// Token: 0x060429A7 RID: 272807 RVA: 0x010311AA File Offset: 0x0102F3AA
		private bool OnShowRewardReceivedCallBack(TItem _)
		{
			return this.IsRewardClaimed;
		}

		// Token: 0x060429A8 RID: 272808 RVA: 0x010311B4 File Offset: 0x0102F3B4
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
			int[] source = array ?? Array.Empty<int>();
			foreach (KeyValuePair<int, int> keyValuePair in readOnlyDictionary)
			{
				if (!source.Contains(keyValuePair.Key))
				{
					this.RewardDataList.Add(new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value));
				}
			}
		}

		// Token: 0x060429A9 RID: 272809 RVA: 0x010312F4 File Offset: 0x0102F4F4
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

		// Token: 0x060429AA RID: 272810 RVA: 0x0103148C File Offset: 0x0102F68C
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

		// Token: 0x060429AB RID: 272811 RVA: 0x01031604 File Offset: 0x0102F804
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

		// Token: 0x060429AC RID: 272812 RVA: 0x0103175B File Offset: 0x0102F95B
		private void RefreshRewardDisplay(List<TItem> rewardDataList)
		{
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardScrollView = this.RewardScrollView;
			if (rewardScrollView == null)
			{
				return;
			}
			rewardScrollView.RefreshByData(rewardDataList, null, false);
		}

		// Token: 0x060429AD RID: 272813 RVA: 0x01031770 File Offset: 0x0102F970
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

		// Token: 0x060429AE RID: 272814 RVA: 0x010317D8 File Offset: 0x0102F9D8
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

		// Token: 0x060429AF RID: 272815 RVA: 0x0103181D File Offset: 0x0102FA1D
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

		// Token: 0x04022B20 RID: 142112
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRetryCountItem, DangoBrawlRetryCountInfo> HeartLayout;

		// Token: 0x04022B21 RID: 142113
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x04022B22 RID: 142114
		[Nullable(2)]
		private DangoBrawlFinalSettleButton BackBtn;

		// Token: 0x04022B23 RID: 142115
		[Nullable(2)]
		private DangoBrawlFinalSettleButton NextBtn;

		// Token: 0x04022B24 RID: 142116
		private readonly List<TItem> RewardDataList = new List<TItem>();

		// Token: 0x04022B25 RID: 142117
		private bool IsRewardClaimed;

		// Token: 0x04022B26 RID: 142118
		private EDangoBrawlSuccessSettleBtnMode CurrentLevelMode;

		// Token: 0x04022B27 RID: 142119
		private int CurrentLevelId;

		// Token: 0x04022B28 RID: 142120
		private int NextLevelId;

		// Token: 0x04022B29 RID: 142121
		private readonly Dictionary<EDangoBrawlSettleBtnText, string> btnTextMap;

		// Token: 0x0200C9FF RID: 51711
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403D09A RID: 250010
			TxtNum,
			// Token: 0x0403D09B RID: 250011
			PnlHeartLayout,
			// Token: 0x0403D09C RID: 250012
			SprHeart,
			// Token: 0x0403D09D RID: 250013
			SvInfo,
			// Token: 0x0403D09E RID: 250014
			Uiitem_TuJianPageBItem2,
			// Token: 0x0403D09F RID: 250015
			PnlTipsNext,
			// Token: 0x0403D0A0 RID: 250016
			BtnBack,
			// Token: 0x0403D0A1 RID: 250017
			BtnNext,
			// Token: 0x0403D0A2 RID: 250018
			TogDetail,
			// Token: 0x0403D0A3 RID: 250019
			PnlSelf,
			// Token: 0x0403D0A4 RID: 250020
			TxtTitle
		}
	}
}
