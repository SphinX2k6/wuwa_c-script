using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;

// Token: 0x020017D0 RID: 6096
[NullableContext(1)]
[Nullable(0)]
public class CheckBuffAddCondition : BaseCheckCondition
{
	// Token: 0x0600B23B RID: 45627 RVA: 0x0028472A File Offset: 0x0028292A
	public CheckBuffAddCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.SuccessType = EComboTeachingSuccessCondition.AddBuff;
	}

	// Token: 0x17000EF7 RID: 3831
	// (get) Token: 0x0600B23C RID: 45628 RVA: 0x00284750 File Offset: 0x00282950
	// (set) Token: 0x0600B23D RID: 45629 RVA: 0x00284758 File Offset: 0x00282958
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000EF8 RID: 3832
	// (get) Token: 0x0600B23E RID: 45630 RVA: 0x00284761 File Offset: 0x00282961
	// (set) Token: 0x0600B23F RID: 45631 RVA: 0x00284769 File Offset: 0x00282969
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.AddBuff;

	// Token: 0x0600B240 RID: 45632 RVA: 0x00284774 File Offset: 0x00282974
	public override bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo paramex = null)
	{
		if (this.SuccessParamsArray == null)
		{
			return false;
		}
		int entityIdNoBlueprint = Global.BaseCharacter.GetEntityIdNoBlueprint();
		Entity entity = EntitySystem.Instance.Get(entityIdNoBlueprint);
		CharacterBuffComponent characterBuffComponent = (entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null;
		if (characterBuffComponent == null)
		{
			return false;
		}
		foreach (List<string> list in this.SuccessParamsArray)
		{
			if (characterBuffComponent.GetBuffTotalStackById(long.Parse(list[0]), false) > 0)
			{
				return true;
			}
		}
		return false;
	}
}
