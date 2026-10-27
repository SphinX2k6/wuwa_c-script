using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200312C RID: 12588
[NullableContext(1)]
[Nullable(0)]
public class EntityPhysicsAssetConfig : ConfigBase
{
	// Token: 0x0601B0AF RID: 110767 RVA: 0x00756ED0 File Offset: 0x007550D0
	public PhysicsAssetConfig? GetPhysicsAssetConfigByRoleBody(string height)
	{
		PhysicsAssetConfig? config = ConfigPhysicsAssetConfigByIdWithDefaultId.GetConfig("0", height, height, height, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "该角色未在角色物理资产配置表中默认值配置 /Config/j.角色物理资产";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("默认值Id", "0");
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		if (config.Value.Id != height)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Character;
			ELogAuthor author2 = ELogAuthor.LJM;
			string message2 = "该角色未在角色物理资产配置表中配置 /Config/j.角色物理资产";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("默认值Id", "0");
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		return config;
	}

	// Token: 0x17002570 RID: 9584
	// (get) Token: 0x0601B0B0 RID: 110768 RVA: 0x00756F6E File Offset: 0x0075516E
	public static EntityPhysicsAssetConfig Instance
	{
		get
		{
			return EntityPhysicsAssetConfig._Instance;
		}
	}

	// Token: 0x0601B0B1 RID: 110769 RVA: 0x00756F75 File Offset: 0x00755175
	public static EntityPhysicsAssetConfig GetOrCreateInstance()
	{
		if (EntityPhysicsAssetConfig._Instance == null)
		{
			EntityPhysicsAssetConfig.CreateInstance();
		}
		return EntityPhysicsAssetConfig._Instance;
	}

	// Token: 0x0601B0B2 RID: 110770 RVA: 0x00756F89 File Offset: 0x00755189
	public static bool CreateInstance()
	{
		if (EntityPhysicsAssetConfig._Instance != null)
		{
			return true;
		}
		EntityPhysicsAssetConfig._Instance = new EntityPhysicsAssetConfig();
		return true;
	}

	// Token: 0x0601B0B3 RID: 110771 RVA: 0x00756F9F File Offset: 0x0075519F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B0B4 RID: 110772 RVA: 0x00756FA1 File Offset: 0x007551A1
	public static void ResetStaticDefaultValue()
	{
		EntityPhysicsAssetConfig._Instance = null;
	}

	// Token: 0x0601B0B5 RID: 110773 RVA: 0x00756FA9 File Offset: 0x007551A9
	static EntityPhysicsAssetConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EntityPhysicsAssetConfig.CreateStaticDefaultValue), new Action(EntityPhysicsAssetConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400D24C RID: 53836
	private const string DEFAULT_DB_ID = "0";

	// Token: 0x0400D24D RID: 53837
	[Nullable(2)]
	private static EntityPhysicsAssetConfig _Instance;
}
