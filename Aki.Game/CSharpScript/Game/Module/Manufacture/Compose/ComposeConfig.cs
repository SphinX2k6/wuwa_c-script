using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Manufacture.Compose
{
	// Token: 0x02005654 RID: 22100
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class ComposeConfig : ConfigBase
	{
		// Token: 0x06038324 RID: 230180 RVA: 0x00D5159F File Offset: 0x00D4F79F
		[NullableContext(1)]
		public string GetLocalText(string id)
		{
			return ConfigMultiTextLang.GetLocalTextNew(id, null) ?? "";
		}

		// Token: 0x06038325 RID: 230181 RVA: 0x00D515B4 File Offset: 0x00D4F7B4
		public SynthesisFormula? GetSynthesisFormulaByFormulaItemId(int id)
		{
			SynthesisFormula? config = ConfigSynthesisFormulaByFormulaItemId.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Compose;
				ELogAuthor author = ELogAuthor.LK;
				string message = "合成配方获取失败，请检查合成配方配置表是否正确";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("FormulaItemId", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06038326 RID: 230182 RVA: 0x00D51602 File Offset: 0x00D4F802
		public SynthesisFormula? GetSynthesisFormulaByItemId(int itemId)
		{
			return ConfigSynthesisFormulaByItemId.GetConfig(itemId, true);
		}

		// Token: 0x06038327 RID: 230183 RVA: 0x00D5160C File Offset: 0x00D4F80C
		public SynthesisFormula? GetSynthesisFormulaById(int id)
		{
			SynthesisFormula? config = ConfigSynthesisFormulaById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Compose;
				ELogAuthor author = ELogAuthor.LK;
				string message = "合成配方获取失败，请检查合成配方配置表是否正确";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06038328 RID: 230184 RVA: 0x00D5165C File Offset: 0x00D4F85C
		public IReadOnlyList<SynthesisFormula> GetComposeListByType(int type)
		{
			IReadOnlyList<SynthesisFormula> configList = ConfigSynthesisFormulaByFormulaType.GetConfigList(type, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Compose;
				ELogAuthor author = ELogAuthor.LK;
				string message = "获取对应类型合成数据失败，请检查合成配方配置表是否正确";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("FormulaType", type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return configList;
		}

		// Token: 0x06038329 RID: 230185 RVA: 0x00D516A4 File Offset: 0x00D4F8A4
		public IReadOnlyList<MaterialReplace> GetExchangeList()
		{
			IReadOnlyList<MaterialReplace> configList = ConfigMaterialReplaceAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.Compose, ELogAuthor.LJQ, "获取置换数据列表失败，请检查合成表是否正确", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return configList;
		}

		// Token: 0x0603832A RID: 230186 RVA: 0x00D516D8 File Offset: 0x00D4F8D8
		public IReadOnlyList<SynthesisLevel> GetComposeLevel()
		{
			IReadOnlyList<SynthesisLevel> configList = ConfigSynthesisLevelAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.Compose, ELogAuthor.LK, "获取制药证书相关配置失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return configList;
		}

		// Token: 0x0603832B RID: 230187 RVA: 0x00D5170D File Offset: 0x00D4F90D
		public ConditionGroup? GetConditionInfo(int upConditionId)
		{
			return ConfigConditionGroupById.GetConfig(upConditionId, true);
		}

		// Token: 0x0603832C RID: 230188 RVA: 0x00D51716 File Offset: 0x00D4F916
		public IReadOnlyList<MaterialReplace> GetExchangeByGroupId(int groupId)
		{
			return ConfigMaterialReplaceByGroupId.GetConfigList(groupId, true);
		}

		// Token: 0x0603832D RID: 230189 RVA: 0x00D5171F File Offset: 0x00D4F91F
		public ExchangeParam? GetExchangeParamById(int id)
		{
			return ConfigExchangeParamById.GetConfig(id, true);
		}

		// Token: 0x0603832E RID: 230190 RVA: 0x00D51728 File Offset: 0x00D4F928
		public ExchangeType? GetExchangeTypeById(int id)
		{
			return ConfigExchangeTypeById.GetConfig(id, true);
		}

		// Token: 0x0603832F RID: 230191 RVA: 0x00D51731 File Offset: 0x00D4F931
		public IReadOnlyList<ExchangeType> GetExchangeTypeList()
		{
			return ConfigExchangeTypeAll.GetConfigList(true);
		}

		// Token: 0x1700873F RID: 34623
		// (get) Token: 0x06038330 RID: 230192 RVA: 0x00D51739 File Offset: 0x00D4F939
		[Nullable(1)]
		public static ComposeConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return ComposeConfig._Instance;
			}
		}

		// Token: 0x06038331 RID: 230193 RVA: 0x00D51740 File Offset: 0x00D4F940
		[NullableContext(1)]
		public static ComposeConfig GetOrCreateInstance()
		{
			if (ComposeConfig._Instance == null)
			{
				ComposeConfig.CreateInstance();
			}
			return ComposeConfig._Instance;
		}

		// Token: 0x06038332 RID: 230194 RVA: 0x00D51754 File Offset: 0x00D4F954
		public static bool CreateInstance()
		{
			if (ComposeConfig._Instance != null)
			{
				return true;
			}
			ComposeConfig._Instance = new ComposeConfig();
			return true;
		}

		// Token: 0x06038333 RID: 230195 RVA: 0x00D5176A File Offset: 0x00D4F96A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06038334 RID: 230196 RVA: 0x00D5176C File Offset: 0x00D4F96C
		public static void ResetStaticDefaultValue()
		{
			ComposeConfig._Instance = null;
		}

		// Token: 0x06038335 RID: 230197 RVA: 0x00D51774 File Offset: 0x00D4F974
		static ComposeConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ComposeConfig.CreateStaticDefaultValue), new Action(ComposeConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401D8EE RID: 121070
		private static ComposeConfig _Instance;
	}
}
