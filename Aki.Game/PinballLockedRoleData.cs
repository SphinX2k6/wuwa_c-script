using System;

// Token: 0x02000897 RID: 2199
public class PinballLockedRoleData : PinballRoleDataBase
{
	// Token: 0x06006351 RID: 25425 RVA: 0x001F9FDF File Offset: 0x001F81DF
	public PinballLockedRoleData(int id) : base(id)
	{
	}

	// Token: 0x06006352 RID: 25426 RVA: 0x001F9FE8 File Offset: 0x001F81E8
	public override bool IsLocked()
	{
		return true;
	}
}
