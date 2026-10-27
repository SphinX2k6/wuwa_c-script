using System;
using System.Runtime.CompilerServices;

// Token: 0x02000082 RID: 130
[NullableContext(1)]
[Nullable(0)]
public class EntitySystemHelper : Singleton
{
	// Token: 0x17000093 RID: 147
	// (get) Token: 0x060003FD RID: 1021 RVA: 0x00017DE5 File Offset: 0x00015FE5
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

	// Token: 0x060003FE RID: 1022 RVA: 0x00017E08 File Offset: 0x00016008
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060003FF RID: 1023 RVA: 0x00017E0A File Offset: 0x0001600A
	public static void ResetStaticDefaultValue()
	{
		EntitySystemHelper instance = EntitySystemHelper._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		EntitySystemHelper._instance = null;
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x00017E23 File Offset: 0x00016023
	static EntitySystemHelper()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EntitySystemHelper.CreateStaticDefaultValue), new Action(EntitySystemHelper.ResetStaticDefaultValue));
	}

	// Token: 0x040003B8 RID: 952
	public bool IsSortDirty;

	// Token: 0x040003B9 RID: 953
	public bool IsFilterDirty;

	// Token: 0x040003BA RID: 954
	public int SortedFrame = -1;

	// Token: 0x040003BB RID: 955
	[Nullable(2)]
	private static EntitySystemHelper _instance;
}
