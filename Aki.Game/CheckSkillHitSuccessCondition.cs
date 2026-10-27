using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020017CD RID: 6093
[NullableContext(1)]
[Nullable(0)]
public class CheckSkillHitSuccessCondition : BaseCheckCondition
{
	// Token: 0x0600B226 RID: 45606 RVA: 0x00284488 File Offset: 0x00282688
	public CheckSkillHitSuccessCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Event;
		this.SuccessType = EComboTeachingSuccessCondition.SkillIdHit;
	}

	// Token: 0x17000EF0 RID: 3824
	// (get) Token: 0x0600B227 RID: 45607 RVA: 0x002844A7 File Offset: 0x002826A7
	// (set) Token: 0x0600B228 RID: 45608 RVA: 0x002844AF File Offset: 0x002826AF
	public override EComboTeachingCheckType Type { get; set; }

	// Token: 0x17000EF1 RID: 3825
	// (get) Token: 0x0600B229 RID: 45609 RVA: 0x002844B8 File Offset: 0x002826B8
	// (set) Token: 0x0600B22A RID: 45610 RVA: 0x002844C0 File Offset: 0x002826C0
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.SkillIdHit;

	// Token: 0x0600B22B RID: 45611 RVA: 0x002844CC File Offset: 0x002826CC
	public override bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo extra = null)
	{
		ICheckSkillHitCondition checkSkillHitCondition = extra as ICheckSkillHitCondition;
		if (this.SuccessParamsArray == null || checkSkillHitCondition == null)
		{
			return false;
		}
		foreach (List<string> list in this.SuccessParamsArray)
		{
			if (checkSkillHitCondition.HitSkillId == (long)int.Parse(list[0]))
			{
				return true;
			}
		}
		return false;
	}
}
