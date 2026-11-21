using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x0200070D RID: 1805
	internal struct MonoMethodInfo
	{
		// Token: 0x06007743 RID: 30531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_method_info(IntPtr handle, out MonoMethodInfo info);

		// Token: 0x06007744 RID: 30532
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int get_method_attributes(IntPtr handle);

		// Token: 0x06007745 RID: 30533 RVA: 0x0011BCF4 File Offset: 0x00119EF4
		internal static MonoMethodInfo GetMethodInfo(IntPtr handle)
		{
			MonoMethodInfo result;
			MonoMethodInfo.get_method_info(handle, out result);
			return result;
		}

		// Token: 0x06007746 RID: 30534 RVA: 0x0011BD0A File Offset: 0x00119F0A
		internal static Type GetDeclaringType(IntPtr handle)
		{
			return MonoMethodInfo.GetMethodInfo(handle).parent;
		}

		// Token: 0x06007747 RID: 30535 RVA: 0x0011BD17 File Offset: 0x00119F17
		internal static Type GetReturnType(IntPtr handle)
		{
			return MonoMethodInfo.GetMethodInfo(handle).ret;
		}

		// Token: 0x06007748 RID: 30536 RVA: 0x0011BD24 File Offset: 0x00119F24
		internal static MethodAttributes GetAttributes(IntPtr handle)
		{
			return (MethodAttributes)MonoMethodInfo.get_method_attributes(handle);
		}

		// Token: 0x06007749 RID: 30537 RVA: 0x0011BD2C File Offset: 0x00119F2C
		internal static CallingConventions GetCallingConvention(IntPtr handle)
		{
			return MonoMethodInfo.GetMethodInfo(handle).callconv;
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x0011BD39 File Offset: 0x00119F39
		internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle)
		{
			return MonoMethodInfo.GetMethodInfo(handle).iattrs;
		}

		// Token: 0x0600774B RID: 30539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member);

		// Token: 0x0600774C RID: 30540 RVA: 0x0011BD46 File Offset: 0x00119F46
		internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member)
		{
			return MonoMethodInfo.get_parameter_info(handle, member);
		}

		// Token: 0x0600774D RID: 30541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern MarshalAsAttribute get_retval_marshal(IntPtr handle);

		// Token: 0x0600774E RID: 30542 RVA: 0x0011BD4F File Offset: 0x00119F4F
		internal static ParameterInfo GetReturnParameterInfo(RuntimeMethodInfo method)
		{
			return RuntimeParameterInfo.New(MonoMethodInfo.GetReturnType(method.mhandle), method, MonoMethodInfo.get_retval_marshal(method.mhandle));
		}

		// Token: 0x040015A4 RID: 5540
		private Type parent;

		// Token: 0x040015A5 RID: 5541
		private Type ret;

		// Token: 0x040015A6 RID: 5542
		internal MethodAttributes attrs;

		// Token: 0x040015A7 RID: 5543
		internal MethodImplAttributes iattrs;

		// Token: 0x040015A8 RID: 5544
		private CallingConventions callconv;
	}
}
