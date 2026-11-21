using System;
using System.Runtime.CompilerServices;

// Token: 0x02000084 RID: 132
[NullableContext(1)]
[Nullable(0)]
public class EntitySystemHelper : Singleton
{
	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x0600043D RID: 1085 RVA: 0x000186CE File Offset: 0x000168CE
	public static EntitySystemHelper Instance
	{
		get
		{
			if (EntitySystemHelper._instance == null)
			{
				EntitySystemHelper._instance = new EntitySystemHelper();
				EntitySystemHelper._instance.OnInit();
			}
			return EntitySystemHelper._instance;
		}
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x000186F1 File Offset: 0x000168F1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x000186F3 File Offset: 0x000168F3
	public static void ResetStaticDefaultValue()
	{
		EntitySystemHelper instance = EntitySystemHelper._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		EntitySystemHelper._instance = null;
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x0001870C File Offset: 0x0001690C
	static EntitySystemHelper()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EntitySystemHelper.CreateStaticDefaultValue), new Action(EntitySystemHelper.ResetStaticDefaultValue));
	}

	// Token: 0x040003C6 RID: 966
	public bool IsSortDirty;

	// Token: 0x040003C7 RID: 967
	public bool IsFilterDirty;

	// Token: 0x040003C8 RID: 968
	public int SortedFrame = -1;

	// Token: 0x040003C9 RID: 969
	[Nullable(2)]
	private static EntitySystemHelper _instance;
}
