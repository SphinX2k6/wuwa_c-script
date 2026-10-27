using System;

// Token: 0x02003134 RID: 12596
public class AnimNotifyStateSkillRotateStyle
{
	// Token: 0x0601B11B RID: 110875 RVA: 0x0075ADB9 File Offset: 0x00758FB9
	public void Reset()
	{
		this.IsUseAnsRotateOffset = false;
		this.AnsRotateOffset = 0f;
		this.PauseRotateThreshold = 0f;
		this.ResumeRotateThreshold = 0f;
		this.IsPaused = false;
	}

	// Token: 0x0400D292 RID: 53906
	public bool IsUseAnsRotateOffset;

	// Token: 0x0400D293 RID: 53907
	public float AnsRotateOffset;

	// Token: 0x0400D294 RID: 53908
	public float PauseRotateThreshold;

	// Token: 0x0400D295 RID: 53909
	public float ResumeRotateThreshold;

	// Token: 0x0400D296 RID: 53910
	public bool IsPaused;
}
