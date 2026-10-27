using System;
using System.Runtime.CompilerServices;

// Token: 0x0200324A RID: 12874
public class CachedSafetyLocationRecorder : ISafetyLocationGetter, IClear
{
	// Token: 0x0601BC71 RID: 113777 RVA: 0x007A8E40 File Offset: 0x007A7040
	[NullableContext(2)]
	public Vector GetSafetyLocation()
	{
		if (!this.IsSafety)
		{
			return null;
		}
		return this.SafetyLocation;
	}

	// Token: 0x0601BC72 RID: 113778 RVA: 0x007A8E52 File Offset: 0x007A7052
	public bool ClearObject()
	{
		this.IsSafety = false;
		return true;
	}

	// Token: 0x0400DADC RID: 56028
	[Nullable(1)]
	public readonly Vector SafetyLocation = Vector.Create();

	// Token: 0x0400DADD RID: 56029
	public bool IsSafety;
}
