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

// Token: 0x020021A2 RID: 8610
[NullableContext(1)]
[Nullable(0)]
public class LordGymDifficultySelectView : UiViewBase
{
	// Token: 0x06010BD5 RID: 68565 RVA: 0x00410FEE File Offset: 0x0040F1EE
	public LordGymDifficultySelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010BD6 RID: 68566 RVA: 0x00410FF8 File Offset: 0x0040F1F8
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

	// Token: 0x06010BD7 RID: 68567 RVA: 0x004111B8 File Offset: 0x0040F3B8
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymDifficultySelectView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymDifficultySelectView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010BD8 RID: 68568 RVA: 0x004111FB File Offset: 0x0040F3FB
	protected override void OnHandleLoadScene()
	{
		UiSceneManager.Instance.InitLordSkeletalHandle();
		LordGymController.Instance.CreateLordModelByEntranceId();
		LordGymController.Instance.LoadLordModelByEntranceId(this.LordEntranceId, true, false).Forget();
	}

	// Token: 0x06010BD9 RID: 68569 RVA: 0x00411228 File Offset: 0x0040F428
	protected override void OnHandleReleaseScene()
	{
		UiSceneManager.Instance.DestroyLordSkeletalHandle();
	}

	// Token: 0x06010BDA RID: 68570 RVA: 0x00411234 File Offset: 0x0040F434
	protected virtual void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06010BDB RID: 68571 RVA: 0x00411240 File Offset: 0x0040F440
	private void OnHelpBtnClick()
	{
		int helpId = ConfigLordGymEntranceSetById.GetConfig(this.LordEntranceSetId, true).Value.HelpId;
		HelpController.Instance.OpenHelpById(helpId);
	}

	// Token: 0x06010BDC RID: 68572 RVA: 0x00411275 File Offset: 0x0040F475
	private LordGymDifficultyItem CreateDifficultyLoopItem()
	{
		return this.CreateItem();
	}

	// Token: 0x06010BDD RID: 68573 RVA: 0x0041127D File Offset: 0x0040F47D
	protected virtual LordGymDifficultyItem CreateItem()
	{
		return new LordGymDifficultyItem
		{
			OnToggleClick = new Action<int>(this.OnLordDifficultyToggleClick),
			CanExecuteChangeCallBack = new Func<int, bool>(this.CanLordDifficultyToggleChange)
		};
	}

	// Token: 0x06010BDE RID: 68574 RVA: 0x004112A8 File Offset: 0x0040F4A8
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06010BDF RID: 68575 RVA: 0x004112AF File Offset: 0x0040F4AF
	private void OnStartChallengeButtonClick()
	{
		this.OnStartChallenge();
	}

	// Token: 0x06010BE0 RID: 68576 RVA: 0x004112B8 File Offset: 0x0040F4B8
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

	// Token: 0x06010BE1 RID: 68577 RVA: 0x00411320 File Offset: 0x0040F520
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

	// Token: 0x06010BE2 RID: 68578 RVA: 0x00411384 File Offset: 0x0040F584
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

	// Token: 0x06010BE3 RID: 68579 RVA: 0x00411430 File Offset: 0x0040F630
	protected bool CanLordDifficultyToggleChange(int index)
	{
		return index != this.LordDifficultyScrollView.GetSelectedGridIndex();
	}

	// Token: 0x06010BE4 RID: 68580 RVA: 0x00411443 File Offset: 0x0040F643
	protected void OnLordDifficultyToggleClick(int index)
	{
		if (!this.CanLordDifficultyToggleChange(index))
		{
			return;
		}
		this.SelectLordDifficultyByIndex(index);
	}

	// Token: 0x06010BE5 RID: 68581 RVA: 0x00411456 File Offset: 0x0040F656
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

	// Token: 0x06010BE6 RID: 68582 RVA: 0x00411484 File Offset: 0x0040F684
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

	// Token: 0x04007F73 RID: 32627
	[Nullable(2)]
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04007F74 RID: 32628
	protected int LordEntranceSetId;

	// Token: 0x04007F75 RID: 32629
	protected int LordEntranceId;

	// Token: 0x04007F76 RID: 32630
	[Nullable(2)]
	protected List<int> LordList;

	// Token: 0x04007F77 RID: 32631
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected LoopScrollView<LordGymDifficultyItem, int> LordDifficultyScrollView;

	// Token: 0x04007F78 RID: 32632
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x04007F79 RID: 32633
	protected int SelectedLordId;

	// Token: 0x020086CD RID: 34509
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402BDC2 RID: 179650
		public const int CaptionItem = 0;

		// Token: 0x0402BDC3 RID: 179651
		public const int DifficultyLoopScrollView = 1;

		// Token: 0x0402BDC4 RID: 179652
		public const int DifficultyLoopItem = 2;

		// Token: 0x0402BDC5 RID: 179653
		public const int LordNameText = 3;

		// Token: 0x0402BDC6 RID: 179654
		public const int LordLevelText = 4;

		// Token: 0x0402BDC7 RID: 179655
		public const int DetailText = 5;

		// Token: 0x0402BDC8 RID: 179656
		public const int RewardScrollView = 6;

		// Token: 0x0402BDC9 RID: 179657
		public const int HistoryButton = 7;

		// Token: 0x0402BDCA RID: 179658
		public const int HistoryText = 8;

		// Token: 0x0402BDCB RID: 179659
		public const int WarningItem = 9;

		// Token: 0x0402BDCC RID: 179660
		public const int StartChallengeButton = 10;

		// Token: 0x0402BDCD RID: 179661
		public const int StartChallengeText = 11;

		// Token: 0x0402BDCE RID: 179662
		public const int LockItem = 12;

		// Token: 0x0402BDCF RID: 179663
		public const int ConditionText = 13;

		// Token: 0x0402BDD0 RID: 179664
		public const int BackBtn = 14;
	}
}
