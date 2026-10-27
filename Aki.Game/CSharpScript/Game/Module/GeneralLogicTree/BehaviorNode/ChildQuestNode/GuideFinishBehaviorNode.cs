using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059D4 RID: 22996
	public class GuideFinishBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0603A4AC RID: 238764 RVA: 0x00DDCA70 File Offset: 0x00DDAC70
		public GuideFinishBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A4AD RID: 238765 RVA: 0x00DDCA7C File Offset: 0x00DDAC7C
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

		// Token: 0x0603A4AE RID: 238766 RVA: 0x00DDCABE File Offset: 0x00DDACBE
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.GuideGroupId = 0;
		}

		// Token: 0x0603A4AF RID: 238767 RVA: 0x00DDCAD0 File Offset: 0x00DDACD0
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

		// Token: 0x0603A4B0 RID: 238768 RVA: 0x00DDCB3C File Offset: 0x00DDAD3C
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

		// Token: 0x0603A4B1 RID: 238769 RVA: 0x00DDCBC1 File Offset: 0x00DDADC1
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

		// Token: 0x0603A4B2 RID: 238770 RVA: 0x00DDCBDC File Offset: 0x00DDADDC
		private void OnGuideGroupFinishByComboTeaching()
		{
			if (this.Submitting)
			{
				return;
			}
			this.SubmitNode(null);
		}

		// Token: 0x0401E63D RID: 124477
		private int GuideGroupId;
	}
}
