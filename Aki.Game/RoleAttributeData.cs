using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001D29 RID: 7465
[NullableContext(1)]
[Nullable(0)]
public class RoleAttributeData : RoleModuleDataBase
{
	// Token: 0x06012837 RID: 75831 RVA: 0x00578E89 File Offset: 0x00577089
	public RoleAttributeData(int roleId) : base(roleId)
	{
	}

	// Token: 0x06012838 RID: 75832 RVA: 0x00578EA8 File Offset: 0x005770A8
	public void SetRoleBaseAttr(int key, int value)
	{
		this.RoleBaseAttr[key] = value;
	}

	// Token: 0x06012839 RID: 75833 RVA: 0x00578EB8 File Offset: 0x005770B8
	public int GetRoleBaseAttr(int key)
	{
		int result;
		if (!this.RoleBaseAttr.TryGetValue(key, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x0601283A RID: 75834 RVA: 0x00578ED8 File Offset: 0x005770D8
	public void ClearRoleBaseAttr()
	{
		this.RoleBaseAttr.Clear();
	}

	// Token: 0x0601283B RID: 75835 RVA: 0x00578EE5 File Offset: 0x005770E5
	public void SetRoleAddAttr(int key, int value)
	{
		this.RoleAddAttr[key] = value;
	}

	// Token: 0x0601283C RID: 75836 RVA: 0x00578EF4 File Offset: 0x005770F4
	public int GetRoleAddAttr(int key)
	{
		int result;
		if (!this.RoleAddAttr.TryGetValue(key, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x0601283D RID: 75837 RVA: 0x00578F14 File Offset: 0x00577114
	public void ClearRoleAddAttr()
	{
		this.RoleAddAttr.Clear();
	}

	// Token: 0x0601283E RID: 75838 RVA: 0x00578F24 File Offset: 0x00577124
	public Dictionary<int, int> GetOldRoleBaseAttr()
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (int key in this.RoleBaseAttr.Keys)
		{
			dictionary[key] = 0;
		}
		return dictionary;
	}

	// Token: 0x0601283F RID: 75839 RVA: 0x00578F84 File Offset: 0x00577184
	public Dictionary<int, int> GetOldRoleAddAttr()
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (int key in this.RoleAddAttr.Keys)
		{
			dictionary[key] = 0;
		}
		return dictionary;
	}

	// Token: 0x06012840 RID: 75840 RVA: 0x00578FE4 File Offset: 0x005771E4
	public Dictionary<int, int> GetBaseAttrList()
	{
		return this.RoleBaseAttr;
	}

	// Token: 0x06012841 RID: 75841 RVA: 0x00578FEC File Offset: 0x005771EC
	public Dictionary<int, int> GetAddAttrList()
	{
		return this.RoleAddAttr;
	}

	// Token: 0x06012842 RID: 75842 RVA: 0x00578FF4 File Offset: 0x005771F4
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

	// Token: 0x0400A0DD RID: 41181
	protected Dictionary<int, int> RoleBaseAttr = new Dictionary<int, int>();

	// Token: 0x0400A0DE RID: 41182
	protected Dictionary<int, int> RoleAddAttr = new Dictionary<int, int>();
}
