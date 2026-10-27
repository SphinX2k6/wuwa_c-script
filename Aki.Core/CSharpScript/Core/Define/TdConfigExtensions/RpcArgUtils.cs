using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace CSharpScript.Core.Define.TdConfigExtensions
{
	// Token: 0x0200013B RID: 315
	[NullableContext(2)]
	[Nullable(0)]
	public static class RpcArgUtils
	{
		// Token: 0x06000B02 RID: 2818 RVA: 0x00034E6C File Offset: 0x0003306C
		[NullableContext(1)]
		public static T To<T>([Nullable(2)] object value)
		{
			if (value == null || RpcArgUtils.IsJsonNull(value))
			{
				throw new ArgumentException("RpcArgUtils.To<" + typeof(T).Name + ">: 需要非空参数,实际为 null");
			}
			T t = RpcArgUtils.Decode<T>(value);
			if (t == null)
			{
				throw new ArgumentException("RpcArgUtils.To<" + typeof(T).Name + ">: 解析结果为 null");
			}
			return t;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00034EDC File Offset: 0x000330DC
		public static T ToNullable<T>(object value)
		{
			if (value == null || RpcArgUtils.IsJsonNull(value))
			{
				return default(T);
			}
			return RpcArgUtils.Decode<T>(value);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00034F04 File Offset: 0x00033104
		private static T Decode<T>([Nullable(1)] object value)
		{
			if (value is T)
			{
				return (T)((object)value);
			}
			if (value is JsonElement)
			{
				JsonElement element = (JsonElement)value;
				return element.Deserialize(JsonSettings.DecodeOptions);
			}
			if (value == null)
			{
				return default(T);
			}
			T result;
			if (RpcArgUtils.TryConvert<T>(value, out result))
			{
				return result;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendLiteral("RpcArgUtils.To<");
			defaultInterpolatedStringHandler.AppendFormatted(typeof(T).Name);
			defaultInterpolatedStringHandler.AppendLiteral(">: 需要 ");
			defaultInterpolatedStringHandler.AppendFormatted(typeof(T).Name);
			defaultInterpolatedStringHandler.AppendLiteral(",实际为 ");
			defaultInterpolatedStringHandler.AppendFormatted(value.GetType().Name);
			throw new ArgumentException(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00034FD4 File Offset: 0x000331D4
		private static bool IsJsonNull(object value)
		{
			if (value is JsonElement)
			{
				JsonValueKind valueKind = ((JsonElement)value).ValueKind;
				if (valueKind == JsonValueKind.Undefined || valueKind == JsonValueKind.Null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00035008 File Offset: 0x00033208
		private static bool TryConvert<T>([Nullable(1)] object value, out T result)
		{
			Type type = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);
			try
			{
				if (type.IsEnum)
				{
					result = (T)((object)Enum.ToObject(type, value));
					return true;
				}
				if (value is IConvertible && typeof(IConvertible).IsAssignableFrom(type))
				{
					result = (T)((object)Convert.ChangeType(value, type));
					return true;
				}
			}
			catch
			{
			}
			result = default(T);
			return false;
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x000350A0 File Offset: 0x000332A0
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public static OneOf<T1, T2> ToOneOf<T1, T2>(object value)
		{
			if (value == null || RpcArgUtils.IsJsonNull(value))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 2);
				defaultInterpolatedStringHandler.AppendLiteral("RpcArgUtils.ToOneOf<");
				defaultInterpolatedStringHandler.AppendFormatted(typeof(T1).Name);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted(typeof(T2).Name);
				defaultInterpolatedStringHandler.AppendLiteral(">: 需要非空参数,实际为 null");
				throw new ArgumentException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return RpcArgUtils.DecodeOneOf<T1, T2>(value);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00035128 File Offset: 0x00033328
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public static OneOf<T1, T2>? ToOneOfNullable<T1, T2>(object value)
		{
			if (value == null || RpcArgUtils.IsJsonNull(value))
			{
				return null;
			}
			return new OneOf<T1, T2>?(RpcArgUtils.DecodeOneOf<T1, T2>(value));
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00035158 File Offset: 0x00033358
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private static OneOf<T1, T2> DecodeOneOf<T1, T2>([Nullable(1)] object value)
		{
			if (value is OneOf<T1, T2>)
			{
				return (OneOf<T1, T2>)value;
			}
			if (value is T1)
			{
				T1 value2 = (T1)((object)value);
				return value2;
			}
			if (value is T2)
			{
				T2 value3 = (T2)((object)value);
				return value3;
			}
			if (value is JsonElement)
			{
				JsonElement element = (JsonElement)value;
				return RpcArgUtils.FromJsonElement<T1, T2>(element);
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
			defaultInterpolatedStringHandler.AppendLiteral("RpcArgUtils.DecodeOneOf<");
			defaultInterpolatedStringHandler.AppendFormatted(typeof(T1).Name);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted(typeof(T2).Name);
			defaultInterpolatedStringHandler.AppendLiteral(">: 无法转换 ");
			defaultInterpolatedStringHandler.AppendFormatted(value.GetType().Name);
			throw new ArgumentException(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00035238 File Offset: 0x00033438
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private static OneOf<T1, T2> FromJsonElement<T1, T2>(JsonElement element)
		{
			bool flag = RpcArgUtils.KindMatches(typeof(T1), element.ValueKind);
			bool flag2 = RpcArgUtils.KindMatches(typeof(T2), element.ValueKind);
			if (flag && !flag2)
			{
				return new OneOf<T1, T2>(element.Deserialize(JsonSettings.DecodeOptions));
			}
			if (flag2 && !flag)
			{
				return new OneOf<T1, T2>(element.Deserialize(JsonSettings.DecodeOptions));
			}
			try
			{
				T1 t = element.Deserialize(JsonSettings.DecodeOptions);
				if (t != null)
				{
					return new OneOf<T1, T2>(t);
				}
			}
			catch
			{
			}
			try
			{
				T2 t2 = element.Deserialize(JsonSettings.DecodeOptions);
				if (t2 != null)
				{
					return new OneOf<T1, T2>(t2);
				}
			}
			catch
			{
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(50, 3);
			defaultInterpolatedStringHandler.AppendLiteral("RpcArgUtils.FromJsonElement<");
			defaultInterpolatedStringHandler.AppendFormatted(typeof(T1).Name);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted(typeof(T2).Name);
			defaultInterpolatedStringHandler.AppendLiteral(">: ");
			defaultInterpolatedStringHandler.AppendLiteral("JSON 形态 ");
			defaultInterpolatedStringHandler.AppendFormatted<JsonValueKind>(element.ValueKind);
			defaultInterpolatedStringHandler.AppendLiteral(" 无法解析为任一分支");
			throw new ArgumentException(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0003539C File Offset: 0x0003359C
		[NullableContext(1)]
		private static bool KindMatches(Type type, JsonValueKind kind)
		{
			Type type2 = Nullable.GetUnderlyingType(type) ?? type;
			if (type2 == typeof(string))
			{
				return kind == JsonValueKind.String;
			}
			if (RpcArgUtils.IsBase64Bytes(type2))
			{
				return kind == JsonValueKind.String;
			}
			if (RpcArgUtils.IsDictionary(type2))
			{
				return kind == JsonValueKind.Object;
			}
			if (typeof(IEnumerable).IsAssignableFrom(type2))
			{
				return kind == JsonValueKind.Array;
			}
			if (type2 == typeof(bool))
			{
				return kind - JsonValueKind.True <= 1;
			}
			if (type2.IsEnum)
			{
				return kind == ((Attribute.IsDefined(type2, typeof(EnumExtensionsAttribute)) && Attribute.IsDefined(type2, typeof(JsonConverterAttribute))) ? JsonValueKind.String : JsonValueKind.Number);
			}
			if (type2.IsPrimitive || type2 == typeof(decimal))
			{
				return kind == JsonValueKind.Number;
			}
			return kind == JsonValueKind.Object;
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00035479 File Offset: 0x00033679
		[NullableContext(1)]
		private static bool IsBase64Bytes(Type t)
		{
			return t == typeof(byte[]) || t == typeof(Memory<byte>) || t == typeof(ReadOnlyMemory<byte>);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x000354B4 File Offset: 0x000336B4
		[NullableContext(1)]
		private static bool IsDictionary(Type t)
		{
			if (typeof(IDictionary).IsAssignableFrom(t))
			{
				return true;
			}
			if (RpcArgUtils.IsDictionaryGenericInterface(t))
			{
				return true;
			}
			Type[] interfaces = t.GetInterfaces();
			for (int i = 0; i < interfaces.Length; i++)
			{
				if (RpcArgUtils.IsDictionaryGenericInterface(interfaces[i]))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00035504 File Offset: 0x00033704
		[NullableContext(1)]
		private static bool IsDictionaryGenericInterface(Type i)
		{
			if (!i.IsGenericType)
			{
				return false;
			}
			Type genericTypeDefinition = i.GetGenericTypeDefinition();
			return genericTypeDefinition == typeof(IDictionary<, >) || genericTypeDefinition == typeof(IReadOnlyDictionary<, >);
		}
	}
}
