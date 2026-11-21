using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using CSharpScript.Launcher.Util.Json.Generated;

namespace CSharpScript.Launcher.Util.Json
{
	// Token: 0x02000083 RID: 131
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherJsonSettings : IStaticVariableResetter
	{
		// Token: 0x06000371 RID: 881 RVA: 0x00013190 File Offset: 0x00011390
		static LauncherJsonSettings()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherJsonSettings.CreateStaticDefaultValue), new Action(LauncherJsonSettings.ResetStaticDefaultValue));
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000131B0 File Offset: 0x000113B0
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

		// Token: 0x06000373 RID: 883 RVA: 0x00013220 File Offset: 0x00011420
		public static void ResetStaticDefaultValue()
		{
			LauncherJsonSettings.JsonOptions = null;
			LauncherJsonSettings.SharedTypeInfoResolver = null;
			LauncherJsonSettings.SerializerTypeInfoResolver = null;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00013234 File Offset: 0x00011434
		public static JsonSerializerOptions GetSerializerOptions<[Nullable(2)] T>()
		{
			return LauncherJsonSettings.CreateSerializerOptions<T>();
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0001323B File Offset: 0x0001143B
		private static JsonSerializerOptions CreateSerializerOptions<[Nullable(2)] T>()
		{
			JsonSerializerOptions jsonSerializerOptions = LauncherJsonSettings.CreateOptions(JsonIgnoreCondition.WhenWritingNull);
			jsonSerializerOptions.Converters.Add(new LauncherJsonConverter<T>());
			return jsonSerializerOptions;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00013253 File Offset: 0x00011453
		public static JsonSerializerOptions CreateOptions(JsonIgnoreCondition defaultIgnoreCondition)
		{
			return new JsonSerializerOptions
			{
				IncludeFields = true,
				DefaultIgnoreCondition = defaultIgnoreCondition,
				TypeInfoResolver = LauncherJsonSettings.SerializerTypeInfoResolver
			};
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00013273 File Offset: 0x00011473
		public static JsonSerializerOptions CreateOptionsLike(JsonSerializerOptions options)
		{
			return new JsonSerializerOptions
			{
				IncludeFields = options.IncludeFields,
				DefaultIgnoreCondition = options.DefaultIgnoreCondition,
				TypeInfoResolver = options.TypeInfoResolver
			};
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000132A0 File Offset: 0x000114A0
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

		// Token: 0x06000379 RID: 889 RVA: 0x000133DC File Offset: 0x000115DC
		public static bool IsGenericDictionary(Type type)
		{
			if (type.IsGenericType)
			{
				Type genericTypeDefinition = type.GetGenericTypeDefinition();
				if (genericTypeDefinition == typeof(Dictionary<, >) || genericTypeDefinition == typeof(IDictionary<, >) || genericTypeDefinition == typeof(IReadOnlyDictionary<, >))
				{
					return true;
				}
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

		// Token: 0x0600037A RID: 890 RVA: 0x0001346C File Offset: 0x0001166C
		public static bool IsGenericHashSet(Type type)
		{
			if (type.IsGenericType)
			{
				Type genericTypeDefinition = type.GetGenericTypeDefinition();
				if (genericTypeDefinition == typeof(HashSet<>) || genericTypeDefinition == typeof(ISet<>))
				{
					return true;
				}
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

		// Token: 0x0400027D RID: 637
		[Nullable(2)]
		public static JsonSerializerOptions JsonOptions;

		// Token: 0x0400027E RID: 638
		[Nullable(2)]
		private static IJsonTypeInfoResolver SharedTypeInfoResolver;

		// Token: 0x0400027F RID: 639
		[Nullable(2)]
		private static IJsonTypeInfoResolver SerializerTypeInfoResolver;

		// Token: 0x020002D8 RID: 728
		[Nullable(0)]
		public static class ESpecialValue
		{
			// Token: 0x04000B7D RID: 2941
			public const string Undefined = "___undefined___";

			// Token: 0x04000B7E RID: 2942
			public const string NaN = "___NaN___";

			// Token: 0x04000B7F RID: 2943
			public const string Infinity = "___Infinity___";

			// Token: 0x04000B80 RID: 2944
			public const string InfinityNegative = "___-Infinity___";

			// Token: 0x04000B81 RID: 2945
			public const string BigInt = "___BI___";

			// Token: 0x04000B82 RID: 2946
			public const string Long = "__kr_long__";

			// Token: 0x04000B83 RID: 2947
			public const string BooleanTrue = "___1B___";

			// Token: 0x04000B84 RID: 2948
			public const string BooleanFalse = "___0B___";

			// Token: 0x04000B85 RID: 2949
			public const string Map = "__kr_map__";
		}

		// Token: 0x020002D9 RID: 729
		[Nullable(0)]
		public static class EMetaType
		{
			// Token: 0x04000B86 RID: 2950
			public const string Map = "___Map___";

			// Token: 0x04000B87 RID: 2951
			public const string Set = "___Set___";
		}

		// Token: 0x020002DA RID: 730
		[Nullable(0)]
		public static class EMetaPropertyName
		{
			// Token: 0x04000B88 RID: 2952
			public const string MetaType = "___MetaType___";

			// Token: 0x04000B89 RID: 2953
			public const string Content = "Content";
		}

		// Token: 0x020002DB RID: 731
		[NullableContext(2)]
		[Nullable(0)]
		public class MetaJson
		{
			// Token: 0x1700017D RID: 381
			// (get) Token: 0x06001012 RID: 4114 RVA: 0x000618B6 File Offset: 0x0005FAB6
			// (set) Token: 0x06001013 RID: 4115 RVA: 0x000618BE File Offset: 0x0005FABE
			[JsonPropertyName("___MetaType___")]
			public string MetaType { get; set; }

			// Token: 0x1700017E RID: 382
			// (get) Token: 0x06001014 RID: 4116 RVA: 0x000618C7 File Offset: 0x0005FAC7
			// (set) Token: 0x06001015 RID: 4117 RVA: 0x000618CF File Offset: 0x0005FACF
			[JsonPropertyName("Content")]
			public object Content { get; set; }
		}
	}
}
