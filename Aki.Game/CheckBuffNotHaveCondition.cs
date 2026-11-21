using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000C8B RID: 3211
[NullableContext(1)]
[Nullable(0)]
public class CheckBuffNotHaveCondition : BaseCheckCondition
{
	// Token: 0x06008630 RID: 34352 RVA: 0x0028EF80 File Offset: 0x0028D180
	public CheckBuffNotHaveCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.FailType = EComboTeachingFailCondition.NotHaveBuff;
		this.SuccessType = EComboTeachingSuccessCondition.NotHaveBuff;
	}

	// Token: 0x17000F1E RID: 3870
	// (get) Token: 0x06008631 RID: 34353 RVA: 0x0028EFB4 File Offset: 0x0028D1B4
	// (set) Token: 0x06008632 RID: 34354 RVA: 0x0028EFBC File Offset: 0x0028D1BC
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000F1F RID: 3871
	// (get) Token: 0x06008633 RID: 34355 RVA: 0x0028EFC5 File Offset: 0x0028D1C5
	// (set) Token: 0x06008634 RID: 34356 RVA: 0x0028EFCD File Offset: 0x0028D1CD
	protected override EComboTeachingFailCondition FailType { get; set; } = EComboTeachingFailCondition.NotHaveBuff;

	// Token: 0x17000F20 RID: 3872
	// (get) Token: 0x06008635 RID: 34357 RVA: 0x0028EFD6 File Offset: 0x0028D1D6
	// (set) Token: 0x06008636 RID: 34358 RVA: 0x0028EFDE File Offset: 0x0028D1DE
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.NotHaveBuff;

	// Token: 0x06008637 RID: 34359 RVA: 0x0028EFE7 File Offset: 0x0028D1E7
	protected override bool CheckFail(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		if (this.ParamsArray == null)
		{
			return false;
		}
		CharacterBuffComponent playerComponent = BaseCheckCondition.GetPlayerComponent<CharacterBuffComponent>();
		return playerComponent == null || playerComponent.GetBuffTotalStackById(long.Parse(this.ParamsArray[0]), false) <= 0;
	}

	// Token: 0x06008638 RID: 34360 RVA: 0x0028F01C File Offset: 0x0028D21C
	protected override bool CheckSuccess(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo paramex = null)
	{
		if (this.SuccessParamsArray == null)
		{
			return false;
		}
		CharacterBuffComponent playerComponent = BaseCheckCondition.GetPlayerComponent<CharacterBuffComponent>();
		if (playerComponent == null)
		{
			return false;
		}
		foreach (List<string> list in this.SuccessParamsArray)
		{
			if (playerComponent.GetBuffTotalStackById(long.Parse(list[0]), false) == 0)
			{
				return true;
			}
		}
		return false;
	}
}
