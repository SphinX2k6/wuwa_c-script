using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x0200520B RID: 21003
	[NullableContext(1)]
	[Nullable(0)]
	public class RealmBetweenTravelTaskView : UiViewBase
	{
		// Token: 0x0603446F RID: 214127 RVA: 0x00E9FBA2 File Offset: 0x00E9DDA2
		public RealmBetweenTravelTaskView(UiViewInfo uiViewInfo) : base(uiViewInfo)
		{
		}

		// Token: 0x06034470 RID: 214128 RVA: 0x00E9FBC8 File Offset: 0x00E9DDC8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIScrollViewComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIMultiTemplateScrollViewComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x06034471 RID: 214129 RVA: 0x00E9FC5C File Offset: 0x00E9DE5C
		protected override UniTask OnBeforeStartAsync()
		{
			RealmBetweenTravelTaskView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RealmBetweenTravelTaskView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034472 RID: 214130 RVA: 0x00E9FC9F File Offset: 0x00E9DE9F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RealmBetweenTaskRefresh, new Action(this.OnRealmBetweenTaskRefresh));
			EventSystem.Instance.Add(EEventName.RealmBetweenTaskNavigationNext, new Action(this.OnRealmBetweenTaskNavigationNext));
		}

		// Token: 0x06034473 RID: 214131 RVA: 0x00E9FCD9 File Offset: 0x00E9DED9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RealmBetweenTaskRefresh, new Action(this.OnRealmBetweenTaskRefresh));
			EventSystem.Instance.Remove(EEventName.RealmBetweenTaskNavigationNext, new Action(this.OnRealmBetweenTaskNavigationNext));
		}

		// Token: 0x06034474 RID: 214132 RVA: 0x00E9FD14 File Offset: 0x00E9DF14
		private UniTask EnsureMenuItems(List<RealmBetweenAreaData> areaDataList)
		{
			RealmBetweenTravelTaskView.<EnsureMenuItems>d__14 <EnsureMenuItems>d__;
			<EnsureMenuItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnsureMenuItems>d__.<>4__this = this;
			<EnsureMenuItems>d__.areaDataList = areaDataList;
			<EnsureMenuItems>d__.<>1__state = -1;
			<EnsureMenuItems>d__.<>t__builder.Start<RealmBetweenTravelTaskView.<EnsureMenuItems>d__14>(ref <EnsureMenuItems>d__);
			return <EnsureMenuItems>d__.<>t__builder.Task;
		}

		// Token: 0x06034475 RID: 214133 RVA: 0x00E9FD60 File Offset: 0x00E9DF60
		private void OnRealmBetweenTaskNavigationNext()
		{
			List<RealmBetweenAreaData> areaDataList = this.GetAreaDataList();
			int missionTitleIndexByMenuIndex = this.GetMissionTitleIndexByMenuIndex(areaDataList, this.TabSelectIndex);
			AreaTaskItem areaTaskItem = this.AreaMissionItemScroll.GetProxyByGridIndex(missionTitleIndexByMenuIndex + 1) as AreaTaskItem;
			UUIItem uuiitem = (areaTaskItem != null) ? areaTaskItem.GetFirstUiItem() : null;
			if (uuiitem != null)
			{
				UiNavigationNewController.Instance.SetNavigationFocusForView(uuiitem, false, false, false);
			}
		}

		// Token: 0x06034476 RID: 214134 RVA: 0x00E9FDB4 File Offset: 0x00E9DFB4
		private void OnRealmBetweenTaskRefresh()
		{
			this.RefreshCurrentAsync().Forget();
		}

		// Token: 0x06034477 RID: 214135 RVA: 0x00E9FDC4 File Offset: 0x00E9DFC4
		private UniTask RefreshCurrentAsync()
		{
			RealmBetweenTravelTaskView.<RefreshCurrentAsync>d__17 <RefreshCurrentAsync>d__;
			<RefreshCurrentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCurrentAsync>d__.<>4__this = this;
			<RefreshCurrentAsync>d__.<>1__state = -1;
			<RefreshCurrentAsync>d__.<>t__builder.Start<RealmBetweenTravelTaskView.<RefreshCurrentAsync>d__17>(ref <RefreshCurrentAsync>d__);
			return <RefreshCurrentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034478 RID: 214136 RVA: 0x00E9FE08 File Offset: 0x00E9E008
		private UniTask Refresh()
		{
			RealmBetweenTravelTaskView.<Refresh>d__18 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<RealmBetweenTravelTaskView.<Refresh>d__18>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x06034479 RID: 214137 RVA: 0x00E9FE4C File Offset: 0x00E9E04C
		private List<IMultiTemplateGridData> GetMissionGridDataList(List<RealmBetweenAreaData> areaDataList)
		{
			List<IMultiTemplateGridData> list = new List<IMultiTemplateGridData>();
			foreach (RealmBetweenAreaData realmBetweenAreaData in areaDataList)
			{
				list.Add(new AreaTitleGridData(realmBetweenAreaData, this.ActivityBaseData));
				if (realmBetweenAreaData.IsUnlock)
				{
					using (List<ActivityTaskData>.Enumerator enumerator2 = this.ActivityBaseData.GetAreaTaskDataList(realmBetweenAreaData.AreaId).GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							ActivityTaskData taskData = enumerator2.Current;
							list.Add(new AreaTaskGridData(taskData, realmBetweenAreaData, this.ActivityBaseData));
						}
						continue;
					}
				}
				list.Add(new AreaLockGuideGridData(realmBetweenAreaData, this.ActivityBaseData));
			}
			return list;
		}

		// Token: 0x0603447A RID: 214138 RVA: 0x00E9FF28 File Offset: 0x00E9E128
		private int GetMissionTitleIndexByMenuIndex(List<RealmBetweenAreaData> areaDataList, int menuIndex)
		{
			int num = menuIndex;
			List<IMultiTemplateGridData> missionGridDataList = this.GetMissionGridDataList(areaDataList);
			for (int i = 0; i < missionGridDataList.Count; i++)
			{
				if (missionGridDataList[i].GetTemplateIndex() == 0)
				{
					num--;
					if (num < 0)
					{
						return i;
					}
				}
			}
			return 0;
		}

		// Token: 0x0603447B RID: 214139 RVA: 0x00E9FF6C File Offset: 0x00E9E16C
		private void RebuildAreaMissionTitleOffsets(List<IMultiTemplateGridData> flatDataList)
		{
			this.AreaMissionTitleOffsets.Clear();
			UUIMultiTemplateScrollViewComponent scrollView = this.AreaMissionItemScroll.ScrollView;
			float num = 0f;
			for (int i = 0; i < flatDataList.Count; i++)
			{
				if (flatDataList[i].GetTemplateIndex() == 0)
				{
					this.AreaMissionTitleOffsets.Add(num);
				}
				num += scrollView.GetLineHeightWhenVertical(i);
			}
		}

		// Token: 0x0603447C RID: 214140 RVA: 0x00E9FFCC File Offset: 0x00E9E1CC
		private void EnsureMissionScrollFitsLastArea(List<IMultiTemplateGridData> flatDataList)
		{
			UUIMultiTemplateScrollViewComponent scrollView = this.AreaMissionItemScroll.ScrollView;
			float height = scrollView.RootUIComp.Get().GetHeight();
			float num = 0f;
			for (int i = 0; i < flatDataList.Count; i++)
			{
				float lineHeightWhenVertical = scrollView.GetLineHeightWhenVertical(i);
				num = ((i > 0 && flatDataList[i].GetTemplateIndex() == 0) ? lineHeightWhenVertical : (num + lineHeightWhenVertical));
			}
			if (num < height)
			{
				FMargin contentPadding = scrollView.GetContentPadding();
				contentPadding.Bottom = height - num;
				scrollView.SetContentPadding(contentPadding);
			}
		}

		// Token: 0x0603447D RID: 214141 RVA: 0x00EA005C File Offset: 0x00E9E25C
		private List<RealmBetweenAreaData> GetAreaDataList()
		{
			List<RealmBetweenAreaData> list = new List<RealmBetweenAreaData>();
			foreach (RealmBetweenAreaData realmBetweenAreaData in this.ActivityBaseData.GetAllAreaData())
			{
				if (realmBetweenAreaData.TravelTaskIdSet.Count > 0)
				{
					list.Add(realmBetweenAreaData);
				}
			}
			list.Sort((RealmBetweenAreaData a, RealmBetweenAreaData b) => a.AreaId - b.AreaId);
			return list;
		}

		// Token: 0x0603447E RID: 214142 RVA: 0x00EA00F0 File Offset: 0x00E9E2F0
		private void SetMenuTabSelected(int index, bool bOn, bool bFireEvent)
		{
			this.TabSelectIndex = index;
			if (index >= 0 && index < this.MenuTabItems.Count)
			{
				this.MenuTabItems[index].SetSelected(bOn, bFireEvent);
			}
		}

		// Token: 0x0603447F RID: 214143 RVA: 0x00EA0120 File Offset: 0x00E9E320
		private int? GetNewMenuTab()
		{
			List<RealmBetweenAreaData> areaDataList = this.GetAreaDataList();
			int? result = null;
			for (int i = 0; i < areaDataList.Count; i++)
			{
				int areaId = areaDataList[i].AreaId;
				bool areaNewUnlockState = this.ActivityBaseData.GetAreaNewUnlockState(areaId);
				if (result == null && areaNewUnlockState)
				{
					result = new int?(i);
				}
			}
			return result;
		}

		// Token: 0x06034480 RID: 214144 RVA: 0x00EA0180 File Offset: 0x00E9E380
		private void OnContentUpdate(FVector2D _)
		{
			if (this.IsRefreshEnd || this.MenuTabItems.Count == 0 || this.AreaMissionTitleOffsets.Count == 0)
			{
				return;
			}
			float anchorOffsetY = this.AreaMissionItemScroll.ScrollView.ContentUIItem.Get().GetAnchorOffsetY();
			int num = this.FindAreaIndexByScroll(anchorOffsetY);
			if (num == this.TabSelectIndex)
			{
				return;
			}
			this.SetMenuTabSelected(this.TabSelectIndex, false, false);
			this.SetMenuTabSelected(num, true, false);
			if (num >= 0 && num < this.MenuTabItems.Count)
			{
				this.MenuTabItems[num].MarkNewUnlockSeen();
			}
			this.EnsureMenuTabVisible(num);
		}

		// Token: 0x06034481 RID: 214145 RVA: 0x00EA0224 File Offset: 0x00E9E424
		private int FindAreaIndexByScroll(float scrollY)
		{
			int i = 0;
			int num = this.AreaMissionTitleOffsets.Count - 1;
			while (i < num)
			{
				int num2 = (i + num + 1) / 2;
				if (this.AreaMissionTitleOffsets[num2] <= scrollY)
				{
					i = num2;
				}
				else
				{
					num = num2 - 1;
				}
			}
			return i;
		}

		// Token: 0x06034482 RID: 214146 RVA: 0x00EA0268 File Offset: 0x00E9E468
		private void EnsureMenuTabVisible(int menuTabIndex)
		{
			UUIScrollViewComponent scrollView = base.GetScrollView(2);
			UUIItem uuiitem = (menuTabIndex >= 0 && menuTabIndex < this.MenuTabItems.Count) ? this.MenuTabItems[menuTabIndex].GetRootItem() : null;
			if (uuiitem == null)
			{
				return;
			}
			float height = scrollView.RootUIComp.Get().Height;
			float height2 = scrollView.ContentUIItem.Get().GetHeight();
			float num = Math.Max(0f, height2 - height);
			if (num <= 0f)
			{
				return;
			}
			float num2 = -uuiitem.GetAnchorOffsetY();
			float num3 = num2 + uuiitem.GetHeight();
			float anchorOffsetY = scrollView.ContentUIItem.Get().GetAnchorOffsetY();
			float num4 = anchorOffsetY + height;
			if (num2 >= anchorOffsetY && num3 <= num4)
			{
				return;
			}
			float num5 = (num2 < anchorOffsetY) ? num2 : (num3 - height);
			scrollView.SetScrollProgress(Math.Max(0f, Math.Min(1f, num5 / num)));
		}

		// Token: 0x06034483 RID: 214147 RVA: 0x00EA0358 File Offset: 0x00E9E558
		private void TabSelectedCallBack(RealmBetweenAreaData tabData, int index)
		{
			if (index != this.TabSelectIndex)
			{
				this.SetMenuTabSelected(this.TabSelectIndex, false, false);
			}
			List<RealmBetweenAreaData> areaDataList = this.GetAreaDataList();
			int missionTitleIndexByMenuIndex = this.GetMissionTitleIndexByMenuIndex(areaDataList, index);
			this.TabSelectIndex = index;
			this.AreaMissionItemScroll.ScrollView.StopMovement();
			this.AreaMissionItemScroll.ScrollView.ScrollToGridIndex(missionTitleIndexByMenuIndex, true);
		}

		// Token: 0x06034484 RID: 214148 RVA: 0x00EA03B8 File Offset: 0x00E9E5B8
		public UniTask PlayStartSequence()
		{
			RealmBetweenTravelTaskView.<PlayStartSequence>d__30 <PlayStartSequence>d__;
			<PlayStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequence>d__.<>4__this = this;
			<PlayStartSequence>d__.<>1__state = -1;
			<PlayStartSequence>d__.<>t__builder.Start<RealmBetweenTravelTaskView.<PlayStartSequence>d__30>(ref <PlayStartSequence>d__);
			return <PlayStartSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06034485 RID: 214149 RVA: 0x00EA03FC File Offset: 0x00E9E5FC
		public UniTask PlayCloseSequence()
		{
			RealmBetweenTravelTaskView.<PlayCloseSequence>d__31 <PlayCloseSequence>d__;
			<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseSequence>d__.<>4__this = this;
			<PlayCloseSequence>d__.<>1__state = -1;
			<PlayCloseSequence>d__.<>t__builder.Start<RealmBetweenTravelTaskView.<PlayCloseSequence>d__31>(ref <PlayCloseSequence>d__);
			return <PlayCloseSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06034486 RID: 214150 RVA: 0x00EA043F File Offset: 0x00E9E63F
		private bool IsSelectedOn(RealmBetweenAreaData tabData, int index)
		{
			return this.TabSelectIndex == index;
		}

		// Token: 0x06034487 RID: 214151 RVA: 0x00EA044C File Offset: 0x00E9E64C
		private void OnClickHelpBtn()
		{
			HelpController.Instance.OpenHelpById(this.ActivityBaseData.LocalConfig.Value.HelpId);
		}

		// Token: 0x0401BC25 RID: 113701
		[Nullable(2)]
		private PopupCaptionItem CaptionComponent;

		// Token: 0x0401BC26 RID: 113702
		private ActivityRealmBetweenData ActivityBaseData;

		// Token: 0x0401BC27 RID: 113703
		[Nullable(2)]
		private RewardPanel PanelReward;

		// Token: 0x0401BC28 RID: 113704
		private bool IsRefreshEnd;

		// Token: 0x0401BC29 RID: 113705
		private int TabSelectIndex = -1;

		// Token: 0x0401BC2A RID: 113706
		private readonly List<RealmBetweenTabItem> MenuTabItems = new List<RealmBetweenTabItem>();

		// Token: 0x0401BC2B RID: 113707
		[Nullable(2)]
		private MultiTemplateScrollView AreaMissionItemScroll;

		// Token: 0x0401BC2C RID: 113708
		private readonly List<float> AreaMissionTitleOffsets = new List<float>();

		// Token: 0x0401BC2D RID: 113709
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;
	}
}
