using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Manufacture.Forging
{
	// Token: 0x02004618 RID: 17944
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ForgingConfig : ConfigBase
	{
		// Token: 0x0602D142 RID: 184642 RVA: 0x00C9A35E File Offset: 0x00C9855E
		public string GetLocalText(string id)
		{
			return ConfigMultiTextLang.GetLocalTextNew(id, null) ?? "";
		}

		// Token: 0x0602D143 RID: 184643 RVA: 0x00C9A370 File Offset: 0x00C98570
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

		// Token: 0x0602D144 RID: 184644 RVA: 0x00C9A3C0 File Offset: 0x00C985C0
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

		// Token: 0x0602D145 RID: 184645 RVA: 0x00C9A410 File Offset: 0x00C98610
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

		// Token: 0x0602D146 RID: 184646 RVA: 0x00C9A448 File Offset: 0x00C98648
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

		// Token: 0x17005B00 RID: 23296
		// (get) Token: 0x0602D147 RID: 184647 RVA: 0x00C9A48E File Offset: 0x00C9868E
		public static ForgingConfig Instance
		{
			get
			{
				return ForgingConfig._Instance;
			}
		}

		// Token: 0x0602D148 RID: 184648 RVA: 0x00C9A495 File Offset: 0x00C98695
		public static ForgingConfig GetOrCreateInstance()
		{
			if (ForgingConfig._Instance == null)
			{
				ForgingConfig.CreateInstance();
			}
			return ForgingConfig._Instance;
		}

		// Token: 0x0602D149 RID: 184649 RVA: 0x00C9A4A9 File Offset: 0x00C986A9
		public static bool CreateInstance()
		{
			if (ForgingConfig._Instance != null)
			{
				return true;
			}
			ForgingConfig._Instance = new ForgingConfig();
			return true;
		}

		// Token: 0x0602D14A RID: 184650 RVA: 0x00C9A4BF File Offset: 0x00C986BF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D14B RID: 184651 RVA: 0x00C9A4C1 File Offset: 0x00C986C1
		public static void ResetStaticDefaultValue()
		{
			ForgingConfig._Instance = null;
		}

		// Token: 0x0602D14C RID: 184652 RVA: 0x00C9A4C9 File Offset: 0x00C986C9
		static ForgingConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ForgingConfig.CreateStaticDefaultValue), new Action(ForgingConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04018314 RID: 99092
		[Nullable(2)]
		private static ForgingConfig _Instance;
	}
}
