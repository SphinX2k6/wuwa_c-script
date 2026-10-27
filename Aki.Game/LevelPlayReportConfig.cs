using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;

// Token: 0x02002053 RID: 8275
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class LevelPlayReportConfig : ConfigBase
{
	// Token: 0x0601042E RID: 66606 RVA: 0x003F70BC File Offset: 0x003F52BC
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

	// Token: 0x0601042F RID: 66607 RVA: 0x003F71C0 File Offset: 0x003F53C0
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

	// Token: 0x06010430 RID: 66608 RVA: 0x003F7210 File Offset: 0x003F5410
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

	// Token: 0x170013F5 RID: 5109
	// (get) Token: 0x06010431 RID: 66609 RVA: 0x003F7273 File Offset: 0x003F5473
	public static LevelPlayReportConfig Instance
	{
		get
		{
			return LevelPlayReportConfig._Instance;
		}
	}

	// Token: 0x06010432 RID: 66610 RVA: 0x003F727A File Offset: 0x003F547A
	public static LevelPlayReportConfig GetOrCreateInstance()
	{
		if (LevelPlayReportConfig._Instance == null)
		{
			LevelPlayReportConfig.CreateInstance();
		}
		return LevelPlayReportConfig._Instance;
	}

	// Token: 0x06010433 RID: 66611 RVA: 0x003F728E File Offset: 0x003F548E
	public static bool CreateInstance()
	{
		if (LevelPlayReportConfig._Instance != null)
		{
			return true;
		}
		LevelPlayReportConfig._Instance = new LevelPlayReportConfig();
		return true;
	}

	// Token: 0x06010434 RID: 66612 RVA: 0x003F72A4 File Offset: 0x003F54A4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010435 RID: 66613 RVA: 0x003F72A6 File Offset: 0x003F54A6
	public static void ResetStaticDefaultValue()
	{
		LevelPlayReportConfig._Instance = null;
	}

	// Token: 0x06010436 RID: 66614 RVA: 0x003F72AE File Offset: 0x003F54AE
	static LevelPlayReportConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelPlayReportConfig.CreateStaticDefaultValue), new Action(LevelPlayReportConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04007840 RID: 30784
	private readonly Dictionary<int, LevelPlayReportDefine.ILevelPlayReportConfigData> LevelPlayReportConfigMapping = new Dictionary<int, LevelPlayReportDefine.ILevelPlayReportConfigData>();

	// Token: 0x04007841 RID: 30785
	[Nullable(2)]
	private static LevelPlayReportConfig _Instance;
}
