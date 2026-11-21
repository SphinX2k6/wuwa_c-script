using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049B8 RID: 18872
	public class RhythmGameNode : ChildQuestNodeBase
	{
		// Token: 0x0602F420 RID: 193568 RVA: 0x00D2E022 File Offset: 0x00D2C222
		public RhythmGameNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F421 RID: 193569 RVA: 0x00D2E02C File Offset: 0x00D2C22C
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

		// Token: 0x0602F422 RID: 193570 RVA: 0x00D2E080 File Offset: 0x00D2C280
		protected override void OnDestroy()
		{
			base.OnDestroy();
			if (EventSystem.Instance.Has(EEventName.OnRhythmGameFinish, new Action(this.OnRhythmGameFinish)))
			{
				EventSystem.Instance.Remove(EEventName.OnRhythmGameFinish, new Action(this.OnRhythmGameFinish));
			}
		}

		// Token: 0x0602F423 RID: 193571 RVA: 0x00D2E0CC File Offset: 0x00D2C2CC
		private void OnRhythmGameFinish()
		{
			this.SubmitNode(null);
		}

		// Token: 0x0602F424 RID: 193572 RVA: 0x00D2E0D8 File Offset: 0x00D2C2D8
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
