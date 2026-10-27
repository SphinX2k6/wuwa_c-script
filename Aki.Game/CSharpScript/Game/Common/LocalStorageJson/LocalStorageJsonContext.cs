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
	// Token: 0x0200728C RID: 29324
	[NullableContext(1)]
	[Nullable(0)]
	public class LocalStorageJsonContext : IStaticVariableResetter
	{
		// Token: 0x06047DDB RID: 294363 RVA: 0x01263D37 File Offset: 0x01261F37
		static LocalStorageJsonContext()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LocalStorageJsonContext.CreateStaticDefaultValue), new Action(LocalStorageJsonContext.ResetStaticDefaultValue));
		}

		// Token: 0x06047DDC RID: 294364 RVA: 0x01263D58 File Offset: 0x01261F58
		public static LocalStorageJsonContext.Scope EnterScope(ELocalStorageGlobalKey key)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Global:");
			defaultInterpolatedStringHandler.AppendFormatted<ELocalStorageGlobalKey>(key);
			return new LocalStorageJsonContext.Scope(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06047DDD RID: 294365 RVA: 0x01263D90 File Offset: 0x01261F90
		public static LocalStorageJsonContext.Scope EnterScope(ELocalStoragePlayerKey key)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Player:");
			defaultInterpolatedStringHandler.AppendFormatted<ELocalStoragePlayerKey>(key);
			return new LocalStorageJsonContext.Scope(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06047DDE RID: 294366 RVA: 0x01263DC8 File Offset: 0x01261FC8
		public static LocalStorageJsonContext.Scope EnterScope(ELocalStorageDeviceKey key)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Device:");
			defaultInterpolatedStringHandler.AppendFormatted<ELocalStorageDeviceKey>(key);
			return new LocalStorageJsonContext.Scope(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06047DDF RID: 294367 RVA: 0x01263DFE File Offset: 0x01261FFE
		public static string GetCurrentProcessKey()
		{
			return LocalStorageJsonContext.CurrentProcessKey ?? "Unknown";
		}

		// Token: 0x06047DE0 RID: 294368 RVA: 0x01263E0E File Offset: 0x0126200E
		public static JsonSerializerOptions GetSerializerOptions<[Nullable(2)] T>()
		{
			return LocalStorageJsonContext.OptionsCache.GetOrAdd(typeof(T), (Type _) => LocalStorageJsonContext.BuildSerializerOptions<T>());
		}

		// Token: 0x06047DE1 RID: 294369 RVA: 0x01263E43 File Offset: 0x01262043
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

		// Token: 0x06047DE2 RID: 294370 RVA: 0x01263E73 File Offset: 0x01262073
		public static JsonSerializerOptions GetNestedSerializerOptions(Type valueType)
		{
			return LocalStorageJsonContext.NestedJsonOptions;
		}

		// Token: 0x06047DE3 RID: 294371 RVA: 0x01263E7A File Offset: 0x0126207A
		[NullableContext(2)]
		[return: Nullable(1)]
		public static ArrayToKvpConverter<TKey, TValue> GetArrayToKvpConverter<TKey, TValue>()
		{
			return new ArrayToKvpConverter<TKey, TValue>();
		}

		// Token: 0x06047DE4 RID: 294372 RVA: 0x01263E81 File Offset: 0x01262081
		public static HashSetJsonConverter<T> GetHashSetJsonConverter<[Nullable(2)] T>()
		{
			return new HashSetJsonConverter<T>();
		}

		// Token: 0x06047DE5 RID: 294373 RVA: 0x01263E88 File Offset: 0x01262088
		public static JsonTypeInfo GetTypeInfo(Type type)
		{
			return LocalStorageJsonContext.InternalJsonOptions.GetTypeInfo(type);
		}

		// Token: 0x06047DE6 RID: 294374 RVA: 0x01263E95 File Offset: 0x01262095
		public static Type UnwrapNullable(Type type)
		{
			return Nullable.GetUnderlyingType(type) ?? type;
		}

		// Token: 0x06047DE7 RID: 294375 RVA: 0x01263EA4 File Offset: 0x012620A4
		public static bool IsScalarType(Type type)
		{
			type = LocalStorageJsonContext.UnwrapNullable(type);
			return type.IsPrimitive || (type == typeof(string) || type == typeof(decimal) || type == typeof(BigInteger) || type == typeof(DateTime) || type == typeof(DateTimeOffset) || type == typeof(Guid) || type == typeof(TimeSpan)) || type.IsEnum;
		}

		// Token: 0x06047DE8 RID: 294376 RVA: 0x01263F4C File Offset: 0x0126214C
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

		// Token: 0x06047DE9 RID: 294377 RVA: 0x01263FBC File Offset: 0x012621BC
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

		// Token: 0x06047DEA RID: 294378 RVA: 0x01264008 File Offset: 0x01262208
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

		// Token: 0x06047DEB RID: 294379 RVA: 0x01264083 File Offset: 0x01262283
		public static void ResetStaticDefaultValue()
		{
			LocalStorageJsonContext.InternalJsonOptions = null;
			LocalStorageJsonContext.OptionsCache = null;
			LocalStorageJsonContext.NestedJsonOptions = null;
			LocalStorageJsonContext.CurrentProcessKey = null;
		}

		// Token: 0x06047DEC RID: 294380 RVA: 0x012640A0 File Offset: 0x012622A0
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

		// Token: 0x04025E73 RID: 155251
		[Nullable(2)]
		public static string CurrentProcessKey;

		// Token: 0x04025E74 RID: 155252
		[Nullable(2)]
		public static JsonSerializerOptions InternalJsonOptions;

		// Token: 0x04025E75 RID: 155253
		[Nullable(2)]
		[StaticVariableRuleIgnore]
		public static IJsonTypeInfoResolver GeneratedTypeInfoResolver;

		// Token: 0x04025E76 RID: 155254
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static ConcurrentDictionary<Type, JsonSerializerOptions> OptionsCache;

		// Token: 0x04025E77 RID: 155255
		[Nullable(2)]
		public static JsonSerializerOptions NestedJsonOptions;

		// Token: 0x0200CF90 RID: 53136
		[Nullable(0)]
		public static class ESpecialValue
		{
			// Token: 0x0403E625 RID: 255525
			public const string Undefined = "___undefined___";

			// Token: 0x0403E626 RID: 255526
			public const string NaN = "___NaN___";

			// Token: 0x0403E627 RID: 255527
			public const string Infinity = "___Infinity___";

			// Token: 0x0403E628 RID: 255528
			public const string InfinityNegative = "___-Infinity___";

			// Token: 0x0403E629 RID: 255529
			public const string BigInt = "___BI___";

			// Token: 0x0403E62A RID: 255530
			public const string BooleanTrue = "___1B___";

			// Token: 0x0403E62B RID: 255531
			public const string BooleanFalse = "___0B___";
		}

		// Token: 0x0200CF91 RID: 53137
		[Nullable(0)]
		public static class EMetaType
		{
			// Token: 0x0403E62C RID: 255532
			public const string Map = "___Map___";

			// Token: 0x0403E62D RID: 255533
			public const string Set = "___Set___";
		}

		// Token: 0x0200CF92 RID: 53138
		[NullableContext(2)]
		[Nullable(0)]
		public class MetaJson
		{
			// Token: 0x1700A2DC RID: 41692
			// (get) Token: 0x0605210A RID: 336138 RVA: 0x0164CFA1 File Offset: 0x0164B1A1
			// (set) Token: 0x0605210B RID: 336139 RVA: 0x0164CFA9 File Offset: 0x0164B1A9
			[JsonPropertyName("___MetaType___")]
			public string MetaType { get; set; }

			// Token: 0x1700A2DD RID: 41693
			// (get) Token: 0x0605210C RID: 336140 RVA: 0x0164CFB2 File Offset: 0x0164B1B2
			// (set) Token: 0x0605210D RID: 336141 RVA: 0x0164CFBA File Offset: 0x0164B1BA
			[JsonPropertyName("Content")]
			public JsonElement Content { get; set; }
		}

		// Token: 0x0200CF93 RID: 53139
		[NullableContext(0)]
		public readonly struct Scope : IDisposable
		{
			// Token: 0x0605210F RID: 336143 RVA: 0x0164CFCB File Offset: 0x0164B1CB
			[NullableContext(1)]
			internal Scope(string key)
			{
				this.PreviousKey = LocalStorageJsonContext.CurrentProcessKey;
				LocalStorageJsonContext.CurrentProcessKey = key;
			}

			// Token: 0x06052110 RID: 336144 RVA: 0x0164CFDE File Offset: 0x0164B1DE
			public void Dispose()
			{
				LocalStorageJsonContext.CurrentProcessKey = this.PreviousKey;
			}

			// Token: 0x0403E630 RID: 255536
			[Nullable(2)]
			private readonly string PreviousKey;
		}
	}
}
