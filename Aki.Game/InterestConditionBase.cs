using System;
using System.Runtime.CompilerServices;

// Token: 0x0200320D RID: 12813
[NullableContext(1)]
[Nullable(0)]
public class InterestConditionBase
{
	// Token: 0x1700263B RID: 9787
	// (get) Token: 0x0601BA3E RID: 113214 RVA: 0x00797DBB File Offset: 0x00795FBB
	public virtual EInterestConditionType Type
	{
		get
		{
			return EInterestConditionType.Angle;
		}
	}

	// Token: 0x0601BA3F RID: 113215 RVA: 0x00797DBE File Offset: 0x00795FBE
	public virtual bool CheckCondition(Entity entity, InterestItemBase item)
	{
		return false;
	}

	// Token: 0x0400D959 RID: 55641
	[StaticVariableRuleIgnore]
	protected static Vector TmpVector1 = Vector.Create();
}
