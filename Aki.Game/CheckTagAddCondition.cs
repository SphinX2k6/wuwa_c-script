using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000C8A RID: 3210
[NullableContext(1)]
[Nullable(0)]
public class CheckTagAddCondition : BaseCheckCondition
{
	// Token: 0x0600862A RID: 34346 RVA: 0x0028EEBC File Offset: 0x0028D0BC
	public CheckTagAddCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Update;
		this.SuccessType = EComboTeachingSuccessCondition.AddTag;
	}

	// Token: 0x17000F1C RID: 3868
	// (get) Token: 0x0600862B RID: 34347 RVA: 0x0028EEE2 File Offset: 0x0028D0E2
	// (set) Token: 0x0600862C RID: 34348 RVA: 0x0028EEEA File Offset: 0x0028D0EA
	public override EComboTeachingCheckType Type { get; set; } = EComboTeachingCheckType.Update;

	// Token: 0x17000F1D RID: 3869
	// (get) Token: 0x0600862D RID: 34349 RVA: 0x0028EEF3 File Offset: 0x0028D0F3
	// (set) Token: 0x0600862E RID: 34350 RVA: 0x0028EEFB File Offset: 0x0028D0FB
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.AddTag;

	// Token: 0x0600862F RID: 34351 RVA: 0x0028EF04 File Offset: 0x0028D104
	public override bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo paramex = null)
	{
		if (this.SuccessParamsArray == null)
		{
			return false;
		}
		BaseTagComponent playerComponent = BaseCheckCondition.GetPlayerComponent<BaseTagComponent>();
		if (playerComponent == null)
		{
			return false;
		}
		foreach (List<string> list in this.SuccessParamsArray)
		{
			int tagIdByName = GameplayTagUtils.GetTagIdByName(list[0]);
			if (playerComponent.HasTag(tagIdByName))
			{
				return true;
			}
		}
		return false;
	}
}
