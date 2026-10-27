using System;
using System.Runtime.CompilerServices;

// Token: 0x020017D6 RID: 6102
[NullableContext(1)]
[Nullable(0)]
public class CheckSkillExitNextAttrCondition : BaseCheckCondition
{
	// Token: 0x0600B265 RID: 45669 RVA: 0x00284D29 File Offset: 0x00282F29
	public CheckSkillExitNextAttrCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.FailType = EComboTeachingFailCondition.NextAttrEnd;
	}

	// Token: 0x17000F05 RID: 3845
	// (get) Token: 0x0600B266 RID: 45670 RVA: 0x00284D4F File Offset: 0x00282F4F
	// (set) Token: 0x0600B267 RID: 45671 RVA: 0x00284D57 File Offset: 0x00282F57
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000F06 RID: 3846
	// (get) Token: 0x0600B268 RID: 45672 RVA: 0x00284D60 File Offset: 0x00282F60
	// (set) Token: 0x0600B269 RID: 45673 RVA: 0x00284D68 File Offset: 0x00282F68
	protected override EComboTeachingFailCondition FailType { get; set; } = EComboTeachingFailCondition.NextAttrEnd;

	// Token: 0x0600B26A RID: 45674 RVA: 0x00284D71 File Offset: 0x00282F71
	public override bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		return ComboTeachingModel.Instance.UseSkillId == ComboTeachingModel.Instance.NextAttrSkillId && !ComboTeachingModel.Instance.NextAttr && ComboTeachingModel.Instance.PreNextAttr;
	}
}
