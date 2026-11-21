using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Reflection
{
	// Token: 0x02000712 RID: 1810
	internal sealed class RuntimeParameterInfo : ParameterInfo
	{
		// Token: 0x060077DE RID: 30686 RVA: 0x0011D157 File Offset: 0x0011B357
		internal RuntimeParameterInfo(string name, Type type, int position, int attrs, object defaultValue, MemberInfo member, MarshalAsAttribute marshalAs)
		{
			this.NameImpl = name;
			this.ClassImpl = type;
			this.PositionImpl = position;
			this.AttrsImpl = (ParameterAttributes)attrs;
			this.DefaultValueImpl = defaultValue;
			this.MemberImpl = member;
			this.marshalAs = marshalAs;
		}

		// Token: 0x060077DF RID: 30687 RVA: 0x0011D194 File Offset: 0x0011B394
		internal unsafe static void FormatParameters(StringBuilder sb, ReadOnlySpan<ParameterInfo> p, CallingConventions callingConvention)
		{
			for (int i = 0; i < p.Length; i++)
			{
				if (i > 0)
				{
					sb.Append(", ");
				}
				Type parameterType = p[i]->ParameterType;
				string text = parameterType.FormatTypeName();
				if (parameterType.IsByRef)
				{
					sb.Append(text.TrimEnd('&'));
					sb.Append(" ByRef");
				}
				else
				{
					sb.Append(text);
				}
			}
			if ((callingConvention & CallingConventions.VarArgs) != (CallingConventions)0)
			{
				if (p.Length > 0)
				{
					sb.Append(", ");
				}
				sb.Append("...");
			}
		}

		// Token: 0x060077E0 RID: 30688 RVA: 0x0011D22C File Offset: 0x0011B42C
		internal RuntimeParameterInfo(ParameterBuilder pb, Type type, MemberInfo member, int position)
		{
			this.ClassImpl = type;
			this.MemberImpl = member;
			if (pb != null)
			{
				this.NameImpl = pb.Name;
				this.PositionImpl = pb.Position - 1;
				this.AttrsImpl = (ParameterAttributes)pb.Attributes;
				return;
			}
			this.NameImpl = null;
			this.PositionImpl = position - 1;
			this.AttrsImpl = ParameterAttributes.None;
		}

		// Token: 0x060077E1 RID: 30689 RVA: 0x0011D28F File Offset: 0x0011B48F
		internal static ParameterInfo New(ParameterBuilder pb, Type type, MemberInfo member, int position)
		{
			return new RuntimeParameterInfo(pb, type, member, position);
		}

		// Token: 0x060077E2 RID: 30690 RVA: 0x0011D29C File Offset: 0x0011B49C
		internal RuntimeParameterInfo(ParameterInfo pinfo, MemberInfo member)
		{
			this.ClassImpl = pinfo.ParameterType;
			this.MemberImpl = member;
			this.NameImpl = pinfo.Name;
			this.PositionImpl = pinfo.Position;
			this.AttrsImpl = pinfo.Attributes;
			this.DefaultValueImpl = RuntimeParameterInfo.GetDefaultValueImpl(pinfo);
		}

		// Token: 0x060077E3 RID: 30691 RVA: 0x0011D2F2 File Offset: 0x0011B4F2
		internal RuntimeParameterInfo(Type type, MemberInfo member, MarshalAsAttribute marshalAs)
		{
			this.ClassImpl = type;
			this.MemberImpl = member;
			this.NameImpl = null;
			this.PositionImpl = -1;
			this.AttrsImpl = ParameterAttributes.Retval;
			this.marshalAs = marshalAs;
			this.DefaultValueImpl = DBNull.Value;
		}

		// Token: 0x060077E4 RID: 30692 RVA: 0x0011D32F File Offset: 0x0011B52F
		internal RuntimeParameterInfo(MethodInfo owner, string name, Type parameterType, int position)
		{
			this.MemberImpl = owner;
			this.NameImpl = name;
			this.ClassImpl = parameterType;
			this.PositionImpl = position;
			this.AttrsImpl = ParameterAttributes.None;
		}

		// Token: 0x060077E5 RID: 30693 RVA: 0x0011D35C File Offset: 0x0011B55C
		private object GetDefaultValueFromCustomAttributeData()
		{
			foreach (CustomAttributeData customAttributeData in CustomAttributeData.GetCustomAttributes(this))
			{
				Type attributeType = customAttributeData.AttributeType;
				if (attributeType == typeof(DecimalConstantAttribute))
				{
					return RuntimeParameterInfo.GetRawDecimalConstant(customAttributeData);
				}
				if (attributeType.IsSubclassOf(typeof(CustomConstantAttribute)))
				{
					if (attributeType == typeof(DateTimeConstantAttribute))
					{
						return RuntimeParameterInfo.GetRawDateTimeConstant(customAttributeData);
					}
					return RuntimeParameterInfo.GetRawConstant(customAttributeData);
				}
			}
			return DBNull.Value;
		}

		// Token: 0x060077E6 RID: 30694 RVA: 0x0011D40C File Offset: 0x0011B60C
		private static decimal GetRawDecimalConstant(CustomAttributeData attr)
		{
			IList<CustomAttributeTypedArgument> constructorArguments = attr.ConstructorArguments;
			return new decimal(RuntimeParameterInfo.<GetRawDecimalConstant>g__GetConstructorArgument|10_0(constructorArguments, 4), RuntimeParameterInfo.<GetRawDecimalConstant>g__GetConstructorArgument|10_0(constructorArguments, 3), RuntimeParameterInfo.<GetRawDecimalConstant>g__GetConstructorArgument|10_0(constructorArguments, 2), (byte)constructorArguments[1].Value > 0, (byte)constructorArguments[0].Value);
		}

		// Token: 0x060077E7 RID: 30695 RVA: 0x0011D468 File Offset: 0x0011B668
		private static DateTime GetRawDateTimeConstant(CustomAttributeData attr)
		{
			return new DateTime((long)attr.ConstructorArguments[0].Value);
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x0011D494 File Offset: 0x0011B694
		private static object GetRawConstant(CustomAttributeData attr)
		{
			foreach (CustomAttributeNamedArgument customAttributeNamedArgument in attr.NamedArguments)
			{
				if (customAttributeNamedArgument.MemberInfo.Name.Equals("Value"))
				{
					return customAttributeNamedArgument.TypedValue.Value;
				}
			}
			return DBNull.Value;
		}

		// Token: 0x060077E9 RID: 30697 RVA: 0x0011D50C File Offset: 0x0011B70C
		private object GetDefaultValueFromCustomAttributes()
		{
			object[] customAttributes = this.GetCustomAttributes(typeof(CustomConstantAttribute), false);
			if (customAttributes.Length != 0)
			{
				return ((CustomConstantAttribute)customAttributes[0]).Value;
			}
			customAttributes = this.GetCustomAttributes(typeof(DecimalConstantAttribute), false);
			if (customAttributes.Length != 0)
			{
				return ((DecimalConstantAttribute)customAttributes[0]).Value;
			}
			return DBNull.Value;
		}

		// Token: 0x060077EA RID: 30698 RVA: 0x0011D56C File Offset: 0x0011B76C
		private object GetDefaultValue(bool raw)
		{
			object obj = this.DefaultValueImpl;
			if (obj != null && (obj.GetType() == typeof(DBNull) || obj.GetType() == typeof(Missing)))
			{
				obj = (raw ? this.GetDefaultValueFromCustomAttributeData() : this.GetDefaultValueFromCustomAttributes());
			}
			if (obj == DBNull.Value && base.IsOptional)
			{
				obj = Type.Missing;
			}
			return obj;
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x060077EB RID: 30699 RVA: 0x0011D5DA File Offset: 0x0011B7DA
		public override object DefaultValue
		{
			get
			{
				return this.GetDefaultValue(false);
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x060077EC RID: 30700 RVA: 0x0011D5E4 File Offset: 0x0011B7E4
		public override object RawDefaultValue
		{
			get
			{
				object defaultValue = this.GetDefaultValue(true);
				Enum @enum = defaultValue as Enum;
				if (@enum != null)
				{
					return @enum.GetValue();
				}
				return defaultValue;
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x060077ED RID: 30701 RVA: 0x0011D60C File Offset: 0x0011B80C
		public override int MetadataToken
		{
			get
			{
				PropertyInfo propertyInfo = this.MemberImpl as PropertyInfo;
				if (propertyInfo != null)
				{
					return (propertyInfo.GetGetMethod(true) ?? propertyInfo.GetSetMethod(true)).GetParametersInternal()[this.PositionImpl].MetadataToken;
				}
				if (this.MemberImpl is MethodBase)
				{
					return this.GetMetadataToken();
				}
				throw new ArgumentException(SR.NoMetadataTokenAvailable);
			}
		}

		// Token: 0x060077EE RID: 30702 RVA: 0x0011D66A File Offset: 0x0011B86A
		public override object[] GetCustomAttributes(bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, false);
		}

		// Token: 0x060077EF RID: 30703 RVA: 0x0011D673 File Offset: 0x0011B873
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, attributeType, false);
		}

		// Token: 0x060077F0 RID: 30704 RVA: 0x0011D67D File Offset: 0x0011B87D
		internal static object GetDefaultValueImpl(ParameterInfo pinfo)
		{
			return typeof(ParameterInfo).GetField("DefaultValueImpl", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(pinfo);
		}

		// Token: 0x060077F1 RID: 30705 RVA: 0x00009CC2 File Offset: 0x00007EC2
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return CustomAttribute.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x060077F2 RID: 30706 RVA: 0x0011D69B File Offset: 0x0011B89B
		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return RuntimeCustomAttributeData.GetCustomAttributesInternal(this);
		}

		// Token: 0x060077F3 RID: 30707
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern int GetMetadataToken();

		// Token: 0x060077F4 RID: 30708 RVA: 0x0011D6A3 File Offset: 0x0011B8A3
		public override Type[] GetOptionalCustomModifiers()
		{
			if (!(this.MemberImpl is DynamicMethod))
			{
				return this.GetCustomModifiers(true);
			}
			return Type.EmptyTypes;
		}

		// Token: 0x060077F5 RID: 30709 RVA: 0x0011D6C0 File Offset: 0x0011B8C0
		internal object[] GetPseudoCustomAttributes()
		{
			int num = 0;
			if (base.IsIn)
			{
				num++;
			}
			if (base.IsOut)
			{
				num++;
			}
			if (base.IsOptional)
			{
				num++;
			}
			if (this.marshalAs != null)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			object[] array = new object[num];
			num = 0;
			if (base.IsIn)
			{
				array[num++] = new InAttribute();
			}
			if (base.IsOut)
			{
				array[num++] = new OutAttribute();
			}
			if (base.IsOptional)
			{
				array[num++] = new OptionalAttribute();
			}
			if (this.marshalAs != null)
			{
				array[num++] = (MarshalAsAttribute)this.marshalAs.CloneInternal();
			}
			return array;
		}

		// Token: 0x060077F6 RID: 30710 RVA: 0x0011D76C File Offset: 0x0011B96C
		internal CustomAttributeData[] GetPseudoCustomAttributesData()
		{
			int num = 0;
			if (base.IsIn)
			{
				num++;
			}
			if (base.IsOut)
			{
				num++;
			}
			if (base.IsOptional)
			{
				num++;
			}
			if (this.marshalAs != null)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			CustomAttributeData[] array = new CustomAttributeData[num];
			num = 0;
			if (base.IsIn)
			{
				array[num++] = new RuntimeCustomAttributeData(typeof(InAttribute).GetConstructor(Type.EmptyTypes));
			}
			if (base.IsOut)
			{
				array[num++] = new RuntimeCustomAttributeData(typeof(OutAttribute).GetConstructor(Type.EmptyTypes));
			}
			if (base.IsOptional)
			{
				array[num++] = new RuntimeCustomAttributeData(typeof(OptionalAttribute).GetConstructor(Type.EmptyTypes));
			}
			if (this.marshalAs != null)
			{
				CustomAttributeTypedArgument[] ctorArgs = new CustomAttributeTypedArgument[]
				{
					new CustomAttributeTypedArgument(typeof(UnmanagedType), this.marshalAs.Value)
				};
				array[num++] = new RuntimeCustomAttributeData(typeof(MarshalAsAttribute).GetConstructor(new Type[]
				{
					typeof(UnmanagedType)
				}), ctorArgs, Array.Empty<CustomAttributeNamedArgument>());
			}
			return array;
		}

		// Token: 0x060077F7 RID: 30711 RVA: 0x0011D89B File Offset: 0x0011BA9B
		public override Type[] GetRequiredCustomModifiers()
		{
			if (!(this.MemberImpl is DynamicMethod))
			{
				return this.GetCustomModifiers(false);
			}
			return Type.EmptyTypes;
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x060077F8 RID: 30712 RVA: 0x0011D8B8 File Offset: 0x0011BAB8
		public override bool HasDefaultValue
		{
			get
			{
				object defaultValue = this.DefaultValue;
				return defaultValue == null || (!(defaultValue.GetType() == typeof(DBNull)) && !(defaultValue.GetType() == typeof(Missing)));
			}
		}

		// Token: 0x060077F9 RID: 30713
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Type[] GetTypeModifiers(Type type, MemberInfo member, int position, bool optional, int genericArgumentPosition = -1);

		// Token: 0x060077FA RID: 30714 RVA: 0x0011D902 File Offset: 0x0011BB02
		internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member)
		{
			return new RuntimeParameterInfo(pinfo, member);
		}

		// Token: 0x060077FB RID: 30715 RVA: 0x0011D90B File Offset: 0x0011BB0B
		internal static ParameterInfo New(Type type, MemberInfo member, MarshalAsAttribute marshalAs)
		{
			return new RuntimeParameterInfo(type, member, marshalAs);
		}

		// Token: 0x060077FC RID: 30716 RVA: 0x0011D915 File Offset: 0x0011BB15
		internal void SetName(string name)
		{
			this.NameImpl = name;
		}

		// Token: 0x060077FD RID: 30717 RVA: 0x0011D91E File Offset: 0x0011BB1E
		internal void SetAttributes(ParameterAttributes attributes)
		{
			this.AttrsImpl = attributes;
		}

		// Token: 0x060077FE RID: 30718 RVA: 0x0011D927 File Offset: 0x0011BB27
		private Type[] GetCustomModifiers(bool optional)
		{
			return RuntimeParameterInfo.GetTypeModifiers(this.ParameterType, this.Member, this.Position, optional, -1) ?? Type.EmptyTypes;
		}

		// Token: 0x060077FF RID: 30719 RVA: 0x0011D94B File Offset: 0x0011BB4B
		internal Type[] GetCustomModifiersFromModifiedType(bool optional, int genericArgumentPosition)
		{
			return RuntimeParameterInfo.GetTypeModifiers(this.ParameterType, this.Member, this.Position, optional, genericArgumentPosition) ?? Type.EmptyTypes;
		}

		// Token: 0x06007800 RID: 30720 RVA: 0x0011D96F File Offset: 0x0011BB6F
		public override Type GetModifiedParameterType()
		{
			return ModifiedType.Create(this.ParameterType, this, this.PositionImpl + 1);
		}

		// Token: 0x06007801 RID: 30721 RVA: 0x0011D988 File Offset: 0x0011BB88
		[CompilerGenerated]
		internal static int <GetRawDecimalConstant>g__GetConstructorArgument|10_0(IList<CustomAttributeTypedArgument> args, int index)
		{
			object value = args[index].Value;
			if (value is int)
			{
				return (int)value;
			}
			return (int)((uint)value);
		}

		// Token: 0x040015C0 RID: 5568
		internal MarshalAsAttribute marshalAs;
	}
}
