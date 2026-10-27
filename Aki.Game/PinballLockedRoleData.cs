using System;

// Token: 0x020013E3 RID: 5091
public class PinballLockedRoleData : PinballRoleDataBase
{
	// Token: 0x06008FBC RID: 36796 RVA: 0x001F14A3 File Offset: 0x001EF6A3
	public PinballLockedRoleData(int id) : base(id)
	{
	}

	// Token: 0x06008FBD RID: 36797 RVA: 0x001F14AC File Offset: 0x001EF6AC
	public override bool IsLocked()
	{
		return true;
	}
}
