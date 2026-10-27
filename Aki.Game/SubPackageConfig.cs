using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002A90 RID: 10896
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class SubPackageConfig : ConfigBase
{
	// Token: 0x06016AE8 RID: 92904 RVA: 0x005BEB3C File Offset: 0x005BCD3C
	public DownLoadSubPackage? GetDownLoadSubPackageById(int id)
	{
		return ConfigDownLoadSubPackageById.GetConfig(id, true);
	}

	// Token: 0x06016AE9 RID: 92905 RVA: 0x005BEB45 File Offset: 0x005BCD45
	public DownLoadVersion? GetDownLoadVersionByVersion(int version)
	{
		return ConfigDownLoadVersionByVersion.GetConfig(version, true);
	}

	// Token: 0x06016AEA RID: 92906 RVA: 0x005BEB4E File Offset: 0x005BCD4E
	public IReadOnlyList<DownLoadVersion> GetDownLoadVersionByType(int type)
	{
		return ConfigDownLoadVersionByType.GetConfigList(type, true);
	}

	// Token: 0x06016AEB RID: 92907 RVA: 0x005BEB57 File Offset: 0x005BCD57
	public IReadOnlyList<DownLoadSubPackage> GetDownLoadSubPackageList()
	{
		return ConfigDownLoadSubPackageAll.GetConfigList(true);
	}

	// Token: 0x06016AEC RID: 92908 RVA: 0x005BEB5F File Offset: 0x005BCD5F
	public IReadOnlyList<DownLoadSubPackage> GetDownLoadSubPackageListByVersion(int versionId)
	{
		return ConfigDownLoadSubPackageByVersion.GetConfigList(versionId, true);
	}

	// Token: 0x06016AED RID: 92909 RVA: 0x005BEB68 File Offset: 0x005BCD68
	public IReadOnlyList<VideoData> GetVideoDataByBranch(int branch)
	{
		return ConfigVideoDataByBelongBranch.GetConfigList(branch, true);
	}

	// Token: 0x17001E37 RID: 7735
	// (get) Token: 0x06016AEE RID: 92910 RVA: 0x005BEB71 File Offset: 0x005BCD71
	[Nullable(1)]
	public static SubPackageConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return SubPackageConfig._Instance;
		}
	}

	// Token: 0x06016AEF RID: 92911 RVA: 0x005BEB78 File Offset: 0x005BCD78
	[NullableContext(1)]
	public static SubPackageConfig GetOrCreateInstance()
	{
		if (SubPackageConfig._Instance == null)
		{
			SubPackageConfig.CreateInstance();
		}
		return SubPackageConfig._Instance;
	}

	// Token: 0x06016AF0 RID: 92912 RVA: 0x005BEB8C File Offset: 0x005BCD8C
	public static bool CreateInstance()
	{
		if (SubPackageConfig._Instance != null)
		{
			return true;
		}
		SubPackageConfig._Instance = new SubPackageConfig();
		return true;
	}

	// Token: 0x06016AF1 RID: 92913 RVA: 0x005BEBA2 File Offset: 0x005BCDA2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016AF2 RID: 92914 RVA: 0x005BEBA4 File Offset: 0x005BCDA4
	public static void ResetStaticDefaultValue()
	{
		SubPackageConfig._Instance = null;
	}

	// Token: 0x06016AF3 RID: 92915 RVA: 0x005BEBAC File Offset: 0x005BCDAC
	static SubPackageConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SubPackageConfig.CreateStaticDefaultValue), new Action(SubPackageConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400A855 RID: 43093
	private static SubPackageConfig _Instance;
}
