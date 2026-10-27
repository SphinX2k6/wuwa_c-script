using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

// Token: 0x02002200 RID: 8704
[NullableContext(1)]
[Nullable(0)]
public class MarqueeData
{
	// Token: 0x06010ED1 RID: 69329 RVA: 0x0041E3A0 File Offset: 0x0041C5A0
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

	// Token: 0x06010ED2 RID: 69330 RVA: 0x0041E46C File Offset: 0x0041C66C
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

	// Token: 0x06010ED3 RID: 69331 RVA: 0x0041E504 File Offset: 0x0041C704
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

	// Token: 0x040080A8 RID: 32936
	public string Id = "";

	// Token: 0x040080A9 RID: 32937
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> WhiteLists;

	// Token: 0x040080AA RID: 32938
	public double ModifyTime;

	// Token: 0x040080AB RID: 32939
	[Nullable(2)]
	public string Content = "";

	// Token: 0x040080AC RID: 32940
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<MarqueeContent> Contents;

	// Token: 0x040080AD RID: 32941
	public double BeginTime;

	// Token: 0x040080AE RID: 32942
	public double EndTime;

	// Token: 0x040080AF RID: 32943
	public int ScrollInterval;

	// Token: 0x040080B0 RID: 32944
	public int ScrollTimes;

	// Token: 0x040080B1 RID: 32945
	public int ShowInFight;

	// Token: 0x040080B2 RID: 32946
	public int ShowInPhotograph;

	// Token: 0x040080B3 RID: 32947
	[Nullable(2)]
	public List<int> Platform;

	// Token: 0x040080B4 RID: 32948
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> Channel;

	// Token: 0x040080B5 RID: 32949
	public bool IsClientMarquee;

	// Token: 0x040080B6 RID: 32950
	public string LocalTextKey = "";

	// Token: 0x040080B7 RID: 32951
	public bool UseLocalTextKey;

	// Token: 0x040080B8 RID: 32952
	private const int MARQUEEPLATFORMPC = 1;

	// Token: 0x040080B9 RID: 32953
	private const int MARQUEEPLATFORMIOS = 2;

	// Token: 0x040080BA RID: 32954
	private const int MARQUEEPLATFORMANDROID = 3;
}
