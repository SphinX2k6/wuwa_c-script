using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;

// Token: 0x02001526 RID: 5414
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class LevelPlayReportConfig : ConfigBase
{
	// Token: 0x0600D895 RID: 55445 RVA: 0x004035B4 File Offset: 0x004017B4
	protected override bool OnInit()
	{
		foreach (LevelPlayInfoMappingConfig levelPlayInfoMappingConfig in ConfigLevelPlayInfoMappingConfigAll.GetConfigList(true))
		{
			LevelPlayReportDefine.LevelPlayReportConfigData levelPlayReportConfigData = Json.Decode<LevelPlayReportDefine.LevelPlayReportConfigData>(levelPlayInfoMappingConfig.Data, null);
			if (!this.LevelPlayReportConfigMapping.ContainsKey(levelPlayReportConfigData.LevelPlayId))
			{
				if (levelPlayReportConfigData.Vars.Length > 1)
				{
					int num = levelPlayReportConfigData.Vars.Length - 1;
					string getBoxNumKey = levelPlayReportConfigData.Vars[num];
					levelPlayReportConfigData.GetBoxNumKey = getBoxNumKey;
					string[] array = new string[num];
					Array.Copy(levelPlayReportConfigData.Vars, 0, array, 0, num);
					levelPlayReportConfigData.Vars = array;
				}
				this.LevelPlayReportConfigMapping.Add(levelPlayReportConfigData.LevelPlayId, levelPlayReportConfigData);
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlayReport;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "玩法信息映射设置失败,重复玩法Id,请联系策划检查";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LevelPlayId", levelPlayReportConfigData.LevelPlayId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
		return true;
	}

	// Token: 0x0600D896 RID: 55446 RVA: 0x004036B8 File Offset: 0x004018B8
	[NullableContext(2)]
	public LevelPlayReportDefine.ILevelPlayReportConfigData GetLevelPlayReportConfig(int levelPlayReportId)
	{
		LevelPlayReportDefine.ILevelPlayReportConfigData result;
		if (this.LevelPlayReportConfigMapping.TryGetValue(levelPlayReportId, out result))
		{
			return result;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.LevelPlayReport;
		ELogAuthor author = ELogAuthor.LRX;
		string message = "获取玩法信息映设配置失败,请联系策划检查";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LevelPlayId", levelPlayReportId);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0600D897 RID: 55447 RVA: 0x00403708 File Offset: 0x00401908
	public HiddenBossWindow? GetHiddenBossWindowConfig(int id)
	{
		HiddenBossWindow? config = ConfigHiddenBossWindowById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelPlayReport;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "找不到隐藏Boss窗口配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("界面Id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HiddenBossWindow?(config.Value);
	}

	// Token: 0x17001422 RID: 5154
	// (get) Token: 0x0600D898 RID: 55448 RVA: 0x0040376B File Offset: 0x0040196B
	public static LevelPlayReportConfig Instance
	{
		get
		{
			return LevelPlayReportConfig._Instance;
		}
	}

	// Token: 0x0600D899 RID: 55449 RVA: 0x00403772 File Offset: 0x00401972
	public static LevelPlayReportConfig GetOrCreateInstance()
	{
		if (LevelPlayReportConfig._Instance == null)
		{
			LevelPlayReportConfig.CreateInstance();
		}
		return LevelPlayReportConfig._Instance;
	}

	// Token: 0x0600D89A RID: 55450 RVA: 0x00403786 File Offset: 0x00401986
	public static bool CreateInstance()
	{
		if (LevelPlayReportConfig._Instance != null)
		{
			return true;
		}
		LevelPlayReportConfig._Instance = new LevelPlayReportConfig();
		return true;
	}

	// Token: 0x0600D89B RID: 55451 RVA: 0x0040379C File Offset: 0x0040199C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D89C RID: 55452 RVA: 0x0040379E File Offset: 0x0040199E
	public static void ResetStaticDefaultValue()
	{
		LevelPlayReportConfig._Instance = null;
	}

	// Token: 0x0600D89D RID: 55453 RVA: 0x004037A6 File Offset: 0x004019A6
	static LevelPlayReportConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelPlayReportConfig.CreateStaticDefaultValue), new Action(LevelPlayReportConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04007929 RID: 31017
	private readonly Dictionary<int, LevelPlayReportDefine.ILevelPlayReportConfigData> LevelPlayReportConfigMapping = new Dictionary<int, LevelPlayReportDefine.ILevelPlayReportConfigData>();

	// Token: 0x0400792A RID: 31018
	[Nullable(2)]
	private static LevelPlayReportConfig _Instance;
}
