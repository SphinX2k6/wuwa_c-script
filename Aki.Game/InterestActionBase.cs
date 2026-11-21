using System;
using System.Runtime.CompilerServices;

// Token: 0x02002777 RID: 10103
[NullableContext(1)]
[Nullable(0)]
public class InterestActionBase
{
	// Token: 0x17002875 RID: 10357
	// (get) Token: 0x060195A7 RID: 103847 RVA: 0x007C02AE File Offset: 0x007BE4AE
	public virtual EInterestActionType Type
	{
		get
		{
			return EInterestActionType.LookAt;
		}
	}

	// Token: 0x17002876 RID: 10358
	// (get) Token: 0x060195A8 RID: 103848 RVA: 0x007C02B1 File Offset: 0x007BE4B1
	public virtual bool IsExclusive
	{
		get
		{
			return false;
		}
	}

	// Token: 0x060195A9 RID: 103849 RVA: 0x007C02B4 File Offset: 0x007BE4B4
	public virtual void OnEnter(Entity entity, InterestItemBase item)
	{
	}

	// Token: 0x060195AA RID: 103850 RVA: 0x007C02B6 File Offset: 0x007BE4B6
	public virtual void OnLeave(Entity entity, InterestItemBase item)
	{
	}

	// Token: 0x060195AB RID: 103851 RVA: 0x007C02B8 File Offset: 0x007BE4B8
	public virtual int GetPriority(Entity entity, InterestItemBase item)
	{
		return 0;
	}

	// Token: 0x0400DDF3 RID: 56819
	public int Priority;

	// Token: 0x0400DDF4 RID: 56820
	[StaticVariableRuleIgnore]
	protected static Vector TmpVector1 = Vector.Create();
}
