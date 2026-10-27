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

// Token: 0x0200117A RID: 4474
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerNormalLevelChoseView : UiViewBase
{
	// Token: 0x0600763D RID: 30269 RVA: 0x00188A60 File Offset: 0x00186C60
	public BabelTowerNormalLevelChoseView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600763E RID: 30270 RVA: 0x00188A74 File Offset: 0x00186C74
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

	// Token: 0x0600763F RID: 30271 RVA: 0x00188C24 File Offset: 0x00186E24
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerNormalLevelChoseView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerNormalLevelChoseView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007640 RID: 30272 RVA: 0x00188C68 File Offset: 0x00186E68
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

	// Token: 0x06007641 RID: 30273 RVA: 0x00188D00 File Offset: 0x00186F00
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

	// Token: 0x06007642 RID: 30274 RVA: 0x00188D51 File Offset: 0x00186F51
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerQuestRedDot, base.GetItem(5), 0);
	}

	// Token: 0x06007643 RID: 30275 RVA: 0x00188D6C File Offset: 0x00186F6C
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

	// Token: 0x06007644 RID: 30276 RVA: 0x00188E84 File Offset: 0x00187084
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

	// Token: 0x06007645 RID: 30277 RVA: 0x00188F08 File Offset: 0x00187108
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

	// Token: 0x06007646 RID: 30278 RVA: 0x00188F64 File Offset: 0x00187164
	private void OnClickQuestBtn()
	{
		if (!BabelTowerController.Instance.GetBabelTowerData().CheckIfInOpenTime())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BabelTowerIsNotOpen", Array.Empty<object>());
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.BabelTowerQuestView, null, null);
	}

	// Token: 0x06007647 RID: 30279 RVA: 0x00188F9D File Offset: 0x0018719D
	private void OnClickLoopItem(int levelId)
	{
		BabelTowerController.Instance.SaveNewLevelClickData(levelId, EBabelTowerDifficulty.Normal);
		UiManager.Instance.OpenView(EUiViewName.BabelTowerDeTermSelectViewNew, levelId, null);
	}

	// Token: 0x06007648 RID: 30280 RVA: 0x00188FC1 File Offset: 0x001871C1
	protected override void OnBeforeHide()
	{
		BabelTowerModel.Instance.LevelChoseHandle = 0;
	}

	// Token: 0x06007649 RID: 30281 RVA: 0x00188FCE File Offset: 0x001871CE
	private BabelTowerNormalLevelChoseItem InitItem()
	{
		return new BabelTowerNormalLevelChoseItem
		{
			OnClickButtonCallBack = new Action<int>(this.OnClickLoopItem)
		};
	}

	// Token: 0x0600764A RID: 30282 RVA: 0x00188FE8 File Offset: 0x001871E8
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

	// Token: 0x04003639 RID: 13881
	[Nullable(2)]
	private IBabelTowerNormalLevelChoseViewData Data;

	// Token: 0x0400363A RID: 13882
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400363B RID: 13883
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<BabelTowerNormalLevelChoseItem, BabelActivityLevelInfo> LoopScrollView;

	// Token: 0x0400363C RID: 13884
	private List<BabelActivityLevelInfo> LevelList = new List<BabelActivityLevelInfo>();

	// Token: 0x0400363D RID: 13885
	[Nullable(2)]
	private BabelTowerNormalLevelChoseItem CurrentPlayLoopSeqItem;

	// Token: 0x0200774B RID: 30539
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040275AB RID: 161195
		public const int CaptionItem = 0;

		// Token: 0x040275AC RID: 161196
		public const int TargetText = 1;

		// Token: 0x040275AD RID: 161197
		public const int ShopItem = 2;

		// Token: 0x040275AE RID: 161198
		public const int ShopBtnRedDotItem = 3;

		// Token: 0x040275AF RID: 161199
		public const int QuestBtn = 4;

		// Token: 0x040275B0 RID: 161200
		public const int QuestBtnRedDotItem = 5;

		// Token: 0x040275B1 RID: 161201
		public const int QuestBtnText1 = 6;

		// Token: 0x040275B2 RID: 161202
		public const int QuestBtnText2 = 7;

		// Token: 0x040275B3 RID: 161203
		public const int LoopScrollView = 8;

		// Token: 0x040275B4 RID: 161204
		public const int LoopScrollItem = 9;
	}
}
