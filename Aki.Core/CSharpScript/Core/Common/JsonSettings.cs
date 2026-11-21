using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace CSharpScript.Core.Common
{
	// Token: 0x02000172 RID: 370
	[NullableContext(2)]
	[Nullable(0)]
	public class JsonSettings : IStaticVariableResetter
	{
		// Token: 0x06000CF1 RID: 3313 RVA: 0x0003BD0C File Offset: 0x00039F0C
		static JsonSettings()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(JsonSettings.CreateStaticDefaultValue), new Action(JsonSettings.ResetStaticDefaultValue));
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0003BD2C File Offset: 0x00039F2C
		public static void CreateStaticDefaultValue()
		{
			List<IJsonTypeInfoResolver> list = new List<IJsonTypeInfoResolver>();
			if (JsonSettings.GameJsonTypeInfoResolver != null)
			{
				list.Add(JsonSettings.GameJsonTypeInfoResolver);
			}
			if (JsonSettings.TestJsonTypeInfoResolver != null)
			{
				list.Add(JsonSettings.TestJsonTypeInfoResolver);
			}
			list.Add(new DefaultJsonTypeInfoResolver());
			IJsonTypeInfoResolver typeInfoResolver = JsonTypeInfoResolver.Combine(list.ToArray());
			JsonSettings.EncodeOptions = new JsonSerializerOptions
			{
				IncludeFields = true,
				DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
				TypeInfoResolver = typeInfoResolver
			};
			JsonSettings.DecodeOptions = new JsonSerializerOptions
			{
				IncludeFields = true,
				DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
				TypeInfoResolver = typeInfoResolver
			};
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0003BDB8 File Offset: 0x00039FB8
		public static void ResetStaticDefaultValue()
		{
			JsonSettings.EncodeOptions = null;
			JsonSettings.DecodeOptions = null;
			JsonSettings.GameJsonTypeInfoResolver = null;
			JsonSettings.TestJsonTypeInfoResolver = null;
		}

		// Token: 0x0400074E RID: 1870
		public static JsonSerializerOptions EncodeOptions;

		// Token: 0x0400074F RID: 1871
		public static JsonSerializerOptions DecodeOptions;

		// Token: 0x04000750 RID: 1872
		public static IJsonTypeInfoResolver GameJsonTypeInfoResolver;

		// Token: 0x04000751 RID: 1873
		public static IJsonTypeInfoResolver TestJsonTypeInfoResolver;
	}
}
