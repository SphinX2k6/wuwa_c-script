using System;
using System.Runtime.CompilerServices;

// Token: 0x0200320A RID: 12810
[NullableContext(1)]
[Nullable(0)]
public class InterestItemBase
{
	// Token: 0x17002638 RID: 9784
	// (get) Token: 0x0601BA30 RID: 113200 RVA: 0x00797C7C File Offset: 0x00795E7C
	public virtual EInterestItemType Type
	{
		get
		{
			return EInterestItemType.Position;
		}
	}

	// Token: 0x0601BA31 RID: 113201 RVA: 0x00797C7F File Offset: 0x00795E7F
	public virtual bool GetLocation(Vector outVector)
	{
		return false;
	}

	// Token: 0x0601BA32 RID: 113202 RVA: 0x00797C82 File Offset: 0x00795E82
	public virtual string GetDebugInfo()
	{
		return "";
	}

	// Token: 0x0400D956 RID: 55638
	[StaticVariableRuleIgnore]
	protected static Vector TempVector1 = Vector.Create();
}
