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
	// Token: 0x020064A6 RID: 25766
	[NullableContext(2)]
	[Nullable(0)]
	public class MatchThreeSelectLevelView : UiTickViewBase
	{
		// Token: 0x06040B31 RID: 265009 RVA: 0x00FA9FA3 File Offset: 0x00FA81A3
		[NullableContext(1)]
		public MatchThreeSelectLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06040B32 RID: 265010 RVA: 0x00FA9FC0 File Offset: 0x00FA81C0
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

		// Token: 0x06040B33 RID: 265011 RVA: 0x00FAA06C File Offset: 0x00FA826C
		protected override UniTask OnBeforeStartAsync()
		{
			MatchThreeSelectLevelView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MatchThreeSelectLevelView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040B34 RID: 265012 RVA: 0x00FAA0B0 File Offset: 0x00FA82B0
		protected override void OnBeforeShow()
		{
			int selectedIndex = this.RefreshLevelList();
			this.PlayGridAnim();
			this.ScheduleSelectedLevelOffset(selectedIndex);
		}

		// Token: 0x06040B35 RID: 265013 RVA: 0x00FAA0D1 File Offset: 0x00FA82D1
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

		// Token: 0x06040B36 RID: 265014 RVA: 0x00FAA104 File Offset: 0x00FA8304
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

		// Token: 0x06040B37 RID: 265015 RVA: 0x00FAA180 File Offset: 0x00FA8380
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

		// Token: 0x06040B38 RID: 265016 RVA: 0x00FAA270 File Offset: 0x00FA8470
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

		// Token: 0x06040B39 RID: 265017 RVA: 0x00FAA2D0 File Offset: 0x00FA84D0
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

		// Token: 0x06040B3A RID: 265018 RVA: 0x00FAA32C File Offset: 0x00FA852C
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

		// Token: 0x06040B3B RID: 265019 RVA: 0x00FAA37C File Offset: 0x00FA857C
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

		// Token: 0x06040B3C RID: 265020 RVA: 0x00FAA3E0 File Offset: 0x00FA85E0
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

		// Token: 0x06040B3D RID: 265021 RVA: 0x00FAA448 File Offset: 0x00FA8648
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

		// Token: 0x06040B3E RID: 265022 RVA: 0x00FAA498 File Offset: 0x00FA8698
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

		// Token: 0x06040B3F RID: 265023 RVA: 0x00FAA540 File Offset: 0x00FA8740
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

		// Token: 0x06040B40 RID: 265024 RVA: 0x00FAA5DD File Offset: 0x00FA87DD
		[NullableContext(1)]
		private void OnLevelSelected(MatchThreeChapterSelectData chapterData)
		{
			this.CurrentSelectChapter = chapterData;
		}

		// Token: 0x06040B41 RID: 265025 RVA: 0x00FAA5E6 File Offset: 0x00FA87E6
		private void OnClickedCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x06040B42 RID: 265026 RVA: 0x00FAA5F0 File Offset: 0x00FA87F0
		private void OnClickHelpBtn()
		{
			ActivityMatchThreeData matchThreeData = ActivityMatchThreeController.Instance.GetMatchThreeData();
			if (matchThreeData == null || matchThreeData.LocalConfig == null)
			{
				return;
			}
			HelpController.Instance.OpenHelpById(matchThreeData.LocalConfig.Value.HelpId);
		}

		// Token: 0x04021AB9 RID: 137913
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021ABA RID: 137914
		private UUIScrollViewWithScrollbarComponent LevelScrollView;

		// Token: 0x04021ABB RID: 137915
		private MultiTemplateComponent LevelMultiTemplateComponent;

		// Token: 0x04021ABC RID: 137916
		private UUIInturnAnimController GridAnimController;

		// Token: 0x04021ABD RID: 137917
		private MatchThreeChapterSelectData CurrentSelectChapter;

		// Token: 0x04021ABE RID: 137918
		private int PendingFocusIndex = -1;

		// Token: 0x04021ABF RID: 137919
		private int PendingLayoutFrameCount;

		// Token: 0x04021AC0 RID: 137920
		private bool IsWaitingSelectedLevelStartAnimationFinish;

		// Token: 0x04021AC1 RID: 137921
		[Nullable(1)]
		private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();
	}
}
