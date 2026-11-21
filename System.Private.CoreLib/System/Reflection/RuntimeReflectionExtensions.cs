using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000776 RID: 1910
	[NullableContext(1)]
	[Nullable(0)]
	public static class RuntimeReflectionExtensions
	{
		// Token: 0x06007A2B RID: 31275 RVA: 0x0012193A File Offset: 0x0011FB3A
		public static IEnumerable<FieldInfo> GetRuntimeFields([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)] this Type type)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			return type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x06007A2C RID: 31276 RVA: 0x0012194F File Offset: 0x0011FB4F
		public static IEnumerable<MethodInfo> GetRuntimeMethods([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)] this Type type)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			return type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x06007A2D RID: 31277 RVA: 0x00121964 File Offset: 0x0011FB64
		public static IEnumerable<PropertyInfo> GetRuntimeProperties([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] this Type type)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			return type.GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x06007A2E RID: 31278 RVA: 0x00121979 File Offset: 0x0011FB79
		public static IEnumerable<EventInfo> GetRuntimeEvents([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)] this Type type)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			return type.GetEvents(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x06007A2F RID: 31279 RVA: 0x0012198E File Offset: 0x0011FB8E
		[return: Nullable(2)]
		public static FieldInfo GetRuntimeField([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] this Type type, string name)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			return type.GetField(name);
		}

		// Token: 0x06007A30 RID: 31280 RVA: 0x001219A2 File Offset: 0x0011FBA2
		[return: Nullable(2)]
		public static MethodInfo GetRuntimeMethod([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] this Type type, string name, Type[] parameters)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			return type.GetMethod(name, parameters);
		}

		// Token: 0x06007A31 RID: 31281 RVA: 0x001219B7 File Offset: 0x0011FBB7
		[return: Nullable(2)]
		public static PropertyInfo GetRuntimeProperty([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] this Type type, string name)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			return type.GetProperty(name);
		}

		// Token: 0x06007A32 RID: 31282 RVA: 0x001219CB File Offset: 0x0011FBCB
		[return: Nullable(2)]
		public static EventInfo GetRuntimeEvent([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents)] this Type type, string name)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			return type.GetEvent(name);
		}

		// Token: 0x06007A33 RID: 31283 RVA: 0x001219DF File Offset: 0x0011FBDF
		[return: Nullable(2)]
		public static MethodInfo GetRuntimeBaseDefinition(this MethodInfo method)
		{
			ArgumentNullException.ThrowIfNull(method, "method");
			return method.GetBaseDefinition();
		}

		// Token: 0x06007A34 RID: 31284 RVA: 0x001219F2 File Offset: 0x0011FBF2
		public static InterfaceMapping GetRuntimeInterfaceMap(this TypeInfo typeInfo, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)] Type interfaceType)
		{
			ArgumentNullException.ThrowIfNull(typeInfo, "typeInfo");
			return typeInfo.GetInterfaceMap(interfaceType);
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x00121A06 File Offset: 0x0011FC06
		public static MethodInfo GetMethodInfo(this Delegate del)
		{
			ArgumentNullException.ThrowIfNull(del, "del");
			return del.Method;
		}
	}
}
