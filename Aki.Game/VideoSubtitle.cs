using System;
using System.Runtime.CompilerServices;

// Token: 0x02002CE5 RID: 11493
[NullableContext(1)]
[Nullable(0)]
public class VideoSubtitle
{
	// Token: 0x060181F7 RID: 98807 RVA: 0x00622387 File Offset: 0x00620587
	public VideoSubtitle(int showMoment, int duration, string captionText, int captionId, bool isPlaySubtitleVoice)
	{
		this.ShowMoment = showMoment;
		this.Duration = duration;
		this.CaptionText = captionText;
		this.CaptionId = captionId;
		this.IsPlaySubtitleVoice = isPlaySubtitleVoice;
	}

	// Token: 0x0400B35F RID: 45919
	public int ShowMoment;

	// Token: 0x0400B360 RID: 45920
	public int Duration;

	// Token: 0x0400B361 RID: 45921
	public string CaptionText;

	// Token: 0x0400B362 RID: 45922
	public int CaptionId;

	// Token: 0x0400B363 RID: 45923
	public bool IsPlaySubtitleVoice;
}
