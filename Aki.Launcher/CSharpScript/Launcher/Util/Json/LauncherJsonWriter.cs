using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Util.Json
{
	// Token: 0x02000084 RID: 132
	[NullableContext(1)]
	[Nullable(0)]
	public static class LauncherJsonWriter
	{
		// Token: 0x0600037C RID: 892 RVA: 0x000134F4 File Offset: 0x000116F4
		public static void Write<[Nullable(2)] T>(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return;
			}
			Type typeFromHandle = typeof(T);
			Type type = value.GetType();
			if (LauncherJsonSettings.IsGenericDictionary(type))
			{
				LauncherJsonWriter.WriteDictionary<T>(writer, value, type);
				return;
			}
			if (LauncherJsonSettings.IsGenericHashSet(type))
			{
				LauncherJsonWriter.WriteHashSet<T>(writer, value, type);
				return;
			}
			LauncherJsonWriter.WriteScalarValue<T>(writer, value, typeFromHandle);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00013554 File Offset: 0x00011754
		private static void WriteScalarValue<[Nullable(2)] T>(Utf8JsonWriter writer, T value, Type type)
		{
			if (value is long)
			{
				long num = value as long;
				if (num >= -9007199254740991L && num <= 9007199254740991L)
				{
					writer.WriteNumberValue(num);
					return;
				}
				writer.WriteStringValue(num.ToString() + "___BI___");
				return;
			}
			else
			{
				if (value is BigInteger)
				{
					writer.WriteStringValue((value as BigInteger).ToString() + "___BI___");
					return;
				}
				if (value is bool)
				{
					bool flag = value as bool;
					writer.WriteStringValue(flag ? "___1B___" : "___0B___");
					return;
				}
				if (value is float)
				{
					float num2 = value as float;
					if (float.IsNaN(num2))
					{
						writer.WriteStringValue("___NaN___");
						return;
					}
					if (float.IsPositiveInfinity(num2))
					{
						writer.WriteStringValue("___Infinity___");
						return;
					}
					if (float.IsNegativeInfinity(num2))
					{
						writer.WriteStringValue("___-Infinity___");
						return;
					}
					writer.WriteNumberValue(num2);
					return;
				}
				else if (value is double)
				{
					double num3 = value as double;
					if (double.IsNaN(num3))
					{
						writer.WriteStringValue("___NaN___");
						return;
					}
					if (double.IsPositiveInfinity(num3))
					{
						writer.WriteStringValue("___Infinity___");
						return;
					}
					if (double.IsNegativeInfinity(num3))
					{
						writer.WriteStringValue("___-Infinity___");
						return;
					}
					writer.WriteNumberValue(num3);
					return;
				}
				else
				{
					if (value is int)
					{
						int value2 = value as int;
						writer.WriteNumberValue(value2);
						return;
					}
					if (value is uint)
					{
						uint value3 = value as uint;
						writer.WriteNumberValue(value3);
						return;
					}
					if (value is short)
					{
						short value4 = value as short;
						writer.WriteNumberValue((int)value4);
						return;
					}
					if (value is ushort)
					{
						ushort value5 = value as ushort;
						writer.WriteNumberValue((int)value5);
						return;
					}
					if (value is byte)
					{
						byte value6 = value as byte;
						writer.WriteNumberValue((int)value6);
						return;
					}
					if (value is sbyte)
					{
						sbyte value7 = value as sbyte;
						writer.WriteNumberValue((int)value7);
						return;
					}
					if (value is ulong)
					{
						ulong value8 = value as ulong;
						writer.WriteNumberValue(value8);
						return;
					}
					if (value is decimal)
					{
						decimal value9 = value as decimal;
						writer.WriteNumberValue(value9);
						return;
					}
					JsonSerializer.Serialize(writer, value, type, LauncherJsonSettings.JsonOptions);
					return;
				}
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00013888 File Offset: 0x00011A88
		private static void WriteDictionary<[Nullable(2)] T>(Utf8JsonWriter writer, T value, Type type)
		{
			IDictionary dictionary = value as IDictionary;
			if (dictionary == null)
			{
				throw new JsonException("Failed to serialize Dictionary: " + type.Name + ".");
			}
			ValueTuple<Type, Type> dictionaryKeyValueTypes = LauncherJsonWriter.GetDictionaryKeyValueTypes(type);
			Type item = dictionaryKeyValueTypes.Item1;
			Type item2 = dictionaryKeyValueTypes.Item2;
			JsonSerializerOptions jsonSerializerOptions = LauncherJsonSettings.CreateOptionsWithMarkerConverters(LauncherJsonSettings.JsonOptions);
			if (LauncherJsonSettings.IsGenericDictionary(item2) || LauncherJsonSettings.IsGenericHashSet(item2))
			{
				Type type2 = typeof(LauncherJsonConverter<>).MakeGenericType(new Type[]
				{
					item2
				});
				jsonSerializerOptions.Converters.Add((JsonConverter)Activator.CreateInstance(type2));
			}
			writer.WriteStartObject();
			writer.WriteString("___MetaType___", "___Map___");
			writer.WritePropertyName("Content");
			writer.WriteStartArray();
			foreach (object obj in dictionary)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, dictionaryEntry.Key, item, jsonSerializerOptions);
				JsonSerializer.Serialize(writer, dictionaryEntry.Value, item2, jsonSerializerOptions);
				writer.WriteEndArray();
			}
			writer.WriteEndArray();
			writer.WriteEndObject();
		}

		// Token: 0x0600037F RID: 895 RVA: 0x000139C4 File Offset: 0x00011BC4
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
		private static ValueTuple<Type, Type> GetDictionaryKeyValueTypes(Type type)
		{
			foreach (Type type2 in type.GetInterfaces())
			{
				if (type2.IsGenericType && type2.GetGenericTypeDefinition() == typeof(IDictionary<, >))
				{
					Type[] genericArguments = type2.GetGenericArguments();
					return new ValueTuple<Type, Type>(genericArguments[0], genericArguments[1]);
				}
			}
			Type[] genericArguments2 = type.GetGenericArguments();
			if (genericArguments2.Length == 2)
			{
				return new ValueTuple<Type, Type>(genericArguments2[0], genericArguments2[1]);
			}
			throw new JsonException("Failed to get Dictionary generic arguments for " + type.Name + ".");
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00013A54 File Offset: 0x00011C54
		private static void WriteHashSet<[Nullable(2)] T>(Utf8JsonWriter writer, T value, Type type)
		{
			JsonSerializerOptions options = LauncherJsonSettings.CreateOptionsWithMarkerConverters(LauncherJsonSettings.JsonOptions);
			writer.WriteStartObject();
			writer.WriteString("___MetaType___", "___Set___");
			writer.WritePropertyName("Content");
			JsonSerializer.Serialize(writer, value, type, options);
			writer.WriteEndObject();
		}

		// Token: 0x04000280 RID: 640
		private const long JS_MAX_SAFE_INTEGER = 9007199254740991L;
	}
}
