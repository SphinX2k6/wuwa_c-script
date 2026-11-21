using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200065D RID: 1629
	[NullableContext(1)]
	[Nullable(0)]
	public static class RuntimeHelpers
	{
		// Token: 0x060072EA RID: 29418 RVA: 0x001121C2 File Offset: 0x001103C2
		public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle)
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			ArgumentNullException.ThrowIfNull(fldHandle.Value, "fldHandle");
			RuntimeHelpers.InitializeArray(array, fldHandle.Value);
		}

		// Token: 0x060072EB RID: 29419 RVA: 0x001121F0 File Offset: 0x001103F0
		private unsafe static ref byte GetSpanDataFrom(RuntimeFieldHandle fldHandle, RuntimeTypeHandle targetTypeHandle, out int count)
		{
			fixed (int* ptr = &count)
			{
				int* value = ptr;
				return RuntimeHelpers.GetSpanDataFrom(fldHandle.Value, targetTypeHandle.Value, new IntPtr((void*)value));
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x060072EC RID: 29420 RVA: 0x00074EAC File Offset: 0x000730AC
		[Obsolete("OffsetToStringData has been deprecated. Use string.GetPinnableReference() instead.")]
		public static int OffsetToStringData
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x060072ED RID: 29421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int InternalGetHashCode(object o);

		// Token: 0x060072EE RID: 29422 RVA: 0x0011221C File Offset: 0x0011041C
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetHashCode(object o)
		{
			int result;
			if (ObjectHeader.TryGetHashCode(o, out result))
			{
				return result;
			}
			return RuntimeHelpers.InternalGetHashCode(o);
		}

		// Token: 0x060072EF RID: 29423 RVA: 0x0011223C File Offset: 0x0011043C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int TryGetHashCode(object o)
		{
			int result;
			if (ObjectHeader.TryGetHashCode(o, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x060072F0 RID: 29424 RVA: 0x00112256 File Offset: 0x00110456
		[NullableContext(2)]
		public new static bool Equals(object o1, object o2)
		{
			return o1 == o2 || (o1 != null && o2 != null && o1 is ValueType && ValueType.DefaultEquals(o1, o2));
		}

		// Token: 0x060072F1 RID: 29425
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: NotNullIfNotNull("obj")]
		public static extern object GetObjectValue(object obj);

		// Token: 0x060072F2 RID: 29426 RVA: 0x00112277 File Offset: 0x00110477
		[RequiresUnreferencedCode("Trimmer can't guarantee existence of class constructor")]
		public static void RunClassConstructor(RuntimeTypeHandle type)
		{
			if (type.Value == IntPtr.Zero)
			{
				throw new ArgumentException(SR.InvalidOperation_HandleIsNotInitialized, "type");
			}
			RuntimeHelpers.RunClassConstructor(type.Value);
		}

		// Token: 0x060072F3 RID: 29427 RVA: 0x001122A3 File Offset: 0x001104A3
		public static void EnsureSufficientExecutionStack()
		{
			if (RuntimeHelpers.SufficientExecutionStack())
			{
				return;
			}
			throw new InsufficientExecutionStackException();
		}

		// Token: 0x060072F4 RID: 29428 RVA: 0x001122B2 File Offset: 0x001104B2
		public static bool TryEnsureSufficientExecutionStack()
		{
			return RuntimeHelpers.SufficientExecutionStack();
		}

		// Token: 0x060072F5 RID: 29429 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public static void PrepareDelegate(Delegate d)
		{
		}

		// Token: 0x060072F6 RID: 29430 RVA: 0x001122B9 File Offset: 0x001104B9
		public static void PrepareMethod(RuntimeMethodHandle method)
		{
			if (method.IsNullHandle())
			{
				throw new ArgumentException(SR.Argument_InvalidHandle);
			}
			RuntimeHelpers.PrepareMethod(method.Value, null, 0);
		}

		// Token: 0x060072F7 RID: 29431 RVA: 0x001122E0 File Offset: 0x001104E0
		[NullableContext(2)]
		public unsafe static void PrepareMethod(RuntimeMethodHandle method, RuntimeTypeHandle[] instantiation)
		{
			if (method.IsNullHandle())
			{
				throw new ArgumentException(SR.Argument_InvalidHandle);
			}
			int ninst;
			IntPtr[] array;
			IntPtr* instantiations;
			if ((array = RuntimeTypeHandle.CopyRuntimeTypeHandles(instantiation, out ninst)) == null || array.Length == 0)
			{
				instantiations = null;
			}
			else
			{
				instantiations = &array[0];
			}
			RuntimeHelpers.PrepareMethod(method.Value, instantiations, ninst);
			GC.KeepAlive(instantiation);
			array = null;
		}

		// Token: 0x060072F8 RID: 29432 RVA: 0x00112336 File Offset: 0x00110536
		public static void RunModuleConstructor(ModuleHandle module)
		{
			if (module == ModuleHandle.EmptyHandle)
			{
				throw new ArgumentException(SR.InvalidOperation_HandleIsNotInitialized, "module");
			}
			RuntimeHelpers.RunModuleConstructor(module.Value);
		}

		// Token: 0x060072F9 RID: 29433 RVA: 0x00112361 File Offset: 0x00110561
		public static IntPtr AllocateTypeAssociatedMemory(Type type, int size)
		{
			if (!(type is RuntimeType))
			{
				throw new ArgumentException(SR.Arg_MustBeType, "type");
			}
			ArgumentOutOfRangeException.ThrowIfNegative<int>(size, "size");
			return NativeMemory.AllocZeroed((UIntPtr)size);
		}

		// Token: 0x060072FA RID: 29434 RVA: 0x0011238D File Offset: 0x0011058D
		[Intrinsic]
		internal static ref byte GetRawData(this object obj)
		{
			return obj.GetRawData();
		}

		// Token: 0x060072FB RID: 29435 RVA: 0x00112395 File Offset: 0x00110595
		[Intrinsic]
		internal static bool IsBitwiseEquatable<T>()
		{
			return RuntimeHelpers.IsBitwiseEquatable<T>();
		}

		// Token: 0x060072FC RID: 29436 RVA: 0x0011239C File Offset: 0x0011059C
		[Intrinsic]
		internal static bool ObjectHasComponentSize(object obj)
		{
			return RuntimeHelpers.ObjectHasComponentSize(obj);
		}

		// Token: 0x060072FD RID: 29437 RVA: 0x001123A4 File Offset: 0x001105A4
		[Intrinsic]
		internal static bool ObjectHasReferences(object obj)
		{
			return RuntimeTypeHandle.HasReferences(obj.GetType() as RuntimeType);
		}

		// Token: 0x060072FE RID: 29438 RVA: 0x001123B8 File Offset: 0x001105B8
		public static object GetUninitializedObject([DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)] Type type)
		{
			RuntimeType runtimeType = type as RuntimeType;
			if (runtimeType == null)
			{
				ArgumentNullException.ThrowIfNull(type, "type");
				throw new SerializationException(SR.Format(SR.Serialization_InvalidType, type));
			}
			return RuntimeHelpers.GetUninitializedObjectInternal(new RuntimeTypeHandle(runtimeType).Value);
		}

		// Token: 0x060072FF RID: 29439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void PrepareMethod(IntPtr method, IntPtr* instantiations, int ninst);

		// Token: 0x06007300 RID: 29440
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern object GetUninitializedObjectInternal(IntPtr type);

		// Token: 0x06007301 RID: 29441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitializeArray(Array array, IntPtr fldHandle);

		// Token: 0x06007302 RID: 29442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static ref extern byte GetSpanDataFrom(IntPtr fldHandle, IntPtr targetTypeHandle, IntPtr count);

		// Token: 0x06007303 RID: 29443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RunClassConstructor(IntPtr type);

		// Token: 0x06007304 RID: 29444
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RunModuleConstructor(IntPtr module);

		// Token: 0x06007305 RID: 29445
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool SufficientExecutionStack();

		// Token: 0x06007306 RID: 29446
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern object InternalBox(QCallTypeHandle type, ref byte target);

		// Token: 0x06007307 RID: 29447 RVA: 0x001123FC File Offset: 0x001105FC
		[NullableContext(2)]
		public unsafe static object Box(ref byte target, RuntimeTypeHandle type)
		{
			if (type.Value == 0)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.type);
			}
			if (Unsafe.IsNullRef<byte>(ref target))
			{
				throw new NullReferenceException();
			}
			RuntimeType runtimeType = (RuntimeType)Type.GetTypeFromHandle(type);
			if (runtimeType.ContainsGenericParameters || runtimeType.IsPointer || runtimeType.IsFunctionPointer || runtimeType.IsByRef || runtimeType.IsGenericParameter || runtimeType == typeof(void))
			{
				throw new ArgumentException(SR.Arg_TypeNotSupported);
			}
			if (!runtimeType.IsValueType)
			{
				return *Unsafe.As<byte, object>(ref target);
			}
			if (runtimeType.IsByRefLike)
			{
				throw new NotSupportedException(SR.NotSupported_ByRefLike);
			}
			return RuntimeHelpers.InternalBox(new QCallTypeHandle(ref runtimeType), ref target);
		}

		// Token: 0x06007308 RID: 29448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int SizeOf(QCallTypeHandle handle);

		// Token: 0x06007309 RID: 29449 RVA: 0x001124A8 File Offset: 0x001106A8
		public static int SizeOf(RuntimeTypeHandle type)
		{
			if (type.Value == IntPtr.Zero)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.type);
			}
			Type typeFromHandle = Type.GetTypeFromHandle(type);
			if (typeFromHandle.ContainsGenericParameters || typeFromHandle.IsGenericParameter || typeFromHandle == typeof(void))
			{
				throw new ArgumentException(SR.Arg_TypeNotSupported);
			}
			return RuntimeHelpers.SizeOf(new QCallTypeHandle(ref type));
		}

		// Token: 0x0600730A RID: 29450 RVA: 0x0011250C File Offset: 0x0011070C
		public static T[] GetSubArray<[Nullable(2)] T>(T[] array, Range range)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			ValueTuple<int, int> offsetAndLength = range.GetOffsetAndLength(array.Length);
			int item = offsetAndLength.Item1;
			int item2 = offsetAndLength.Item2;
			T[] array2;
			if (typeof(T[]) == array.GetType())
			{
				if (item2 == 0)
				{
					return Array.Empty<T>();
				}
				array2 = new T[item2];
			}
			else
			{
				array2 = Unsafe.As<T[]>(Array.CreateInstanceFromArrayType(array.GetType(), item2));
			}
			Buffer.Memmove<T>(MemoryMarshal.GetArrayDataReference<T>(array2), Unsafe.Add<T>(MemoryMarshal.GetArrayDataReference<T>(array), item), (UIntPtr)item2);
			return array2;
		}

		// Token: 0x0600730B RID: 29451 RVA: 0x00112590 File Offset: 0x00110790
		[Obsolete("The Constrained Execution Region (CER) feature is not supported.", DiagnosticId = "SYSLIB0004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public static void ExecuteCodeWithGuaranteedCleanup(RuntimeHelpers.TryCode code, RuntimeHelpers.CleanupCode backoutCode, [Nullable(2)] object userData)
		{
			ArgumentNullException.ThrowIfNull(code, "code");
			ArgumentNullException.ThrowIfNull(backoutCode, "backoutCode");
			bool exceptionThrown = true;
			try
			{
				code(userData);
				exceptionThrown = false;
			}
			finally
			{
				backoutCode(userData, exceptionThrown);
			}
		}

		// Token: 0x0600730C RID: 29452 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[Obsolete("The Constrained Execution Region (CER) feature is not supported.", DiagnosticId = "SYSLIB0004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public static void PrepareContractedDelegate(Delegate d)
		{
		}

		// Token: 0x0600730D RID: 29453 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[Obsolete("The Constrained Execution Region (CER) feature is not supported.", DiagnosticId = "SYSLIB0004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public static void ProbeForSufficientStack()
		{
		}

		// Token: 0x0600730E RID: 29454 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[Obsolete("The Constrained Execution Region (CER) feature is not supported.", DiagnosticId = "SYSLIB0004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public static void PrepareConstrainedRegions()
		{
		}

		// Token: 0x0600730F RID: 29455 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[Obsolete("The Constrained Execution Region (CER) feature is not supported.", DiagnosticId = "SYSLIB0004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public static void PrepareConstrainedRegionsNoOP()
		{
		}

		// Token: 0x06007310 RID: 29456 RVA: 0x001125DC File Offset: 0x001107DC
		internal static bool IsPrimitiveType(this CorElementType et)
		{
			return (1 << (int)et & 50348028) != 0;
		}

		// Token: 0x06007311 RID: 29457 RVA: 0x001125F0 File Offset: 0x001107F0
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static ReadOnlySpan<T> CreateSpan<T>(RuntimeFieldHandle fldHandle)
		{
			int length;
			return new ReadOnlySpan<T>(Unsafe.As<byte, T>(RuntimeHelpers.GetSpanDataFrom(fldHandle, typeof(T).TypeHandle, out length)), length);
		}

		// Token: 0x06007312 RID: 29458 RVA: 0x00007B65 File Offset: 0x00005D65
		[Intrinsic]
		internal static bool IsKnownConstant(Type t)
		{
			return false;
		}

		// Token: 0x06007313 RID: 29459 RVA: 0x00007B65 File Offset: 0x00005D65
		[Intrinsic]
		internal static bool IsKnownConstant(string t)
		{
			return false;
		}

		// Token: 0x06007314 RID: 29460 RVA: 0x00007B65 File Offset: 0x00005D65
		[Intrinsic]
		internal static bool IsKnownConstant(char t)
		{
			return false;
		}

		// Token: 0x06007315 RID: 29461 RVA: 0x00007B65 File Offset: 0x00005D65
		[Intrinsic]
		internal static bool IsKnownConstant<T>(T t) where T : struct
		{
			return false;
		}

		// Token: 0x06007316 RID: 29462 RVA: 0x0011261F File Offset: 0x0011081F
		[NullableContext(2)]
		[Intrinsic]
		public static bool IsReferenceOrContainsReferences<T>()
		{
			return RuntimeHelpers.IsReferenceOrContainsReferences<T>();
		}

		// Token: 0x0200065E RID: 1630
		// (Invoke) Token: 0x06007318 RID: 29464
		[NullableContext(0)]
		public delegate void TryCode(object userData);

		// Token: 0x0200065F RID: 1631
		// (Invoke) Token: 0x0600731C RID: 29468
		[NullableContext(0)]
		public delegate void CleanupCode(object userData, bool exceptionThrown);
	}
}
