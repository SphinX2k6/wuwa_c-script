using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

// Token: 0x0200000A RID: 10
[NullableContext(1)]
[Nullable(0)]
[JsonConverter(typeof(OneOfJsonConvertor))]
public struct OneOf<[Nullable(2)] T1, [Nullable(2)] T2> : IEquatable<OneOf<T1, T2>>, IOneOfObject
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000008 RID: 8 RVA: 0x00002A71 File Offset: 0x00000C71
	public readonly bool HasValue
	{
		get
		{
			return this._typeIndex > 0;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000009 RID: 9 RVA: 0x00002A7C File Offset: 0x00000C7C
	public readonly bool IsT1
	{
		get
		{
			return this._typeIndex == 1;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600000A RID: 10 RVA: 0x00002A87 File Offset: 0x00000C87
	public readonly bool IsT2
	{
		get
		{
			return this._typeIndex == 2;
		}
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002A92 File Offset: 0x00000C92
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
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600000C RID: 12 RVA: 0x00002AC4 File Offset: 0x00000CC4
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

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600000D RID: 13 RVA: 0x00002B14 File Offset: 0x00000D14
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

	// Token: 0x0600000E RID: 14 RVA: 0x00002B63 File Offset: 0x00000D63
	public OneOf(T1 value)
	{
		this._typeIndex = ((value != null) ? 1 : 0);
		this._value1 = value;
		this._value2 = default(T2);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002B88 File Offset: 0x00000D88
	public OneOf(T2 value)
	{
		this._typeIndex = ((value == null) ? 0 : 2);
		this._value2 = value;
		this._value1 = default(T1);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002BAF File Offset: 0x00000DAF
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public static implicit operator OneOf<T1, T2>(T1 value)
	{
		return new OneOf<T1, T2>(value);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002BB7 File Offset: 0x00000DB7
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public static implicit operator OneOf<T1, T2>(T2 value)
	{
		return new OneOf<T1, T2>(value);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002BBF File Offset: 0x00000DBF
	public static explicit operator T1([Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<T1, T2> oneOf)
	{
		return oneOf.AsT1;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002BC8 File Offset: 0x00000DC8
	public static explicit operator T2([Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<T1, T2> oneOf)
	{
		return oneOf.AsT2;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002BD1 File Offset: 0x00000DD1
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public static OneOf<T1, T2> FromT1<T>(T t1) where T : struct, T1
	{
		return new OneOf<T1, T2>((T1)((object)t1));
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002BE3 File Offset: 0x00000DE3
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public static OneOf<T1, T2> FromT2<T>(T t2) where T : struct, T2
	{
		return new OneOf<T1, T2>((T2)((object)t2));
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002BF8 File Offset: 0x00000DF8
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public static OneOf<T1, T2> FromT1<T>(T? t1) where T : struct, T1
	{
		if (t1 == null)
		{
			return default(OneOf<T1, T2>);
		}
		return new OneOf<T1, T2>((T1)((object)t1.Value));
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002C30 File Offset: 0x00000E30
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public static OneOf<T1, T2> FromT2<T>(T? t2) where T : struct, T2
	{
		if (t2 == null)
		{
			return default(OneOf<T1, T2>);
		}
		return new OneOf<T1, T2>((T2)((object)t2.Value));
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002C68 File Offset: 0x00000E68
	public readonly TResult Match<[Nullable(2)] TResult>(Func<T1, TResult> t1, Func<T2, TResult> t2)
	{
		byte typeIndex = this._typeIndex;
		if (typeIndex == 1)
		{
			return t1(this._value1);
		}
		if (typeIndex != 2)
		{
			throw new InvalidOperationException("Unexpected type index.");
		}
		return t2(this._value2);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002CAC File Offset: 0x00000EAC
	[NullableContext(2)]
	public readonly object GetValue()
	{
		byte typeIndex = this._typeIndex;
		if (typeIndex == 1)
		{
			return this._value1;
		}
		if (typeIndex != 2)
		{
			throw new InvalidOperationException("Unexpected type index.");
		}
		return this._value2;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002CEC File Offset: 0x00000EEC
	public readonly void Switch(Action<T1> t1, Action<T2> t2)
	{
		byte typeIndex = this._typeIndex;
		if (typeIndex == 1)
		{
			t1(this._value1);
			return;
		}
		if (typeIndex != 2)
		{
			throw new InvalidOperationException("Unexpected type index.");
		}
		t2(this._value2);
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002D30 File Offset: 0x00000F30
	public override readonly string ToString()
	{
		byte typeIndex = this._typeIndex;
		if (typeIndex == 1)
		{
			T1 value = this._value1;
			return ((value != null) ? value.ToString() : null) ?? string.Empty;
		}
		if (typeIndex != 2)
		{
			return string.Empty;
		}
		T2 value2 = this._value2;
		return ((value2 != null) ? value2.ToString() : null) ?? string.Empty;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002DB4 File Offset: 0x00000FB4
	public readonly bool Equals([Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<T1, T2> other)
	{
		if (this._typeIndex != other._typeIndex)
		{
			return false;
		}
		byte typeIndex = this._typeIndex;
		bool result;
		if (typeIndex != 1)
		{
			result = (typeIndex != 2 || EqualityComparer<T2>.Default.Equals(this._value2, other._value2));
		}
		else
		{
			result = EqualityComparer<T1>.Default.Equals(this._value1, other._value1);
		}
		return result;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002E18 File Offset: 0x00001018
	public override readonly int GetHashCode()
	{
		byte typeIndex = this._typeIndex;
		int result;
		if (typeIndex != 1)
		{
			if (typeIndex != 2)
			{
				result = 0;
			}
			else
			{
				result = EqualityComparer<T2>.Default.GetHashCode(this._value2);
			}
		}
		else
		{
			result = EqualityComparer<T1>.Default.GetHashCode(this._value1);
		}
		return result;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002E60 File Offset: 0x00001060
	[NullableContext(2)]
	public override readonly bool Equals(object obj)
	{
		if (obj is OneOf<T1, T2>)
		{
			OneOf<T1, T2> other = (OneOf<T1, T2>)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002E85 File Offset: 0x00001085
	public static bool operator ==([Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<T1, T2> left, [Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<T1, T2> right)
	{
		return left.Equals(right);
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002E8F File Offset: 0x0000108F
	public static bool operator !=([Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<T1, T2> left, [Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<T1, T2> right)
	{
		return !left.Equals(right);
	}

	// Token: 0x0400020D RID: 525
	private byte _typeIndex;

	// Token: 0x0400020E RID: 526
	private T1 _value1;

	// Token: 0x0400020F RID: 527
	private T2 _value2;
}
