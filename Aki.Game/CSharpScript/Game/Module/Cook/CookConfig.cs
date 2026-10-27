using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005AEF RID: 23279
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class CookConfig : ConfigBase
	{
		// Token: 0x0603AED6 RID: 241366 RVA: 0x00E0C8C3 File Offset: 0x00E0AAC3
		public string GetLocalText(string id)
		{
			return ConfigMultiTextLang.GetLocalTextNew(id, null) ?? "";
		}

		// Token: 0x0603AED7 RID: 241367 RVA: 0x00E0C8D8 File Offset: 0x00E0AAD8
		public CookFormula GetCookFormulaByFormulaItemId(int id)
		{
			CookFormula? config = ConfigCookFormulaByFormulaItemId.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Cook;
				ELogAuthor author = ELogAuthor.LK;
				string message = "烹饪配方获取失败，请检查烹饪配方配置表是否正确";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("FormulaItemId=", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config.Value;
		}

		// Token: 0x0603AED8 RID: 241368 RVA: 0x00E0C92C File Offset: 0x00E0AB2C
		[NullableContext(2)]
		public IReadOnlyList<CookFormula> GetCookFormula()
		{
			return ConfigCookFormulaAll.GetConfigList(true);
		}

		// Token: 0x0603AED9 RID: 241369 RVA: 0x00E0C934 File Offset: 0x00E0AB34
		public CookFormula GetCookFormulaById(int id)
		{
			CookFormula? config = ConfigCookFormulaById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Cook;
				ELogAuthor author = ELogAuthor.LK;
				string message = "烹饪配方获取失败，请检查烹饪配方配置表是否正确";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id=", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config.Value;
		}

		// Token: 0x0603AEDA RID: 241370 RVA: 0x00E0C988 File Offset: 0x00E0AB88
		public CookProcessed GetCookProcessedById(int id)
		{
			CookProcessed? config = ConfigCookProcessedById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Cook;
				ELogAuthor author = ELogAuthor.LK;
				string message = "食材加工获取失败，请检查食材加工配置表是否正确";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id=", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config.Value;
		}

		// Token: 0x0603AEDB RID: 241371 RVA: 0x00E0C9DC File Offset: 0x00E0ABDC
		public IReadOnlyList<CookProcessed> GetCookProcessed()
		{
			IReadOnlyList<CookProcessed> configList = ConfigCookProcessedAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.Cook, ELogAuthor.LK, "食材加工列表获取失败，请检查食材加工配置表是否正确", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return configList;
		}

		// Token: 0x0603AEDC RID: 241372 RVA: 0x00E0CA14 File Offset: 0x00E0AC14
		public CookProcessMsg GetCookProcessMsgById(int id)
		{
			CookProcessMsg? config = ConfigCookProcessMsgById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Cook;
				ELogAuthor author = ELogAuthor.LK;
				string message = "食材加工获取失败，请检查食材加工配置表是否正确";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id=", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config.Value;
		}

		// Token: 0x0603AEDD RID: 241373 RVA: 0x00E0CA68 File Offset: 0x00E0AC68
		public IReadOnlyList<CookLevel> GetCookLevel()
		{
			IReadOnlyList<CookLevel> configList = ConfigCookLevelAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.Cook, ELogAuthor.LK, "获取厨师证书相关配置失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return configList;
		}

		// Token: 0x0603AEDE RID: 241374 RVA: 0x00E0CAA0 File Offset: 0x00E0ACA0
		public CookLevel GetCookLevelByLevel(int level)
		{
			CookLevel? config = ConfigCookLevelById.GetConfig(level, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Cook;
				ELogAuthor author = ELogAuthor.LK;
				string message = "获取目标等级厨师证书相关配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id=", level);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config.Value;
		}

		// Token: 0x0603AEDF RID: 241375 RVA: 0x00E0CAF4 File Offset: 0x00E0ACF4
		public CookFixTool GetCookFixToolById(int id)
		{
			CookFixTool? config = ConfigCookFixToolById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Cook;
				ELogAuthor author = ELogAuthor.LK;
				string message = "食材修理工具获取失败，请检查食材修理工具配置表是否正确";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id=", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config.Value;
		}

		// Token: 0x17008C35 RID: 35893
		// (get) Token: 0x0603AEE0 RID: 241376 RVA: 0x00E0CB48 File Offset: 0x00E0AD48
		public static CookConfig Instance
		{
			get
			{
				return CookConfig._Instance;
			}
		}

		// Token: 0x0603AEE1 RID: 241377 RVA: 0x00E0CB4F File Offset: 0x00E0AD4F
		public static CookConfig GetOrCreateInstance()
		{
			if (CookConfig._Instance == null)
			{
				CookConfig.CreateInstance();
			}
			return CookConfig._Instance;
		}

		// Token: 0x0603AEE2 RID: 241378 RVA: 0x00E0CB63 File Offset: 0x00E0AD63
		public static bool CreateInstance()
		{
			if (CookConfig._Instance != null)
			{
				return true;
			}
			CookConfig._Instance = new CookConfig();
			return true;
		}

		// Token: 0x0603AEE3 RID: 241379 RVA: 0x00E0CB79 File Offset: 0x00E0AD79
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603AEE4 RID: 241380 RVA: 0x00E0CB7B File Offset: 0x00E0AD7B
		public static void ResetStaticDefaultValue()
		{
			CookConfig._Instance = null;
		}

		// Token: 0x0603AEE5 RID: 241381 RVA: 0x00E0CB83 File Offset: 0x00E0AD83
		static CookConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CookConfig.CreateStaticDefaultValue), new Action(CookConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401EC25 RID: 125989
		[Nullable(2)]
		private static CookConfig _Instance;
	}
}
