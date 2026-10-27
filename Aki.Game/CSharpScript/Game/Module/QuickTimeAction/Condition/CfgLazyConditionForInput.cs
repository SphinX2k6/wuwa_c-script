using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.QuickTimeAction;

namespace CSharpScript.Game.Module.QuickTimeAction.Condition
{
	// Token: 0x02004F57 RID: 20311
	[NullableContext(1)]
	[Nullable(0)]
	public class CfgLazyConditionForInput : CfgLazyConditionBase
	{
		// Token: 0x06034105 RID: 213253 RVA: 0x00C35FF5 File Offset: 0x00C341F5
		public CfgLazyConditionForInput()
		{
			this.ConditionType = new ELazyConditionType?(ELazyConditionType.输入检测);
		}

		// Token: 0x06034106 RID: 213254 RVA: 0x00C3601B File Offset: 0x00C3421B
		public void InitForQta(string actionName, SQtaCondition_Content ueCondition)
		{
			this.ActionName = actionName;
			this.KeyMatchType = (ELazyConditionKeyMatchType)ueCondition.InputMatchType;
			this.Reverse = ueCondition.Reverse;
		}

		// Token: 0x0401BA93 RID: 113299
		public string ActionName = string.Empty;

		// Token: 0x0401BA94 RID: 113300
		public ELazyConditionKeyMatchType KeyMatchType = ELazyConditionKeyMatchType.没按键;

		// Token: 0x0401BA95 RID: 113301
		public bool Reverse;
	}
}
