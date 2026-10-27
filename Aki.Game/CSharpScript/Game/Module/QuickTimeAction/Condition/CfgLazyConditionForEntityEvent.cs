using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.QuickTimeAction;

namespace CSharpScript.Game.Module.QuickTimeAction.Condition
{
	// Token: 0x02004F58 RID: 20312
	public class CfgLazyConditionForEntityEvent : CfgLazyConditionBase
	{
		// Token: 0x06034107 RID: 213255 RVA: 0x00C36041 File Offset: 0x00C34241
		public CfgLazyConditionForEntityEvent()
		{
			this.ConditionType = new ELazyConditionType?(ELazyConditionType.事件变化);
		}

		// Token: 0x06034108 RID: 213256 RVA: 0x00C3605C File Offset: 0x00C3425C
		[NullableContext(1)]
		public void InitForQta(SQtaCondition_Content ueCondition)
		{
			this.EventName = (ELazyConditionEventName)ueCondition.EventName;
		}

		// Token: 0x0401BA96 RID: 113302
		public ELazyConditionEventName EventName = ELazyConditionEventName.当前技能结束;
	}
}
