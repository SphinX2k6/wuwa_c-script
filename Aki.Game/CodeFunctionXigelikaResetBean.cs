using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026E3 RID: 9955
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeFunctionXigelikaResetBean : CodeFunctionBase<SpecialSkillXigelika>
{
	// Token: 0x06018EBC RID: 102076 RVA: 0x007954B5 File Offset: 0x007936B5
	public CodeFunctionXigelikaResetBean(SpecialSkillXigelika specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018EBD RID: 102077 RVA: 0x007954BE File Offset: 0x007936BE
	public override FKuroCodeFunctionResult Execute(FKuroCodeFunctionPayload payload)
	{
		this.SpecialSkill.ResetBean();
		return base.CreateSuccessResult();
	}

	// Token: 0x0400D8D8 RID: 55512
	public static readonly string FunctionName = "Xigelika.ResetBean";
}
