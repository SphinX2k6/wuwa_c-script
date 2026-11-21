using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004130 RID: 16688
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaEntranceRepeatTabView : PhantomArenaChildViewBase
	{
		// Token: 0x170054DA RID: 21722
		// (get) Token: 0x0602A32B RID: 172843 RVA: 0x00BEA411 File Offset: 0x00BE8611
		// (set) Token: 0x0602A32C RID: 172844 RVA: 0x00BEA41E File Offset: 0x00BE861E
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

		// Token: 0x0602A32D RID: 172845 RVA: 0x00BEA428 File Offset: 0x00BE8628
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

		// Token: 0x0602A32E RID: 172846 RVA: 0x00BEA520 File Offset: 0x00BE8720
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaEntranceRepeatTabView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaEntranceRepeatTabView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A32F RID: 172847 RVA: 0x00BEA564 File Offset: 0x00BE8764
		protected override void OnStart()
		{
			this.LayoutReward = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(4), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, null);
			PhantomArenaModel.Instance.SetGymRedDotChecked(7, base.ActivityId);
			ServerStorageUtil.OverrideLocalNumberToServerNumber(ELocalStoragePlayerKey.PhantomArenaRepeatLastIndex, EClientStorageSystemIdType.PhantomArenaRepeatLastIndex, true);
			int valueOrDefault = (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.PhantomArenaRepeatLastIndex) as ServerStorageNumber).Get().GetValueOrDefault();
			List<GymChallengeData> challengeStateListByGymLevel = PhantomArenaModel.Instance.GetChallengeStateListByGymLevel(7, base.ActivityId);
			this.ChallengeData = challengeStateListByGymLevel[valueOrDefault];
			this.DropDownDifficulty.InitScroll(challengeStateListByGymLevel, new Func<GymChallengeData, GymChallengeData>(this.GetDropDownItemData), valueOrDefault, true);
			this.DropDownDifficulty.SetShowType(ECommonDropDownShowType.Up);
			this.DropDownDifficulty.SetOnSelectCall(new Action<int, GymChallengeData>(this.OnSelectDifficulty));
		}

		// Token: 0x0602A330 RID: 172848 RVA: 0x00BEA63C File Offset: 0x00BE883C
		protected override void OnBeforeShow()
		{
			this.RefreshInfo();
			this.RefreshPoints();
			this.RefreshBtns();
		}

		// Token: 0x0602A331 RID: 172849 RVA: 0x00BEA650 File Offset: 0x00BE8850
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

		// Token: 0x0602A332 RID: 172850 RVA: 0x00BEA72C File Offset: 0x00BE892C
		private void RefreshPoints()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "PhantomBattle_1106", Array.Empty<object>());
			int pointsItemId = PhantomArenaModel.Instance.GetPointsItemId(base.ActivityId);
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(pointsItemId, 0);
			base.GetText(1).SetText(commonItemCount.ToString(), true);
		}

		// Token: 0x0602A333 RID: 172851 RVA: 0x00BEA788 File Offset: 0x00BE8988
		private void RefreshBtns()
		{
			bool uiActive = FunctionModel.Instance.IsOpen(EFunctionType.PhantomArenaCard);
			this.BtnCard.SetUiActive(uiActive);
		}

		// Token: 0x0602A334 RID: 172852 RVA: 0x00BEA7B4 File Offset: 0x00BE89B4
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

		// Token: 0x0602A335 RID: 172853 RVA: 0x00BEA7F2 File Offset: 0x00BE89F2
		private void OnClickConfirm(int _)
		{
			if (!PhantomArenaModel.Instance.GetRepeatChallengeOpen(this.ChallengeId))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattle_1112", Array.Empty<object>());
				return;
			}
			this.ViewModel.SetRepeatChallenge(this.ChallengeId, false);
		}

		// Token: 0x0602A336 RID: 172854 RVA: 0x00BEA82D File Offset: 0x00BE8A2D
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0602A337 RID: 172855 RVA: 0x00BEA834 File Offset: 0x00BE8A34
		private bool OnCheckCanChange(int oldIndex, int newIndex)
		{
			return oldIndex != newIndex && PhantomArenaModel.Instance.GetChallengeStateListByGymLevel(7, base.ActivityId)[newIndex].State > EChallengeState.Lock;
		}

		// Token: 0x0602A338 RID: 172856 RVA: 0x00BEA85C File Offset: 0x00BE8A5C
		private void OnSelectDifficulty(int index, object data)
		{
			GymChallengeData challengeData = data as GymChallengeData;
			this.ChallengeData = challengeData;
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.PhantomArenaRepeatLastIndex) as ServerStorageNumber).Set(new int?(index));
			this.RefreshInfo();
		}

		// Token: 0x0602A339 RID: 172857 RVA: 0x00BEA899 File Offset: 0x00BE8A99
		private GymChallengeData GetDropDownItemData(object data)
		{
			return data as GymChallengeData;
		}

		// Token: 0x170054DB RID: 21723
		// (get) Token: 0x0602A33A RID: 172858 RVA: 0x00BEA8A1 File Offset: 0x00BE8AA1
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

		// Token: 0x04016F95 RID: 94101
		[Nullable(2)]
		private GymChallengeData ChallengeData;

		// Token: 0x04016F96 RID: 94102
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> LayoutReward;

		// Token: 0x04016F97 RID: 94103
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private CommonDropDown<GymChallengeData, GymChallengeData> DropDownDifficulty;

		// Token: 0x04016F98 RID: 94104
		[Nullable(2)]
		private ButtonItem BtnCard;

		// Token: 0x04016F99 RID: 94105
		[Nullable(2)]
		private ButtonItem BtnConfirm;

		// Token: 0x02009CFA RID: 40186
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04030CEA RID: 199914
			public const int TextPointsAllTitle = 0;

			// Token: 0x04030CEB RID: 199915
			public const int TextPointsAll = 1;

			// Token: 0x04030CEC RID: 199916
			public const int TextChallenge = 2;

			// Token: 0x04030CED RID: 199917
			public const int TextDesc = 3;

			// Token: 0x04030CEE RID: 199918
			public const int ScrollReward = 4;

			// Token: 0x04030CEF RID: 199919
			public const int ItemReward = 5;

			// Token: 0x04030CF0 RID: 199920
			public const int TextPointsNow = 6;

			// Token: 0x04030CF1 RID: 199921
			public const int ItemDropDown = 7;

			// Token: 0x04030CF2 RID: 199922
			public const int BtnConfirmLeft = 8;

			// Token: 0x04030CF3 RID: 199923
			public const int BtnConfirmRight = 9;
		}
	}
}
