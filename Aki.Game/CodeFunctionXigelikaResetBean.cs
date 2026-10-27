using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003176 RID: 12662
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeFunctionXigelikaResetBean : CodeFunctionBase<SpecialSkillXigelika>
{
	// Token: 0x0601B3B7 RID: 111543 RVA: 0x0076DB51 File Offset: 0x0076BD51
	public CodeFunctionXigelikaResetBean(SpecialSkillXigelika specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B3B8 RID: 111544 RVA: 0x0076DB5A File Offset: 0x0076BD5A
	public override FKuroCodeFunctionResult Execute(FKuroCodeFunctionPayload payload)
	{
		this.SpecialSkill.ResetBean();
		return base.CreateSuccessResult();
	}

	// Token: 0x0400D475 RID: 54389
	public static readonly string FunctionName = "Xigelika.ResetBean";
}
