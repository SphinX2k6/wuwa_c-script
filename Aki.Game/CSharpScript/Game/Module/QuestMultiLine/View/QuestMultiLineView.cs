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
	// Token: 0x02003F7A RID: 16250
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineView : UiTickViewBase
	{
		// Token: 0x060291EA RID: 168426 RVA: 0x00B8B57A File Offset: 0x00B8977A
		public QuestMultiLineView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17005331 RID: 21297
		// (get) Token: 0x060291EB RID: 168427 RVA: 0x00B8B599 File Offset: 0x00B89799
		[Nullable(2)]
		public new QuestMultiLineViewParams OpenParam
		{
			[NullableContext(2)]
			get
			{
				return this.OpenParam as QuestMultiLineViewParams;
			}
		}

		// Token: 0x060291EC RID: 168428 RVA: 0x00B8B5A8 File Offset: 0x00B897A8
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

		// Token: 0x060291ED RID: 168429 RVA: 0x00B8B670 File Offset: 0x00B89870
		protected override UniTask OnBeforeStartAsync()
		{
			QuestMultiLineView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<QuestMultiLineView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060291EE RID: 168430 RVA: 0x00B8B6B4 File Offset: 0x00B898B4
		private UniTask PrepareViewAsync()
		{
			QuestMultiLineView.<PrepareViewAsync>d__19 <PrepareViewAsync>d__;
			<PrepareViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrepareViewAsync>d__.<>4__this = this;
			<PrepareViewAsync>d__.<>1__state = -1;
			<PrepareViewAsync>d__.<>t__builder.Start<QuestMultiLineView.<PrepareViewAsync>d__19>(ref <PrepareViewAsync>d__);
			return <PrepareViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060291EF RID: 168431 RVA: 0x00B8B6F8 File Offset: 0x00B898F8
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

		// Token: 0x060291F0 RID: 168432 RVA: 0x00B8B744 File Offset: 0x00B89944
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

		// Token: 0x060291F1 RID: 168433 RVA: 0x00B8B800 File Offset: 0x00B89A00
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

		// Token: 0x060291F2 RID: 168434 RVA: 0x00B8B84B File Offset: 0x00B89A4B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<List<QuestMultiLineTimePointData>>(EEventName.QuestMultiLineTimePointChange, new Action<List<QuestMultiLineTimePointData>>(this.OnTimePointChange));
		}

		// Token: 0x060291F3 RID: 168435 RVA: 0x00B8B86C File Offset: 0x00B89A6C
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

		// Token: 0x060291F4 RID: 168436 RVA: 0x00B8B8BF File Offset: 0x00B89ABF
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

		// Token: 0x060291F5 RID: 168437 RVA: 0x00B8B8F0 File Offset: 0x00B89AF0
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

		// Token: 0x060291F6 RID: 168438 RVA: 0x00B8B9B1 File Offset: 0x00B89BB1
		protected override void OnAfterShow()
		{
			QuestMultiLineMapPanel mapPanel = this.MapPanel;
			if (mapPanel == null)
			{
				return;
			}
			mapPanel.MapShow();
		}

		// Token: 0x060291F7 RID: 168439 RVA: 0x00B8B9C3 File Offset: 0x00B89BC3
		protected override void OnBeforeHide()
		{
			QuestMultiLineMapPanel mapPanel = this.MapPanel;
			if (mapPanel == null)
			{
				return;
			}
			mapPanel.MapHide();
		}

		// Token: 0x060291F8 RID: 168440 RVA: 0x00B8B9D5 File Offset: 0x00B89BD5
		protected override void OnTick(float delta)
		{
			QuestMultiLineMapPanel mapPanel = this.MapPanel;
			if (mapPanel == null)
			{
				return;
			}
			mapPanel.OnTick(delta);
		}

		// Token: 0x060291F9 RID: 168441 RVA: 0x00B8B9E8 File Offset: 0x00B89BE8
		private UniTask RefreshView()
		{
			QuestMultiLineView.<RefreshView>d__30 <RefreshView>d__;
			<RefreshView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshView>d__.<>4__this = this;
			<RefreshView>d__.<>1__state = -1;
			<RefreshView>d__.<>t__builder.Start<QuestMultiLineView.<RefreshView>d__30>(ref <RefreshView>d__);
			return <RefreshView>d__.<>t__builder.Task;
		}

		// Token: 0x060291FA RID: 168442 RVA: 0x00B8BA2C File Offset: 0x00B89C2C
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

		// Token: 0x060291FB RID: 168443 RVA: 0x00B8BA88 File Offset: 0x00B89C88
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

		// Token: 0x060291FC RID: 168444 RVA: 0x00B8BAE8 File Offset: 0x00B89CE8
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

		// Token: 0x060291FD RID: 168445 RVA: 0x00B8BB34 File Offset: 0x00B89D34
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

		// Token: 0x060291FE RID: 168446 RVA: 0x00B8BB80 File Offset: 0x00B89D80
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

		// Token: 0x060291FF RID: 168447 RVA: 0x00B8BC20 File Offset: 0x00B89E20
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

		// Token: 0x06029200 RID: 168448 RVA: 0x00B8BC74 File Offset: 0x00B89E74
		private UniTask RefreshMap()
		{
			QuestMultiLineView.<RefreshMap>d__37 <RefreshMap>d__;
			<RefreshMap>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshMap>d__.<>4__this = this;
			<RefreshMap>d__.<>1__state = -1;
			<RefreshMap>d__.<>t__builder.Start<QuestMultiLineView.<RefreshMap>d__37>(ref <RefreshMap>d__);
			return <RefreshMap>d__.<>t__builder.Task;
		}

		// Token: 0x06029201 RID: 168449 RVA: 0x00B8BCB8 File Offset: 0x00B89EB8
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

		// Token: 0x06029202 RID: 168450 RVA: 0x00B8BD03 File Offset: 0x00B89F03
		private void RefreshComponents(List<QuestMultiLineComponentData> components)
		{
			this.MapPanel.RefreshComponents(components);
			this.MapPanel.SetComponentFunction(new Action<QuestMultiLineComponentData>(this.OnClickComponent));
		}

		// Token: 0x06029203 RID: 168451 RVA: 0x00B8BD29 File Offset: 0x00B89F29
		private void RefreshAreaStatus(Dictionary<int, bool> fightAreas)
		{
			this.MapPanel.RefreshFightArea(fightAreas);
		}

		// Token: 0x06029204 RID: 168452 RVA: 0x00B8BD38 File Offset: 0x00B89F38
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

		// Token: 0x06029205 RID: 168453 RVA: 0x00B8BD8C File Offset: 0x00B89F8C
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

		// Token: 0x06029206 RID: 168454 RVA: 0x00B8BDB4 File Offset: 0x00B89FB4
		private void RefreshSelectPanel(QuestMultiLineTimePointData timePointData)
		{
			this.SelectPanel.RefreshPanel(timePointData);
		}

		// Token: 0x06029207 RID: 168455 RVA: 0x00B8BDC4 File Offset: 0x00B89FC4
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

		// Token: 0x06029208 RID: 168456 RVA: 0x00B8BE70 File Offset: 0x00B8A070
		private void OnHelpBtnClick()
		{
			if (this.Sequencer != null && this.Sequencer.IsPlaying)
			{
				return;
			}
			HelpController.Instance.OpenHelpById(617);
		}

		// Token: 0x06029209 RID: 168457 RVA: 0x00B8BE97 File Offset: 0x00B8A097
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

		// Token: 0x0602920A RID: 168458 RVA: 0x00B8BEC4 File Offset: 0x00B8A0C4
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

		// Token: 0x0602920B RID: 168459 RVA: 0x00B8BF10 File Offset: 0x00B8A110
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

		// Token: 0x0602920C RID: 168460 RVA: 0x00B8BFFC File Offset: 0x00B8A1FC
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

		// Token: 0x0602920D RID: 168461 RVA: 0x00B8C050 File Offset: 0x00B8A250
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

		// Token: 0x0602920E RID: 168462 RVA: 0x00B8C11C File Offset: 0x00B8A31C
		private void OnTimePointChange(List<QuestMultiLineTimePointData> timePoints)
		{
			this.TimePoints = timePoints;
			if (this.Sequencer != null && this.Sequencer.IsPlaying)
			{
				return;
			}
			this.RefreshView();
		}

		// Token: 0x0602920F RID: 168463 RVA: 0x00B8C144 File Offset: 0x00B8A344
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

		// Token: 0x06029210 RID: 168464 RVA: 0x00B8C181 File Offset: 0x00B8A381
		private void OnTipsHide()
		{
			QuestMultiLineMapPanel mapPanel = this.MapPanel;
			if (mapPanel == null)
			{
				return;
			}
			mapPanel.ClearAllComponentSelection();
		}

		// Token: 0x06029211 RID: 168465 RVA: 0x00B8C193 File Offset: 0x00B8A393
		private bool OnTipsHideSelfBtnIntercept()
		{
			QuestMultiLineMapPanel mapPanel = this.MapPanel;
			return mapPanel != null && mapPanel.TryClickComponentAtMousePosition();
		}

		// Token: 0x06029212 RID: 168466 RVA: 0x00B8C1A8 File Offset: 0x00B8A3A8
		public UniTask PlayFightLightAsync()
		{
			QuestMultiLineView.<PlayFightLightAsync>d__55 <PlayFightLightAsync>d__;
			<PlayFightLightAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayFightLightAsync>d__.<>4__this = this;
			<PlayFightLightAsync>d__.<>1__state = -1;
			<PlayFightLightAsync>d__.<>t__builder.Start<QuestMultiLineView.<PlayFightLightAsync>d__55>(ref <PlayFightLightAsync>d__);
			return <PlayFightLightAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029213 RID: 168467 RVA: 0x00B8C1EC File Offset: 0x00B8A3EC
		private UniTask PlayUiOutAsync()
		{
			QuestMultiLineView.<PlayUiOutAsync>d__56 <PlayUiOutAsync>d__;
			<PlayUiOutAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUiOutAsync>d__.<>4__this = this;
			<PlayUiOutAsync>d__.<>1__state = -1;
			<PlayUiOutAsync>d__.<>t__builder.Start<QuestMultiLineView.<PlayUiOutAsync>d__56>(ref <PlayUiOutAsync>d__);
			return <PlayUiOutAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029214 RID: 168468 RVA: 0x00B8C22F File Offset: 0x00B8A42F
		public void DebugDrawPath(IReadOnlyList<Vector> points)
		{
		}

		// Token: 0x06029215 RID: 168469 RVA: 0x00B8C231 File Offset: 0x00B8A431
		public void DebugPlayBranchConfirmAnim(int? branchId = null)
		{
		}

		// Token: 0x06029216 RID: 168470 RVA: 0x00B8C234 File Offset: 0x00B8A434
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

		// Token: 0x06029217 RID: 168471 RVA: 0x00B8C280 File Offset: 0x00B8A480
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

		// Token: 0x04016614 RID: 91668
		private const int EARLY_PREPARE_TIME_POINT_ID = 2;

		// Token: 0x04016615 RID: 91669
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<QuestMultiLineTimePointData> TimePoints;

		// Token: 0x04016616 RID: 91670
		private int ShowTimePointId;

		// Token: 0x04016617 RID: 91671
		private bool PlayTimePointComponentAnim;

		// Token: 0x04016618 RID: 91672
		[Nullable(2)]
		private QuestMultiLineMapPanel MapPanel;

		// Token: 0x04016619 RID: 91673
		[Nullable(2)]
		private QuestMultiLineTimeLinePanel TimeLinePanel;

		// Token: 0x0401661A RID: 91674
		[Nullable(2)]
		private QuestMultiLineSelectPanel SelectPanel;

		// Token: 0x0401661B RID: 91675
		[Nullable(2)]
		private QuestMultiLineTipsPanel TipsPanel;

		// Token: 0x0401661C RID: 91676
		[Nullable(2)]
		private QuestMultiLineAnimationSequencer Sequencer;

		// Token: 0x0401661D RID: 91677
		private UniTask BranchPlayPromise = UniTask.CompletedTask;

		// Token: 0x0401661E RID: 91678
		private UniTask StartSequenceFinishedTask = UniTask.CompletedTask;

		// Token: 0x0401661F RID: 91679
		[Nullable(2)]
		private UniTaskCompletionSource StartSequenceFinishedResolve;

		// Token: 0x04016620 RID: 91680
		private bool EarlyPrepare;

		// Token: 0x04016621 RID: 91681
		[Nullable(2)]
		private QuestMultiLineTimePointData FirstShowTimePoint;
	}
}
