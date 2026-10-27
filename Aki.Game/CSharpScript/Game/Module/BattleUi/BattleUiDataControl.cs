using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C6F RID: 23663
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class BattleUiDataControl : UiControllerBase
	{
		// Token: 0x0603BD04 RID: 244996 RVA: 0x00E4A0B0 File Offset: 0x00E482B0
		protected override void OnAddEvents()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.OpenView;
			Action<EUiViewName, int> handle;
			if ((handle = BattleUiDataControl.<>O.<0>__OnOpenView) == null)
			{
				handle = (BattleUiDataControl.<>O.<0>__OnOpenView = new Action<EUiViewName, int>(BattleUiDataControl.OnOpenView));
			}
			instance.Add<EUiViewName, int>(name, handle);
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.CloseView;
			Action<EUiViewName, int> handle2;
			if ((handle2 = BattleUiDataControl.<>O.<1>__OnCloseView) == null)
			{
				handle2 = (BattleUiDataControl.<>O.<1>__OnCloseView = new Action<EUiViewName, int>(BattleUiDataControl.OnCloseView));
			}
			instance2.Add<EUiViewName, int>(name2, handle2);
			EventSystem instance3 = EventSystem.Instance;
			EEventName name3 = EEventName.OnLogicTreeNodeProgressChange;
			Action<GeneralContext, ChildQuestNodeProgress> handle3;
			if ((handle3 = BattleUiDataControl.<>O.<2>__OnLogicTreeNodeProgressChange) == null)
			{
				handle3 = (BattleUiDataControl.<>O.<2>__OnLogicTreeNodeProgressChange = new Action<GeneralContext, ChildQuestNodeProgress>(BattleUiDataControl.OnLogicTreeNodeProgressChange));
			}
			instance3.Add<GeneralContext, ChildQuestNodeProgress>(name3, handle3);
			EventSystem instance4 = EventSystem.Instance;
			EEventName name4 = EEventName.OnLogicTreeNodeStatusChange;
			Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason> handle4;
			if ((handle4 = BattleUiDataControl.<>O.<3>__OnLogicTreeNodeStatusChange) == null)
			{
				handle4 = (BattleUiDataControl.<>O.<3>__OnLogicTreeNodeStatusChange = new Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(BattleUiDataControl.OnLogicTreeNodeStatusChange));
			}
			instance4.Add<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(name4, handle4);
			EventSystem instance5 = EventSystem.Instance;
			EEventName name5 = EEventName.OnGeneralLogicTreeRemove;
			Action<long, ETreeRemoveReason> handle5;
			if ((handle5 = BattleUiDataControl.<>O.<4>__OnGeneralLogicTreeRemove) == null)
			{
				handle5 = (BattleUiDataControl.<>O.<4>__OnGeneralLogicTreeRemove = new Action<long, ETreeRemoveReason>(BattleUiDataControl.OnGeneralLogicTreeRemove));
			}
			instance5.Add<long, ETreeRemoveReason>(name5, handle5);
		}

		// Token: 0x0603BD05 RID: 244997 RVA: 0x00E4A190 File Offset: 0x00E48390
		protected override void OnRemoveEvents()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.OpenView;
			Action<EUiViewName, int> handle;
			if ((handle = BattleUiDataControl.<>O.<0>__OnOpenView) == null)
			{
				handle = (BattleUiDataControl.<>O.<0>__OnOpenView = new Action<EUiViewName, int>(BattleUiDataControl.OnOpenView));
			}
			instance.Remove(name, handle);
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.CloseView;
			Action<EUiViewName, int> handle2;
			if ((handle2 = BattleUiDataControl.<>O.<1>__OnCloseView) == null)
			{
				handle2 = (BattleUiDataControl.<>O.<1>__OnCloseView = new Action<EUiViewName, int>(BattleUiDataControl.OnCloseView));
			}
			instance2.Remove(name2, handle2);
			EventSystem instance3 = EventSystem.Instance;
			EEventName name3 = EEventName.OnLogicTreeNodeProgressChange;
			Action<GeneralContext, ChildQuestNodeProgress> handle3;
			if ((handle3 = BattleUiDataControl.<>O.<2>__OnLogicTreeNodeProgressChange) == null)
			{
				handle3 = (BattleUiDataControl.<>O.<2>__OnLogicTreeNodeProgressChange = new Action<GeneralContext, ChildQuestNodeProgress>(BattleUiDataControl.OnLogicTreeNodeProgressChange));
			}
			instance3.Remove(name3, handle3);
			EventSystem instance4 = EventSystem.Instance;
			EEventName name4 = EEventName.OnLogicTreeNodeStatusChange;
			Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason> handle4;
			if ((handle4 = BattleUiDataControl.<>O.<3>__OnLogicTreeNodeStatusChange) == null)
			{
				handle4 = (BattleUiDataControl.<>O.<3>__OnLogicTreeNodeStatusChange = new Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(BattleUiDataControl.OnLogicTreeNodeStatusChange));
			}
			instance4.Remove(name4, handle4);
			EventSystem instance5 = EventSystem.Instance;
			EEventName name5 = EEventName.OnGeneralLogicTreeRemove;
			Action<long, ETreeRemoveReason> handle5;
			if ((handle5 = BattleUiDataControl.<>O.<4>__OnGeneralLogicTreeRemove) == null)
			{
				handle5 = (BattleUiDataControl.<>O.<4>__OnGeneralLogicTreeRemove = new Action<long, ETreeRemoveReason>(BattleUiDataControl.OnGeneralLogicTreeRemove));
			}
			instance5.Remove(name5, handle5);
			IReadOnlyList<string> actionNames = BattleUiModel.Instance.ExploreModeData.GetActionNames();
			InputDistributeController instance6 = InputDistributeController.Instance;
			IReadOnlyList<string> actionNames2 = actionNames;
			TInputHandle<InputDistributeDefine.EActionType> actionCallback;
			if ((actionCallback = BattleUiDataControl.<>O.<5>__OnInputAction) == null)
			{
				actionCallback = (BattleUiDataControl.<>O.<5>__OnInputAction = new TInputHandle<InputDistributeDefine.EActionType>(BattleUiDataControl.OnInputAction));
			}
			instance6.UnBindActions(actionNames2, actionCallback);
		}

		// Token: 0x0603BD06 RID: 244998 RVA: 0x00E4A2A3 File Offset: 0x00E484A3
		private static void OnOpenView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.GuideFocusView)
			{
				return;
			}
			BattleUiModel.Instance.ExploreModeData.UpdateGuidingState(true);
		}

		// Token: 0x0603BD07 RID: 244999 RVA: 0x00E4A2C3 File Offset: 0x00E484C3
		private static void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.GuideFocusView)
			{
				return;
			}
			BattleUiModel.Instance.ExploreModeData.UpdateGuidingState(false);
		}

		// Token: 0x0603BD08 RID: 245000 RVA: 0x00E4A2E4 File Offset: 0x00E484E4
		private static void OnLogicTreeNodeProgressChange(GeneralContext context, ChildQuestNodeProgress progress)
		{
			GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
			if (generalLogicTreeContext == null || progress.MonsterCreator == null)
			{
				return;
			}
			IBtNode btNode = null;
			BtType btType = generalLogicTreeContext.BtType;
			if (btType != BtType.Quest)
			{
				if (btType - BtType.LevelPlay <= 1)
				{
					btNode = LevelPlayModel.Instance.GetLevelPlayNodeConfig(generalLogicTreeContext.TreeConfigId, generalLogicTreeContext.NodeId);
				}
			}
			else
			{
				btNode = QuestNewModel.Instance.GetQuestNodeConfig(generalLogicTreeContext.TreeConfigId, generalLogicTreeContext.NodeId);
			}
			IChildQuestBtNode childQuestBtNode = btNode as IChildQuestBtNode;
			if (childQuestBtNode == null)
			{
				return;
			}
			IMonsterCreatorQuestCondition monsterCreatorQuestCondition = childQuestBtNode.Condition as IMonsterCreatorQuestCondition;
			if (monsterCreatorQuestCondition == null)
			{
				return;
			}
			if (!monsterCreatorQuestCondition.ShowMonsterMergedHpBar.GetValueOrDefault())
			{
				return;
			}
			BattleUiModel.Instance.MergeHeadStateData.UpdateProgress(generalLogicTreeContext.TreeIncId, generalLogicTreeContext.NodeId, progress.MonsterCreator, monsterCreatorQuestCondition.TidMonsterGroupName, monsterCreatorQuestCondition.MonsterMergedHpBarSettings);
		}

		// Token: 0x0603BD09 RID: 245001 RVA: 0x00E4A3A8 File Offset: 0x00E485A8
		private static void OnLogicTreeNodeStatusChange(GeneralContext context, NodeStatus oldStatus, NodeStatus newStatus, ENodeStatusUpdateReason reason)
		{
			GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
			if (generalLogicTreeContext != null && (newStatus == NodeStatus.CompletedFailed || newStatus == NodeStatus.CompletedSuccess || newStatus == NodeStatus.Destroy))
			{
				BattleUiModel.Instance.MergeHeadStateData.RemoveNode(generalLogicTreeContext.TreeIncId, generalLogicTreeContext.NodeId);
			}
		}

		// Token: 0x0603BD0A RID: 245002 RVA: 0x00E4A3E6 File Offset: 0x00E485E6
		private static void OnGeneralLogicTreeRemove(long treeId, ETreeRemoveReason eTreeRemoveReason)
		{
			BattleUiModel.Instance.MergeHeadStateData.RemoveTree(treeId);
		}

		// Token: 0x0603BD0B RID: 245003 RVA: 0x00E4A3F8 File Offset: 0x00E485F8
		private static void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			BattleUiModel.Instance.ExploreModeData.InputAction(actionName, actionType == InputDistributeDefine.EActionType.Press);
		}

		// Token: 0x17008DC4 RID: 36292
		// (get) Token: 0x0603BD0C RID: 245004 RVA: 0x00E4A40E File Offset: 0x00E4860E
		public static BattleUiDataControl Instance
		{
			get
			{
				return BattleUiDataControl._Instance;
			}
		}

		// Token: 0x0603BD0D RID: 245005 RVA: 0x00E4A415 File Offset: 0x00E48615
		public static BattleUiDataControl GetOrCreateInstance()
		{
			if (BattleUiDataControl._Instance == null)
			{
				BattleUiDataControl.CreateInstance();
			}
			return BattleUiDataControl._Instance;
		}

		// Token: 0x0603BD0E RID: 245006 RVA: 0x00E4A429 File Offset: 0x00E48629
		public static bool CreateInstance()
		{
			if (BattleUiDataControl._Instance != null)
			{
				return true;
			}
			BattleUiDataControl._Instance = new BattleUiDataControl();
			return true;
		}

		// Token: 0x0603BD0F RID: 245007 RVA: 0x00E4A43F File Offset: 0x00E4863F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BD10 RID: 245008 RVA: 0x00E4A441 File Offset: 0x00E48641
		public static void ResetStaticDefaultValue()
		{
			BattleUiDataControl._Instance = null;
		}

		// Token: 0x0603BD11 RID: 245009 RVA: 0x00E4A449 File Offset: 0x00E48649
		static BattleUiDataControl()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleUiDataControl.CreateStaticDefaultValue), new Action(BattleUiDataControl.ResetStaticDefaultValue));
		}

		// Token: 0x0401F295 RID: 127637
		[Nullable(2)]
		private static BattleUiDataControl _Instance;

		// Token: 0x0200BE77 RID: 48759
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403970C RID: 235276
			[Nullable(0)]
			public static Action<EUiViewName, int> <0>__OnOpenView;

			// Token: 0x0403970D RID: 235277
			[Nullable(0)]
			public static Action<EUiViewName, int> <1>__OnCloseView;

			// Token: 0x0403970E RID: 235278
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			public static Action<GeneralContext, ChildQuestNodeProgress> <2>__OnLogicTreeNodeProgressChange;

			// Token: 0x0403970F RID: 235279
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason> <3>__OnLogicTreeNodeStatusChange;

			// Token: 0x04039710 RID: 235280
			[Nullable(0)]
			public static Action<long, ETreeRemoveReason> <4>__OnGeneralLogicTreeRemove;

			// Token: 0x04039711 RID: 235281
			[Nullable(0)]
			public static TInputHandle<InputDistributeDefine.EActionType> <5>__OnInputAction;
		}
	}
}
