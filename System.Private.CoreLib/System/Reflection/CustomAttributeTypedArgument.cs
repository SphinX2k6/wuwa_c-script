using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Reflection
{
	// Token: 0x0200073D RID: 1853
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct CustomAttributeTypedArgument : IEquatable<CustomAttributeTypedArgument>
	{
		// Token: 0x060078DD RID: 30941 RVA: 0x0011EF44 File Offset: 0x0011D144
		public static bool operator ==(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
		{
			return left.Equals(right);
		}

		// Token: 0x060078DE RID: 30942 RVA: 0x0011EF4E File Offset: 0x0011D14E
		public static bool operator !=(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
		{
			return !left.Equals(right);
		}

		// Token: 0x060078DF RID: 30943 RVA: 0x0011EF5B File Offset: 0x0011D15B
		public CustomAttributeTypedArgument(Type argumentType, [Nullable(2)] object value)
		{
			ArgumentNullException.ThrowIfNull(argumentType, "argumentType");
			this._value = CustomAttributeTypedArgument.CanonicalizeValue(value);
			this._argumentType = argumentType;
		}

		// Token: 0x060078E0 RID: 30944 RVA: 0x0011EF7B File Offset: 0x0011D17B
		public CustomAttributeTypedArgument(object value)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			this._value = CustomAttributeTypedArgument.CanonicalizeValue(value);
			this._argumentType = value.GetType();
		}

		// Token: 0x060078E1 RID: 30945 RVA: 0x0011EFA0 File Offset: 0x0011D1A0
		public override string ToString()
		{
			return this.ToString(false);
		}

		// Token: 0x060078E2 RID: 30946 RVA: 0x0011EFAC File Offset: 0x0011D1AC
		internal unsafe string ToString(bool typed)
		{
			if (this._argumentType == null)
			{
				return base.ToString();
			}
			if (this.ArgumentType.IsEnum)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (!typed)
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
					defaultInterpolatedStringHandler.AppendLiteral("(");
					defaultInterpolatedStringHandler.AppendFormatted(this.ArgumentType.FullName);
					defaultInterpolatedStringHandler.AppendLiteral(")");
					defaultInterpolatedStringHandler.AppendFormatted<object>(this.Value);
					return defaultInterpolatedStringHandler.ToStringAndClear();
				}
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<object>(this.Value);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else if (this.Value == null)
			{
				if (!typed)
				{
					return "(" + this.ArgumentType.Name + ")null";
				}
				return "null";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (this.ArgumentType == typeof(string))
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral("\"");
					defaultInterpolatedStringHandler.AppendFormatted<object>(this.Value);
					defaultInterpolatedStringHandler.AppendLiteral("\"");
					return defaultInterpolatedStringHandler.ToStringAndClear();
				}
				if (this.ArgumentType == typeof(char))
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral("'");
					defaultInterpolatedStringHandler.AppendFormatted<object>(this.Value);
					defaultInterpolatedStringHandler.AppendLiteral("'");
					return defaultInterpolatedStringHandler.ToStringAndClear();
				}
				if (this.ArgumentType == typeof(Type))
				{
					return "typeof(" + ((Type)this.Value).FullName + ")";
				}
				if (this.ArgumentType.IsArray)
				{
					IList<CustomAttributeTypedArgument> list = (IList<CustomAttributeTypedArgument>)this.Value;
					Type elementType = this.ArgumentType.GetElementType();
					Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
					ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
					valueStringBuilder.Append("new ");
					valueStringBuilder.Append(elementType.IsEnum ? elementType.FullName : elementType.Name);
					valueStringBuilder.Append('[');
					int count = list.Count;
					valueStringBuilder.Append(count.ToString());
					valueStringBuilder.Append("] { ");
					for (int i = 0; i < count; i++)
					{
						if (i != 0)
						{
							valueStringBuilder.Append(", ");
						}
						valueStringBuilder.Append(list[i].ToString(elementType != typeof(object)));
					}
					valueStringBuilder.Append(" }");
					return valueStringBuilder.ToString();
				}
				if (!typed)
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
					defaultInterpolatedStringHandler.AppendLiteral("(");
					defaultInterpolatedStringHandler.AppendFormatted(this.ArgumentType.Name);
					defaultInterpolatedStringHandler.AppendLiteral(")");
					defaultInterpolatedStringHandler.AppendFormatted<object>(this.Value);
					return defaultInterpolatedStringHandler.ToStringAndClear();
				}
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<object>(this.Value);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}

		// Token: 0x060078E3 RID: 30947 RVA: 0x0011F2A9 File Offset: 0x0011D4A9
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060078E4 RID: 30948 RVA: 0x0011F2BC File Offset: 0x0011D4BC
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is CustomAttributeTypedArgument)
			{
				CustomAttributeTypedArgument other = (CustomAttributeTypedArgument)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060078E5 RID: 30949 RVA: 0x0011F2E1 File Offset: 0x0011D4E1
		public bool Equals(CustomAttributeTypedArgument other)
		{
			return this._value == other._value && this._argumentType == other._argumentType;
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x060078E6 RID: 30950 RVA: 0x0011F304 File Offset: 0x0011D504
		public Type ArgumentType
		{
			get
			{
				return this._argumentType;
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x060078E7 RID: 30951 RVA: 0x0011F30C File Offset: 0x0011D50C
		[Nullable(2)]
		public object Value
		{
			[NullableContext(2)]
			get
			{
				return this._value;
			}
		}

		// Token: 0x060078E8 RID: 30952 RVA: 0x0011F314 File Offset: 0x0011D514
		private static object CanonicalizeValue(object value)
		{
			Enum @enum = value as Enum;
			if (@enum == null)
			{
				return value;
			}
			return @enum.GetValue();
		}

		// Token: 0x04001649 RID: 5705
		private readonly object _value;

		// Token: 0x0400164A RID: 5706
		private readonly Type _argumentType;
	}
}
