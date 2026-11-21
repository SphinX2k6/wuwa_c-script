using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

// Token: 0x020016E4 RID: 5860
[NullableContext(1)]
[Nullable(0)]
public class MarqueeData
{
	// Token: 0x0600E364 RID: 58212 RVA: 0x0042AD44 File Offset: 0x00428F44
	public void RefreshContent()
	{
		if (this.Contents != null)
		{
			MarqueeContent marqueeContent = null;
			foreach (MarqueeContent marqueeContent2 in this.Contents)
			{
				if (marqueeContent2.language == LanguageSystem.Instance.PackageLanguage)
				{
					marqueeContent = marqueeContent2;
					break;
				}
			}
			if (marqueeContent != null)
			{
				this.Content = marqueeContent.content;
			}
			if (string.IsNullOrEmpty(this.Content))
			{
				if (this.Contents != null && this.Contents.Count > 0)
				{
					this.Content = this.Contents[0].content;
					return;
				}
				this.Content = "";
			}
		}
	}

	// Token: 0x0600E365 RID: 58213 RVA: 0x0042AE10 File Offset: 0x00429010
	public void Phrase(MarqueeDataEx data)
	{
		this.Id = data.id.ToString();
		this.EndTime = data.endTimeMs / 1000.0;
		this.BeginTime = data.startTimeMs / 1000.0;
		this.WhiteLists = data.whiteList;
		this.ScrollInterval = data.timeInterval;
		this.ScrollTimes = data.times;
		this.Contents = data.contents;
		this.RefreshContent();
		this.Platform = data.platform;
		this.Channel = data.channel;
	}

	// Token: 0x0600E366 RID: 58214 RVA: 0x0042AEA8 File Offset: 0x004290A8
	public bool CheckPlatformAndChannelIfShow()
	{
		string item = "";
		if (KuroSdkController.Instance.CanUseSdk())
		{
			item = KuroSdkController.Instance.GetChannelId();
		}
		if (this.Channel != null && this.Channel.Count > 0 && !this.Channel.Contains(item))
		{
			return false;
		}
		int item2 = 1;
		if (Info.Instance.PlatformType == ESourcePlatformType.Android)
		{
			item2 = 2;
		}
		else if (Info.Instance.PlatformType == ESourcePlatformType.IOS)
		{
			item2 = 3;
		}
		return this.Platform == null || this.Platform.Count <= 0 || this.Platform.Contains(item2);
	}

	// Token: 0x040081E6 RID: 33254
	public string Id = "";

	// Token: 0x040081E7 RID: 33255
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> WhiteLists;

	// Token: 0x040081E8 RID: 33256
	public double ModifyTime;

	// Token: 0x040081E9 RID: 33257
	[Nullable(2)]
	public string Content = "";

	// Token: 0x040081EA RID: 33258
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<MarqueeContent> Contents;

	// Token: 0x040081EB RID: 33259
	public double BeginTime;

	// Token: 0x040081EC RID: 33260
	public double EndTime;

	// Token: 0x040081ED RID: 33261
	public int ScrollInterval;

	// Token: 0x040081EE RID: 33262
	public int ScrollTimes;

	// Token: 0x040081EF RID: 33263
	public int ShowInFight;

	// Token: 0x040081F0 RID: 33264
	public int ShowInPhotograph;

	// Token: 0x040081F1 RID: 33265
	[Nullable(2)]
	public List<int> Platform;

	// Token: 0x040081F2 RID: 33266
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> Channel;

	// Token: 0x040081F3 RID: 33267
	public bool IsClientMarquee;

	// Token: 0x040081F4 RID: 33268
	public string LocalTextKey = "";

	// Token: 0x040081F5 RID: 33269
	public bool UseLocalTextKey;

	// Token: 0x040081F6 RID: 33270
	private const int MARQUEEPLATFORMPC = 1;

	// Token: 0x040081F7 RID: 33271
	private const int MARQUEEPLATFORMIOS = 2;

	// Token: 0x040081F8 RID: 33272
	private const int MARQUEEPLATFORMANDROID = 3;
}
