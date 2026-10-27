using System;
using System.Runtime.CompilerServices;

// Token: 0x020017D5 RID: 6101
[NullableContext(1)]
[Nullable(0)]
public class CheckSkillIdFailCondition : BaseCheckCondition
{
	// Token: 0x0600B25F RID: 45663 RVA: 0x00284CA8 File Offset: 0x00282EA8
	public CheckSkillIdFailCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Event;
		this.FailType = EComboTeachingFailCondition.SkillIdChecker;
	}

	// Token: 0x17000F03 RID: 3843
	// (get) Token: 0x0600B260 RID: 45664 RVA: 0x00284CC0 File Offset: 0x00282EC0
	// (set) Token: 0x0600B261 RID: 45665 RVA: 0x00284CC8 File Offset: 0x00282EC8
	public override EComboTeachingCheckType Type { get; set; }

	// Token: 0x17000F04 RID: 3844
	// (get) Token: 0x0600B262 RID: 45666 RVA: 0x00284CD1 File Offset: 0x00282ED1
	// (set) Token: 0x0600B263 RID: 45667 RVA: 0x00284CD9 File Offset: 0x00282ED9
	protected override EComboTeachingFailCondition FailType { get; set; }

	// Token: 0x0600B264 RID: 45668 RVA: 0x00284CE4 File Offset: 0x00282EE4
	public override bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		return this.ParamsArray != null && (ComboTeachingModel.Instance.UseSkillId != 0L && !this.OriginString.Contains(ComboTeachingModel.Instance.UseSkillId.ToString()));
	}
}
