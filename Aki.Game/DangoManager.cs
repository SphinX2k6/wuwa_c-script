using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000F31 RID: 3889
[NullableContext(1)]
[Nullable(0)]
public class DangoManager : Singleton
{
	// Token: 0x06009B6E RID: 39790 RVA: 0x002E17A0 File Offset: 0x002DF9A0
	public DangoData GetDangoData(int id)
	{
		DangoData dangoData;
		if (!this.DangoDataMap.TryGetValue(id, out dangoData))
		{
			dangoData = DangoData.Create(id);
			this.DangoDataMap[id] = dangoData;
		}
		return dangoData;
	}

	// Token: 0x1700107E RID: 4222
	// (get) Token: 0x06009B6F RID: 39791 RVA: 0x002E17D2 File Offset: 0x002DF9D2
	public static DangoManager Instance
	{
		get
		{
			if (DangoManager._instance == null)
			{
				DangoManager._instance = new DangoManager();
				DangoManager._instance.OnInit();
			}
			return DangoManager._instance;
		}
	}

	// Token: 0x06009B70 RID: 39792 RVA: 0x002E17F5 File Offset: 0x002DF9F5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009B71 RID: 39793 RVA: 0x002E17F7 File Offset: 0x002DF9F7
	public static void ResetStaticDefaultValue()
	{
		DangoManager instance = DangoManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		DangoManager._instance = null;
	}

	// Token: 0x06009B72 RID: 39794 RVA: 0x002E1810 File Offset: 0x002DFA10
	static DangoManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DangoManager.CreateStaticDefaultValue), new Action(DangoManager.ResetStaticDefaultValue));
	}

	// Token: 0x04005CC6 RID: 23750
	private readonly Dictionary<int, DangoData> DangoDataMap = new Dictionary<int, DangoData>();

	// Token: 0x04005CC7 RID: 23751
	[Nullable(2)]
	private static DangoManager _instance;
}
