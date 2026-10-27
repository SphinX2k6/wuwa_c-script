using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020017CC RID: 6092
[NullableContext(1)]
[Nullable(0)]
public class CheckSkillIdSuccessCondition : BaseCheckCondition
{
	// Token: 0x0600B220 RID: 45600 RVA: 0x002843A5 File Offset: 0x002825A5
	public CheckSkillIdSuccessCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.SuccessType = EComboTeachingSuccessCondition.SkillIdChecker;
	}

	// Token: 0x17000EEE RID: 3822
	// (get) Token: 0x0600B221 RID: 45601 RVA: 0x002843C4 File Offset: 0x002825C4
	// (set) Token: 0x0600B222 RID: 45602 RVA: 0x002843CC File Offset: 0x002825CC
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000EEF RID: 3823
	// (get) Token: 0x0600B223 RID: 45603 RVA: 0x002843D5 File Offset: 0x002825D5
	// (set) Token: 0x0600B224 RID: 45604 RVA: 0x002843DD File Offset: 0x002825DD
	protected override EComboTeachingSuccessCondition SuccessType { get; set; }

	// Token: 0x0600B225 RID: 45605 RVA: 0x002843E8 File Offset: 0x002825E8
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
