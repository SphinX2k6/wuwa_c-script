using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x0200073C RID: 1852
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct CustomAttributeNamedArgument : IEquatable<CustomAttributeNamedArgument>
	{
		// Token: 0x060078D0 RID: 30928 RVA: 0x0011ED8F File Offset: 0x0011CF8F
		public static bool operator ==(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
		{
			return left.Equals(right);
		}

		// Token: 0x060078D1 RID: 30929 RVA: 0x0011ED99 File Offset: 0x0011CF99
		public static bool operator !=(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
		{
			return !left.Equals(right);
		}

		// Token: 0x060078D2 RID: 30930 RVA: 0x0011EDA8 File Offset: 0x0011CFA8
		public CustomAttributeNamedArgument(MemberInfo memberInfo, [Nullable(2)] object value)
		{
			ArgumentNullException.ThrowIfNull(memberInfo, "memberInfo");
			FieldInfo fieldInfo = memberInfo as FieldInfo;
			Type type;
			if (fieldInfo == null)
			{
				PropertyInfo propertyInfo = memberInfo as PropertyInfo;
				if (propertyInfo == null)
				{
					throw new ArgumentException(SR.Argument_InvalidMemberForNamedArgument);
				}
				type = propertyInfo.PropertyType;
			}
			else
			{
				type = fieldInfo.FieldType;
			}
			Type argumentType = type;
			this._memberInfo = memberInfo;
			this._value = new CustomAttributeTypedArgument(argumentType, value);
		}

		// Token: 0x060078D3 RID: 30931 RVA: 0x0011EE09 File Offset: 0x0011D009
		public CustomAttributeNamedArgument(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument)
		{
			ArgumentNullException.ThrowIfNull(memberInfo, "memberInfo");
			this._memberInfo = memberInfo;
			this._value = typedArgument;
		}

		// Token: 0x060078D4 RID: 30932 RVA: 0x0011EE24 File Offset: 0x0011D024
		public override string ToString()
		{
			if (this._memberInfo == null)
			{
				return base.ToString();
			}
			return this.MemberInfo.Name + " = " + this.TypedValue.ToString(this.ArgumentType != typeof(object));
		}

		// Token: 0x060078D5 RID: 30933 RVA: 0x0011EE82 File Offset: 0x0011D082
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060078D6 RID: 30934 RVA: 0x0011EE94 File Offset: 0x0011D094
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is CustomAttributeNamedArgument)
			{
				CustomAttributeNamedArgument other = (CustomAttributeNamedArgument)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060078D7 RID: 30935 RVA: 0x0011EEB9 File Offset: 0x0011D0B9
		public bool Equals(CustomAttributeNamedArgument other)
		{
			return this._memberInfo == other._memberInfo && this._value == other._value;
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x060078D8 RID: 30936 RVA: 0x0011EEE4 File Offset: 0x0011D0E4
		internal Type ArgumentType
		{
			get
			{
				FieldInfo fieldInfo = this._memberInfo as FieldInfo;
				if (fieldInfo == null)
				{
					return ((PropertyInfo)this._memberInfo).PropertyType;
				}
				return fieldInfo.FieldType;
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x060078D9 RID: 30937 RVA: 0x0011EF17 File Offset: 0x0011D117
		public MemberInfo MemberInfo
		{
			get
			{
				return this._memberInfo;
			}
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x060078DA RID: 30938 RVA: 0x0011EF1F File Offset: 0x0011D11F
		public CustomAttributeTypedArgument TypedValue
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x060078DB RID: 30939 RVA: 0x0011EF27 File Offset: 0x0011D127
		public string MemberName
		{
			get
			{
				return this.MemberInfo.Name;
			}
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x060078DC RID: 30940 RVA: 0x0011EF34 File Offset: 0x0011D134
		public bool IsField
		{
			get
			{
				return this.MemberInfo is FieldInfo;
			}
		}

		// Token: 0x04001647 RID: 5703
		private readonly MemberInfo _memberInfo;

		// Token: 0x04001648 RID: 5704
		private readonly CustomAttributeTypedArgument _value;
	}
}
