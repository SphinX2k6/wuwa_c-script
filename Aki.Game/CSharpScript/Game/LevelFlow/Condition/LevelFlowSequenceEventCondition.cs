using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelFlow.Condition
{
	// Token: 0x02006F76 RID: 28534
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowSequenceEventCondition : LevelFlowConditionBase
	{
		// Token: 0x0604569B RID: 284315 RVA: 0x01134C47 File Offset: 0x01132E47
		public LevelFlowSequenceEventCondition Init(string param)
		{
			this.Param = param;
			return this;
		}

		// Token: 0x0604569C RID: 284316 RVA: 0x01134C51 File Offset: 0x01132E51
		protected override void OnEnter()
		{
			EventSystem.Instance.Add<string>(EEventName.LevelFlowSequenceTriggerEvent, new Action<string>(this.OnTriggerEvent));
		}

		// Token: 0x0604569D RID: 284317 RVA: 0x01134C6F File Offset: 0x01132E6F
		protected override void OnExit()
		{
			EventSystem.Instance.Remove<string>(EEventName.LevelFlowSequenceTriggerEvent, new Action<string>(this.OnTriggerEvent));
		}

		// Token: 0x0604569E RID: 284318 RVA: 0x01134C8D File Offset: 0x01132E8D
		protected override void OnReset()
		{
			EventSystem.Instance.Remove<string>(EEventName.LevelFlowSequenceTriggerEvent, new Action<string>(this.OnTriggerEvent));
		}

		// Token: 0x0604569F RID: 284319 RVA: 0x01134CAB File Offset: 0x01132EAB
		private void OnTriggerEvent(string param)
		{
			if (param == this.Param)
			{
				base.FinishExecute(true);
			}
		}

		// Token: 0x0402438E RID: 148366
		private string Param = string.Empty;
	}
}
