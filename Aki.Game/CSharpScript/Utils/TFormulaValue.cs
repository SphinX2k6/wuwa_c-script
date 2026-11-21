using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x0200340C RID: 13324
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct TFormulaValue
	{
		// Token: 0x17004664 RID: 18020
		// (get) Token: 0x06021DC3 RID: 138691 RVA: 0x0096D5AF File Offset: 0x0096B7AF
		public EFormulaValueType Type { get; }

		// Token: 0x06021DC4 RID: 138692 RVA: 0x0096D5B8 File Offset: 0x0096B7B8
		[NullableContext(2)]
		private TFormulaValue(EFormulaValueType type, double doubleValue = 0.0, bool boolValue = false, string stringValue = null, Entity entityValue = null, double[] doubleArrayValue = null, ContextParam contextValue = null, [Nullable(new byte[]
		{
			2,
			1
		})] string[] stringArrayValue = null, TagContainer tagContainerValue = null, Vector vectorValue = null, Rotator rotatorValue = null)
		{
			this.Type = type;
			this._doubleValue = doubleValue;
			this._boolValue = boolValue;
			this._stringValue = stringValue;
			this._entityValue = entityValue;
			this._doubleArrayValue = doubleArrayValue;
			this._contextValue = contextValue;
			this._stringArrayValue = stringArrayValue;
			this._tagContainerValue = tagContainerValue;
			this._vectorValue = vectorValue;
			this._rotatorValue = rotatorValue;
		}

		// Token: 0x17004665 RID: 18021
		// (get) Token: 0x06021DC5 RID: 138693 RVA: 0x0096D61A File Offset: 0x0096B81A
		public bool IsNull
		{
			get
			{
				return this.Type == EFormulaValueType.None;
			}
		}

		// Token: 0x06021DC6 RID: 138694 RVA: 0x0096D628 File Offset: 0x0096B828
		public static TFormulaValue FromInt(int value)
		{
			return new TFormulaValue(EFormulaValueType.Double, (double)value, false, null, null, null, null, null, null, null, null);
		}

		// Token: 0x06021DC7 RID: 138695 RVA: 0x0096D648 File Offset: 0x0096B848
		public static TFormulaValue FromLong(long value)
		{
			return new TFormulaValue(EFormulaValueType.Double, (double)value, false, null, null, null, null, null, null, null, null);
		}

		// Token: 0x06021DC8 RID: 138696 RVA: 0x0096D668 File Offset: 0x0096B868
		public static TFormulaValue FromFloat(float value)
		{
			return new TFormulaValue(EFormulaValueType.Double, (double)value, false, null, null, null, null, null, null, null, null);
		}

		// Token: 0x06021DC9 RID: 138697 RVA: 0x0096D688 File Offset: 0x0096B888
		public static TFormulaValue FromDouble(double value)
		{
			return new TFormulaValue(EFormulaValueType.Double, value, false, null, null, null, null, null, null, null, null);
		}

		// Token: 0x06021DCA RID: 138698 RVA: 0x0096D6A8 File Offset: 0x0096B8A8
		public static TFormulaValue FromBool(bool value)
		{
			return new TFormulaValue(EFormulaValueType.Bool, 0.0, value, null, null, null, null, null, null, null, null);
		}

		// Token: 0x06021DCB RID: 138699 RVA: 0x0096D6D0 File Offset: 0x0096B8D0
		public static TFormulaValue FromString(string value)
		{
			return new TFormulaValue(EFormulaValueType.String, 0.0, false, value, null, null, null, null, null, null, null);
		}

		// Token: 0x06021DCC RID: 138700 RVA: 0x0096D6F8 File Offset: 0x0096B8F8
		public static TFormulaValue FromEntity(Entity value)
		{
			return new TFormulaValue(EFormulaValueType.Entity, 0.0, false, null, value, null, null, null, null, null, null);
		}

		// Token: 0x06021DCD RID: 138701 RVA: 0x0096D720 File Offset: 0x0096B920
		public static TFormulaValue FromIntArray(int[] value)
		{
			return new TFormulaValue(EFormulaValueType.DoubleArray, 0.0, false, null, null, Array.ConvertAll<int, double>(value, (int v) => (double)v), null, null, null, null, null);
		}

		// Token: 0x06021DCE RID: 138702 RVA: 0x0096D76C File Offset: 0x0096B96C
		public static TFormulaValue FromLongArray(long[] value)
		{
			return new TFormulaValue(EFormulaValueType.DoubleArray, 0.0, false, null, null, Array.ConvertAll<long, double>(value, (long v) => (double)v), null, null, null, null, null);
		}

		// Token: 0x06021DCF RID: 138703 RVA: 0x0096D7B8 File Offset: 0x0096B9B8
		public static TFormulaValue FromDoubleArray(double[] value)
		{
			return new TFormulaValue(EFormulaValueType.DoubleArray, 0.0, false, null, null, value, null, null, null, null, null);
		}

		// Token: 0x06021DD0 RID: 138704 RVA: 0x0096D7E0 File Offset: 0x0096B9E0
		[NullableContext(2)]
		public static TFormulaValue FromContext(ContextParam value)
		{
			if (value != null)
			{
				return new TFormulaValue(EFormulaValueType.Context, 0.0, false, null, null, null, value, null, null, null, null);
			}
			return default(TFormulaValue);
		}

		// Token: 0x06021DD1 RID: 138705 RVA: 0x0096D814 File Offset: 0x0096BA14
		public static TFormulaValue FromStringArray(string[] value)
		{
			return new TFormulaValue(EFormulaValueType.StringArray, 0.0, false, null, null, null, null, value, null, null, null);
		}

		// Token: 0x06021DD2 RID: 138706 RVA: 0x0096D83C File Offset: 0x0096BA3C
		public static TFormulaValue FromTagContainer(TagContainer value)
		{
			return new TFormulaValue(EFormulaValueType.TagContainer, 0.0, false, null, null, null, null, null, value, null, null);
		}

		// Token: 0x06021DD3 RID: 138707 RVA: 0x0096D864 File Offset: 0x0096BA64
		public static TFormulaValue FromVector(Vector value)
		{
			return new TFormulaValue(EFormulaValueType.Vector, 0.0, false, null, null, null, null, null, null, value, null);
		}

		// Token: 0x06021DD4 RID: 138708 RVA: 0x0096D88C File Offset: 0x0096BA8C
		public static TFormulaValue FromRotator(Rotator value)
		{
			return new TFormulaValue(EFormulaValueType.Rotator, 0.0, false, null, null, null, null, null, null, null, value);
		}

		// Token: 0x06021DD5 RID: 138709 RVA: 0x0096D8B4 File Offset: 0x0096BAB4
		public static TFormulaValue FromArrayLiteral(TFormulaValue[] values)
		{
			double[] array = new double[values.Length];
			bool flag = true;
			for (int i = 0; i < values.Length; i++)
			{
				double num;
				if (!values[i].TryGetDouble(out num))
				{
					flag = false;
					break;
				}
				array[i] = num;
			}
			if (flag)
			{
				return TFormulaValue.FromDoubleArray(array);
			}
			string[] array2 = new string[values.Length];
			for (int j = 0; j < values.Length; j++)
			{
				string text;
				if (!values[j].TryGetString(out text) || text == null)
				{
					throw new Exception("Array literal only supports number[] or string[]");
				}
				array2[j] = text;
			}
			return TFormulaValue.FromStringArray(array2);
		}

		// Token: 0x06021DD6 RID: 138710 RVA: 0x0096D944 File Offset: 0x0096BB44
		public bool TryGetInt(out int value)
		{
			if (this.Type == EFormulaValueType.Double && this._doubleValue >= -2147483648.0 && this._doubleValue <= 2147483647.0)
			{
				value = (int)this._doubleValue;
				return true;
			}
			value = 0;
			return false;
		}

		// Token: 0x06021DD7 RID: 138711 RVA: 0x0096D980 File Offset: 0x0096BB80
		public bool TryGetLong(out long value)
		{
			if (this.Type == EFormulaValueType.Double && this._doubleValue >= -9.223372036854776E+18 && this._doubleValue <= 9.223372036854776E+18)
			{
				value = (long)this._doubleValue;
				return true;
			}
			value = 0L;
			return false;
		}

		// Token: 0x06021DD8 RID: 138712 RVA: 0x0096D9BD File Offset: 0x0096BBBD
		public bool TryGetFloat(out float value)
		{
			if (this.Type == EFormulaValueType.Double && this._doubleValue >= -3.4028234663852886E+38 && this._doubleValue <= 3.4028234663852886E+38)
			{
				value = (float)this._doubleValue;
				return true;
			}
			value = 0f;
			return false;
		}

		// Token: 0x06021DD9 RID: 138713 RVA: 0x0096D9FD File Offset: 0x0096BBFD
		public bool TryGetDouble(out double value)
		{
			value = this._doubleValue;
			return this.Type == EFormulaValueType.Double;
		}

		// Token: 0x06021DDA RID: 138714 RVA: 0x0096DA10 File Offset: 0x0096BC10
		public bool TryGetBool(out bool value)
		{
			value = this._boolValue;
			return this.Type == EFormulaValueType.Bool;
		}

		// Token: 0x06021DDB RID: 138715 RVA: 0x0096DA23 File Offset: 0x0096BC23
		[NullableContext(2)]
		public bool TryGetString(out string value)
		{
			value = this._stringValue;
			return this.Type == EFormulaValueType.String;
		}

		// Token: 0x06021DDC RID: 138716 RVA: 0x0096DA36 File Offset: 0x0096BC36
		[NullableContext(2)]
		public bool TryGetEntity(out Entity value)
		{
			value = this._entityValue;
			return this.Type == EFormulaValueType.Entity;
		}

		// Token: 0x06021DDD RID: 138717 RVA: 0x0096DA4C File Offset: 0x0096BC4C
		[NullableContext(2)]
		public bool TryGetIntArray(out int[] value)
		{
			if (this.Type == EFormulaValueType.DoubleArray && this._doubleArrayValue != null)
			{
				value = Array.ConvertAll<double, int>(this._doubleArrayValue, (double element) => (int)element);
				return true;
			}
			value = null;
			return false;
		}

		// Token: 0x06021DDE RID: 138718 RVA: 0x0096DA9C File Offset: 0x0096BC9C
		[NullableContext(2)]
		public bool TryGetLongArray(out long[] value)
		{
			if (this.Type == EFormulaValueType.DoubleArray && this._doubleArrayValue != null)
			{
				value = Array.ConvertAll<double, long>(this._doubleArrayValue, (double element) => (long)element);
				return true;
			}
			value = null;
			return false;
		}

		// Token: 0x06021DDF RID: 138719 RVA: 0x0096DAEC File Offset: 0x0096BCEC
		[NullableContext(2)]
		public bool TryGetDoubleArray(out double[] value)
		{
			value = this._doubleArrayValue;
			return this.Type == EFormulaValueType.DoubleArray;
		}

		// Token: 0x06021DE0 RID: 138720 RVA: 0x0096DAFF File Offset: 0x0096BCFF
		[NullableContext(2)]
		public bool TryGetContext(out ContextParam value)
		{
			value = this._contextValue;
			return this.Type == EFormulaValueType.Context;
		}

		// Token: 0x06021DE1 RID: 138721 RVA: 0x0096DB12 File Offset: 0x0096BD12
		public bool TryGetStringArray([Nullable(new byte[]
		{
			2,
			1
		})] out string[] value)
		{
			value = this._stringArrayValue;
			return this.Type == EFormulaValueType.StringArray;
		}

		// Token: 0x06021DE2 RID: 138722 RVA: 0x0096DB25 File Offset: 0x0096BD25
		[NullableContext(2)]
		public bool TryGetTagContainer(out TagContainer value)
		{
			value = this._tagContainerValue;
			return this.Type == EFormulaValueType.TagContainer;
		}

		// Token: 0x06021DE3 RID: 138723 RVA: 0x0096DB38 File Offset: 0x0096BD38
		[NullableContext(2)]
		public bool TryGetVector(out Vector value)
		{
			value = this._vectorValue;
			return this.Type == EFormulaValueType.Vector;
		}

		// Token: 0x06021DE4 RID: 138724 RVA: 0x0096DB4C File Offset: 0x0096BD4C
		[NullableContext(2)]
		public bool TryGetRotator(out Rotator value)
		{
			value = this._rotatorValue;
			return this.Type == EFormulaValueType.Rotator;
		}

		// Token: 0x06021DE5 RID: 138725 RVA: 0x0096DB60 File Offset: 0x0096BD60
		public bool TryGetArrayElement(int index, out TFormulaValue value)
		{
			if (index < 0)
			{
				value = default(TFormulaValue);
				return false;
			}
			if (this.Type == EFormulaValueType.DoubleArray && this._doubleArrayValue != null && index < this._doubleArrayValue.Length)
			{
				value = TFormulaValue.FromDouble(this._doubleArrayValue[index]);
				return true;
			}
			if (this.Type == EFormulaValueType.StringArray && this._stringArrayValue != null && index < this._stringArrayValue.Length)
			{
				value = TFormulaValue.FromString(this._stringArrayValue[index]);
				return true;
			}
			value = default(TFormulaValue);
			return false;
		}

		// Token: 0x06021DE6 RID: 138726 RVA: 0x0096DBE4 File Offset: 0x0096BDE4
		public bool TryGetIndex(out int index)
		{
			if (this.Type == EFormulaValueType.Double && this._doubleValue >= -2147483648.0 && this._doubleValue <= 2147483647.0)
			{
				index = (int)this._doubleValue;
				return true;
			}
			index = -1;
			return false;
		}

		// Token: 0x06021DE7 RID: 138727 RVA: 0x0096DC20 File Offset: 0x0096BE20
		private static bool IsNumeric(TFormulaValue value)
		{
			return value.Type == EFormulaValueType.Double;
		}

		// Token: 0x06021DE8 RID: 138728 RVA: 0x0096DC2C File Offset: 0x0096BE2C
		public static TFormulaValue operator +(TFormulaValue operand)
		{
			if (!TFormulaValue.IsNumeric(operand))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Invalid unary + operand: ");
				defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(operand);
				throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return operand;
		}

		// Token: 0x06021DE9 RID: 138729 RVA: 0x0096DC70 File Offset: 0x0096BE70
		public static TFormulaValue operator -(TFormulaValue operand)
		{
			if (operand.Type == EFormulaValueType.Double)
			{
				return TFormulaValue.FromDouble(-operand._doubleValue);
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Invalid unary - operand: ");
			defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(operand);
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06021DEA RID: 138730 RVA: 0x0096DCC0 File Offset: 0x0096BEC0
		public static TFormulaValue operator !(TFormulaValue operand)
		{
			bool flag;
			if (!operand.TryGetBool(out flag))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Invalid unary ! operand: ");
				defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(operand);
				throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return TFormulaValue.FromBool(!flag);
		}

		// Token: 0x06021DEB RID: 138731 RVA: 0x0096DD0C File Offset: 0x0096BF0C
		public static TFormulaValue operator +(TFormulaValue left, TFormulaValue right)
		{
			if (left.Type == EFormulaValueType.String || right.Type == EFormulaValueType.String)
			{
				return TFormulaValue.FromString(left.ToString() + right.ToString());
			}
			if (TFormulaValue.IsNumeric(left) && TFormulaValue.IsNumeric(right))
			{
				return TFormulaValue.FromDouble((double)left + (double)right);
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Invalid operation: ");
			defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(left);
			defaultInterpolatedStringHandler.AppendLiteral(" + ");
			defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(right);
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06021DEC RID: 138732 RVA: 0x0096DDB8 File Offset: 0x0096BFB8
		public static TFormulaValue operator -(TFormulaValue left, TFormulaValue right)
		{
			if (TFormulaValue.IsNumeric(left) && TFormulaValue.IsNumeric(right))
			{
				return TFormulaValue.FromDouble((double)left - (double)right);
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Invalid operation: ");
			defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(left);
			defaultInterpolatedStringHandler.AppendLiteral(" - ");
			defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(right);
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06021DED RID: 138733 RVA: 0x0096DE28 File Offset: 0x0096C028
		public static TFormulaValue operator *(TFormulaValue left, TFormulaValue right)
		{
			if (TFormulaValue.IsNumeric(left) && TFormulaValue.IsNumeric(right))
			{
				return TFormulaValue.FromDouble((double)left * (double)right);
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Invalid operation: ");
			defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(left);
			defaultInterpolatedStringHandler.AppendLiteral(" * ");
			defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(right);
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06021DEE RID: 138734 RVA: 0x0096DE98 File Offset: 0x0096C098
		public static TFormulaValue operator /(TFormulaValue left, TFormulaValue right)
		{
			if (TFormulaValue.IsNumeric(left) && TFormulaValue.IsNumeric(right))
			{
				return TFormulaValue.FromDouble((double)left / (double)right);
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Invalid operation: ");
			defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(left);
			defaultInterpolatedStringHandler.AppendLiteral(" / ");
			defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(right);
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06021DEF RID: 138735 RVA: 0x0096DF08 File Offset: 0x0096C108
		public static TFormulaValue operator %(TFormulaValue left, TFormulaValue right)
		{
			if (TFormulaValue.IsNumeric(left) && TFormulaValue.IsNumeric(right))
			{
				return TFormulaValue.FromDouble((double)left % (double)right);
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Invalid operation: ");
			defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(left);
			defaultInterpolatedStringHandler.AppendLiteral(" % ");
			defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(right);
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06021DF0 RID: 138736 RVA: 0x0096DF78 File Offset: 0x0096C178
		public static TFormulaValue operator &(TFormulaValue left, TFormulaValue right)
		{
			bool flag;
			bool flag2;
			if (left.TryGetBool(out flag) && right.TryGetBool(out flag2))
			{
				return TFormulaValue.FromBool(flag && flag2);
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Invalid operation: ");
			defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(left);
			defaultInterpolatedStringHandler.AppendLiteral(" && ");
			defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(right);
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06021DF1 RID: 138737 RVA: 0x0096DFE4 File Offset: 0x0096C1E4
		public static TFormulaValue operator |(TFormulaValue left, TFormulaValue right)
		{
			bool flag;
			bool flag2;
			if (left.TryGetBool(out flag) && right.TryGetBool(out flag2))
			{
				return TFormulaValue.FromBool(flag || flag2);
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Invalid operation: ");
			defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(left);
			defaultInterpolatedStringHandler.AppendLiteral(" || ");
			defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(right);
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06021DF2 RID: 138738 RVA: 0x0096E04E File Offset: 0x0096C24E
		public static bool operator >(TFormulaValue left, TFormulaValue right)
		{
			return TFormulaValue.Compare(left, right) > 0;
		}

		// Token: 0x06021DF3 RID: 138739 RVA: 0x0096E05A File Offset: 0x0096C25A
		public static bool operator >=(TFormulaValue left, TFormulaValue right)
		{
			return TFormulaValue.Compare(left, right) >= 0;
		}

		// Token: 0x06021DF4 RID: 138740 RVA: 0x0096E069 File Offset: 0x0096C269
		public static bool operator <(TFormulaValue left, TFormulaValue right)
		{
			return TFormulaValue.Compare(left, right) < 0;
		}

		// Token: 0x06021DF5 RID: 138741 RVA: 0x0096E075 File Offset: 0x0096C275
		public static bool operator <=(TFormulaValue left, TFormulaValue right)
		{
			return TFormulaValue.Compare(left, right) <= 0;
		}

		// Token: 0x06021DF6 RID: 138742 RVA: 0x0096E084 File Offset: 0x0096C284
		public static bool operator ==(TFormulaValue left, TFormulaValue right)
		{
			return TFormulaValue.AreEqual(left, right);
		}

		// Token: 0x06021DF7 RID: 138743 RVA: 0x0096E08D File Offset: 0x0096C28D
		public static bool operator !=(TFormulaValue left, TFormulaValue right)
		{
			return !TFormulaValue.AreEqual(left, right);
		}

		// Token: 0x06021DF8 RID: 138744 RVA: 0x0096E09C File Offset: 0x0096C29C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is TFormulaValue)
			{
				TFormulaValue right = (TFormulaValue)obj;
				return this == right;
			}
			return false;
		}

		// Token: 0x06021DF9 RID: 138745 RVA: 0x0096E0C8 File Offset: 0x0096C2C8
		public override int GetHashCode()
		{
			switch (this.Type)
			{
			case EFormulaValueType.Double:
				return HashCode.Combine<EFormulaValueType, double>(this.Type, this._doubleValue);
			case EFormulaValueType.Bool:
				return HashCode.Combine<EFormulaValueType, bool>(this.Type, this._boolValue);
			case EFormulaValueType.String:
				return HashCode.Combine<EFormulaValueType, string>(this.Type, this._stringValue);
			case EFormulaValueType.Entity:
				return HashCode.Combine<EFormulaValueType, Entity>(this.Type, this._entityValue);
			case EFormulaValueType.DoubleArray:
			{
				EFormulaValueType type = this.Type;
				double[] doubleArrayValue = this._doubleArrayValue;
				int num = HashCode.Combine<EFormulaValueType, int>(type, (doubleArrayValue != null) ? doubleArrayValue.Length : 0);
				if (this._doubleArrayValue != null)
				{
					for (int i = 0; i < this._doubleArrayValue.Length; i++)
					{
						num = HashCode.Combine<int, double>(num, this._doubleArrayValue[i]);
					}
				}
				return num;
			}
			case EFormulaValueType.Context:
				return HashCode.Combine<EFormulaValueType, ContextParam>(this.Type, this._contextValue);
			case EFormulaValueType.StringArray:
			{
				EFormulaValueType type2 = this.Type;
				string[] stringArrayValue = this._stringArrayValue;
				int num2 = HashCode.Combine<EFormulaValueType, int>(type2, (stringArrayValue != null) ? stringArrayValue.Length : 0);
				if (this._stringArrayValue != null)
				{
					for (int j = 0; j < this._stringArrayValue.Length; j++)
					{
						num2 = HashCode.Combine<int, string>(num2, this._stringArrayValue[j]);
					}
				}
				return num2;
			}
			case EFormulaValueType.TagContainer:
				return HashCode.Combine<EFormulaValueType, TagContainer>(this.Type, this._tagContainerValue);
			case EFormulaValueType.Vector:
				return HashCode.Combine<EFormulaValueType, Vector>(this.Type, this._vectorValue);
			case EFormulaValueType.Rotator:
				return HashCode.Combine<EFormulaValueType, Rotator>(this.Type, this._rotatorValue);
			default:
				return this.Type.GetHashCode();
			}
		}

		// Token: 0x06021DFA RID: 138746 RVA: 0x0096E24C File Offset: 0x0096C44C
		private static int Compare(TFormulaValue left, TFormulaValue right)
		{
			if (!TFormulaValue.IsNumeric(left) || !TFormulaValue.IsNumeric(right))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Invalid compare operation: ");
				defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(left);
				defaultInterpolatedStringHandler.AppendLiteral(" and ");
				defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(right);
				throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			double num = (double)left - (double)right;
			if (Math.Abs(num) <= 5E-324)
			{
				return 0;
			}
			if (num <= 0.0)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x06021DFB RID: 138747 RVA: 0x0096E2DC File Offset: 0x0096C4DC
		private static bool AreEqual(TFormulaValue left, TFormulaValue right)
		{
			if (left.Type != right.Type)
			{
				return TFormulaValue.IsNumeric(left) && TFormulaValue.IsNumeric(right) && Math.Abs((double)left - (double)right) <= double.Epsilon;
			}
			switch (left.Type)
			{
			case EFormulaValueType.None:
				return true;
			case EFormulaValueType.Double:
				return Math.Abs(left._doubleValue - right._doubleValue) <= double.Epsilon;
			case EFormulaValueType.Bool:
				return left._boolValue == right._boolValue;
			case EFormulaValueType.String:
				return left._stringValue == right._stringValue;
			case EFormulaValueType.Entity:
				return left._entityValue == right._entityValue;
			case EFormulaValueType.DoubleArray:
				if (left._doubleArrayValue == null || right._doubleArrayValue == null || left._doubleArrayValue.Length != right._doubleArrayValue.Length)
				{
					return false;
				}
				for (int i = 0; i < left._doubleArrayValue.Length; i++)
				{
					if (Math.Abs(left._doubleArrayValue[i] - right._doubleArrayValue[i]) > 5E-324)
					{
						return false;
					}
				}
				return true;
			case EFormulaValueType.Context:
				return left._contextValue == right._contextValue;
			case EFormulaValueType.StringArray:
				if (left._stringArrayValue == null || right._stringArrayValue == null || left._stringArrayValue.Length != right._stringArrayValue.Length)
				{
					return false;
				}
				for (int j = 0; j < left._stringArrayValue.Length; j++)
				{
					if (!string.Equals(left._stringArrayValue[j], right._stringArrayValue[j], StringComparison.Ordinal))
					{
						return false;
					}
				}
				return true;
			case EFormulaValueType.TagContainer:
				return left._tagContainerValue == right._tagContainerValue;
			case EFormulaValueType.Vector:
				return object.Equals(left._vectorValue, right._vectorValue);
			case EFormulaValueType.Rotator:
				return object.Equals(left._rotatorValue, right._rotatorValue);
			default:
				return false;
			}
		}

		// Token: 0x06021DFC RID: 138748 RVA: 0x0096E4B8 File Offset: 0x0096C6B8
		public override string ToString()
		{
			switch (this.Type)
			{
			case EFormulaValueType.Double:
				return this._doubleValue.ToString();
			case EFormulaValueType.Bool:
				return this._boolValue.ToString();
			case EFormulaValueType.String:
				return this._stringValue ?? string.Empty;
			case EFormulaValueType.Entity:
			{
				Entity entityValue = this._entityValue;
				return ((entityValue != null) ? entityValue.ToString() : null) ?? string.Empty;
			}
			case EFormulaValueType.DoubleArray:
				if (this._doubleArrayValue != null)
				{
					return "[" + string.Join<double>(",", this._doubleArrayValue) + "]";
				}
				return "[]";
			case EFormulaValueType.Context:
			{
				ContextParam contextValue = this._contextValue;
				return ((contextValue != null) ? contextValue.ToString() : null) ?? string.Empty;
			}
			case EFormulaValueType.StringArray:
				if (this._stringArrayValue != null)
				{
					return "[" + string.Join(",", this._stringArrayValue) + "]";
				}
				return "[]";
			case EFormulaValueType.TagContainer:
			{
				TagContainer tagContainerValue = this._tagContainerValue;
				return ((tagContainerValue != null) ? tagContainerValue.ToString() : null) ?? string.Empty;
			}
			case EFormulaValueType.Vector:
			{
				Vector vectorValue = this._vectorValue;
				return ((vectorValue != null) ? vectorValue.ToString() : null) ?? string.Empty;
			}
			case EFormulaValueType.Rotator:
			{
				Rotator rotatorValue = this._rotatorValue;
				return ((rotatorValue != null) ? rotatorValue.ToString() : null) ?? string.Empty;
			}
			default:
				return string.Empty;
			}
		}

		// Token: 0x06021DFD RID: 138749 RVA: 0x0096E616 File Offset: 0x0096C816
		public static implicit operator TFormulaValue(int value)
		{
			return TFormulaValue.FromInt(value);
		}

		// Token: 0x06021DFE RID: 138750 RVA: 0x0096E61E File Offset: 0x0096C81E
		public static implicit operator TFormulaValue(long value)
		{
			return TFormulaValue.FromLong(value);
		}

		// Token: 0x06021DFF RID: 138751 RVA: 0x0096E626 File Offset: 0x0096C826
		public static implicit operator TFormulaValue(float value)
		{
			return TFormulaValue.FromFloat(value);
		}

		// Token: 0x06021E00 RID: 138752 RVA: 0x0096E62E File Offset: 0x0096C82E
		public static implicit operator TFormulaValue(double value)
		{
			return TFormulaValue.FromDouble(value);
		}

		// Token: 0x06021E01 RID: 138753 RVA: 0x0096E636 File Offset: 0x0096C836
		public static implicit operator TFormulaValue(bool value)
		{
			return TFormulaValue.FromBool(value);
		}

		// Token: 0x06021E02 RID: 138754 RVA: 0x0096E63E File Offset: 0x0096C83E
		public static implicit operator TFormulaValue(string value)
		{
			return TFormulaValue.FromString(value);
		}

		// Token: 0x06021E03 RID: 138755 RVA: 0x0096E646 File Offset: 0x0096C846
		public static implicit operator TFormulaValue(Entity value)
		{
			return TFormulaValue.FromEntity(value);
		}

		// Token: 0x06021E04 RID: 138756 RVA: 0x0096E64E File Offset: 0x0096C84E
		public static implicit operator TFormulaValue(int[] value)
		{
			return TFormulaValue.FromIntArray(value);
		}

		// Token: 0x06021E05 RID: 138757 RVA: 0x0096E656 File Offset: 0x0096C856
		public static implicit operator TFormulaValue(long[] value)
		{
			return TFormulaValue.FromLongArray(value);
		}

		// Token: 0x06021E06 RID: 138758 RVA: 0x0096E65E File Offset: 0x0096C85E
		public static implicit operator TFormulaValue(double[] value)
		{
			return TFormulaValue.FromDoubleArray(value);
		}

		// Token: 0x06021E07 RID: 138759 RVA: 0x0096E666 File Offset: 0x0096C866
		public static implicit operator TFormulaValue(string[] value)
		{
			return TFormulaValue.FromStringArray(value);
		}

		// Token: 0x06021E08 RID: 138760 RVA: 0x0096E66E File Offset: 0x0096C86E
		public static implicit operator TFormulaValue(ContextParam value)
		{
			return TFormulaValue.FromContext(value);
		}

		// Token: 0x06021E09 RID: 138761 RVA: 0x0096E676 File Offset: 0x0096C876
		public static implicit operator TFormulaValue(TagContainer value)
		{
			return TFormulaValue.FromTagContainer(value);
		}

		// Token: 0x06021E0A RID: 138762 RVA: 0x0096E67E File Offset: 0x0096C87E
		public static implicit operator TFormulaValue(Vector value)
		{
			return TFormulaValue.FromVector(value);
		}

		// Token: 0x06021E0B RID: 138763 RVA: 0x0096E686 File Offset: 0x0096C886
		public static implicit operator TFormulaValue(Rotator value)
		{
			return TFormulaValue.FromRotator(value);
		}

		// Token: 0x06021E0C RID: 138764 RVA: 0x0096E690 File Offset: 0x0096C890
		public static implicit operator long[](TFormulaValue value)
		{
			long[] array;
			if (!value.TryGetLongArray(out array) || array == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Cannot cast TFormulaValue(type=");
				defaultInterpolatedStringHandler.AppendFormatted<EFormulaValueType>(value.Type);
				defaultInterpolatedStringHandler.AppendLiteral(") to long[].");
				throw new InvalidCastException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return array;
		}

		// Token: 0x06021E0D RID: 138765 RVA: 0x0096E6EC File Offset: 0x0096C8EC
		public static explicit operator int(TFormulaValue value)
		{
			int result;
			if (!value.TryGetInt(out result))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Cannot cast TFormulaValue(type=");
				defaultInterpolatedStringHandler.AppendFormatted<EFormulaValueType>(value.Type);
				defaultInterpolatedStringHandler.AppendLiteral(") to int.");
				throw new InvalidCastException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return result;
		}

		// Token: 0x06021E0E RID: 138766 RVA: 0x0096E744 File Offset: 0x0096C944
		public static explicit operator long(TFormulaValue value)
		{
			long result;
			if (!value.TryGetLong(out result))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Cannot cast TFormulaValue(type=");
				defaultInterpolatedStringHandler.AppendFormatted<EFormulaValueType>(value.Type);
				defaultInterpolatedStringHandler.AppendLiteral(") to long.");
				throw new InvalidCastException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return result;
		}

		// Token: 0x06021E0F RID: 138767 RVA: 0x0096E79C File Offset: 0x0096C99C
		public static explicit operator float(TFormulaValue value)
		{
			float result;
			if (!value.TryGetFloat(out result))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Cannot cast TFormulaValue(type=");
				defaultInterpolatedStringHandler.AppendFormatted<EFormulaValueType>(value.Type);
				defaultInterpolatedStringHandler.AppendLiteral(") to float.");
				throw new InvalidCastException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return result;
		}

		// Token: 0x06021E10 RID: 138768 RVA: 0x0096E7F4 File Offset: 0x0096C9F4
		public static explicit operator double(TFormulaValue value)
		{
			double result;
			if (!value.TryGetDouble(out result))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Cannot cast TFormulaValue(type=");
				defaultInterpolatedStringHandler.AppendFormatted<EFormulaValueType>(value.Type);
				defaultInterpolatedStringHandler.AppendLiteral(") to double.");
				throw new InvalidCastException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return result;
		}

		// Token: 0x06021E11 RID: 138769 RVA: 0x0096E84C File Offset: 0x0096CA4C
		public static explicit operator bool(TFormulaValue value)
		{
			bool result;
			if (!value.TryGetBool(out result))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Cannot cast TFormulaValue(type=");
				defaultInterpolatedStringHandler.AppendFormatted<EFormulaValueType>(value.Type);
				defaultInterpolatedStringHandler.AppendLiteral(") to bool.");
				throw new InvalidCastException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return result;
		}

		// Token: 0x06021E12 RID: 138770 RVA: 0x0096E8A4 File Offset: 0x0096CAA4
		public static explicit operator string(TFormulaValue value)
		{
			string text;
			if (!value.TryGetString(out text) || text == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Cannot cast TFormulaValue(type=");
				defaultInterpolatedStringHandler.AppendFormatted<EFormulaValueType>(value.Type);
				defaultInterpolatedStringHandler.AppendLiteral(") to string.");
				throw new InvalidCastException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return text;
		}

		// Token: 0x06021E13 RID: 138771 RVA: 0x0096E900 File Offset: 0x0096CB00
		public static explicit operator Entity(TFormulaValue value)
		{
			Entity entity;
			if (!value.TryGetEntity(out entity) || entity == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Cannot cast TFormulaValue(type=");
				defaultInterpolatedStringHandler.AppendFormatted<EFormulaValueType>(value.Type);
				defaultInterpolatedStringHandler.AppendLiteral(") to Entity.");
				throw new InvalidCastException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return entity;
		}

		// Token: 0x06021E14 RID: 138772 RVA: 0x0096E95C File Offset: 0x0096CB5C
		public static explicit operator int[](TFormulaValue value)
		{
			int[] array;
			if (!value.TryGetIntArray(out array) || array == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Cannot cast TFormulaValue(type=");
				defaultInterpolatedStringHandler.AppendFormatted<EFormulaValueType>(value.Type);
				defaultInterpolatedStringHandler.AppendLiteral(") to int[].");
				throw new InvalidCastException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return array;
		}

		// Token: 0x06021E15 RID: 138773 RVA: 0x0096E9B8 File Offset: 0x0096CBB8
		public static explicit operator double[](TFormulaValue value)
		{
			double[] array;
			if (!value.TryGetDoubleArray(out array) || array == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Cannot cast TFormulaValue(type=");
				defaultInterpolatedStringHandler.AppendFormatted<EFormulaValueType>(value.Type);
				defaultInterpolatedStringHandler.AppendLiteral(") to double[].");
				throw new InvalidCastException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return array;
		}

		// Token: 0x06021E16 RID: 138774 RVA: 0x0096EA14 File Offset: 0x0096CC14
		public static explicit operator string[](TFormulaValue value)
		{
			string[] array;
			if (!value.TryGetStringArray(out array) || array == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Cannot cast TFormulaValue(type=");
				defaultInterpolatedStringHandler.AppendFormatted<EFormulaValueType>(value.Type);
				defaultInterpolatedStringHandler.AppendLiteral(") to string[].");
				throw new InvalidCastException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return array;
		}

		// Token: 0x06021E17 RID: 138775 RVA: 0x0096EA70 File Offset: 0x0096CC70
		public static explicit operator TagContainer(TFormulaValue value)
		{
			TagContainer tagContainer;
			if (!value.TryGetTagContainer(out tagContainer) || tagContainer == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Cannot cast TFormulaValue(type=");
				defaultInterpolatedStringHandler.AppendFormatted<EFormulaValueType>(value.Type);
				defaultInterpolatedStringHandler.AppendLiteral(") to TagContainer.");
				throw new InvalidCastException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return tagContainer;
		}

		// Token: 0x06021E18 RID: 138776 RVA: 0x0096EACC File Offset: 0x0096CCCC
		public static explicit operator Vector(TFormulaValue value)
		{
			Vector vector;
			if (!value.TryGetVector(out vector) || vector == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Cannot cast TFormulaValue(type=");
				defaultInterpolatedStringHandler.AppendFormatted<EFormulaValueType>(value.Type);
				defaultInterpolatedStringHandler.AppendLiteral(") to Vector.");
				throw new InvalidCastException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return vector;
		}

		// Token: 0x06021E19 RID: 138777 RVA: 0x0096EB28 File Offset: 0x0096CD28
		public static explicit operator Rotator(TFormulaValue value)
		{
			Rotator rotator;
			if (!value.TryGetRotator(out rotator) || rotator == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Cannot cast TFormulaValue(type=");
				defaultInterpolatedStringHandler.AppendFormatted<EFormulaValueType>(value.Type);
				defaultInterpolatedStringHandler.AppendLiteral(") to Rotator.");
				throw new InvalidCastException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return rotator;
		}

		// Token: 0x04012AEE RID: 76526
		private readonly double _doubleValue;

		// Token: 0x04012AEF RID: 76527
		private readonly bool _boolValue;

		// Token: 0x04012AF0 RID: 76528
		[Nullable(2)]
		private readonly string _stringValue;

		// Token: 0x04012AF1 RID: 76529
		[Nullable(2)]
		private readonly Entity _entityValue;

		// Token: 0x04012AF2 RID: 76530
		[Nullable(2)]
		private readonly double[] _doubleArrayValue;

		// Token: 0x04012AF3 RID: 76531
		[Nullable(2)]
		private readonly ContextParam _contextValue;

		// Token: 0x04012AF4 RID: 76532
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly string[] _stringArrayValue;

		// Token: 0x04012AF5 RID: 76533
		[Nullable(2)]
		private readonly TagContainer _tagContainerValue;

		// Token: 0x04012AF6 RID: 76534
		[Nullable(2)]
		private readonly Vector _vectorValue;

		// Token: 0x04012AF7 RID: 76535
		[Nullable(2)]
		private readonly Rotator _rotatorValue;
	}
}
