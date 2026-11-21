using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

// Token: 0x0200003D RID: 61
[JsonConverter(typeof(NumberConverter))]
[Obsolete("请尽量用明确的数值类型")]
[StructLayout(LayoutKind.Explicit)]
public struct Number
{
	// Token: 0x0600015D RID: 349 RVA: 0x0000984C File Offset: 0x00007A4C
	private static bool IsZero(Number value)
	{
		if (value.IsInt())
		{
			return value.GetInt() == 0;
		}
		if (value.IsDouble())
		{
			return Math.Abs(value.GetDouble()) < 2.2250738585072014E-308;
		}
		return Math.Abs(value.GetFloat()) < 1.1754944E-38f;
	}

	// Token: 0x0600015E RID: 350 RVA: 0x000098A1 File Offset: 0x00007AA1
	private static double GetEqualityThreshold(Number a, Number b)
	{
		if (!a.IsDouble() && !b.IsDouble())
		{
			return 1.1754943508222875E-38;
		}
		return 2.2250738585072014E-308;
	}

	// Token: 0x0600015F RID: 351 RVA: 0x000098C8 File Offset: 0x00007AC8
	private Number(long value, byte tag)
	{
		this._floatValue = 0f;
		this._doubleValue = 0.0;
		this._longValue = value;
		this._typeTag = tag;
	}

	// Token: 0x06000160 RID: 352 RVA: 0x000098F2 File Offset: 0x00007AF2
	public static Number FromInt(int value)
	{
		return new Number((long)value, 0);
	}

	// Token: 0x06000161 RID: 353 RVA: 0x000098FC File Offset: 0x00007AFC
	public static Number FromDouble(double value)
	{
		return new Number(0L, 1)
		{
			_doubleValue = value
		};
	}

	// Token: 0x06000162 RID: 354 RVA: 0x0000991C File Offset: 0x00007B1C
	public static Number FromFloat(float value)
	{
		return new Number(0L, 2)
		{
			_floatValue = value
		};
	}

