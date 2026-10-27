using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200284B RID: 10315
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class RoleFavorConfig : ConfigBase
{
	// Token: 0x06015449 RID: 87113 RVA: 0x0055F550 File Offset: 0x0055D750
	public FavorLevel? GetFavorLevelConfig(int level)
	{
		FavorLevel? config = ConfigFavorLevelByLevel.GetConfig(level, true);
		if (config == null)
		{
			return null;
		}
		return new FavorLevel?(config.Value);
	}

	// Token: 0x0601544A RID: 87114 RVA: 0x0055F584 File Offset: 0x0055D784
	public FavorRoleInfo? GetFavorRoleInfoConfig(int roleId)
	{
		FavorRoleInfo? config = ConfigFavorRoleInfoByRoleId.GetConfig(roleId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "角色档案配置表获取配置失败,RoleId = ";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new FavorRoleInfo?(config.Value);
	}

	// Token: 0x0601544B RID: 87115 RVA: 0x0055F5E4 File Offset: 0x0055D7E4
	public FavorWord? GetFavorWordConfigById(int id)
	{
		return ConfigFavorWordById.GetConfig(id, true);
	}

	// Token: 0x0601544C RID: 87116 RVA: 0x0055F5F0 File Offset: 0x0055D7F0
	public IReadOnlyList<FavorGoods> GetFavorGoodsConfig(int roleId)
	{
		IReadOnlyList<FavorGoods> configList = ConfigFavorGoodsByRoleId.GetConfigList(roleId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "好感度物品配置表获取配置失败,RoleId = ";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return configList;
	}

	// Token: 0x0601544D RID: 87117 RVA: 0x0055F638 File Offset: 0x0055D838
	public IReadOnlyList<FavorStory> GetFavorStoryConfig(int roleId)
	{
		IReadOnlyList<FavorStory> configList = ConfigFavorStoryByRoleId.GetConfigList(roleId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "好感度故事配置表获取配置失败,RoleId =  Order By Sort";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return configList;
	}

	// Token: 0x0601544E RID: 87118 RVA: 0x0055F680 File Offset: 0x0055D880
	public IReadOnlyList<FavorWord> GetFavorWordConfig(int roleId, int type)
	{
		IReadOnlyList<FavorWord> configList = ConfigFavorWordByRoleIdAndType.GetConfigList(roleId, type, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 2);
			defaultInterpolatedStringHandler.AppendLiteral("好感度语音配置表获取配置失败,RoleId = ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(roleId);
			defaultInterpolatedStringHandler.AppendLiteral(" Type = ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(type);
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return configList;
	}

	// Token: 0x0601544F RID: 87119 RVA: 0x0055F6EC File Offset: 0x0055D8EC
	public FavorTabCamera? GetFavorTabCameraConfig(EFavorTabType favorTabType)
	{
		FavorTabCamera? config = ConfigFavorTabCameraById.GetConfig((int)favorTabType, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "好感度切页镜头配置获取失败,Id = ";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("favorTabType", favorTabType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new FavorTabCamera?(config.Value);
	}

	// Token: 0x17001C65 RID: 7269
	// (get) Token: 0x06015450 RID: 87120 RVA: 0x0055F74C File Offset: 0x0055D94C
	[Nullable(1)]
	public static RoleFavorConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return RoleFavorConfig._Instance;
		}
	}

	// Token: 0x06015451 RID: 87121 RVA: 0x0055F753 File Offset: 0x0055D953
	[NullableContext(1)]
	public static RoleFavorConfig GetOrCreateInstance()
	{
		if (RoleFavorConfig._Instance == null)
		{
			RoleFavorConfig.CreateInstance();
		}
		return RoleFavorConfig._Instance;
	}

	// Token: 0x06015452 RID: 87122 RVA: 0x0055F767 File Offset: 0x0055D967
	public static bool CreateInstance()
	{
		if (RoleFavorConfig._Instance != null)
		{
			return true;
		}
		RoleFavorConfig._Instance = new RoleFavorConfig();
		return true;
	}

	// Token: 0x06015453 RID: 87123 RVA: 0x0055F77D File Offset: 0x0055D97D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015454 RID: 87124 RVA: 0x0055F77F File Offset: 0x0055D97F
	public static void ResetStaticDefaultValue()
	{
		RoleFavorConfig._Instance = null;
	}

	// Token: 0x06015455 RID: 87125 RVA: 0x0055F787 File Offset: 0x0055D987
	static RoleFavorConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleFavorConfig.CreateStaticDefaultValue), new Action(RoleFavorConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04009ED2 RID: 40658
	private static RoleFavorConfig _Instance;
}
