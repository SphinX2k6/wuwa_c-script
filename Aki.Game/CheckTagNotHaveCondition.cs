using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000C8C RID: 3212
[NullableContext(1)]
[Nullable(0)]
public class CheckTagNotHaveCondition : BaseCheckCondition
{
	// Token: 0x06008639 RID: 34361 RVA: 0x0028F09C File Offset: 0x0028D29C
	public CheckTagNotHaveCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.FailType = EComboTeachingFailCondition.NotHaveTag;
		this.SuccessType = EComboTeachingSuccessCondition.NotHaveTag;
	}

	// Token: 0x17000F21 RID: 3873
	// (get) Token: 0x0600863A RID: 34362 RVA: 0x0028F0D0 File Offset: 0x0028D2D0
	// (set) Token: 0x0600863B RID: 34363 RVA: 0x0028F0D8 File Offset: 0x0028D2D8
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000F22 RID: 3874
	// (get) Token: 0x0600863C RID: 34364 RVA: 0x0028F0E1 File Offset: 0x0028D2E1
	// (set) Token: 0x0600863D RID: 34365 RVA: 0x0028F0E9 File Offset: 0x0028D2E9
	protected override EComboTeachingFailCondition FailType { get; set; } = EComboTeachingFailCondition.NotHaveTag;

	// Token: 0x17000F23 RID: 3875
	// (get) Token: 0x0600863E RID: 34366 RVA: 0x0028F0F2 File Offset: 0x0028D2F2
	// (set) Token: 0x0600863F RID: 34367 RVA: 0x0028F0FA File Offset: 0x0028D2FA
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.NotHaveTag;

	// Token: 0x06008640 RID: 34368 RVA: 0x0028F103 File Offset: 0x0028D303
	protected override bool CheckFail(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		if (this.ParamsArray == null)
		{
			return false;
		}
		BaseTagComponent playerComponent = BaseCheckCondition.GetPlayerComponent<BaseTagComponent>();
		return playerComponent == null || !playerComponent.HasTag(GameplayTagUtils.GetTagIdByName(this.ParamsArray[0]));
	}

	// Token: 0x06008641 RID: 34369 RVA: 0x0028F134 File Offset: 0x0028D334
	protected override bool CheckSuccess(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo paramex = null)
	{
		if (this.SuccessParamsArray == null)
		{
			return false;
		}
		BaseTagComponent playerComponent = BaseCheckCondition.GetPlayerComponent<BaseTagComponent>();
		if (playerComponent == null)
		{
			return false;
		}
		foreach (List<string> list in this.SuccessParamsArray)
		{
			if (!playerComponent.HasTag(GameplayTagUtils.GetTagIdByName(list[0])))
			{
				return true;
			}
		}
		return false;
	}
}
