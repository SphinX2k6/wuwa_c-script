using System;
using AkiClient.Game.Aki.Character.BaseCharacter;

namespace CSharpScript.Game.Module.QuickTimeAction.Condition
{
	// Token: 0x02003F1E RID: 16158
	public class CfgLazyConditionForAttribute : CfgLazyConditionBase
	{
		// Token: 0x06028F70 RID: 167792 RVA: 0x00B7F742 File Offset: 0x00B7D942
		public CfgLazyConditionForAttribute()
		{
			this.ConditionType = new ELazyConditionType?(ELazyConditionType.属性检测);
		}

		// Token: 0x0401645D RID: 91229
		public ESkillBehaviorComparisonLogic ComparisonLogic;

		// Token: 0x0401645E RID: 91230
		public int Value;

		// Token: 0x0401645F RID: 91231
		public int RangeL;

		// Token: 0x04016460 RID: 91232
		public int RangeR;

		// Token: 0x04016461 RID: 91233
		public int AttributeId1;

		// Token: 0x04016462 RID: 91234
		public int AttributeId2;

		// Token: 0x04016463 RID: 91235
		public int AttributeRate;

		// Token: 0x04016464 RID: 91236
		public bool Reverse;
	}
}
