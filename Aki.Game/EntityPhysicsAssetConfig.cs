using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002687 RID: 9863
[NullableContext(1)]
[Nullable(0)]
public class EntityPhysicsAssetConfig : ConfigBase
{
	// Token: 0x06018B0A RID: 101130 RVA: 0x0077CF3C File Offset: 0x0077B13C
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

	// Token: 0x1700271B RID: 10011
	// (get) Token: 0x06018B0B RID: 101131 RVA: 0x0077CFDA File Offset: 0x0077B1DA
	public static EntityPhysicsAssetConfig Instance
	{
		get
		{
			return EntityPhysicsAssetConfig._Instance;
		}
	}

	// Token: 0x06018B0C RID: 101132 RVA: 0x0077CFE1 File Offset: 0x0077B1E1
	public static EntityPhysicsAssetConfig GetOrCreateInstance()
	{
		if (EntityPhysicsAssetConfig._Instance == null)
		{
			EntityPhysicsAssetConfig.CreateInstance();
		}
		return EntityPhysicsAssetConfig._Instance;
	}

	// Token: 0x06018B0D RID: 101133 RVA: 0x0077CFF5 File Offset: 0x0077B1F5
	public static bool CreateInstance()
	{
		if (EntityPhysicsAssetConfig._Instance != null)
		{
			return true;
		}
		EntityPhysicsAssetConfig._Instance = new EntityPhysicsAssetConfig();
		return true;
	}

	// Token: 0x06018B0E RID: 101134 RVA: 0x0077D00B File Offset: 0x0077B20B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06018B0F RID: 101135 RVA: 0x0077D00D File Offset: 0x0077B20D
	public static void ResetStaticDefaultValue()
	{
		EntityPhysicsAssetConfig._Instance = null;
	}

	// Token: 0x06018B10 RID: 101136 RVA: 0x0077D015 File Offset: 0x0077B215
	static EntityPhysicsAssetConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EntityPhysicsAssetConfig.CreateStaticDefaultValue), new Action(EntityPhysicsAssetConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400D66E RID: 54894
	private const string DEFAULT_DB_ID = "0";

	// Token: 0x0400D66F RID: 54895
	[Nullable(2)]
	private static EntityPhysicsAssetConfig _Instance;
}
