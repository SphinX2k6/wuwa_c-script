using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.QuickTimeAction;

namespace CSharpScript.Game.Module.QuickTimeAction.Condition
{
	// Token: 0x02003F1F RID: 16159
	public class CfgLazyConditionForTag : CfgLazyConditionBase
	{
		// Token: 0x06028F71 RID: 167793 RVA: 0x00B7F756 File Offset: 0x00B7D956
		public CfgLazyConditionForTag()
		{
			this.ConditionType = new ELazyConditionType?(ELazyConditionType.标签检测);
		}

		// Token: 0x06028F72 RID: 167794 RVA: 0x00B7F76A File Offset: 0x00B7D96A
		[NullableContext(1)]
		public void InitForQta(SQtaCondition_Content ueCondition)
		{
			this.TagToCheck = GameplayTagUtils.ConvertFromUeContainer(ueCondition.Tags);
			this.AnyTag = ueCondition.AnyTag;
			this.Reverse = ueCondition.Reverse;
		}

		// Token: 0x04016465 RID: 91237
		[Nullable(2)]
		public IEnumerable<int> TagToCheck;

		// Token: 0x04016466 RID: 91238
		public bool AnyTag;

		// Token: 0x04016467 RID: 91239
		public bool Reverse;
	}
}
