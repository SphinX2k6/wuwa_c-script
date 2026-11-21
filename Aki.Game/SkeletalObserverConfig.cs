using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;

// Token: 0x02001F91 RID: 8081
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class SkeletalObserverConfig : ConfigBase
{
	// Token: 0x06013FDF RID: 81887 RVA: 0x005D43A8 File Offset: 0x005D25A8
	[NullableContext(2)]
	public SModelConfig GetMeshConfig(int meshId)
	{
		return DataTableUtil.GetDataTableRowFromName<SModelConfig>(EDataTable.ModelConfig, meshId.ToString());
	}

	// Token: 0x17001E2A RID: 7722
	// (get) Token: 0x06013FE0 RID: 81888 RVA: 0x005D43B7 File Offset: 0x005D25B7
	public static SkeletalObserverConfig Instance
	{
		get
		{
			return SkeletalObserverConfig._Instance;
		}
	}

	// Token: 0x06013FE1 RID: 81889 RVA: 0x005D43BE File Offset: 0x005D25BE
	public static SkeletalObserverConfig GetOrCreateInstance()
	{
		if (SkeletalObserverConfig._Instance == null)
		{
			SkeletalObserverConfig.CreateInstance();
		}
		return SkeletalObserverConfig._Instance;
	}

	// Token: 0x06013FE2 RID: 81890 RVA: 0x005D43D2 File Offset: 0x005D25D2
	public static bool CreateInstance()
	{
		if (SkeletalObserverConfig._Instance != null)
		{
			return true;
		}
		SkeletalObserverConfig._Instance = new SkeletalObserverConfig();
		return true;
	}

	// Token: 0x06013FE3 RID: 81891 RVA: 0x005D43E8 File Offset: 0x005D25E8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013FE4 RID: 81892 RVA: 0x005D43EA File Offset: 0x005D25EA
	public static void ResetStaticDefaultValue()
	{
		SkeletalObserverConfig._Instance = null;
	}

	// Token: 0x06013FE5 RID: 81893 RVA: 0x005D43F2 File Offset: 0x005D25F2
	static SkeletalObserverConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SkeletalObserverConfig.CreateStaticDefaultValue), new Action(SkeletalObserverConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400AA61 RID: 43617
	[Nullable(2)]
	private static SkeletalObserverConfig _Instance;
}
