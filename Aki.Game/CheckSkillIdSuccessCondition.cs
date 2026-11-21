using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000C85 RID: 3205
[NullableContext(1)]
[Nullable(0)]
public class CheckSkillIdSuccessCondition : BaseCheckCondition
{
	// Token: 0x06008609 RID: 34313 RVA: 0x0028EAB7 File Offset: 0x0028CCB7
	public CheckSkillIdSuccessCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.SuccessType = EComboTeachingSuccessCondition.SkillIdChecker;
	}

	// Token: 0x17000F11 RID: 3857
	// (get) Token: 0x0600860A RID: 34314 RVA: 0x0028EAD6 File Offset: 0x0028CCD6
	// (set) Token: 0x0600860B RID: 34315 RVA: 0x0028EADE File Offset: 0x0028CCDE
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000F12 RID: 3858
	// (get) Token: 0x0600860C RID: 34316 RVA: 0x0028EAE7 File Offset: 0x0028CCE7
	// (set) Token: 0x0600860D RID: 34317 RVA: 0x0028EAEF File Offset: 0x0028CCEF
	protected override EComboTeachingSuccessCondition SuccessType { get; set; }

	// Token: 0x0600860E RID: 34318 RVA: 0x0028EAF8 File Offset: 0x0028CCF8
	public override bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo paramex = null)
	{
		if (this.SuccessParamsArray == null)
		{
			return false;
		}
		foreach (List<string> list in this.SuccessParamsArray)
		{
			if (ComboTeachingModel.Instance.UseSkillId == (long)int.Parse(list[0]) && ComboTeachingModel.Instance.UseSkillTime >= float.Parse(list[1]) * 1000f && !ComboTeachingModel.Instance.IsEmit)
			{
				return true;
			}
		}
		return false;
	}
}
