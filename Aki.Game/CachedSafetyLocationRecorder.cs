using System;
using System.Runtime.CompilerServices;

// Token: 0x020027B9 RID: 10169
public class CachedSafetyLocationRecorder : ISafetyLocationGetter, IClear
{
	// Token: 0x06019826 RID: 104486 RVA: 0x007D150D File Offset: 0x007CF70D
	[NullableContext(2)]
	public Vector GetSafetyLocation()
	{
		if (!this.IsSafety)
		{
			return null;
		}
		return this.SafetyLocation;
	}

	// Token: 0x06019827 RID: 104487 RVA: 0x007D151F File Offset: 0x007CF71F
	public bool ClearObject()
	{
		this.IsSafety = false;
		return true;
	}

	// Token: 0x0400DF7B RID: 57211
	[Nullable(1)]
	public readonly Vector SafetyLocation = Vector.Create();

	// Token: 0x0400DF7C RID: 57212
	public bool IsSafety;
}
