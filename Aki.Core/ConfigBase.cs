using System;

// Token: 0x020000A0 RID: 160
public abstract class ConfigBase
{
	// Token: 0x060004F7 RID: 1271 RVA: 0x0001B806 File Offset: 0x00019A06
	public bool Init()
	{
		return this.OnInit();
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x0001B80E File Offset: 0x00019A0E
	public bool Clear()
	{
		return this.OnClear();
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x0001B816 File Offset: 0x00019A16
	protected virtual bool OnInit()
	{
		return true;
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x0001B819 File Offset: 0x00019A19
	protected virtual bool OnClear()
	{
		return true;
	}
}
