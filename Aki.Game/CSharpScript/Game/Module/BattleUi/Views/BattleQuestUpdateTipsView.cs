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
	// Token: 0x02004D49 RID: 19785
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleQuestUpdateTipsView : BattleChildView
	{
		// Token: 0x06031AB2 RID: 203442 RVA: 0x00DE41A4 File Offset: 0x00DE23A4
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

		// Token: 0x06031AB3 RID: 203443 RVA: 0x00DE42D4 File Offset: 0x00DE24D4
		protected override void OnStart()
		{
			base.GetText(0).OnSelfLanguageChange.Bind(new Action(this.UpdateQuestName));
			base.GetText(1).OnSelfLanguageChange.Bind(new Action(this.UpdateNodeDescribe));
			base.GetItem(4).SetUIActive(true);
		}

		// Token: 0x06031AB4 RID: 203444 RVA: 0x00DE4328 File Offset: 0x00DE2528
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

		// Token: 0x06031AB5 RID: 203445 RVA: 0x00DE436B File Offset: 0x00DE256B
		protected override void OnBeforeDestroy()
		{
			base.GetText(0).OnSelfLanguageChange.Unbind();
			base.GetText(1).OnSelfLanguageChange.Unbind();
			InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x06031AB6 RID: 203446 RVA: 0x00DE43AA File Offset: 0x00DE25AA
		public void OnBeforePlayShowSequence(QuestUpdateTipsShowData info)
		{
			this.UpdateData(info);
			InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			InputDistributeController.Instance.BindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x06031AB7 RID: 203447 RVA: 0x00DE43E9 File Offset: 0x00DE25E9
		public void OnBeforePlayHideSequence()
		{
			InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			this.IsPlayCloseSequence = true;
		}

		// Token: 0x06031AB8 RID: 203448 RVA: 0x00DE4410 File Offset: 0x00DE2610
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

		// Token: 0x06031AB9 RID: 203449 RVA: 0x00DE4482 File Offset: 0x00DE2682
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

		// Token: 0x06031ABA RID: 203450 RVA: 0x00DE44BC File Offset: 0x00DE26BC
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

		// Token: 0x06031ABB RID: 203451 RVA: 0x00DE4518 File Offset: 0x00DE2718
		private void SetIcon()
		{
			QuestUpdateTipsShowData showData = this.ShowData;
			int markId = (showData != null) ? showData.MissionViewShowData.TrackIconConfigId : 0;
			string questTypeMark = QuestNewConfig.Instance.GetQuestTypeMark(markId);
			UUISprite sprite = base.GetSprite(2);
			this.SetSpriteByPath(questTypeMark, sprite, false, null, null);
		}

		// Token: 0x06031ABC RID: 203452 RVA: 0x00DE4564 File Offset: 0x00DE2764
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

		// Token: 0x06031ABD RID: 203453 RVA: 0x00DE45D4 File Offset: 0x00DE27D4
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

		// Token: 0x06031ABE RID: 203454 RVA: 0x00DE4698 File Offset: 0x00DE2898
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

		// Token: 0x06031ABF RID: 203455 RVA: 0x00DE4758 File Offset: 0x00DE2958
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType != InputDistributeDefine.EActionType.Release)
			{
				return;
			}
			this.OnClickTrack();
		}

		// Token: 0x06031AC0 RID: 203456 RVA: 0x00DE4768 File Offset: 0x00DE2968
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

		// Token: 0x06031AC1 RID: 203457 RVA: 0x00DE47DE File Offset: 0x00DE29DE
		public bool IsClosing()
		{
			return this.IsPlayCloseSequence;
		}

		// Token: 0x0401A4AF RID: 107695
		[Nullable(2)]
		private CombineKeyItem KeyItem;

		// Token: 0x0401A4B0 RID: 107696
		[Nullable(2)]
		private QuestUpdateTipsShowData ShowData;

		// Token: 0x0401A4B1 RID: 107697
		private bool LockClickTrack;

		// Token: 0x0401A4B2 RID: 107698
		private bool IsPlayCloseSequence;

		// Token: 0x0401A4B3 RID: 107699
		private bool IsClicked;

		// Token: 0x0200AA1E RID: 43550
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034937 RID: 215351
			QuestNameText,
			// Token: 0x04034938 RID: 215352
			NodeDescribeText,
			// Token: 0x04034939 RID: 215353
			QuestIcon,
			// Token: 0x0403493A RID: 215354
			TrackBtn,
			// Token: 0x0403493B RID: 215355
			Step1Item,
			// Token: 0x0403493C RID: 215356
			KeyItem
		}
	}
}
