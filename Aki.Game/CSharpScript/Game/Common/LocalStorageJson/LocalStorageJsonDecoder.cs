using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace CSharpScript.Game.Common.LocalStorageJson
{
	// Token: 0x0200640E RID: 25614
	public static class LocalStorageJsonDecoder
	{
		// Token: 0x170075EF RID: 30191
		// (get) Token: 0x0603E1B5 RID: 254389 RVA: 0x01204B51 File Offset: 0x01202D51
		private unsafe static ReadOnlySpan<byte> UndefinedUtf8
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.B0806E217A11A22D00115F92E9E87AA90C0F4A60C7FECCD0B178E83DD3ED0FB4), 15);
			}
		}

		// Token: 0x170075F0 RID: 30192
		// (get) Token: 0x0603E1B6 RID: 254390 RVA: 0x01204B5F File Offset: 0x01202D5F
		private unsafe static ReadOnlySpan<byte> NaNUtf8
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.D83BE94451FCFE05C71DAD7B862938E0934A66CF2C94397AD3C0613E30285AB4), 9);
			}
		}

		// Token: 0x170075F1 RID: 30193
		// (get) Token: 0x0603E1B7 RID: 254391 RVA: 0x01204B6D File Offset: 0x01202D6D
		private unsafe static ReadOnlySpan<byte> InfinityUtf8
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.7AAD3A78EE4DA8AC37F3E9591CEA3E6302D7EB8A4C7A2E2EBCB9F5392DBED708), 14);
			}
		}

		// Token: 0x170075F2 RID: 30194
		// (get) Token: 0x0603E1B8 RID: 254392 RVA: 0x01204B7B File Offset: 0x01202D7B
		private unsafe static ReadOnlySpan<byte> InfinityNegativeUtf8
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.AE409D506004148BB51FD75BA12F9059C0681340510BFE0439075C7E9473226F), 15);
			}
		}

		// Token: 0x170075F3 RID: 30195
		// (get) Token: 0x0603E1B9 RID: 254393 RVA: 0x01204B89 File Offset: 0x01202D89
		private unsafe static ReadOnlySpan<byte> BooleanTrueUtf8
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.1F9F3C0705925E748B75DCE1A487E849FBDF4ACA0398904368F271BA409C9F88), 8);
			}
		}

		// Token: 0x170075F4 RID: 30196
		// (get) Token: 0x0603E1BA RID: 254394 RVA: 0x01204B96 File Offset: 0x01202D96
		private unsafe static ReadOnlySpan<byte> BooleanFalseUtf8
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.C1C09635A8381661D4B865AD73FB9804BBF6B542A7219FD5E3444E701B55F941), 8);
			}
		}

		// Token: 0x170075F5 RID: 30197
		// (get) Token: 0x0603E1BB RID: 254395 RVA: 0x01204BA3 File Offset: 0x01202DA3
		private unsafe static ReadOnlySpan<byte> BigIntMarkerUtf8
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.78E14F28A8A77FAAF461BB92A742F0D7EFF3E8B082D52681C0EB6D96B3C7DC65), 8);
			}
		}

		// Token: 0x170075F6 RID: 30198
		// (get) Token: 0x0603E1BC RID: 254396 RVA: 0x01204BB0 File Offset: 0x01202DB0
		private static ReadOnlySpan<char> BigIntMarkerChars
		{
			get
			{
				return "___BI___";
			}
		}

		// Token: 0x170075F7 RID: 30199
		// (get) Token: 0x0603E1BD RID: 254397 RVA: 0x01204BBC File Offset: 0x01202DBC
		private unsafe static ReadOnlySpan<byte> MetaTypePropertyNameUtf8
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.CB7FCD77FBF798BB027D6B91EF60854663C5E25F6559D6FB22E56EE9005E9AEB), 14);
			}
		}

		// Token: 0x170075F8 RID: 30200
		// (get) Token: 0x0603E1BE RID: 254398 RVA: 0x01204BCA File Offset: 0x01202DCA
		private unsafe static ReadOnlySpan<byte> ContentPropertyNameUtf8
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.E305279D5B112237FACF20D5545320776D9036138AA37F94ABF7D2F5C3BA5CF9), 7);
			}
		}

		// Token: 0x170075F9 RID: 30201
		// (get) Token: 0x0603E1BF RID: 254399 RVA: 0x01204BD7 File Offset: 0x01202DD7
		private unsafe static ReadOnlySpan<byte> MetaMapValueUtf8
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.895B3A303B19374C59863E6460BE02CD703D6BC19A4FD5053D05D46ED7328E89), 9);
			}
		}

		// Token: 0x170075FA RID: 30202
		// (get) Token: 0x0603E1C0 RID: 254400 RVA: 0x01204BE5 File Offset: 0x01202DE5
		private unsafe static ReadOnlySpan<byte> MetaSetValueUtf8
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.E268DB06C48A79ACE3AFE80EC6C89859FDBED4178BAD7409E3A707BBD4AFA538), 9);
			}
		}

		// Token: 0x0603E1C1 RID: 254401 RVA: 0x01204BF4 File Offset: 0x01202DF4
		[NullableContext(2)]
		public static T Decode<T>(ref Utf8JsonReader reader, [Nullable(1)] JsonSerializerOptions options)
		{
			Type targetType = LocalStorageJsonContext.UnwrapNullable(typeof(T));
			JsonTokenType tokenType = reader.TokenType;
			if (tokenType != JsonTokenType.StartObject)
			{
				switch (tokenType)
				{
				case JsonTokenType.String:
					return LocalStorageJsonDecoder.DecodeStringPayload<T>(ref reader, targetType);
				case JsonTokenType.Number:
					return LocalStorageJsonDecoder.DecodeNumberPayload<T>(ref reader, targetType);
				case JsonTokenType.Null:
					return default(T);
				}
				return JsonSerializer.Deserialize<T>(ref reader, LocalStorageJsonContext.InternalJsonOptions);
			}
			return LocalStorageJsonDecoder.DecodeObjectPayload<T>(ref reader, targetType, options);
		}

		// Token: 0x0603E1C2 RID: 254402 RVA: 0x01204C68 File Offset: 0x01202E68
		[NullableContext(2)]
		private static T DecodeStringPayload<T>(ref Utf8JsonReader reader, [Nullable(1)] Type targetType)
		{
			if (reader.ValueTextEquals(LocalStorageJsonDecoder.UndefinedUtf8))
			{
				return default(T);
			}
			if (reader.ValueTextEquals(LocalStorageJsonDecoder.NaNUtf8))
			{
				return LocalStorageJsonDecoder.CastFloating<T>(double.NaN, targetType);
			}
			if (reader.ValueTextEquals(LocalStorageJsonDecoder.InfinityUtf8))
			{
				return LocalStorageJsonDecoder.CastFloating<T>(double.PositiveInfinity, targetType);
			}
			if (reader.ValueTextEquals(LocalStorageJsonDecoder.InfinityNegativeUtf8))
			{
				return LocalStorageJsonDecoder.CastFloating<T>(double.NegativeInfinity, targetType);
			}
			if (reader.ValueTextEquals(LocalStorageJsonDecoder.BooleanTrueUtf8))
			{
				return LocalStorageJsonDecoder.CastBoolean<T>(true, targetType);
			}
			if (reader.ValueTextEquals(LocalStorageJsonDecoder.BooleanFalseUtf8))
			{
				return LocalStorageJsonDecoder.CastBoolean<T>(false, targetType);
			}
			string @string = reader.GetString();
			if (@string == null)
			{
				return default(T);
			}
			if (@string.AsSpan().EndsWith(LocalStorageJsonDecoder.BigIntMarkerChars, StringComparison.Ordinal))
			{
				return LocalStorageJsonDecoder.CastBigInt<T>(@string.AsSpan(0, @string.Length - LocalStorageJsonDecoder.BigIntMarkerChars.Length), targetType);
			}
			if (targetType == typeof(string))
			{
				return (T)((object)@string);
			}
			return JsonSerializer.Deserialize<T>("\"" + @string + "\"", LocalStorageJsonContext.InternalJsonOptions);
		}

		// Token: 0x0603E1C3 RID: 254403 RVA: 0x01204D8C File Offset: 0x01202F8C
		[NullableContext(2)]
		private unsafe static T DecodeNumberPayload<T>(ref Utf8JsonReader reader, [Nullable(1)] Type targetType)
		{
			if (!(targetType == typeof(bool)))
			{
				return JsonSerializer.Deserialize<T>(ref reader, LocalStorageJsonContext.InternalJsonOptions);
			}
			bool flag = reader.GetDecimal() != 0m;
			if (!(typeof(T) != targetType))
			{
				return *Unsafe.As<bool, T>(ref flag);
			}
			return (T)((object)flag);
		}

		// Token: 0x0603E1C4 RID: 254404 RVA: 0x01204DF4 File Offset: 0x01202FF4
		[NullableContext(1)]
		private unsafe static T CastBoolean<[Nullable(2)] T>(bool b, Type targetType)
		{
			if (targetType != typeof(bool))
			{
				throw new JsonException("Cannot convert " + (b ? "___1B___" : "___0B___") + " to " + typeof(T).Name);
			}
			if (!(typeof(T) != targetType))
			{
				return *Unsafe.As<bool, T>(ref b);
			}
			return (T)((object)b);
		}

		// Token: 0x0603E1C5 RID: 254405 RVA: 0x01204E70 File Offset: 0x01203070
		[NullableContext(2)]
		private unsafe static T CastFloating<T>(double v, [Nullable(1)] Type targetType)
		{
			bool flag = typeof(T) != targetType;
			if (targetType == typeof(double))
			{
				double num = v;
				if (!flag)
				{
					return *Unsafe.As<double, T>(ref num);
				}
				return (T)((object)num);
			}
			else
			{
				if (!(targetType == typeof(float)))
				{
					throw new JsonException("特殊浮点值无法赋给类型 " + targetType.Name);
				}
				float num2 = (float)v;
				if (!flag)
				{
					return *Unsafe.As<float, T>(ref num2);
				}
				return (T)((object)num2);
			}
		}

		// Token: 0x0603E1C6 RID: 254406 RVA: 0x01204F04 File Offset: 0x01203104
		[NullableContext(2)]
		private unsafe static T CastBigInt<T>([Nullable(0)] ReadOnlySpan<char> num, [Nullable(1)] Type targetType)
		{
			bool flag = typeof(T) != targetType;
			long num2;
			ulong num3;
			int num4;
			uint num5;
			short num6;
			ushort num7;
			byte b;
			sbyte b2;
			if (targetType == typeof(long) && long.TryParse(num, out num2))
			{
				if (!flag)
				{
					return *Unsafe.As<long, T>(ref num2);
				}
				return (T)((object)num2);
			}
			else if (targetType == typeof(ulong) && ulong.TryParse(num, out num3))
			{
				if (!flag)
				{
					return *Unsafe.As<ulong, T>(ref num3);
				}
				return (T)((object)num3);
			}
			else if (targetType == typeof(int) && int.TryParse(num, out num4))
			{
				if (!flag)
				{
					return *Unsafe.As<int, T>(ref num4);
				}
				return (T)((object)num4);
			}
			else if (targetType == typeof(uint) && uint.TryParse(num, out num5))
			{
				if (!flag)
				{
					return *Unsafe.As<uint, T>(ref num5);
				}
				return (T)((object)num5);
			}
			else if (targetType == typeof(short) && short.TryParse(num, out num6))
			{
				if (!flag)
				{
					return *Unsafe.As<short, T>(ref num6);
				}
				return (T)((object)num6);
			}
			else if (targetType == typeof(ushort) && ushort.TryParse(num, out num7))
			{
				if (!flag)
				{
					return *Unsafe.As<ushort, T>(ref num7);
				}
				return (T)((object)num7);
			}
			else if (targetType == typeof(byte) && byte.TryParse(num, out b))
			{
				if (!flag)
				{
					return *Unsafe.As<byte, T>(ref b);
				}
				return (T)((object)b);
			}
			else if (targetType == typeof(sbyte) && sbyte.TryParse(num, out b2))
			{
				if (!flag)
				{
					return *Unsafe.As<sbyte, T>(ref b2);
				}
				return (T)((object)b2);
			}
			else
			{
				BigInteger bigInteger;
				if (!(targetType == typeof(BigInteger)) || !BigInteger.TryParse(num, NumberStyles.Integer, CultureInfo.InvariantCulture, out bigInteger))
				{
					BigInteger bigInteger2;
					if (BigInteger.TryParse(num, NumberStyles.Integer, CultureInfo.InvariantCulture, out bigInteger2))
					{
						try
						{
							return (T)((object)Convert.ChangeType(bigInteger2, targetType));
						}
						catch
						{
						}
					}
					throw new JsonException("BigInt(" + num.ToString() + ") 无法转换到目标类型 " + targetType.Name);
				}
				if (!flag)
				{
					return *Unsafe.As<BigInteger, T>(ref bigInteger);
				}
				return (T)((object)bigInteger);
			}
		}

		// Token: 0x0603E1C7 RID: 254407 RVA: 0x0120518C File Offset: 0x0120338C
		[NullableContext(1)]
		[return: Nullable(2)]
		private static T DecodeObjectPayload<[Nullable(2)] T>(ref Utf8JsonReader reader, Type targetType, JsonSerializerOptions options)
		{
			T result;
			using (JsonDocument jsonDocument = JsonDocument.ParseValue(ref reader))
			{
				JsonElement rootElement = jsonDocument.RootElement;
				JsonElement jsonElement;
				if (rootElement.ValueKind == JsonValueKind.Object && rootElement.TryGetProperty(LocalStorageJsonDecoder.MetaTypePropertyNameUtf8, out jsonElement) && jsonElement.ValueKind == JsonValueKind.String)
				{
					JsonElement contentArray;
					if (!rootElement.TryGetProperty(LocalStorageJsonDecoder.ContentPropertyNameUtf8, out contentArray))
					{
						throw new JsonException("MetaJson 缺少 Content 字段");
					}
					if (jsonElement.ValueEquals(LocalStorageJsonDecoder.MetaMapValueUtf8))
					{
						return LocalStorageJsonDecoder.DecodeMap<T>(contentArray, targetType);
					}
					if (jsonElement.ValueEquals(LocalStorageJsonDecoder.MetaSetValueUtf8))
					{
						return LocalStorageJsonDecoder.DecodeSet<T>(contentArray, targetType);
					}
				}
				result = (T)((object)LocalStorageJsonDecoder.DeserializeObjectByMembers(rootElement, targetType));
			}
			return result;
		}

		// Token: 0x0603E1C8 RID: 254408 RVA: 0x01205244 File Offset: 0x01203444
		[NullableContext(1)]
		[return: Nullable(2)]
		private static object DeserializeObjectByMembers(JsonElement root, Type targetType)
		{
			JsonTypeInfo typeInfo = LocalStorageJsonContext.GetTypeInfo(targetType);
			object obj = (typeInfo.CreateObject != null) ? typeInfo.CreateObject() : RuntimeHelpers.GetUninitializedObject(targetType);
			JsonSerializerOptions nestedJsonOptions = LocalStorageJsonContext.NestedJsonOptions;
			Dictionary<string, JsonPropertyInfo> dictionary = new Dictionary<string, JsonPropertyInfo>(typeInfo.Properties.Count, StringComparer.Ordinal);
			foreach (JsonPropertyInfo jsonPropertyInfo in typeInfo.Properties)
			{
				if (jsonPropertyInfo.Set != null)
				{
					dictionary[jsonPropertyInfo.Name] = jsonPropertyInfo;
				}
			}
			foreach (JsonProperty jsonProperty in root.EnumerateObject())
			{
				JsonPropertyInfo jsonPropertyInfo2;
				if (dictionary.TryGetValue(jsonProperty.Name, out jsonPropertyInfo2))
				{
					try
					{
						object arg = jsonProperty.Value.Deserialize(jsonPropertyInfo2.PropertyType, nestedJsonOptions);
						jsonPropertyInfo2.Set(obj, arg);
					}
					catch
					{
					}
				}
			}
			return obj;
		}

		// Token: 0x0603E1C9 RID: 254409 RVA: 0x01205374 File Offset: 0x01203574
		[NullableContext(2)]
		private static T DecodeMap<T>(JsonElement contentArray, [Nullable(1)] Type targetType)
		{
			if (!LocalStorageJsonContext.IsDictionaryType(targetType))
			{
				throw new JsonException("目标类型 " + targetType.Name + " 不是 Dictionary，但 JSON 是 Map MetaJson");
			}
			if (contentArray.ValueKind != JsonValueKind.Array)
			{
				throw new JsonException("Map.Content 不是数组");
			}
			Type[] genericArguments = targetType.GetGenericArguments();
			Type type = genericArguments[0];
			Type type2 = genericArguments[1];
			JsonSerializerOptions nestedSerializerOptions = LocalStorageJsonContext.GetNestedSerializerOptions(type);
			JsonSerializerOptions nestedSerializerOptions2 = LocalStorageJsonContext.GetNestedSerializerOptions(type2);
			T result;
			if (LocalStorageJsonMapDecoder.TryDecode<T>(contentArray, targetType, nestedSerializerOptions, nestedSerializerOptions2, out result))
			{
				return result;
			}
			IDictionary dictionary = (IDictionary)Activator.CreateInstance(typeof(Dictionary<, >).MakeGenericType(new Type[]
			{
				type,
				type2
			}));
			foreach (JsonElement jsonElement in contentArray.EnumerateArray())
			{
				if (jsonElement.ValueKind != JsonValueKind.Array)
				{
					throw new JsonException("Map.Content 元素不是 [k,v] 数组");
				}
				using (JsonElement.ArrayEnumerator enumerator2 = jsonElement.EnumerateArray().GetEnumerator())
				{
					if (!enumerator2.MoveNext())
					{
						throw new JsonException("Map.Content 元素缺少 key");
					}
					object obj = enumerator2.Current.Deserialize(type, nestedSerializerOptions);
					if (!enumerator2.MoveNext())
					{
						throw new JsonException("Map.Content 元素缺少 value");
					}
					object value = enumerator2.Current.Deserialize(type2, nestedSerializerOptions2);
					if (obj != null)
					{
						dictionary[obj] = value;
					}
				}
			}
			return (T)((object)dictionary);
		}

		// Token: 0x0603E1CA RID: 254410 RVA: 0x012054FC File Offset: 0x012036FC
		[NullableContext(2)]
		private static T DecodeSet<T>(JsonElement contentArray, [Nullable(1)] Type targetType)
		{
			if (!LocalStorageJsonContext.IsSetType(targetType))
			{
				throw new JsonException("目标类型 " + targetType.Name + " 不是 HashSet，但 JSON 是 Set MetaJson");
			}
			if (contentArray.ValueKind != JsonValueKind.Array)
			{
				throw new JsonException("Set.Content 不是数组");
			}
			JsonSerializerOptions nestedSerializerOptions = LocalStorageJsonContext.GetNestedSerializerOptions(targetType.GetGenericArguments()[0]);
			T result;
			if (LocalStorageJsonSetDecoder.TryDecode<T>(contentArray, targetType, nestedSerializerOptions, out result))
			{
				return result;
			}
			return contentArray.Deserialize(LocalStorageJsonContext.InternalJsonOptions);
		}

		// Token: 0x04021144 RID: 135492
		private const NumberStyles BigIntNumberStyles = NumberStyles.Integer;
	}
}
