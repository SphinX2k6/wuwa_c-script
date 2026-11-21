using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020021A9 RID: 8617
public class TutorialSaveData : ITutorialSaveData
{
	// Token: 0x17002017 RID: 8215
	// (get) Token: 0x06015322 RID: 86818 RVA: 0x00629CDF File Offset: 0x00627EDF
	// (set) Token: 0x06015323 RID: 86819 RVA: 0x00629CE7 File Offset: 0x00627EE7
	public int TimeStamp { get; set; }

	// Token: 0x17002018 RID: 8216
	// (get) Token: 0x06015324 RID: 86820 RVA: 0x00629CF0 File Offset: 0x00627EF0
	// (set) Token: 0x06015325 RID: 86821 RVA: 0x00629CF8 File Offset: 0x00627EF8
	public int TutorialId { get; set; }

	// Token: 0x17002019 RID: 8217
	// (get) Token: 0x06015326 RID: 86822 RVA: 0x00629D01 File Offset: 0x00627F01
	// (set) Token: 0x06015327 RID: 86823 RVA: 0x00629D09 File Offset: 0x00627F09
	public bool HasRedDot { get; set; }

	// Token: 0x1700201A RID: 8218
	// (get) Token: 0x06015328 RID: 86824 RVA: 0x00629D14 File Offset: 0x00627F14
	// (set) Token: 0x06015329 RID: 86825 RVA: 0x00629DB7 File Offset: 0x00627FB7
	public bool IsExcludedFromWiki
	{
		get
		{
			GuideTutorial? guideTutorial = this.TutorialData;
			if (guideTutorial != null && guideTutorial.GetValueOrDefault().TutorialType == 6)
			{
				return true;
			}
			if (this.IsExcludedFromWikiInternal == null)
			{
				guideTutorial = GuideConfig.Instance.GetGuideTutorial(this.TutorialId);
				bool? flag = (guideTutorial != null) ? new bool?(guideTutorial.GetValueOrDefault().ExcludeFromWiki) : null;
				if (flag != null)
				{
					this.IsExcludedFromWikiInternal = new bool?(flag.Value);
				}
			}
			return this.IsExcludedFromWikiInternal.GetValueOrDefault();
		}
		set
		{
			this.IsExcludedFromWikiInternal = new bool?(value);
		}
	}

	// Token: 0x1700201B RID: 8219
	// (get) Token: 0x0601532A RID: 86826 RVA: 0x00629DC5 File Offset: 0x00627FC5
	public GuideTutorial? TutorialData
	{
		get
		{
			return GuideConfig.Instance.GetGuideTutorial(this.TutorialId);
		}
	}

	// Token: 0x0601532B RID: 86827 RVA: 0x00629DD8 File Offset: 0x00627FD8
	[NullableContext(1)]
	public string GetTutorialTitle()
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.TutorialData.Value.GroupName, null) ?? "";
	}

	// Token: 0x0400B3C6 RID: 46022
	private bool? IsExcludedFromWikiInternal;
}
