using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace CSharpScript.Utils
{
	// Token: 0x02004509 RID: 17673
	public class FormulaParamsCacheManager : IStaticVariableResetter
	{
		// Token: 0x0602D7E2 RID: 186338 RVA: 0x00A43E1A File Offset: 0x00A4201A
		static FormulaParamsCacheManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FormulaParamsCacheManager.CreateStaticDefaultValue), new Action(FormulaParamsCacheManager.ResetStaticDefaultValue));
		}

		// Token: 0x0602D7E3 RID: 186339 RVA: 0x00A43E39 File Offset: 0x00A42039
		public static void CreateStaticDefaultValue()
		{
			FormulaParamsCacheManager.Cache = new Dictionary<string, FormulaParamsCacheManager.CachedParamsEntry>();
		}

		// Token: 0x0602D7E4 RID: 186340 RVA: 0x00A43E45 File Offset: 0x00A42045
		public static void ResetStaticDefaultValue()
		{
			FormulaParamsCacheManager.Cache = null;
		}

		// Token: 0x0602D7E5 RID: 186341 RVA: 0x00A43E50 File Offset: 0x00A42050
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

		// Token: 0x0602D7E6 RID: 186342 RVA: 0x00A43F58 File Offset: 0x00A42158
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

		// Token: 0x0401850D RID: 99597
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<string, FormulaParamsCacheManager.CachedParamsEntry> Cache;

		// Token: 0x0200A746 RID: 42822
		private class CachedParamsEntry
		{
			// Token: 0x0403283A RID: 206906
			[Nullable(1)]
			public Dictionary<string, TFormulaValue> Params = new Dictionary<string, TFormulaValue>();

			// Token: 0x0403283B RID: 206907
			public int RefCount;
		}
	}
}
