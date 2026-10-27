using System;
using System.Buffers;
using System.Buffers.Text;
using System.Collections;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace CSharpScript.Game.Common.LocalStorageJson
{
	// Token: 0x02007290 RID: 29328
	public static class LocalStorageJsonEncoder
	{
		// Token: 0x17009EA2 RID: 40610
		// (get) Token: 0x06047E0B RID: 294411 RVA: 0x01264B58 File Offset: 0x01262D58
		private unsafe static ReadOnlySpan<byte> BigIntMarkerUtf8
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.78E14F28A8A77FAAF461BB92A742F0D7EFF3E8B082D52681C0EB6D96B3C7DC65), 8);
			}
		}

		// Token: 0x17009EA3 RID: 40611
		// (get) Token: 0x06047E0C RID: 294412 RVA: 0x01264B65 File Offset: 0x01262D65
		private unsafe static ReadOnlySpan<byte> MetaTypePropertyNameUtf8
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.CB7FCD77FBF798BB027D6B91EF60854663C5E25F6559D6FB22E56EE9005E9AEB), 14);
			}
		}

		// Token: 0x17009EA4 RID: 40612
		// (get) Token: 0x06047E0D RID: 294413 RVA: 0x01264B73 File Offset: 0x01262D73
		private unsafe static ReadOnlySpan<byte> ContentPropertyNameUtf8
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.E305279D5B112237FACF20D5545320776D9036138AA37F94ABF7D2F5C3BA5CF9), 7);
			}
		}

		// Token: 0x17009EA5 RID: 40613
		// (get) Token: 0x06047E0E RID: 294414 RVA: 0x01264B80 File Offset: 0x01262D80
		private unsafe static ReadOnlySpan<byte> MetaMapValueUtf8
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.895B3A303B19374C59863E6460BE02CD703D6BC19A4FD5053D05D46ED7328E89), 9);
			}
		}

		// Token: 0x17009EA6 RID: 40614
		// (get) Token: 0x06047E0F RID: 294415 RVA: 0x01264B8E File Offset: 0x01262D8E
		private unsafe static ReadOnlySpan<byte> MetaSetValueUtf8
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.E268DB06C48A79ACE3AFE80EC6C89859FDBED4178BAD7409E3A707BBD4AFA538), 9);
			}
		}

		// Token: 0x17009EA7 RID: 40615
		// (get) Token: 0x06047E10 RID: 294416 RVA: 0x01264B9C File Offset: 0x01262D9C
		private static ReadOnlySpan<char> BigIntMarkerChars
		{
			get
			{
				return "___BI___";
			}
		}

		// Token: 0x06047E11 RID: 294417 RVA: 0x01264BA8 File Offset: 0x01262DA8
		[NullableContext(1)]
		public static void Encode<[Nullable(2)] T>(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return;
			}
			Type type = typeof(T).IsValueType ? LocalStorageJsonContext.UnwrapNullable(typeof(T)) : LocalStorageJsonContext.UnwrapNullable(value.GetType());
			if (LocalStorageJsonContext.IsScalarType(type))
			{
				LocalStorageJsonEncoder.WriteScalar(writer, value, type);
				return;
			}
			if (LocalStorageJsonContext.IsDictionaryType(type))
			{
				LocalStorageJsonEncoder.WriteAsMap(writer, (IDictionary)((object)value), type);
				return;
			}
			if (LocalStorageJsonContext.IsSetType(type))
			{
				LocalStorageJsonEncoder.WriteAsSet(writer, (IEnumerable)((object)value), type);
				return;
			}
			if (value is IEnumerable && !(value is string))
			{
				LocalStorageJsonEncoder.WriteAsArray(writer, (IEnumerable)((object)value), type);
				return;
			}
			LocalStorageJsonEncoder.WriteAsObject(writer, value, type);
		}

		// Token: 0x06047E12 RID: 294418 RVA: 0x01264C80 File Offset: 0x01262E80
		[NullableContext(1)]
		private static void WriteAsObject(Utf8JsonWriter writer, object value, Type runtimeType)
		{
			writer.WriteStartObject();
			JsonTypeInfo typeInfo = LocalStorageJsonContext.GetTypeInfo(runtimeType);
			JsonSerializerOptions nestedJsonOptions = LocalStorageJsonContext.NestedJsonOptions;
			foreach (JsonPropertyInfo jsonPropertyInfo in typeInfo.Properties)
			{
				if (jsonPropertyInfo.Get != null)
				{
					object obj;
					try
					{
						obj = jsonPropertyInfo.Get(value);
					}
					catch
					{
						continue;
					}
					if ((jsonPropertyInfo.ShouldSerialize == null || jsonPropertyInfo.ShouldSerialize(value, obj)) && obj != null)
					{
						writer.WritePropertyName(jsonPropertyInfo.Name);
						JsonSerializer.Serialize(writer, obj, jsonPropertyInfo.PropertyType, nestedJsonOptions);
					}
				}
			}
			writer.WriteEndObject();
		}

		// Token: 0x06047E13 RID: 294419 RVA: 0x01264D38 File Offset: 0x01262F38
		[NullableContext(1)]
		private static void WriteScalar(Utf8JsonWriter writer, object value, Type runtimeType)
		{
			if (value is bool)
			{
				bool flag = (bool)value;
				writer.WriteStringValue(flag ? "___1B___" : "___0B___");
				return;
			}
			if (value is long)
			{
				long value2 = (long)value;
				LocalStorageJsonEncoder.WriteLongWithBigIntMarker(writer, value2);
				return;
			}
			if (value is ulong)
			{
				ulong value3 = (ulong)value;
				LocalStorageJsonEncoder.WriteUlongWithBigIntMarker(writer, value3);
				return;
			}
			if (value is BigInteger)
			{
				BigInteger value4 = (BigInteger)value;
				LocalStorageJsonEncoder.WriteBigIntegerWithBigIntMarker(writer, value4);
				return;
			}
			if (value is float)
			{
				float num = (float)value;
				if (float.IsNaN(num))
				{
					writer.WriteStringValue("___NaN___");
					return;
				}
				if (float.IsPositiveInfinity(num))
				{
					writer.WriteStringValue("___Infinity___");
					return;
				}
				if (float.IsNegativeInfinity(num))
				{
					writer.WriteStringValue("___-Infinity___");
					return;
				}
				writer.WriteNumberValue(num);
				return;
			}
			else
			{
				if (!(value is double))
				{
					JsonSerializer.Serialize(writer, value, runtimeType, LocalStorageJsonContext.InternalJsonOptions);
					return;
				}
				double num2 = (double)value;
				if (double.IsNaN(num2))
				{
					writer.WriteStringValue("___NaN___");
					return;
				}
				if (double.IsPositiveInfinity(num2))
				{
					writer.WriteStringValue("___Infinity___");
					return;
				}
				if (double.IsNegativeInfinity(num2))
				{
					writer.WriteStringValue("___-Infinity___");
					return;
				}
				writer.WriteNumberValue(num2);
				return;
			}
		}

		// Token: 0x06047E14 RID: 294420 RVA: 0x01264E7C File Offset: 0x0126307C
		[NullableContext(1)]
		private unsafe static void WriteLongWithBigIntMarker(Utf8JsonWriter writer, long value)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)32], 32);
			int num;
			if (Utf8Formatter.TryFormat(value, destination, out num, default(StandardFormat)))
			{
				LocalStorageJsonEncoder.BigIntMarkerUtf8.CopyTo(destination.Slice(num));
				writer.WriteStringValue(destination.Slice(0, num + LocalStorageJsonEncoder.BigIntMarkerUtf8.Length));
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted<long>(value);
			defaultInterpolatedStringHandler.AppendFormatted("___BI___");
			writer.WriteStringValue(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06047E15 RID: 294421 RVA: 0x01264F0C File Offset: 0x0126310C
		[NullableContext(1)]
		private unsafe static void WriteUlongWithBigIntMarker(Utf8JsonWriter writer, ulong value)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)32], 32);
			int num;
			if (Utf8Formatter.TryFormat(value, destination, out num, default(StandardFormat)))
			{
				LocalStorageJsonEncoder.BigIntMarkerUtf8.CopyTo(destination.Slice(num));
				writer.WriteStringValue(destination.Slice(0, num + LocalStorageJsonEncoder.BigIntMarkerUtf8.Length));
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted<ulong>(value);
			defaultInterpolatedStringHandler.AppendFormatted("___BI___");
			writer.WriteStringValue(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06047E16 RID: 294422 RVA: 0x01264F9C File Offset: 0x0126319C
		[NullableContext(1)]
		private unsafe static void WriteBigIntegerWithBigIntMarker(Utf8JsonWriter writer, BigInteger value)
		{
			Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)128], 64);
			Span<char> destination = span;
			IFormatProvider invariantCulture = CultureInfo.InvariantCulture;
			int num;
			if (value.TryFormat(destination, out num, default(ReadOnlySpan<char>), invariantCulture) && span.Slice(num).Length >= LocalStorageJsonEncoder.BigIntMarkerChars.Length)
			{
				LocalStorageJsonEncoder.BigIntMarkerChars.CopyTo(span.Slice(num));
				writer.WriteStringValue(span.Slice(0, num + LocalStorageJsonEncoder.BigIntMarkerChars.Length));
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted<BigInteger>(value);
			defaultInterpolatedStringHandler.AppendFormatted("___BI___");
			writer.WriteStringValue(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06047E17 RID: 294423 RVA: 0x01265058 File Offset: 0x01263258
		[NullableContext(1)]
		private static void WriteAsMap(Utf8JsonWriter writer, IDictionary dict, Type runtimeType)
		{
			Type[] genericArguments = runtimeType.GetGenericArguments();
			Type type = genericArguments[0];
			Type type2 = genericArguments[1];
			JsonSerializerOptions nestedSerializerOptions = LocalStorageJsonContext.GetNestedSerializerOptions(type);
			JsonSerializerOptions nestedSerializerOptions2 = LocalStorageJsonContext.GetNestedSerializerOptions(type2);
			writer.WriteStartObject();
			writer.WriteString(LocalStorageJsonEncoder.MetaTypePropertyNameUtf8, LocalStorageJsonEncoder.MetaMapValueUtf8);
			writer.WritePropertyName(LocalStorageJsonEncoder.ContentPropertyNameUtf8);
			writer.WriteStartArray();
			foreach (object obj in dict)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, dictionaryEntry.Key, type, nestedSerializerOptions);
				JsonSerializer.Serialize(writer, dictionaryEntry.Value, type2, nestedSerializerOptions2);
				writer.WriteEndArray();
			}
			writer.WriteEndArray();
			writer.WriteEndObject();
		}

		// Token: 0x06047E18 RID: 294424 RVA: 0x01265128 File Offset: 0x01263328
		[NullableContext(1)]
		private static void WriteAsArray(Utf8JsonWriter writer, IEnumerable enumerable, Type runtimeType)
		{
			Type enumerableElementType = LocalStorageJsonEncoder.GetEnumerableElementType(runtimeType);
			JsonSerializerOptions nestedSerializerOptions = LocalStorageJsonContext.GetNestedSerializerOptions(enumerableElementType);
			writer.WriteStartArray();
			foreach (object value in enumerable)
			{
				JsonSerializer.Serialize(writer, value, enumerableElementType, nestedSerializerOptions);
			}
			writer.WriteEndArray();
		}

		// Token: 0x06047E19 RID: 294425 RVA: 0x01265198 File Offset: 0x01263398
		[NullableContext(1)]
		private static void WriteAsSet(Utf8JsonWriter writer, IEnumerable set, Type runtimeType)
		{
			Type type = runtimeType.GetGenericArguments()[0];
			JsonSerializerOptions nestedSerializerOptions = LocalStorageJsonContext.GetNestedSerializerOptions(type);
			writer.WriteStartObject();
			writer.WriteString(LocalStorageJsonEncoder.MetaTypePropertyNameUtf8, LocalStorageJsonEncoder.MetaSetValueUtf8);
			writer.WritePropertyName(LocalStorageJsonEncoder.ContentPropertyNameUtf8);
			writer.WriteStartArray();
			foreach (object value in set)
			{
				JsonSerializer.Serialize(writer, value, type, nestedSerializerOptions);
			}
			writer.WriteEndArray();
			writer.WriteEndObject();
		}

		// Token: 0x06047E1A RID: 294426 RVA: 0x01265230 File Offset: 0x01263430
		[NullableContext(1)]
		private static Type GetEnumerableElementType(Type runtimeType)
		{
			if (runtimeType.IsArray)
			{
				return runtimeType.GetElementType() ?? typeof(object);
			}
			if (runtimeType.IsGenericType)
			{
				Type[] genericArguments = runtimeType.GetGenericArguments();
				if (genericArguments.Length == 1)
				{
					return genericArguments[0];
				}
			}
			return typeof(object);
		}

		// Token: 0x04025E79 RID: 155257
		private const int LongUtf8BufferSize = 32;

		// Token: 0x04025E7A RID: 155258
		private const int UlongUtf8BufferSize = 32;

		// Token: 0x04025E7B RID: 155259
		private const int BigIntegerCharBufferSize = 64;
	}
}
