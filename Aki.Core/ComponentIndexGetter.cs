using System;

// Token: 0x0200007E RID: 126
[StaticVariableRuleIgnore]
public static class ComponentIndexGetter<T> where T : EntityComponent
{
	// Token: 0x040003A6 RID: 934
	public static int Index = EntityComponentConstant.GetComponentIndex(typeof(T));
}
