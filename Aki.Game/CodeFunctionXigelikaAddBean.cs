using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026E0 RID: 9952
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeFunctionXigelikaAddBean : CodeFunctionBase<SpecialSkillXigelika>
{
	// Token: 0x06018EB3 RID: 102067 RVA: 0x007953E4 File Offset: 0x007935E4
	public CodeFunctionXigelikaAddBean(SpecialSkillXigelika specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018EB4 RID: 102068 RVA: 0x007953F0 File Offset: 0x007935F0
	public override FKuroCodeFunctionResult Execute(FKuroCodeFunctionPayload payload)
	{
		string bean;
		if (!payload.StringValues.TryGetValue("Bean", out bean))
		{
			return base.CreateFailureResult("缺少String参数：Bean");
		}
		FKuroCodeFunctionResult fkuroCodeFunctionResult = base.CreateSuccessResult();
		fkuroCodeFunctionResult.Values.IntValues.Add("AddedCount", this.SpecialSkill.AddBean(bean));
		return fkuroCodeFunctionResult;
	}

	// Token: 0x0400D8D2 RID: 55506
	private const string BEAN_PARAM = "Bean";

	// Token: 0x0400D8D3 RID: 55507
	private const string ADDED_COUNT_RESULT = "AddedCount";

	// Token: 0x0400D8D4 RID: 55508
	public static readonly string FunctionName = "Xigelika.AddBean";
}
