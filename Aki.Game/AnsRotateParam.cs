using System;
using System.Runtime.CompilerServices;

// Token: 0x02000159 RID: 345
[NullableContext(2)]
[Nullable(0)]
internal class AnsRotateParam
{
	// Token: 0x06001571 RID: 5489 RVA: 0x000762DF File Offset: 0x000744DF
	public AnsRotateParam(float total)
	{
		this.NowTime = 0f;
		this.TotalDurationReciprocal = 1f / total;
	}

	// Token: 0x06001572 RID: 5490 RVA: 0x0007630A File Offset: 0x0007450A
	public void Update(float now, float total)
	{
		this.NowTime = now;
		this.TotalDurationReciprocal = 1f / total;
	}

	// Token: 0x06001573 RID: 5491 RVA: 0x00076320 File Offset: 0x00074520
	public void SetRotateTarget(Vector target, ESkillRotateType type)
	{
		this.SkillRotateTarget.TargetVector = target;
		this.SkillRotateTarget.TargetString = null;
		this.SkillRotateTarget.Type = type;
	}

	// Token: 0x06001574 RID: 5492 RVA: 0x00076346 File Offset: 0x00074546
	public void SetRotateTarget(string target, ESkillRotateType type)
	{
		this.SkillRotateTarget.TargetString = target;
		this.SkillRotateTarget.TargetVector = null;
		this.SkillRotateTarget.Type = type;
	}

	// Token: 0x04000F1F RID: 3871
	public EAnsRotateDetectionTypeLocal RotateDetectionType;

	// Token: 0x04000F20 RID: 3872
	[Nullable(1)]
	public SkillRotateTarget SkillRotateTarget = new SkillRotateTarget();

	// Token: 0x04000F21 RID: 3873
	public float NowTime;

	// Token: 0x04000F22 RID: 3874
	public float TotalDurationReciprocal;
}
