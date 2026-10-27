using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005160 RID: 20832
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaEntranceRepeatTabView : PhantomArenaChildViewBase
	{
		// Token: 0x1700811A RID: 33050
		// (get) Token: 0x0603542F RID: 218159 RVA: 0x00C9CF11 File Offset: 0x00C9B111
		// (set) Token: 0x06035430 RID: 218160 RVA: 0x00C9CF1E File Offset: 0x00C9B11E
		public new PhantomArenaEntranceViewModel ViewModel
		{
			get
			{
				return this.ViewModel as PhantomArenaEntranceViewModel;
			}
			set
			{
				this.ViewModel = value;
			}
		}

		// Token: 0x06035431 RID: 218161 RVA: 0x00C9CF28 File Offset: 0x00C9B128
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem))
			};
		}

		// Token: 0x06035432 RID: 218162 RVA: 0x00C9D020 File Offset: 0x00C9B220
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaEntranceRepeatTabView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaEntranceRepeatTabView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035433 RID: 218163 RVA: 0x00C9D064 File Offset: 0x00C9B264
		protected override void OnStart()
		{
			this.LayoutReward = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(4), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, null);
			PhantomArenaModel.Instance.SetGymRedDotChecked(7, base.ActivityId);
			int player = LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.PhantomArenaRepeatLastIndex, 0);
			List<GymChallengeData> challengeStateListByGymLevel = PhantomArenaModel.Instance.GetChallengeStateListByGymLevel(7, base.ActivityId);
			this.ChallengeData = challengeStateListByGymLevel[player];
			this.DropDownDifficulty.InitScroll(challengeStateListByGymLevel, new Func<GymChallengeData, GymChallengeData>(this.GetDropDownItemData), player, true);
			this.DropDownDifficulty.SetShowType(ECommonDropDownShowType.Up);
			this.DropDownDifficulty.SetOnSelectCall(new Action<int, GymChallengeData>(this.OnSelectDifficulty));
		}

		// Token: 0x06035434 RID: 218164 RVA: 0x00C9D11B File Offset: 0x00C9B31B
		protected override void OnBeforeShow()
		{
			this.RefreshInfo();
			this.RefreshPoints();
			this.RefreshBtns();
		}

		// Token: 0x06035435 RID: 218165 RVA: 0x00C9D130 File Offset: 0x00C9B330
		private void RefreshInfo()
		{
			PhantomBattleChallenge phantomBattleChallenge = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(this.ChallengeId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), phantomBattleChallenge.ChallengeName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), phantomBattleChallenge.NpcDesc, Array.Empty<object>());
			List<TItem> rewardListByChallengeId = PhantomArenaModel.Instance.GetRewardListByChallengeId(this.ChallengeId);
			this.LayoutReward.RefreshByData(rewardListByChallengeId, null, false);
			int masterLevel = PhantomArenaModel.Instance.GetMasterLevel(base.ActivityId);
			int repeatGymExpWeekLimitByLevel = PhantomArenaConfig.Instance.GetRepeatGymExpWeekLimitByLevel(masterLevel);
			int masterExpWeek = PhantomArenaModel.Instance.GetMasterExpWeek(base.ActivityId);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(6), "PhantomBattle_1117", new <>z__ReadOnlyArray<object>(new object[]
			{
				masterExpWeek,
				repeatGymExpWeekLimitByLevel
			}));
		}

		// Token: 0x06035436 RID: 218166 RVA: 0x00C9D20C File Offset: 0x00C9B40C
		private void RefreshPoints()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "PhantomBattle_1106", Array.Empty<object>());
			int pointsItemId = PhantomArenaModel.Instance.GetPointsItemId(base.ActivityId);
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(pointsItemId, 0);
			base.GetText(1).SetText(commonItemCount.ToString(), true);
		}

		// Token: 0x06035437 RID: 218167 RVA: 0x00C9D268 File Offset: 0x00C9B468
		private void RefreshBtns()
		{
			bool uiActive = FunctionModel.Instance.IsOpen(EFunctionType.PhantomArenaCard);
			this.BtnCard.SetUiActive(uiActive);
		}

		// Token: 0x06035438 RID: 218168 RVA: 0x00C9D294 File Offset: 0x00C9B494
		private void OnClickCard(int _)
		{
			PhantomArenaMainViewOpenParam param = new PhantomArenaMainViewOpenParam
			{
				ChallengeId = 0,
				OpenView = EPhantomArenaChildViewName.PhantomArenaDeckOverviewTabView,
				ActivityId = base.ActivityId
			};
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaMainView, param, null);
		}

		// Token: 0x06035439 RID: 218169 RVA: 0x00C9D2D2 File Offset: 0x00C9B4D2
		private void OnClickConfirm(int _)
		{
			if (!PhantomArenaModel.Instance.GetRepeatChallengeOpen(this.ChallengeId))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattle_1112", Array.Empty<object>());
				return;
			}
			this.ViewModel.SetRepeatChallenge(this.ChallengeId, false);
		}

		// Token: 0x0603543A RID: 218170 RVA: 0x00C9D30D File Offset: 0x00C9B50D
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0603543B RID: 218171 RVA: 0x00C9D314 File Offset: 0x00C9B514
		private bool OnCheckCanChange(int oldIndex, int newIndex)
		{
			return oldIndex != newIndex && PhantomArenaModel.Instance.GetChallengeStateListByGymLevel(7, base.ActivityId)[newIndex].State > EChallengeState.Lock;
		}

		// Token: 0x0603543C RID: 218172 RVA: 0x00C9D33C File Offset: 0x00C9B53C
		private void OnSelectDifficulty(int index, object data)
		{
			GymChallengeData challengeData = data as GymChallengeData;
			this.ChallengeData = challengeData;
			LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.PhantomArenaRepeatLastIndex, index);
			this.RefreshInfo();
		}

		// Token: 0x0603543D RID: 218173 RVA: 0x00C9D369 File Offset: 0x00C9B569
		private GymChallengeData GetDropDownItemData(object data)
		{
			return data as GymChallengeData;
		}

		// Token: 0x1700811B RID: 33051
		// (get) Token: 0x0603543E RID: 218174 RVA: 0x00C9D371 File Offset: 0x00C9B571
		private int ChallengeId
		{
			get
			{
				GymChallengeData challengeData = this.ChallengeData;
				if (challengeData == null)
				{
					return -1;
				}
				return challengeData.Id;
			}
		}

		// Token: 0x0401C560 RID: 116064
		[Nullable(2)]
		private GymChallengeData ChallengeData;

		// Token: 0x0401C561 RID: 116065
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> LayoutReward;

		// Token: 0x0401C562 RID: 116066
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private CommonDropDown<GymChallengeData, GymChallengeData> DropDownDifficulty;

		// Token: 0x0401C563 RID: 116067
		[Nullable(2)]
		private ButtonItem BtnCard;

		// Token: 0x0401C564 RID: 116068
		[Nullable(2)]
		private ButtonItem BtnConfirm;

		// Token: 0x0200B2C1 RID: 45761
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04036295 RID: 221845
			public const int TextPointsAllTitle = 0;

			// Token: 0x04036296 RID: 221846
			public const int TextPointsAll = 1;

			// Token: 0x04036297 RID: 221847
			public const int TextChallenge = 2;

			// Token: 0x04036298 RID: 221848
			public const int TextDesc = 3;

			// Token: 0x04036299 RID: 221849
			public const int ScrollReward = 4;

			// Token: 0x0403629A RID: 221850
			public const int ItemReward = 5;

			// Token: 0x0403629B RID: 221851
			public const int TextPointsNow = 6;

			// Token: 0x0403629C RID: 221852
			public const int ItemDropDown = 7;

			// Token: 0x0403629D RID: 221853
			public const int BtnConfirmLeft = 8;

			// Token: 0x0403629E RID: 221854
			public const int BtnConfirmRight = 9;
		}
	}
}
