using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000C86 RID: 3206
[NullableContext(1)]
[Nullable(0)]
public class CheckSkillHitSuccessCondition : BaseCheckCondition
{
	// Token: 0x0600860F RID: 34319 RVA: 0x0028EB98 File Offset: 0x0028CD98
	public CheckSkillHitSuccessCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Event;
		this.SuccessType = EComboTeachingSuccessCondition.SkillIdHit;
	}

	// Token: 0x17000F13 RID: 3859
	// (get) Token: 0x06008610 RID: 34320 RVA: 0x0028EBB7 File Offset: 0x0028CDB7
	// (set) Token: 0x06008611 RID: 34321 RVA: 0x0028EBBF File Offset: 0x0028CDBF
	public override EComboTeachingCheckType Type { get; set; }

	// Token: 0x17000F14 RID: 3860
	// (get) Token: 0x06008612 RID: 34322 RVA: 0x0028EBC8 File Offset: 0x0028CDC8
	// (set) Token: 0x06008613 RID: 34323 RVA: 0x0028EBD0 File Offset: 0x0028CDD0
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.SkillIdHit;

	// Token: 0x06008614 RID: 34324 RVA: 0x0028EBDC File Offset: 0x0028CDDC
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
