using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace CSharpScript.Launcher.Util.Json
{
	// Token: 0x0200007F RID: 127
	[NullableContext(2)]
	[Nullable(0)]
	public static class LauncherJsonReader
	{
		// Token: 0x06000350 RID: 848 RVA: 0x000118FC File Offset: 0x0000FAFC
		public static T Read<T>(ref Utf8JsonReader reader, [Nullable(1)] JsonSerializerOptions options)
		{
			JsonTokenType tokenType = reader.TokenType;
			if (tokenType != JsonTokenType.StartObject)
			{
				if (tokenType == JsonTokenType.String)
				{
					return LauncherJsonReader.ReadString<T>(ref reader);
				}
				if (tokenType != JsonTokenType.Number)
				{
					return JsonSerializer.Deserialize<T>(ref reader, LauncherJsonSettings.JsonOptions);
				}
				return LauncherJsonReader.ReadNumber<T>(ref reader);
			}
			else
			{
				LauncherJsonSettings.MetaJson metaJson;
				if (ref reader.TryReadMetaJson(options, out metaJson))
				{
					return LauncherJsonReader.ReadMetaObject<T>(metaJson, options);
				}
				return JsonSerializer.Deserialize<T>(ref reader, LauncherJsonSettings.JsonOptions);
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00011958 File Offset: 0x0000FB58
		public unsafe static T ReadString<T>(ref Utf8JsonReader reader)
		{
			string @string = reader.GetString();
			if (@string == null)
			{
				return default(T);
			}
			if (@string == "___undefined___")
			{
				return LauncherJsonReader.ReadStringUndefined<T>(@string);
			}
			if (@string == "___NaN___")
			{
				return LauncherJsonReader.ReadStringNaN<T>(@string);
			}
			if (@string == "___Infinity___")
			{
				return LauncherJsonReader.ReadStringInfinity<T>(@string);
			}
			if (@string == "___-Infinity___")
			{
				return LauncherJsonReader.ReadStringInfinityNegative<T>(@string);
			}
			if (@string == "___1B___")
			{
				return LauncherJsonReader.ReadStringBoolean<T>(@string, true);
			}
			if (@string == "___0B___")
			{
				return LauncherJsonReader.ReadStringBoolean<T>(@string, false);
			}
			if (@string.EndsWith("___BI___", StringComparison.Ordinal) && typeof(T) != typeof(string))
			{
				return LauncherJsonReader.ReadStringBigInt<T>(@string);
			}
			if (@string.StartsWith("__kr_long__"))
			{
				Type typeFromHandle = typeof(T);
				Type left = Nullable.GetUnderlyingType(typeFromHandle) ?? typeFromHandle;
				long num;
				if (left == typeof(long) && long.TryParse(@string.AsSpan("__kr_long__".Length), out num))
				{
					if (!(left != typeFromHandle))
					{
						return *Unsafe.As<long, T>(ref num);
					}
					return (T)((object)num);
				}
			}
			if (typeof(T) == typeof(string))
			{
				return *Unsafe.As<string, T>(ref @string);
			}
			throw new ArgumentException(@string + " with " + typeof(T).Name + " is not support");
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00011AE4 File Offset: 0x0000FCE4
		private unsafe static T ReadStringBoolean<T>([Nullable(1)] string value, bool result)
		{
			Type typeFromHandle = typeof(T);
			if (typeFromHandle == typeof(bool))
			{
				return *Unsafe.As<bool, T>(ref result);
			}
			if (Nullable.GetUnderlyingType(typeFromHandle) == typeof(bool))
			{
				return (T)((object)result);
			}
			throw new ArgumentException(value + " with " + typeFromHandle.Name + " is not support");
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00011B5C File Offset: 0x0000FD5C
		private static T ReadStringUndefined<T>([Nullable(1)] string value)
		{
			Type typeFromHandle = typeof(T);
			if (!typeFromHandle.IsValueType)
			{
				return default(T);
			}
			if (Nullable.GetUnderlyingType(typeFromHandle) != null)
			{
				return default(T);
			}
			throw new JsonException("Cannot assign 'undefined' to non-nullable value type " + typeFromHandle.Name);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00011BB3 File Offset: 0x0000FDB3
		private static T ReadStringNaN<T>([Nullable(1)] string value)
		{
			return LauncherJsonReader.ReadStringFloating<T>(value, double.NaN, "NaN");
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00011BC9 File Offset: 0x0000FDC9
		private static T ReadStringInfinity<T>([Nullable(1)] string value)
		{
			return LauncherJsonReader.ReadStringFloating<T>(value, double.PositiveInfinity, "Infinity");
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00011BDF File Offset: 0x0000FDDF
		private static T ReadStringInfinityNegative<T>([Nullable(1)] string value)
		{
			return LauncherJsonReader.ReadStringFloating<T>(value, double.NegativeInfinity, "InfinityNegative");
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		[NullableContext(1)]
		[return: Nullable(2)]
		private unsafe static T ReadStringFloating<[Nullable(2)] T>(string value, double v, string name)
		{
			Type typeFromHandle = typeof(T);
			Type left = Nullable.GetUnderlyingType(typeFromHandle) ?? typeFromHandle;
			bool flag = left != typeFromHandle;
			if (left == typeof(float))
			{
				float num = (float)v;
				if (!flag)
				{
					return *Unsafe.As<float, T>(ref num);
				}
				return (T)((object)num);
			}
			else
			{
				if (!(left == typeof(double)))
				{
					throw new JsonException("Cannot deserialize '" + name + "' to " + typeFromHandle.Name);
				}
				double num2 = v;
				if (!flag)
				{
					return *Unsafe.As<double, T>(ref num2);
				}
				return (T)((object)num2);
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00011CA4 File Offset: 0x0000FEA4
		private unsafe static T ReadStringBigInt<T>([Nullable(1)] string value)
		{
			long num;
			if (long.TryParse(value.AsSpan(0, value.Length - "___BI___".Length), out num))
			{
				Type typeFromHandle = typeof(T);
				Type left = Nullable.GetUnderlyingType(typeFromHandle) ?? typeFromHandle;
				if (left == typeof(long))
				{
					if (!(left != typeFromHandle))
					{
						return *Unsafe.As<long, T>(ref num);
					}
					return (T)((object)num);
				}
			}
			throw new JsonException("Cannot deserialize 'BigInt':'" + value + "' to " + typeof(T).Name);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00011D44 File Offset: 0x0000FF44
		private unsafe static T ReadNumber<T>(ref Utf8JsonReader reader)
		{
			Type typeFromHandle = typeof(T);
			Type type = Nullable.GetUnderlyingType(typeFromHandle) ?? typeFromHandle;
			bool flag = type != typeFromHandle;
			switch (Type.GetTypeCode(type))
			{
			case TypeCode.Byte:
			{
				byte @byte = reader.GetByte();
				if (!flag)
				{
					return *Unsafe.As<byte, T>(ref @byte);
				}
				return (T)((object)@byte);
			}
			case TypeCode.Int16:
			{
				short @int = reader.GetInt16();
				if (!flag)
				{
					return *Unsafe.As<short, T>(ref @int);
				}
				return (T)((object)@int);
			}
			case TypeCode.UInt16:
			{
				ushort @uint = reader.GetUInt16();
				if (!flag)
				{
					return *Unsafe.As<ushort, T>(ref @uint);
				}
				return (T)((object)@uint);
			}
			case TypeCode.Int32:
			{
				int int2 = reader.GetInt32();
				if (!flag)
				{
					return *Unsafe.As<int, T>(ref int2);
				}
				return (T)((object)int2);
			}
			case TypeCode.UInt32:
			{
				uint uint2 = reader.GetUInt32();
				if (!flag)
				{
					return *Unsafe.As<uint, T>(ref uint2);
				}
				return (T)((object)uint2);
			}
			case TypeCode.Int64:
			{
				long int3 = reader.GetInt64();
				if (!flag)
				{
					return *Unsafe.As<long, T>(ref int3);
				}
				return (T)((object)int3);
			}
			case TypeCode.UInt64:
			{
				ulong uint3 = reader.GetUInt64();
				if (!flag)
				{
					return *Unsafe.As<ulong, T>(ref uint3);
				}
				return (T)((object)uint3);
			}
			case TypeCode.Single:
			{
				float single = reader.GetSingle();
				if (!flag)
				{
					return *Unsafe.As<float, T>(ref single);
				}
				return (T)((object)single);
			}
			case TypeCode.Double:
			{
				double @double = reader.GetDouble();
				if (!flag)
				{
					return *Unsafe.As<double, T>(ref @double);
				}
				return (T)((object)@double);
			}
			case TypeCode.Decimal:
			{
				decimal @decimal = reader.GetDecimal();
				if (!flag)
				{
					return *Unsafe.As<decimal, T>(ref @decimal);
				}
				return (T)((object)@decimal);
			}
			default:
				throw new JsonException("Cannot deserialize 'number' to " + typeFromHandle.Name);
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00011F30 File Offset: 0x00010130
		[NullableContext(1)]
		private static bool TryReadMetaJson(this Utf8JsonReader reader, JsonSerializerOptions options, [Nullable(2)] out LauncherJsonSettings.MetaJson metaJson)
		{
			Utf8JsonReader utf8JsonReader = reader;
			metaJson = JsonSerializer.Deserialize<LauncherJsonSettings.MetaJson>(ref utf8JsonReader, options);
			if (metaJson != null && metaJson.Content != null)
			{
				reader = utf8JsonReader;
				return true;
			}
			metaJson = null;
			return false;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00011F68 File Offset: 0x00010168
		[NullableContext(1)]
		[return: Nullable(2)]
		private static T ReadMetaObject<[Nullable(2)] T>(LauncherJsonSettings.MetaJson metaJson, JsonSerializerOptions options)
		{
			object content = metaJson.Content;
			if (content is JsonElement)
			{
				JsonElement jsonElement = (JsonElement)content;
				if (metaJson.MetaType == "___Map___")
				{
					return LauncherJsonReader.DeserializeMap<T>(jsonElement, LauncherJsonSettings.JsonOptions);
				}
				if (metaJson.MetaType == "___Set___")
				{
					return LauncherJsonReader.DeserializeSet<T>(jsonElement, LauncherJsonSettings.JsonOptions);
				}
			}
			return default(T);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00011FD0 File Offset: 0x000101D0
		private static T DeserializeMap<T>(JsonElement mapElement, [Nullable(1)] JsonSerializerOptions options)
		{
			Type typeFromHandle = typeof(T);
			if (LauncherJsonSettings.IsGenericDictionary(typeFromHandle))
			{
				return (T)((object)LauncherJsonReader.DeserializeDictionary(mapElement, typeFromHandle, options));
			}
			throw new JsonException("Failed to deserialize JSON to " + typeof(T).Name + ".");
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00012024 File Offset: 0x00010224
		[NullableContext(1)]
		[return: Nullable(2)]
		private static object DeserializeDictionary(JsonElement mapElement, Type dictType, JsonSerializerOptions options)
		{
			JsonValueKind valueKind = mapElement.ValueKind;
			if (valueKind == JsonValueKind.Object)
			{
				return mapElement.Deserialize(dictType, options);
			}
			if (valueKind != JsonValueKind.Array)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Expected JSON object or array, got ");
				defaultInterpolatedStringHandler.AppendFormatted<JsonValueKind>(mapElement.ValueKind);
				throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			object obj = JsonSerializer.Deserialize("{}", dictType, options);
			IDictionary dictionary = obj as IDictionary;
			if (dictionary == null)
			{
				throw new JsonException("Failed to create dictionary for " + dictType.Name + ".");
			}
			JsonSerializerOptions options2 = LauncherJsonSettings.CreateOptionsWithMarkerConverters(options);
			ValueTuple<Type, Type> dictionaryGenericArguments = LauncherJsonReader.GetDictionaryGenericArguments(dictType);
			Type item = dictionaryGenericArguments.Item1;
			Type item2 = dictionaryGenericArguments.Item2;
			foreach (JsonElement jsonElement in mapElement.EnumerateArray())
			{
				if (jsonElement.ValueKind != JsonValueKind.Array || jsonElement.GetArrayLength() != 2)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Expected KeyValuePair array, got ");
					defaultInterpolatedStringHandler.AppendFormatted<JsonValueKind>(jsonElement.ValueKind);
					throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				JsonElement element = jsonElement[0];
				JsonElement element2 = jsonElement[1];
				object obj2 = LauncherJsonReader.DeserializeElement(element, item, options2);
				object value = LauncherJsonReader.DeserializeElement(element2, item2, options2);
				if (obj2 == null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Failed to deserialize JSON :");
					defaultInterpolatedStringHandler.AppendFormatted(element.GetRawText());
					defaultInterpolatedStringHandler.AppendLiteral(" to Dictionary Key: ");
					defaultInterpolatedStringHandler.AppendFormatted<Type>(item);
					defaultInterpolatedStringHandler.AppendLiteral(".");
					throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				dictionary.Add(obj2, value);
			}
			return obj;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000121E8 File Offset: 0x000103E8
		[NullableContext(1)]
		[return: Nullable(2)]
		private static object DeserializeElement(JsonElement element, Type type, JsonSerializerOptions options)
		{
			JsonElement jsonElement;
			if (element.ValueKind == JsonValueKind.Object && element.TryGetProperty("___MetaType___", out jsonElement))
			{
				string @string = jsonElement.GetString();
				JsonElement element2;
				if (@string == "___Set___" && element.TryGetProperty("Content", out element2) && LauncherJsonSettings.IsGenericHashSet(type))
				{
					return element2.Deserialize(type, options);
				}
				JsonElement mapElement;
				if (@string == "___Map___" && element.TryGetProperty("Content", out mapElement) && LauncherJsonSettings.IsGenericDictionary(type))
				{
					return LauncherJsonReader.DeserializeDictionary(mapElement, type, options);
				}
			}
			return element.Deserialize(type, options);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0001227C File Offset: 0x0001047C
		private static T DeserializeSet<T>(JsonElement setElement, [Nullable(1)] JsonSerializerOptions options)
		{
			if (LauncherJsonSettings.IsGenericHashSet(typeof(T)))
			{
				JsonSerializerOptions options2 = LauncherJsonSettings.CreateOptionsWithMarkerConverters(options);
				return setElement.Deserialize(options2);
			}
			throw new JsonException("Failed to deserialize JSON to " + typeof(T).Name + ".");
		}

		// Token: 0x06000360 RID: 864 RVA: 0x000122CC File Offset: 0x000104CC
		[NullableContext(1)]
		[return: TupleElementNames(new string[]
		{
			"Key",
			"Value"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private static ValueTuple<Type, Type> GetDictionaryGenericArguments(Type type)
		{
			Type[] genericArguments = type.GetGenericArguments();
			if (genericArguments.Length == 2)
			{
				return new ValueTuple<Type, Type>(genericArguments[0], genericArguments[1]);
			}
			throw new JsonException("Failed to get Dictionary generic arguments for " + type.Name + ".");
		}
	}
}
