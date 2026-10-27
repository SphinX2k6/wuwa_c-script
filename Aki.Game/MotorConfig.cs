using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002247 RID: 8775
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MotorConfig : ConfigBase
{
	// Token: 0x060111DD RID: 70109 RVA: 0x0042D344 File Offset: 0x0042B544
	public IReadOnlyList<MotorLvl> GetAllMotorLevelList()
	{
		IReadOnlyList<MotorLvl> configList = ConfigMotorLvlAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Motor, ELogAuthor.LZK, "MotorLevel表无效All", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<MotorLvl>();
		}
		return configList;
	}

	// Token: 0x060111DE RID: 70110 RVA: 0x0042D384 File Offset: 0x0042B584
	public MotorLvl? GetMotorLevelConfig(int level)
	{
		MotorLvl? config = ConfigMotorLvlByLevel.GetConfig(level, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Motor;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "MotorLevel表无效Level";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("level", level);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060111DF RID: 70111 RVA: 0x0042D3DC File Offset: 0x0042B5DC
	public IReadOnlyList<MotorLevelHint> GetAllMotorLevelHintList()
	{
		IReadOnlyList<MotorLevelHint> configList = ConfigMotorLevelHintAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Motor, ELogAuthor.LZK, "MotorLevelHint表无效All", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<MotorLevelHint>();
		}
		return configList;
	}

	// Token: 0x060111E0 RID: 70112 RVA: 0x0042D41C File Offset: 0x0042B61C
	public MotorTechTree? GetMotorTechTreeConfig(int treeType)
	{
		MotorTechTree? config = ConfigMotorTechTreeById.GetConfig(treeType, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Motor;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "MotorTechTree表无效TreeType";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("treeType", treeType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060111E1 RID: 70113 RVA: 0x0042D474 File Offset: 0x0042B674
	public int[] GetAllMotorTreeIds()
	{
		List<int> list = new List<int>();
		IReadOnlyList<MotorTechTree> configList = ConfigMotorTechTreeAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Motor, ELogAuthor.LZK, "MotorTechTree表无效All", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new int[0];
		}
		foreach (MotorTechTree motorTechTree in configList)
		{
			list.Add(motorTechTree.Id);
		}
		return list.ToArray();
	}

	// Token: 0x060111E2 RID: 70114 RVA: 0x0042D500 File Offset: 0x0042B700
	public IReadOnlyList<MotorTech> GetMotorTechConfigList(int treeType)
	{
		IReadOnlyList<MotorTech> configList = ConfigMotorTechByTreeType.GetConfigList(treeType, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Motor;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "MotorTech表无效TreeType";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("treeType", treeType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<MotorTech>();
		}
		return configList;
	}

	// Token: 0x060111E3 RID: 70115 RVA: 0x0042D550 File Offset: 0x0042B750
	public MotorTech? GetMotorTechConfig(int id)
	{
		MotorTech? config = ConfigMotorTechById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Motor;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "MotorTech表无效Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060111E4 RID: 70116 RVA: 0x0042D5A8 File Offset: 0x0042B7A8
	public MotorTechTag? GetMotorTechTagConfig(int tagId)
	{
		MotorTechTag? config = ConfigMotorTechTagById.GetConfig(tagId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Motor;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "MotorTechTag表无效Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tagId", tagId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060111E5 RID: 70117 RVA: 0x0042D600 File Offset: 0x0042B800
	public MotorTechLv? GetMotorTechLvConfig(int id)
	{
		MotorTechLv? config = ConfigMotorTechLvById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Motor;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "MotorTechLv表无效Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060111E6 RID: 70118 RVA: 0x0042D658 File Offset: 0x0042B858
	public MotorEffect? GetMotorEffectConfig(int id)
	{
		MotorEffect? config = ConfigMotorEffectById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Motor;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "MotorEffect表无效Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060111E7 RID: 70119 RVA: 0x0042D6B0 File Offset: 0x0042B8B0
	public MotorTask? GetMotorTaskConfig(int taskId)
	{
		MotorTask? config = ConfigMotorTaskById.GetConfig(taskId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Motor;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "MotorTask表无效Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("taskId", taskId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060111E8 RID: 70120 RVA: 0x0042D708 File Offset: 0x0042B908
	public IReadOnlyList<MotorTask> GetMotorTaskConfigList(int treeType)
	{
		IReadOnlyList<MotorTask> configList = ConfigMotorTaskByTreeType.GetConfigList(treeType, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Motor;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "MotorTask表无效TreeType";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("treeType", treeType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<MotorTask>();
		}
		return configList;
	}

	// Token: 0x060111E9 RID: 70121 RVA: 0x0042D758 File Offset: 0x0042B958
	public MotorAttr? GetMotorAttrConfig(int attrId)
	{
		MotorAttr? config = ConfigMotorAttrById.GetConfig(attrId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Motor;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "MotorAttr表无效Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", attrId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060111EA RID: 70122 RVA: 0x0042D7B0 File Offset: 0x0042B9B0
	public IReadOnlyList<MotorAttr> GetAllMotorAttrList()
	{
		IReadOnlyList<MotorAttr> configList = ConfigMotorAttrAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Motor, ELogAuthor.LZK, "MotorAttr表无效All", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<MotorAttr>();
		}
		return configList;
	}

	// Token: 0x060111EB RID: 70123 RVA: 0x0042D7F0 File Offset: 0x0042B9F0
	public TrialMotor? GetTrialMotorConfig(int id)
	{
		TrialMotor? config = ConfigTrialMotorById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Motor;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "TrialMotor表无效Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x170015AE RID: 5550
	// (get) Token: 0x060111EC RID: 70124 RVA: 0x0042D848 File Offset: 0x0042BA48
	public static MotorConfig Instance
	{
		get
		{
			return MotorConfig._Instance;
		}
	}

	// Token: 0x060111ED RID: 70125 RVA: 0x0042D84F File Offset: 0x0042BA4F
	public static MotorConfig GetOrCreateInstance()
	{
		if (MotorConfig._Instance == null)
		{
			MotorConfig.CreateInstance();
		}
		return MotorConfig._Instance;
	}

	// Token: 0x060111EE RID: 70126 RVA: 0x0042D863 File Offset: 0x0042BA63
	public static bool CreateInstance()
	{
		if (MotorConfig._Instance != null)
		{
			return true;
		}
		MotorConfig._Instance = new MotorConfig();
		return true;
	}

	// Token: 0x060111EF RID: 70127 RVA: 0x0042D879 File Offset: 0x0042BA79
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060111F0 RID: 70128 RVA: 0x0042D87B File Offset: 0x0042BA7B
	public static void ResetStaticDefaultValue()
	{
		MotorConfig._Instance = null;
	}

	// Token: 0x060111F1 RID: 70129 RVA: 0x0042D883 File Offset: 0x0042BA83
	static MotorConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorConfig.CreateStaticDefaultValue), new Action(MotorConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04008256 RID: 33366
	[Nullable(2)]
	private static MotorConfig _Instance;
}
