using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026E2 RID: 9954
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeFunctionXigelikaGetBeanResultant : CodeFunctionBase<SpecialSkillXigelika>
{
	// Token: 0x06018EB9 RID: 102073 RVA: 0x00795478 File Offset: 0x00793678
	public CodeFunctionXigelikaGetBeanResultant(SpecialSkillXigelika specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018EBA RID: 102074 RVA: 0x00795481 File Offset: 0x00793681
	public override FKuroCodeFunctionResult Execute(FKuroCodeFunctionPayload payload)
	{
		FKuroCodeFunctionResult fkuroCodeFunctionResult = base.CreateSuccessResult();
		fkuroCodeFunctionResult.Values.IntValues.Add("Resultant", this.SpecialSkill.GetBeanResultant());
		return fkuroCodeFunctionResult;
	}

	// Token: 0x0400D8D6 RID: 55510
	private const string RESULTANT_RESULT = "Resultant";

	// Token: 0x0400D8D7 RID: 55511
	public static readonly string FunctionName = "Xigelika.GetBeanResultant";
}
