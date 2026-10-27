using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001152 RID: 4434
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerDeTermSelectView : UiViewBase
{
	// Token: 0x06007462 RID: 29794 RVA: 0x0017C7AA File Offset: 0x0017A9AA
	public BabelTowerDeTermSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007463 RID: 29795 RVA: 0x0017C7C0 File Offset: 0x0017A9C0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 21;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(17, new Action(this.OnClickConfirmBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickClearBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.OnClickQuestBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickLevelDetailBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007464 RID: 29796 RVA: 0x0017CB54 File Offset: 0x0017AD54
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerDeTermSelectView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerDeTermSelectView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007465 RID: 29797 RVA: 0x0017CB98 File Offset: 0x0017AD98
	protected override void OnStart()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.BabelTowerQuestRedDot, base.GetItem(20), null, 0);
		this.LevelId = (int)(this.OpenParam ?? 0);
		base.GetText(9).SetUIActive(false);
		BabelTowerModel.Instance.DeTermSelectInfo.Clear();
		BabelTowerModel.Instance.DeTermSelectIndex = 0;
		this.InitDeTermScrollView();
		UUIInturnAnimController uuiinturnAnimController = base.GetScrollViewWithScrollbar(2).Content.Get().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController;
		if (uuiinturnAnimController != null)
		{
			uuiinturnAnimController.Play("", -1, false);
		}
		UUIInturnAnimController uuiinturnAnimController2 = base.GetScrollViewWithScrollbar(5).Content.Get().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController;
		if (uuiinturnAnimController2 != null)
		{
			uuiinturnAnimController2.Play("", -1, false);
		}
		BabelTowerModel.Instance.CurrentSelectLevel = this.LevelId;
	}

	// Token: 0x06007466 RID: 29798 RVA: 0x0017CC8B File Offset: 0x0017AE8B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.BabelTowerRefreshLevelInfo, new Action(this.BabelTowerRefreshLevelInfo));
	}

	// Token: 0x06007467 RID: 29799 RVA: 0x0017CCA9 File Offset: 0x0017AEA9
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.BabelTowerRefreshLevelInfo, new Action(this.BabelTowerRefreshLevelInfo));
	}

	// Token: 0x06007468 RID: 29800 RVA: 0x0017CCC7 File Offset: 0x0017AEC7
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x06007469 RID: 29801 RVA: 0x0017CCCF File Offset: 0x0017AECF
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerQuestRedDot, base.GetItem(20), 0);
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0600746A RID: 29802 RVA: 0x0017CD04 File Offset: 0x0017AF04
	private void RefreshView()
	{
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(this.LevelId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), babelTowerLevelConfig.NameText, Array.Empty<object>());
		base.GetItem(19).SetUIActive(babelTowerLevelConfig.IsDifficult);
		if (babelTowerLevelConfig.IsDifficult)
		{
			BabelActivityLevelInfo babelActivityLevelInfo;
			int num = BabelTowerController.Instance.GetBabelTowerData().HardLevelDataMap.TryGetValue(this.LevelId, out babelActivityLevelInfo) ? babelActivityLevelInfo.PassStar : 0;
			base.GetText(10).SetText(num.ToString() ?? "", true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(18), "BabelTowerHardStar", Array.Empty<object>());
			return;
		}
		base.GetText(10).SetText(babelTowerLevelConfig.PassStar.ToString() ?? "", true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(18), "BabelTowerNormalStar", Array.Empty<object>());
	}

	// Token: 0x0600746B RID: 29803 RVA: 0x0017CE04 File Offset: 0x0017B004
	private void InitDeTermScrollView()
	{
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(this.LevelId);
		this.DeTermScrollViewDataList.Clear();
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		List<int> dailyDeTerm = babelTowerData.GetDailyLevel().Contains(this.LevelId) ? babelTowerData.GetDailyDeTerm() : new List<int>();
		if (babelTowerLevelConfig.FixBabelDeTermdsLength > 0)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < babelTowerLevelConfig.FixBabelDeTermdsLength; i++)
			{
				int num = babelTowerLevelConfig.FixBabelDeTermds(i);
				BabelTowerDeTerm babelTowerDeTerm = BabelTowerConfig.Instance.GetBabelTowerDeTerm(num);
				int j = 1;
				while (babelTowerDeTerm.Star > j)
				{
					list.Add(0);
					j++;
				}
				list.Add(num);
				for (j++; j <= 3; j++)
				{
					list.Add(0);
				}
				BabelTowerSelectInfo babelTowerSelectInfo = new BabelTowerSelectInfo();
				babelTowerSelectInfo.State = EBabelTowerDeTermState.StaticSelect;
				BabelTowerModel instance = BabelTowerModel.Instance;
				int deTermSelectIndex = instance.DeTermSelectIndex;
				instance.DeTermSelectIndex = deTermSelectIndex + 1;
				babelTowerSelectInfo.SelectIndex = deTermSelectIndex;
				BabelTowerSelectInfo value = babelTowerSelectInfo;
				BabelTowerModel.Instance.DeTermSelectInfo[num] = value;
			}
			BabelTowerDeTermSelectItemInfo item = new BabelTowerDeTermSelectItemInfo
			{
				IsNecessary = true,
				AllDeTerm = list,
				DailyDeTerm = dailyDeTerm,
				OnChangeSelectDeTerm = new Action<int>(this.OnChangeDeTerm)
			};
			this.DeTermScrollViewDataList.Add(item);
		}
		List<int> list2 = new List<int>();
		for (int k = 0; k < babelTowerLevelConfig.BabelTowerDeTermMutexArrayLength; k++)
		{
			int id = babelTowerLevelConfig.BabelTowerDeTermMutexArray(k);
			list2 = new List<int>();
			BabelTowerDeTermMutex babelTowerDeTermMutual = BabelTowerConfig.Instance.GetBabelTowerDeTermMutual(id);
			for (int l = 0; l < babelTowerDeTermMutual.MutexDeTermGroupLength; l++)
			{
				int groupId = babelTowerDeTermMutual.MutexDeTermGroup(l);
				list2.AddRange(this.GetDeTermListByGroupId(groupId));
			}
			BabelTowerDeTermSelectItemInfo item2 = new BabelTowerDeTermSelectItemInfo
			{
				IsNecessary = false,
				AllDeTerm = list2,
				DailyDeTerm = dailyDeTerm,
				OnChangeSelectDeTerm = new Action<int>(this.OnChangeDeTerm)
			};
			this.DeTermScrollViewDataList.Add(item2);
		}
		GenericScrollViewNew<BabelTowerDeTermSelectItem, IBabelTowerDeTermSelectItemInfo> deTermScrollView = this.DeTermScrollView;
		if (deTermScrollView != null)
		{
			deTermScrollView.RefreshByData(this.DeTermScrollViewDataList, null, false);
		}
		this.RefreshDesScrollView(null);
	}

	// Token: 0x0600746C RID: 29804 RVA: 0x0017D038 File Offset: 0x0017B238
	private List<int> GetDeTermListByGroupId(int groupId)
	{
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		List<int> list = new List<int>();
		List<BabelTowerDeTerm> list2 = new List<BabelTowerDeTerm>(BabelTowerConfig.Instance.GetBabelTowerDeTermByGroupId(groupId));
		list2.Sort(delegate(BabelTowerDeTerm a, BabelTowerDeTerm b)
		{
			if (a.Line != b.Line)
			{
				return a.Line - b.Line;
			}
			return a.Star - b.Star;
		});
		int num = 1;
		int num2 = 1;
		using (List<BabelTowerDeTerm>.Enumerator enumerator = list2.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				BabelTowerDeTerm babelTowerDeTerm = enumerator.Current;
				if (num2 != babelTowerDeTerm.Line)
				{
					num2 = babelTowerDeTerm.Line;
					num = 1;
				}
				while (babelTowerDeTerm.Star > num)
				{
					list.Add(0);
					num++;
				}
				list.Add(babelTowerDeTerm.Id);
				if (babelTowerData.GetDeTermIsLock(babelTowerDeTerm.Id))
				{
					BabelTowerSelectInfo babelTowerSelectInfo = new BabelTowerSelectInfo();
					babelTowerSelectInfo.State = EBabelTowerDeTermState.Lock;
					BabelTowerModel instance = BabelTowerModel.Instance;
					int deTermSelectIndex = instance.DeTermSelectIndex;
					instance.DeTermSelectIndex = deTermSelectIndex + 1;
					babelTowerSelectInfo.SelectIndex = deTermSelectIndex;
					BabelTowerSelectInfo value = babelTowerSelectInfo;
					BabelTowerModel.Instance.DeTermSelectInfo[babelTowerDeTerm.Id] = value;
				}
				else if (babelTowerData.GetDeTermIsUse(this.LevelId, babelTowerDeTerm.Id))
				{
					BabelTowerSelectInfo babelTowerSelectInfo2 = new BabelTowerSelectInfo();
					babelTowerSelectInfo2.State = EBabelTowerDeTermState.Select;
					BabelTowerModel instance2 = BabelTowerModel.Instance;
					int deTermSelectIndex = instance2.DeTermSelectIndex;
					instance2.DeTermSelectIndex = deTermSelectIndex + 1;
					babelTowerSelectInfo2.SelectIndex = deTermSelectIndex;
					BabelTowerSelectInfo value2 = babelTowerSelectInfo2;
					BabelTowerModel.Instance.DeTermSelectInfo[babelTowerDeTerm.Id] = value2;
				}
				else
				{
					BabelTowerSelectInfo babelTowerSelectInfo3 = new BabelTowerSelectInfo();
					babelTowerSelectInfo3.State = EBabelTowerDeTermState.Select;
					BabelTowerModel instance3 = BabelTowerModel.Instance;
					int deTermSelectIndex = instance3.DeTermSelectIndex;
					instance3.DeTermSelectIndex = deTermSelectIndex + 1;
					babelTowerSelectInfo3.SelectIndex = deTermSelectIndex;
					BabelTowerSelectInfo value3 = babelTowerSelectInfo3;
					BabelTowerModel.Instance.DeTermSelectInfo[babelTowerDeTerm.Id] = value3;
				}
				num++;
			}
			goto IL_1B9;
		}
		IL_1AE:
		list.Add(0);
		num++;
		IL_1B9:
		if (num > 3)
		{
			return list;
		}
		goto IL_1AE;
	}

	// Token: 0x0600746D RID: 29805 RVA: 0x0017D220 File Offset: 0x0017B420
	private void OnClickConfirmBtn()
	{
		List<int> selectDeTermList = new List<int>();
		Dictionary<int, IBabelTowerSelectInfo> deTermSelectInfo = BabelTowerModel.Instance.DeTermSelectInfo;
		int currentStar = 0;
		foreach (KeyValuePair<int, IBabelTowerSelectInfo> keyValuePair in deTermSelectInfo)
		{
			if (keyValuePair.Value.State == EBabelTowerDeTermState.Select)
			{
				selectDeTermList.Add(keyValuePair.Key);
			}
			if (keyValuePair.Value.State == EBabelTowerDeTermState.Select || keyValuePair.Value.State == EBabelTowerDeTermState.StaticSelect)
			{
				BabelTowerDeTerm babelTowerDeTerm = BabelTowerConfig.Instance.GetBabelTowerDeTerm(keyValuePair.Key);
				currentStar += babelTowerDeTerm.Star;
			}
		}
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(this.LevelId);
		if (currentStar >= babelTowerLevelConfig.PassStar)
		{
			this.RequestDeTermChose(selectDeTermList, currentStar).Forget();
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BabelTowerLowStarConfirm);
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			this.RequestDeTermChose(selectDeTermList, currentStar).Forget();
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600746E RID: 29806 RVA: 0x0017D364 File Offset: 0x0017B564
	private UniTask RequestDeTermChose(List<int> selectDeTermList, int currentStar)
	{
		BabelTowerDeTermSelectView.<RequestDeTermChose>d__20 <RequestDeTermChose>d__;
		<RequestDeTermChose>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestDeTermChose>d__.<>4__this = this;
		<RequestDeTermChose>d__.selectDeTermList = selectDeTermList;
		<RequestDeTermChose>d__.currentStar = currentStar;
		<RequestDeTermChose>d__.<>1__state = -1;
		<RequestDeTermChose>d__.<>t__builder.Start<BabelTowerDeTermSelectView.<RequestDeTermChose>d__20>(ref <RequestDeTermChose>d__);
		return <RequestDeTermChose>d__.<>t__builder.Task;
	}

	// Token: 0x0600746F RID: 29807 RVA: 0x0017D3B7 File Offset: 0x0017B5B7
	private void OnClickQuestBtn()
	{
		if (!BabelTowerController.Instance.GetBabelTowerData().CheckIfInOpenTime())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BabelTowerIsNotOpen", Array.Empty<object>());
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.BabelTowerQuestView, null, null);
	}

	// Token: 0x06007470 RID: 29808 RVA: 0x0017D3F0 File Offset: 0x0017B5F0
	private void OnClickLevelDetailBtn()
	{
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(this.LevelId);
		UiManager.Instance.OpenView(EUiViewName.InstanceDungeonMonsterPreView, babelTowerLevelConfig.InstId, null);
	}

	// Token: 0x06007471 RID: 29809 RVA: 0x0017D42C File Offset: 0x0017B62C
	private void OnClickClearBtn()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BabelTowerClearDeTerm);
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			BabelTowerController.Instance.SelectBabelActivityDeTermRequest(this.LevelId, new List<int>()).Forget<bool>();
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06007472 RID: 29810 RVA: 0x0017D468 File Offset: 0x0017B668
	private BabelTowerDeTermSelectItem InitDeTermItem()
	{
		return new BabelTowerDeTermSelectItem();
	}

	// Token: 0x06007473 RID: 29811 RVA: 0x0017D46F File Offset: 0x0017B66F
	private BabelTowerDeTermSelectDesItem InitDesItem()
	{
		return new BabelTowerDeTermSelectDesItem
		{
			OnClickCallBack = new Action<int>(this.OnClickDesBtn)
		};
	}

	// Token: 0x06007474 RID: 29812 RVA: 0x0017D488 File Offset: 0x0017B688
	private void OnChangeDeTerm(int deTerm)
	{
		this.RefreshDesScrollView(new int?(deTerm));
	}

	// Token: 0x06007475 RID: 29813 RVA: 0x0017D498 File Offset: 0x0017B698
	private void RefreshDesScrollView(int? deTerm = null)
	{
		List<int> list = new List<int>();
		Dictionary<int, IBabelTowerSelectInfo> map = BabelTowerModel.Instance.DeTermSelectInfo;
		int num = 0;
		foreach (KeyValuePair<int, IBabelTowerSelectInfo> keyValuePair in map)
		{
			if (keyValuePair.Key != 0 && (keyValuePair.Value.State == EBabelTowerDeTermState.Select || keyValuePair.Value.State == EBabelTowerDeTermState.StaticSelect))
			{
				list.Add(keyValuePair.Key);
				BabelTowerDeTerm babelTowerDeTerm = BabelTowerConfig.Instance.GetBabelTowerDeTerm(keyValuePair.Key);
				num += babelTowerDeTerm.Star;
			}
		}
		list.Sort((int a, int b) => map[b].SelectIndex - map[a].SelectIndex);
		GenericScrollViewNew<BabelTowerDeTermSelectDesItem, int> desScrollView = this.DesScrollView;
		if (desScrollView != null)
		{
			desScrollView.RefreshByData(list, delegate
			{
				if (deTerm == null)
				{
					return;
				}
				foreach (BabelTowerDeTermSelectDesItem babelTowerDeTermSelectDesItem in this.DesScrollView.GetScrollItemList())
				{
					int deTermId = babelTowerDeTermSelectDesItem.DeTermId;
					int? deTerm2 = deTerm;
					if (deTermId == deTerm2.GetValueOrDefault() & deTerm2 != null)
					{
						GenericScrollViewNew<BabelTowerDeTermSelectDesItem, int> desScrollView2 = this.DesScrollView;
						if (desScrollView2 != null)
						{
							desScrollView2.LateScrollTo(babelTowerDeTermSelectDesItem.GetRootItem(), null, false);
						}
						babelTowerDeTermSelectDesItem.PlayChoseSequence();
					}
				}
			}, false);
		}
		base.GetArtText(13).SetText(((num < 10) ? "0" : "") + num.ToString());
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(this.LevelId);
		bool uiactive = num < babelTowerLevelConfig.PassStar;
		base.GetItem(11).SetUIActive(uiactive);
		base.GetItem(7).SetUIActive(list.Count <= 0);
		BabelTowerDifficulty? babelTowerDifficulty = BabelTowerModel.Instance.CalculateDifficultyConfigByStarNum(babelTowerLevelConfig.ActivityId, num);
		if (babelTowerDifficulty == null)
		{
			return;
		}
		if (this.LastDiff < 2 && babelTowerDifficulty.Value.DifficultyId >= 2)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely("Highest", false, false, null, null, false);
			}
		}
		else if (this.LastDiff >= 2 && babelTowerDifficulty.Value.DifficultyId < 2)
		{
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlaySequencePurely("HighestClose", false, false, null, null, false);
			}
		}
		this.LastDiff = babelTowerDifficulty.Value.DifficultyId;
		FColor color = FColor.FromHex(babelTowerDifficulty.Value.TextBgColor);
		base.GetItem(14).SetColor(color);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(15), babelTowerDifficulty.Value.DifficultyTextKey, Array.Empty<object>());
	}

	// Token: 0x06007476 RID: 29814 RVA: 0x0017D708 File Offset: 0x0017B908
	private void OnClickDesBtn(int deTerm)
	{
		for (int i = 0; i < this.DeTermScrollViewDataList.Count; i++)
		{
			if (this.DeTermScrollViewDataList[i].AllDeTerm.Contains(deTerm))
			{
				UUIItem itemByIndex = this.DeTermScrollView.GetItemByIndex(i);
				this.DeTermScrollView.ScrollTo(itemByIndex, false);
				BabelTowerDeTermSelectItem scrollItemByIndex = this.DeTermScrollView.GetScrollItemByIndex(i);
				if (scrollItemByIndex != null)
				{
					scrollItemByIndex.PlayPositionSequence(deTerm);
				}
			}
		}
	}

	// Token: 0x06007477 RID: 29815 RVA: 0x0017D778 File Offset: 0x0017B978
	private void BabelTowerRefreshLevelInfo()
	{
		foreach (BabelTowerDeTermSelectItem babelTowerDeTermSelectItem in this.DeTermScrollView.GetScrollItemList())
		{
			babelTowerDeTermSelectItem.ClearSelect();
		}
		this.InitDeTermScrollView();
	}

	// Token: 0x04003598 RID: 13720
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003599 RID: 13721
	private int LevelId;

	// Token: 0x0400359A RID: 13722
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<BabelTowerDeTermSelectItem, IBabelTowerDeTermSelectItemInfo> DeTermScrollView;

	// Token: 0x0400359B RID: 13723
	private List<IBabelTowerDeTermSelectItemInfo> DeTermScrollViewDataList = new List<IBabelTowerDeTermSelectItemInfo>();

	// Token: 0x0400359C RID: 13724
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<BabelTowerDeTermSelectDesItem, int> DesScrollView;

	// Token: 0x0400359D RID: 13725
	private int LastDiff;

	// Token: 0x0400359E RID: 13726
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007705 RID: 30469
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04027433 RID: 160819
		public const int CaptionItem = 0;

		// Token: 0x04027434 RID: 160820
		public const int LevelDetailBtn = 1;

		// Token: 0x04027435 RID: 160821
		public const int DeTermScrollView = 2;

		// Token: 0x04027436 RID: 160822
		public const int DeTermScrollItem = 3;

		// Token: 0x04027437 RID: 160823
		public const int ClearBtn = 4;

		// Token: 0x04027438 RID: 160824
		public const int DesScrollView = 5;

		// Token: 0x04027439 RID: 160825
		public const int DesScrollItem = 6;

		// Token: 0x0402743A RID: 160826
		public const int DesNoneItem = 7;

		// Token: 0x0402743B RID: 160827
		public const int NameText = 8;

		// Token: 0x0402743C RID: 160828
		public const int DesText = 9;

		// Token: 0x0402743D RID: 160829
		public const int TargetStarText = 10;

		// Token: 0x0402743E RID: 160830
		public const int LowStarItem = 11;

		// Token: 0x0402743F RID: 160831
		public const int LowStarText = 12;

		// Token: 0x04027440 RID: 160832
		public const int CurrentStarText = 13;

		// Token: 0x04027441 RID: 160833
		public const int HardItem = 14;

		// Token: 0x04027442 RID: 160834
		public const int HardText = 15;

		// Token: 0x04027443 RID: 160835
		public const int QuestBtn = 16;

		// Token: 0x04027444 RID: 160836
		public const int ConfirmBtn = 17;

		// Token: 0x04027445 RID: 160837
		public const int TargetDesText = 18;

		// Token: 0x04027446 RID: 160838
		public const int DifficultyEffectItem = 19;

		// Token: 0x04027447 RID: 160839
		public const int QuestBtnRedDotItem = 20;
	}
}
