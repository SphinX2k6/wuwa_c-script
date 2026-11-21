using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C90 RID: 3216
[NullableContext(1)]
[Nullable(0)]
public class CheckNotInSkillCondition : BaseCheckCondition
{
	// Token: 0x06008654 RID: 34388 RVA: 0x0028F39A File Offset: 0x0028D59A
	public CheckNotInSkillCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.FailType = EComboTeachingFailCondition.InSkillChecker;
	}

	// Token: 0x17000F2A RID: 3882
	// (get) Token: 0x06008655 RID: 34389 RVA: 0x0028F3C0 File Offset: 0x0028D5C0
	// (set) Token: 0x06008656 RID: 34390 RVA: 0x0028F3C8 File Offset: 0x0028D5C8
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000F2B RID: 3883
	// (get) Token: 0x06008657 RID: 34391 RVA: 0x0028F3D1 File Offset: 0x0028D5D1
	// (set) Token: 0x06008658 RID: 34392 RVA: 0x0028F3D9 File Offset: 0x0028D5D9
	protected override EComboTeachingFailCondition FailType { get; set; } = EComboTeachingFailCondition.InSkillChecker;

	// Token: 0x06008659 RID: 34393 RVA: 0x0028F3E2 File Offset: 0x0028D5E2
	public override bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		BaseTagComponent playerComponent = BaseCheckCondition.GetPlayerComponent<BaseTagComponent>();
		return playerComponent == null || !playerComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]);
	}
}
