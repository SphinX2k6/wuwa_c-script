using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000076 RID: 118
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public abstract class Attribute
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x00009BD0 File Offset: 0x00007DD0
		private static Attribute GetAttr(ICustomAttributeProvider element, Type attributeType, bool inherit)
		{
			ArgumentNullException.ThrowIfNull(attributeType, "attributeType");
			if (!attributeType.IsSubclassOf(typeof(Attribute)) && !attributeType.IsInterface && attributeType != typeof(Attribute) && attributeType != typeof(CustomAttribute))
			{
				throw new ArgumentException(SR.Argument_MustHaveAttributeBaseClass + " " + attributeType.FullName);
			}
			object[] customAttributes = CustomAttribute.GetCustomAttributes(element, attributeType, inherit);
			if (customAttributes == null || customAttributes.Length == 0)
			{
				return null;
			}
			Attribute attribute = (Attribute)customAttributes[0];
			if (customAttributes.Length != 1)
			{
				throw ThrowHelper.GetAmbiguousMatchException(attribute);
			}
			return attribute;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00009C6A File Offset: 0x00007E6A
		[return: Nullable(2)]
		public static Attribute GetCustomAttribute(Assembly element, Type attributeType)
		{
			return Attribute.GetAttr(element, attributeType, true);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00009C74 File Offset: 0x00007E74
		[return: Nullable(2)]
		public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit)
		{
			return Attribute.GetAttr(element, attributeType, inherit);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00009C6A File Offset: 0x00007E6A
		[return: Nullable(2)]
		public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType)
		{
			return Attribute.GetAttr(element, attributeType, true);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00009C74 File Offset: 0x00007E74
		[return: Nullable(2)]
		public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit)
		{
			return Attribute.GetAttr(element, attributeType, inherit);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00009C6A File Offset: 0x00007E6A
		[return: Nullable(2)]
		public static Attribute GetCustomAttribute(Module element, Type attributeType)
		{
			return Attribute.GetAttr(element, attributeType, true);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00009C74 File Offset: 0x00007E74
		[return: Nullable(2)]
		public static Attribute GetCustomAttribute(Module element, Type attributeType, bool inherit)
		{
			return Attribute.GetAttr(element, attributeType, inherit);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00009C6A File Offset: 0x00007E6A
		[return: Nullable(2)]
		public static Attribute GetCustomAttribute(ParameterInfo element, Type attributeType)
		{
			return Attribute.GetAttr(element, attributeType, true);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00009C74 File Offset: 0x00007E74
		[return: Nullable(2)]
		public static Attribute GetCustomAttribute(ParameterInfo element, Type attributeType, bool inherit)
		{
			return Attribute.GetAttr(element, attributeType, inherit);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00009C7E File Offset: 0x00007E7E
		public static Attribute[] GetCustomAttributes(Assembly element)
		{
			return (Attribute[])CustomAttribute.GetCustomAttributes(element, true);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00009C8C File Offset: 0x00007E8C
		public static Attribute[] GetCustomAttributes(Assembly element, bool inherit)
		{
			return (Attribute[])CustomAttribute.GetCustomAttributes(element, inherit);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00009C9A File Offset: 0x00007E9A
		public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType)
		{
			return (Attribute[])CustomAttribute.GetCustomAttributes(element, attributeType, true);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00009CA9 File Offset: 0x00007EA9
		public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit)
		{
			return (Attribute[])CustomAttribute.GetCustomAttributes(element, attributeType, inherit);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00009C7E File Offset: 0x00007E7E
		public static Attribute[] GetCustomAttributes(MemberInfo element)
		{
			return (Attribute[])CustomAttribute.GetCustomAttributes(element, true);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00009C8C File Offset: 0x00007E8C
		public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit)
		{
			return (Attribute[])CustomAttribute.GetCustomAttributes(element, inherit);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00009C9A File Offset: 0x00007E9A
		public static Attribute[] GetCustomAttributes(MemberInfo element, Type attributeType)
		{
			return (Attribute[])CustomAttribute.GetCustomAttributes(element, attributeType, true);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00009CA9 File Offset: 0x00007EA9
		public static Attribute[] GetCustomAttributes(MemberInfo element, Type attributeType, bool inherit)
		{
			return (Attribute[])CustomAttribute.GetCustomAttributes(element, attributeType, inherit);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00009C7E File Offset: 0x00007E7E
		public static Attribute[] GetCustomAttributes(Module element)
		{
			return (Attribute[])CustomAttribute.GetCustomAttributes(element, true);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00009C8C File Offset: 0x00007E8C
		public static Attribute[] GetCustomAttributes(Module element, bool inherit)
		{
			return (Attribute[])CustomAttribute.GetCustomAttributes(element, inherit);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00009C9A File Offset: 0x00007E9A
		public static Attribute[] GetCustomAttributes(Module element, Type attributeType)
		{
			return (Attribute[])CustomAttribute.GetCustomAttributes(element, attributeType, true);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00009CA9 File Offset: 0x00007EA9
		public static Attribute[] GetCustomAttributes(Module element, Type attributeType, bool inherit)
		{
			return (Attribute[])CustomAttribute.GetCustomAttributes(element, attributeType, inherit);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00009C7E File Offset: 0x00007E7E
		public static Attribute[] GetCustomAttributes(ParameterInfo element)
		{
			return (Attribute[])CustomAttribute.GetCustomAttributes(element, true);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00009C8C File Offset: 0x00007E8C
		public static Attribute[] GetCustomAttributes(ParameterInfo element, bool inherit)
		{
			return (Attribute[])CustomAttribute.GetCustomAttributes(element, inherit);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00009C9A File Offset: 0x00007E9A
		public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType)
		{
			return (Attribute[])CustomAttribute.GetCustomAttributes(element, attributeType, true);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00009CA9 File Offset: 0x00007EA9
		public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType, bool inherit)
		{
			return (Attribute[])CustomAttribute.GetCustomAttributes(element, attributeType, inherit);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00009CB8 File Offset: 0x00007EB8
		public static bool IsDefined(Assembly element, Type attributeType)
		{
			return CustomAttribute.IsDefined(element, attributeType, true);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00009CC2 File Offset: 0x00007EC2
		public static bool IsDefined(Assembly element, Type attributeType, bool inherit)
		{
			return CustomAttribute.IsDefined(element, attributeType, inherit);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00009CB8 File Offset: 0x00007EB8
		public static bool IsDefined(MemberInfo element, Type attributeType)
		{
			return CustomAttribute.IsDefined(element, attributeType, true);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00009CC2 File Offset: 0x00007EC2
		public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit)
		{
			return CustomAttribute.IsDefined(element, attributeType, inherit);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00009CB8 File Offset: 0x00007EB8
		public static bool IsDefined(Module element, Type attributeType)
		{
			return CustomAttribute.IsDefined(element, attributeType, true);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00009CC2 File Offset: 0x00007EC2
		public static bool IsDefined(Module element, Type attributeType, bool inherit)
		{
			return CustomAttribute.IsDefined(element, attributeType, inherit);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00009CB8 File Offset: 0x00007EB8
		public static bool IsDefined(ParameterInfo element, Type attributeType)
		{
			return CustomAttribute.IsDefined(element, attributeType, true);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00009CC2 File Offset: 0x00007EC2
		public static bool IsDefined(ParameterInfo element, Type attributeType, bool inherit)
		{
			return CustomAttribute.IsDefined(element, attributeType, inherit);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00009CCC File Offset: 0x00007ECC
		[NullableContext(2)]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2075:UnrecognizedReflectionPattern", Justification = "Unused fields don't make a difference for equality")]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (base.GetType() != obj.GetType())
			{
				return false;
			}
			Type type = base.GetType();
			while (type != typeof(Attribute))
			{
				FieldInfo[] fields = type.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				for (int i = 0; i < fields.Length; i++)
				{
					object value = fields[i].GetValue(this);
					object value2 = fields[i].GetValue(obj);
					if (!Attribute.AreFieldValuesEqual(value, value2))
					{
						return false;
					}
				}
				type = type.BaseType;
			}
			return true;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00009D54 File Offset: 0x00007F54
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2075:UnrecognizedReflectionPattern", Justification = "Unused fields don't make a difference for hashcode quality")]
		public override int GetHashCode()
		{
			Type type = base.GetType();
			while (type != typeof(Attribute))
			{
				FieldInfo[] fields = type.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				object obj = null;
				for (int i = 0; i < fields.Length; i++)
				{
					object value = fields[i].GetValue(this);
					if (value != null && !value.GetType().IsArray)
					{
						obj = value;
					}
					if (obj != null)
					{
						break;
					}
				}
				if (obj != null)
				{
					return obj.GetHashCode();
				}
				type = type.BaseType;
			}
			return type.GetHashCode();
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00009DD0 File Offset: 0x00007FD0
		private static bool AreFieldValuesEqual(object thisValue, object thatValue)
		{
			if (thisValue == null && thatValue == null)
			{
				return true;
			}
			if (thisValue == null || thatValue == null)
			{
				return false;
			}
			Type type = thisValue.GetType();
			if (type.IsArray)
			{
				if (!type.Equals(thatValue.GetType()))
				{
					return false;
				}
				Array array = (Array)thisValue;
				Array array2 = (Array)thatValue;
				if (array.Length != array2.Length)
				{
					return false;
				}
				for (int i = 0; i < array.Length; i++)
				{
					if (!Attribute.AreFieldValuesEqual(array.GetValue(i), array2.GetValue(i)))
					{
						return false;
					}
				}
			}
			else if (!thisValue.Equals(thatValue))
			{
				return false;
			}
			return true;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00009E60 File Offset: 0x00008060
		public virtual object TypeId
		{
			get
			{
				return base.GetType();
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00009E68 File Offset: 0x00008068
		[NullableContext(2)]
		public virtual bool Match(object obj)
		{
			return this.Equals(obj);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsDefaultAttribute()
		{
			return false;
		}
	}
}
