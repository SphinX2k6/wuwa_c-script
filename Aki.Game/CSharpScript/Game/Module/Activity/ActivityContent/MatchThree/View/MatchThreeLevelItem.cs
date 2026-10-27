using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.View
{
	// Token: 0x02006498 RID: 25752
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MatchThreeLevelItem : SyncGridProxyAbstract<MatchThreeChapterSelectData>
	{
		// Token: 0x06040AC8 RID: 264904 RVA: 0x00FA7A68 File Offset: 0x00FA5C68
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedSelectButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06040AC9 RID: 264905 RVA: 0x00FA7C3C File Offset: 0x00FA5E3C
		protected override void OnStart()
		{
			this.InitTickSystem();
			if (this.TickId != -1)
			{
				TickSystem.Instance.Resume(this.TickId);
			}
			this.SequencePlayer = new LevelSequencePlayer(base.GetItem(9));
			TArray<UActorComponent> componentsInChildren = ULGUIBPLibrary.GetComponentsInChildren(this.RootActor, TsUiNavigationBehaviorListener.StaticClass(), true);
			if (componentsInChildren != null && componentsInChildren.Num() > 0)
			{
				TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = componentsInChildren.Get(componentsInChildren.Num() - 1) as TsUiNavigationBehaviorListener;
				this.NavigationItem = ((tsUiNavigationBehaviorListener != null) ? tsUiNavigationBehaviorListener.RootUIComp.Get() : null);
			}
		}

		// Token: 0x06040ACA RID: 264906 RVA: 0x00FA7CD0 File Offset: 0x00FA5ED0
		protected override void OnBeforeDestroy()
		{
			UUIButtonComponent button = base.GetButton(0);
			button.FocusListenerDelegate.Unbind();
			button.UnFocusListenerDelegate.Unbind();
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			this.NavigationItem = null;
			if (this.TickId != -1)
			{
				TickSystem.Instance.Remove(this.TickId);
				this.TickId = -1;
			}
		}

		// Token: 0x06040ACB RID: 264907 RVA: 0x00FA7D39 File Offset: 0x00FA5F39
		public override void Refresh(MatchThreeChapterSelectData data)
		{
			this.ChapterData = data;
			this.RefreshPanel();
		}

		// Token: 0x06040ACC RID: 264908 RVA: 0x00FA7D48 File Offset: 0x00FA5F48
		[NullableContext(2)]
		public UUIItem GetNavigationItem()
		{
			return this.NavigationItem;
		}

		// Token: 0x06040ACD RID: 264909 RVA: 0x00FA7D50 File Offset: 0x00FA5F50
		public bool IsStartAnimationPlaying()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			return sequencePlayer != null && sequencePlayer.CheckSeqActorIsSeqPlaying("Start");
		}

		// Token: 0x06040ACE RID: 264910 RVA: 0x00FA7D68 File Offset: 0x00FA5F68
		private void InitTickSystem()
		{
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.RefreshTimeTick), "MatchThreeLevelItem", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
			if (this.TickId != -1)
			{
				TickSystem.Instance.Pause(this.TickId);
			}
		}

		// Token: 0x06040ACF RID: 264911 RVA: 0x00FA7DBC File Offset: 0x00FA5FBC
		private void RefreshPanel()
		{
			if (this.ChapterData == null)
			{
				return;
			}
			ActivityMatchThreeData matchThreeData = ActivityMatchThreeController.Instance.GetMatchThreeData();
			if (matchThreeData == null)
			{
				return;
			}
			this.ChapterState = matchThreeData.GetChapterState(this.ChapterData);
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(!this.ChapterData.IsEndless && this.ChapterData.Chapter % 2 == 0);
			}
			UUIArtText artText = base.GetArtText(2);
			if (artText != null)
			{
				artText.SetText(this.ChapterData.Chapter.ToString());
			}
			this.RefreshStageName();
			this.RefreshState(matchThreeData);
			this.RefreshNewDot(matchThreeData);
		}

		// Token: 0x06040AD0 RID: 264912 RVA: 0x00FA7E5B File Offset: 0x00FA605B
		private void RefreshNewDot(ActivityMatchThreeData activityData)
		{
			if (this.ChapterData == null)
			{
				return;
			}
			UUIItem item = base.GetItem(10);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(activityData.CheckChapterRedPointShow(this.ChapterData));
		}

		// Token: 0x06040AD1 RID: 264913 RVA: 0x00FA7E84 File Offset: 0x00FA6084
		private void RefreshStageName()
		{
			this.SetStageNameText(base.GetText(3));
			this.SetStageNameText(base.GetText(4));
			this.SetStageNameText(base.GetText(5));
		}

		// Token: 0x06040AD2 RID: 264914 RVA: 0x00FA7EAD File Offset: 0x00FA60AD
		[NullableContext(2)]
		private void SetStageNameText(UUIText text)
		{
			if (text == null || this.ChapterData == null)
			{
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(text, ActivityMatchThreeConfig.Instance.GetLevelTitleTextId(this.ChapterData.NormalLevelId), Array.Empty<object>());
		}

		// Token: 0x06040AD3 RID: 264915 RVA: 0x00FA7EE0 File Offset: 0x00FA60E0
		private void RefreshState(ActivityMatchThreeData activityData)
		{
			if (this.ChapterData == null)
			{
				return;
			}
			EMatchThreeChapterState chapterState = this.ChapterState;
			bool flag = chapterState - EMatchThreeChapterState.TimeLocked <= 1;
			bool flag2 = flag;
			bool flag3 = this.ChapterState == EMatchThreeChapterState.Completed;
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(flag2);
			}
			UUIItem item2 = base.GetItem(8);
			if (item2 != null)
			{
				item2.SetUIActive(flag3);
			}
			this.RefreshStateColor(flag2, flag3);
			UUIText text = base.GetText(7);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			if (text == null)
			{
				return;
			}
			if (flag2)
			{
				this.RefreshLockStatusText(activityData, text);
				return;
			}
			if (this.ChapterData.IsEndless)
			{
				this.RefreshEndlessStatusText(activityData, text);
				return;
			}
			if (flag3)
			{
				LguiUtil.Instance.TrySetLocalTextNew(text, "MatchThree_Completed", Array.Empty<object>());
				return;
			}
			this.RefreshInProgressStatusText(activityData, text);
		}

		// Token: 0x06040AD4 RID: 264916 RVA: 0x00FA7FA0 File Offset: 0x00FA61A0
		private void RefreshStateColor(bool isLocked, bool isDone)
		{
			string hexStr = isLocked ? "909090" : (isDone ? "C0D8C5" : "FFFFFF");
			UUIItem item = base.GetItem(9);
			if (item == null)
			{
				return;
			}
			item.SetColor(FColor.FromHex(hexStr));
		}

		// Token: 0x06040AD5 RID: 264917 RVA: 0x00FA7FE0 File Offset: 0x00FA61E0
		private void RefreshLockStatusText(ActivityMatchThreeData activityData, UUIText statusText)
		{
			if (this.ChapterData == null)
			{
				return;
			}
			if (this.ChapterState != EMatchThreeChapterState.TimeLocked)
			{
				LguiUtil.Instance.TrySetLocalTextNew(statusText, "MatchThree_FinishPrestage", Array.Empty<object>());
				return;
			}
			string unlockDesc = activityData.GetUnlockDesc(this.ChapterData.PrimaryLevelId);
			if (!string.IsNullOrEmpty(unlockDesc))
			{
				statusText.SetText(unlockDesc, true);
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(statusText, "MatchThree_TimeCountdown", Array.Empty<object>());
		}

		// Token: 0x06040AD6 RID: 264918 RVA: 0x00FA8050 File Offset: 0x00FA6250
		private void RefreshInProgressStatusText(ActivityMatchThreeData activityData, UUIText statusText)
		{
			if (this.ChapterData == null)
			{
				return;
			}
			ValueTuple<int, int> chapterProgress = activityData.GetChapterProgress(this.ChapterData);
			int item = chapterProgress.Item1;
			int item2 = chapterProgress.Item2;
			LguiUtil.Instance.TrySetLocalTextNew(statusText, "MatchThree_Ongoing", new <>z__ReadOnlyArray<object>(new object[]
			{
				item.ToString(),
				item2.ToString()
			}));
		}

		// Token: 0x06040AD7 RID: 264919 RVA: 0x00FA80B0 File Offset: 0x00FA62B0
		private void RefreshEndlessStatusText(ActivityMatchThreeData activityData, UUIText statusText)
		{
			if (this.ChapterData == null)
			{
				return;
			}
			int endlessBestScore = activityData.GetEndlessBestScore(this.ChapterData);
			if (endlessBestScore > 0)
			{
				LguiUtil.Instance.TrySetLocalTextNew(statusText, "MatchThree_BestRecord", new <>z__ReadOnlySingleElementList<object>(endlessBestScore.ToString()));
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(statusText, "MatchThree_NoRecord", Array.Empty<object>());
		}

		// Token: 0x06040AD8 RID: 264920 RVA: 0x00FA810C File Offset: 0x00FA630C
		private void RefreshTimeTick(float _)
		{
			if (this.ChapterData == null)
			{
				return;
			}
			ActivityMatchThreeData matchThreeData = ActivityMatchThreeController.Instance.GetMatchThreeData();
			if (matchThreeData == null)
			{
				return;
			}
			EMatchThreeChapterState chapterState = matchThreeData.GetChapterState(this.ChapterData);
			if (chapterState != this.ChapterState)
			{
				this.ChapterState = chapterState;
				this.RefreshState(matchThreeData);
				this.RefreshNewDot(matchThreeData);
				return;
			}
			if (this.ChapterState == EMatchThreeChapterState.TimeLocked)
			{
				UUIText text = base.GetText(7);
				if (text != null)
				{
					this.RefreshLockStatusText(matchThreeData, text);
				}
			}
		}

		// Token: 0x06040AD9 RID: 264921 RVA: 0x00FA817C File Offset: 0x00FA637C
		private void OnClickedSelectButton()
		{
			if (this.ChapterData == null)
			{
				return;
			}
			ActivityMatchThreeData matchThreeData = ActivityMatchThreeController.Instance.GetMatchThreeData();
			if (matchThreeData == null)
			{
				return;
			}
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ConnectBan", Array.Empty<object>());
				return;
			}
			EMatchThreeChapterLockReason chapterLockReason = matchThreeData.GetChapterLockReason(this.ChapterData);
			if (chapterLockReason == EMatchThreeChapterLockReason.Time)
			{
				string unlockDesc = matchThreeData.GetUnlockDesc(this.ChapterData.PrimaryLevelId);
				if (!string.IsNullOrEmpty(unlockDesc))
				{
					ScrollingTipsController.Instance.ShowTipsByText(unlockDesc);
					return;
				}
				ScrollingTipsController.Instance.ShowTipsByTextId("MatchThree_TimeCountdown", Array.Empty<object>());
				return;
			}
			else
			{
				if (chapterLockReason == EMatchThreeChapterLockReason.PreChapter)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("MatchThree_FinishPrestage", Array.Empty<object>());
					return;
				}
				matchThreeData.MarkChapterClicked(this.ChapterData.Chapter);
				UUIItem item = base.GetItem(10);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				Action<MatchThreeChapterSelectData> onSelected = this.OnSelected;
				if (onSelected != null)
				{
					onSelected(this.ChapterData);
				}
				ActivityMatchThreeController.Instance.OpenLevelDetail(this.ChapterData);
				return;
			}
		}

		// Token: 0x04021A66 RID: 137830
		public const int TemplateNormal = 0;

		// Token: 0x04021A67 RID: 137831
		public const int TemplateEndless = 1;

		// Token: 0x04021A68 RID: 137832
		private const string ColorLocked = "909090";

		// Token: 0x04021A69 RID: 137833
		private const string ColorNormal = "FFFFFF";

		// Token: 0x04021A6A RID: 137834
		private const string ColorDone = "C0D8C5";

		// Token: 0x04021A6B RID: 137835
		[Nullable(2)]
		private MatchThreeChapterSelectData ChapterData;

		// Token: 0x04021A6C RID: 137836
		private EMatchThreeChapterState ChapterState;

		// Token: 0x04021A6D RID: 137837
		private int TickId = -1;

		// Token: 0x04021A6E RID: 137838
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x04021A6F RID: 137839
		[Nullable(2)]
		private UUIItem NavigationItem;

		// Token: 0x04021A70 RID: 137840
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MatchThreeChapterSelectData> OnSelected;
	}
}
