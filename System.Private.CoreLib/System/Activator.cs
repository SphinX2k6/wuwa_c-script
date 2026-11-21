using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;
using System.Runtime.Remoting;
using System.Threading;

namespace System
{
	// Token: 0x020000C3 RID: 195
	[NullableContext(1)]
	[Nullable(0)]
	public static class Activator
	{
		// Token: 0x0600092B RID: 2347 RVA: 0x0001CB0B File Offset: 0x0001AD0B
		[NullableContext(2)]
		[DebuggerHidden]
		[DebuggerStepThrough]
		public static object CreateInstance([Nullable(1)] [DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)] Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture)
		{
			return Activator.CreateInstance(type, bindingAttr, binder, args, culture, null);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0001CB19 File Offset: 0x0001AD19
		[NullableContext(2)]
		[DebuggerHidden]
		[DebuggerStepThrough]
		public static object CreateInstance([Nullable(1)] [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type type, params object[] args)
		{
			return Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, args, null, null);
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0001CB2A File Offset: 0x0001AD2A
		[NullableContext(2)]
		[DebuggerHidden]
		[DebuggerStepThrough]
		public static object CreateInstance([Nullable(1)] [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type type, object[] args, object[] activationAttributes)
		{
			return Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, args, null, activationAttributes);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0001CB3B File Offset: 0x0001AD3B
		[DebuggerHidden]
		[DebuggerStepThrough]
		[return: Nullable(2)]
		public static object CreateInstance([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] Type type)
		{
			return Activator.CreateInstance(type, false);
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0001CB44 File Offset: 0x0001AD44
		[RequiresUnreferencedCode("Type and its constructor could be removed")]
		[return: Nullable(2)]
		public static ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName)
		{
			return Activator.CreateInstanceFrom(assemblyFile, typeName, false, BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, null, null, null);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0001CB57 File Offset: 0x0001AD57
		[RequiresUnreferencedCode("Type and its constructor could be removed")]
		[return: Nullable(2)]
		public static ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, [Nullable(2)] object[] activationAttributes)
		{
			return Activator.CreateInstanceFrom(assemblyFile, typeName, false, BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, null, null, activationAttributes);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0001CB6C File Offset: 0x0001AD6C
		[NullableContext(2)]
		[RequiresUnreferencedCode("Type and its constructor could be removed")]
		public static ObjectHandle CreateInstanceFrom([Nullable(1)] string assemblyFile, [Nullable(1)] string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			object obj = Activator.CreateInstance(Assembly.LoadFrom(assemblyFile).GetType(typeName, true, ignoreCase), bindingAttr, binder, args, culture, activationAttributes);
			if (obj == null)
			{
				return null;
			}
			return new ObjectHandle(obj);
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0001CBA4 File Offset: 0x0001ADA4
		[NullableContext(2)]
		public static object CreateInstance([Nullable(1)] [DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)] Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			if (type is TypeBuilder)
			{
				throw new NotSupportedException(SR.NotSupported_CreateInstanceWithTypeBuilder);
			}
			if ((bindingAttr & (BindingFlags)255) == BindingFlags.Default)
			{
				bindingAttr |= (BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance);
			}
			if (activationAttributes != null && activationAttributes.Length != 0)
			{
				throw new PlatformNotSupportedException(SR.NotSupported_ActivAttr);
			}
			RuntimeType runtimeType = type.UnderlyingSystemType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(SR.Arg_MustBeType, "type");
			}
			return runtimeType.CreateInstanceImpl(bindingAttr, binder, args, culture);
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0001CC20 File Offset: 0x0001AE20
		[RequiresUnreferencedCode("Type and its constructor could be removed")]
		[return: Nullable(2)]
		public static ObjectHandle CreateInstance(string assemblyName, string typeName)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return Activator.CreateInstanceInternal(assemblyName, typeName, false, BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, null, null, null, ref stackCrawlMark);
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0001CC44 File Offset: 0x0001AE44
		[NullableContext(2)]
		[RequiresUnreferencedCode("Type and its constructor could be removed")]
		public static ObjectHandle CreateInstance([Nullable(1)] string assemblyName, [Nullable(1)] string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return Activator.CreateInstanceInternal(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, ref stackCrawlMark);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0001CC68 File Offset: 0x0001AE68
		[RequiresUnreferencedCode("Type and its constructor could be removed")]
		[return: Nullable(2)]
		public static ObjectHandle CreateInstance(string assemblyName, string typeName, [Nullable(2)] object[] activationAttributes)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return Activator.CreateInstanceInternal(assemblyName, typeName, false, BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, null, null, activationAttributes, ref stackCrawlMark);
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0001CC8A File Offset: 0x0001AE8A
		[return: Nullable(2)]
		public static object CreateInstance([DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)] Type type, bool nonPublic)
		{
			return Activator.CreateInstance(type, nonPublic, true);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0001CC94 File Offset: 0x0001AE94
		internal static object CreateInstance(Type type, bool nonPublic, bool wrapExceptions)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			RuntimeType runtimeType = type.UnderlyingSystemType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(SR.Arg_MustBeType, "type");
			}
			return runtimeType.CreateInstanceDefaultCtor(!nonPublic, wrapExceptions);
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0001CCCC File Offset: 0x0001AECC
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "Implementation detail of Activator that linker intrinsically recognizes")]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2072:UnrecognizedReflectionPattern", Justification = "Implementation detail of Activator that linker intrinsically recognizes")]
		private static ObjectHandle CreateInstanceInternal(string assemblyString, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark)
		{
			RuntimeAssembly runtimeAssembly;
			if (assemblyString == null)
			{
				runtimeAssembly = Assembly.GetExecutingAssembly(ref stackMark);
			}
			else
			{
				runtimeAssembly = RuntimeAssembly.InternalLoad(new AssemblyName(assemblyString), ref stackMark, AssemblyLoadContext.CurrentContextualReflectionContext);
			}
			object obj = Activator.CreateInstance(runtimeAssembly.GetType(typeName, true, ignoreCase), bindingAttr, binder, args, culture, activationAttributes);
			if (obj == null)
			{
				return null;
			}
			return new ObjectHandle(obj);
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0001CD1C File Offset: 0x0001AF1C
		[Intrinsic]
		public unsafe static T CreateInstance<[Nullable(2), DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] T>()
		{
			RuntimeType runtimeType = (RuntimeType)typeof(T);
			if (!runtimeType.IsValueType)
			{
				object obj = runtimeType.CreateInstanceOfT();
				return *Unsafe.As<object, T>(ref obj);
			}
			T result = default(T);
			runtimeType.CallDefaultStructConstructor(Unsafe.As<T, byte>(ref result));
			return result;
		}
	}
}
