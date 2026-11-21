using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049A4 RID: 18852
	[NullableContext(1)]
	[Nullable(0)]
	public class CheckPlayerInputBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0602F373 RID: 193395 RVA: 0x00D2A98C File Offset: 0x00D28B8C
		public CheckPlayerInputBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F374 RID: 193396 RVA: 0x00D2A998 File Offset: 0x00D28B98
		protected override bool OnCreate(IBtNode nodeConfig)
		{
			if (!base.OnCreate(nodeConfig))
			{
				return false;
			}
			IChildQuestBtNode childQuestBtNode = nodeConfig as IChildQuestBtNode;
			if (childQuestBtNode == null)
			{
				return false;
			}
			ICheckPlayerInputCondition checkPlayerInputCondition = childQuestBtNode.Condition as ICheckPlayerInputCondition;
			if (checkPlayerInputCondition == null)
			{
				return false;
			}
			ICheckPlayerPressButton checkInput = checkPlayerInputCondition.CheckInput;
			if (checkInput == null)
			{
				return false;
			}
			this.ButtonType = checkInput.ButtonType;
			EPlayerButtonType buttonType = this.ButtonType;
			if (buttonType != EPlayerButtonType.ChallengeAgain)
			{
				if (buttonType == EPlayerButtonType.ExitChallenge)
				{
					this.ActionName = "玩法放弃";
				}
			}
			else
			{
				this.ActionName = "重新挑战";
			}
			return true;
		}

		// Token: 0x0602F375 RID: 193397 RVA: 0x00D2AA10 File Offset: 0x00D28C10
		protected override void AddEventsOnChildQuestStart()
		{
			base.AddEventsOnChildQuestStart();
			if (string.IsNullOrEmpty(this.ActionName))
			{
				return;
			}
			InputDistributeController.Instance.UnBindAction(this.ActionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			InputDistributeController.Instance.BindAction(this.ActionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			EventSystem.Instance.Add<string>(EEventName.ChallengeAgain, new Action<string>(this.OnChallengeAgain));
			if (this.ActionName == "重新挑战")
			{
				this.Blackboard.AddTag(EBehaviorTreeTag.CanChallengeAgain, "");
			}
		}

		// Token: 0x0602F376 RID: 193398 RVA: 0x00D2AAAC File Offset: 0x00D28CAC
		protected override void RemoveEventsOnChildQuestEnd()
		{
			base.RemoveEventsOnChildQuestEnd();
			if (string.IsNullOrEmpty(this.ActionName))
			{
				return;
			}
			InputDistributeController.Instance.UnBindAction(this.ActionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			EventSystem.Instance.Remove<string>(EEventName.ChallengeAgain, new Action<string>(this.OnChallengeAgain));
			if (this.ActionName == "重新挑战")
			{
				this.Blackboard.RemoveTag(EBehaviorTreeTag.CanChallengeAgain, "");
			}
		}

		// Token: 0x0602F377 RID: 193399 RVA: 0x00D2AB29 File Offset: 0x00D28D29
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification ii)
		{
			if (actionType != InputDistributeDefine.EActionType.Release)
			{
				return;
			}
			this.OnChallengeAgain(actionName);
		}

		// Token: 0x0602F378 RID: 193400 RVA: 0x00D2AB37 File Offset: 0x00D28D37
		protected void OnChallengeAgain(string actionName)
		{
			if (this.Submitting)
			{
				return;
			}
			if (this.ActionName != actionName)
			{
				return;
			}
			this.SubmitNode(null);
		}

		// Token: 0x040190B8 RID: 102584
		private EPlayerButtonType ButtonType;

		// Token: 0x040190B9 RID: 102585
		[Nullable(2)]
		private string ActionName;
	}
}
