using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

// Token: 0x0200000C RID: 12
[NullableContext(1)]
[Nullable(0)]
[JsonConverter(typeof(OneOfJsonConvertor))]
public struct OneOf<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4> : IEquatable<OneOf<T1, T2, T3, T4>>, IOneOfObject
{
	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000041 RID: 65 RVA: 0x000034AC File Offset: 0x000016AC
	public readonly bool HasValue
	{
		get
		{
			return this._typeIndex > 0;
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000042 RID: 66 RVA: 0x000034B7 File Offset: 0x000016B7
	public readonly bool IsT1
	{
		get
		{
			return this._typeIndex == 1;
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000043 RID: 67 RVA: 0x000034C2 File Offset: 0x000016C2
	public readonly bool IsT2
	{
		get
		{
			return this._typeIndex == 2;
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000044 RID: 68 RVA: 0x000034CD File Offset: 0x000016CD
	public readonly bool IsT3
	{
		get
		{
			return this._typeIndex == 3;
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000045 RID: 69 RVA: 0x000034D8 File Offset: 0x000016D8
	public readonly bool IsT4
	{
		get
		{
			return this._typeIndex == 4;
		}
	}

	// Token: 0x06000046 RID: 70 RVA: 0x000034E4 File Offset: 0x000016E4
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
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000047 RID: 71 RVA: 0x00003544 File Offset: 0x00001744
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

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000048 RID: 72 RVA: 0x00003594 File Offset: 0x00001794
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

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000049 RID: 73 RVA: 0x000035E4 File Offset: 0x000017E4
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

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x0600004A RID: 74 RVA: 0x00003634 File Offset: 0x00001834
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

	// Token: 0x0600004B RID: 75 RVA: 0x00003683 File Offset: 0x00001883
	public OneOf(T1 value)
	{
		this._typeIndex = ((value != null) ? 1 : 0);
		this._value1 = value;
		this._value2 = default(T2);
		this._value3 = default(T3);
		this._value4 = default(T4);
	}

	// Token: 0x0600004C RID: 76 RVA: 0x000036C0 File Offset: 0x000018C0
	public OneOf(T2 value)
	{
		this._typeIndex = ((value == null) ? 0 : 2);
		this._value2 = value;
		this._value1 = default(T1);
		this._value3 = default(T3);
		this._value4 = default(T4);
	}

	// Token: 0x0600004D RID: 77 RVA: 0x000036FF File Offset: 0x000018FF
	public OneOf(T3 value)
	{
		this._typeIndex = ((value == null) ? 0 : 3);
		this._value3 = value;
		this._value1 = default(T1);
		this._value2 = default(T2);
		this._value4 = default(T4);
	}

	// Token: 0x0600004E RID: 78 RVA: 0x0000373E File Offset: 0x0000193E
	public OneOf(T4 value)
	{
		this._typeIndex = ((value == null) ? 0 : 4);
		this._value4 = value;
		this._value1 = default(T1);
		this._value2 = default(T2);
		this._value3 = default(T3);
	}

	// Token: 0x0600004F RID: 79 RVA: 0x0000377D File Offset: 0x0000197D
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})]
	public static implicit operator OneOf<T1, T2, T3, T4>(T1 value)
	{
		return new OneOf<T1, T2, T3, T4>(value);
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00003785 File Offset: 0x00001985
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})]
	public static implicit operator OneOf<T1, T2, T3, T4>(T2 value)
	{
		return new OneOf<T1, T2, T3, T4>(value);
	}

	// Token: 0x06000051 RID: 81 RVA: 0x0000378D File Offset: 0x0000198D
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})]
	public static implicit operator OneOf<T1, T2, T3, T4>(T3 value)
	{
		return new OneOf<T1, T2, T3, T4>(value);
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00003795 File Offset: 0x00001995
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})]
	public static implicit operator OneOf<T1, T2, T3, T4>(T4 value)
	{
		return new OneOf<T1, T2, T3, T4>(value);
	}

	// Token: 0x06000053 RID: 83 RVA: 0x0000379D File Offset: 0x0000199D
	public static explicit operator T1([Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4> oneOf)
	{
		return oneOf.AsT1;
	}

	// Token: 0x06000054 RID: 84 RVA: 0x000037A6 File Offset: 0x000019A6
	public static explicit operator T2([Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4> oneOf)
	{
		return oneOf.AsT2;
	}

	// Token: 0x06000055 RID: 85 RVA: 0x000037AF File Offset: 0x000019AF
	public static explicit operator T3([Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4> oneOf)
	{
		return oneOf.AsT3;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000037B8 File Offset: 0x000019B8
	public static explicit operator T4([Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4> oneOf)
	{
		return oneOf.AsT4;
	}

	// Token: 0x06000057 RID: 87 RVA: 0x000037C1 File Offset: 0x000019C1
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3, T4> FromT1<T>(T t1) where T : struct, T1
	{
		return new OneOf<T1, T2, T3, T4>((T1)((object)t1));
	}

	// Token: 0x06000058 RID: 88 RVA: 0x000037D3 File Offset: 0x000019D3
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3, T4> FromT2<T>(T t2) where T : struct, T2
	{
		return new OneOf<T1, T2, T3, T4>((T2)((object)t2));
	}

	// Token: 0x06000059 RID: 89 RVA: 0x000037E5 File Offset: 0x000019E5
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3, T4> FromT3<T>(T t3) where T : struct, T3
	{
		return new OneOf<T1, T2, T3, T4>((T3)((object)t3));
	}

	// Token: 0x0600005A RID: 90 RVA: 0x000037F7 File Offset: 0x000019F7
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3, T4> FromT4<T>(T t4) where T : struct, T4
	{
		return new OneOf<T1, T2, T3, T4>((T4)((object)t4));
	}

	// Token: 0x0600005B RID: 91 RVA: 0x0000380C File Offset: 0x00001A0C
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3, T4> FromT1<T>(T? t1) where T : struct, T1
	{
		if (t1 == null)
		{
			return default(OneOf<T1, T2, T3, T4>);
		}
		return new OneOf<T1, T2, T3, T4>((T1)((object)t1.Value));
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00003844 File Offset: 0x00001A44
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3, T4> FromT2<T>(T? t2) where T : struct, T2
	{
		if (t2 == null)
		{
			return default(OneOf<T1, T2, T3, T4>);
		}
		return new OneOf<T1, T2, T3, T4>((T2)((object)t2.Value));
	}

	// Token: 0x0600005D RID: 93 RVA: 0x0000387C File Offset: 0x00001A7C
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3, T4> FromT3<T>(T? t3) where T : struct, T3
	{
		if (t3 == null)
		{
			return default(OneOf<T1, T2, T3, T4>);
		}
		return new OneOf<T1, T2, T3, T4>((T3)((object)t3.Value));
	}

	// Token: 0x0600005E RID: 94 RVA: 0x000038B4 File Offset: 0x00001AB4
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})]
	public static OneOf<T1, T2, T3, T4> FromT4<T>(T? t4) where T : struct, T4
	{
		if (t4 == null)
		{
			return default(OneOf<T1, T2, T3, T4>);
		}
		return new OneOf<T1, T2, T3, T4>((T4)((object)t4.Value));
	}

	// Token: 0x0600005F RID: 95 RVA: 0x000038EC File Offset: 0x00001AEC
	public readonly TResult Match<[Nullable(2)] TResult>(Func<T1, TResult> t1, Func<T2, TResult> t2, Func<T3, TResult> t3, Func<T4, TResult> t4)
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
		default:
			throw new InvalidOperationException("Unexpected type index.");
		}
	}

	// Token: 0x06000060 RID: 96 RVA: 0x0000395C File Offset: 0x00001B5C
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
		default:
			throw new InvalidOperationException("Unexpected type index.");
		}
	}

	// Token: 0x06000061 RID: 97 RVA: 0x000039C4 File Offset: 0x00001BC4
	public readonly void Switch(Action<T1> t1, Action<T2> t2, Action<T3> t3, Action<T4> t4)
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
		default:
			throw new InvalidOperationException("Unexpected type index.");
		}
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00003A34 File Offset: 0x00001C34
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
		default:
			return string.Empty;
		}
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00003B28 File Offset: 0x00001D28
	public readonly bool Equals([Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4> other)
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
		default:
			result = true;
			break;
		}
		return result;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00003BD0 File Offset: 0x00001DD0
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
		default:
			result = 0;
			break;
		}
		return result;
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00003C50 File Offset: 0x00001E50
	[NullableContext(2)]
	public override readonly bool Equals(object obj)
	{
		if (obj is OneOf<T1, T2, T3, T4>)
		{
			OneOf<T1, T2, T3, T4> other = (OneOf<T1, T2, T3, T4>)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00003C75 File Offset: 0x00001E75
	public static bool operator ==([Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4> left, [Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4> right)
	{
		return left.Equals(right);
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00003C7F File Offset: 0x00001E7F
	public static bool operator !=([Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4> left, [Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})] OneOf<T1, T2, T3, T4> right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04000214 RID: 532
	private byte _typeIndex;

	// Token: 0x04000215 RID: 533
	private T1 _value1;

	// Token: 0x04000216 RID: 534
	private T2 _value2;

	// Token: 0x04000217 RID: 535
	private T3 _value3;

	// Token: 0x04000218 RID: 536
	private T4 _value4;
}
