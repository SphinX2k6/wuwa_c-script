using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003175 RID: 12661
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeFunctionXigelikaGetBeanResultant : CodeFunctionBase<SpecialSkillXigelika>
{
	// Token: 0x0601B3B4 RID: 111540 RVA: 0x0076DB14 File Offset: 0x0076BD14
	public CodeFunctionXigelikaGetBeanResultant(SpecialSkillXigelika specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B3B5 RID: 111541 RVA: 0x0076DB1D File Offset: 0x0076BD1D
	public override FKuroCodeFunctionResult Execute(FKuroCodeFunctionPayload payload)
	{
		FKuroCodeFunctionResult fkuroCodeFunctionResult = base.CreateSuccessResult();
		fkuroCodeFunctionResult.Values.IntValues.Add("Resultant", this.SpecialSkill.GetBeanResultant());
		return fkuroCodeFunctionResult;
	}

	// Token: 0x0400D473 RID: 54387
	private const string RESULTANT_RESULT = "Resultant";

	// Token: 0x0400D474 RID: 54388
	public static readonly string FunctionName = "Xigelika.GetBeanResultant";
}
