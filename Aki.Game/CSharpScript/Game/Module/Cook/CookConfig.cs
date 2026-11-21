using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004AD0 RID: 19152
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class CookConfig : ConfigBase
	{
		// Token: 0x0602FE48 RID: 196168 RVA: 0x00D5D587 File Offset: 0x00D5B787
		public string GetLocalText(string id)
		{
			return ConfigMultiTextLang.GetLocalTextNew(id, null) ?? "";
		}

		// Token: 0x0602FE49 RID: 196169 RVA: 0x00D5D59C File Offset: 0x00D5B79C
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

		// Token: 0x0602FE4A RID: 196170 RVA: 0x00D5D5F0 File Offset: 0x00D5B7F0
		[NullableContext(2)]
		public IReadOnlyList<CookFormula> GetCookFormula()
		{
			return ConfigCookFormulaAll.GetConfigList(true);
		}

		// Token: 0x0602FE4B RID: 196171 RVA: 0x00D5D5F8 File Offset: 0x00D5B7F8
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

		// Token: 0x0602FE4C RID: 196172 RVA: 0x00D5D64C File Offset: 0x00D5B84C
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

		// Token: 0x0602FE4D RID: 196173 RVA: 0x00D5D6A0 File Offset: 0x00D5B8A0
		public IReadOnlyList<CookProcessed> GetCookProcessed()
		{
			IReadOnlyList<CookProcessed> configList = ConfigCookProcessedAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.Cook, ELogAuthor.LK, "食材加工列表获取失败，请检查食材加工配置表是否正确", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return configList;
		}

		// Token: 0x0602FE4E RID: 196174 RVA: 0x00D5D6D8 File Offset: 0x00D5B8D8
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

		// Token: 0x0602FE4F RID: 196175 RVA: 0x00D5D72C File Offset: 0x00D5B92C
		public IReadOnlyList<CookLevel> GetCookLevel()
		{
			IReadOnlyList<CookLevel> configList = ConfigCookLevelAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.Cook, ELogAuthor.LK, "获取厨师证书相关配置失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return configList;
		}

		// Token: 0x0602FE50 RID: 196176 RVA: 0x00D5D764 File Offset: 0x00D5B964
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

		// Token: 0x0602FE51 RID: 196177 RVA: 0x00D5D7B8 File Offset: 0x00D5B9B8
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

		// Token: 0x1700600F RID: 24591
		// (get) Token: 0x0602FE52 RID: 196178 RVA: 0x00D5D80C File Offset: 0x00D5BA0C
		public static CookConfig Instance
		{
			get
			{
				return CookConfig._Instance;
			}
		}

		// Token: 0x0602FE53 RID: 196179 RVA: 0x00D5D813 File Offset: 0x00D5BA13
		public static CookConfig GetOrCreateInstance()
		{
			if (CookConfig._Instance == null)
			{
				CookConfig.CreateInstance();
			}
			return CookConfig._Instance;
		}

		// Token: 0x0602FE54 RID: 196180 RVA: 0x00D5D827 File Offset: 0x00D5BA27
		public static bool CreateInstance()
		{
			if (CookConfig._Instance != null)
			{
				return true;
			}
			CookConfig._Instance = new CookConfig();
			return true;
		}

		// Token: 0x0602FE55 RID: 196181 RVA: 0x00D5D83D File Offset: 0x00D5BA3D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602FE56 RID: 196182 RVA: 0x00D5D83F File Offset: 0x00D5BA3F
		public static void ResetStaticDefaultValue()
		{
			CookConfig._Instance = null;
		}

		// Token: 0x0602FE57 RID: 196183 RVA: 0x00D5D847 File Offset: 0x00D5BA47
		static CookConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CookConfig.CreateStaticDefaultValue), new Action(CookConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040196E1 RID: 104161
		[Nullable(2)]
		private static CookConfig _Instance;
	}
}
