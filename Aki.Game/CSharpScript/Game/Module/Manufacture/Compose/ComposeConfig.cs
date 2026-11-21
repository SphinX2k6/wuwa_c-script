using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Manufacture.Compose
{
	// Token: 0x0200462A RID: 17962
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class ComposeConfig : ConfigBase
	{
		// Token: 0x0602D222 RID: 184866 RVA: 0x00C9F3EF File Offset: 0x00C9D5EF
		[NullableContext(1)]
		public string GetLocalText(string id)
		{
			return ConfigMultiTextLang.GetLocalTextNew(id, null) ?? "";
		}

		// Token: 0x0602D223 RID: 184867 RVA: 0x00C9F404 File Offset: 0x00C9D604
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

		// Token: 0x0602D224 RID: 184868 RVA: 0x00C9F452 File Offset: 0x00C9D652
		public SynthesisFormula? GetSynthesisFormulaByItemId(int itemId)
		{
			return ConfigSynthesisFormulaByItemId.GetConfig(itemId, true);
		}

		// Token: 0x0602D225 RID: 184869 RVA: 0x00C9F45C File Offset: 0x00C9D65C
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

		// Token: 0x0602D226 RID: 184870 RVA: 0x00C9F4AC File Offset: 0x00C9D6AC
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

		// Token: 0x0602D227 RID: 184871 RVA: 0x00C9F4F4 File Offset: 0x00C9D6F4
		public IReadOnlyList<MaterialReplace> GetExchangeList()
		{
			IReadOnlyList<MaterialReplace> configList = ConfigMaterialReplaceAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.Compose, ELogAuthor.LJQ, "获取置换数据列表失败，请检查合成表是否正确", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return configList;
		}

		// Token: 0x0602D228 RID: 184872 RVA: 0x00C9F528 File Offset: 0x00C9D728
		public IReadOnlyList<SynthesisLevel> GetComposeLevel()
		{
			IReadOnlyList<SynthesisLevel> configList = ConfigSynthesisLevelAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.Compose, ELogAuthor.LK, "获取制药证书相关配置失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return configList;
		}

		// Token: 0x0602D229 RID: 184873 RVA: 0x00C9F55D File Offset: 0x00C9D75D
		public ConditionGroup? GetConditionInfo(int upConditionId)
		{
			return ConfigConditionGroupById.GetConfig(upConditionId, true);
		}

		// Token: 0x0602D22A RID: 184874 RVA: 0x00C9F566 File Offset: 0x00C9D766
		public IReadOnlyList<MaterialReplace> GetExchangeByGroupId(int groupId)
		{
			return ConfigMaterialReplaceByGroupId.GetConfigList(groupId, true);
		}

		// Token: 0x0602D22B RID: 184875 RVA: 0x00C9F56F File Offset: 0x00C9D76F
		public ExchangeParam? GetExchangeParamById(int id)
		{
			return ConfigExchangeParamById.GetConfig(id, true);
		}

		// Token: 0x0602D22C RID: 184876 RVA: 0x00C9F578 File Offset: 0x00C9D778
		public ExchangeType? GetExchangeTypeById(int id)
		{
			return ConfigExchangeTypeById.GetConfig(id, true);
		}

		// Token: 0x0602D22D RID: 184877 RVA: 0x00C9F581 File Offset: 0x00C9D781
		public IReadOnlyList<ExchangeType> GetExchangeTypeList()
		{
			return ConfigExchangeTypeAll.GetConfigList(true);
		}

		// Token: 0x17005B06 RID: 23302
		// (get) Token: 0x0602D22E RID: 184878 RVA: 0x00C9F589 File Offset: 0x00C9D789
		[Nullable(1)]
		public static ComposeConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return ComposeConfig._Instance;
			}
		}

		// Token: 0x0602D22F RID: 184879 RVA: 0x00C9F590 File Offset: 0x00C9D790
		[NullableContext(1)]
		public static ComposeConfig GetOrCreateInstance()
		{
			if (ComposeConfig._Instance == null)
			{
				ComposeConfig.CreateInstance();
			}
			return ComposeConfig._Instance;
		}

		// Token: 0x0602D230 RID: 184880 RVA: 0x00C9F5A4 File Offset: 0x00C9D7A4
		public static bool CreateInstance()
		{
			if (ComposeConfig._Instance != null)
			{
				return true;
			}
			ComposeConfig._Instance = new ComposeConfig();
			return true;
		}

		// Token: 0x0602D231 RID: 184881 RVA: 0x00C9F5BA File Offset: 0x00C9D7BA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D232 RID: 184882 RVA: 0x00C9F5BC File Offset: 0x00C9D7BC
		public static void ResetStaticDefaultValue()
		{
			ComposeConfig._Instance = null;
		}

		// Token: 0x0602D233 RID: 184883 RVA: 0x00C9F5C4 File Offset: 0x00C9D7C4
		static ComposeConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ComposeConfig.CreateStaticDefaultValue), new Action(ComposeConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04018379 RID: 99193
		private static ComposeConfig _Instance;
	}
}
