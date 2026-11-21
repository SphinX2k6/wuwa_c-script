using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000C8D RID: 3213
[NullableContext(1)]
[Nullable(0)]
public class CheckSkillEnterNextAttrCondition : BaseCheckCondition
{
	// Token: 0x06008642 RID: 34370 RVA: 0x0028F1B0 File Offset: 0x0028D3B0
	public CheckSkillEnterNextAttrCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.SuccessType = EComboTeachingSuccessCondition.NextAttrStart;
	}

	// Token: 0x17000F24 RID: 3876
	// (get) Token: 0x06008643 RID: 34371 RVA: 0x0028F1D6 File Offset: 0x0028D3D6
	// (set) Token: 0x06008644 RID: 34372 RVA: 0x0028F1DE File Offset: 0x0028D3DE
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000F25 RID: 3877
	// (get) Token: 0x06008645 RID: 34373 RVA: 0x0028F1E7 File Offset: 0x0028D3E7
	// (set) Token: 0x06008646 RID: 34374 RVA: 0x0028F1EF File Offset: 0x0028D3EF
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.NextAttrStart;

	// Token: 0x06008647 RID: 34375 RVA: 0x0028F1F8 File Offset: 0x0028D3F8
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
