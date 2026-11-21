using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001C7A RID: 7290
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RoleSelectModel : ModelBase
{
	// Token: 0x06012161 RID: 74081 RVA: 0x0055265C File Offset: 0x0055085C
	public int GetRoleIndex(int roleConfigId)
	{
		foreach (KeyValuePair<int, RoleDataBase> keyValuePair in this.RoleIndexMap)
		{
			if (keyValuePair.Value.GetDataId() == roleConfigId)
			{
				return keyValuePair.Key;
			}
		}
		return 0;
	}

	// Token: 0x06012162 RID: 74082 RVA: 0x005526C4 File Offset: 0x005508C4
	public void ClearData()
	{
		this.SelectedRoleSet.Clear();
		this.RoleIndexMap.Clear();
	}

	// Token: 0x17001B58 RID: 7000
	// (get) Token: 0x06012163 RID: 74083 RVA: 0x005526DC File Offset: 0x005508DC
	public static RoleSelectModel Instance
	{
		get
		{
			return RoleSelectModel._Instance;
		}
	}

	// Token: 0x06012164 RID: 74084 RVA: 0x005526E3 File Offset: 0x005508E3
	public static RoleSelectModel GetOrCreateInstance()
	{
		if (RoleSelectModel._Instance == null)
		{
			RoleSelectModel.CreateInstance();
		}
		return RoleSelectModel._Instance;
	}

	// Token: 0x06012165 RID: 74085 RVA: 0x005526F7 File Offset: 0x005508F7
	public static bool CreateInstance()
	{
		if (RoleSelectModel._Instance != null)
		{
			return true;
		}
		RoleSelectModel._Instance = new RoleSelectModel();
		return true;
	}

	// Token: 0x06012166 RID: 74086 RVA: 0x0055270D File Offset: 0x0055090D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012167 RID: 74087 RVA: 0x0055270F File Offset: 0x0055090F
	public static void ResetStaticDefaultValue()
	{
		RoleSelectModel._Instance = null;
	}

	// Token: 0x06012168 RID: 74088 RVA: 0x00552717 File Offset: 0x00550917
	static RoleSelectModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleSelectModel.CreateStaticDefaultValue), new Action(RoleSelectModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009DC4 RID: 40388
	public readonly HashSet<int> SelectedRoleSet = new HashSet<int>();

	// Token: 0x04009DC5 RID: 40389
	public readonly Dictionary<int, RoleDataBase> RoleIndexMap = new Dictionary<int, RoleDataBase>();

	// Token: 0x04009DC6 RID: 40390
	[Nullable(2)]
	private static RoleSelectModel _Instance;
}
