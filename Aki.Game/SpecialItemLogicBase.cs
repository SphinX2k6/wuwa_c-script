using System;

// Token: 0x020014F3 RID: 5363
public class SpecialItemLogicBase
{
	// Token: 0x0600D656 RID: 54870 RVA: 0x003F9495 File Offset: 0x003F7695
	public SpecialItemLogicBase(int configId)
	{
		this.ConfigId = configId;
	}

	// Token: 0x0600D657 RID: 54871 RVA: 0x003F94A4 File Offset: 0x003F76A4
	public virtual void Init()
	{
	}

	// Token: 0x0600D658 RID: 54872 RVA: 0x003F94A6 File Offset: 0x003F76A6
	public virtual void Destroy()
	{
	}

	// Token: 0x0600D659 RID: 54873 RVA: 0x003F94A8 File Offset: 0x003F76A8
	public virtual bool CheckUseCondition()
	{
		return true;
	}

	// Token: 0x0600D65A RID: 54874 RVA: 0x003F94AB File Offset: 0x003F76AB
	public virtual void OnUse()
	{
	}

	// Token: 0x04007833 RID: 30771
	protected int ConfigId;
}
