using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200172B RID: 5931
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MotorConfig : ConfigBase
{
	// Token: 0x0600E673 RID: 58995 RVA: 0x00439EE8 File Offset: 0x004380E8
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

	// Token: 0x0600E674 RID: 58996 RVA: 0x00439F28 File Offset: 0x00438128
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

	// Token: 0x0600E675 RID: 58997 RVA: 0x00439F80 File Offset: 0x00438180
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

	// Token: 0x0600E676 RID: 58998 RVA: 0x00439FC0 File Offset: 0x004381C0
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

	// Token: 0x0600E677 RID: 58999 RVA: 0x0043A018 File Offset: 0x00438218
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

	// Token: 0x0600E678 RID: 59000 RVA: 0x0043A0A4 File Offset: 0x004382A4
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

	// Token: 0x0600E679 RID: 59001 RVA: 0x0043A0F4 File Offset: 0x004382F4
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

	// Token: 0x0600E67A RID: 59002 RVA: 0x0043A14C File Offset: 0x0043834C
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

	// Token: 0x0600E67B RID: 59003 RVA: 0x0043A1A4 File Offset: 0x004383A4
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

	// Token: 0x0600E67C RID: 59004 RVA: 0x0043A1FC File Offset: 0x004383FC
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

	// Token: 0x0600E67D RID: 59005 RVA: 0x0043A254 File Offset: 0x00438454
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

	// Token: 0x0600E67E RID: 59006 RVA: 0x0043A2AC File Offset: 0x004384AC
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

	// Token: 0x0600E67F RID: 59007 RVA: 0x0043A2FC File Offset: 0x004384FC
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

	// Token: 0x0600E680 RID: 59008 RVA: 0x0043A354 File Offset: 0x00438554
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

	// Token: 0x0600E681 RID: 59009 RVA: 0x0043A394 File Offset: 0x00438594
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

	// Token: 0x170015E5 RID: 5605
	// (get) Token: 0x0600E682 RID: 59010 RVA: 0x0043A3EC File Offset: 0x004385EC
	public static MotorConfig Instance
	{
		get
		{
			return MotorConfig._Instance;
		}
	}

	// Token: 0x0600E683 RID: 59011 RVA: 0x0043A3F3 File Offset: 0x004385F3
	public static MotorConfig GetOrCreateInstance()
	{
		if (MotorConfig._Instance == null)
		{
			MotorConfig.CreateInstance();
		}
		return MotorConfig._Instance;
	}

	// Token: 0x0600E684 RID: 59012 RVA: 0x0043A407 File Offset: 0x00438607
	public static bool CreateInstance()
	{
		if (MotorConfig._Instance != null)
		{
			return true;
		}
		MotorConfig._Instance = new MotorConfig();
		return true;
	}

	// Token: 0x0600E685 RID: 59013 RVA: 0x0043A41D File Offset: 0x0043861D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E686 RID: 59014 RVA: 0x0043A41F File Offset: 0x0043861F
	public static void ResetStaticDefaultValue()
	{
		MotorConfig._Instance = null;
	}

	// Token: 0x0600E687 RID: 59015 RVA: 0x0043A427 File Offset: 0x00438627
	static MotorConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorConfig.CreateStaticDefaultValue), new Action(MotorConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04008394 RID: 33684
	[Nullable(2)]
	private static MotorConfig _Instance;
}
