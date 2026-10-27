using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Manufacture.Forging
{
	// Token: 0x02005642 RID: 22082
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ForgingConfig : ConfigBase
	{
		// Token: 0x06038244 RID: 229956 RVA: 0x00D4C616 File Offset: 0x00D4A816
		public string GetLocalText(string id)
		{
			return ConfigMultiTextLang.GetLocalTextNew(id, null) ?? "";
		}

		// Token: 0x06038245 RID: 229957 RVA: 0x00D4C628 File Offset: 0x00D4A828
		public ForgeFormula? GetForgeFormulaByFormulaItemId(int id)
		{
			ForgeFormula? config = ConfigForgeFormulaByFormulaItemId.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Forging;
				ELogAuthor author = ELogAuthor.LK;
				string message = "锻造配方获取失败，请检查锻造配方配置表是否正确";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("FormulaItemId=", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06038246 RID: 229958 RVA: 0x00D4C678 File Offset: 0x00D4A878
		public ForgeFormula? GetForgeFormulaById(int id)
		{
			ForgeFormula? config = ConfigForgeFormulaById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Forging;
				ELogAuthor author = ELogAuthor.LK;
				string message = "锻造配方获取失败，请检查锻造配方配置表是否正确";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id=", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06038247 RID: 229959 RVA: 0x00D4C6C8 File Offset: 0x00D4A8C8
		[NullableContext(2)]
		public IReadOnlyList<ForgeFormula> GetForgeList()
		{
			IReadOnlyList<ForgeFormula> configList = ConfigForgeFormulaAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.Forging, ELogAuthor.LK, "获取对应类型锻造数据列表失败，请检查锻造配方配置表是否正确", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return configList;
		}

		// Token: 0x06038248 RID: 229960 RVA: 0x00D4C700 File Offset: 0x00D4A900
		[NullableContext(2)]
		public IReadOnlyList<ForgeFormula> GetForgeListByType(int type)
		{
			IReadOnlyList<ForgeFormula> configList = ConfigForgeFormulaByTypeId.GetConfigList(type, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Forging;
				ELogAuthor author = ELogAuthor.LK;
				string message = "获取对应类型锻造数据失败，请检查锻造配方配置表是否正确";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TypeId=", type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return configList;
		}

		// Token: 0x17008739 RID: 34617
		// (get) Token: 0x06038249 RID: 229961 RVA: 0x00D4C746 File Offset: 0x00D4A946
		public static ForgingConfig Instance
		{
			get
			{
				return ForgingConfig._Instance;
			}
		}

		// Token: 0x0603824A RID: 229962 RVA: 0x00D4C74D File Offset: 0x00D4A94D
		public static ForgingConfig GetOrCreateInstance()
		{
			if (ForgingConfig._Instance == null)
			{
				ForgingConfig.CreateInstance();
			}
			return ForgingConfig._Instance;
		}

		// Token: 0x0603824B RID: 229963 RVA: 0x00D4C761 File Offset: 0x00D4A961
		public static bool CreateInstance()
		{
			if (ForgingConfig._Instance != null)
			{
				return true;
			}
			ForgingConfig._Instance = new ForgingConfig();
			return true;
		}

		// Token: 0x0603824C RID: 229964 RVA: 0x00D4C777 File Offset: 0x00D4A977
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603824D RID: 229965 RVA: 0x00D4C779 File Offset: 0x00D4A979
		public static void ResetStaticDefaultValue()
		{
			ForgingConfig._Instance = null;
		}

		// Token: 0x0603824E RID: 229966 RVA: 0x00D4C781 File Offset: 0x00D4A981
		static ForgingConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ForgingConfig.CreateStaticDefaultValue), new Action(ForgingConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401D889 RID: 120969
		[Nullable(2)]
		private static ForgingConfig _Instance;
	}
}
