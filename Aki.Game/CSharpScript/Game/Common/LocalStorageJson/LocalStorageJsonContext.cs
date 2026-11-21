using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.LocalStorageJson.Generated;

namespace CSharpScript.Game.Common.LocalStorageJson
{
	// Token: 0x0200640B RID: 25611
	[NullableContext(1)]
	[Nullable(0)]
	public class LocalStorageJsonContext : IStaticVariableResetter
	{
		// Token: 0x0603E19B RID: 254363 RVA: 0x01204747 File Offset: 0x01202947
		static LocalStorageJsonContext()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LocalStorageJsonContext.CreateStaticDefaultValue), new Action(LocalStorageJsonContext.ResetStaticDefaultValue));
		}

		// Token: 0x0603E19C RID: 254364 RVA: 0x01204768 File Offset: 0x01202968
		public static LocalStorageJsonContext.Scope EnterScope(ELocalStorageGlobalKey key)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Global:");
			defaultInterpolatedStringHandler.AppendFormatted<ELocalStorageGlobalKey>(key);
			return new LocalStorageJsonContext.Scope(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x0603E19D RID: 254365 RVA: 0x012047A0 File Offset: 0x012029A0
		public static LocalStorageJsonContext.Scope EnterScope(ELocalStoragePlayerKey key)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Player:");
			defaultInterpolatedStringHandler.AppendFormatted<ELocalStoragePlayerKey>(key);
			return new LocalStorageJsonContext.Scope(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x0603E19E RID: 254366 RVA: 0x012047D8 File Offset: 0x012029D8
		public static LocalStorageJsonContext.Scope EnterScope(ELocalStorageDeviceKey key)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Device:");
			defaultInterpolatedStringHandler.AppendFormatted<ELocalStorageDeviceKey>(key);
			return new LocalStorageJsonContext.Scope(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x0603E19F RID: 254367 RVA: 0x0120480E File Offset: 0x01202A0E
		public static string GetCurrentProcessKey()
		{
			return LocalStorageJsonContext.CurrentProcessKey ?? "Unknown";
		}

		// Token: 0x0603E1A0 RID: 254368 RVA: 0x0120481E File Offset: 0x01202A1E
		public static JsonSerializerOptions GetSerializerOptions<[Nullable(2)] T>()
		{
			return LocalStorageJsonContext.OptionsCache.GetOrAdd(typeof(T), (Type _) => LocalStorageJsonContext.BuildSerializerOptions<T>());
		}

		// Token: 0x0603E1A1 RID: 254369 RVA: 0x01204853 File Offset: 0x01202A53
		private static JsonSerializerOptions BuildSerializerOptions<[Nullable(2)] T>()
		{
			return new JsonSerializerOptions
			{
				IncludeFields = true,
				DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
				TypeInfoResolver = LocalStorageJsonContext.CreateTypeInfoResolver(),
				Converters = 
				{
					new LocalStorageJsonConverter<T>()
				}
			};
		}

		// Token: 0x0603E1A2 RID: 254370 RVA: 0x01204883 File Offset: 0x01202A83
		public static JsonSerializerOptions GetNestedSerializerOptions(Type valueType)
		{
			return LocalStorageJsonContext.NestedJsonOptions;
		}

		// Token: 0x0603E1A3 RID: 254371 RVA: 0x0120488A File Offset: 0x01202A8A
		[NullableContext(2)]
		[return: Nullable(1)]
		public static ArrayToKvpConverter<TKey, TValue> GetArrayToKvpConverter<TKey, TValue>()
		{
			return new ArrayToKvpConverter<TKey, TValue>();
		}

		// Token: 0x0603E1A4 RID: 254372 RVA: 0x01204891 File Offset: 0x01202A91
		public static HashSetJsonConverter<T> GetHashSetJsonConverter<[Nullable(2)] T>()
		{
			return new HashSetJsonConverter<T>();
		}

		// Token: 0x0603E1A5 RID: 254373 RVA: 0x01204898 File Offset: 0x01202A98
		public static JsonTypeInfo GetTypeInfo(Type type)
		{
			return LocalStorageJsonContext.InternalJsonOptions.GetTypeInfo(type);
		}

		// Token: 0x0603E1A6 RID: 254374 RVA: 0x012048A5 File Offset: 0x01202AA5
		public static Type UnwrapNullable(Type type)
		{
			return Nullable.GetUnderlyingType(type) ?? type;
		}

		// Token: 0x0603E1A7 RID: 254375 RVA: 0x012048B4 File Offset: 0x01202AB4
		public static bool IsScalarType(Type type)
		{
			type = LocalStorageJsonContext.UnwrapNullable(type);
			return type.IsPrimitive || (type == typeof(string) || type == typeof(decimal) || type == typeof(BigInteger) || type == typeof(DateTime) || type == typeof(DateTimeOffset) || type == typeof(Guid) || type == typeof(TimeSpan)) || type.IsEnum;
		}

		// Token: 0x0603E1A8 RID: 254376 RVA: 0x0120495C File Offset: 0x01202B5C
		public static bool IsDictionaryType(Type type)
		{
			type = LocalStorageJsonContext.UnwrapNullable(type);
			if (!type.IsGenericType)
			{
				return false;
			}
			Type genericTypeDefinition = type.GetGenericTypeDefinition();
			return genericTypeDefinition == typeof(Dictionary<, >) || genericTypeDefinition == typeof(IDictionary<, >) || genericTypeDefinition == typeof(SortedDictionary<, >) || genericTypeDefinition == typeof(ConcurrentDictionary<, >);
		}

		// Token: 0x0603E1A9 RID: 254377 RVA: 0x012049CC File Offset: 0x01202BCC
		public static bool IsSetType(Type type)
		{
			type = LocalStorageJsonContext.UnwrapNullable(type);
			if (!type.IsGenericType)
			{
				return false;
			}
			Type genericTypeDefinition = type.GetGenericTypeDefinition();
			return genericTypeDefinition == typeof(HashSet<>) || genericTypeDefinition == typeof(SortedSet<>);
		}

		// Token: 0x0603E1AA RID: 254378 RVA: 0x01204A18 File Offset: 0x01202C18
		public static void CreateStaticDefaultValue()
		{
			LocalStorageJsonContext.GeneratedTypeInfoResolver = LocalStorageJsonSourceGenContext.Default;
			LocalStorageJsonContext.InternalJsonOptions = new JsonSerializerOptions
			{
				IncludeFields = true,
				DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
				TypeInfoResolver = LocalStorageJsonContext.CreateTypeInfoResolver()
			};
			LocalStorageJsonContext.OptionsCache = new ConcurrentDictionary<Type, JsonSerializerOptions>();
			LocalStorageJsonContext.NestedJsonOptions = new JsonSerializerOptions
			{
				IncludeFields = true,
				DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
				TypeInfoResolver = LocalStorageJsonContext.CreateTypeInfoResolver()
			};
			LocalStorageJsonContext.NestedJsonOptions.Converters.Add(new LocalStorageJsonConverterFactory());
		}

		// Token: 0x0603E1AB RID: 254379 RVA: 0x01204A93 File Offset: 0x01202C93
		public static void ResetStaticDefaultValue()
		{
			LocalStorageJsonContext.InternalJsonOptions = null;
			LocalStorageJsonContext.OptionsCache = null;
			LocalStorageJsonContext.NestedJsonOptions = null;
			LocalStorageJsonContext.CurrentProcessKey = null;
		}

		// Token: 0x0603E1AC RID: 254380 RVA: 0x01204AB0 File Offset: 0x01202CB0
		private unsafe static IJsonTypeInfoResolver CreateTypeInfoResolver()
		{
			DefaultJsonTypeInfoResolver defaultJsonTypeInfoResolver = new DefaultJsonTypeInfoResolver();
			if (LocalStorageJsonContext.GeneratedTypeInfoResolver == null)
			{
				return defaultJsonTypeInfoResolver;
			}
			<>y__InlineArray2<IJsonTypeInfoResolver> <>y__InlineArray = default(<>y__InlineArray2<IJsonTypeInfoResolver>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<IJsonTypeInfoResolver>, IJsonTypeInfoResolver>(ref <>y__InlineArray, 0) = LocalStorageJsonContext.GeneratedTypeInfoResolver;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<IJsonTypeInfoResolver>, IJsonTypeInfoResolver>(ref <>y__InlineArray, 1) = defaultJsonTypeInfoResolver;
			return JsonTypeInfoResolver.Combine(<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<IJsonTypeInfoResolver>, IJsonTypeInfoResolver>(<>y__InlineArray, 2));
		}

		// Token: 0x0402113F RID: 135487
		[Nullable(2)]
		public static string CurrentProcessKey;

		// Token: 0x04021140 RID: 135488
		[Nullable(2)]
		public static JsonSerializerOptions InternalJsonOptions;

		// Token: 0x04021141 RID: 135489
		[Nullable(2)]
		[StaticVariableRuleIgnore]
		public static IJsonTypeInfoResolver GeneratedTypeInfoResolver;

		// Token: 0x04021142 RID: 135490
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static ConcurrentDictionary<Type, JsonSerializerOptions> OptionsCache;

		// Token: 0x04021143 RID: 135491
		[Nullable(2)]
		public static JsonSerializerOptions NestedJsonOptions;

		// Token: 0x0200BB7C RID: 47996
		[Nullable(0)]
		public static class ESpecialValue
		{
			// Token: 0x04039A51 RID: 236113
			public const string Undefined = "___undefined___";

			// Token: 0x04039A52 RID: 236114
			public const string NaN = "___NaN___";

			// Token: 0x04039A53 RID: 236115
			public const string Infinity = "___Infinity___";

			// Token: 0x04039A54 RID: 236116
			public const string InfinityNegative = "___-Infinity___";

			// Token: 0x04039A55 RID: 236117
			public const string BigInt = "___BI___";

			// Token: 0x04039A56 RID: 236118
			public const string BooleanTrue = "___1B___";

			// Token: 0x04039A57 RID: 236119
			public const string BooleanFalse = "___0B___";
		}

		// Token: 0x0200BB7D RID: 47997
		[Nullable(0)]
		public static class EMetaType
		{
			// Token: 0x04039A58 RID: 236120
			public const string Map = "___Map___";

			// Token: 0x04039A59 RID: 236121
			public const string Set = "___Set___";
		}

		// Token: 0x0200BB7E RID: 47998
		[NullableContext(2)]
		[Nullable(0)]
		public class MetaJson
		{
			// Token: 0x17007A82 RID: 31362
			// (get) Token: 0x06048976 RID: 297334 RVA: 0x01621D55 File Offset: 0x0161FF55
			// (set) Token: 0x06048977 RID: 297335 RVA: 0x01621D5D File Offset: 0x0161FF5D
			[JsonPropertyName("___MetaType___")]
			public string MetaType { get; set; }

			// Token: 0x17007A83 RID: 31363
			// (get) Token: 0x06048978 RID: 297336 RVA: 0x01621D66 File Offset: 0x0161FF66
			// (set) Token: 0x06048979 RID: 297337 RVA: 0x01621D6E File Offset: 0x0161FF6E
			[JsonPropertyName("Content")]
			public JsonElement Content { get; set; }
		}

		// Token: 0x0200BB7F RID: 47999
		[NullableContext(0)]
		public readonly struct Scope : IDisposable
		{
			// Token: 0x0604897B RID: 297339 RVA: 0x01621D7F File Offset: 0x0161FF7F
			[NullableContext(1)]
			internal Scope(string key)
			{
				this.PreviousKey = LocalStorageJsonContext.CurrentProcessKey;
				LocalStorageJsonContext.CurrentProcessKey = key;
			}

			// Token: 0x0604897C RID: 297340 RVA: 0x01621D92 File Offset: 0x0161FF92
			public void Dispose()
			{
				LocalStorageJsonContext.CurrentProcessKey = this.PreviousKey;
			}

			// Token: 0x04039A5C RID: 236124
			[Nullable(2)]
			private readonly string PreviousKey;
		}
	}
}
