using System;
using System.Runtime.CompilerServices;

// Token: 0x02003208 RID: 12808
[NullableContext(1)]
[Nullable(0)]
public class InterestActionBase
{
	// Token: 0x17002634 RID: 9780
	// (get) Token: 0x0601BA22 RID: 113186 RVA: 0x00797B4F File Offset: 0x00795D4F
	public virtual EInterestActionType Type
	{
		get
		{
			return EInterestActionType.LookAt;
		}
	}

	// Token: 0x17002635 RID: 9781
	// (get) Token: 0x0601BA23 RID: 113187 RVA: 0x00797B52 File Offset: 0x00795D52
	public virtual bool IsExclusive
	{
		get
		{
			return false;
		}
	}

	// Token: 0x0601BA24 RID: 113188 RVA: 0x00797B55 File Offset: 0x00795D55
	public virtual void OnEnter(Entity entity, InterestItemBase item)
	{
	}

	// Token: 0x0601BA25 RID: 113189 RVA: 0x00797B57 File Offset: 0x00795D57
	public virtual void OnLeave(Entity entity, InterestItemBase item)
	{
	}

	// Token: 0x0601BA26 RID: 113190 RVA: 0x00797B59 File Offset: 0x00795D59
	public virtual int GetPriority(Entity entity, InterestItemBase item)
	{
		return 0;
	}

	// Token: 0x0400D954 RID: 55636
	public int Priority;

	// Token: 0x0400D955 RID: 55637
	[StaticVariableRuleIgnore]
	protected static Vector TmpVector1 = Vector.Create();
}
