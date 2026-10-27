using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using CSharpScript.Launcher.Util.Json.Generated;

namespace CSharpScript.Launcher.Util.Json
{
	// Token: 0x02000080 RID: 128
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherJsonSettings : IStaticVariableResetter
	{
		// Token: 0x06000361 RID: 865 RVA: 0x0001230C File Offset: 0x0001050C
		static LauncherJsonSettings()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherJsonSettings.CreateStaticDefaultValue), new Action(LauncherJsonSettings.ResetStaticDefaultValue));
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0001232C File Offset: 0x0001052C
		public unsafe static void CreateStaticDefaultValue()
		{
			LauncherJsonSettings.SharedTypeInfoResolver = new DefaultJsonTypeInfoResolver();
			<>y__InlineArray2<IJsonTypeInfoResolver> <>y__InlineArray = default(<>y__InlineArray2<IJsonTypeInfoResolver>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<IJsonTypeInfoResolver>, IJsonTypeInfoResolver>(ref <>y__InlineArray, 0) = LauncherJsonSourceGenContext.Default;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<IJsonTypeInfoResolver>, IJsonTypeInfoResolver>(ref <>y__InlineArray, 1) = LauncherJsonSettings.SharedTypeInfoResolver;
			LauncherJsonSettings.SerializerTypeInfoResolver = JsonTypeInfoResolver.Combine(<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<IJsonTypeInfoResolver>, IJsonTypeInfoResolver>(<>y__InlineArray, 2));
			LauncherJsonSettings.JsonOptions = new JsonSerializerOptions
			{
				IncludeFields = true,
				DefaultIgnoreCondition = JsonIgnoreCondition.Never,
				TypeInfoResolver = LauncherJsonSettings.SharedTypeInfoResolver
			};
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0001239C File Offset: 0x0001059C
		public static void ResetStaticDefaultValue()
		{
			LauncherJsonSettings.JsonOptions = null;
			LauncherJsonSettings.SharedTypeInfoResolver = null;
			LauncherJsonSettings.SerializerTypeInfoResolver = null;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000123B0 File Offset: 0x000105B0
		public static JsonSerializerOptions GetSerializerOptions<[Nullable(2)] T>()
		{
			return LauncherJsonSettings.CreateSerializerOptions<T>();
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000123B7 File Offset: 0x000105B7
		private static JsonSerializerOptions CreateSerializerOptions<[Nullable(2)] T>()
		{
			JsonSerializerOptions jsonSerializerOptions = LauncherJsonSettings.CreateOptions(JsonIgnoreCondition.WhenWritingNull);
			jsonSerializerOptions.Converters.Add(new LauncherJsonConverter<T>());
			return jsonSerializerOptions;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000123CF File Offset: 0x000105CF
		public static JsonSerializerOptions CreateOptions(JsonIgnoreCondition defaultIgnoreCondition)
		{
			return new JsonSerializerOptions
			{
				IncludeFields = true,
				DefaultIgnoreCondition = defaultIgnoreCondition,
				TypeInfoResolver = LauncherJsonSettings.SerializerTypeInfoResolver
			};
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000123EF File Offset: 0x000105EF
		public static JsonSerializerOptions CreateOptionsLike(JsonSerializerOptions options)
		{
			return new JsonSerializerOptions
			{
				IncludeFields = options.IncludeFields,
				DefaultIgnoreCondition = options.DefaultIgnoreCondition,
				TypeInfoResolver = options.TypeInfoResolver
			};
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0001241C File Offset: 0x0001061C
		public static JsonSerializerOptions CreateOptionsWithMarkerConverters(JsonSerializerOptions options)
		{
			JsonSerializerOptions jsonSerializerOptions = LauncherJsonSettings.CreateOptionsLike(options);
			HashSet<Type> hashSet = new HashSet<Type>
			{
				typeof(LauncherJsonConverter<bool>),
				typeof(LauncherJsonConverter<long>),
				typeof(LauncherJsonConverter<float>),
				typeof(LauncherJsonConverter<double>)
			};
			foreach (JsonConverter jsonConverter in options.Converters)
			{
				jsonSerializerOptions.Converters.Add(jsonConverter);
				hashSet.Remove(jsonConverter.GetType());
			}
			if (hashSet.Contains(typeof(LauncherJsonConverter<bool>)))
			{
				jsonSerializerOptions.Converters.Add(new LauncherJsonConverter<bool>());
			}
			if (hashSet.Contains(typeof(LauncherJsonConverter<long>)))
			{
				jsonSerializerOptions.Converters.Add(new LauncherJsonConverter<long>());
			}
			if (hashSet.Contains(typeof(LauncherJsonConverter<float>)))
			{
				jsonSerializerOptions.Converters.Add(new LauncherJsonConverter<float>());
			}
			if (hashSet.Contains(typeof(LauncherJsonConverter<double>)))
			{
				jsonSerializerOptions.Converters.Add(new LauncherJsonConverter<double>());
			}
			return jsonSerializerOptions;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00012558 File Offset: 0x00010758
		public static bool IsGenericDictionary(Type type)
		{
			if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Dictionary<, >))
			{
				return true;
			}
			foreach (Type type2 in type.GetInterfaces())
			{
				if (type2.IsGenericType && type2.GetGenericTypeDefinition() == typeof(IDictionary<, >))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000125C4 File Offset: 0x000107C4
		public static bool IsGenericHashSet(Type type)
		{
			if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(HashSet<>))
			{
				return true;
			}
			foreach (Type type2 in type.GetInterfaces())
			{
				if (type2.IsGenericType && type2.GetGenericTypeDefinition() == typeof(ISet<>))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000251 RID: 593
		[Nullable(2)]
		public static JsonSerializerOptions JsonOptions;

		// Token: 0x04000252 RID: 594
		[Nullable(2)]
		private static IJsonTypeInfoResolver SharedTypeInfoResolver;

		// Token: 0x04000253 RID: 595
		[Nullable(2)]
		private static IJsonTypeInfoResolver SerializerTypeInfoResolver;

		// Token: 0x020002CD RID: 717
		[Nullable(0)]
		public static class ESpecialValue
		{
			// Token: 0x04000B29 RID: 2857
			public const string Undefined = "___undefined___";

			// Token: 0x04000B2A RID: 2858
			public const string NaN = "___NaN___";

			// Token: 0x04000B2B RID: 2859
			public const string Infinity = "___Infinity___";

			// Token: 0x04000B2C RID: 2860
			public const string InfinityNegative = "___-Infinity___";

			// Token: 0x04000B2D RID: 2861
			public const string BigInt = "___BI___";

			// Token: 0x04000B2E RID: 2862
			public const string Long = "__kr_long__";

			// Token: 0x04000B2F RID: 2863
			public const string BooleanTrue = "___1B___";

			// Token: 0x04000B30 RID: 2864
			public const string BooleanFalse = "___0B___";

			// Token: 0x04000B31 RID: 2865
			public const string Map = "__kr_map__";
		}

		// Token: 0x020002CE RID: 718
		[Nullable(0)]
		public static class EMetaType
		{
			// Token: 0x04000B32 RID: 2866
			public const string Map = "___Map___";

			// Token: 0x04000B33 RID: 2867
			public const string Set = "___Set___";
		}

		// Token: 0x020002CF RID: 719
		[Nullable(0)]
		public static class EMetaPropertyName
		{
			// Token: 0x04000B34 RID: 2868
			public const string MetaType = "___MetaType___";

			// Token: 0x04000B35 RID: 2869
			public const string Content = "Content";
		}

		// Token: 0x020002D0 RID: 720
		[NullableContext(2)]
		[Nullable(0)]
		public class MetaJson
		{
			// Token: 0x17000172 RID: 370
			// (get) Token: 0x06000FBD RID: 4029 RVA: 0x0005E6EE File Offset: 0x0005C8EE
			// (set) Token: 0x06000FBE RID: 4030 RVA: 0x0005E6F6 File Offset: 0x0005C8F6
			[JsonPropertyName("___MetaType___")]
			public string MetaType { get; set; }

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x06000FBF RID: 4031 RVA: 0x0005E6FF File Offset: 0x0005C8FF
			// (set) Token: 0x06000FC0 RID: 4032 RVA: 0x0005E707 File Offset: 0x0005C907
			[JsonPropertyName("Content")]
			public object Content { get; set; }
		}
	}
}
