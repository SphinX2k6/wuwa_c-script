using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000C87 RID: 3207
[NullableContext(1)]
[Nullable(0)]
public class CheckEnergyCondition : BaseCheckCondition
{
	// Token: 0x06008615 RID: 34325 RVA: 0x0028EC58 File Offset: 0x0028CE58
	public CheckEnergyCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.SuccessType = EComboTeachingSuccessCondition.EnergyCheck;
		this.FailType = EComboTeachingFailCondition.EnergyCheck;
	}

	// Token: 0x17000F15 RID: 3861
	// (get) Token: 0x06008616 RID: 34326 RVA: 0x0028EC8C File Offset: 0x0028CE8C
	// (set) Token: 0x06008617 RID: 34327 RVA: 0x0028EC94 File Offset: 0x0028CE94
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000F16 RID: 3862
	// (get) Token: 0x06008618 RID: 34328 RVA: 0x0028EC9D File Offset: 0x0028CE9D
	// (set) Token: 0x06008619 RID: 34329 RVA: 0x0028ECA5 File Offset: 0x0028CEA5
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.EnergyCheck;

	// Token: 0x17000F17 RID: 3863
	// (get) Token: 0x0600861A RID: 34330 RVA: 0x0028ECAE File Offset: 0x0028CEAE
	// (set) Token: 0x0600861B RID: 34331 RVA: 0x0028ECB6 File Offset: 0x0028CEB6
	protected override EComboTeachingFailCondition FailType { get; set; } = EComboTeachingFailCondition.EnergyCheck;

	// Token: 0x0600861C RID: 34332 RVA: 0x0028ECC0 File Offset: 0x0028CEC0
	protected override bool CheckSuccess(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		if (this.SuccessParamsArray == null)
		{
			return false;
		}
		List<string> list = this.SuccessParamsArray[0];
		BaseAttributeComponent playerComponent = BaseCheckCondition.GetPlayerComponent<BaseAttributeComponent>();
		if (playerComponent == null)
		{
			return false;
		}
		float currentValue = playerComponent.GetCurrentValue(CharacterAttributeTypes.energyAttrIds[int.Parse(list[0])]);
		return currentValue >= float.Parse(list[1]) && currentValue <= float.Parse(list[2]);
	}

	// Token: 0x0600861D RID: 34333 RVA: 0x0028ED2C File Offset: 0x0028CF2C
	protected override bool CheckFail(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		if (this.ParamsArray == null)
		{
			return false;
		}
		BaseAttributeComponent playerComponent = BaseCheckCondition.GetPlayerComponent<BaseAttributeComponent>();
		if (playerComponent == null)
		{
			return false;
		}
		float currentValue = playerComponent.GetCurrentValue(CharacterAttributeTypes.energyAttrIds[int.Parse(this.ParamsArray[0])]);
		return currentValue >= float.Parse(this.ParamsArray[1]) && currentValue <= float.Parse(this.ParamsArray[2]);
	}
}
