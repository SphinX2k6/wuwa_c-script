using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.View
{
	// Token: 0x02005424 RID: 21540
	[NullableContext(2)]
	[Nullable(0)]
	public class MatchThreeSelectLevelView : UiTickViewBase
	{
		// Token: 0x060357F5 RID: 219125 RVA: 0x00EF0FEB File Offset: 0x00EEF1EB
		[NullableContext(1)]
		public MatchThreeSelectLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060357F6 RID: 219126 RVA: 0x00EF1008 File Offset: 0x00EEF208
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060357F7 RID: 219127 RVA: 0x00EF10B4 File Offset: 0x00EEF2B4
		protected override UniTask OnBeforeStartAsync()
		{
			MatchThreeSelectLevelView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MatchThreeSelectLevelView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060357F8 RID: 219128 RVA: 0x00EF10F8 File Offset: 0x00EEF2F8
		protected override void OnBeforeShow()
		{
			int selectedIndex = this.RefreshLevelList();
			this.PlayGridAnim();
			this.ScheduleSelectedLevelOffset(selectedIndex);
		}

		// Token: 0x060357F9 RID: 219129 RVA: 0x00EF1119 File Offset: 0x00EEF319
		protected override void OnBeforeHide()
		{
			this.IsWaitingSelectedLevelStartAnimationFinish = false;
			this.SetAllLevelNavigationActive(true);
			this.PendingLayoutFrameCount = 0;
			this.PendingFocusIndex = -1;
			UUIScrollViewWithScrollbarComponent levelScrollView = this.LevelScrollView;
			if (levelScrollView == null)
			{
				return;
			}
			levelScrollView.OnLateUpdate.Unbind();
		}

		// Token: 0x060357FA RID: 219130 RVA: 0x00EF114C File Offset: 0x00EEF34C
		protected override void OnTick(float _)
		{
			if (!this.IsWaitingSelectedLevelStartAnimationFinish)
			{
				return;
			}
			UUIInturnAnimController gridAnimController = this.GridAnimController;
			if (gridAnimController != null && gridAnimController.IsValid() && this.GridAnimController.IsPlaying())
			{
				return;
			}
			MultiTemplateComponent levelMultiTemplateComponent = this.LevelMultiTemplateComponent;
			if (!(((levelMultiTemplateComponent != null) ? levelMultiTemplateComponent.GetProxyByDisplayIndex(this.PendingFocusIndex) : null) is MatchThreeLevelItem))
			{
				return;
			}
			if (this.IsAnyLevelStartAnimationPlaying())
			{
				return;
			}
			this.IsWaitingSelectedLevelStartAnimationFinish = false;
			this.SetAllLevelNavigationActive(true);
			this.FocusSelectedLevel(this.PendingFocusIndex);
		}

		// Token: 0x060357FB RID: 219131 RVA: 0x00EF11C8 File Offset: 0x00EEF3C8
		private void SetSelectedLevelOffset(int selectedIndex)
		{
			if (this.LevelScrollView == null || this.LevelMultiTemplateComponent == null || selectedIndex < 0)
			{
				return;
			}
			UUIItem itemByDisplayIndex = this.LevelMultiTemplateComponent.GetItemByDisplayIndex(selectedIndex);
			if (itemByDisplayIndex == null || !itemByDisplayIndex.IsValid())
			{
				return;
			}
			AUIBaseActor content = this.LevelScrollView.GetContent();
			UUIItem uuiitem = (content != null) ? content.GetUIItem() : null;
			AUIBaseActor viewport = this.LevelScrollView.GetViewport();
			UUIItem uuiitem2 = (viewport != null) ? viewport.GetUIItem() : null;
			if (uuiitem == null || !uuiitem.IsValid() || (uuiitem2 == null || !uuiitem2.IsValid()))
			{
				return;
			}
			float num = uuiitem2.GetWidth() * 0.5f - (itemByDisplayIndex.GetAnchorOffsetX() + itemByDisplayIndex.GetWidth() * 0.5f);
			float num2 = uuiitem2.GetWidth() - uuiitem.GetWidth();
			if (num2 > 0f)
			{
				num2 = 0f;
			}
			if (num < num2)
			{
				num = num2;
			}
			else if (num > 0f)
			{
				num = 0f;
			}
			uuiitem.SetAnchorOffsetX(num);
		}

		// Token: 0x060357FC RID: 219132 RVA: 0x00EF12B8 File Offset: 0x00EEF4B8
		private void FocusSelectedLevel(int selectedIndex)
		{
			if (!Info.Instance.IsInGamepad() || this.LevelMultiTemplateComponent == null)
			{
				return;
			}
			if (selectedIndex < 0)
			{
				return;
			}
			MatchThreeLevelItem matchThreeLevelItem = this.LevelMultiTemplateComponent.GetProxyByDisplayIndex(selectedIndex) as MatchThreeLevelItem;
			if (matchThreeLevelItem == null)
			{
				return;
			}
			UUIItem navigationItem = matchThreeLevelItem.GetNavigationItem();
			if (navigationItem == null || !navigationItem.IsValid())
			{
				return;
			}
			UiNavigationNewController.Instance.SetNavigationFocusForView(navigationItem, true, true, true);
		}

		// Token: 0x060357FD RID: 219133 RVA: 0x00EF1318 File Offset: 0x00EEF518
		private void SetAllLevelNavigationActive(bool active)
		{
			if (this.LevelMultiTemplateComponent == null)
			{
				return;
			}
			int displayGridNum = this.LevelMultiTemplateComponent.GetDisplayGridNum();
			for (int i = 0; i < displayGridNum; i++)
			{
				MatchThreeLevelItem matchThreeLevelItem = this.LevelMultiTemplateComponent.GetProxyByDisplayIndex(i) as MatchThreeLevelItem;
				if (matchThreeLevelItem != null)
				{
					UUIItem navigationItem = matchThreeLevelItem.GetNavigationItem();
					if (navigationItem != null && navigationItem.IsValid())
					{
						navigationItem.SetUIActive(active);
					}
				}
			}
		}

		// Token: 0x060357FE RID: 219134 RVA: 0x00EF1374 File Offset: 0x00EEF574
		private bool IsAnyLevelStartAnimationPlaying()
		{
			if (this.LevelMultiTemplateComponent == null)
			{
				return false;
			}
			int displayGridNum = this.LevelMultiTemplateComponent.GetDisplayGridNum();
			for (int i = 0; i < displayGridNum; i++)
			{
				MatchThreeLevelItem matchThreeLevelItem = this.LevelMultiTemplateComponent.GetProxyByDisplayIndex(i) as MatchThreeLevelItem;
				if (matchThreeLevelItem != null && matchThreeLevelItem.IsStartAnimationPlaying())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060357FF RID: 219135 RVA: 0x00EF13C4 File Offset: 0x00EEF5C4
		private void PlayGridAnim()
		{
			if (this.LevelMultiTemplateComponent == null)
			{
				return;
			}
			UUIInturnAnimController gridAnimController = this.GridAnimController;
			if (gridAnimController == null || !gridAnimController.IsValid())
			{
				return;
			}
			if (Info.Instance.IsInGamepad())
			{
				this.SetAllLevelNavigationActive(false);
				this.IsWaitingSelectedLevelStartAnimationFinish = true;
			}
			this.GridAnimController.Play("Start", this.LevelMultiTemplateComponent.GetDisplayGridNum(), false);
		}

		// Token: 0x06035800 RID: 219136 RVA: 0x00EF1428 File Offset: 0x00EEF628
		private void ScheduleSelectedLevelOffset(int selectedIndex)
		{
			this.PendingLayoutFrameCount = 0;
			this.PendingFocusIndex = -1;
			UUIScrollViewWithScrollbarComponent levelScrollView = this.LevelScrollView;
			if (levelScrollView != null)
			{
				levelScrollView.OnLateUpdate.Unbind();
			}
			if (this.LevelScrollView == null || selectedIndex < 0)
			{
				return;
			}
			this.PendingFocusIndex = selectedIndex;
			this.PendingLayoutFrameCount = 1;
			this.LevelScrollView.OnLateUpdate.Bind(new Action<float>(this.OnLevelScrollLateUpdate));
		}

		// Token: 0x06035801 RID: 219137 RVA: 0x00EF1490 File Offset: 0x00EEF690
		private void OnLevelScrollLateUpdate(float _)
		{
			if (this.PendingLayoutFrameCount > 0)
			{
				this.PendingLayoutFrameCount--;
				return;
			}
			UUIScrollViewWithScrollbarComponent levelScrollView = this.LevelScrollView;
			if (levelScrollView != null)
			{
				levelScrollView.OnLateUpdate.Unbind();
			}
			if (!base.IsShowOrShowing)
			{
				return;
			}
			this.SetSelectedLevelOffset(this.PendingFocusIndex);
		}

		// Token: 0x06035802 RID: 219138 RVA: 0x00EF14E0 File Offset: 0x00EEF6E0
		private int RefreshLevelList()
		{
			if (this.LevelMultiTemplateComponent == null)
			{
				return -1;
			}
			IReadOnlyList<MatchThreeChapterSelectData> allLevelSelectData = ActivityMatchThreeController.Instance.GetAllLevelSelectData();
			int result = this.ResolveCurrentSelectIndex(allLevelSelectData);
			this.ScrollDataList.Clear();
			foreach (MatchThreeChapterSelectData data in allLevelSelectData)
			{
				this.ScrollDataList.Add(new MatchThreeLevelItemTemplateData
				{
					Data = data,
					OnSelected = new Action<MatchThreeChapterSelectData>(this.OnLevelSelected)
				});
			}
			this.LevelMultiTemplateComponent.RefreshByData(this.ScrollDataList, false);
			return result;
		}

		// Token: 0x06035803 RID: 219139 RVA: 0x00EF1588 File Offset: 0x00EEF788
		[NullableContext(1)]
		private int ResolveCurrentSelectIndex(IReadOnlyList<MatchThreeChapterSelectData> levelData)
		{
			if (levelData.Count == 0)
			{
				this.CurrentSelectChapter = null;
				return -1;
			}
			MatchThreeChapterSelectData currentSelectChapter = this.CurrentSelectChapter;
			int? num = (currentSelectChapter != null) ? new int?(currentSelectChapter.Chapter) : null;
			int num2 = -1;
			if (num != null)
			{
				for (int i = 0; i < levelData.Count; i++)
				{
					if (levelData[i].Chapter == num.Value)
					{
						num2 = i;
						break;
					}
				}
			}
			if (num2 < 0)
			{
				ActivityMatchThreeData matchThreeData = ActivityMatchThreeController.Instance.GetMatchThreeData();
				num2 = ((matchThreeData != null) ? matchThreeData.GetAutoFocusChapterIndex(levelData) : 0);
			}
			this.CurrentSelectChapter = levelData[num2];
			return num2;
		}

		// Token: 0x06035804 RID: 219140 RVA: 0x00EF1625 File Offset: 0x00EEF825
		[NullableContext(1)]
		private void OnLevelSelected(MatchThreeChapterSelectData chapterData)
		{
			this.CurrentSelectChapter = chapterData;
		}

		// Token: 0x06035805 RID: 219141 RVA: 0x00EF162E File Offset: 0x00EEF82E
		private void OnClickedCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x06035806 RID: 219142 RVA: 0x00EF1638 File Offset: 0x00EEF838
		private void OnClickHelpBtn()
		{
			ActivityMatchThreeData matchThreeData = ActivityMatchThreeController.Instance.GetMatchThreeData();
			if (matchThreeData == null || matchThreeData.LocalConfig == null)
			{
				return;
			}
			HelpController.Instance.OpenHelpById(matchThreeData.LocalConfig.Value.HelpId);
		}

		// Token: 0x0401C3EA RID: 115690
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C3EB RID: 115691
		private UUIScrollViewWithScrollbarComponent LevelScrollView;

		// Token: 0x0401C3EC RID: 115692
		private MultiTemplateComponent LevelMultiTemplateComponent;

		// Token: 0x0401C3ED RID: 115693
		private UUIInturnAnimController GridAnimController;

		// Token: 0x0401C3EE RID: 115694
		private MatchThreeChapterSelectData CurrentSelectChapter;

		// Token: 0x0401C3EF RID: 115695
		private int PendingFocusIndex = -1;

		// Token: 0x0401C3F0 RID: 115696
		private int PendingLayoutFrameCount;

		// Token: 0x0401C3F1 RID: 115697
		private bool IsWaitingSelectedLevelStartAnimationFinish;

		// Token: 0x0401C3F2 RID: 115698
		[Nullable(1)]
		private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();
	}
}
