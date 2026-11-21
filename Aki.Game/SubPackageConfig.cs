using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200200C RID: 8204
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class SubPackageConfig : ConfigBase
{
	// Token: 0x0601450D RID: 83213 RVA: 0x005EAD24 File Offset: 0x005E8F24
	public DownLoadSubPackage? GetDownLoadSubPackageById(int id)
	{
		return ConfigDownLoadSubPackageById.GetConfig(id, true);
	}

	// Token: 0x0601450E RID: 83214 RVA: 0x005EAD2D File Offset: 0x005E8F2D
	public DownLoadVersion? GetDownLoadVersionByVersion(int version)
	{
		return ConfigDownLoadVersionByVersion.GetConfig(version, true);
	}

	// Token: 0x0601450F RID: 83215 RVA: 0x005EAD36 File Offset: 0x005E8F36
	public IReadOnlyList<DownLoadVersion> GetDownLoadVersionByType(int type)
	{
		return ConfigDownLoadVersionByType.GetConfigList(type, true);
	}

	// Token: 0x06014510 RID: 83216 RVA: 0x005EAD3F File Offset: 0x005E8F3F
	public IReadOnlyList<DownLoadSubPackage> GetDownLoadSubPackageList()
	{
		return ConfigDownLoadSubPackageAll.GetConfigList(true);
	}

	// Token: 0x06014511 RID: 83217 RVA: 0x005EAD47 File Offset: 0x005E8F47
	public IReadOnlyList<DownLoadSubPackage> GetDownLoadSubPackageListByVersion(int versionId)
	{
		return ConfigDownLoadSubPackageByVersion.GetConfigList(versionId, true);
	}

	// Token: 0x06014512 RID: 83218 RVA: 0x005EAD50 File Offset: 0x005E8F50
	public IReadOnlyList<VideoData> GetVideoDataByBranch(int branch)
	{
		return ConfigVideoDataByBelongBranch.GetConfigList(branch, true);
	}

	// Token: 0x17001E8F RID: 7823
	// (get) Token: 0x06014513 RID: 83219 RVA: 0x005EAD59 File Offset: 0x005E8F59
	[Nullable(1)]
	public static SubPackageConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return SubPackageConfig._Instance;
		}
	}

	// Token: 0x06014514 RID: 83220 RVA: 0x005EAD60 File Offset: 0x005E8F60
	[NullableContext(1)]
	public static SubPackageConfig GetOrCreateInstance()
	{
		if (SubPackageConfig._Instance == null)
		{
			SubPackageConfig.CreateInstance();
		}
		return SubPackageConfig._Instance;
	}

	// Token: 0x06014515 RID: 83221 RVA: 0x005EAD74 File Offset: 0x005E8F74
	public static bool CreateInstance()
	{
		if (SubPackageConfig._Instance != null)
		{
			return true;
		}
		SubPackageConfig._Instance = new SubPackageConfig();
		return true;
	}

	// Token: 0x06014516 RID: 83222 RVA: 0x005EAD8A File Offset: 0x005E8F8A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014517 RID: 83223 RVA: 0x005EAD8C File Offset: 0x005E8F8C
	public static void ResetStaticDefaultValue()
	{
		SubPackageConfig._Instance = null;
	}

	// Token: 0x06014518 RID: 83224 RVA: 0x005EAD94 File Offset: 0x005E8F94
	static SubPackageConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SubPackageConfig.CreateStaticDefaultValue), new Action(SubPackageConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400AC5A RID: 44122
	private static SubPackageConfig _Instance;
}
