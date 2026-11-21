using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C91 RID: 3217
[NullableContext(1)]
[Nullable(0)]
public class CheckIsInJumpCondition : BaseCheckCondition
{
	// Token: 0x0600865A RID: 34394 RVA: 0x0028F407 File Offset: 0x0028D607
	public CheckIsInJumpCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.FailType = EComboTeachingFailCondition.NotInJump;
	}

	// Token: 0x17000F2C RID: 3884
	// (get) Token: 0x0600865B RID: 34395 RVA: 0x0028F42D File Offset: 0x0028D62D
	// (set) Token: 0x0600865C RID: 34396 RVA: 0x0028F435 File Offset: 0x0028D635
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000F2D RID: 3885
	// (get) Token: 0x0600865D RID: 34397 RVA: 0x0028F43E File Offset: 0x0028D63E
	// (set) Token: 0x0600865E RID: 34398 RVA: 0x0028F446 File Offset: 0x0028D646
	protected override EComboTeachingFailCondition FailType { get; set; } = EComboTeachingFailCondition.NotInJump;

	// Token: 0x0600865F RID: 34399 RVA: 0x0028F450 File Offset: 0x0028D650
	public override bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		BaseTagComponent playerComponent = BaseCheckCondition.GetPlayerComponent<BaseTagComponent>();
		bool flag = ComboTeachingModel.Instance.BeforeJumpTime > 0f;
		bool? flag2 = (playerComponent != null) ? new bool?(playerComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"])) : null;
		return !flag && flag2.GetValueOrDefault();
	}
}
