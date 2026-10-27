using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020017D9 RID: 6105
[NullableContext(1)]
[Nullable(0)]
public class CheckBulletHitCondition : BaseCheckCondition
{
	// Token: 0x0600B277 RID: 45687 RVA: 0x00284EFA File Offset: 0x002830FA
	public CheckBulletHitCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Event;
		this.SuccessType = EComboTeachingSuccessCondition.BulletHit;
	}

	// Token: 0x17000F0B RID: 3851
	// (get) Token: 0x0600B278 RID: 45688 RVA: 0x00284F1B File Offset: 0x0028311B
	// (set) Token: 0x0600B279 RID: 45689 RVA: 0x00284F23 File Offset: 0x00283123
	public override EComboTeachingCheckType Type { get; set; }

	// Token: 0x17000F0C RID: 3852
	// (get) Token: 0x0600B27A RID: 45690 RVA: 0x00284F2C File Offset: 0x0028312C
	// (set) Token: 0x0600B27B RID: 45691 RVA: 0x00284F34 File Offset: 0x00283134
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.BulletHit;

	// Token: 0x0600B27C RID: 45692 RVA: 0x00284F40 File Offset: 0x00283140
	public override bool Check(IComboTeachingInfo node, [Nullable(2)] IBaseCheckConditionInfo extra = null)
	{
		ICheckSkillHitCondition checkSkillHitCondition = extra as ICheckSkillHitCondition;
		if (this.SuccessParamsArray == null || checkSkillHitCondition == null)
		{
			return false;
		}
		foreach (List<string> list in this.SuccessParamsArray)
		{
			if (checkSkillHitCondition.BulletId == long.Parse(list[0]))
			{
				return true;
			}
		}
		return false;
	}
}
