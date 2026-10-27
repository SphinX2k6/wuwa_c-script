using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020027AE RID: 10158
[NullableContext(1)]
[Nullable(0)]
public class RoleAttributeData : RoleModuleDataBase
{
	// Token: 0x06014E38 RID: 85560 RVA: 0x0054E161 File Offset: 0x0054C361
	public RoleAttributeData(int roleId) : base(roleId)
	{
	}

	// Token: 0x06014E39 RID: 85561 RVA: 0x0054E180 File Offset: 0x0054C380
	public void SetRoleBaseAttr(int key, int value)
	{
		this.RoleBaseAttr[key] = value;
	}

	// Token: 0x06014E3A RID: 85562 RVA: 0x0054E190 File Offset: 0x0054C390
	public int GetRoleBaseAttr(int key)
	{
		int result;
		if (!this.RoleBaseAttr.TryGetValue(key, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x06014E3B RID: 85563 RVA: 0x0054E1B0 File Offset: 0x0054C3B0
	public void ClearRoleBaseAttr()
	{
		this.RoleBaseAttr.Clear();
	}

	// Token: 0x06014E3C RID: 85564 RVA: 0x0054E1BD File Offset: 0x0054C3BD
	public void SetRoleAddAttr(int key, int value)
	{
		this.RoleAddAttr[key] = value;
	}

	// Token: 0x06014E3D RID: 85565 RVA: 0x0054E1CC File Offset: 0x0054C3CC
	public int GetRoleAddAttr(int key)
	{
		int result;
		if (!this.RoleAddAttr.TryGetValue(key, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x06014E3E RID: 85566 RVA: 0x0054E1EC File Offset: 0x0054C3EC
	public void ClearRoleAddAttr()
	{
		this.RoleAddAttr.Clear();
	}

	// Token: 0x06014E3F RID: 85567 RVA: 0x0054E1FC File Offset: 0x0054C3FC
	public Dictionary<int, int> GetOldRoleBaseAttr()
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (int key in this.RoleBaseAttr.Keys)
		{
			dictionary[key] = 0;
		}
		return dictionary;
	}

	// Token: 0x06014E40 RID: 85568 RVA: 0x0054E25C File Offset: 0x0054C45C
	public Dictionary<int, int> GetOldRoleAddAttr()
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (int key in this.RoleAddAttr.Keys)
		{
			dictionary[key] = 0;
		}
		return dictionary;
	}

	// Token: 0x06014E41 RID: 85569 RVA: 0x0054E2BC File Offset: 0x0054C4BC
	public Dictionary<int, int> GetBaseAttrList()
	{
		return this.RoleBaseAttr;
	}

	// Token: 0x06014E42 RID: 85570 RVA: 0x0054E2C4 File Offset: 0x0054C4C4
	public Dictionary<int, int> GetAddAttrList()
	{
		return this.RoleAddAttr;
	}

	// Token: 0x06014E43 RID: 85571 RVA: 0x0054E2CC File Offset: 0x0054C4CC
	public int GetAttrValueById(int id)
	{
		int num = 0;
		int num2;
		if (this.RoleBaseAttr.TryGetValue(id, out num2))
		{
			num += num2;
		}
		int num3;
		if (this.RoleAddAttr.TryGetValue(id, out num3))
		{
			num += num3;
		}
		return num;
	}

	// Token: 0x04009CFA RID: 40186
	protected Dictionary<int, int> RoleBaseAttr = new Dictionary<int, int>();

	// Token: 0x04009CFB RID: 40187
	protected Dictionary<int, int> RoleAddAttr = new Dictionary<int, int>();
}
