using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000704 RID: 1796
	internal sealed class RuntimeCustomAttributeData : CustomAttributeData
	{
		// Token: 0x060076E7 RID: 30439 RVA: 0x0011B57A File Offset: 0x0011977A
		internal RuntimeCustomAttributeData(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length)
		{
			this.ctorInfo = ctorInfo;
			this.lazyData = new RuntimeCustomAttributeData.LazyCAttrData();
			this.lazyData.assembly = assembly;
			this.lazyData.data = data;
			this.lazyData.data_length = data_length;
		}

		// Token: 0x060076E8 RID: 30440 RVA: 0x0011B5B9 File Offset: 0x001197B9
		internal RuntimeCustomAttributeData(ConstructorInfo ctorInfo) : this(ctorInfo, Array.Empty<CustomAttributeTypedArgument>(), Array.Empty<CustomAttributeNamedArgument>())
		{
		}

		// Token: 0x060076E9 RID: 30441 RVA: 0x0011B5CC File Offset: 0x001197CC
		internal RuntimeCustomAttributeData(ConstructorInfo ctorInfo, IList<CustomAttributeTypedArgument> ctorArgs, IList<CustomAttributeNamedArgument> namedArgs)
		{
			this.ctorInfo = ctorInfo;
			this.ctorArgs = ctorArgs;
			this.namedArgs = namedArgs;
		}

		// Token: 0x060076EA RID: 30442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs);

		// Token: 0x060076EB RID: 30443 RVA: 0x0011B5EC File Offset: 0x001197EC
		private void ResolveArguments()
		{
			if (this.lazyData == null)
			{
				return;
			}
			object[] array;
			object[] array2;
			RuntimeCustomAttributeData.ResolveArgumentsInternal(this.ctorInfo, this.lazyData.assembly, this.lazyData.data, this.lazyData.data_length, out array, out array2);
			this.ctorArgs = Array.AsReadOnly<CustomAttributeTypedArgument>((array != null) ? RuntimeCustomAttributeData.UnboxValues<CustomAttributeTypedArgument>(array) : Array.Empty<CustomAttributeTypedArgument>());
			this.namedArgs = Array.AsReadOnly<CustomAttributeNamedArgument>((array2 != null) ? RuntimeCustomAttributeData.UnboxValues<CustomAttributeNamedArgument>(array2) : Array.Empty<CustomAttributeNamedArgument>());
			this.lazyData = null;
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x060076EC RID: 30444 RVA: 0x0011B66F File Offset: 0x0011986F
		public override ConstructorInfo Constructor
		{
			get
			{
				return this.ctorInfo;
			}
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x060076ED RID: 30445 RVA: 0x0011B677 File Offset: 0x00119877
		public override IList<CustomAttributeTypedArgument> ConstructorArguments
		{
			get
			{
				this.ResolveArguments();
				return this.ctorArgs;
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x060076EE RID: 30446 RVA: 0x0011B685 File Offset: 0x00119885
		public override IList<CustomAttributeNamedArgument> NamedArguments
		{
			get
			{
				this.ResolveArguments();
				return this.namedArgs;
			}
		}

		// Token: 0x060076EF RID: 30447 RVA: 0x0011B693 File Offset: 0x00119893
		internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target)
		{
			return CustomAttribute.GetCustomAttributesData(target, false);
		}

		// Token: 0x060076F0 RID: 30448 RVA: 0x0011B693 File Offset: 0x00119893
		internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeFieldInfo target)
		{
			return CustomAttribute.GetCustomAttributesData(target, false);
		}

		// Token: 0x060076F1 RID: 30449 RVA: 0x0011B693 File Offset: 0x00119893
		internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeMethodInfo target)
		{
			return CustomAttribute.GetCustomAttributesData(target, false);
		}

		// Token: 0x060076F2 RID: 30450 RVA: 0x0011B693 File Offset: 0x00119893
		internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeConstructorInfo target)
		{
			return CustomAttribute.GetCustomAttributesData(target, false);
		}

		// Token: 0x060076F3 RID: 30451 RVA: 0x0011B693 File Offset: 0x00119893
		internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeEventInfo target)
		{
			return CustomAttribute.GetCustomAttributesData(target, false);
		}

		// Token: 0x060076F4 RID: 30452 RVA: 0x0011B693 File Offset: 0x00119893
		internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimePropertyInfo target)
		{
			return CustomAttribute.GetCustomAttributesData(target, false);
		}

		// Token: 0x060076F5 RID: 30453 RVA: 0x0011B693 File Offset: 0x00119893
		internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeModule target)
		{
			return CustomAttribute.GetCustomAttributesData(target, false);
		}

		// Token: 0x060076F6 RID: 30454 RVA: 0x0011B693 File Offset: 0x00119893
		internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeAssembly target)
		{
			return CustomAttribute.GetCustomAttributesData(target, false);
		}

		// Token: 0x060076F7 RID: 30455 RVA: 0x0011B693 File Offset: 0x00119893
		internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeParameterInfo target)
		{
			return CustomAttribute.GetCustomAttributesData(target, false);
		}

		// Token: 0x060076F8 RID: 30456 RVA: 0x0011B69C File Offset: 0x0011989C
		private static T[] UnboxValues<T>(object[] values)
		{
			T[] array = new T[values.Length];
			for (int i = 0; i < values.Length; i++)
			{
				array[i] = (T)((object)values[i]);
			}
			return array;
		}

		// Token: 0x0400156E RID: 5486
		private ConstructorInfo ctorInfo;

		// Token: 0x0400156F RID: 5487
		private IList<CustomAttributeTypedArgument> ctorArgs;

		// Token: 0x04001570 RID: 5488
		private IList<CustomAttributeNamedArgument> namedArgs;

		// Token: 0x04001571 RID: 5489
		private RuntimeCustomAttributeData.LazyCAttrData lazyData;

		// Token: 0x02000705 RID: 1797
		private sealed class LazyCAttrData
		{
			// Token: 0x04001572 RID: 5490
			internal Assembly assembly;

			// Token: 0x04001573 RID: 5491
			internal IntPtr data;

			// Token: 0x04001574 RID: 5492
			internal uint data_length;
		}
	}
}
