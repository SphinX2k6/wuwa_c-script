using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000613 RID: 1555
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerHardLevelChoseView : UiViewBase
{
	// Token: 0x060048BE RID: 18622 RVA: 0x0018A4E8 File Offset: 0x001886E8
	public BabelTowerHardLevelChoseView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060048BF RID: 18623 RVA: 0x0018A4FC File Offset: 0x001886FC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickRankBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickQuestBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060048C0 RID: 18624 RVA: 0x0018A713 File Offset: 0x00188913
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.BabelTowerRefreshLevelInfo, new Action(this.BabelTowerRefreshLevelInfo));
	}

	// Token: 0x060048C1 RID: 18625 RVA: 0x0018A731 File Offset: 0x00188931
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.BabelTowerRefreshLevelInfo, new Action(this.BabelTowerRefreshLevelInfo));
	}

	// Token: 0x060048C2 RID: 18626 RVA: 0x0018A750 File Offset: 0x00188950
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerHardLevelChoseView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerHardLevelChoseView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060048C3 RID: 18627 RVA: 0x0018A793 File Offset: 0x00188993
	protected override void OnStart()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.BabelTowerQuestRedDot, base.GetItem(5), null, 0);
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.RefreshView();
	}

	// Token: 0x060048C4 RID: 18628 RVA: 0x0018A7C6 File Offset: 0x001889C6
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerQuestRedDot, base.GetItem(5), 0);
	}

	// Token: 0x060048C5 RID: 18629 RVA: 0x0018A7E0 File Offset: 0x001889E0
	protected override void OnBeforeShow()
	{
		int levelChoseHandle = BabelTowerModel.Instance.LevelChoseHandle;
		if (levelChoseHandle != 0)
		{
			for (int i = 0; i < this.LevelList.Count; i++)
			{
				if (this.LevelList[i].LevelsId == levelChoseHandle)
				{
					LoopScrollView<BabelTowerHardLevelChoseItem, BabelActivityLevelInfo> loopScrollView = this.LoopScrollView;
					if (loopScrollView != null)
					{
						loopScrollView.ScrollToGridIndex(i, true);
					}
					BabelTowerHardLevelChoseItem item = this.LoopScrollView.UnsafeGetGridProxy(i, false);
					LoopScrollView<BabelTowerHardLevelChoseItem, BabelActivityLevelInfo> loopScrollView2 = this.LoopScrollView;
					if (loopScrollView2 != null)
					{
						loopScrollView2.BindLateUpdate(delegate(float _)
						{
							if (item != null)
							{
								UiNavigationNewController.Instance.SetNavigationFocusForView(item.GetRootItem(), true, false, false);
								if (this.CurrentPlayLoopSeqItem != item)
								{
									BabelTowerHardLevelChoseItem currentPlayLoopSeqItem = this.CurrentPlayLoopSeqItem;
									if (currentPlayLoopSeqItem != null)
									{
										currentPlayLoopSeqItem.StopLoopSequence();
									}
									item.PlayLoopSequence();
								}
								else if (this.CurrentPlayLoopSeqItem != null && !this.CurrentPlayLoopSeqItem.IsPlayingSequence())
								{
									item.PlayLoopSequence();
								}
								this.CurrentPlayLoopSeqItem = item;
							}
							LoopScrollView<BabelTowerHardLevelChoseItem, BabelActivityLevelInfo> loopScrollView3 = this.LoopScrollView;
							if (loopScrollView3 == null)
							{
								return;
							}
							loopScrollView3.UnBindLateUpdate();
						});
					}
				}
			}
			return;
		}
		this.RefreshView();
	}

	// Token: 0x060048C6 RID: 18630 RVA: 0x0018A87C File Offset: 0x00188A7C
	private void RefreshView()
	{
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		this.LevelList = new List<BabelActivityLevelInfo>();
		foreach (KeyValuePair<int, BabelActivityLevelInfo> keyValuePair in babelTowerData.HardLevelDataMap)
		{
			this.LevelList.Add(keyValuePair.Value);
		}
		LoopScrollView<BabelTowerHardLevelChoseItem, BabelActivityLevelInfo> loopScrollView = this.LoopScrollView;
		if (loopScrollView != null)
		{
			loopScrollView.RefreshByData(this.LevelList, false, null, false);
		}
		base.GetArtText(1).SetText(babelTowerData.GetHardLevelStarText());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "BabelTower_paiming", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "BabelTowerTaskType_3", Array.Empty<object>());
		ValueTuple<int, int> normalQuestCount = babelTowerData.GetNormalQuestCount();
		int item = normalQuestCount.Item1;
		int item2 = normalQuestCount.Item2;
		UUIText text = base.GetText(6);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		UUIText text2 = base.GetText(7);
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(item);
		text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		UUIInturnAnimController uuiinturnAnimController = base.GetLoopScrollViewComponent(8).Content.Get().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController;
		if (uuiinturnAnimController == null)
		{
			return;
		}
		uuiinturnAnimController.Play("", -1, false);
	}

	// Token: 0x060048C7 RID: 18631 RVA: 0x0018A9F8 File Offset: 0x00188BF8
	private void OnCloseBtnClick()
	{
		IBabelTowerHardLevelChoseViewData data = this.Data;
		if (data != null && data.IfReturnToBabelTowerMainView)
		{
			BabelTowerMainViewData param = new BabelTowerMainViewData
			{
				IfLeaveInstanceDungeonWhenClose = this.Data.IfLeaveInstanceDungeonWhenMainViewClose
			};
			UiManager.Instance.OpenView(EUiViewName.BabelTowerMainView, param, delegate(bool _, int _)
			{
				base.CloseMe(null);
			});
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x060048C8 RID: 18632 RVA: 0x0018AA54 File Offset: 0x00188C54
	private void OnClickRankBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.BabelTowerRankView, null, null);
	}

	// Token: 0x060048C9 RID: 18633 RVA: 0x0018AA67 File Offset: 0x00188C67
	private void OnClickQuestBtn()
	{
		if (!BabelTowerController.Instance.GetBabelTowerData().CheckIfInOpenTime())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BabelTowerIsNotOpen", Array.Empty<object>());
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.BabelTowerQuestView, null, null);
	}

	// Token: 0x060048CA RID: 18634 RVA: 0x0018AAA0 File Offset: 0x00188CA0
	private void OnClickLoopItem(int levelId)
	{
		BabelTowerController.Instance.SaveNewLevelClickData(levelId, EBabelTowerDifficulty.Hard);
		UiManager.Instance.OpenView(EUiViewName.BabelTowerDeTermSelectViewNew, levelId, null);
	}

	// Token: 0x060048CB RID: 18635 RVA: 0x0018AAC4 File Offset: 0x00188CC4
	private BabelTowerHardLevelChoseItem InitItem()
	{
		return new BabelTowerHardLevelChoseItem
		{
			OnClickButtonCallBack = new Action<int>(this.OnClickLoopItem)
		};
	}

	// Token: 0x060048CC RID: 18636 RVA: 0x0018AADD File Offset: 0x00188CDD
	private void BabelTowerRefreshLevelInfo()
	{
		this.RefreshView();
	}

	// Token: 0x060048CD RID: 18637 RVA: 0x0018AAE5 File Offset: 0x00188CE5
	protected override void OnBeforeHide()
	{
		BabelTowerModel.Instance.LevelChoseHandle = 0;
	}

	// Token: 0x060048CE RID: 18638 RVA: 0x0018AAF4 File Offset: 0x00188CF4
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams == null || configParams.Length == 0)
		{
			return null;
		}
		if (!(configParams[0] == "FirstEntry"))
		{
			return null;
		}
		LoopScrollView<BabelTowerHardLevelChoseItem, BabelActivityLevelInfo> loopScrollView = this.LoopScrollView;
		UUIItem uuiitem = (loopScrollView != null) ? loopScrollView.GetGridByDisplayIndex(0) : null;
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x04003673 RID: 13939
	[Nullable(2)]
	private IBabelTowerHardLevelChoseViewData Data;

	// Token: 0x04003674 RID: 13940
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003675 RID: 13941
	private List<BabelActivityLevelInfo> LevelList = new List<BabelActivityLevelInfo>();

	// Token: 0x04003676 RID: 13942
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<BabelTowerHardLevelChoseItem, BabelActivityLevelInfo> LoopScrollView;

	// Token: 0x04003677 RID: 13943
	[Nullable(2)]
	private BabelTowerHardLevelChoseItem CurrentPlayLoopSeqItem;

	// Token: 0x020068B1 RID: 26801
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04022810 RID: 141328
		public const int CaptionItem = 0;

		// Token: 0x04022811 RID: 141329
		public const int TargetText = 1;

		// Token: 0x04022812 RID: 141330
		public const int RankBtn = 2;

		// Token: 0x04022813 RID: 141331
		public const int RankBtnRedDotItem = 3;

		// Token: 0x04022814 RID: 141332
		public const int QuestBtn = 4;

		// Token: 0x04022815 RID: 141333
		public const int QuestBtnRedDotItem = 5;

		// Token: 0x04022816 RID: 141334
		public const int QuestText1 = 6;

		// Token: 0x04022817 RID: 141335
		public const int QuestText2 = 7;

		// Token: 0x04022818 RID: 141336
		public const int LoopScrollView = 8;

		// Token: 0x04022819 RID: 141337
		public const int LoopScrollItem = 9;

		// Token: 0x0402281A RID: 141338
		public const int OneText = 10;

		// Token: 0x0402281B RID: 141339
		public const int TowText = 11;
	}
}
