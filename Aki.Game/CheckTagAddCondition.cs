using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;

// Token: 0x020017D1 RID: 6097
[NullableContext(1)]
[Nullable(0)]
public class CheckTagAddCondition : BaseCheckCondition
{
	// Token: 0x0600B241 RID: 45633 RVA: 0x00284814 File Offset: 0x00282A14
	public CheckTagAddCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.SuccessType = EComboTeachingSuccessCondition.AddTag;
	}

	// Token: 0x17000EF9 RID: 3833
	// (get) Token: 0x0600B242 RID: 45634 RVA: 0x0028483A File Offset: 0x00282A3A
	// (set) Token: 0x0600B243 RID: 45635 RVA: 0x00284842 File Offset: 0x00282A42
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000EFA RID: 3834
	// (get) Token: 0x0600B244 RID: 45636 RVA: 0x0028484B File Offset: 0x00282A4B
	// (set) Token: 0x0600B245 RID: 45637 RVA: 0x00284853 File Offset: 0x00282A53
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.AddTag;

	// Token: 0x0600B246 RID: 45638 RVA: 0x0028485C File Offset: 0x00282A5C
	public override bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo paramex = null)
	{
		if (this.SuccessParamsArray == null)
		{
			return false;
		}
		int entityIdNoBlueprint = Global.BaseCharacter.GetEntityIdNoBlueprint();
		Entity entity = EntitySystem.Instance.Get(entityIdNoBlueprint);
		BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		if (baseTagComponent == null)
		{
			return false;
		}
		foreach (List<string> list in this.SuccessParamsArray)
		{
			int tagIdByName = GameplayTagUtils.GetTagIdByName(list[0]);
			if (baseTagComponent.HasTag(tagIdByName))
			{
				return true;
			}
		}
		return false;
	}
}
