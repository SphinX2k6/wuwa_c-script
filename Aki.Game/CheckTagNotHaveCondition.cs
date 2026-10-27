using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;

// Token: 0x020017D3 RID: 6099
[NullableContext(1)]
[Nullable(0)]
public class CheckTagNotHaveCondition : BaseCheckCondition
{
	// Token: 0x0600B250 RID: 45648 RVA: 0x00284A68 File Offset: 0x00282C68
	public CheckTagNotHaveCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.FailType = EComboTeachingFailCondition.NotHaveTag;
		this.SuccessType = EComboTeachingSuccessCondition.NotHaveTag;
	}

	// Token: 0x17000EFE RID: 3838
	// (get) Token: 0x0600B251 RID: 45649 RVA: 0x00284A9C File Offset: 0x00282C9C
	// (set) Token: 0x0600B252 RID: 45650 RVA: 0x00284AA4 File Offset: 0x00282CA4
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000EFF RID: 3839
	// (get) Token: 0x0600B253 RID: 45651 RVA: 0x00284AAD File Offset: 0x00282CAD
	// (set) Token: 0x0600B254 RID: 45652 RVA: 0x00284AB5 File Offset: 0x00282CB5
	protected override EComboTeachingFailCondition FailType { get; set; } = EComboTeachingFailCondition.NotHaveTag;

	// Token: 0x17000F00 RID: 3840
	// (get) Token: 0x0600B255 RID: 45653 RVA: 0x00284ABE File Offset: 0x00282CBE
	// (set) Token: 0x0600B256 RID: 45654 RVA: 0x00284AC6 File Offset: 0x00282CC6
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.NotHaveTag;

	// Token: 0x0600B257 RID: 45655 RVA: 0x00284AD0 File Offset: 0x00282CD0
	protected override bool CheckFail(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		if (this.ParamsArray == null)
		{
			return false;
		}
		int entityIdNoBlueprint = Global.BaseCharacter.GetEntityIdNoBlueprint();
		Entity entity = EntitySystem.Instance.Get(entityIdNoBlueprint);
		BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		return baseTagComponent == null || !baseTagComponent.HasTag(GameplayTagUtils.GetTagIdByName(this.ParamsArray[0]));
	}

	// Token: 0x0600B258 RID: 45656 RVA: 0x00284B2C File Offset: 0x00282D2C
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
		BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		if (baseTagComponent == null)
		{
			return false;
		}
		foreach (List<string> list in this.SuccessParamsArray)
		{
			if (!baseTagComponent.HasTag(GameplayTagUtils.GetTagIdByName(list[0])))
			{
				return true;
			}
		}
		return false;
	}
}
