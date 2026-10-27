using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003174 RID: 12660
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeFunctionXigelikaConsumeBean : CodeFunctionBase<SpecialSkillXigelika>
{
	// Token: 0x0601B3B1 RID: 111537 RVA: 0x0076DAEC File Offset: 0x0076BCEC
	public CodeFunctionXigelikaConsumeBean(SpecialSkillXigelika specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B3B2 RID: 111538 RVA: 0x0076DAF5 File Offset: 0x0076BCF5
	public override FKuroCodeFunctionResult Execute(FKuroCodeFunctionPayload payload)
	{
		this.SpecialSkill.ConsumeBean();
		return base.CreateSuccessResult();
	}

	// Token: 0x0400D472 RID: 54386
	public static readonly string FunctionName = "Xigelika.ConsumeBean";
}
