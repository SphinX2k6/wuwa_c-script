using System;

// Token: 0x02001479 RID: 5241
public class RegressGradeUiItem
{
	// Token: 0x17000CEF RID: 3311
	// (get) Token: 0x06009444 RID: 37956 RVA: 0x001FEF05 File Offset: 0x001FD105
	// (set) Token: 0x06009445 RID: 37957 RVA: 0x001FEF0D File Offset: 0x001FD10D
	public ERegressGrade Grade
	{
		get
		{
			return this.GradeInternal;
		}
		set
		{
			this.GradeInternal = value;
			this.Update();
		}
	}

	// Token: 0x06009446 RID: 37958 RVA: 0x001FEF1C File Offset: 0x001FD11C
	private void Update()
	{
		ERegressGrade grade = this.Grade;
		if (grade == ERegressGrade.Normal)
		{
			this.OnSetToNormal();
			return;
		}
		if (grade != ERegressGrade.Hyper)
		{
			return;
		}
		this.OnSetToHyper();
	}

	// Token: 0x06009447 RID: 37959 RVA: 0x001FEF46 File Offset: 0x001FD146
	protected virtual void OnSetToNormal()
	{
	}

	// Token: 0x06009448 RID: 37960 RVA: 0x001FEF48 File Offset: 0x001FD148
	protected virtual void OnSetToHyper()
	{
	}

	// Token: 0x06009449 RID: 37961 RVA: 0x001FEF4A File Offset: 0x001FD14A
	public virtual void BindRedDot(ERedDotName dotName)
	{
	}

	// Token: 0x040041C6 RID: 16838
	private ERegressGrade GradeInternal = ERegressGrade.Normal;
}
