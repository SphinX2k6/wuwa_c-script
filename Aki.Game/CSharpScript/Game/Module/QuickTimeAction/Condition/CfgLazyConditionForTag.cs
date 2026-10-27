using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.QuickTimeAction;

namespace CSharpScript.Game.Module.QuickTimeAction.Condition
{
	// Token: 0x02004F56 RID: 20310
	public class CfgLazyConditionForTag : CfgLazyConditionBase
	{
		// Token: 0x06034103 RID: 213251 RVA: 0x00C35FB6 File Offset: 0x00C341B6
		public CfgLazyConditionForTag()
		{
			this.ConditionType = new ELazyConditionType?(ELazyConditionType.标签检测);
		}

		// Token: 0x06034104 RID: 213252 RVA: 0x00C35FCA File Offset: 0x00C341CA
		[NullableContext(1)]
		public void InitForQta(SQtaCondition_Content ueCondition)
		{
			this.TagToCheck = GameplayTagUtils.ConvertFromUeContainer(ueCondition.Tags);
			this.AnyTag = ueCondition.AnyTag;
			this.Reverse = ueCondition.Reverse;
		}

		// Token: 0x0401BA90 RID: 113296
		[Nullable(2)]
		public IEnumerable<int> TagToCheck;

		// Token: 0x0401BA91 RID: 113297
		public bool AnyTag;

		// Token: 0x0401BA92 RID: 113298
		public bool Reverse;
	}
}
