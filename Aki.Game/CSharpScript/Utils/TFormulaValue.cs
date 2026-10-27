using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x020044EA RID: 17642
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct TFormulaValue
	{
		// Token: 0x170073AC RID: 29612
		// (get) Token: 0x0602D6F3 RID: 186099 RVA: 0x00A4179F File Offset: 0x00A3F99F
		public EFormulaValueType Type { get; }

		// Token: 0x0602D6F4 RID: 186100 RVA: 0x00A417A8 File Offset: 0x00A3F9A8
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

		// Token: 0x170073AD RID: 29613
		// (get) Token: 0x0602D6F5 RID: 186101 RVA: 0x00A4180A File Offset: 0x00A3FA0A
		public bool IsNull
		{
			get
			{
				return this.Type == EFormulaValueType.None;
			}
		}

		// Token: 0x0602D6F6 RID: 186102 RVA: 0x00A41818 File Offset: 0x00A3FA18
		public static TFormulaValue FromInt(int value)
		{
			return new TFormulaValue(EFormulaValueType.Double, (double)value, false, null, null, null, null, null, null, null, null);
		}

		// Token: 0x0602D6F7 RID: 186103 RVA: 0x00A41838 File Offset: 0x00A3FA38
		public static TFormulaValue FromLong(long value)
		{
			return new TFormulaValue(EFormulaValueType.Double, (double)value, false, null, null, null, null, null, null, null, null);
		}

		// Token: 0x0602D6F8 RID: 186104 RVA: 0x00A41858 File Offset: 0x00A3FA58
		public static TFormulaValue FromFloat(float value)
		{
			return new TFormulaValue(EFormulaValueType.Double, (double)value, false, null, null, null, null, null, null, null, null);
		}

		// Token: 0x0602D6F9 RID: 186105 RVA: 0x00A41878 File Offset: 0x00A3FA78
		public static TFormulaValue FromDouble(double value)
		{
			return new TFormulaValue(EFormulaValueType.Double, value, false, null, null, null, null, null, null, null, null);
		}

		// Token: 0x0602D6FA RID: 186106 RVA: 0x00A41898 File Offset: 0x00A3FA98
		public static TFormulaValue FromBool(bool value)
		{
			return new TFormulaValue(EFormulaValueType.Bool, 0.0, value, null, null, null, null, null, null, null, null);
		}

		// Token: 0x0602D6FB RID: 186107 RVA: 0x00A418C0 File Offset: 0x00A3FAC0
		public static TFormulaValue FromString(string value)
		{
			return new TFormulaValue(EFormulaValueType.String, 0.0, false, value, null, null, null, null, null, null, null);
		}

		// Token: 0x0602D6FC RID: 186108 RVA: 0x00A418E8 File Offset: 0x00A3FAE8
		public static TFormulaValue FromEntity(Entity value)
		{
			return new TFormulaValue(EFormulaValueType.Entity, 0.0, false, null, value, null, null, null, null, null, null);
		}

		// Token: 0x0602D6FD RID: 186109 RVA: 0x00A41910 File Offset: 0x00A3FB10
		public static TFormulaValue FromIntArray(int[] value)
		{
			return new TFormulaValue(EFormulaValueType.DoubleArray, 0.0, false, null, null, Array.ConvertAll<int, double>(value, (int v) => (double)v), null, null, null, null, null);
		}

		// Token: 0x0602D6FE RID: 186110 RVA: 0x00A4195C File Offset: 0x00A3FB5C
		public static TFormulaValue FromLongArray(long[] value)
		{
			return new TFormulaValue(EFormulaValueType.DoubleArray, 0.0, false, null, null, Array.ConvertAll<long, double>(value, (long v) => (double)v), null, null, null, null, null);
		}

		// Token: 0x0602D6FF RID: 186111 RVA: 0x00A419A8 File Offset: 0x00A3FBA8
		public static TFormulaValue FromDoubleArray(double[] value)
		{
			return new TFormulaValue(EFormulaValueType.DoubleArray, 0.0, false, null, null, value, null, null, null, null, null);
		}

		// Token: 0x0602D700 RID: 186112 RVA: 0x00A419D0 File Offset: 0x00A3FBD0
		[NullableContext(2)]
		public static TFormulaValue FromContext(ContextParam value)
		{
			if (value != null)
			{
				return new TFormulaValue(EFormulaValueType.Context, 0.0, false, null, null, null, value, null, null, null, null);
			}
			return default(TFormulaValue);
		}

		// Token: 0x0602D701 RID: 186113 RVA: 0x00A41A04 File Offset: 0x00A3FC04
		public static TFormulaValue FromStringArray(string[] value)
		{
			return new TFormulaValue(EFormulaValueType.StringArray, 0.0, false, null, null, null, null, value, null, null, null);
		}

		// Token: 0x0602D702 RID: 186114 RVA: 0x00A41A2C File Offset: 0x00A3FC2C
		public static TFormulaValue FromTagContainer(TagContainer value)
		{
			return new TFormulaValue(EFormulaValueType.TagContainer, 0.0, false, null, null, null, null, null, value, null, null);
		}

		// Token: 0x0602D703 RID: 186115 RVA: 0x00A41A54 File Offset: 0x00A3FC54
		public static TFormulaValue FromVector(Vector value)
		{
			return new TFormulaValue(EFormulaValueType.Vector, 0.0, false, null, null, null, null, null, null, value, null);
		}

		// Token: 0x0602D704 RID: 186116 RVA: 0x00A41A7C File Offset: 0x00A3FC7C
		public static TFormulaValue FromRotator(Rotator value)
		{
			return new TFormulaValue(EFormulaValueType.Rotator, 0.0, false, null, null, null, null, null, null, null, value);
		}

		// Token: 0x0602D705 RID: 186117 RVA: 0x00A41AA4 File Offset: 0x00A3FCA4
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

		// Token: 0x0602D706 RID: 186118 RVA: 0x00A41B34 File Offset: 0x00A3FD34
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

		// Token: 0x0602D707 RID: 186119 RVA: 0x00A41B70 File Offset: 0x00A3FD70
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

		// Token: 0x0602D708 RID: 186120 RVA: 0x00A41BAD File Offset: 0x00A3FDAD
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

		// Token: 0x0602D709 RID: 186121 RVA: 0x00A41BED File Offset: 0x00A3FDED
		public bool TryGetDouble(out double value)
		{
			value = this._doubleValue;
			return this.Type == EFormulaValueType.Double;
		}

		// Token: 0x0602D70A RID: 186122 RVA: 0x00A41C00 File Offset: 0x00A3FE00
		public bool TryGetBool(out bool value)
		{
			value = this._boolValue;
			return this.Type == EFormulaValueType.Bool;
		}

		// Token: 0x0602D70B RID: 186123 RVA: 0x00A41C13 File Offset: 0x00A3FE13
		[NullableContext(2)]
		public bool TryGetString(out string value)
		{
			value = this._stringValue;
			return this.Type == EFormulaValueType.String;
		}

		// Token: 0x0602D70C RID: 186124 RVA: 0x00A41C26 File Offset: 0x00A3FE26
		[NullableContext(2)]
		public bool TryGetEntity(out Entity value)
		{
			value = this._entityValue;
			return this.Type == EFormulaValueType.Entity;
		}

		// Token: 0x0602D70D RID: 186125 RVA: 0x00A41C3C File Offset: 0x00A3FE3C
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

		// Token: 0x0602D70E RID: 186126 RVA: 0x00A41C8C File Offset: 0x00A3FE8C
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

		// Token: 0x0602D70F RID: 186127 RVA: 0x00A41CDC File Offset: 0x00A3FEDC
		[NullableContext(2)]
		public bool TryGetDoubleArray(out double[] value)
		{
			value = this._doubleArrayValue;
			return this.Type == EFormulaValueType.DoubleArray;
		}

		// Token: 0x0602D710 RID: 186128 RVA: 0x00A41CEF File Offset: 0x00A3FEEF
		[NullableContext(2)]
		public bool TryGetContext(out ContextParam value)
		{
			value = this._contextValue;
			return this.Type == EFormulaValueType.Context;
		}

		// Token: 0x0602D711 RID: 186129 RVA: 0x00A41D02 File Offset: 0x00A3FF02
		public bool TryGetStringArray([Nullable(new byte[]
		{
			2,
			1
		})] out string[] value)
		{
			value = this._stringArrayValue;
			return this.Type == EFormulaValueType.StringArray;
		}

		// Token: 0x0602D712 RID: 186130 RVA: 0x00A41D15 File Offset: 0x00A3FF15
		[NullableContext(2)]
		public bool TryGetTagContainer(out TagContainer value)
		{
			value = this._tagContainerValue;
			return this.Type == EFormulaValueType.TagContainer;
		}

		// Token: 0x0602D713 RID: 186131 RVA: 0x00A41D28 File Offset: 0x00A3FF28
		[NullableContext(2)]
		public bool TryGetVector(out Vector value)
		{
			value = this._vectorValue;
			return this.Type == EFormulaValueType.Vector;
		}

		// Token: 0x0602D714 RID: 186132 RVA: 0x00A41D3C File Offset: 0x00A3FF3C
		[NullableContext(2)]
		public bool TryGetRotator(out Rotator value)
		{
			value = this._rotatorValue;
			return this.Type == EFormulaValueType.Rotator;
		}

		// Token: 0x0602D715 RID: 186133 RVA: 0x00A41D50 File Offset: 0x00A3FF50
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

		// Token: 0x0602D716 RID: 186134 RVA: 0x00A41DD4 File Offset: 0x00A3FFD4
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

		// Token: 0x0602D717 RID: 186135 RVA: 0x00A41E10 File Offset: 0x00A40010
		private static bool IsNumeric(TFormulaValue value)
		{
			return value.Type == EFormulaValueType.Double;
		}

		// Token: 0x0602D718 RID: 186136 RVA: 0x00A41E1C File Offset: 0x00A4001C
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

		// Token: 0x0602D719 RID: 186137 RVA: 0x00A41E60 File Offset: 0x00A40060
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

		// Token: 0x0602D71A RID: 186138 RVA: 0x00A41EB0 File Offset: 0x00A400B0
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

		// Token: 0x0602D71B RID: 186139 RVA: 0x00A41EFC File Offset: 0x00A400FC
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

		// Token: 0x0602D71C RID: 186140 RVA: 0x00A41FA8 File Offset: 0x00A401A8
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

		// Token: 0x0602D71D RID: 186141 RVA: 0x00A42018 File Offset: 0x00A40218
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

		// Token: 0x0602D71E RID: 186142 RVA: 0x00A42088 File Offset: 0x00A40288
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

		// Token: 0x0602D71F RID: 186143 RVA: 0x00A420F8 File Offset: 0x00A402F8
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

		// Token: 0x0602D720 RID: 186144 RVA: 0x00A42168 File Offset: 0x00A40368
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

		// Token: 0x0602D721 RID: 186145 RVA: 0x00A421D4 File Offset: 0x00A403D4
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

		// Token: 0x0602D722 RID: 186146 RVA: 0x00A4223E File Offset: 0x00A4043E
		public static bool operator >(TFormulaValue left, TFormulaValue right)
		{
			return TFormulaValue.Compare(left, right) > 0;
		}

		// Token: 0x0602D723 RID: 186147 RVA: 0x00A4224A File Offset: 0x00A4044A
		public static bool operator >=(TFormulaValue left, TFormulaValue right)
		{
			return TFormulaValue.Compare(left, right) >= 0;
		}

		// Token: 0x0602D724 RID: 186148 RVA: 0x00A42259 File Offset: 0x00A40459
		public static bool operator <(TFormulaValue left, TFormulaValue right)
		{
			return TFormulaValue.Compare(left, right) < 0;
		}

		// Token: 0x0602D725 RID: 186149 RVA: 0x00A42265 File Offset: 0x00A40465
		public static bool operator <=(TFormulaValue left, TFormulaValue right)
		{
			return TFormulaValue.Compare(left, right) <= 0;
		}

		// Token: 0x0602D726 RID: 186150 RVA: 0x00A42274 File Offset: 0x00A40474
		public static bool operator ==(TFormulaValue left, TFormulaValue right)
		{
			return TFormulaValue.AreEqual(left, right);
		}

		// Token: 0x0602D727 RID: 186151 RVA: 0x00A4227D File Offset: 0x00A4047D
		public static bool operator !=(TFormulaValue left, TFormulaValue right)
		{
			return !TFormulaValue.AreEqual(left, right);
		}

		// Token: 0x0602D728 RID: 186152 RVA: 0x00A4228C File Offset: 0x00A4048C
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

		// Token: 0x0602D729 RID: 186153 RVA: 0x00A422B8 File Offset: 0x00A404B8
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

		// Token: 0x0602D72A RID: 186154 RVA: 0x00A4243C File Offset: 0x00A4063C
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

		// Token: 0x0602D72B RID: 186155 RVA: 0x00A424CC File Offset: 0x00A406CC
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

		// Token: 0x0602D72C RID: 186156 RVA: 0x00A426A8 File Offset: 0x00A408A8
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

		// Token: 0x0602D72D RID: 186157 RVA: 0x00A42806 File Offset: 0x00A40A06
		public static implicit operator TFormulaValue(int value)
		{
			return TFormulaValue.FromInt(value);
		}

		// Token: 0x0602D72E RID: 186158 RVA: 0x00A4280E File Offset: 0x00A40A0E
		public static implicit operator TFormulaValue(long value)
		{
			return TFormulaValue.FromLong(value);
		}

		// Token: 0x0602D72F RID: 186159 RVA: 0x00A42816 File Offset: 0x00A40A16
		public static implicit operator TFormulaValue(float value)
		{
			return TFormulaValue.FromFloat(value);
		}

		// Token: 0x0602D730 RID: 186160 RVA: 0x00A4281E File Offset: 0x00A40A1E
		public static implicit operator TFormulaValue(double value)
		{
			return TFormulaValue.FromDouble(value);
		}

		// Token: 0x0602D731 RID: 186161 RVA: 0x00A42826 File Offset: 0x00A40A26
		public static implicit operator TFormulaValue(bool value)
		{
			return TFormulaValue.FromBool(value);
		}

		// Token: 0x0602D732 RID: 186162 RVA: 0x00A4282E File Offset: 0x00A40A2E
		public static implicit operator TFormulaValue(string value)
		{
			return TFormulaValue.FromString(value);
		}

		// Token: 0x0602D733 RID: 186163 RVA: 0x00A42836 File Offset: 0x00A40A36
		public static implicit operator TFormulaValue(Entity value)
		{
			return TFormulaValue.FromEntity(value);
		}

		// Token: 0x0602D734 RID: 186164 RVA: 0x00A4283E File Offset: 0x00A40A3E
		public static implicit operator TFormulaValue(int[] value)
		{
			return TFormulaValue.FromIntArray(value);
		}

		// Token: 0x0602D735 RID: 186165 RVA: 0x00A42846 File Offset: 0x00A40A46
		public static implicit operator TFormulaValue(long[] value)
		{
			return TFormulaValue.FromLongArray(value);
		}

		// Token: 0x0602D736 RID: 186166 RVA: 0x00A4284E File Offset: 0x00A40A4E
		public static implicit operator TFormulaValue(double[] value)
		{
			return TFormulaValue.FromDoubleArray(value);
		}

		// Token: 0x0602D737 RID: 186167 RVA: 0x00A42856 File Offset: 0x00A40A56
		public static implicit operator TFormulaValue(string[] value)
		{
			return TFormulaValue.FromStringArray(value);
		}

		// Token: 0x0602D738 RID: 186168 RVA: 0x00A4285E File Offset: 0x00A40A5E
		public static implicit operator TFormulaValue(ContextParam value)
		{
			return TFormulaValue.FromContext(value);
		}

		// Token: 0x0602D739 RID: 186169 RVA: 0x00A42866 File Offset: 0x00A40A66
		public static implicit operator TFormulaValue(TagContainer value)
		{
			return TFormulaValue.FromTagContainer(value);
		}

		// Token: 0x0602D73A RID: 186170 RVA: 0x00A4286E File Offset: 0x00A40A6E
		public static implicit operator TFormulaValue(Vector value)
		{
			return TFormulaValue.FromVector(value);
		}

		// Token: 0x0602D73B RID: 186171 RVA: 0x00A42876 File Offset: 0x00A40A76
		public static implicit operator TFormulaValue(Rotator value)
		{
			return TFormulaValue.FromRotator(value);
		}

		// Token: 0x0602D73C RID: 186172 RVA: 0x00A42880 File Offset: 0x00A40A80
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

		// Token: 0x0602D73D RID: 186173 RVA: 0x00A428DC File Offset: 0x00A40ADC
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

		// Token: 0x0602D73E RID: 186174 RVA: 0x00A42934 File Offset: 0x00A40B34
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

		// Token: 0x0602D73F RID: 186175 RVA: 0x00A4298C File Offset: 0x00A40B8C
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

		// Token: 0x0602D740 RID: 186176 RVA: 0x00A429E4 File Offset: 0x00A40BE4
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

		// Token: 0x0602D741 RID: 186177 RVA: 0x00A42A3C File Offset: 0x00A40C3C
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

		// Token: 0x0602D742 RID: 186178 RVA: 0x00A42A94 File Offset: 0x00A40C94
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

		// Token: 0x0602D743 RID: 186179 RVA: 0x00A42AF0 File Offset: 0x00A40CF0
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

		// Token: 0x0602D744 RID: 186180 RVA: 0x00A42B4C File Offset: 0x00A40D4C
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

		// Token: 0x0602D745 RID: 186181 RVA: 0x00A42BA8 File Offset: 0x00A40DA8
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

		// Token: 0x0602D746 RID: 186182 RVA: 0x00A42C04 File Offset: 0x00A40E04
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

		// Token: 0x0602D747 RID: 186183 RVA: 0x00A42C60 File Offset: 0x00A40E60
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

		// Token: 0x0602D748 RID: 186184 RVA: 0x00A42CBC File Offset: 0x00A40EBC
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

		// Token: 0x0602D749 RID: 186185 RVA: 0x00A42D18 File Offset: 0x00A40F18
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

		// Token: 0x040184C6 RID: 99526
		private readonly double _doubleValue;

		// Token: 0x040184C7 RID: 99527
		private readonly bool _boolValue;

		// Token: 0x040184C8 RID: 99528
		[Nullable(2)]
		private readonly string _stringValue;

		// Token: 0x040184C9 RID: 99529
		[Nullable(2)]
		private readonly Entity _entityValue;

		// Token: 0x040184CA RID: 99530
		[Nullable(2)]
		private readonly double[] _doubleArrayValue;

		// Token: 0x040184CB RID: 99531
		[Nullable(2)]
		private readonly ContextParam _contextValue;

		// Token: 0x040184CC RID: 99532
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly string[] _stringArrayValue;

		// Token: 0x040184CD RID: 99533
		[Nullable(2)]
		private readonly TagContainer _tagContainerValue;

		// Token: 0x040184CE RID: 99534
		[Nullable(2)]
		private readonly Vector _vectorValue;

		// Token: 0x040184CF RID: 99535
		[Nullable(2)]
		private readonly Rotator _rotatorValue;
	}
}
