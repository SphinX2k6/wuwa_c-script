using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DC6 RID: 7622
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class RoleFavorConfig : ConfigBase
{
	// Token: 0x06012E47 RID: 77383 RVA: 0x0058A2AC File Offset: 0x005884AC
	public FavorLevel? GetFavorLevelConfig(int level)
	{
		FavorLevel? config = ConfigFavorLevelByLevel.GetConfig(level, true);
		if (config == null)
		{
			return null;
		}
		return new FavorLevel?(config.Value);
	}

	// Token: 0x06012E48 RID: 77384 RVA: 0x0058A2E0 File Offset: 0x005884E0
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

	// Token: 0x06012E49 RID: 77385 RVA: 0x0058A340 File Offset: 0x00588540
	public FavorWord? GetFavorWordConfigById(int id)
	{
		return ConfigFavorWordById.GetConfig(id, true);
	}

	// Token: 0x06012E4A RID: 77386 RVA: 0x0058A34C File Offset: 0x0058854C
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

	// Token: 0x06012E4B RID: 77387 RVA: 0x0058A394 File Offset: 0x00588594
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

	// Token: 0x06012E4C RID: 77388 RVA: 0x0058A3DC File Offset: 0x005885DC
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

	// Token: 0x06012E4D RID: 77389 RVA: 0x0058A448 File Offset: 0x00588648
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

	// Token: 0x17001CBD RID: 7357
	// (get) Token: 0x06012E4E RID: 77390 RVA: 0x0058A4A8 File Offset: 0x005886A8
	[Nullable(1)]
	public static RoleFavorConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return RoleFavorConfig._Instance;
		}
	}

	// Token: 0x06012E4F RID: 77391 RVA: 0x0058A4AF File Offset: 0x005886AF
	[NullableContext(1)]
	public static RoleFavorConfig GetOrCreateInstance()
	{
		if (RoleFavorConfig._Instance == null)
		{
			RoleFavorConfig.CreateInstance();
		}
		return RoleFavorConfig._Instance;
	}

	// Token: 0x06012E50 RID: 77392 RVA: 0x0058A4C3 File Offset: 0x005886C3
	public static bool CreateInstance()
	{
		if (RoleFavorConfig._Instance != null)
		{
			return true;
		}
		RoleFavorConfig._Instance = new RoleFavorConfig();
		return true;
	}

	// Token: 0x06012E51 RID: 77393 RVA: 0x0058A4D9 File Offset: 0x005886D9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012E52 RID: 77394 RVA: 0x0058A4DB File Offset: 0x005886DB
	public static void ResetStaticDefaultValue()
	{
		RoleFavorConfig._Instance = null;
	}

	// Token: 0x06012E53 RID: 77395 RVA: 0x0058A4E3 File Offset: 0x005886E3
	static RoleFavorConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleFavorConfig.CreateStaticDefaultValue), new Action(RoleFavorConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400A2BB RID: 41659
	private static RoleFavorConfig _Instance;
}
