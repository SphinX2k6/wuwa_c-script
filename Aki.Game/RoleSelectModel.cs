using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200278F RID: 10127
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RoleSelectModel : ModelBase
{
	// Token: 0x06014C76 RID: 85110 RVA: 0x00543578 File Offset: 0x00541778
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

	// Token: 0x06014C77 RID: 85111 RVA: 0x005435E0 File Offset: 0x005417E0
	public void ClearData()
	{
		this.SelectedRoleSet.Clear();
		this.RoleIndexMap.Clear();
	}

	// Token: 0x17001B1F RID: 6943
	// (get) Token: 0x06014C78 RID: 85112 RVA: 0x005435F8 File Offset: 0x005417F8
	public static RoleSelectModel Instance
	{
		get
		{
			return RoleSelectModel._Instance;
		}
	}

	// Token: 0x06014C79 RID: 85113 RVA: 0x005435FF File Offset: 0x005417FF
	public static RoleSelectModel GetOrCreateInstance()
	{
		if (RoleSelectModel._Instance == null)
		{
			RoleSelectModel.CreateInstance();
		}
		return RoleSelectModel._Instance;
	}

	// Token: 0x06014C7A RID: 85114 RVA: 0x00543613 File Offset: 0x00541813
	public static bool CreateInstance()
	{
		if (RoleSelectModel._Instance != null)
		{
			return true;
		}
		RoleSelectModel._Instance = new RoleSelectModel();
		return true;
	}

	// Token: 0x06014C7B RID: 85115 RVA: 0x00543629 File Offset: 0x00541829
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014C7C RID: 85116 RVA: 0x0054362B File Offset: 0x0054182B
	public static void ResetStaticDefaultValue()
	{
		RoleSelectModel._Instance = null;
	}

	// Token: 0x06014C7D RID: 85117 RVA: 0x00543633 File Offset: 0x00541833
	static RoleSelectModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleSelectModel.CreateStaticDefaultValue), new Action(RoleSelectModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009C60 RID: 40032
	public readonly HashSet<int> SelectedRoleSet = new HashSet<int>();

	// Token: 0x04009C61 RID: 40033
	public readonly Dictionary<int, RoleDataBase> RoleIndexMap = new Dictionary<int, RoleDataBase>();

	// Token: 0x04009C62 RID: 40034
	[Nullable(2)]
	private static RoleSelectModel _Instance;
}
