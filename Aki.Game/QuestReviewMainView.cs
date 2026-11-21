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

// Token: 0x02001B67 RID: 7015
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewMainView : UiViewBase
{
	// Token: 0x060117E2 RID: 71650 RVA: 0x00527817 File Offset: 0x00525A17
	public QuestReviewMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060117E3 RID: 71651 RVA: 0x00527820 File Offset: 0x00525A20
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

	// Token: 0x060117E4 RID: 71652 RVA: 0x0052792E File Offset: 0x00525B2E
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		this.WaitFusionFinish();
		this.WaitTabUnlock();
	}

	// Token: 0x060117E5 RID: 71653 RVA: 0x0052795A File Offset: 0x00525B5A
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x060117E6 RID: 71654 RVA: 0x00527978 File Offset: 0x00525B78
	protected override UniTask OnBeforeStartAsync()
	{
		QuestReviewMainView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestReviewMainView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060117E7 RID: 71655 RVA: 0x005279BC File Offset: 0x00525BBC
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

	// Token: 0x060117E8 RID: 71656 RVA: 0x00527AF6 File Offset: 0x00525CF6
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Emit(EEventName.OnQuestReviewMainViewBeforeHide);
	}

	// Token: 0x060117E9 RID: 71657 RVA: 0x00527B08 File Offset: 0x00525D08
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

	// Token: 0x060117EA RID: 71658 RVA: 0x00527BBA File Offset: 0x00525DBA
	public override bool GetBgmSwitch()
	{
		return this.UseLoopMusic;
	}

	// Token: 0x060117EB RID: 71659 RVA: 0x00527BC4 File Offset: 0x00525DC4
	private void RefreshView()
	{
		this.RefreshTabs(this.Data);
		QuestReviewTreeData questReviewTreeDataById = QuestReviewModel.Instance.GetQuestReviewTreeDataById(this.CurrentTabData.QuestTree);
		this.RefreshQuestTree(questReviewTreeDataById);
	}

	// Token: 0x060117EC RID: 71660 RVA: 0x00527BFC File Offset: 0x00525DFC
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

	// Token: 0x060117ED RID: 71661 RVA: 0x00527CB8 File Offset: 0x00525EB8
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

	// Token: 0x060117EE RID: 71662 RVA: 0x00527D54 File Offset: 0x00525F54
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

	// Token: 0x060117EF RID: 71663 RVA: 0x00527E40 File Offset: 0x00526040
	private UniTask WaitFusionFinish()
	{
		QuestReviewMainView.<WaitFusionFinish>d__19 <WaitFusionFinish>d__;
		<WaitFusionFinish>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitFusionFinish>d__.<>1__state = -1;
		<WaitFusionFinish>d__.<>t__builder.Start<QuestReviewMainView.<WaitFusionFinish>d__19>(ref <WaitFusionFinish>d__);
		return <WaitFusionFinish>d__.<>t__builder.Task;
	}

	// Token: 0x060117F0 RID: 71664 RVA: 0x00527E7C File Offset: 0x0052607C
	private UniTask WaitTabUnlock()
	{
		QuestReviewMainView.<WaitTabUnlock>d__20 <WaitTabUnlock>d__;
		<WaitTabUnlock>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitTabUnlock>d__.<>1__state = -1;
		<WaitTabUnlock>d__.<>t__builder.Start<QuestReviewMainView.<WaitTabUnlock>d__20>(ref <WaitTabUnlock>d__);
		return <WaitTabUnlock>d__.<>t__builder.Task;
	}

	// Token: 0x060117F1 RID: 71665 RVA: 0x00527EB8 File Offset: 0x005260B8
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

	// Token: 0x060117F2 RID: 71666 RVA: 0x0052801C File Offset: 0x0052621C
	private QuestReviewLineItem CreateQuestLineItem()
	{
		return new QuestReviewLineItem();
	}

	// Token: 0x060117F3 RID: 71667 RVA: 0x00528023 File Offset: 0x00526223
	private QuestReviewTabItem CreateTabItem()
	{
		return new QuestReviewTabItem();
	}

	// Token: 0x060117F4 RID: 71668 RVA: 0x0052802A File Offset: 0x0052622A
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

	// Token: 0x060117F5 RID: 71669 RVA: 0x00528067 File Offset: 0x00526267
	private void OnFirstStartSeqEnd(string _)
	{
		QuestReviewEntryData data = this.Data;
		if (data != null && data.IsFirstEntry)
		{
			this.Data.IsFirstEntry = false;
		}
	}

	// Token: 0x04009953 RID: 39251
	private GenericLayout<QuestReviewLineItem, QuestReviewLineData> LayoutQuestTree;

	// Token: 0x04009954 RID: 39252
	private GenericLayout<QuestReviewTabItem, QuestReviewTabData> LayoutTabs;

	// Token: 0x04009955 RID: 39253
	private PopupCaptionItem Caption;

	// Token: 0x04009956 RID: 39254
	private QuestReviewEntryData Data;

	// Token: 0x04009957 RID: 39255
	private bool UseLoopMusic;

	// Token: 0x04009958 RID: 39256
	private QuestReviewTabData CurrentTabData;

	// Token: 0x02007E4C RID: 32332
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028E01 RID: 167425
		public const int ItemCaption = 0;

		// Token: 0x04028E02 RID: 167426
		public const int LayoutQuestTree = 1;

		// Token: 0x04028E03 RID: 167427
		public const int ItemQuestLine = 2;

		// Token: 0x04028E04 RID: 167428
		public const int LayoutTab = 3;

		// Token: 0x04028E05 RID: 167429
		public const int ItemTab = 4;

		// Token: 0x04028E06 RID: 167430
		public const int SpineBookA = 5;

		// Token: 0x04028E07 RID: 167431
		public const int SpineBookB = 6;
	}
}
