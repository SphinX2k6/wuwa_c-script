using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000CB8 RID: 3256
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ComponentConfig : ConfigBase
{
	// Token: 0x060087F4 RID: 34804 RVA: 0x00294EFC File Offset: 0x002930FC
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

	// Token: 0x060087F5 RID: 34805 RVA: 0x00294F58 File Offset: 0x00293158
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

	// Token: 0x060087F6 RID: 34806 RVA: 0x00294FB4 File Offset: 0x002931B4
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

	// Token: 0x060087F7 RID: 34807 RVA: 0x00295010 File Offset: 0x00293210
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

	// Token: 0x060087F8 RID: 34808 RVA: 0x0029506C File Offset: 0x0029326C
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

	// Token: 0x060087F9 RID: 34809 RVA: 0x002950C8 File Offset: 0x002932C8
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

	// Token: 0x060087FA RID: 34810 RVA: 0x00295124 File Offset: 0x00293324
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

	// Token: 0x17000F42 RID: 3906
	// (get) Token: 0x060087FB RID: 34811 RVA: 0x0029517D File Offset: 0x0029337D
	public static ComponentConfig Instance
	{
		get
		{
			return ComponentConfig._Instance;
		}
	}

	// Token: 0x060087FC RID: 34812 RVA: 0x00295184 File Offset: 0x00293384
	public static ComponentConfig GetOrCreateInstance()
	{
		if (ComponentConfig._Instance == null)
		{
			ComponentConfig.CreateInstance();
		}
		return ComponentConfig._Instance;
	}

	// Token: 0x060087FD RID: 34813 RVA: 0x00295198 File Offset: 0x00293398
	public static bool CreateInstance()
	{
		if (ComponentConfig._Instance != null)
		{
			return true;
		}
		ComponentConfig._Instance = new ComponentConfig();
		return true;
	}

	// Token: 0x060087FE RID: 34814 RVA: 0x002951AE File Offset: 0x002933AE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060087FF RID: 34815 RVA: 0x002951B0 File Offset: 0x002933B0
	public static void ResetStaticDefaultValue()
	{
		ComponentConfig._Instance = null;
	}

	// Token: 0x06008800 RID: 34816 RVA: 0x002951B8 File Offset: 0x002933B8
	static ComponentConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ComponentConfig.CreateStaticDefaultValue), new Action(ComponentConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005211 RID: 21009
	[Nullable(2)]
	private static ComponentConfig _Instance;
}
