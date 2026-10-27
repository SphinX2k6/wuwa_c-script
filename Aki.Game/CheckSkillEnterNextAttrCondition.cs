using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020017D4 RID: 6100
[NullableContext(1)]
[Nullable(0)]
public class CheckSkillEnterNextAttrCondition : BaseCheckCondition
{
	// Token: 0x0600B259 RID: 45657 RVA: 0x00284BD0 File Offset: 0x00282DD0
	public CheckSkillEnterNextAttrCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.SuccessType = EComboTeachingSuccessCondition.NextAttrStart;
	}

	// Token: 0x17000F01 RID: 3841
	// (get) Token: 0x0600B25A RID: 45658 RVA: 0x00284BF6 File Offset: 0x00282DF6
	// (set) Token: 0x0600B25B RID: 45659 RVA: 0x00284BFE File Offset: 0x00282DFE
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000F02 RID: 3842
	// (get) Token: 0x0600B25C RID: 45660 RVA: 0x00284C07 File Offset: 0x00282E07
	// (set) Token: 0x0600B25D RID: 45661 RVA: 0x00284C0F File Offset: 0x00282E0F
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.NextAttrStart;

	// Token: 0x0600B25E RID: 45662 RVA: 0x00284C18 File Offset: 0x00282E18
	public override bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo paramex = null)
	{
		if (this.SuccessParamsArray == null)
		{
			return false;
		}
		foreach (List<string> list in this.SuccessParamsArray)
		{
			if (ComboTeachingModel.Instance.NextAttrSkillId == (long)int.Parse(list[0]) && ComboTeachingModel.Instance.NextAttr && !ComboTeachingModel.Instance.PreNextAttr)
			{
				return true;
			}
		}
		return false;
	}
}
