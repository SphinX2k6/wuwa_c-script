using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003173 RID: 12659
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeFunctionXigelikaAddBean : CodeFunctionBase<SpecialSkillXigelika>
{
	// Token: 0x0601B3AE RID: 111534 RVA: 0x0076DA80 File Offset: 0x0076BC80
	public CodeFunctionXigelikaAddBean(SpecialSkillXigelika specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B3AF RID: 111535 RVA: 0x0076DA8C File Offset: 0x0076BC8C
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

	// Token: 0x0400D46F RID: 54383
	private const string BEAN_PARAM = "Bean";

	// Token: 0x0400D470 RID: 54384
	private const string ADDED_COUNT_RESULT = "AddedCount";

	// Token: 0x0400D471 RID: 54385
	public static readonly string FunctionName = "Xigelika.AddBean";
}
