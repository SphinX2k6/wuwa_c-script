using System;

// Token: 0x02002690 RID: 9872
public class AnimNotifyStateSkillRotateStyle
{
	// Token: 0x06018B87 RID: 101255 RVA: 0x0078111F File Offset: 0x0077F31F
	public void Reset()
	{
		this.IsUseAnsRotateOffset = false;
		this.AnsRotateOffset = 0f;
		this.PauseRotateThreshold = 0f;
		this.ResumeRotateThreshold = 0f;
		this.IsPaused = false;
	}

	// Token: 0x0400D6BC RID: 54972
	public bool IsUseAnsRotateOffset;

	// Token: 0x0400D6BD RID: 54973
	public float AnsRotateOffset;

	// Token: 0x0400D6BE RID: 54974
	public float PauseRotateThreshold;

	// Token: 0x0400D6BF RID: 54975
	public float ResumeRotateThreshold;

	// Token: 0x0400D6C0 RID: 54976
	public bool IsPaused;
}
