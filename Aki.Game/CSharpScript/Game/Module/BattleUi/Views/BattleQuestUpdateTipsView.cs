using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D67 RID: 23911
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleQuestUpdateTipsView : BattleChildView
	{
		// Token: 0x0603CB56 RID: 248662 RVA: 0x00E9395C File Offset: 0x00E91B5C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			if (!Info.Instance.IsInTouch())
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(5, typeof(UUIItem)));
			}
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickTrack));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603CB57 RID: 248663 RVA: 0x00E93A8C File Offset: 0x00E91C8C
		protected override void OnStart()
		{
			base.GetText(0).OnSelfLanguageChange.Bind(new Action(this.UpdateQuestName));
			base.GetText(1).OnSelfLanguageChange.Bind(new Action(this.UpdateNodeDescribe));
			base.GetItem(4).SetUIActive(true);
		}

		// Token: 0x0603CB58 RID: 248664 RVA: 0x00E93AE0 File Offset: 0x00E91CE0
		[NullableContext(2)]
		protected override UniTask InitializeAsync(object param = null)
		{
			BattleQuestUpdateTipsView.<InitializeAsync>d__8 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<BattleQuestUpdateTipsView.<InitializeAsync>d__8>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CB59 RID: 248665 RVA: 0x00E93B23 File Offset: 0x00E91D23
		protected override void OnBeforeDestroy()
		{
			base.GetText(0).OnSelfLanguageChange.Unbind();
			base.GetText(1).OnSelfLanguageChange.Unbind();
			InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0603CB5A RID: 248666 RVA: 0x00E93B62 File Offset: 0x00E91D62
		public void OnBeforePlayShowSequence(QuestUpdateTipsShowData info)
		{
			this.UpdateData(info);
			InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			InputDistributeController.Instance.BindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0603CB5B RID: 248667 RVA: 0x00E93BA1 File Offset: 0x00E91DA1
		public void OnBeforePlayHideSequence()
		{
			InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			this.IsPlayCloseSequence = true;
		}

		// Token: 0x0603CB5C RID: 248668 RVA: 0x00E93BC8 File Offset: 0x00E91DC8
		public void OnAfterPlayHideSequence()
		{
			InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			this.IsPlayCloseSequence = false;
			if (!this.IsClicked)
			{
				QuestUpdateTipsShowData showData = this.ShowData;
				if (showData != null && showData.IsNewQuest)
				{
					QuestNewController.Instance.TryChangeTrackedQuest(QuestNewModel.Instance.CurShowUpdateTipsQuest);
				}
			}
			QuestNewModel.Instance.CurShowUpdateTipsQuest = 0;
			this.ShowData = null;
		}

		// Token: 0x0603CB5D RID: 248669 RVA: 0x00E93C3A File Offset: 0x00E91E3A
		public void UpdateData(QuestUpdateTipsShowData info)
		{
			this.IsClicked = false;
			this.RefreshUi(info);
			this.OpenNewMissionTipsView();
			QuestUpdateTipsShowData showData = this.ShowData;
			if (showData != null && showData.IsNewQuest)
			{
				QuestNewModel.Instance.CurShowUpdateTipsQuest = info.QuestId;
			}
		}

		// Token: 0x0603CB5E RID: 248670 RVA: 0x00E93C74 File Offset: 0x00E91E74
		public void RefreshUi(QuestUpdateTipsShowData data)
		{
			this.ShowData = data;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "BattleQuestUpdateTipsView:界面刷新";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("任务Id", this.ShowData.QuestId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.SetIcon();
			this.UpdateQuestName();
			this.UpdateNodeDescribe();
		}

		// Token: 0x0603CB5F RID: 248671 RVA: 0x00E93CD0 File Offset: 0x00E91ED0
		private void SetIcon()
		{
			QuestUpdateTipsShowData showData = this.ShowData;
			int markId = (showData != null) ? showData.MissionViewShowData.TrackIconConfigId : 0;
			string questTypeMark = QuestNewConfig.Instance.GetQuestTypeMark(markId);
			UUISprite sprite = base.GetSprite(2);
			this.SetSpriteByPath(questTypeMark, sprite, false, null, null);
		}

		// Token: 0x0603CB60 RID: 248672 RVA: 0x00E93D1C File Offset: 0x00E91F1C
		private void UpdateQuestName()
		{
			if (this.ShowData == null)
			{
				return;
			}
			global::Quest quest = QuestNewModel.Instance.GetQuest(this.ShowData.QuestId);
			if (quest == null)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "BattleQuestUpdateTipsView:UpdateQuestName";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("QuestName", quest.Name);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.GetText(0).SetText(quest.Name, true);
		}

		// Token: 0x0603CB61 RID: 248673 RVA: 0x00E93D8C File Offset: 0x00E91F8C
		private void UpdateNodeDescribe()
		{
			if (this.ShowData == null)
			{
				return;
			}
			string text = string.Empty;
			if (this.ShowData.MissionViewShowData.MainStepInfo != null)
			{
				text = MissionViewStepTextUtil.GetStepTextByConfig(this.ShowData.MissionViewShowData.Id, this.ShowData.MissionViewShowData.MainStepInfo);
			}
			else if (this.ShowData.MissionViewShowData.DataSource == EMissionItemViewDataSource.BehaviorTree)
			{
				text = GeneralLogicTreeController.Instance.GetNodeTrackText(this.ShowData.MissionViewShowData.Id, this.ShowData.NodeId);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "BattleQuestUpdateTipsView:UpdateNodeDescribe";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("describe", text);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.GetText(1).SetText(text, true);
		}

		// Token: 0x0603CB62 RID: 248674 RVA: 0x00E93E50 File Offset: 0x00E92050
		private void OpenNewMissionTipsView()
		{
			if (this.ShowData == null)
			{
				return;
			}
			EventSystem.Instance.Emit<bool>(EEventName.MissionUpdate, this.ShowData.IsNewQuest);
			if (!this.ShowData.IsNewQuest)
			{
				return;
			}
			global::Quest quest = QuestNewModel.Instance.GetQuest(this.ShowData.QuestId);
			EQuest? equest = (quest != null) ? new EQuest?(quest.Type) : null;
			if (equest == null)
			{
				return;
			}
			int? newTipsShowTime = QuestNewConfig.Instance.GetNewTipsShowTime((int)equest.Value);
			int num = 0;
			if (newTipsShowTime.GetValueOrDefault() > num & newTipsShowTime != null)
			{
				UiManager.Instance.OpenView(EUiViewName.NewMissionTips, this.ShowData.QuestId, null);
			}
		}

		// Token: 0x0603CB63 RID: 248675 RVA: 0x00E93F10 File Offset: 0x00E92110
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType != InputDistributeDefine.EActionType.Release)
			{
				return;
			}
			this.OnClickTrack();
		}

		// Token: 0x0603CB64 RID: 248676 RVA: 0x00E93F20 File Offset: 0x00E92120
		private void OnClickTrack()
		{
			if (this.LockClickTrack || this.ShowData == null || this.ShowData.QuestId == 0)
			{
				return;
			}
			this.LockClickTrack = true;
			if (!this.IsClicked)
			{
				EventSystem.Instance.Emit(EEventName.QuestUpdateTipsClickTrack);
				this.IsClicked = true;
			}
			QuestNewController.Instance.RequestTrackQuest(this.ShowData.QuestId, true, ERequestTrackOperate.Manual, ESetTrackReason.None, delegate
			{
				this.LockClickTrack = false;
			});
		}

		// Token: 0x0603CB65 RID: 248677 RVA: 0x00E93F96 File Offset: 0x00E92196
		public bool IsClosing()
		{
			return this.IsPlayCloseSequence;
		}

		// Token: 0x0401F9F7 RID: 129527
		[Nullable(2)]
		private CombineKeyItem KeyItem;

		// Token: 0x0401F9F8 RID: 129528
		[Nullable(2)]
		private QuestUpdateTipsShowData ShowData;

		// Token: 0x0401F9F9 RID: 129529
		private bool LockClickTrack;

		// Token: 0x0401F9FA RID: 129530
		private bool IsPlayCloseSequence;

		// Token: 0x0401F9FB RID: 129531
		private bool IsClicked;

		// Token: 0x0200C018 RID: 49176
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039F74 RID: 237428
			QuestNameText,
			// Token: 0x04039F75 RID: 237429
			NodeDescribeText,
			// Token: 0x04039F76 RID: 237430
			QuestIcon,
			// Token: 0x04039F77 RID: 237431
			TrackBtn,
			// Token: 0x04039F78 RID: 237432
			Step1Item,
			// Token: 0x04039F79 RID: 237433
			KeyItem
		}
	}
}
