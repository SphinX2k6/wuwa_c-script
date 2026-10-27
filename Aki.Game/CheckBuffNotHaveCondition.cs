using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;

// Token: 0x020017D2 RID: 6098
[NullableContext(1)]
[Nullable(0)]
public class CheckBuffNotHaveCondition : BaseCheckCondition
{
	// Token: 0x0600B247 RID: 45639 RVA: 0x002848F8 File Offset: 0x00282AF8
	public CheckBuffNotHaveCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.FailType = EComboTeachingFailCondition.NotHaveBuff;
		this.SuccessType = EComboTeachingSuccessCondition.NotHaveBuff;
	}

	// Token: 0x17000EFB RID: 3835
	// (get) Token: 0x0600B248 RID: 45640 RVA: 0x0028492C File Offset: 0x00282B2C
	// (set) Token: 0x0600B249 RID: 45641 RVA: 0x00284934 File Offset: 0x00282B34
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000EFC RID: 3836
	// (get) Token: 0x0600B24A RID: 45642 RVA: 0x0028493D File Offset: 0x00282B3D
	// (set) Token: 0x0600B24B RID: 45643 RVA: 0x00284945 File Offset: 0x00282B45
	protected override EComboTeachingFailCondition FailType { get; set; } = EComboTeachingFailCondition.NotHaveBuff;

	// Token: 0x17000EFD RID: 3837
	// (get) Token: 0x0600B24C RID: 45644 RVA: 0x0028494E File Offset: 0x00282B4E
	// (set) Token: 0x0600B24D RID: 45645 RVA: 0x00284956 File Offset: 0x00282B56
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.NotHaveBuff;

	// Token: 0x0600B24E RID: 45646 RVA: 0x00284960 File Offset: 0x00282B60
	protected override bool CheckFail(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		if (this.ParamsArray == null)
		{
			return false;
		}
		int entityIdNoBlueprint = Global.BaseCharacter.GetEntityIdNoBlueprint();
		Entity entity = EntitySystem.Instance.Get(entityIdNoBlueprint);
		CharacterBuffComponent characterBuffComponent = (entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null;
		return characterBuffComponent == null || characterBuffComponent.GetBuffTotalStackById(long.Parse(this.ParamsArray[0]), false) <= 0;
	}

	// Token: 0x0600B24F RID: 45647 RVA: 0x002849C0 File Offset: 0x00282BC0
	protected override bool CheckSuccess(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo paramex = null)
	{
		if (this.SuccessParamsArray == null)
		{
			return false;
		}
		int entityIdNoBlueprint = Global.BaseCharacter.GetEntityIdNoBlueprint();
		Entity entity = EntitySystem.Instance.Get(entityIdNoBlueprint);
		if (entity == null)
		{
			return false;
		}
		CharacterBuffComponent characterBuffComponent = (entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null;
		if (characterBuffComponent == null)
		{
			return false;
		}
		foreach (List<string> list in this.SuccessParamsArray)
		{
			if (characterBuffComponent != null && characterBuffComponent.GetBuffTotalStackById(long.Parse(list[0]), false) == 0)
			{
				return true;
			}
		}
		return false;
	}
}
