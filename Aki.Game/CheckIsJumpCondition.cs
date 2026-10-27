using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;

// Token: 0x020017CF RID: 6095
[NullableContext(1)]
[Nullable(0)]
public class CheckIsJumpCondition : BaseCheckCondition
{
	// Token: 0x0600B235 RID: 45621 RVA: 0x002846A8 File Offset: 0x002828A8
	public CheckIsJumpCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.SuccessType = EComboTeachingSuccessCondition.Jump;
	}

	// Token: 0x17000EF5 RID: 3829
	// (get) Token: 0x0600B236 RID: 45622 RVA: 0x002846CE File Offset: 0x002828CE
	// (set) Token: 0x0600B237 RID: 45623 RVA: 0x002846D6 File Offset: 0x002828D6
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000EF6 RID: 3830
	// (get) Token: 0x0600B238 RID: 45624 RVA: 0x002846DF File Offset: 0x002828DF
	// (set) Token: 0x0600B239 RID: 45625 RVA: 0x002846E7 File Offset: 0x002828E7
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.Jump;

	// Token: 0x0600B23A RID: 45626 RVA: 0x002846F0 File Offset: 0x002828F0
	public override bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		int entityIdNoBlueprint = Global.BaseCharacter.GetEntityIdNoBlueprint();
		Entity entity = EntitySystem.Instance.Get(entityIdNoBlueprint);
		CharacterMoveComponent characterMoveComponent = (entity != null) ? entity.GetComponent<CharacterMoveComponent>() : null;
		return characterMoveComponent != null && characterMoveComponent.IsJump;
	}
}
