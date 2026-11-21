using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200062E RID: 1582
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerNormalLevelChoseView : UiViewBase
{
	// Token: 0x060049D4 RID: 18900 RVA: 0x00191610 File Offset: 0x0018F810
	public BabelTowerNormalLevelChoseView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060049D5 RID: 18901 RVA: 0x00191624 File Offset: 0x0018F824
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
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
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickQuestBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060049D6 RID: 18902 RVA: 0x001917D4 File Offset: 0x0018F9D4
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerNormalLevelChoseView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerNormalLevelChoseView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060049D7 RID: 18903 RVA: 0x00191818 File Offset: 0x0018FA18
	protected override void OnBeforeShow()
	{
		int levelChoseHandle = BabelTowerModel.Instance.LevelChoseHandle;
		if (levelChoseHandle != 0)
		{
			for (int i = 0; i < this.LevelList.Count; i++)
			{
				if (this.LevelList[i].LevelsId == levelChoseHandle)
				{
					LoopScrollView<BabelTowerNormalLevelChoseItem, BabelActivityLevelInfo> loopScrollView = this.LoopScrollView;
					if (loopScrollView != null)
					{
						loopScrollView.ScrollToGridIndex(i, true);
					}
					BabelTowerNormalLevelChoseItem item = this.LoopScrollView.UnsafeGetGridProxy(i, false);
					LoopScrollView<BabelTowerNormalLevelChoseItem, BabelActivityLevelInfo> loopScrollView2 = this.LoopScrollView;
					if (loopScrollView2 != null)
					{
						loopScrollView2.BindLateUpdate(delegate(float _)
						{
							if (item != null)
							{
								UiNavigationNewController.Instance.SetNavigationFocusForView(item.GetRootItem(), true, false, false);
								if (this.CurrentPlayLoopSeqItem != item)
								{
									BabelTowerNormalLevelChoseItem currentPlayLoopSeqItem = this.CurrentPlayLoopSeqItem;
									if (currentPlayLoopSeqItem != null)
									{
										currentPlayLoopSeqItem.StopLoopSequence();
									}
									item.PlayLoopSequence();
								}
								else if (this.CurrentPlayLoopSeqItem != null && !this.CurrentPlayLoopSeqItem.IsPlayingSequence())
								{
									this.CurrentPlayLoopSeqItem.PlayLoopSequence();
								}
								this.CurrentPlayLoopSeqItem = item;
							}
							LoopScrollView<BabelTowerNormalLevelChoseItem, BabelActivityLevelInfo> loopScrollView3 = this.LoopScrollView;
							if (loopScrollView3 == null)
							{
								return;
							}
							loopScrollView3.UnBindLateUpdate();
						});
					}
				}
			}
		}
	}

	// Token: 0x060049D8 RID: 18904 RVA: 0x001918B0 File Offset: 0x0018FAB0
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		RedDotController.Instance.BindRedDot(ERedDotName.BabelTowerQuestRedDot, base.GetItem(5), null, 0);
		this.RefreshView();
	}

	// Token: 0x060049D9 RID: 18905 RVA: 0x00191901 File Offset: 0x0018FB01
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerQuestRedDot, base.GetItem(5), 0);
	}

	// Token: 0x060049DA RID: 18906 RVA: 0x0019191C File Offset: 0x0018FB1C
	private void RefreshView()
	{
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		this.LevelList = new List<BabelActivityLevelInfo>();
		int num = 0;
		foreach (KeyValuePair<int, BabelActivityLevelInfo> keyValuePair in babelTowerData.NormalLevelDataMap)
		{
			this.LevelList.Add(keyValuePair.Value);
			if (keyValuePair.Value.IsFinished)
			{
				num++;
			}
		}
		LoopScrollView<BabelTowerNormalLevelChoseItem, BabelActivityLevelInfo> loopScrollView = this.LoopScrollView;
		if (loopScrollView != null)
		{
			loopScrollView.RefreshByData(this.LevelList, false, null, false);
		}
		base.GetText(1).SetText(num.ToString() + "/" + babelTowerData.NormalLevelDataMap.Count.ToString(), true);
		UUIInturnAnimController uuiinturnAnimController = base.GetLoopScrollViewComponent(8).Content.Get().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController;
		if (uuiinturnAnimController != null)
		{
			uuiinturnAnimController.Play("", -1, false);
		}
		this.RefreshQuestText();
	}

	// Token: 0x060049DB RID: 18907 RVA: 0x00191A34 File Offset: 0x0018FC34
	private void RefreshQuestText()
	{
		ValueTuple<int, int> normalQuestCount = BabelTowerController.Instance.GetBabelTowerData().GetNormalQuestCount();
		int item = normalQuestCount.Item1;
		int item2 = normalQuestCount.Item2;
		int value = item;
		int value2 = item2;
		UUIText text = base.GetText(6);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		UUIText text2 = base.GetText(7);
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x060049DC RID: 18908 RVA: 0x00191AB8 File Offset: 0x0018FCB8
	private void OnCloseBtnClick()
	{
		IBabelTowerNormalLevelChoseViewData data = this.Data;
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

	// Token: 0x060049DD RID: 18909 RVA: 0x00191B14 File Offset: 0x0018FD14
	private void OnClickQuestBtn()
	{
		if (!BabelTowerController.Instance.GetBabelTowerData().CheckIfInOpenTime())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BabelTowerIsNotOpen", Array.Empty<object>());
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.BabelTowerQuestView, null, null);
	}

	// Token: 0x060049DE RID: 18910 RVA: 0x00191B4D File Offset: 0x0018FD4D
	private void OnClickLoopItem(int levelId)
	{
		BabelTowerController.Instance.SaveNewLevelClickData(levelId, EBabelTowerDifficulty.Normal);
		UiManager.Instance.OpenView(EUiViewName.BabelTowerDeTermSelectViewNew, levelId, null);
	}

	// Token: 0x060049DF RID: 18911 RVA: 0x00191B71 File Offset: 0x0018FD71
	protected override void OnBeforeHide()
	{
		BabelTowerModel.Instance.LevelChoseHandle = 0;
	}

	// Token: 0x060049E0 RID: 18912 RVA: 0x00191B7E File Offset: 0x0018FD7E
	private BabelTowerNormalLevelChoseItem InitItem()
	{
		return new BabelTowerNormalLevelChoseItem
		{
			OnClickButtonCallBack = new Action<int>(this.OnClickLoopItem)
		};
	}

	// Token: 0x060049E1 RID: 18913 RVA: 0x00191B98 File Offset: 0x0018FD98
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
		LoopScrollView<BabelTowerNormalLevelChoseItem, BabelActivityLevelInfo> loopScrollView = this.LoopScrollView;
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

	// Token: 0x040036D2 RID: 14034
	[Nullable(2)]
	private IBabelTowerNormalLevelChoseViewData Data;

	// Token: 0x040036D3 RID: 14035
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040036D4 RID: 14036
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<BabelTowerNormalLevelChoseItem, BabelActivityLevelInfo> LoopScrollView;

	// Token: 0x040036D5 RID: 14037
	private List<BabelActivityLevelInfo> LevelList = new List<BabelActivityLevelInfo>();

	// Token: 0x040036D6 RID: 14038
	[Nullable(2)]
	private BabelTowerNormalLevelChoseItem CurrentPlayLoopSeqItem;

	// Token: 0x020068D8 RID: 26840
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040228E4 RID: 141540
		public const int CaptionItem = 0;

		// Token: 0x040228E5 RID: 141541
		public const int TargetText = 1;

		// Token: 0x040228E6 RID: 141542
		public const int ShopItem = 2;

		// Token: 0x040228E7 RID: 141543
		public const int ShopBtnRedDotItem = 3;

		// Token: 0x040228E8 RID: 141544
		public const int QuestBtn = 4;

		// Token: 0x040228E9 RID: 141545
		public const int QuestBtnRedDotItem = 5;

		// Token: 0x040228EA RID: 141546
		public const int QuestBtnText1 = 6;

		// Token: 0x040228EB RID: 141547
		public const int QuestBtnText2 = 7;

		// Token: 0x040228EC RID: 141548
		public const int LoopScrollView = 8;

		// Token: 0x040228ED RID: 141549
		public const int LoopScrollItem = 9;
	}
}
