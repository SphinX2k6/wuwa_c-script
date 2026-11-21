using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace CSharpScript.Utils
{
	// Token: 0x0200342B RID: 13355
	public class FormulaParamsCacheManager : IStaticVariableResetter
	{
		// Token: 0x06021EB2 RID: 138930 RVA: 0x0096FC2A File Offset: 0x0096DE2A
		static FormulaParamsCacheManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FormulaParamsCacheManager.CreateStaticDefaultValue), new Action(FormulaParamsCacheManager.ResetStaticDefaultValue));
		}

		// Token: 0x06021EB3 RID: 138931 RVA: 0x0096FC49 File Offset: 0x0096DE49
		public static void CreateStaticDefaultValue()
		{
			FormulaParamsCacheManager.Cache = new Dictionary<string, FormulaParamsCacheManager.CachedParamsEntry>();
		}

		// Token: 0x06021EB4 RID: 138932 RVA: 0x0096FC55 File Offset: 0x0096DE55
		public static void ResetStaticDefaultValue()
		{
			FormulaParamsCacheManager.Cache = null;
		}

		// Token: 0x06021EB5 RID: 138933 RVA: 0x0096FC60 File Offset: 0x0096DE60
		[NullableContext(1)]
		public static Dictionary<string, TFormulaValue> Acquire(string paramsRaw)
		{
			FormulaParamsCacheManager.CachedParamsEntry cachedParamsEntry;
			if (FormulaParamsCacheManager.Cache.TryGetValue(paramsRaw, out cachedParamsEntry))
			{
				cachedParamsEntry.RefCount++;
				return cachedParamsEntry.Params;
			}
			Dictionary<string, TFormulaValue> result;
			using (JsonDocument jsonDocument = JsonDocument.Parse(paramsRaw, default(JsonDocumentOptions)))
			{
				if (jsonDocument.RootElement.ValueKind != JsonValueKind.Object)
				{
					throw new Exception("Formula default params must be a JSON object");
				}
				Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
				foreach (JsonProperty jsonProperty in jsonDocument.RootElement.EnumerateObject())
				{
					dictionary[jsonProperty.Name] = Formula.FromJsonElement(jsonProperty.Value);
				}
				FormulaParamsCacheManager.Cache[paramsRaw] = new FormulaParamsCacheManager.CachedParamsEntry
				{
					Params = dictionary,
					RefCount = 1
				};
				result = dictionary;
			}
			return result;
		}

		// Token: 0x06021EB6 RID: 138934 RVA: 0x0096FD68 File Offset: 0x0096DF68
		[NullableContext(1)]
		public static void Release(string paramsRaw)
		{
			FormulaParamsCacheManager.CachedParamsEntry cachedParamsEntry;
			if (!FormulaParamsCacheManager.Cache.TryGetValue(paramsRaw, out cachedParamsEntry))
			{
				return;
			}
			cachedParamsEntry.RefCount--;
			if (cachedParamsEntry.RefCount <= 0)
			{
				FormulaParamsCacheManager.Cache.Remove(paramsRaw);
			}
		}

		// Token: 0x04012B35 RID: 76597
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<string, FormulaParamsCacheManager.CachedParamsEntry> Cache;

		// Token: 0x020090FE RID: 37118
		private class CachedParamsEntry
		{
			// Token: 0x0402CFE0 RID: 184288
			[Nullable(1)]
			public Dictionary<string, TFormulaValue> Params = new Dictionary<string, TFormulaValue>();

			// Token: 0x0402CFE1 RID: 184289
			public int RefCount;
		}
	}
}
