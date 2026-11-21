using System;
using System.Runtime.CompilerServices;

// Token: 0x0200277C RID: 10108
[NullableContext(1)]
[Nullable(0)]
public class InterestConditionBase
{
	// Token: 0x1700287C RID: 10364
	// (get) Token: 0x060195C3 RID: 103875 RVA: 0x007C051B File Offset: 0x007BE71B
	public virtual EInterestConditionType Type
	{
		get
		{
			return EInterestConditionType.Angle;
		}
	}

	// Token: 0x060195C4 RID: 103876 RVA: 0x007C051E File Offset: 0x007BE71E
	public virtual bool CheckCondition(Entity entity, InterestItemBase item)
	{
		return false;
	}

	// Token: 0x0400DDF8 RID: 56824
	[StaticVariableRuleIgnore]
	protected static Vector TmpVector1 = Vector.Create();
}
