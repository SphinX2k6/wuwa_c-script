using System;

// Token: 0x020000A4 RID: 164
public abstract class ModelBase
{
	// Token: 0x0600051D RID: 1309 RVA: 0x0001BB5C File Offset: 0x00019D5C
	public bool Init()
	{
		return this.OnInit();
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x0001BB64 File Offset: 0x00019D64
	public bool Clear()
	{
		return this.OnClear();
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x0001BB6C File Offset: 0x00019D6C
	public bool LeaveLevel()
	{
		return this.OnLeaveLevel();
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x0001BB74 File Offset: 0x00019D74
	public bool ChangeMode()
	{
		return this.OnChangeMode();
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x0001BB7C File Offset: 0x00019D7C
	protected virtual bool OnInit()
	{
		return true;
	}

	// Token: 0x06000522 RID: 1314 RVA: 0x0001BB7F File Offset: 0x00019D7F
	protected virtual bool OnClear()
	{
		return true;
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x0001BB82 File Offset: 0x00019D82
	protected virtual bool OnLeaveLevel()
	{
		return true;
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x0001BB85 File Offset: 0x00019D85
	protected virtual bool OnChangeMode()
	{
		return true;
	}
}
