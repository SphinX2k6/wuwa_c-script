using System;

// Token: 0x0200009E RID: 158
public abstract class ConfigBase
{
	// Token: 0x060004B6 RID: 1206 RVA: 0x0001B11E File Offset: 0x0001931E
	public bool Init()
	{
		return this.OnInit();
	}

	// Token: 0x060004B7 RID: 1207 RVA: 0x0001B126 File Offset: 0x00019326
	public bool Clear()
	{
		return this.OnClear();
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x0001B12E File Offset: 0x0001932E
	protected virtual bool OnInit()
	{
		return true;
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x0001B131 File Offset: 0x00019331
	protected virtual bool OnClear()
	{
		return true;
	}
}
