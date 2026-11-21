using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049AD RID: 18861
	public class GuideFinishBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0602F3D3 RID: 193491 RVA: 0x00D2C250 File Offset: 0x00D2A450
		public GuideFinishBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F3D4 RID: 193492 RVA: 0x00D2C25C File Offset: 0x00D2A45C
		[NullableContext(1)]
		protected override bool OnCreate(IBtNode nodeConfig)
		{
			IChildQuestBtNode childQuestBtNode = nodeConfig as IChildQuestBtNode;
			if (childQuestBtNode == null)
			{
				return false;
			}
			if (!base.OnCreate(nodeConfig))
			{
				return false;
			}
			IGuideCondition guideCondition = childQuestBtNode.Condition as IGuideCondition;
			if (guideCondition == null)
			{
				return false;
			}
			this.GuideGroupId = guideCondition.GuideGroupId;
			return true;
		}

		// Token: 0x0602F3D5 RID: 193493 RVA: 0x00D2C29E File Offset: 0x00D2A49E
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.GuideGroupId = 0;
		}

		// Token: 0x0602F3D6 RID: 193494 RVA: 0x00D2C2B0 File Offset: 0x00D2A4B0
		protected override void AddEventsOnChildQuestStart()
		{
			base.AddEventsOnChildQuestStart();
			EventSystem.Instance.Add(EEventName.GuideGroupFinished, new Action<int>(this.OnGuideGroupFinish));
			EventSystem.Instance.Add(EEventName.ComboTeachingFinish, new Action(this.OnGuideGroupFinishByComboTeaching));
			if (GuideModel.Instance.IsGroupFinished(this.GuideGroupId).GetValueOrDefault())
			{
				this.SubmitNode(null);
			}
		}

		// Token: 0x0602F3D7 RID: 193495 RVA: 0x00D2C31C File Offset: 0x00D2A51C
		protected override void RemoveEventsOnChildQuestEnd()
		{
			if (EventSystem.Instance.Has<int>(EEventName.GuideGroupFinished, new Action<int>(this.OnGuideGroupFinish)))
			{
				EventSystem.Instance.Remove<int>(EEventName.GuideGroupFinished, new Action<int>(this.OnGuideGroupFinish));
			}
			if (EventSystem.Instance.Has(EEventName.ComboTeachingFinish, new Action(this.OnGuideGroupFinishByComboTeaching)))
			{
				EventSystem.Instance.Remove(EEventName.ComboTeachingFinish, new Action(this.OnGuideGroupFinishByComboTeaching));
			}
			base.RemoveEventsOnChildQuestEnd();
		}

		// Token: 0x0602F3D8 RID: 193496 RVA: 0x00D2C3A1 File Offset: 0x00D2A5A1
		private void OnGuideGroupFinish(int guideGroupId)
		{
			if (this.Submitting)
			{
				return;
			}
			if (guideGroupId == this.GuideGroupId)
			{
				this.SubmitNode(null);
			}
		}

		// Token: 0x0602F3D9 RID: 193497 RVA: 0x00D2C3BC File Offset: 0x00D2A5BC
		private void OnGuideGroupFinishByComboTeaching()
		{
			if (this.Submitting)
			{
				return;
			}
			this.SubmitNode(null);
		}

		// Token: 0x040190DC RID: 102620
		private int GuideGroupId;
	}
}
