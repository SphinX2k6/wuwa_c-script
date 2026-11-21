using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x0200073A RID: 1850
	[NullableContext(1)]
	[Nullable(0)]
	public static class CustomAttributeExtensions
	{
		// Token: 0x060078A8 RID: 30888 RVA: 0x0011EB5E File Offset: 0x0011CD5E
		[return: Nullable(2)]
		public static Attribute GetCustomAttribute(this Assembly element, Type attributeType)
		{
			return Attribute.GetCustomAttribute(element, attributeType);
		}

		// Token: 0x060078A9 RID: 30889 RVA: 0x0011EB67 File Offset: 0x0011CD67
		[return: Nullable(2)]
		public static Attribute GetCustomAttribute(this Module element, Type attributeType)
		{
			return Attribute.GetCustomAttribute(element, attributeType);
		}

		// Token: 0x060078AA RID: 30890 RVA: 0x0011EB70 File Offset: 0x0011CD70
		[return: Nullable(2)]
		public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType)
		{
			return Attribute.GetCustomAttribute(element, attributeType);
		}

		// Token: 0x060078AB RID: 30891 RVA: 0x0011EB79 File Offset: 0x0011CD79
		[return: Nullable(2)]
		public static Attribute GetCustomAttribute(this ParameterInfo element, Type attributeType)
		{
			return Attribute.GetCustomAttribute(element, attributeType);
		}

		// Token: 0x060078AC RID: 30892 RVA: 0x0011EB82 File Offset: 0x0011CD82
		[return: Nullable(2)]
		public static T GetCustomAttribute<[Nullable(0)] T>(this Assembly element) where T : Attribute
		{
			return (T)((object)element.GetCustomAttribute(typeof(T)));
		}

		// Token: 0x060078AD RID: 30893 RVA: 0x0011EB99 File Offset: 0x0011CD99
		[return: Nullable(2)]
		public static T GetCustomAttribute<[Nullable(0)] T>(this Module element) where T : Attribute
		{
			return (T)((object)element.GetCustomAttribute(typeof(T)));
		}

		// Token: 0x060078AE RID: 30894 RVA: 0x0011EBB0 File Offset: 0x0011CDB0
		[return: Nullable(2)]
		public static T GetCustomAttribute<[Nullable(0)] T>(this MemberInfo element) where T : Attribute
		{
			return (T)((object)element.GetCustomAttribute(typeof(T)));
		}

		// Token: 0x060078AF RID: 30895 RVA: 0x0011EBC7 File Offset: 0x0011CDC7
		[return: Nullable(2)]
		public static T GetCustomAttribute<[Nullable(0)] T>(this ParameterInfo element) where T : Attribute
		{
			return (T)((object)element.GetCustomAttribute(typeof(T)));
		}

		// Token: 0x060078B0 RID: 30896 RVA: 0x0011EBDE File Offset: 0x0011CDDE
		[return: Nullable(2)]
		public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType, bool inherit)
		{
			return Attribute.GetCustomAttribute(element, attributeType, inherit);
		}

		// Token: 0x060078B1 RID: 30897 RVA: 0x0011EBE8 File Offset: 0x0011CDE8
		[return: Nullable(2)]
		public static Attribute GetCustomAttribute(this ParameterInfo element, Type attributeType, bool inherit)
		{
			return Attribute.GetCustomAttribute(element, attributeType, inherit);
		}

		// Token: 0x060078B2 RID: 30898 RVA: 0x0011EBF2 File Offset: 0x0011CDF2
		[return: Nullable(2)]
		public static T GetCustomAttribute<[Nullable(0)] T>(this MemberInfo element, bool inherit) where T : Attribute
		{
			return (T)((object)element.GetCustomAttribute(typeof(T), inherit));
		}

		// Token: 0x060078B3 RID: 30899 RVA: 0x0011EC0A File Offset: 0x0011CE0A
		[return: Nullable(2)]
		public static T GetCustomAttribute<[Nullable(0)] T>(this ParameterInfo element, bool inherit) where T : Attribute
		{
			return (T)((object)element.GetCustomAttribute(typeof(T), inherit));
		}

		// Token: 0x060078B4 RID: 30900 RVA: 0x0011EC22 File Offset: 0x0011CE22
		public static IEnumerable<Attribute> GetCustomAttributes(this Assembly element)
		{
			return Attribute.GetCustomAttributes(element);
		}

		// Token: 0x060078B5 RID: 30901 RVA: 0x0011EC2A File Offset: 0x0011CE2A
		public static IEnumerable<Attribute> GetCustomAttributes(this Module element)
		{
			return Attribute.GetCustomAttributes(element);
		}

		// Token: 0x060078B6 RID: 30902 RVA: 0x0011EC32 File Offset: 0x0011CE32
		public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element)
		{
			return Attribute.GetCustomAttributes(element);
		}

		// Token: 0x060078B7 RID: 30903 RVA: 0x0011EC3A File Offset: 0x0011CE3A
		public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element)
		{
			return Attribute.GetCustomAttributes(element);
		}

		// Token: 0x060078B8 RID: 30904 RVA: 0x0011EC42 File Offset: 0x0011CE42
		public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, bool inherit)
		{
			return Attribute.GetCustomAttributes(element, inherit);
		}

		// Token: 0x060078B9 RID: 30905 RVA: 0x0011EC4B File Offset: 0x0011CE4B
		public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element, bool inherit)
		{
			return Attribute.GetCustomAttributes(element, inherit);
		}

		// Token: 0x060078BA RID: 30906 RVA: 0x0011EC54 File Offset: 0x0011CE54
		public static IEnumerable<Attribute> GetCustomAttributes(this Assembly element, Type attributeType)
		{
			return Attribute.GetCustomAttributes(element, attributeType);
		}

		// Token: 0x060078BB RID: 30907 RVA: 0x0011EC5D File Offset: 0x0011CE5D
		public static IEnumerable<Attribute> GetCustomAttributes(this Module element, Type attributeType)
		{
			return Attribute.GetCustomAttributes(element, attributeType);
		}

		// Token: 0x060078BC RID: 30908 RVA: 0x0011EC66 File Offset: 0x0011CE66
		public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType)
		{
			return Attribute.GetCustomAttributes(element, attributeType);
		}

		// Token: 0x060078BD RID: 30909 RVA: 0x0011EC6F File Offset: 0x0011CE6F
		public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element, Type attributeType)
		{
			return Attribute.GetCustomAttributes(element, attributeType);
		}

		// Token: 0x060078BE RID: 30910 RVA: 0x0011EC78 File Offset: 0x0011CE78
		public static IEnumerable<T> GetCustomAttributes<[Nullable(0)] T>(this Assembly element) where T : Attribute
		{
			return (IEnumerable<T>)element.GetCustomAttributes(typeof(T));
		}

		// Token: 0x060078BF RID: 30911 RVA: 0x0011EC8F File Offset: 0x0011CE8F
		public static IEnumerable<T> GetCustomAttributes<[Nullable(0)] T>(this Module element) where T : Attribute
		{
			return (IEnumerable<T>)element.GetCustomAttributes(typeof(T));
		}

		// Token: 0x060078C0 RID: 30912 RVA: 0x0011ECA6 File Offset: 0x0011CEA6
		public static IEnumerable<T> GetCustomAttributes<[Nullable(0)] T>(this MemberInfo element) where T : Attribute
		{
			return (IEnumerable<T>)element.GetCustomAttributes(typeof(T));
		}

		// Token: 0x060078C1 RID: 30913 RVA: 0x0011ECBD File Offset: 0x0011CEBD
		public static IEnumerable<T> GetCustomAttributes<[Nullable(0)] T>(this ParameterInfo element) where T : Attribute
		{
			return (IEnumerable<T>)element.GetCustomAttributes(typeof(T));
		}

		// Token: 0x060078C2 RID: 30914 RVA: 0x0011ECD4 File Offset: 0x0011CED4
		public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType, bool inherit)
		{
			return Attribute.GetCustomAttributes(element, attributeType, inherit);
		}

		// Token: 0x060078C3 RID: 30915 RVA: 0x0011ECDE File Offset: 0x0011CEDE
		public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element, Type attributeType, bool inherit)
		{
			return Attribute.GetCustomAttributes(element, attributeType, inherit);
		}

		// Token: 0x060078C4 RID: 30916 RVA: 0x0011ECE8 File Offset: 0x0011CEE8
		public static IEnumerable<T> GetCustomAttributes<[Nullable(0)] T>(this MemberInfo element, bool inherit) where T : Attribute
		{
			return (IEnumerable<T>)element.GetCustomAttributes(typeof(T), inherit);
		}

		// Token: 0x060078C5 RID: 30917 RVA: 0x0011ED00 File Offset: 0x0011CF00
		public static IEnumerable<T> GetCustomAttributes<[Nullable(0)] T>(this ParameterInfo element, bool inherit) where T : Attribute
		{
			return (IEnumerable<T>)element.GetCustomAttributes(typeof(T), inherit);
		}

		// Token: 0x060078C6 RID: 30918 RVA: 0x0011ED18 File Offset: 0x0011CF18
		public static bool IsDefined(this Assembly element, Type attributeType)
		{
			return Attribute.IsDefined(element, attributeType);
		}

		// Token: 0x060078C7 RID: 30919 RVA: 0x0011ED21 File Offset: 0x0011CF21
		public static bool IsDefined(this Module element, Type attributeType)
		{
			return Attribute.IsDefined(element, attributeType);
		}

		// Token: 0x060078C8 RID: 30920 RVA: 0x0011ED2A File Offset: 0x0011CF2A
		public static bool IsDefined(this MemberInfo element, Type attributeType)
		{
			return Attribute.IsDefined(element, attributeType);
		}

		// Token: 0x060078C9 RID: 30921 RVA: 0x0011ED33 File Offset: 0x0011CF33
		public static bool IsDefined(this ParameterInfo element, Type attributeType)
		{
			return Attribute.IsDefined(element, attributeType);
		}

		// Token: 0x060078CA RID: 30922 RVA: 0x0011ED3C File Offset: 0x0011CF3C
		public static bool IsDefined(this MemberInfo element, Type attributeType, bool inherit)
		{
			return Attribute.IsDefined(element, attributeType, inherit);
		}

		// Token: 0x060078CB RID: 30923 RVA: 0x0011ED46 File Offset: 0x0011CF46
		public static bool IsDefined(this ParameterInfo element, Type attributeType, bool inherit)
		{
			return Attribute.IsDefined(element, attributeType, inherit);
		}
	}
}
