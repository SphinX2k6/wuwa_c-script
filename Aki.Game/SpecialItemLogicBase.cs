using System;

// Token: 0x02002020 RID: 8224
public class SpecialItemLogicBase
{
	// Token: 0x060101EE RID: 66030 RVA: 0x003ECE9D File Offset: 0x003EB09D
	public SpecialItemLogicBase(int configId)
	{
		this.ConfigId = configId;
	}

	// Token: 0x060101EF RID: 66031 RVA: 0x003ECEAC File Offset: 0x003EB0AC
	public virtual void Init()
	{
	}

	// Token: 0x060101F0 RID: 66032 RVA: 0x003ECEAE File Offset: 0x003EB0AE
	public virtual void Destroy()
	{
	}

	// Token: 0x060101F1 RID: 66033 RVA: 0x003ECEB0 File Offset: 0x003EB0B0
	public virtual bool CheckUseCondition()
	{
		return true;
	}

	// Token: 0x060101F2 RID: 66034 RVA: 0x003ECEB3 File Offset: 0x003EB0B3
	public virtual void OnUse()
	{
	}

	// Token: 0x0400774A RID: 30538
	protected int ConfigId;
}
