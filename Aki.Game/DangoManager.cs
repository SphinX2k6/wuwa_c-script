using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001A72 RID: 6770
[NullableContext(1)]
[Nullable(0)]
public class DangoManager : Singleton
{
	// Token: 0x0600C75E RID: 51038 RVA: 0x002D66B0 File Offset: 0x002D48B0
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

	// Token: 0x17001059 RID: 4185
	// (get) Token: 0x0600C75F RID: 51039 RVA: 0x002D66E2 File Offset: 0x002D48E2
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

	// Token: 0x0600C760 RID: 51040 RVA: 0x002D6705 File Offset: 0x002D4905
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C761 RID: 51041 RVA: 0x002D6707 File Offset: 0x002D4907
	public static void ResetStaticDefaultValue()
	{
		DangoManager instance = DangoManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		DangoManager._instance = null;
	}

	// Token: 0x0600C762 RID: 51042 RVA: 0x002D6720 File Offset: 0x002D4920
	static DangoManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DangoManager.CreateStaticDefaultValue), new Action(DangoManager.ResetStaticDefaultValue));
	}

	// Token: 0x04005BF7 RID: 23543
	private readonly Dictionary<int, DangoData> DangoDataMap = new Dictionary<int, DangoData>();

	// Token: 0x04005BF8 RID: 23544
	[Nullable(2)]
	private static DangoManager _instance;
}
