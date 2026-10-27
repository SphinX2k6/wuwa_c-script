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

// Token: 0x0200115F RID: 4447
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerHardLevelChoseView : UiViewBase
{
	// Token: 0x06007527 RID: 29991 RVA: 0x001819B8 File Offset: 0x0017FBB8
	public BabelTowerHardLevelChoseView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007528 RID: 29992 RVA: 0x001819CC File Offset: 0x0017FBCC
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

	// Token: 0x06007529 RID: 29993 RVA: 0x00181BE3 File Offset: 0x0017FDE3
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.BabelTowerRefreshLevelInfo, new Action(this.BabelTowerRefreshLevelInfo));
	}

	// Token: 0x0600752A RID: 29994 RVA: 0x00181C01 File Offset: 0x0017FE01
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.BabelTowerRefreshLevelInfo, new Action(this.BabelTowerRefreshLevelInfo));
	}

	// Token: 0x0600752B RID: 29995 RVA: 0x00181C20 File Offset: 0x0017FE20
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerHardLevelChoseView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerHardLevelChoseView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600752C RID: 29996 RVA: 0x00181C63 File Offset: 0x0017FE63
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

	// Token: 0x0600752D RID: 29997 RVA: 0x00181C96 File Offset: 0x0017FE96
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerQuestRedDot, base.GetItem(5), 0);
	}

	// Token: 0x0600752E RID: 29998 RVA: 0x00181CB0 File Offset: 0x0017FEB0
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

	// Token: 0x0600752F RID: 29999 RVA: 0x00181D4C File Offset: 0x0017FF4C
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

	// Token: 0x06007530 RID: 30000 RVA: 0x00181EC8 File Offset: 0x001800C8
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

	// Token: 0x06007531 RID: 30001 RVA: 0x00181F24 File Offset: 0x00180124
	private void OnClickRankBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.BabelTowerRankView, null, null);
	}

	// Token: 0x06007532 RID: 30002 RVA: 0x00181F37 File Offset: 0x00180137
	private void OnClickQuestBtn()
	{
		if (!BabelTowerController.Instance.GetBabelTowerData().CheckIfInOpenTime())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BabelTowerIsNotOpen", Array.Empty<object>());
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.BabelTowerQuestView, null, null);
	}

	// Token: 0x06007533 RID: 30003 RVA: 0x00181F70 File Offset: 0x00180170
	private void OnClickLoopItem(int levelId)
	{
		BabelTowerController.Instance.SaveNewLevelClickData(levelId, EBabelTowerDifficulty.Hard);
		UiManager.Instance.OpenView(EUiViewName.BabelTowerDeTermSelectViewNew, levelId, null);
	}

	// Token: 0x06007534 RID: 30004 RVA: 0x00181F94 File Offset: 0x00180194
	private BabelTowerHardLevelChoseItem InitItem()
	{
		return new BabelTowerHardLevelChoseItem
		{
			OnClickButtonCallBack = new Action<int>(this.OnClickLoopItem)
		};
	}

	// Token: 0x06007535 RID: 30005 RVA: 0x00181FAD File Offset: 0x001801AD
	private void BabelTowerRefreshLevelInfo()
	{
		this.RefreshView();
	}

	// Token: 0x06007536 RID: 30006 RVA: 0x00181FB5 File Offset: 0x001801B5
	protected override void OnBeforeHide()
	{
		BabelTowerModel.Instance.LevelChoseHandle = 0;
	}

	// Token: 0x06007537 RID: 30007 RVA: 0x00181FC4 File Offset: 0x001801C4
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

	// Token: 0x040035DA RID: 13786
	[Nullable(2)]
	private IBabelTowerHardLevelChoseViewData Data;

	// Token: 0x040035DB RID: 13787
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040035DC RID: 13788
	private List<BabelActivityLevelInfo> LevelList = new List<BabelActivityLevelInfo>();

	// Token: 0x040035DD RID: 13789
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<BabelTowerHardLevelChoseItem, BabelActivityLevelInfo> LoopScrollView;

	// Token: 0x040035DE RID: 13790
	[Nullable(2)]
	private BabelTowerHardLevelChoseItem CurrentPlayLoopSeqItem;

	// Token: 0x02007723 RID: 30499
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040274D1 RID: 160977
		public const int CaptionItem = 0;

		// Token: 0x040274D2 RID: 160978
		public const int TargetText = 1;

		// Token: 0x040274D3 RID: 160979
		public const int RankBtn = 2;

		// Token: 0x040274D4 RID: 160980
		public const int RankBtnRedDotItem = 3;

		// Token: 0x040274D5 RID: 160981
		public const int QuestBtn = 4;

		// Token: 0x040274D6 RID: 160982
		public const int QuestBtnRedDotItem = 5;

		// Token: 0x040274D7 RID: 160983
		public const int QuestText1 = 6;

		// Token: 0x040274D8 RID: 160984
		public const int QuestText2 = 7;

		// Token: 0x040274D9 RID: 160985
		public const int LoopScrollView = 8;

		// Token: 0x040274DA RID: 160986
		public const int LoopScrollItem = 9;

		// Token: 0x040274DB RID: 160987
		public const int OneText = 10;

		// Token: 0x040274DC RID: 160988
		public const int TowText = 11;
	}
}
