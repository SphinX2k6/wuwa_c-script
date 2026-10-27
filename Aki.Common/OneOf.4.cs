using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

// Token: 0x0200000D RID: 13
[NullableContext(1)]
[Nullable(0)]
[JsonConverter(typeof(OneOfJsonConvertor))]
public struct OneOf<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5> : IEquatable<OneOf<T1, T2, T3, T4, T5>>, IOneOfObject
{
	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000068 RID: 104 RVA: 0x00003C8C File Offset: 0x00001E8C
	public readonly bool HasValue
	{
		get
		{
			return this._typeIndex > 0;
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000069 RID: 105 RVA: 0x00003C97 File Offset: 0x00001E97
	public readonly bool IsT1
	{
		get
		{
			return this._typeIndex == 1;
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x0600006A RID: 106 RVA: 0x00003CA2 File Offset: 0x00001EA2
	public readonly bool IsT2
	{
		get
		{
			return this._typeIndex == 2;
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x0600006B RID: 107 RVA: 0x00003CAD File Offset: 0x00001EAD
	public readonly bool IsT3
	{
		get
		{
			return this._typeIndex == 3;
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x0600006C RID: 108 RVA: 0x00003CB8 File Offset: 0x00001EB8
	public readonly bool IsT4
	{
		get
		{
			return this._typeIndex == 4;
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x0600006D RID: 109 RVA: 0x00003CC3 File Offset: 0x00001EC3
	public readonly bool IsT5
	{
		get
		{
			return this._typeIndex == 5;
		}
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00003CD0 File Offset: 0x00001ED0
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
		if (RuntimeHelpers.IsReferenceOrContainsReferences<T4>())
		{
			this._value4 = default(T4);
		}
		if (RuntimeHelpers.IsReferenceOrContainsReferences<T5>())
		{
			this._value5 = default(T5);
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x0600006F RID: 111 RVA: 0x00003D44 File Offset: 0x00001F44
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

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000070 RID: 112 RVA: 0x00003D94 File Offset: 0x00001F94
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

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000071 RID: 113 RVA: 0x00003DE4 File Offset: 0x00001FE4
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

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x06000072 RID: 114 RVA: 0x00003E34 File Offset: 0x00002034
	public readonly T4 AsT4
	{
		get
		{
			if (!this.IsT4)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Value is not ");
				defaultInterpolatedStringHandler.AppendFormatted<Type>(typeof(T4));
				throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return this._value4;
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000073 RID: 115 RVA: 0x00003E84 File Offset: 0x00002084
	public readonly T5 AsT5
	{
		get
		{
			if (!this.IsT5)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Value is not ");
				defaultInterpolatedStringHandler.AppendFormatted<Type>(typeof(T5));
				throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return this._value5;
		}
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00003ED4 File Offset: 0x000020D4
	public OneOf(T1 value)
	{
		this._typeIndex = ((value != null) ? 1 : 0);
		this._value1 = value;
		this._value2 = default(T2);
		this._value3 = default(T3);
		this._value4 = default(T4);
		this._value5 = default(T5);
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00003F28 File Offset: 0x00002128
	public OneOf(T2 value)
	{
		this._typeIndex = ((value == null) ? 0 : 2);
		this._value2 = value;
		this._value1 = default(T1);
		this._value3 = default(T3);
		this._value4 = default(T4);
		this._value5 = default(T5);
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00003F80 File Offset: 0x00002180
	public OneOf(T3 value)
	{
		this._typeIndex = ((value == null) ? 0 : 3);
		this._value3 = value;
		this._value1 = default(T1);
		this._value2 = default(T2);
		this._value4 = default(T4);
		this._value5 = default(T5);
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00003FD8 File Offset: 0x000021D8
	public OneOf(T4 value)
	{
		this._typeIndex = ((value == null) ? 0 : 4);
		this._value4 = value;
		this._value1 = default(T1);
		this._value2 = default(T2);
		this._value3 = default(T3);
		this._value5 = default(T5);
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00004030 File Offset: 0x00002230
	public OneOf(T5 value)
	{
		this._typeIndex = ((value == null) ? 0 : 5);
		this._value5 = value;
		this._value1 = default(T1);
		this._value2 = default(T2);
		this._value3 = default(T3);
		this._value4 = default(T4);
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00004086 File Offset: 0x00002286
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})]
	public static implicit operator OneOf<T1, T2, T3, T4, T5>(T1 value)
	{
		return new OneOf<T1, T2, T3, T4, T5>(value);
	}

	// Token: 0x0600007A RID: 122 RVA: 0x0000408E File Offset: 0x0000228E
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})]
	public static implicit operator OneOf<T1, T2, T3, T4, T5>(T2 value)
	{
		return new OneOf<T1, T2, T3, T4, T5>(value);
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00004096 File Offset: 0x00002296
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})]
	public static implicit operator OneOf<T1, T2, T3, T4, T5>(T3 value)
	{
		return new OneOf<T1, T2, T3, T4, T5>(value);
	}

	// Token: 0x0600007C RID: 124 RVA: 0x0000409E File Offset: 0x0000229E
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})]
	public static implicit operator OneOf<T1, T2, T3, T4, T5>(T4 value)
	{
		return new OneOf<T1, T2, T3, T4, T5>(value);
	}

	// Token: 0x0600007D RID: 125 RVA: 0x000040A6 File Offset: 0x000022A6
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})]
	public static implicit operator OneOf<T1, T2, T3, T4, T5>(T5 value)
	{
		return new OneOf<T1, T2, T3, T4, T5>(value);
	}

	// Token: 0x0600007E RID: 126 RVA: 0x000040AE File Offset: 0x000022AE
	public static explicit operator T1([Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4, T5> oneOf)
	{
		return oneOf.AsT1;
	}

	// Token: 0x0600007F RID: 127 RVA: 0x000040B7 File Offset: 0x000022B7
	public static explicit operator T2([Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4, T5> oneOf)
	{
		return oneOf.AsT2;
	}

	// Token: 0x06000080 RID: 128 RVA: 0x000040C0 File Offset: 0x000022C0
	public static explicit operator T3([Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4, T5> oneOf)
	{
		return oneOf.AsT3;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x000040C9 File Offset: 0x000022C9
	public static explicit operator T4([Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4, T5> oneOf)
	{
		return oneOf.AsT4;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x000040D2 File Offset: 0x000022D2
	public static explicit operator T5([Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4, T5> oneOf)
	{
		return oneOf.AsT5;
	}

	// Token: 0x06000083 RID: 131 RVA: 0x000040DB File Offset: 0x000022DB
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3, T4, T5> FromT1<T>(T t1) where T : struct, T1
	{
		return new OneOf<T1, T2, T3, T4, T5>((T1)((object)t1));
	}

	// Token: 0x06000084 RID: 132 RVA: 0x000040ED File Offset: 0x000022ED
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3, T4, T5> FromT2<T>(T t2) where T : struct, T2
	{
		return new OneOf<T1, T2, T3, T4, T5>((T2)((object)t2));
	}

	// Token: 0x06000085 RID: 133 RVA: 0x000040FF File Offset: 0x000022FF
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3, T4, T5> FromT3<T>(T t3) where T : struct, T3
	{
		return new OneOf<T1, T2, T3, T4, T5>((T3)((object)t3));
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00004111 File Offset: 0x00002311
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3, T4, T5> FromT4<T>(T t4) where T : struct, T4
	{
		return new OneOf<T1, T2, T3, T4, T5>((T4)((object)t4));
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00004123 File Offset: 0x00002323
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3, T4, T5> FromT5<T>(T t5) where T : struct, T5
	{
		return new OneOf<T1, T2, T3, T4, T5>((T5)((object)t5));
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00004138 File Offset: 0x00002338
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3, T4, T5> FromT1<T>(T? t1) where T : struct, T1
	{
		if (t1 == null)
		{
			return default(OneOf<T1, T2, T3, T4, T5>);
		}
		return new OneOf<T1, T2, T3, T4, T5>((T1)((object)t1.Value));
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00004170 File Offset: 0x00002370
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3, T4, T5> FromT2<T>(T? t2) where T : struct, T2
	{
		if (t2 == null)
		{
			return default(OneOf<T1, T2, T3, T4, T5>);
		}
		return new OneOf<T1, T2, T3, T4, T5>((T2)((object)t2.Value));
	}

	// Token: 0x0600008A RID: 138 RVA: 0x000041A8 File Offset: 0x000023A8
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3, T4, T5> FromT3<T>(T? t3) where T : struct, T3
	{
		if (t3 == null)
		{
			return default(OneOf<T1, T2, T3, T4, T5>);
		}
		return new OneOf<T1, T2, T3, T4, T5>((T3)((object)t3.Value));
	}

	// Token: 0x0600008B RID: 139 RVA: 0x000041E0 File Offset: 0x000023E0
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3, T4, T5> FromT4<T>(T? t4) where T : struct, T4
	{
		if (t4 == null)
		{
			return default(OneOf<T1, T2, T3, T4, T5>);
		}
		return new OneOf<T1, T2, T3, T4, T5>((T4)((object)t4.Value));
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00004218 File Offset: 0x00002418
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3, T4, T5> FromT5<T>(T? t5) where T : struct, T5
	{
		if (t5 == null)
		{
			return default(OneOf<T1, T2, T3, T4, T5>);
		}
		return new OneOf<T1, T2, T3, T4, T5>((T5)((object)t5.Value));
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00004250 File Offset: 0x00002450
	public readonly TResult Match<[Nullable(2)] TResult>(Func<T1, TResult> t1, Func<T2, TResult> t2, Func<T3, TResult> t3, Func<T4, TResult> t4, Func<T5, TResult> t5)
	{
		switch (this._typeIndex)
		{
		case 1:
			return t1(this._value1);
		case 2:
			return t2(this._value2);
		case 3:
			return t3(this._value3);
		case 4:
			return t4(this._value4);
		case 5:
			return t5(this._value5);
		default:
			throw new InvalidOperationException("Unexpected type index.");
		}
	}

	// Token: 0x0600008E RID: 142 RVA: 0x000042D0 File Offset: 0x000024D0
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
		case 4:
			return this._value4;
		case 5:
			return this._value5;
		default:
			throw new InvalidOperationException("Unexpected type index.");
		}
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00004348 File Offset: 0x00002548
	public readonly void Switch(Action<T1> t1, Action<T2> t2, Action<T3> t3, Action<T4> t4, Action<T5> t5)
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
		case 4:
			t4(this._value4);
			return;
		case 5:
			t5(this._value5);
			return;
		default:
			throw new InvalidOperationException("Unexpected type index.");
		}
	}

	// Token: 0x06000090 RID: 144 RVA: 0x000043C8 File Offset: 0x000025C8
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
		case 4:
		{
			T4 value4 = this._value4;
			return ((value4 != null) ? value4.ToString() : null) ?? string.Empty;
		}
		case 5:
		{
			T5 value5 = this._value5;
			return ((value5 != null) ? value5.ToString() : null) ?? string.Empty;
		}
		default:
			return string.Empty;
		}
	}

	// Token: 0x06000091 RID: 145 RVA: 0x000044F0 File Offset: 0x000026F0
	public readonly bool Equals([Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4, T5> other)
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
		case 4:
			result = EqualityComparer<T4>.Default.Equals(this._value4, other._value4);
			break;
		case 5:
			result = EqualityComparer<T5>.Default.Equals(this._value5, other._value5);
			break;
		default:
			result = true;
			break;
		}
		return result;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x000045B4 File Offset: 0x000027B4
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
		case 4:
			result = EqualityComparer<T4>.Default.GetHashCode(this._value4);
			break;
		case 5:
			result = EqualityComparer<T5>.Default.GetHashCode(this._value5);
			break;
		default:
			result = 0;
			break;
		}
		return result;
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00004648 File Offset: 0x00002848
	[NullableContext(2)]
	public override readonly bool Equals(object obj)
	{
		if (obj is OneOf<T1, T2, T3, T4, T5>)
		{
			OneOf<T1, T2, T3, T4, T5> other = (OneOf<T1, T2, T3, T4, T5>)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x06000094 RID: 148 RVA: 0x0000466D File Offset: 0x0000286D
	public static bool operator ==([Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4, T5> left, [Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4, T5> right)
	{
		return left.Equals(right);
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00004677 File Offset: 0x00002877
	public static bool operator !=([Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4, T5> left, [Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4, T5> right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04000219 RID: 537
	private byte _typeIndex;

	// Token: 0x0400021A RID: 538
	private T1 _value1;

	// Token: 0x0400021B RID: 539
	private T2 _value2;

	// Token: 0x0400021C RID: 540
	private T3 _value3;

	// Token: 0x0400021D RID: 541
	private T4 _value4;

	// Token: 0x0400021E RID: 542
	private T5 _value5;
}
