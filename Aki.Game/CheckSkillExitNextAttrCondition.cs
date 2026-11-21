using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C8F RID: 3215
[NullableContext(1)]
[Nullable(0)]
public class CheckSkillExitNextAttrCondition : BaseCheckCondition
{
	// Token: 0x0600864E RID: 34382 RVA: 0x0028F31F File Offset: 0x0028D51F
	public CheckSkillExitNextAttrCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.FailType = EComboTeachingFailCondition.NextAttrEnd;
	}

	// Token: 0x17000F28 RID: 3880
	// (get) Token: 0x0600864F RID: 34383 RVA: 0x0028F345 File Offset: 0x0028D545
	// (set) Token: 0x06008650 RID: 34384 RVA: 0x0028F34D File Offset: 0x0028D54D
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000F29 RID: 3881
	// (get) Token: 0x06008651 RID: 34385 RVA: 0x0028F356 File Offset: 0x0028D556
	// (set) Token: 0x06008652 RID: 34386 RVA: 0x0028F35E File Offset: 0x0028D55E
	protected override EComboTeachingFailCondition FailType { get; set; } = EComboTeachingFailCondition.NextAttrEnd;

	// Token: 0x06008653 RID: 34387 RVA: 0x0028F367 File Offset: 0x0028D567
	public override bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		return ComboTeachingModel.Instance.UseSkillId == ComboTeachingModel.Instance.NextAttrSkillId && !ComboTeachingModel.Instance.NextAttr && ComboTeachingModel.Instance.PreNextAttr;
	}
}
