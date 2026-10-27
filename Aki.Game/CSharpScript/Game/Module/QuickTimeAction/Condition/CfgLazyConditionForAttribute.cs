using System;
using AkiClient.Game.Aki.Character.BaseCharacter;

namespace CSharpScript.Game.Module.QuickTimeAction.Condition
{
	// Token: 0x02004F55 RID: 20309
	public class CfgLazyConditionForAttribute : CfgLazyConditionBase
	{
		// Token: 0x06034102 RID: 213250 RVA: 0x00C35FA2 File Offset: 0x00C341A2
		public CfgLazyConditionForAttribute()
		{
			this.ConditionType = new ELazyConditionType?(ELazyConditionType.属性检测);
		}

		// Token: 0x0401BA88 RID: 113288
		public ESkillBehaviorComparisonLogic ComparisonLogic;

		// Token: 0x0401BA89 RID: 113289
		public int Value;

		// Token: 0x0401BA8A RID: 113290
		public int RangeL;

		// Token: 0x0401BA8B RID: 113291
		public int RangeR;

		// Token: 0x0401BA8C RID: 113292
		public int AttributeId1;

		// Token: 0x0401BA8D RID: 113293
		public int AttributeId2;

		// Token: 0x0401BA8E RID: 113294
		public int AttributeRate;

		// Token: 0x0401BA8F RID: 113295
		public bool Reverse;
	}
}
