using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;

// Token: 0x020017CE RID: 6094
[NullableContext(1)]
[Nullable(0)]
public class CheckEnergyCondition : BaseCheckCondition
{
	// Token: 0x0600B22C RID: 45612 RVA: 0x00284548 File Offset: 0x00282748
	public CheckEnergyCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.SuccessType = EComboTeachingSuccessCondition.EnergyCheck;
		this.FailType = EComboTeachingFailCondition.EnergyCheck;
	}

	// Token: 0x17000EF2 RID: 3826
	// (get) Token: 0x0600B22D RID: 45613 RVA: 0x0028457C File Offset: 0x0028277C
	// (set) Token: 0x0600B22E RID: 45614 RVA: 0x00284584 File Offset: 0x00282784
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000EF3 RID: 3827
	// (get) Token: 0x0600B22F RID: 45615 RVA: 0x0028458D File Offset: 0x0028278D
	// (set) Token: 0x0600B230 RID: 45616 RVA: 0x00284595 File Offset: 0x00282795
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.EnergyCheck;

	// Token: 0x17000EF4 RID: 3828
	// (get) Token: 0x0600B231 RID: 45617 RVA: 0x0028459E File Offset: 0x0028279E
	// (set) Token: 0x0600B232 RID: 45618 RVA: 0x002845A6 File Offset: 0x002827A6
	protected override EComboTeachingFailCondition FailType { get; set; } = EComboTeachingFailCondition.EnergyCheck;

	// Token: 0x0600B233 RID: 45619 RVA: 0x002845B0 File Offset: 0x002827B0
	protected override bool CheckSuccess(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		if (this.SuccessParamsArray == null)
		{
			return false;
		}
		List<string> list = this.SuccessParamsArray[0];
		int entityIdNoBlueprint = Global.BaseCharacter.GetEntityIdNoBlueprint();
		float currentValue = EntitySystem.Instance.Get(entityIdNoBlueprint).GetComponent<BaseAttributeComponent>().GetCurrentValue(CharacterAttributeTypes.energyAttrIds[int.Parse(list[0])]);
		return currentValue >= float.Parse(list[1]) && currentValue <= float.Parse(list[2]);
	}

	// Token: 0x0600B234 RID: 45620 RVA: 0x0028462C File Offset: 0x0028282C
	protected override bool CheckFail(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		if (this.ParamsArray == null)
		{
			return false;
		}
		int entityIdNoBlueprint = Global.BaseCharacter.GetEntityIdNoBlueprint();
		float currentValue = EntitySystem.Instance.Get(entityIdNoBlueprint).GetComponent<BaseAttributeComponent>().GetCurrentValue(CharacterAttributeTypes.energyAttrIds[int.Parse(this.ParamsArray[0])]);
		return currentValue >= float.Parse(this.ParamsArray[1]) && currentValue <= float.Parse(this.ParamsArray[2]);
	}
}
