using System;
using System.Runtime.CompilerServices;

// Token: 0x02003136 RID: 12598
[NullableContext(2)]
[Nullable(0)]
public class SkillRotateTarget
{
	// Token: 0x0601B11D RID: 110877 RVA: 0x0075ADF2 File Offset: 0x00758FF2
	public void Reset()
	{
		this.TargetVector = null;
		this.TargetString = null;
		this.Type = ESkillRotateType.None;
	}

	// Token: 0x0400D2A0 RID: 53920
	public Vector TargetVector;

	// Token: 0x0400D2A1 RID: 53921
	public string TargetString;

	// Token: 0x0400D2A2 RID: 53922
	public ESkillRotateType Type;
}
