using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000C92 RID: 3218
[NullableContext(1)]
[Nullable(0)]
public class CheckBulletHitCondition : BaseCheckCondition
{
	// Token: 0x06008660 RID: 34400 RVA: 0x0028F4A9 File Offset: 0x0028D6A9
	public CheckBulletHitCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Event;
		this.SuccessType = EComboTeachingSuccessCondition.BulletHit;
	}

	// Token: 0x17000F2E RID: 3886
	// (get) Token: 0x06008661 RID: 34401 RVA: 0x0028F4CA File Offset: 0x0028D6CA
	// (set) Token: 0x06008662 RID: 34402 RVA: 0x0028F4D2 File Offset: 0x0028D6D2
	public override EComboTeachingCheckType Type { get; set; }

	// Token: 0x17000F2F RID: 3887
	// (get) Token: 0x06008663 RID: 34403 RVA: 0x0028F4DB File Offset: 0x0028D6DB
	// (set) Token: 0x06008664 RID: 34404 RVA: 0x0028F4E3 File Offset: 0x0028D6E3
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.BulletHit;

	// Token: 0x06008665 RID: 34405 RVA: 0x0028F4EC File Offset: 0x0028D6EC
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