	// Token: 0x06000163 RID: 355 RVA: 0x0000993C File Offset: 0x00007B3C
	public bool IsInt()
	{
		return this._typeTag == 0;
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00009947 File Offset: 0x00007B47
	public bool IsDouble()
	{
		return this._typeTag == 1;
	}

	// Token: 0x06000165 RID: 357 RVA: 0x00009952 File Offset: 0x00007B52
	public bool IsFloat()
	{
		return this._typeTag == 2;
	}

	// Token: 0x06000166 RID: 358 RVA: 0x0000995D File Offset: 0x00007B5D
	public bool IsNaN()
	{
		return (this.IsDouble() && double.IsNaN(this._doubleValue)) || (this.IsFloat() && float.IsNaN(this._floatValue));
	}

	// Token: 0x06000167 RID: 359 RVA: 0x0000998B File Offset: 0x00007B8B
	public bool IsInfinity()
	{
		if (this.IsDouble())
		{
			return double.IsInfinity(this._doubleValue);
		}
		return this.IsFloat() && float.IsInfinity(this._floatValue);
	}

	// Token: 0x06000168 RID: 360 RVA: 0x000099B6 File Offset: 0x00007BB6
	public int GetInt()
	{
		if (!this.IsInt())
		{
			throw new InvalidOperationException("Number is not an integer");
		}
		return (int)this._longValue;
	}

	// Token: 0x06000169 RID: 361 RVA: 0x000099D2 File Offset: 0x00007BD2
	public long GetLong()
	{
		if (!this.IsInt())
		{
			throw new InvalidOperationException("Number is not an integer");
		}
		return this._longValue;
	}

	// Token: 0x0600016A RID: 362 RVA: 0x000099F0 File Offset: 0x00007BF0
	public double GetDouble()
	{
		byte typeTag = this._typeTag;
		double result;
		if (typeTag != 1)
		{
			if (typeTag != 2)
			{
				result = (double)this._longValue;
			}
			else
			{
				result = (double)this._floatValue;
			}
		}
		else
		{
			result = this._doubleValue;
		}
		return result;
	}

	// Token: 0x0600016B RID: 363 RVA: 0x00009A2C File Offset: 0x00007C2C
	public float GetFloat()
	{
		byte typeTag = this._typeTag;
		float result;
		if (typeTag != 1)
		{
			if (typeTag == 2)
			{
				result = this._floatValue;
			}
			else
			{
				result = (float)this._longValue;
			}
		}
		else
		{
			result = (float)this._doubleValue;
		}
		return result;
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00009A64 File Offset: 0x00007C64
	public static implicit operator Number(int value)
	{
		return Number.FromInt(value);
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00009A6C File Offset: 0x00007C6C
	public static implicit operator Number(double value)
	{
		return Number.FromDouble(value);
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00009A74 File Offset: 0x00007C74
	public static implicit operator Number(float value)
	{
		return Number.FromFloat(value);
	}

	// Token: 0x0600016F RID: 367 RVA: 0x00009A7C File Offset: 0x00007C7C
	public static implicit operator int(Number number)
	{
		return number.GetInt();
	}

	// Token: 0x06000170 RID: 368 RVA: 0x00009A85 File Offset: 0x00007C85
	public static implicit operator double(Number number)
	{
		return number.GetDouble();
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00009A8E File Offset: 0x00007C8E
	public static implicit operator float(Number number)
	{
		return number.GetFloat();
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00009A98 File Offset: 0x00007C98
	public static Number operator +(Number a, Number b)
	{
		if (a.IsDouble() || b.IsDouble())
		{
			return Number.FromDouble(a.GetDouble() + b.GetDouble());
		}
		if (!a.IsFloat() && !b.IsFloat())
		{
			return Number.FromInt(a.GetInt() + b.GetInt());
		}
		return Number.FromFloat(a.GetFloat() + b.GetFloat());
	}

	// Token: 0x06000173 RID: 371 RVA: 0x00009B08 File Offset: 0x00007D08
	public static Number operator -(Number a, Number b)
	{
		if (a.IsDouble() || b.IsDouble())
		{
			return Number.FromDouble(a.GetDouble() - b.GetDouble());
		}
		if (!a.IsFloat() && !b.IsFloat())
		{
			return Number.FromInt(a.GetInt() - b.GetInt());
		}
		return Number.FromFloat(a.GetFloat() - b.GetFloat());
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00009B78 File Offset: 0x00007D78
	public static Number operator *(Number a, Number b)
	{
		if (a.IsDouble() || b.IsDouble())
		{
			return Number.FromDouble(a.GetDouble() * b.GetDouble());
		}
		if (!a.IsFloat() && !b.IsFloat())
		{
			return Number.FromInt(a.GetInt() * b.GetInt());
		}
		return Number.FromFloat(a.GetFloat() * b.GetFloat());
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00009BE8 File Offset: 0x00007DE8
	public static Number operator /(Number a, Number b)
	{
		if (Number.IsZero(b))
		{
			throw new DivideByZeroException("Cannot divide by zero");
		}
		if (a.IsDouble() || b.IsDouble())
		{
			return Number.FromDouble(a.GetDouble() / b.GetDouble());
		}
		if (a.IsFloat() || b.IsFloat())
		{
			return Number.FromFloat(a.GetFloat() / b.GetFloat());
		}
		return Number.FromDouble(a.GetDouble() / b.GetDouble());
	}

	// Token: 0x06000176 RID: 374 RVA: 0x00009C6C File Offset: 0x00007E6C
	public static Number operator %(Number a, Number b)
	{
		if (Number.IsZero(b))
		{
			throw new DivideByZeroException("Cannot modulo by zero");
		}
		if (a.IsDouble() || b.IsDouble())
		{
			return Number.FromDouble(a.GetDouble() % b.GetDouble());
		}
		if (a.IsFloat() || b.IsFloat())
		{
			return Number.FromFloat(a.GetFloat() % b.GetFloat());
		}
		return Number.FromInt(a.GetInt() % b.GetInt());
	}

	// Token: 0x06000177 RID: 375 RVA: 0x00009CF0 File Offset: 0x00007EF0
	public static Number operator ++(Number a)
	{
		if (a.IsDouble())
		{
			return Number.FromDouble(a.GetDouble() + 1.0);
		}
		if (a.IsFloat())
		{
			return Number.FromFloat(a.GetFloat() + 1f);
		}
		return Number.FromInt(a.GetInt() + 1);
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00009D48 File Offset: 0x00007F48
	public static Number operator --(Number a)
	{
		if (a.IsDouble())
		{
			return Number.FromDouble(a.GetDouble() - 1.0);
		}
		if (a.IsFloat())
		{
			return Number.FromFloat(a.GetFloat() - 1f);
		}
		return Number.FromInt(a.GetInt() - 1);
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00009DA0 File Offset: 0x00007FA0
	public static bool operator ==(Number a, Number b)
	{
		if (a.IsInt() && b.IsInt())
		{
			return a.GetInt() == b.GetInt();
		}
		return Math.Abs(a.GetDouble() - b.GetDouble()) < Number.GetEqualityThreshold(a, b);
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00009DED File Offset: 0x00007FED
	public static bool operator !=(Number a, Number b)
	{
		return !(a == b);
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00009DF9 File Offset: 0x00007FF9
	public static bool operator >(Number a, Number b)
	{
		return a.GetDouble() > b.GetDouble();
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00009E0B File Offset: 0x0000800B
	public static bool operator <=(Number a, Number b)
	{
		return a.GetDouble() <= b.GetDouble();
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00009E20 File Offset: 0x00008020
	public static bool operator >=(Number a, Number b)
	{
		return a.GetDouble() >= b.GetDouble();
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00009E35 File Offset: 0x00008035
	public static bool operator <(Number a, Number b)
	{
		return a.GetDouble() < b.GetDouble();
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00009E48 File Offset: 0x00008048
	[NullableContext(1)]
	public override string ToString()
	{
		byte typeTag = this._typeTag;
		string result;
		if (typeTag != 0)
		{
			if (typeTag != 2)
			{
				result = this.GetDouble().ToString();
			}
			else
			{
				result = this.GetFloat().ToString();
			}
		}
		else
		{
			result = this.GetInt().ToString();
		}
		return result;
	}

	// Token: 0x0400016F RID: 367
	[FieldOffset(0)]
	private long _longValue;

	// Token: 0x04000170 RID: 368
	[FieldOffset(0)]
	private double _doubleValue;

	// Token: 0x04000171 RID: 369
	[FieldOffset(0)]
	private float _floatValue;

	// Token: 0x04000172 RID: 370
	[FieldOffset(8)]
	private byte _typeTag;

	// Token: 0x04000173 RID: 371
	private const byte IntTag = 0;

	// Token: 0x04000174 RID: 372
	private const byte DoubleTag = 1;

	// Token: 0x04000175 RID: 373
	private const byte FloatTag = 2;

	// Token: 0x04000176 RID: 374
	private const long TagMask = 255L;
}
