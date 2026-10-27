using System;

// Token: 0x020000A2 RID: 162
public abstract class ModelBase
{
	// Token: 0x060004DC RID: 1244 RVA: 0x0001B474 File Offset: 0x00019674
	public bool Init()
	{
		return this.OnInit();
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x0001B47C File Offset: 0x0001967C
	public bool Clear()
	{
		return this.OnClear();
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x0001B484 File Offset: 0x00019684
	public bool LeaveLevel()
	{
		return this.OnLeaveLevel();
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x0001B48C File Offset: 0x0001968C
	public bool ChangeMode()
	{
		return this.OnChangeMode();
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x0001B494 File Offset: 0x00019694
	protected virtual bool OnInit()
	{
		return true;
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x0001B497 File Offset: 0x00019697
	protected virtual bool OnClear()
	{
		return true;
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x0001B49A File Offset: 0x0001969A
	protected virtual bool OnLeaveLevel()
	{
		return true;
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x0001B49D File Offset: 0x0001969D
	protected virtual bool OnChangeMode()
	{
		return true;
	}
}
