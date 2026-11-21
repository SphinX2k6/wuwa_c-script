using System;

// Token: 0x02000899 RID: 2201
public class PinballRoleData : PinballRoleDataBase
{
	// Token: 0x06006358 RID: 25432 RVA: 0x001FA239 File Offset: 0x001F8439
	public PinballRoleData(int id) : base(id)
	{
	}

	// Token: 0x06006359 RID: 25433 RVA: 0x001FA242 File Offset: 0x001F8442
	public override bool IsLocked()
	{
		return false;
	}
}
