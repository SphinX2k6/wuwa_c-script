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
	// Token: 0x02004C4F RID: 19535
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class BattleUiDataControl : UiControllerBase
	{
		// Token: 0x06030C52 RID: 199762 RVA: 0x00D9A62C File Offset: 0x00D9882C
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

		// Token: 0x06030C53 RID: 199763 RVA: 0x00D9A70C File Offset: 0x00D9890C
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

		// Token: 0x06030C54 RID: 199764 RVA: 0x00D9A81F File Offset: 0x00D98A1F
		private static void OnOpenView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.GuideFocusView)
			{
				return;
			}
			BattleUiModel.Instance.ExploreModeData.UpdateGuidingState(true);
		}

		// Token: 0x06030C55 RID: 199765 RVA: 0x00D9A83F File Offset: 0x00D98A3F
		private static void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.GuideFocusView)
			{
				return;
			}
			BattleUiModel.Instance.ExploreModeData.UpdateGuidingState(false);
		}

		// Token: 0x06030C56 RID: 199766 RVA: 0x00D9A860 File Offset: 0x00D98A60
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

		// Token: 0x06030C57 RID: 199767 RVA: 0x00D9A924 File Offset: 0x00D98B24
		private static void OnLogicTreeNodeStatusChange(GeneralContext context, NodeStatus oldStatus, NodeStatus newStatus, ENodeStatusUpdateReason reason)
		{
			GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
			if (generalLogicTreeContext != null && (newStatus == NodeStatus.CompletedFailed || newStatus == NodeStatus.CompletedSuccess || newStatus == NodeStatus.Destroy))
			{
				BattleUiModel.Instance.MergeHeadStateData.RemoveNode(generalLogicTreeContext.TreeIncId, generalLogicTreeContext.NodeId);
			}
		}

		// Token: 0x06030C58 RID: 199768 RVA: 0x00D9A962 File Offset: 0x00D98B62
		private static void OnGeneralLogicTreeRemove(long treeId, ETreeRemoveReason eTreeRemoveReason)
		{
			BattleUiModel.Instance.MergeHeadStateData.RemoveTree(treeId);
		}

		// Token: 0x06030C59 RID: 199769 RVA: 0x00D9A974 File Offset: 0x00D98B74
		private static void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			BattleUiModel.Instance.ExploreModeData.InputAction(actionName, actionType == InputDistributeDefine.EActionType.Press);
		}

		// Token: 0x17006196 RID: 24982
		// (get) Token: 0x06030C5A RID: 199770 RVA: 0x00D9A98A File Offset: 0x00D98B8A
		public static BattleUiDataControl Instance
		{
			get
			{
				return BattleUiDataControl._Instance;
			}
		}

		// Token: 0x06030C5B RID: 199771 RVA: 0x00D9A991 File Offset: 0x00D98B91
		public static BattleUiDataControl GetOrCreateInstance()
		{
			if (BattleUiDataControl._Instance == null)
			{
				BattleUiDataControl.CreateInstance();
			}
			return BattleUiDataControl._Instance;
		}

		// Token: 0x06030C5C RID: 199772 RVA: 0x00D9A9A5 File Offset: 0x00D98BA5
		public static bool CreateInstance()
		{
			if (BattleUiDataControl._Instance != null)
			{
				return true;
			}
			BattleUiDataControl._Instance = new BattleUiDataControl();
			return true;
		}

		// Token: 0x06030C5D RID: 199773 RVA: 0x00D9A9BB File Offset: 0x00D98BBB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030C5E RID: 199774 RVA: 0x00D9A9BD File Offset: 0x00D98BBD
		public static void ResetStaticDefaultValue()
		{
			BattleUiDataControl._Instance = null;
		}

		// Token: 0x06030C5F RID: 199775 RVA: 0x00D9A9C5 File Offset: 0x00D98BC5
		static BattleUiDataControl()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleUiDataControl.CreateStaticDefaultValue), new Action(BattleUiDataControl.ResetStaticDefaultValue));
		}

		// Token: 0x04019D49 RID: 105801
		[Nullable(2)]
		private static BattleUiDataControl _Instance;

		// Token: 0x0200A87D RID: 43133
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040340CD RID: 213197
			[Nullable(0)]
			public static Action<EUiViewName, int> <0>__OnOpenView;

			// Token: 0x040340CE RID: 213198
			[Nullable(0)]
			public static Action<EUiViewName, int> <1>__OnCloseView;

			// Token: 0x040340CF RID: 213199
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			public static Action<GeneralContext, ChildQuestNodeProgress> <2>__OnLogicTreeNodeProgressChange;

			// Token: 0x040340D0 RID: 213200
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason> <3>__OnLogicTreeNodeStatusChange;

			// Token: 0x040340D1 RID: 213201
			[Nullable(0)]
			public static Action<long, ETreeRemoveReason> <4>__OnGeneralLogicTreeRemove;

			// Token: 0x040340D2 RID: 213202
			[Nullable(0)]
			public static TInputHandle<InputDistributeDefine.EActionType> <5>__OnInputAction;
		}
	}
}
