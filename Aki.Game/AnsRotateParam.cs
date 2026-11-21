using System;
using System.Runtime.CompilerServices;

// Token: 0x0200015D RID: 349
[NullableContext(2)]
[Nullable(0)]
internal class AnsRotateParam
{
	// Token: 0x0600160E RID: 5646 RVA: 0x0007B953 File Offset: 0x00079B53
	public AnsRotateParam(float total)
	{
		this.NowTime = 0f;
		this.TotalDurationReciprocal = 1f / total;
	}

	// Token: 0x0600160F RID: 5647 RVA: 0x0007B97E File Offset: 0x00079B7E
	public void Update(float now, float total)
	{
		this.NowTime = now;
		this.TotalDurationReciprocal = 1f / total;
	}

	// Token: 0x06001610 RID: 5648 RVA: 0x0007B994 File Offset: 0x00079B94
	public void SetRotateTarget(Vector target, ESkillRotateType type)
	{
		this.SkillRotateTarget.TargetVector = target;
		this.SkillRotateTarget.TargetString = null;
		this.SkillRotateTarget.Type = type;
	}

	// Token: 0x06001611 RID: 5649 RVA: 0x0007B9BA File Offset: 0x00079BBA
	public void SetRotateTarget(string target, ESkillRotateType type)
	{
		this.SkillRotateTarget.TargetString = target;
		this.SkillRotateTarget.TargetVector = null;
		this.SkillRotateTarget.Type = type;
	}

	// Token: 0x04000F62 RID: 3938
	public EAnsRotateDetectionTypeLocal RotateDetectionType;

	// Token: 0x04000F63 RID: 3939
	[Nullable(1)]
	public SkillRotateTarget SkillRotateTarget = new SkillRotateTarget();

	// Token: 0x04000F64 RID: 3940
	public float NowTime;

	// Token: 0x04000F65 RID: 3941
	public float TotalDurationReciprocal;
}
