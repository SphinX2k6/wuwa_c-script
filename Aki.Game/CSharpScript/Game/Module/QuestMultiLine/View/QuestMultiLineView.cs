using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using CSharpScript.Game.Module.QuestMultiLine.View.Items;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine.View
{
	// Token: 0x02004FB1 RID: 20401
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineView : UiTickViewBase
	{
		// Token: 0x0603437C RID: 213884 RVA: 0x00C41DCE File Offset: 0x00C3FFCE
		public QuestMultiLineView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17007F81 RID: 32641
		// (get) Token: 0x0603437D RID: 213885 RVA: 0x00C41DED File Offset: 0x00C3FFED
		[Nullable(2)]
		public new QuestMultiLineViewParams OpenParam
		{
			[NullableContext(2)]
			get
			{
				return this.OpenParam as QuestMultiLineViewParams;
			}
		}

		// Token: 0x0603437E RID: 213886 RVA: 0x00C41DFC File Offset: 0x00C3FFFC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIText))
			};
		}

		// Token: 0x0603437F RID: 213887 RVA: 0x00C41EC4 File Offset: 0x00C400C4
		protected override UniTask OnBeforeStartAsync()
		{
			QuestMultiLineView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<QuestMultiLineView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034380 RID: 213888 RVA: 0x00C41F08 File Offset: 0x00C40108
		private UniTask PrepareViewAsync()
		{
			QuestMultiLineView.<PrepareViewAsync>d__19 <PrepareViewAsync>d__;
			<PrepareViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrepareViewAsync>d__.<>4__this = this;
			<PrepareViewAsync>d__.<>1__state = -1;
			<PrepareViewAsync>d__.<>t__builder.Start<QuestMultiLineView.<PrepareViewAsync>d__19>(ref <PrepareViewAsync>d__);
			return <PrepareViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034381 RID: 213889 RVA: 0x00C41F4C File Offset: 0x00C4014C
		private UniTask PrepareNormalTimePointView(QuestMultiLineTimePointData curShowTimePoint)
		{
			QuestMultiLineView.<PrepareNormalTimePointView>d__20 <PrepareNormalTimePointView>d__;
			<PrepareNormalTimePointView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrepareNormalTimePointView>d__.<>4__this = this;
			<PrepareNormalTimePointView>d__.curShowTimePoint = curShowTimePoint;
			<PrepareNormalTimePointView>d__.<>1__state = -1;
			<PrepareNormalTimePointView>d__.<>t__builder.Start<QuestMultiLineView.<PrepareNormalTimePointView>d__20>(ref <PrepareNormalTimePointView>d__);
			return <PrepareNormalTimePointView>d__.<>t__builder.Task;
		}

		// Token: 0x06034382 RID: 213890 RVA: 0x00C41F98 File Offset: 0x00C40198
		private void PlayEnterAnimations()
		{
			QuestMultiLineTimePointData firstShowTimePoint = this.FirstShowTimePoint;
			this.FirstShowTimePoint = null;
			if (firstShowTimePoint == null || QuestMultiLineUtils.IsBranchSelectTimePoint(firstShowTimePoint))
			{
				return;
			}
			if (this.PlayTimePointComponentAnim)
			{
				this.PlayStartSequencerAsync(firstShowTimePoint);
				return;
			}
			base.PlaySequenceAsync("TimeLine_In", false, false, null);
			this.MapPanel.PlayAllComponentsAppearStart();
			Dictionary<int, bool> fightAreas = ((firstShowTimePoint != null) ? firstShowTimePoint.FightingAreaMap : null) ?? new Dictionary<int, bool>();
			this.RefreshAreaStatus(fightAreas);
			if (this.HasActiveFightArea(fightAreas))
			{
				this.PlayFightLightAsync();
			}
			string title = firstShowTimePoint.Title;
			string desc = firstShowTimePoint.Desc;
			if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(desc))
			{
				base.PlaySequenceAsync("Tips_In", false, false, null);
			}
		}

		// Token: 0x06034383 RID: 213891 RVA: 0x00C42054 File Offset: 0x00C40254
		private UniTask PlayStartSequencerAsync(QuestMultiLineTimePointData curShowTimePoint)
		{
			QuestMultiLineView.<PlayStartSequencerAsync>d__22 <PlayStartSequencerAsync>d__;
			<PlayStartSequencerAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequencerAsync>d__.<>4__this = this;
			<PlayStartSequencerAsync>d__.curShowTimePoint = curShowTimePoint;
			<PlayStartSequencerAsync>d__.<>1__state = -1;
			<PlayStartSequencerAsync>d__.<>t__builder.Start<QuestMultiLineView.<PlayStartSequencerAsync>d__22>(ref <PlayStartSequencerAsync>d__);
			return <PlayStartSequencerAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034384 RID: 213892 RVA: 0x00C4209F File Offset: 0x00C4029F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<List<QuestMultiLineTimePointData>>(EEventName.QuestMultiLineTimePointChange, new Action<List<QuestMultiLineTimePointData>>(this.OnTimePointChange));
		}

		// Token: 0x06034385 RID: 213893 RVA: 0x00C420C0 File Offset: 0x00C402C0
		protected override void OnRemoveEventListener()
		{
			QuestMultiLineAnimationSequencer sequencer = this.Sequencer;
			if (sequencer != null)
			{
				sequencer.Stop();
			}
			UniTaskCompletionSource startSequenceFinishedResolve = this.StartSequenceFinishedResolve;
			if (startSequenceFinishedResolve != null)
			{
				startSequenceFinishedResolve.TrySetResult();
			}
			this.StartSequenceFinishedResolve = null;
			EventSystem.Instance.Remove(EEventName.QuestMultiLineTimePointChange, new Action<List<QuestMultiLineTimePointData>>(this.OnTimePointChange));
		}

		// Token: 0x06034386 RID: 213894 RVA: 0x00C42113 File Offset: 0x00C40313
		protected override void OnAfterPlayStartSequence()
		{
			base.OnAfterPlayStartSequence();
			UniTaskCompletionSource startSequenceFinishedResolve = this.StartSequenceFinishedResolve;
			if (startSequenceFinishedResolve != null)
			{
				startSequenceFinishedResolve.TrySetResult();
			}
			this.StartSequenceFinishedResolve = null;
			if (this.EarlyPrepare)
			{
				this.PlayEnterAnimations();
			}
		}

		// Token: 0x06034387 RID: 213895 RVA: 0x00C42144 File Offset: 0x00C40344
		protected override void OnStart()
		{
			PopupCaptionItem popupCaptionItem = new PopupCaptionItem(base.GetItem(1));
			popupCaptionItem.SetCloseCallBack(new Action(this.OnCloseBtnClick));
			popupCaptionItem.SetHelpCallBack(new Action(this.OnHelpBtnClick));
			popupCaptionItem.CreateHomeBtn(EUiViewName.QuestMultiLineView, null, true);
			QuestMultiLineTimeLinePanel timeLinePanel = this.TimeLinePanel;
			if (timeLinePanel != null)
			{
				timeLinePanel.SetTimePointFunction(new Action<QuestMultiLineTimePointData>(this.OnClickTimePoint));
			}
			QuestMultiLineTipsPanel tipsPanel = this.TipsPanel;
			if (tipsPanel != null)
			{
				tipsPanel.SetUiActive(false);
			}
			QuestMultiLineTipsPanel tipsPanel2 = this.TipsPanel;
			if (tipsPanel2 != null)
			{
				tipsPanel2.SetHideCallback(new Action(this.OnTipsHide));
			}
			QuestMultiLineTipsPanel tipsPanel3 = this.TipsPanel;
			if (tipsPanel3 != null)
			{
				tipsPanel3.SetHideSelfBtnInterceptor(new Func<bool>(this.OnTipsHideSelfBtnIntercept));
			}
			if (!this.EarlyPrepare)
			{
				this.RefreshView();
			}
		}

		// Token: 0x06034388 RID: 213896 RVA: 0x00C42205 File Offset: 0x00C40405
		protected override void OnAfterShow()
		{
			QuestMultiLineMapPanel mapPanel = this.MapPanel;
			if (mapPanel == null)
			{
				return;
			}
			mapPanel.MapShow();
		}

		// Token: 0x06034389 RID: 213897 RVA: 0x00C42217 File Offset: 0x00C40417
		protected override void OnBeforeHide()
		{
			QuestMultiLineMapPanel mapPanel = this.MapPanel;
			if (mapPanel == null)
			{
				return;
			}
			mapPanel.MapHide();
		}

		// Token: 0x0603438A RID: 213898 RVA: 0x00C42229 File Offset: 0x00C40429
		protected override void OnTick(float delta)
		{
			QuestMultiLineMapPanel mapPanel = this.MapPanel;
			if (mapPanel == null)
			{
				return;
			}
			mapPanel.OnTick(delta);
		}

		// Token: 0x0603438B RID: 213899 RVA: 0x00C4223C File Offset: 0x00C4043C
		private UniTask RefreshView()
		{
			QuestMultiLineView.<RefreshView>d__30 <RefreshView>d__;
			<RefreshView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshView>d__.<>4__this = this;
			<RefreshView>d__.<>1__state = -1;
			<RefreshView>d__.<>t__builder.Start<QuestMultiLineView.<RefreshView>d__30>(ref <RefreshView>d__);
			return <RefreshView>d__.<>t__builder.Task;
		}

		// Token: 0x0603438C RID: 213900 RVA: 0x00C42280 File Offset: 0x00C40480
		[NullableContext(2)]
		private QuestMultiLineTimePointData ResolveCurrentTimePoint()
		{
			QuestMultiLineTimePointData curShowTimePoint = this.GetCurShowTimePoint();
			if (curShowTimePoint != null)
			{
				return curShowTimePoint;
			}
			Log.Instance.Error(ELogModule.QuestMultiLine, ELogAuthor.CCJ, "没有解锁的时间点", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (this.TimePoints == null || this.TimePoints.Count <= 0)
			{
				return null;
			}
			return this.TimePoints[0];
		}

		// Token: 0x0603438D RID: 213901 RVA: 0x00C422DC File Offset: 0x00C404DC
		private void RefreshBranchSelectView(QuestMultiLineTimePointData curShowTimePoint)
		{
			QuestMultiLineTimeLinePanel timeLinePanel = this.TimeLinePanel;
			if (timeLinePanel != null)
			{
				timeLinePanel.SetUiActive(false);
			}
			QuestMultiLineSelectPanel selectPanel = this.SelectPanel;
			if (selectPanel != null)
			{
				selectPanel.SetUiActive(true);
			}
			this.RefreshSelectPanel(curShowTimePoint);
			this.RefreshComponents(new List<QuestMultiLineComponentData>());
			this.RefreshAreaStatus(new Dictionary<int, bool>());
			this.MapPanel.RefreshFullScreenNiagara(false, curShowTimePoint.ScreenEffect);
		}

		// Token: 0x0603438E RID: 213902 RVA: 0x00C4233C File Offset: 0x00C4053C
		private UniTask RefreshNormalTimePointView(QuestMultiLineTimePointData curShowTimePoint)
		{
			QuestMultiLineView.<RefreshNormalTimePointView>d__33 <RefreshNormalTimePointView>d__;
			<RefreshNormalTimePointView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshNormalTimePointView>d__.<>4__this = this;
			<RefreshNormalTimePointView>d__.curShowTimePoint = curShowTimePoint;
			<RefreshNormalTimePointView>d__.<>1__state = -1;
			<RefreshNormalTimePointView>d__.<>t__builder.Start<QuestMultiLineView.<RefreshNormalTimePointView>d__33>(ref <RefreshNormalTimePointView>d__);
			return <RefreshNormalTimePointView>d__.<>t__builder.Task;
		}

		// Token: 0x0603438F RID: 213903 RVA: 0x00C42388 File Offset: 0x00C40588
		private UniTask RunSequencerAsync(QuestMultiLineTimePointData curShowTimePoint)
		{
			QuestMultiLineView.<RunSequencerAsync>d__34 <RunSequencerAsync>d__;
			<RunSequencerAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunSequencerAsync>d__.<>4__this = this;
			<RunSequencerAsync>d__.curShowTimePoint = curShowTimePoint;
			<RunSequencerAsync>d__.<>1__state = -1;
			<RunSequencerAsync>d__.<>t__builder.Start<QuestMultiLineView.<RunSequencerAsync>d__34>(ref <RunSequencerAsync>d__);
			return <RunSequencerAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034390 RID: 213904 RVA: 0x00C423D4 File Offset: 0x00C405D4
		private void RefreshTaskDescPanel(QuestMultiLineTimePointData curShowTimePoint, bool playAnim = true)
		{
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			if (QuestMultiLineUtils.IsBranchSelectTimePoint(curShowTimePoint))
			{
				item.SetUIActive(false);
				return;
			}
			string title = curShowTimePoint.Title;
			string desc = curShowTimePoint.Desc;
			if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(desc))
			{
				item.SetUIActive(false);
				return;
			}
			item.SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), title, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), desc, Array.Empty<object>());
			if (playAnim)
			{
				base.PlaySequenceAsync("Tips_In", false, false, null);
			}
		}

		// Token: 0x06034391 RID: 213905 RVA: 0x00C42474 File Offset: 0x00C40674
		private UniTask RunBranchSelectSequencerAsync(List<QuestMultiLineComponentData> components, List<int> fightAreas)
		{
			QuestMultiLineView.<RunBranchSelectSequencerAsync>d__36 <RunBranchSelectSequencerAsync>d__;
			<RunBranchSelectSequencerAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunBranchSelectSequencerAsync>d__.<>4__this = this;
			<RunBranchSelectSequencerAsync>d__.components = components;
			<RunBranchSelectSequencerAsync>d__.fightAreas = fightAreas;
			<RunBranchSelectSequencerAsync>d__.<>1__state = -1;
			<RunBranchSelectSequencerAsync>d__.<>t__builder.Start<QuestMultiLineView.<RunBranchSelectSequencerAsync>d__36>(ref <RunBranchSelectSequencerAsync>d__);
			return <RunBranchSelectSequencerAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034392 RID: 213906 RVA: 0x00C424C8 File Offset: 0x00C406C8
		private UniTask RefreshMap()
		{
			QuestMultiLineView.<RefreshMap>d__37 <RefreshMap>d__;
			<RefreshMap>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshMap>d__.<>4__this = this;
			<RefreshMap>d__.<>1__state = -1;
			<RefreshMap>d__.<>t__builder.Start<QuestMultiLineView.<RefreshMap>d__37>(ref <RefreshMap>d__);
			return <RefreshMap>d__.<>t__builder.Task;
		}

		// Token: 0x06034393 RID: 213907 RVA: 0x00C4250C File Offset: 0x00C4070C
		private UniTask RefreshTimeLine(List<QuestMultiLineTimePointData> timePoints)
		{
			QuestMultiLineView.<RefreshTimeLine>d__38 <RefreshTimeLine>d__;
			<RefreshTimeLine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTimeLine>d__.<>4__this = this;
			<RefreshTimeLine>d__.timePoints = timePoints;
			<RefreshTimeLine>d__.<>1__state = -1;
			<RefreshTimeLine>d__.<>t__builder.Start<QuestMultiLineView.<RefreshTimeLine>d__38>(ref <RefreshTimeLine>d__);
			return <RefreshTimeLine>d__.<>t__builder.Task;
		}

		// Token: 0x06034394 RID: 213908 RVA: 0x00C42557 File Offset: 0x00C40757
		private void RefreshComponents(List<QuestMultiLineComponentData> components)
		{
			this.MapPanel.RefreshComponents(components);
			this.MapPanel.SetComponentFunction(new Action<QuestMultiLineComponentData>(this.OnClickComponent));
		}

		// Token: 0x06034395 RID: 213909 RVA: 0x00C4257D File Offset: 0x00C4077D
		private void RefreshAreaStatus(Dictionary<int, bool> fightAreas)
		{
			this.MapPanel.RefreshFightArea(fightAreas);
		}

		// Token: 0x06034396 RID: 213910 RVA: 0x00C4258C File Offset: 0x00C4078C
		private bool HasActiveFightArea(Dictionary<int, bool> fightAreas)
		{
			using (Dictionary<int, bool>.ValueCollection.Enumerator enumerator = fightAreas.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06034397 RID: 213911 RVA: 0x00C425E0 File Offset: 0x00C407E0
		private void ShowComponentTips(QuestMultiLineComponentData componentData)
		{
			QuestMultiLineTipsPanel tipsPanel = this.TipsPanel;
			if (tipsPanel != null)
			{
				tipsPanel.RefreshTips(componentData);
			}
			if (this.TipsPanel != null)
			{
				this.TipsPanel.ShowAndPlayStartAsync();
			}
		}

		// Token: 0x06034398 RID: 213912 RVA: 0x00C42608 File Offset: 0x00C40808
		private void RefreshSelectPanel(QuestMultiLineTimePointData timePointData)
		{
			this.SelectPanel.RefreshPanel(timePointData);
		}

		// Token: 0x06034399 RID: 213913 RVA: 0x00C42618 File Offset: 0x00C40818
		[NullableContext(2)]
		private QuestMultiLineTimePointData GetCurShowTimePoint()
		{
			if (this.TimePoints == null)
			{
				return null;
			}
			foreach (QuestMultiLineTimePointData questMultiLineTimePointData in this.TimePoints)
			{
				if (questMultiLineTimePointData.Id == this.ShowTimePointId)
				{
					return questMultiLineTimePointData;
				}
			}
			for (int i = this.TimePoints.Count - 1; i >= 0; i--)
			{
				QuestMultiLineTimePointData questMultiLineTimePointData2 = this.TimePoints[i];
				if (questMultiLineTimePointData2.IsUnLock)
				{
					this.ShowTimePointId = questMultiLineTimePointData2.Id;
					return questMultiLineTimePointData2;
				}
			}
			return null;
		}

		// Token: 0x0603439A RID: 213914 RVA: 0x00C426C4 File Offset: 0x00C408C4
		private void OnHelpBtnClick()
		{
			if (this.Sequencer != null && this.Sequencer.IsPlaying)
			{
				return;
			}
			HelpController.Instance.OpenHelpById(617);
		}

		// Token: 0x0603439B RID: 213915 RVA: 0x00C426EB File Offset: 0x00C408EB
		private void OnCloseBtnClick()
		{
			QuestMultiLineAnimationSequencer sequencer = this.Sequencer;
			if (sequencer != null)
			{
				sequencer.Stop();
			}
			QuestMultiLineMapPanel mapPanel = this.MapPanel;
			if (mapPanel != null)
			{
				mapPanel.StopComponentMoveAlongPath();
			}
			base.CloseMe(null);
		}

		// Token: 0x0603439C RID: 213916 RVA: 0x00C42718 File Offset: 0x00C40918
		private void OnClickTimePoint(QuestMultiLineTimePointData timePoint)
		{
			if (this.Sequencer != null && this.Sequencer.IsPlaying)
			{
				return;
			}
			if (timePoint.Id == this.ShowTimePointId)
			{
				return;
			}
			this.PlayTimePointComponentAnim = false;
			this.ShowTimePointId = timePoint.Id;
			this.RefreshMap();
		}

		// Token: 0x0603439D RID: 213917 RVA: 0x00C42764 File Offset: 0x00C40964
		private void OnSelectBranch(int branchPageId, int branchId)
		{
			List<QuestMultiLineBranchData> branchData = this.GetCurShowTimePoint().BranchPageData.BranchData;
			QuestMultiLineBranchData questMultiLineBranchData = null;
			foreach (QuestMultiLineBranchData questMultiLineBranchData2 in branchData)
			{
				if (questMultiLineBranchData2.BranchId == branchId)
				{
					questMultiLineBranchData = questMultiLineBranchData2;
					break;
				}
			}
			if (questMultiLineBranchData == null || this.MapPanel == null)
			{
				return;
			}
			base.PlaySequenceAsync((branchId == branchData[0].BranchId) ? "Select_L" : "Select_R", false, false, null);
			List<int> list = new List<int>();
			foreach (int item in questMultiLineBranchData.FightingAreas)
			{
				list.Add(item);
			}
			this.BranchPlayPromise = this.RunBranchSelectSequencerAsync(questMultiLineBranchData.Components, list);
		}

		// Token: 0x0603439E RID: 213918 RVA: 0x00C42850 File Offset: 0x00C40A50
		private UniTask OnEnsureBranch(int branchPageId, int branchId)
		{
			QuestMultiLineView.<OnEnsureBranch>d__49 <OnEnsureBranch>d__;
			<OnEnsureBranch>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnEnsureBranch>d__.<>4__this = this;
			<OnEnsureBranch>d__.branchPageId = branchPageId;
			<OnEnsureBranch>d__.branchId = branchId;
			<OnEnsureBranch>d__.<>1__state = -1;
			<OnEnsureBranch>d__.<>t__builder.Start<QuestMultiLineView.<OnEnsureBranch>d__49>(ref <OnEnsureBranch>d__);
			return <OnEnsureBranch>d__.<>t__builder.Task;
		}

		// Token: 0x0603439F RID: 213919 RVA: 0x00C428A4 File Offset: 0x00C40AA4
		[NullableContext(2)]
		private QuestMultiLineComponentData FindBranchMainRole(int branchId)
		{
			QuestMultiLineTimePointData curShowTimePoint = this.GetCurShowTimePoint();
			List<QuestMultiLineBranchData> list;
			if (curShowTimePoint == null)
			{
				list = null;
			}
			else
			{
				QuestMultiLineBranchPageData branchPageData = curShowTimePoint.BranchPageData;
				list = ((branchPageData != null) ? branchPageData.BranchData : null);
			}
			List<QuestMultiLineBranchData> list2 = list;
			if (list2 == null)
			{
				return null;
			}
			foreach (QuestMultiLineBranchData questMultiLineBranchData in list2)
			{
				if (questMultiLineBranchData.BranchId == branchId)
				{
					foreach (QuestMultiLineComponentData questMultiLineComponentData in questMultiLineBranchData.Components)
					{
						if (questMultiLineComponentData.Type == 1)
						{
							return questMultiLineComponentData;
						}
					}
					return null;
				}
			}
			return null;
		}

		// Token: 0x060343A0 RID: 213920 RVA: 0x00C42970 File Offset: 0x00C40B70
		private void OnTimePointChange(List<QuestMultiLineTimePointData> timePoints)
		{
			this.TimePoints = timePoints;
			if (this.Sequencer != null && this.Sequencer.IsPlaying)
			{
				return;
			}
			this.RefreshView();
		}

		// Token: 0x060343A1 RID: 213921 RVA: 0x00C42998 File Offset: 0x00C40B98
		private void OnClickComponent(QuestMultiLineComponentData componentData)
		{
			if (this.Sequencer != null && this.Sequencer.IsPlaying)
			{
				return;
			}
			QuestMultiLineTimePointData curShowTimePoint = this.GetCurShowTimePoint();
			if (curShowTimePoint != null && QuestMultiLineUtils.IsBranchSelectTimePoint(curShowTimePoint))
			{
				return;
			}
			this.ShowComponentTips(componentData);
		}

		// Token: 0x060343A2 RID: 213922 RVA: 0x00C429D5 File Offset: 0x00C40BD5
		private void OnTipsHide()
		{
			QuestMultiLineMapPanel mapPanel = this.MapPanel;
			if (mapPanel == null)
			{
				return;
			}
			mapPanel.ClearAllComponentSelection();
		}

		// Token: 0x060343A3 RID: 213923 RVA: 0x00C429E7 File Offset: 0x00C40BE7
		private bool OnTipsHideSelfBtnIntercept()
		{
			QuestMultiLineMapPanel mapPanel = this.MapPanel;
			return mapPanel != null && mapPanel.TryClickComponentAtMousePosition();
		}

		// Token: 0x060343A4 RID: 213924 RVA: 0x00C429FC File Offset: 0x00C40BFC
		public UniTask PlayFightLightAsync()
		{
			QuestMultiLineView.<PlayFightLightAsync>d__55 <PlayFightLightAsync>d__;
			<PlayFightLightAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayFightLightAsync>d__.<>4__this = this;
			<PlayFightLightAsync>d__.<>1__state = -1;
			<PlayFightLightAsync>d__.<>t__builder.Start<QuestMultiLineView.<PlayFightLightAsync>d__55>(ref <PlayFightLightAsync>d__);
			return <PlayFightLightAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060343A5 RID: 213925 RVA: 0x00C42A40 File Offset: 0x00C40C40
		private UniTask PlayUiOutAsync()
		{
			QuestMultiLineView.<PlayUiOutAsync>d__56 <PlayUiOutAsync>d__;
			<PlayUiOutAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUiOutAsync>d__.<>4__this = this;
			<PlayUiOutAsync>d__.<>1__state = -1;
			<PlayUiOutAsync>d__.<>t__builder.Start<QuestMultiLineView.<PlayUiOutAsync>d__56>(ref <PlayUiOutAsync>d__);
			return <PlayUiOutAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060343A6 RID: 213926 RVA: 0x00C42A83 File Offset: 0x00C40C83
		public void DebugDrawPath(IReadOnlyList<Vector> points)
		{
		}

		// Token: 0x060343A7 RID: 213927 RVA: 0x00C42A85 File Offset: 0x00C40C85
		public void DebugPlayBranchConfirmAnim(int? branchId = null)
		{
		}

		// Token: 0x060343A8 RID: 213928 RVA: 0x00C42A88 File Offset: 0x00C40C88
		private UniTask RunDebugBranchConfirmAnim(int? branchId = null)
		{
			QuestMultiLineView.<RunDebugBranchConfirmAnim>d__59 <RunDebugBranchConfirmAnim>d__;
			<RunDebugBranchConfirmAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunDebugBranchConfirmAnim>d__.<>4__this = this;
			<RunDebugBranchConfirmAnim>d__.branchId = branchId;
			<RunDebugBranchConfirmAnim>d__.<>1__state = -1;
			<RunDebugBranchConfirmAnim>d__.<>t__builder.Start<QuestMultiLineView.<RunDebugBranchConfirmAnim>d__59>(ref <RunDebugBranchConfirmAnim>d__);
			return <RunDebugBranchConfirmAnim>d__.<>t__builder.Task;
		}

		// Token: 0x060343A9 RID: 213929 RVA: 0x00C42AD4 File Offset: 0x00C40CD4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				Log.Instance.Error(ELogModule.Guide, ELogAuthor.TZJ, "QuestMultiLineView 引导 ExtraParam 不能为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			if (configParams[0] == "TimePoint")
			{
				if (configParams.Length < 2)
				{
					Log.Instance.Error(ELogModule.Guide, ELogAuthor.TZJ, "QuestMultiLineView TimePoint 引导参数缺失", default(ReadOnlySpan<ValueTuple<string, object>>));
					return null;
				}
				int num;
				if (!int.TryParse(configParams[1], out num) || num <= 0)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Guide;
					ELogAuthor author = ELogAuthor.TZJ;
					string message = "QuestMultiLineView TimePoint 引导参数非法";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("param", configParams[1]);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return null;
				}
				QuestMultiLineTimeLinePanel timeLinePanel = this.TimeLinePanel;
				UUIItem uuiitem = (timeLinePanel != null) ? timeLinePanel.GetGuideTimePointUiItem(num - 1) : null;
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
			else
			{
				if (!(configParams[0] == "Component"))
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Guide;
					ELogAuthor author2 = ELogAuthor.TZJ;
					string message2 = "QuestMultiLineView 引导 ExtraParam 类型未知";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("key", configParams[0]);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return null;
				}
				if (configParams.Length < 2)
				{
					Log.Instance.Error(ELogModule.Guide, ELogAuthor.TZJ, "QuestMultiLineView Component 引导参数缺失", default(ReadOnlySpan<ValueTuple<string, object>>));
					return null;
				}
				int num2;
				if (!int.TryParse(configParams[1], out num2) || num2 <= 0)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Guide;
					ELogAuthor author3 = ELogAuthor.TZJ;
					string message3 = "QuestMultiLineView Component 引导参数非法";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("param", configParams[1]);
					instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					return null;
				}
				QuestMultiLineMapPanel mapPanel = this.MapPanel;
				UUIItem uuiitem2 = (mapPanel != null) ? mapPanel.GetGuideComponentUiItem(num2) : null;
				if (uuiitem2 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem2,
					uuiitem2
				};
			}
		}

		// Token: 0x0401BC3F RID: 113727
		private const int EARLY_PREPARE_TIME_POINT_ID = 2;

		// Token: 0x0401BC40 RID: 113728
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<QuestMultiLineTimePointData> TimePoints;

		// Token: 0x0401BC41 RID: 113729
		private int ShowTimePointId;

		// Token: 0x0401BC42 RID: 113730
		private bool PlayTimePointComponentAnim;

		// Token: 0x0401BC43 RID: 113731
		[Nullable(2)]
		private QuestMultiLineMapPanel MapPanel;

		// Token: 0x0401BC44 RID: 113732
		[Nullable(2)]
		private QuestMultiLineTimeLinePanel TimeLinePanel;

		// Token: 0x0401BC45 RID: 113733
		[Nullable(2)]
		private QuestMultiLineSelectPanel SelectPanel;

		// Token: 0x0401BC46 RID: 113734
		[Nullable(2)]
		private QuestMultiLineTipsPanel TipsPanel;

		// Token: 0x0401BC47 RID: 113735
		[Nullable(2)]
		private QuestMultiLineAnimationSequencer Sequencer;

		// Token: 0x0401BC48 RID: 113736
		private UniTask BranchPlayPromise = UniTask.CompletedTask;

		// Token: 0x0401BC49 RID: 113737
		private UniTask StartSequenceFinishedTask = UniTask.CompletedTask;

		// Token: 0x0401BC4A RID: 113738
		[Nullable(2)]
		private UniTaskCompletionSource StartSequenceFinishedResolve;

		// Token: 0x0401BC4B RID: 113739
		private bool EarlyPrepare;

		// Token: 0x0401BC4C RID: 113740
		[Nullable(2)]
		private QuestMultiLineTimePointData FirstShowTimePoint;
	}
}
