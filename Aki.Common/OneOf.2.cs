using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

// Token: 0x0200000B RID: 11
[NullableContext(1)]
[Nullable(0)]
[JsonConverter(typeof(OneOfJsonConvertor))]
public struct OneOf<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3> : IEquatable<OneOf<T1, T2, T3>>, IOneOfObject
{
	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000021 RID: 33 RVA: 0x00002E9C File Offset: 0x0000109C
	public readonly bool HasValue
	{
		get
		{
			return this._typeIndex > 0;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000022 RID: 34 RVA: 0x00002EA7 File Offset: 0x000010A7
	public readonly bool IsT1
	{
		get
		{
			return this._typeIndex == 1;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000023 RID: 35 RVA: 0x00002EB2 File Offset: 0x000010B2
	public readonly bool IsT2
	{
		get
		{
			return this._typeIndex == 2;
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000024 RID: 36 RVA: 0x00002EBD File Offset: 0x000010BD
	public readonly bool IsT3
	{
		get
		{
			return this._typeIndex == 3;
		}
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002EC8 File Offset: 0x000010C8
	public void Clear()
	{
		this._typeIndex = 0;
		if (RuntimeHelpers.IsReferenceOrContainsReferences<T1>())
		{
			this._value1 = default(T1);
		}
		if (RuntimeHelpers.IsReferenceOrContainsReferences<T2>())
		{
			this._value2 = default(T2);
		}
		if (RuntimeHelpers.IsReferenceOrContainsReferences<T3>())
		{
			this._value3 = default(T3);
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000026 RID: 38 RVA: 0x00002F18 File Offset: 0x00001118
	public readonly T1 AsT1
	{
		get
		{
			if (!this.IsT1)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Value is not ");
				defaultInterpolatedStringHandler.AppendFormatted<Type>(typeof(T1));
				throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return this._value1;
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000027 RID: 39 RVA: 0x00002F68 File Offset: 0x00001168
	public readonly T2 AsT2
	{
		get
		{
			if (!this.IsT2)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Value is not ");
				defaultInterpolatedStringHandler.AppendFormatted<Type>(typeof(T2));
				throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return this._value2;
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000028 RID: 40 RVA: 0x00002FB8 File Offset: 0x000011B8
	public readonly T3 AsT3
	{
		get
		{
			if (!this.IsT3)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Value is not ");
				defaultInterpolatedStringHandler.AppendFormatted<Type>(typeof(T3));
				throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return this._value3;
		}
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00003007 File Offset: 0x00001207
	public OneOf(T1 value)
	{
		this._typeIndex = ((value != null) ? 1 : 0);
		this._value1 = value;
		this._value2 = default(T2);
		this._value3 = default(T3);
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00003038 File Offset: 0x00001238
	public OneOf(T2 value)
	{
		this._typeIndex = ((value == null) ? 0 : 2);
		this._value2 = value;
		this._value1 = default(T1);
		this._value3 = default(T3);
	}

	// Token: 0x0600002B RID: 43 RVA: 0x0000306B File Offset: 0x0000126B
	public OneOf(T3 value)
	{
		this._typeIndex = ((value == null) ? 0 : 3);
		this._value3 = value;
		this._value1 = default(T1);
		this._value2 = default(T2);
	}

	// Token: 0x0600002C RID: 44 RVA: 0x0000309E File Offset: 0x0000129E
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	public static implicit operator OneOf<T1, T2, T3>(T1 value)
	{
		return new OneOf<T1, T2, T3>(value);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x000030A6 File Offset: 0x000012A6
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	public static implicit operator OneOf<T1, T2, T3>(T2 value)
	{
		return new OneOf<T1, T2, T3>(value);
	}

	// Token: 0x0600002E RID: 46 RVA: 0x000030AE File Offset: 0x000012AE
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	public static implicit operator OneOf<T1, T2, T3>(T3 value)
	{
		return new OneOf<T1, T2, T3>(value);
	}

	// Token: 0x0600002F RID: 47 RVA: 0x000030B6 File Offset: 0x000012B6
	public static explicit operator T1([Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] OneOf<T1, T2, T3> oneOf)
	{
		return oneOf.AsT1;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x000030BF File Offset: 0x000012BF
	public static explicit operator T2([Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] OneOf<T1, T2, T3> oneOf)
	{
		return oneOf.AsT2;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x000030C8 File Offset: 0x000012C8
	public static explicit operator T3([Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] OneOf<T1, T2, T3> oneOf)
	{
		return oneOf.AsT3;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x000030D1 File Offset: 0x000012D1
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3> FromT1<T>(T t1) where T : struct, T1
	{
		return new OneOf<T1, T2, T3>((T1)((object)t1));
	}

	// Token: 0x06000033 RID: 51 RVA: 0x000030E3 File Offset: 0x000012E3
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3> FromT2<T>(T t2) where T : struct, T2
	{
		return new OneOf<T1, T2, T3>((T2)((object)t2));
	}

	// Token: 0x06000034 RID: 52 RVA: 0x000030F5 File Offset: 0x000012F5
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3> FromT3<T>(T t3) where T : struct, T3
	{
		return new OneOf<T1, T2, T3>((T3)((object)t3));
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00003108 File Offset: 0x00001308
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3> FromT1<T>(T? t1) where T : struct, T1
	{
		if (t1 == null)
		{
			return default(OneOf<T1, T2, T3>);
		}
		return new OneOf<T1, T2, T3>((T1)((object)t1.Value));
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00003140 File Offset: 0x00001340
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3> FromT2<T>(T? t2) where T : struct, T2
	{
		if (t2 == null)
		{
			return default(OneOf<T1, T2, T3>);
		}
		return new OneOf<T1, T2, T3>((T2)((object)t2.Value));
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00003178 File Offset: 0x00001378
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3> FromT3<T>(T? t3) where T : struct, T3
	{
		if (t3 == null)
		{
			return default(OneOf<T1, T2, T3>);
		}
		return new OneOf<T1, T2, T3>((T3)((object)t3.Value));
	}

	// Token: 0x06000038 RID: 56 RVA: 0x000031B0 File Offset: 0x000013B0
	public readonly TResult Match<[Nullable(2)] TResult>(Func<T1, TResult> t1, Func<T2, TResult> t2, Func<T3, TResult> t3)
	{
		switch (this._typeIndex)
		{
		case 1:
			return t1(this._value1);
		case 2:
			return t2(this._value2);
		case 3:
			return t3(this._value3);
		default:
			throw new InvalidOperationException("Unexpected type index.");
		}
	}

	// Token: 0x06000039 RID: 57 RVA: 0x0000320C File Offset: 0x0000140C
	[NullableContext(2)]
	public readonly object GetValue()
	{
		switch (this._typeIndex)
		{
		case 1:
			return this._value1;
		case 2:
			return this._value2;
		case 3:
			return this._value3;
		default:
			throw new InvalidOperationException("Unexpected type index.");
		}
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00003264 File Offset: 0x00001464
	public readonly void Switch(Action<T1> t1, Action<T2> t2, Action<T3> t3)
	{
		switch (this._typeIndex)
		{
		case 1:
			t1(this._value1);
			return;
		case 2:
			t2(this._value2);
			return;
		case 3:
			t3(this._value3);
			return;
		default:
			throw new InvalidOperationException("Unexpected type index.");
		}
	}

	// Token: 0x0600003B RID: 59 RVA: 0x000032C0 File Offset: 0x000014C0
	public override readonly string ToString()
	{
		switch (this._typeIndex)
		{
		case 1:
		{
			T1 value = this._value1;
			return ((value != null) ? value.ToString() : null) ?? string.Empty;
		}
		case 2:
		{
			T2 value2 = this._value2;
			return ((value2 != null) ? value2.ToString() : null) ?? string.Empty;
		}
		case 3:
		{
			T3 value3 = this._value3;
			return ((value3 != null) ? value3.ToString() : null) ?? string.Empty;
		}
		default:
			return string.Empty;
		}
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00003380 File Offset: 0x00001580
	public readonly bool Equals([Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] OneOf<T1, T2, T3> other)
	{
		if (this._typeIndex != other._typeIndex)
		{
			return false;
		}
		bool result;
		switch (this._typeIndex)
		{
		case 1:
			result = EqualityComparer<T1>.Default.Equals(this._value1, other._value1);
			break;
		case 2:
			result = EqualityComparer<T2>.Default.Equals(this._value2, other._value2);
			break;
		case 3:
			result = EqualityComparer<T3>.Default.Equals(this._value3, other._value3);
			break;
		default:
			result = true;
			break;
		}
		return result;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00003408 File Offset: 0x00001608
	public override readonly int GetHashCode()
	{
		int result;
		switch (this._typeIndex)
		{
		case 1:
			result = EqualityComparer<T1>.Default.GetHashCode(this._value1);
			break;
		case 2:
			result = EqualityComparer<T2>.Default.GetHashCode(this._value2);
			break;
		case 3:
			result = EqualityComparer<T3>.Default.GetHashCode(this._value3);
			break;
		default:
			result = 0;
			break;
		}
		return result;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00003470 File Offset: 0x00001670
	[NullableContext(2)]
	public override readonly bool Equals(object obj)
	{
		if (obj is OneOf<T1, T2, T3>)
		{
			OneOf<T1, T2, T3> other = (OneOf<T1, T2, T3>)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00003495 File Offset: 0x00001695
	public static bool operator ==([Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] OneOf<T1, T2, T3> left, [Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] OneOf<T1, T2, T3> right)
	{
		return left.Equals(right);
	}

	// Token: 0x06000040 RID: 64 RVA: 0x0000349F File Offset: 0x0000169F
	public static bool operator !=([Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] OneOf<T1, T2, T3> left, [Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] OneOf<T1, T2, T3> right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04000210 RID: 528
	private byte _typeIndex;

	// Token: 0x04000211 RID: 529
	private T1 _value1;

	// Token: 0x04000212 RID: 530
	private T2 _value2;

	// Token: 0x04000213 RID: 531
	private T3 _value3;
}
