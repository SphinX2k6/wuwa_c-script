using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059CB RID: 22987
	[NullableContext(1)]
	[Nullable(0)]
	public class CheckPlayerInputBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0603A44C RID: 238668 RVA: 0x00DDB104 File Offset: 0x00DD9304
		public CheckPlayerInputBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A44D RID: 238669 RVA: 0x00DDB110 File Offset: 0x00DD9310
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

		// Token: 0x0603A44E RID: 238670 RVA: 0x00DDB188 File Offset: 0x00DD9388
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

		// Token: 0x0603A44F RID: 238671 RVA: 0x00DDB224 File Offset: 0x00DD9424
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

		// Token: 0x0603A450 RID: 238672 RVA: 0x00DDB2A1 File Offset: 0x00DD94A1
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification ii)
		{
			if (actionType != InputDistributeDefine.EActionType.Release)
			{
				return;
			}
			this.OnChallengeAgain(actionName);
		}

		// Token: 0x0603A451 RID: 238673 RVA: 0x00DDB2AF File Offset: 0x00DD94AF
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

		// Token: 0x0401E619 RID: 124441
		private EPlayerButtonType ButtonType;

		// Token: 0x0401E61A RID: 124442
		[Nullable(2)]
		private string ActionName;
	}
}
