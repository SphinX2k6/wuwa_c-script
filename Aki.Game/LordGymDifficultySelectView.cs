using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001686 RID: 5766
[NullableContext(1)]
[Nullable(0)]
public class LordGymDifficultySelectView : UiViewBase
{
	// Token: 0x0600E066 RID: 57446 RVA: 0x0041D8D6 File Offset: 0x0041BAD6
	public LordGymDifficultySelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E067 RID: 57447 RVA: 0x0041D8E0 File Offset: 0x0041BAE0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(14, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(10, new Action(this.OnStartChallengeButtonClick)),
			new ValueTuple<int, Delegate>(7, new Action(this.OnHistoryButtonClick)),
			new ValueTuple<int, Delegate>(14, new Action(this.OnCloseBtnClick))
		};
	}

	// Token: 0x0600E068 RID: 57448 RVA: 0x0041DAA0 File Offset: 0x0041BCA0
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymDifficultySelectView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymDifficultySelectView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E069 RID: 57449 RVA: 0x0041DAE3 File Offset: 0x0041BCE3
	protected override void OnHandleLoadScene()
	{
		UiSceneManager.Instance.InitLordSkeletalHandle();
		LordGymController.Instance.CreateLordModelByEntranceId();
		LordGymController.Instance.LoadLordModelByEntranceId(this.LordEntranceId, true, false).Forget();
	}

	// Token: 0x0600E06A RID: 57450 RVA: 0x0041DB10 File Offset: 0x0041BD10
	protected override void OnHandleReleaseScene()
	{
		UiSceneManager.Instance.DestroyLordSkeletalHandle();
	}

	// Token: 0x0600E06B RID: 57451 RVA: 0x0041DB1C File Offset: 0x0041BD1C
	protected virtual void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600E06C RID: 57452 RVA: 0x0041DB28 File Offset: 0x0041BD28
	private void OnHelpBtnClick()
	{
		int helpId = ConfigLordGymEntranceSetById.GetConfig(this.LordEntranceSetId, true).Value.HelpId;
		HelpController.Instance.OpenHelpById(helpId);
	}

	// Token: 0x0600E06D RID: 57453 RVA: 0x0041DB5D File Offset: 0x0041BD5D
	private LordGymDifficultyItem CreateDifficultyLoopItem()
	{
		return this.CreateItem();
	}

	// Token: 0x0600E06E RID: 57454 RVA: 0x0041DB65 File Offset: 0x0041BD65
	protected virtual LordGymDifficultyItem CreateItem()
	{
		return new LordGymDifficultyItem
		{
			OnToggleClick = new Action<int>(this.OnLordDifficultyToggleClick),
			CanExecuteChangeCallBack = new Func<int, bool>(this.CanLordDifficultyToggleChange)
		};
	}

	// Token: 0x0600E06F RID: 57455 RVA: 0x0041DB90 File Offset: 0x0041BD90
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600E070 RID: 57456 RVA: 0x0041DB97 File Offset: 0x0041BD97
	private void OnStartChallengeButtonClick()
	{
		this.OnStartChallenge();
	}

	// Token: 0x0600E071 RID: 57457 RVA: 0x0041DBA0 File Offset: 0x0041BDA0
	protected virtual void OnStartChallenge()
	{
		if (!LordGymController.Instance.IsInEntranceEntity())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("LordGymOpen_ErrorTipText", Array.Empty<object>());
			return;
		}
		int selectedGridIndex = this.LordDifficultyScrollView.GetSelectedGridIndex();
		int lordId = this.LordList[selectedGridIndex];
		LordGymController.Instance.LordGymBeginRequest(lordId).ContinueWith(delegate(bool isSuccess)
		{
			if (isSuccess)
			{
				UiManager.Instance.ResetToBattleView(null);
				LordGymModel.Instance.LastChallengeLordEntranceId = this.LordEntranceId;
			}
		}).Forget();
	}

	// Token: 0x0600E072 RID: 57458 RVA: 0x0041DC08 File Offset: 0x0041BE08
	private void OnHistoryButtonClick()
	{
		LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(this.SelectedLordId);
		LordGymChallengeRecordViewParam param = new LordGymChallengeRecordViewParam
		{
			EntranceId = this.LordEntranceId,
			Difficulty = ((lordGymConfig != null) ? lordGymConfig.Value.Difficulty : 0)
		};
		UiManager.Instance.OpenView(EUiViewName.LordGymChallengeRecordView, param, null);
	}

	// Token: 0x0600E073 RID: 57459 RVA: 0x0041DC6C File Offset: 0x0041BE6C
	private void SetDefaultSelect()
	{
		if (this.LordList == null || this.LordList.Count == 0)
		{
			return;
		}
		ILordGymDifficultySelectViewParam lordGymDifficultySelectViewParam = this.OpenParam as ILordGymDifficultySelectViewParam;
		int num = (lordGymDifficultySelectViewParam != null) ? lordGymDifficultySelectViewParam.DefaultLordId : 0;
		if (num > 0)
		{
			int num2 = this.LordList.IndexOf(num);
			if (num2 >= 0)
			{
				this.SelectLordDifficultyByIndex(num2);
				return;
			}
		}
		int num3 = 0;
		LordGymModel instance = LordGymModel.Instance;
		for (int i = 0; i < this.LordList.Count; i++)
		{
			int lordId = this.LordList[i];
			if (instance.GetLordGymIsUnLock(lordId) && instance.GetLastGymFinish(lordId) && i >= num3)
			{
				num3 = i;
			}
		}
		this.SelectLordDifficultyByIndex(num3);
	}

	// Token: 0x0600E074 RID: 57460 RVA: 0x0041DD18 File Offset: 0x0041BF18
	protected bool CanLordDifficultyToggleChange(int index)
	{
		return index != this.LordDifficultyScrollView.GetSelectedGridIndex();
	}

	// Token: 0x0600E075 RID: 57461 RVA: 0x0041DD2B File Offset: 0x0041BF2B
	protected void OnLordDifficultyToggleClick(int index)
	{
		if (!this.CanLordDifficultyToggleChange(index))
		{
			return;
		}
		this.SelectLordDifficultyByIndex(index);
	}

	// Token: 0x0600E076 RID: 57462 RVA: 0x0041DD3E File Offset: 0x0041BF3E
	public void SelectLordDifficultyByIndex(int index)
	{
		LoopScrollView<LordGymDifficultyItem, int> lordDifficultyScrollView = this.LordDifficultyScrollView;
		if (lordDifficultyScrollView != null)
		{
			lordDifficultyScrollView.SelectGridProxy(index, false);
		}
		this.SelectedLordId = this.LordList[index];
		this.RefreshDetail();
	}

	// Token: 0x0600E077 RID: 57463 RVA: 0x0041DD6C File Offset: 0x0041BF6C
	public virtual void RefreshDetail()
	{
		LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(this.SelectedLordId);
		if (lordGymConfig == null)
		{
			return;
		}
		LordGym value = lordGymConfig.Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "Text_InstanceDungeonRecommendLevel_Text", new <>z__ReadOnlySingleElementList<object>(value.MonsterLevel.ToString()));
		int rewardId = value.RewardId;
		List<TItem> exchangeRewardPreviewRewardList = ExchangeRewardConfig.Instance.GetExchangeRewardPreviewRewardList(rewardId, null);
		bool isPass = LordGymModel.Instance.GetLordGymIsFinish(this.SelectedLordId);
		this.RewardScrollView.RefreshByData(exchangeRewardPreviewRewardList, delegate
		{
			foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in this.RewardScrollView.GetScrollItemList())
			{
				commonItemSmallItemGrid.SetReceivedVisible(isPass);
			}
		}, false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), value.PlayDescription, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), value.NewGymTitle, Array.Empty<object>());
		LordGymPassRecord lordGymPassRecord;
		LordGymModel.Instance.LordGymRecord.TryGetValue(this.SelectedLordId, out lordGymPassRecord);
		if (lordGymPassRecord != null && lordGymPassRecord != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "BestPassTime", new <>z__ReadOnlySingleElementList<object>(TimeUtil.Instance.GetTimeString((double)lordGymPassRecord.PassTime)));
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "NoPassRecord", Array.Empty<object>());
		}
		bool flag = !LordGymModel.Instance.GetLordGymIsUnLock(this.SelectedLordId);
		bool lastGymFinish = LordGymModel.Instance.GetLastGymFinish(this.SelectedLordId);
		bool flag2 = (float)value.MonsterLevel > FormationModel.Instance.GetFormationAverageLevel();
		base.GetItem(12).SetUIActive(flag || !lastGymFinish);
		base.GetItem(9).SetUIActive(flag2 && !flag && lastGymFinish);
		UUIItem uuiitem = base.GetButton(10).RootUIComp.Get();
		if (uuiitem != null)
		{
			uuiitem.SetUIActive(!flag && lastGymFinish);
		}
		if (flag)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(13), value.LockDescription, Array.Empty<object>());
		}
		else if (!lastGymFinish)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(13), "LordGymLockTips", Array.Empty<object>());
		}
		else if (flag2)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(13), "LordGymLowLevel", Array.Empty<object>());
		}
		if (isPass)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "Text_ButtonTextChallengeOneMore_Text", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "Text_StartBattle_Text", Array.Empty<object>());
	}

	// Token: 0x040080BA RID: 32954
	[Nullable(2)]
	protected PopupCaptionItem CaptionItem;

	// Token: 0x040080BB RID: 32955
	protected int LordEntranceSetId;

	// Token: 0x040080BC RID: 32956
	protected int LordEntranceId;

	// Token: 0x040080BD RID: 32957
	[Nullable(2)]
	protected List<int> LordList;

	// Token: 0x040080BE RID: 32958
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected LoopScrollView<LordGymDifficultyItem, int> LordDifficultyScrollView;

	// Token: 0x040080BF RID: 32959
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x040080C0 RID: 32960
	protected int SelectedLordId;

	// Token: 0x02007858 RID: 30808
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x040270E3 RID: 159971
		public const int CaptionItem = 0;

		// Token: 0x040270E4 RID: 159972
		public const int DifficultyLoopScrollView = 1;

		// Token: 0x040270E5 RID: 159973
		public const int DifficultyLoopItem = 2;

		// Token: 0x040270E6 RID: 159974
		public const int LordNameText = 3;

		// Token: 0x040270E7 RID: 159975
		public const int LordLevelText = 4;

		// Token: 0x040270E8 RID: 159976
		public const int DetailText = 5;

		// Token: 0x040270E9 RID: 159977
		public const int RewardScrollView = 6;

		// Token: 0x040270EA RID: 159978
		public const int HistoryButton = 7;

		// Token: 0x040270EB RID: 159979
		public const int HistoryText = 8;

		// Token: 0x040270EC RID: 159980
		public const int WarningItem = 9;

		// Token: 0x040270ED RID: 159981
		public const int StartChallengeButton = 10;

		// Token: 0x040270EE RID: 159982
		public const int StartChallengeText = 11;

		// Token: 0x040270EF RID: 159983
		public const int LockItem = 12;

		// Token: 0x040270F0 RID: 159984
		public const int ConditionText = 13;

		// Token: 0x040270F1 RID: 159985
		public const int BackBtn = 14;
	}
}
