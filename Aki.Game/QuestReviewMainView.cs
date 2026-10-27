using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200267C RID: 9852
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewMainView : UiViewBase
{
	// Token: 0x06014300 RID: 82688 RVA: 0x00518ADF File Offset: 0x00516CDF
	public QuestReviewMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014301 RID: 82689 RVA: 0x00518AE8 File Offset: 0x00516CE8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(USpineSkeletonAnimationComponent));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06014302 RID: 82690 RVA: 0x00518BF6 File Offset: 0x00516DF6
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		this.WaitFusionFinish();
		this.WaitTabUnlock();
	}

	// Token: 0x06014303 RID: 82691 RVA: 0x00518C22 File Offset: 0x00516E22
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06014304 RID: 82692 RVA: 0x00518C40 File Offset: 0x00516E40
	protected override UniTask OnBeforeStartAsync()
	{
		QuestReviewMainView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestReviewMainView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014305 RID: 82693 RVA: 0x00518C84 File Offset: 0x00516E84
	protected override void OnStart()
	{
		object[] array = this.OpenParam as object[];
		if (array != null && array.Length >= 2)
		{
			this.Data = (array[0] as QuestReviewEntryData);
			this.UseLoopMusic = (array[1] as bool?).GetValueOrDefault();
		}
		this.LayoutQuestTree = new GenericLayout<QuestReviewLineItem, QuestReviewLineData>(base.GetVerticalLayout(1), new Func<QuestReviewLineItem>(this.CreateQuestLineItem), null, false, true);
		this.LayoutTabs = new GenericLayout<QuestReviewTabItem, QuestReviewTabData>(base.GetHorizontalLayout(3), new Func<QuestReviewTabItem>(this.CreateTabItem), null, false, true);
		QuestReviewLineData questReviewLineDataById = QuestReviewModel.Instance.GetQuestReviewLineDataById(3100);
		int num = (questReviewLineDataById.IsDestroy && questReviewLineDataById.IsFirstTimeDestroy) ? 3 : this.Data.TargetTab;
		this.CurrentTabData = QuestReviewModel.Instance.GetQuestReviewTabDataById(num);
		this.RefreshDelegate(new int?(num));
		QuestReviewController.Instance.AddViewRefreshDelegate(new Action<int?>(this.RefreshDelegate));
		if (this.Data.IsFirstEntry)
		{
			this.UiViewSequence.StartSequenceName = "FirstStart";
			this.UiViewSequence.AddSequenceFinishEvent("FirstStart", new Action<string>(this.OnFirstStartSeqEnd), false);
			return;
		}
		this.UiViewSequence.StartSequenceName = "Start";
	}

	// Token: 0x06014306 RID: 82694 RVA: 0x00518DBE File Offset: 0x00516FBE
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Emit(EEventName.OnQuestReviewMainViewBeforeHide);
	}

	// Token: 0x06014307 RID: 82695 RVA: 0x00518DD0 File Offset: 0x00516FD0
	protected override void OnBeforeDestroy()
	{
		QuestReviewController.Instance.RemoveViewRefreshDelegate(new Action<int?>(this.RefreshDelegate));
		this.UiViewSequence.RemoveSequenceFinishEvent("FirstStart", new Action<string>(this.OnFirstStartSeqEnd));
		QuestReviewTabData currentTabData = this.CurrentTabData;
		if (currentTabData != null && currentTabData.Id == 3)
		{
			if (!QuestReviewModel.Instance.HasQuestLineFused())
			{
				QuestReviewController.Instance.SetBurnFinish();
				QuestReviewController.Instance.SetFusionFinish();
				QuestReviewController.Instance.SetNewTabUnlockFinish();
				QuestReviewModel.Instance.SetQuestLineFused();
				QuestReviewLineData questReviewLineDataById = QuestReviewModel.Instance.GetQuestReviewLineDataById(3200);
				questReviewLineDataById.HasFused = true;
				questReviewLineDataById.IsFirstTimeShow = false;
			}
			this.CurrentTabData.IsFirstTimeShow = false;
		}
	}

	// Token: 0x06014308 RID: 82696 RVA: 0x00518E82 File Offset: 0x00517082
	public override bool GetLoopAudioEventSwitch()
	{
		return this.UseLoopMusic;
	}

	// Token: 0x06014309 RID: 82697 RVA: 0x00518E8C File Offset: 0x0051708C
	private void RefreshView()
	{
		this.RefreshTabs(this.Data);
		QuestReviewTreeData questReviewTreeDataById = QuestReviewModel.Instance.GetQuestReviewTreeDataById(this.CurrentTabData.QuestTree);
		this.RefreshQuestTree(questReviewTreeDataById);
	}

	// Token: 0x0601430A RID: 82698 RVA: 0x00518EC4 File Offset: 0x005170C4
	private void RefreshQuestTree(QuestReviewTreeData treeData)
	{
		List<QuestReviewLineData> list = new List<QuestReviewLineData>();
		foreach (int id in treeData.QuestLines)
		{
			QuestReviewLineData questReviewLineDataById = QuestReviewModel.Instance.GetQuestReviewLineDataById(id);
			if ((questReviewLineDataById == null || !questReviewLineDataById.IsFusionLine || !QuestReviewModel.Instance.HasQuestLineFused()) && questReviewLineDataById != null && questReviewLineDataById.IsShow)
			{
				list.Add(questReviewLineDataById);
			}
		}
		list.Sort((QuestReviewLineData a, QuestReviewLineData b) => a.DisplayOrder.CompareTo(b.DisplayOrder));
		this.LayoutQuestTree.RefreshByData(list, null, false);
	}

	// Token: 0x0601430B RID: 82699 RVA: 0x00518F80 File Offset: 0x00517180
	private void RefreshAfterBurn()
	{
		QuestReviewLineData questReviewLineDataById = QuestReviewModel.Instance.GetQuestReviewLineDataById(3100);
		questReviewLineDataById.IsFirstTimeDestroy = false;
		questReviewLineDataById.SkipAnim = true;
		QuestReviewLineData tempLineData = QuestReviewModel.Instance.GetTempLineData();
		QuestReviewLineData questReviewLineDataById2 = QuestReviewModel.Instance.GetQuestReviewLineDataById(3200);
		questReviewLineDataById2.IsFirstTimeShow = true;
		questReviewLineDataById2.HasFused = true;
		QuestReviewLineData tempLineData2 = QuestReviewModel.Instance.GetTempLineData();
		List<QuestReviewLineData> data = new List<QuestReviewLineData>
		{
			questReviewLineDataById,
			tempLineData,
			questReviewLineDataById2,
			tempLineData2
		};
		this.LayoutQuestTree.RefreshByData(data, null, false);
		QuestReviewModel.Instance.SetQuestLineFused();
	}

	// Token: 0x0601430C RID: 82700 RVA: 0x0051901C File Offset: 0x0051721C
	private void RefreshTabs(QuestReviewEntryData entryData)
	{
		List<QuestReviewTabData> list = new List<QuestReviewTabData>();
		foreach (int num in entryData.Tabs)
		{
			QuestReviewTabData questReviewTabDataById = QuestReviewModel.Instance.GetQuestReviewTabDataById(num);
			if (questReviewTabDataById != null && questReviewTabDataById.IsUnlocked)
			{
				questReviewTabDataById.IsSelected = (num == this.CurrentTabData.Id);
				list.Add(questReviewTabDataById);
			}
		}
		this.LayoutTabs.GetRootUiItem().SetUIActive(list.Count > 1);
		if (list.Count <= 2)
		{
			foreach (QuestReviewTabData questReviewTabData in list)
			{
				questReviewTabData.IsFirstTimeShow = false;
			}
		}
		this.LayoutTabs.RefreshByData(list, null, false);
	}

	// Token: 0x0601430D RID: 82701 RVA: 0x00519108 File Offset: 0x00517308
	private UniTask WaitFusionFinish()
	{
		QuestReviewMainView.<WaitFusionFinish>d__19 <WaitFusionFinish>d__;
		<WaitFusionFinish>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitFusionFinish>d__.<>1__state = -1;
		<WaitFusionFinish>d__.<>t__builder.Start<QuestReviewMainView.<WaitFusionFinish>d__19>(ref <WaitFusionFinish>d__);
		return <WaitFusionFinish>d__.<>t__builder.Task;
	}

	// Token: 0x0601430E RID: 82702 RVA: 0x00519144 File Offset: 0x00517344
	private UniTask WaitTabUnlock()
	{
		QuestReviewMainView.<WaitTabUnlock>d__20 <WaitTabUnlock>d__;
		<WaitTabUnlock>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitTabUnlock>d__.<>1__state = -1;
		<WaitTabUnlock>d__.<>t__builder.Start<QuestReviewMainView.<WaitTabUnlock>d__20>(ref <WaitTabUnlock>d__);
		return <WaitTabUnlock>d__.<>t__builder.Task;
	}

	// Token: 0x0601430F RID: 82703 RVA: 0x00519180 File Offset: 0x00517380
	private void RefreshDelegate(int? tabId = 0)
	{
		int? num = tabId;
		int num2 = 0;
		if (num.GetValueOrDefault() > num2 & num != null)
		{
			this.CurrentTabData = QuestReviewModel.Instance.GetQuestReviewTabDataById(tabId.Value);
		}
		if (tabId.GetValueOrDefault() == -1)
		{
			this.RefreshAfterBurn();
			return;
		}
		if (tabId.GetValueOrDefault() == 3 && !QuestReviewModel.Instance.HasQuestLineFused())
		{
			base.GetHorizontalLayout(3).RootUIComp.Get().SetUIActive(false);
			QuestReviewTreeData questReviewTreeDataById = QuestReviewModel.Instance.GetQuestReviewTreeDataById(this.CurrentTabData.QuestTree);
			this.RefreshQuestTree(questReviewTreeDataById);
			return;
		}
		if (tabId.GetValueOrDefault() == -2)
		{
			QuestReviewEntryData data = this.Data;
			foreach (int id in (((data != null) ? data.Tabs : null) ?? Array.Empty<int>()))
			{
				QuestReviewTabData questReviewTabDataById = QuestReviewModel.Instance.GetQuestReviewTabDataById(id);
				if (questReviewTabDataById != null)
				{
					questReviewTabDataById.IsFirstTimeShow = false;
				}
			}
			this.CurrentTabData = QuestReviewModel.Instance.GetQuestReviewTabDataById(3);
			this.CurrentTabData.IsFirstTimeShow = true;
			base.GetHorizontalLayout(3).RootUIComp.Get().SetUIActive(true);
			this.RefreshTabs(this.Data);
			return;
		}
		this.RefreshView();
	}

	// Token: 0x06014310 RID: 82704 RVA: 0x005192E4 File Offset: 0x005174E4
	private QuestReviewLineItem CreateQuestLineItem()
	{
		return new QuestReviewLineItem();
	}

	// Token: 0x06014311 RID: 82705 RVA: 0x005192EB File Offset: 0x005174EB
	private QuestReviewTabItem CreateTabItem()
	{
		return new QuestReviewTabItem();
	}

	// Token: 0x06014312 RID: 82706 RVA: 0x005192F2 File Offset: 0x005174F2
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "Start")
		{
			base.GetSpine(5).SetAnimation(0, param, false);
			return;
		}
		if (param == "Open")
		{
			base.GetSpine(6).SetAnimation(0, param, false);
		}
	}

	// Token: 0x06014313 RID: 82707 RVA: 0x0051932F File Offset: 0x0051752F
	private void OnFirstStartSeqEnd(string _)
	{
		QuestReviewEntryData data = this.Data;
		if (data != null && data.IsFirstEntry)
		{
			this.Data.IsFirstEntry = false;
		}
	}

	// Token: 0x040097FB RID: 38907
	private GenericLayout<QuestReviewLineItem, QuestReviewLineData> LayoutQuestTree;

	// Token: 0x040097FC RID: 38908
	private GenericLayout<QuestReviewTabItem, QuestReviewTabData> LayoutTabs;

	// Token: 0x040097FD RID: 38909
	private PopupCaptionItem Caption;

	// Token: 0x040097FE RID: 38910
	private QuestReviewEntryData Data;

	// Token: 0x040097FF RID: 38911
	private bool UseLoopMusic;

	// Token: 0x04009800 RID: 38912
	private QuestReviewTabData CurrentTabData;

	// Token: 0x02008CC3 RID: 36035
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402DAEA RID: 187114
		public const int ItemCaption = 0;

		// Token: 0x0402DAEB RID: 187115
		public const int LayoutQuestTree = 1;

		// Token: 0x0402DAEC RID: 187116
		public const int ItemQuestLine = 2;

		// Token: 0x0402DAED RID: 187117
		public const int LayoutTab = 3;

		// Token: 0x0402DAEE RID: 187118
		public const int ItemTab = 4;

		// Token: 0x0402DAEF RID: 187119
		public const int SpineBookA = 5;

		// Token: 0x0402DAF0 RID: 187120
		public const int SpineBookB = 6;
	}
}
