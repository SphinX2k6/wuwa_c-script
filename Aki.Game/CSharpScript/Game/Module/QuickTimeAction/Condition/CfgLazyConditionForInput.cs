using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.QuickTimeAction;

namespace CSharpScript.Game.Module.QuickTimeAction.Condition
{
	// Token: 0x02003F20 RID: 16160
	[NullableContext(1)]
	[Nullable(0)]
	public class CfgLazyConditionForInput : CfgLazyConditionBase
	{
		// Token: 0x06028F73 RID: 167795 RVA: 0x00B7F795 File Offset: 0x00B7D995
		public CfgLazyConditionForInput()
		{
			this.ConditionType = new ELazyConditionType?(ELazyConditionType.输入检测);
		}

		// Token: 0x06028F74 RID: 167796 RVA: 0x00B7F7BB File Offset: 0x00B7D9BB
		public void InitForQta(string actionName, SQtaCondition_Content ueCondition)
		{
			this.ActionName = actionName;
			this.KeyMatchType = (ELazyConditionKeyMatchType)ueCondition.InputMatchType;
			this.Reverse = ueCondition.Reverse;
		}

		// Token: 0x04016468 RID: 91240
		public string ActionName = string.Empty;

		// Token: 0x04016469 RID: 91241
		public ELazyConditionKeyMatchType KeyMatchType = ELazyConditionKeyMatchType.没按键;

		// Token: 0x0401646A RID: 91242
		public bool Reverse;
	}
}
