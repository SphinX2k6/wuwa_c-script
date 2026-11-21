using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C88 RID: 3208
[NullableContext(1)]
[Nullable(0)]
public class CheckIsJumpCondition : BaseCheckCondition
{
	// Token: 0x0600861E RID: 34334 RVA: 0x0028ED99 File Offset: 0x0028CF99
	public CheckIsJumpCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.SuccessType = EComboTeachingSuccessCondition.Jump;
	}

	// Token: 0x17000F18 RID: 3864
	// (get) Token: 0x0600861F RID: 34335 RVA: 0x0028EDBF File Offset: 0x0028CFBF
	// (set) Token: 0x06008620 RID: 34336 RVA: 0x0028EDC7 File Offset: 0x0028CFC7
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000F19 RID: 3865
	// (get) Token: 0x06008621 RID: 34337 RVA: 0x0028EDD0 File Offset: 0x0028CFD0
	// (set) Token: 0x06008622 RID: 34338 RVA: 0x0028EDD8 File Offset: 0x0028CFD8
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.Jump;

	// Token: 0x06008623 RID: 34339 RVA: 0x0028EDE1 File Offset: 0x0028CFE1
	public override bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		CharacterMoveComponent playerComponent = BaseCheckCondition.GetPlayerComponent<CharacterMoveComponent>();
		return playerComponent != null && playerComponent.IsJump;
	}
}
