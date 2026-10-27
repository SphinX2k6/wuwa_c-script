using System;

// Token: 0x020013E5 RID: 5093
public class PinballRoleData : PinballRoleDataBase
{
	// Token: 0x06008FC3 RID: 36803 RVA: 0x001F16FD File Offset: 0x001EF8FD
	public PinballRoleData(int id) : base(id)
	{
	}

	// Token: 0x06008FC4 RID: 36804 RVA: 0x001F1706 File Offset: 0x001EF906
	public override bool IsLocked()
	{
		return false;
	}
}
