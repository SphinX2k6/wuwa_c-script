using System;
using System.Runtime.CompilerServices;

// Token: 0x02002779 RID: 10105
[NullableContext(1)]
[Nullable(0)]
public class InterestItemBase
{
	// Token: 0x17002879 RID: 10361
	// (get) Token: 0x060195B5 RID: 103861 RVA: 0x007C03DC File Offset: 0x007BE5DC
	public virtual EInterestItemType Type
	{
		get
		{
			return EInterestItemType.Position;
		}
	}

	// Token: 0x060195B6 RID: 103862 RVA: 0x007C03DF File Offset: 0x007BE5DF
	public virtual bool GetLocation(Vector outVector)
	{
		return false;
	}

	// Token: 0x060195B7 RID: 103863 RVA: 0x007C03E2 File Offset: 0x007BE5E2
	public virtual string GetDebugInfo()
	{
		return "";
	}

	// Token: 0x0400DDF5 RID: 56821
	[StaticVariableRuleIgnore]
	protected static Vector TempVector1 = Vector.Create();
}
