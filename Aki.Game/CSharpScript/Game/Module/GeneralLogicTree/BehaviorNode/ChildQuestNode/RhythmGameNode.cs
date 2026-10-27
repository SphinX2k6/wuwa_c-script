using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059DF RID: 23007
	public class RhythmGameNode : ChildQuestNodeBase
	{
		// Token: 0x0603A4F8 RID: 238840 RVA: 0x00DDE802 File Offset: 0x00DDCA02
		public RhythmGameNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A4F9 RID: 238841 RVA: 0x00DDE80C File Offset: 0x00DDCA0C
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
			if (childQuestBtNode.Condition.Type != EChildQuest.FinishRhythmSpaceship)
			{
				return false;
			}
			EventSystem.Instance.Add(EEventName.OnRhythmGameFinish, new Action(this.OnRhythmGameFinish));
			return true;
		}

		// Token: 0x0603A4FA RID: 238842 RVA: 0x00DDE860 File Offset: 0x00DDCA60
		protected override void OnDestroy()
		{
			base.OnDestroy();
			if (EventSystem.Instance.Has(EEventName.OnRhythmGameFinish, new Action(this.OnRhythmGameFinish)))
			{
				EventSystem.Instance.Remove(EEventName.OnRhythmGameFinish, new Action(this.OnRhythmGameFinish));
			}
		}

		// Token: 0x0603A4FB RID: 238843 RVA: 0x00DDE8AC File Offset: 0x00DDCAAC
		private void OnRhythmGameFinish()
		{
			this.SubmitNode(null);
		}

		// Token: 0x0603A4FC RID: 238844 RVA: 0x00DDE8B8 File Offset: 0x00DDCAB8
		protected override void OnAfterSubmit(bool submitSuccess)
		{
			base.OnAfterSubmit(submitSuccess);
			if (submitSuccess && EventSystem.Instance.Has(EEventName.OnRhythmGameFinish, new Action(this.OnRhythmGameFinish)))
			{
				EventSystem.Instance.Remove(EEventName.OnRhythmGameFinish, new Action(this.OnRhythmGameFinish));
			}
		}
	}
}
