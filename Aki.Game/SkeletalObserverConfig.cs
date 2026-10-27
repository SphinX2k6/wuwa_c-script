using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;

// Token: 0x02002A16 RID: 10774
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class SkeletalObserverConfig : ConfigBase
{
	// Token: 0x060165D8 RID: 91608 RVA: 0x005A93D0 File Offset: 0x005A75D0
	[NullableContext(2)]
	public SModelConfig GetMeshConfig(int meshId)
	{
		return DataTableUtil.GetDataTableRowFromName<SModelConfig>(EDataTable.ModelConfig, meshId.ToString());
	}

	// Token: 0x17001DD1 RID: 7633
	// (get) Token: 0x060165D9 RID: 91609 RVA: 0x005A93DF File Offset: 0x005A75DF
	public static SkeletalObserverConfig Instance
	{
		get
		{
			return SkeletalObserverConfig._Instance;
		}
	}

	// Token: 0x060165DA RID: 91610 RVA: 0x005A93E6 File Offset: 0x005A75E6
	public static SkeletalObserverConfig GetOrCreateInstance()
	{
		if (SkeletalObserverConfig._Instance == null)
		{
			SkeletalObserverConfig.CreateInstance();
		}
		return SkeletalObserverConfig._Instance;
	}

	// Token: 0x060165DB RID: 91611 RVA: 0x005A93FA File Offset: 0x005A75FA
	public static bool CreateInstance()
	{
		if (SkeletalObserverConfig._Instance != null)
		{
			return true;
		}
		SkeletalObserverConfig._Instance = new SkeletalObserverConfig();
		return true;
	}

	// Token: 0x060165DC RID: 91612 RVA: 0x005A9410 File Offset: 0x005A7610
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060165DD RID: 91613 RVA: 0x005A9412 File Offset: 0x005A7612
	public static void ResetStaticDefaultValue()
	{
		SkeletalObserverConfig._Instance = null;
	}

	// Token: 0x060165DE RID: 91614 RVA: 0x005A941A File Offset: 0x005A761A
	static SkeletalObserverConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SkeletalObserverConfig.CreateStaticDefaultValue), new Action(SkeletalObserverConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400A677 RID: 42615
	[Nullable(2)]
	private static SkeletalObserverConfig _Instance;
}
