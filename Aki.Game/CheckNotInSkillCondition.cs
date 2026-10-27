using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;

// Token: 0x020017D7 RID: 6103
[NullableContext(1)]
[Nullable(0)]
public class CheckNotInSkillCondition : BaseCheckCondition
{
	// Token: 0x0600B26B RID: 45675 RVA: 0x00284DA4 File Offset: 0x00282FA4
	public CheckNotInSkillCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.FailType = EComboTeachingFailCondition.InSkillChecker;
	}

	// Token: 0x17000F07 RID: 3847
	// (get) Token: 0x0600B26C RID: 45676 RVA: 0x00284DCA File Offset: 0x00282FCA
	// (set) Token: 0x0600B26D RID: 45677 RVA: 0x00284DD2 File Offset: 0x00282FD2
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000F08 RID: 3848
	// (get) Token: 0x0600B26E RID: 45678 RVA: 0x00284DDB File Offset: 0x00282FDB
	// (set) Token: 0x0600B26F RID: 45679 RVA: 0x00284DE3 File Offset: 0x00282FE3
	protected override EComboTeachingFailCondition FailType { get; set; } = EComboTeachingFailCondition.InSkillChecker;

	// Token: 0x0600B270 RID: 45680 RVA: 0x00284DEC File Offset: 0x00282FEC
	public override bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		int entityIdNoBlueprint = Global.BaseCharacter.GetEntityIdNoBlueprint();
		Entity entity = EntitySystem.Instance.Get(entityIdNoBlueprint);
		BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		return baseTagComponent == null || !baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]);
	}
}
