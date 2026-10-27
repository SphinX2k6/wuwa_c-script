using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;

// Token: 0x020017D8 RID: 6104
[NullableContext(1)]
[Nullable(0)]
public class CheckIsInJumpCondition : BaseCheckCondition
{
	// Token: 0x0600B271 RID: 45681 RVA: 0x00284E39 File Offset: 0x00283039
	public CheckIsInJumpCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.FailType = EComboTeachingFailCondition.NotInJump;
	}

	// Token: 0x17000F09 RID: 3849
	// (get) Token: 0x0600B272 RID: 45682 RVA: 0x00284E5F File Offset: 0x0028305F
	// (set) Token: 0x0600B273 RID: 45683 RVA: 0x00284E67 File Offset: 0x00283067
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000F0A RID: 3850
	// (get) Token: 0x0600B274 RID: 45684 RVA: 0x00284E70 File Offset: 0x00283070
	// (set) Token: 0x0600B275 RID: 45685 RVA: 0x00284E78 File Offset: 0x00283078
	protected override EComboTeachingFailCondition FailType { get; set; } = EComboTeachingFailCondition.NotInJump;

	// Token: 0x0600B276 RID: 45686 RVA: 0x00284E84 File Offset: 0x00283084
	public override bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		int entityIdNoBlueprint = Global.BaseCharacter.GetEntityIdNoBlueprint();
		Entity entity = EntitySystem.Instance.Get(entityIdNoBlueprint);
		object obj = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		bool flag = ComboTeachingModel.Instance.BeforeJumpTime > 0f;
		object obj2 = obj;
		bool? flag2 = (obj2 != null) ? new bool?(obj2.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"])) : null;
		return !flag && flag2.GetValueOrDefault();
	}
}
