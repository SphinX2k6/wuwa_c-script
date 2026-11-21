using System;

// Token: 0x0200092D RID: 2349
public class RegressGradeUiItem
{
	// Token: 0x17000D0F RID: 3343
	// (get) Token: 0x060067D9 RID: 26585 RVA: 0x00207E69 File Offset: 0x00206069
	// (set) Token: 0x060067DA RID: 26586 RVA: 0x00207E71 File Offset: 0x00206071
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

	// Token: 0x060067DB RID: 26587 RVA: 0x00207E80 File Offset: 0x00206080
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

	// Token: 0x060067DC RID: 26588 RVA: 0x00207EAA File Offset: 0x002060AA
	protected virtual void OnSetToNormal()
	{
	}

	// Token: 0x060067DD RID: 26589 RVA: 0x00207EAC File Offset: 0x002060AC
	protected virtual void OnSetToHyper()
	{
	}

	// Token: 0x060067DE RID: 26590 RVA: 0x00207EAE File Offset: 0x002060AE
	public virtual void BindRedDot(ERedDotName dotName)
	{
	}

	// Token: 0x0400425E RID: 16990
	private ERegressGrade GradeInternal = ERegressGrade.Normal;
}
