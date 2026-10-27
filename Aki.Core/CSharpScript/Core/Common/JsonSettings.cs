using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace CSharpScript.Core.Common
{
	// Token: 0x0200016D RID: 365
	[NullableContext(2)]
	[Nullable(0)]
	public class JsonSettings : IStaticVariableResetter
	{
		// Token: 0x06000C96 RID: 3222 RVA: 0x0003B048 File Offset: 0x00039248
		static JsonSettings()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(JsonSettings.CreateStaticDefaultValue), new Action(JsonSettings.ResetStaticDefaultValue));
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x0003B068 File Offset: 0x00039268
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

		// Token: 0x06000C98 RID: 3224 RVA: 0x0003B0F4 File Offset: 0x000392F4
		public static void ResetStaticDefaultValue()
		{
			JsonSettings.EncodeOptions = null;
			JsonSettings.DecodeOptions = null;
			JsonSettings.GameJsonTypeInfoResolver = null;
			JsonSettings.TestJsonTypeInfoResolver = null;
		}

		// Token: 0x0400073F RID: 1855
		public static JsonSerializerOptions EncodeOptions;

		// Token: 0x04000740 RID: 1856
		public static JsonSerializerOptions DecodeOptions;

		// Token: 0x04000741 RID: 1857
		public static IJsonTypeInfoResolver GameJsonTypeInfoResolver;

		// Token: 0x04000742 RID: 1858
		public static IJsonTypeInfoResolver TestJsonTypeInfoResolver;
	}
}
