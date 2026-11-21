using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.QuickTimeAction;

namespace CSharpScript.Game.Module.QuickTimeAction.Condition
{
	// Token: 0x02003F21 RID: 16161
	public class CfgLazyConditionForEntityEvent : CfgLazyConditionBase
	{
		// Token: 0x06028F75 RID: 167797 RVA: 0x00B7F7E1 File Offset: 0x00B7D9E1
		public CfgLazyConditionForEntityEvent()
		{
			this.ConditionType = new ELazyConditionType?(ELazyConditionType.事件变化);
		}

		// Token: 0x06028F76 RID: 167798 RVA: 0x00B7F7FC File Offset: 0x00B7D9FC
		[NullableContext(1)]
		public void InitForQta(SQtaCondition_Content ueCondition)
		{
			this.EventName = (ELazyConditionEventName)ueCondition.EventName;
		}

		// Token: 0x0401646B RID: 91243
		public ELazyConditionEventName EventName = ELazyConditionEventName.当前技能结束;
	}
}
