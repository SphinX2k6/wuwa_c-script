using System;
using System.Runtime.CompilerServices;

// Token: 0x0200223E RID: 8766
[NullableContext(1)]
[Nullable(0)]
public class VideoSubtitle
{
	// Token: 0x06015A76 RID: 88694 RVA: 0x00647FFB File Offset: 0x006461FB
	public VideoSubtitle(int showMoment, int duration, string captionText, int captionId, bool isPlaySubtitleVoice)
	{
		this.ShowMoment = showMoment;
		this.Duration = duration;
		this.CaptionText = captionText;
		this.CaptionId = captionId;
		this.IsPlaySubtitleVoice = isPlaySubtitleVoice;
	}

	// Token: 0x0400B6CB RID: 46795
	public int ShowMoment;

	// Token: 0x0400B6CC RID: 46796
	public int Duration;

	// Token: 0x0400B6CD RID: 46797
	public string CaptionText;

	// Token: 0x0400B6CE RID: 46798
	public int CaptionId;

	// Token: 0x0400B6CF RID: 46799
	public bool IsPlaySubtitleVoice;
}
