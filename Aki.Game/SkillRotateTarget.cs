using System;
using System.Runtime.CompilerServices;

// Token: 0x02002692 RID: 9874
[NullableContext(2)]
[Nullable(0)]
public class SkillRotateTarget
{
	// Token: 0x06018B89 RID: 101257 RVA: 0x00781158 File Offset: 0x0077F358
	public void Reset()
	{
		this.TargetVector = null;
		this.TargetString = null;
		this.Type = ESkillRotateType.None;
	}

	// Token: 0x0400D6CA RID: 54986
	public Vector TargetVector;

	// Token: 0x0400D6CB RID: 54987
	public string TargetString;

	// Token: 0x0400D6CC RID: 54988
	public ESkillRotateType Type;
}
