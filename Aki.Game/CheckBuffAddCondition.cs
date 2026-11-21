using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000C89 RID: 3209
[NullableContext(1)]
[Nullable(0)]
public class CheckBuffAddCondition : BaseCheckCondition
{
	// Token: 0x06008624 RID: 34340 RVA: 0x0028EDF3 File Offset: 0x0028CFF3
	public CheckBuffAddCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.SuccessType = EComboTeachingSuccessCondition.AddBuff;
	}

	// Token: 0x17000F1A RID: 3866
	// (get) Token: 0x06008625 RID: 34341 RVA: 0x0028EE19 File Offset: 0x0028D019
	// (set) Token: 0x06008626 RID: 34342 RVA: 0x0028EE21 File Offset: 0x0028D021
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000F1B RID: 3867
	// (get) Token: 0x06008627 RID: 34343 RVA: 0x0028EE2A File Offset: 0x0028D02A
	// (set) Token: 0x06008628 RID: 34344 RVA: 0x0028EE32 File Offset: 0x0028D032
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.AddBuff;

	// Token: 0x06008629 RID: 34345 RVA: 0x0028EE3C File Offset: 0x0028D03C
	public override bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo paramex = null)
	{
		if (this.SuccessParamsArray == null)
		{
			return false;
		}
		CharacterBuffComponent playerComponent = BaseCheckCondition.GetPlayerComponent<CharacterBuffComponent>();
		if (playerComponent == null)
		{
			return false;
		}
		foreach (List<string> list in this.SuccessParamsArray)
		{
			if (playerComponent.GetBuffTotalStackById(long.Parse(list[0]), false) > 0)
			{
				return true;
			}
		}
		return false;
	}
}
