using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020017FF RID: 6143
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ComponentConfig : ConfigBase
{
	// Token: 0x0600B409 RID: 46089 RVA: 0x0028A7DC File Offset: 0x002889DC
	[return: Nullable(2)]
	public string GetItemConfigParam(string tag)
	{
		ItemIconTag? config = ConfigItemIconTagById.GetConfig(tag, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LguiUtil;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[ComponentConfig.GetItemConfigParam]查找配置数据失败，数据为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("标签", tag);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config.Value.ConfigParam;
	}

	// Token: 0x0600B40A RID: 46090 RVA: 0x0028A838 File Offset: 0x00288A38
	[return: Nullable(2)]
	public string GetQualityConfigParam(string tag)
	{
		QualityIconTag? config = ConfigQualityIconTagById.GetConfig(tag, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LguiUtil;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[ComponentConfig.GetQualityConfigParam]查找配置数据失败，数据为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("标签", tag);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config.Value.ConfigParam;
	}

	// Token: 0x0600B40B RID: 46091 RVA: 0x0028A894 File Offset: 0x00288A94
	[return: Nullable(2)]
	public string GetRoleConfigParam(string tag)
	{
		RoleIconTag? config = ConfigRoleIconTagById.GetConfig(tag, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LguiUtil;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[ComponentConfig.GetRoleConfigParam]查找配置数据失败，数据为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("标签", tag);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config.Value.ConfigParam;
	}

	// Token: 0x0600B40C RID: 46092 RVA: 0x0028A8F0 File Offset: 0x00288AF0
	[return: Nullable(2)]
	public string GetRoleSkinConfigParam(string tag)
	{
		RoleIconTag? config = ConfigRoleIconTagById.GetConfig(tag, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LguiUtil;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[ComponentConfig.GetRoleConfigParam]查找配置数据失败，数据为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("标签", tag);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config.Value.ConfigParam;
	}

	// Token: 0x0600B40D RID: 46093 RVA: 0x0028A94C File Offset: 0x00288B4C
	[return: Nullable(2)]
	public string GetElementConfigParam(string tag)
	{
		ElementIconTag? config = ConfigElementIconTagById.GetConfig(tag, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LguiUtil;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[ComponentConfig.GetElementIconTag]查找配置数据失败，数据为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("标签", tag);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config.Value.ConfigParam;
	}

	// Token: 0x0600B40E RID: 46094 RVA: 0x0028A9A8 File Offset: 0x00288BA8
	[return: Nullable(2)]
	public string GetMonsterConfigParam(string tag)
	{
		MonsterIconTag? config = ConfigMonsterIconTagById.GetConfig(tag, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LguiUtil;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[ComponentConfig.GetMonsterConfigParam]查找配置数据失败，数据为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("标签", tag);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config.Value.ConfigParam;
	}

	// Token: 0x0600B40F RID: 46095 RVA: 0x0028AA04 File Offset: 0x00288C04
	[return: Nullable(2)]
	public string GetDungeonEntranceConfigParam(string tag)
	{
		EntranceIconTag? config = ConfigEntranceIconTagById.GetConfig(tag, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LguiUtil;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[ComponentConfig.GetDungeonConfigParam]查找配置数据失败，数据为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("标签", tag);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config.Value.ConfigParam;
	}

	// Token: 0x17000F1F RID: 3871
	// (get) Token: 0x0600B410 RID: 46096 RVA: 0x0028AA5D File Offset: 0x00288C5D
	public static ComponentConfig Instance
	{
		get
		{
			return ComponentConfig._Instance;
		}
	}

	// Token: 0x0600B411 RID: 46097 RVA: 0x0028AA64 File Offset: 0x00288C64
	public static ComponentConfig GetOrCreateInstance()
	{
		if (ComponentConfig._Instance == null)
		{
			ComponentConfig.CreateInstance();
		}
		return ComponentConfig._Instance;
	}

	// Token: 0x0600B412 RID: 46098 RVA: 0x0028AA78 File Offset: 0x00288C78
	public static bool CreateInstance()
	{
		if (ComponentConfig._Instance != null)
		{
			return true;
		}
		ComponentConfig._Instance = new ComponentConfig();
		return true;
	}

	// Token: 0x0600B413 RID: 46099 RVA: 0x0028AA8E File Offset: 0x00288C8E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B414 RID: 46100 RVA: 0x0028AA90 File Offset: 0x00288C90
	public static void ResetStaticDefaultValue()
	{
		ComponentConfig._Instance = null;
	}

	// Token: 0x0600B415 RID: 46101 RVA: 0x0028AA98 File Offset: 0x00288C98
	static ComponentConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ComponentConfig.CreateStaticDefaultValue), new Action(ComponentConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005166 RID: 20838
	[Nullable(2)]
	private static ComponentConfig _Instance;
}
