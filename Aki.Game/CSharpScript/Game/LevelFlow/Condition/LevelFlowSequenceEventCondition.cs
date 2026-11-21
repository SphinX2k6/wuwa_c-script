using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelFlow.Condition
{
	// Token: 0x020060F7 RID: 24823
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowSequenceEventCondition : LevelFlowConditionBase
	{
		// Token: 0x0603B849 RID: 243785 RVA: 0x010DEA4B File Offset: 0x010DCC4B
		public LevelFlowSequenceEventCondition Init(string param)
		{
			this.Param = param;
			return this;
		}

		// Token: 0x0603B84A RID: 243786 RVA: 0x010DEA55 File Offset: 0x010DCC55
		protected override void OnEnter()
		{
			EventSystem.Instance.Add<string>(EEventName.LevelFlowSequenceTriggerEvent, new Action<string>(this.OnTriggerEvent));
		}

		// Token: 0x0603B84B RID: 243787 RVA: 0x010DEA73 File Offset: 0x010DCC73
		protected override void OnExit()
		{
			EventSystem.Instance.Remove<string>(EEventName.LevelFlowSequenceTriggerEvent, new Action<string>(this.OnTriggerEvent));
		}

		// Token: 0x0603B84C RID: 243788 RVA: 0x010DEA91 File Offset: 0x010DCC91
		protected override void OnReset()
		{
			EventSystem.Instance.Remove<string>(EEventName.LevelFlowSequenceTriggerEvent, new Action<string>(this.OnTriggerEvent));
		}

		// Token: 0x0603B84D RID: 243789 RVA: 0x010DEAAF File Offset: 0x010DCCAF
		private void OnTriggerEvent(string param)
		{
			if (param == this.Param)
			{
				base.FinishExecute(true);
			}
		}

		// Token: 0x0401F643 RID: 128579
		private string Param = string.Empty;
	}
}
