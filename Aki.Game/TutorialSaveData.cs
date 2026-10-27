using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002C2E RID: 11310
public class TutorialSaveData : ITutorialSaveData
{
	// Token: 0x17001FBF RID: 8127
	// (get) Token: 0x060178F0 RID: 96496 RVA: 0x005FD2BB File Offset: 0x005FB4BB
	// (set) Token: 0x060178F1 RID: 96497 RVA: 0x005FD2C3 File Offset: 0x005FB4C3
	public int TimeStamp { get; set; }

	// Token: 0x17001FC0 RID: 8128
	// (get) Token: 0x060178F2 RID: 96498 RVA: 0x005FD2CC File Offset: 0x005FB4CC
	// (set) Token: 0x060178F3 RID: 96499 RVA: 0x005FD2D4 File Offset: 0x005FB4D4
	public int TutorialId { get; set; }

	// Token: 0x17001FC1 RID: 8129
	// (get) Token: 0x060178F4 RID: 96500 RVA: 0x005FD2DD File Offset: 0x005FB4DD
	// (set) Token: 0x060178F5 RID: 96501 RVA: 0x005FD2E5 File Offset: 0x005FB4E5
	public bool HasRedDot { get; set; }

	// Token: 0x17001FC2 RID: 8130
	// (get) Token: 0x060178F6 RID: 96502 RVA: 0x005FD2F0 File Offset: 0x005FB4F0
	// (set) Token: 0x060178F7 RID: 96503 RVA: 0x005FD393 File Offset: 0x005FB593
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

	// Token: 0x17001FC3 RID: 8131
	// (get) Token: 0x060178F8 RID: 96504 RVA: 0x005FD3A1 File Offset: 0x005FB5A1
	public GuideTutorial? TutorialData
	{
		get
		{
			return GuideConfig.Instance.GetGuideTutorial(this.TutorialId);
		}
	}

	// Token: 0x060178F9 RID: 96505 RVA: 0x005FD3B4 File Offset: 0x005FB5B4
	[NullableContext(1)]
	public string GetTutorialTitle()
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.TutorialData.Value.GroupName, null) ?? "";
	}

	// Token: 0x0400AFC1 RID: 44993
	private bool? IsExcludedFromWikiInternal;
}
