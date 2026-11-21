using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C8E RID: 3214
[NullableContext(1)]
[Nullable(0)]
public class CheckSkillIdFailCondition : BaseCheckCondition
{
	// Token: 0x06008648 RID: 34376 RVA: 0x0028F288 File Offset: 0x0028D488
	public CheckSkillIdFailCondition(string paramsString, bool isSuccessNode, EComboTeachingFailCondition failType) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Event;
		this.FailType = failType;
	}

	// Token: 0x17000F26 RID: 3878
	// (get) Token: 0x06008649 RID: 34377 RVA: 0x0028F2A0 File Offset: 0x0028D4A0
	// (set) Token: 0x0600864A RID: 34378 RVA: 0x0028F2A8 File Offset: 0x0028D4A8
	public override EComboTeachingCheckType Type { get; set; }

	// Token: 0x17000F27 RID: 3879
	// (get) Token: 0x0600864B RID: 34379 RVA: 0x0028F2B1 File Offset: 0x0028D4B1
	// (set) Token: 0x0600864C RID: 34380 RVA: 0x0028F2B9 File Offset: 0x0028D4B9
	protected override EComboTeachingFailCondition FailType { get; set; }

	// Token: 0x0600864D RID: 34381 RVA: 0x0028F2C4 File Offset: 0x0028D4C4
	public override bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		bool flag = this.FailType == EComboTeachingFailCondition.HoldSkillIdChecker;
		return data.IsHoldAction == flag && this.ParamsArray != null && (ComboTeachingModel.Instance.UseSkillId != 0L && !this.OriginString.Contains(ComboTeachingModel.Instance.UseSkillId.ToString()));
	}
}
