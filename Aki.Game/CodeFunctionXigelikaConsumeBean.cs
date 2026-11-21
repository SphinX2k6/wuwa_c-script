using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026E1 RID: 9953
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeFunctionXigelikaConsumeBean : CodeFunctionBase<SpecialSkillXigelika>
{
	// Token: 0x06018EB6 RID: 102070 RVA: 0x00795450 File Offset: 0x00793650
	public CodeFunctionXigelikaConsumeBean(SpecialSkillXigelika specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018EB7 RID: 102071 RVA: 0x00795459 File Offset: 0x00793659
	public override FKuroCodeFunctionResult Execute(FKuroCodeFunctionPayload payload)
	{
		this.SpecialSkill.ConsumeBean();
		return base.CreateSuccessResult();
	}

	// Token: 0x0400D8D5 RID: 55509
	public static readonly string FunctionName = "Xigelika.ConsumeBean";
}
