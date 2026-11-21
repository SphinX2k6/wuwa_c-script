using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using System.Security;
using System.Text;
using System.Threading;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200059F RID: 1439
	[NullableContext(1)]
	[Nullable(0)]
	public static class Marshal
	{
		// Token: 0x06006EA0 RID: 28320
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetLastPInvokeError();

		// Token: 0x06006EA1 RID: 28321
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetLastPInvokeError(int error);

		// Token: 0x06006EA2 RID: 28322
		[RequiresDynamicCode("Marshalling code for the object might not be available. Use the DestroyStructure<T> overload instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyStructure(IntPtr ptr, Type structuretype);

		// Token: 0x06006EA3 RID: 28323
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr OffsetOf(Type t, string fieldName);

		// Token: 0x06006EA4 RID: 28324
		[RequiresDynamicCode("Marshalling code for the object might not be available. Use the StructureToPtr<T> overload instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld);

		// Token: 0x06006EA5 RID: 28325 RVA: 0x0010AD7F File Offset: 0x00108F7F
		internal static bool IsPinnable(object obj)
		{
			return obj == null || obj is string || !RuntimeTypeHandle.HasReferences(obj.GetType() as RuntimeType);
		}

		// Token: 0x06006EA6 RID: 28326 RVA: 0x0010ADA1 File Offset: 0x00108FA1
		private static void PrelinkCore(MethodInfo m)
		{
			if (!(m is RuntimeMethodInfo))
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeMethodInfo, "m");
			}
			Marshal.PrelinkInternal(m);
		}

		// Token: 0x06006EA7 RID: 28327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PtrToStructureHelper(IntPtr ptr, object structure, bool allowValueClasses);

		// Token: 0x06006EA8 RID: 28328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetDelegateForFunctionPointerInternal(QCallTypeHandle t, IntPtr ptr, ObjectHandleOnStack res);

		// Token: 0x06006EA9 RID: 28329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetFunctionPointerForDelegateInternal(Delegate d);

		// Token: 0x06006EAA RID: 28330 RVA: 0x0010ADC4 File Offset: 0x00108FC4
		private static Delegate GetDelegateForFunctionPointerInternal(IntPtr ptr, RuntimeType t)
		{
			Delegate result = null;
			Marshal.GetDelegateForFunctionPointerInternal(new QCallTypeHandle(ref t), ptr, ObjectHandleOnStack.Create<Delegate>(ref result));
			return result;
		}

		// Token: 0x06006EAB RID: 28331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PrelinkInternal(MethodInfo m);

		// Token: 0x06006EAC RID: 28332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int SizeOfHelper(QCallTypeHandle t, bool throwIfNotMarshalable);

		// Token: 0x06006EAD RID: 28333 RVA: 0x0010ADE8 File Offset: 0x00108FE8
		private static int SizeOfHelper(RuntimeType rttype, bool throwIfNotMarshalable)
		{
			return Marshal.SizeOfHelper(new QCallTypeHandle(ref rttype), throwIfNotMarshalable);
		}

		// Token: 0x06006EAE RID: 28334 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static IntPtr GetExceptionPointers()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006EAF RID: 28335 RVA: 0x0010ADF8 File Offset: 0x00108FF8
		private unsafe static void SetInvokeArgs(ref string cookie, IntPtr* params_byref)
		{
			ByReference byReference = ByReference.Create<string>(ref cookie);
			*(ByReference*)params_byref = byReference;
		}

		// Token: 0x06006EB0 RID: 28336 RVA: 0x0010AE14 File Offset: 0x00109014
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern", Justification = "Implementation detail of MarshalAs.CustomMarshaler")]
		internal unsafe static ICustomMarshaler GetCustomMarshalerInstance(Type type, string cookie)
		{
			ValueTuple<Type, string> key = new ValueTuple<Type, string>(type, cookie);
			Dictionary<ValueTuple<Type, string>, ICustomMarshaler> dictionary;
			if ((dictionary = Volatile.Read<Dictionary<ValueTuple<Type, string>, ICustomMarshaler>>(ref Marshal.MarshalerInstanceCache)) == null)
			{
				dictionary = (Interlocked.CompareExchange<Dictionary<ValueTuple<Type, string>, ICustomMarshaler>>(ref Marshal.MarshalerInstanceCache, new Dictionary<ValueTuple<Type, string>, ICustomMarshaler>(new Marshal.MarshalerInstanceKeyComparer()), null) ?? Marshal.MarshalerInstanceCache);
			}
			Dictionary<ValueTuple<Type, string>, ICustomMarshaler> dictionary2 = dictionary;
			Dictionary<ValueTuple<Type, string>, ICustomMarshaler> obj = dictionary2;
			ICustomMarshaler customMarshaler;
			bool flag2;
			lock (obj)
			{
				flag2 = dictionary2.TryGetValue(key, out customMarshaler);
			}
			if (!flag2)
			{
				RuntimeMethodInfo runtimeMethodInfo;
				try
				{
					runtimeMethodInfo = (RuntimeMethodInfo)type.GetMethod("GetInstance", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, new Type[]
					{
						typeof(string)
					}, null);
				}
				catch (AmbiguousMatchException)
				{
					throw new ApplicationException(SR.Format(SR.CustomMarshaler_MultipleGetInstanceMethods, type.FullName));
				}
				if (runtimeMethodInfo == null || runtimeMethodInfo.ReturnType != typeof(ICustomMarshaler))
				{
					throw new ApplicationException(SR.Format(SR.CustomMarshaler_NoGetInstanceMethod, type.FullName));
				}
				if (runtimeMethodInfo.ContainsGenericParameters)
				{
					throw new TypeLoadException(SR.Format(SR.CustomMarshaler_UnassignedGenericParams, type.FullName));
				}
				Exception ex;
				try
				{
					IntPtr intPtr = (IntPtr)0;
					IntPtr* ptr = &intPtr;
					Marshal.SetInvokeArgs(ref cookie, ptr);
					customMarshaler = (ICustomMarshaler)runtimeMethodInfo.InternalInvoke(null, ptr, out ex);
				}
				catch (Exception ex)
				{
					customMarshaler = null;
				}
				if (ex != null)
				{
					ExceptionDispatchInfo.Capture(ex).Throw();
				}
				if (customMarshaler == null)
				{
					throw new ApplicationException(SR.Format(SR.CustomMarshaler_NullReturnForGetInstance, type.FullName));
				}
				obj = dictionary2;
				lock (obj)
				{
					dictionary2[key] = customMarshaler;
				}
			}
			return customMarshaler;
		}

		// Token: 0x06006EB1 RID: 28337 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("GetExceptionCode() may be unavailable in future releases.")]
		public static int GetExceptionCode()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006EB2 RID: 28338 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("ReadByte(Object, Int32) may be unavailable in future releases.")]
		[RequiresDynamicCode("Marshalling code for the object might not be available")]
		public static byte ReadByte(object ptr, int ofs)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006EB3 RID: 28339 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("ReadInt16(Object, Int32) may be unavailable in future releases.")]
		[RequiresDynamicCode("Marshalling code for the object might not be available")]
		public static short ReadInt16(object ptr, int ofs)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006EB4 RID: 28340 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("ReadInt32(Object, Int32) may be unavailable in future releases.")]
		[RequiresDynamicCode("Marshalling code for the object might not be available")]
		public static int ReadInt32(object ptr, int ofs)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006EB5 RID: 28341 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("ReadInt64(Object, Int32) may be unavailable in future releases.")]
		[RequiresDynamicCode("Marshalling code for the object might not be available")]
		public static long ReadInt64(object ptr, int ofs)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006EB6 RID: 28342 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("WriteByte(Object, Int32, Byte) may be unavailable in future releases.")]
		[RequiresDynamicCode("Marshalling code for the object might not be available")]
		public static void WriteByte(object ptr, int ofs, byte val)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006EB7 RID: 28343 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("WriteInt16(Object, Int32, Int16) may be unavailable in future releases.")]
		[RequiresDynamicCode("Marshalling code for the object might not be available")]
		public static void WriteInt16(object ptr, int ofs, short val)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006EB8 RID: 28344 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("WriteInt32(Object, Int32, Int32) may be unavailable in future releases.")]
		[RequiresDynamicCode("Marshalling code for the object might not be available")]
		public static void WriteInt32(object ptr, int ofs, int val)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006EB9 RID: 28345 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("WriteInt64(Object, Int32, Int64) may be unavailable in future releases.")]
		[RequiresDynamicCode("Marshalling code for the object might not be available")]
		public static void WriteInt64(object ptr, int ofs, long val)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006EBA RID: 28346 RVA: 0x0010AFD0 File Offset: 0x001091D0
		public static IntPtr AllocHGlobal(int cb)
		{
			return Marshal.AllocHGlobal((IntPtr)cb);
		}

		// Token: 0x06006EBB RID: 28347 RVA: 0x0010AFD9 File Offset: 0x001091D9
		[NullableContext(2)]
		public static string PtrToStringAnsi(IntPtr ptr)
		{
			if (Marshal.IsNullOrWin32Atom(ptr))
			{
				return null;
			}
			return new string(ptr);
		}

		// Token: 0x06006EBC RID: 28348 RVA: 0x0010AFEB File Offset: 0x001091EB
		public static string PtrToStringAnsi(IntPtr ptr, int len)
		{
			ArgumentNullException.ThrowIfNull(ptr, "ptr");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(len, "len");
			return new string(ptr, 0, len);
		}

		// Token: 0x06006EBD RID: 28349 RVA: 0x0010B00B File Offset: 0x0010920B
		[NullableContext(2)]
		public static string PtrToStringUni(IntPtr ptr)
		{
			if (Marshal.IsNullOrWin32Atom(ptr))
			{
				return null;
			}
			return new string(ptr);
		}

		// Token: 0x06006EBE RID: 28350 RVA: 0x0010B01D File Offset: 0x0010921D
		public static string PtrToStringUni(IntPtr ptr, int len)
		{
			ArgumentNullException.ThrowIfNull(ptr, "ptr");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(len, "len");
			return new string(ptr, 0, len);
		}

		// Token: 0x06006EBF RID: 28351 RVA: 0x0010B040 File Offset: 0x00109240
		[NullableContext(2)]
		public static string PtrToStringUTF8(IntPtr ptr)
		{
			if (Marshal.IsNullOrWin32Atom(ptr))
			{
				return null;
			}
			int byteLength = string.strlen(ptr);
			return string.CreateStringFromEncoding(ptr, byteLength, Encoding.UTF8);
		}

		// Token: 0x06006EC0 RID: 28352 RVA: 0x0010B06A File Offset: 0x0010926A
		public static string PtrToStringUTF8(IntPtr ptr, int byteLen)
		{
			ArgumentNullException.ThrowIfNull(ptr, "ptr");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteLen, "byteLen");
			return string.CreateStringFromEncoding(ptr, byteLen, Encoding.UTF8);
		}

		// Token: 0x06006EC1 RID: 28353 RVA: 0x0010B08E File Offset: 0x0010928E
		[RequiresDynamicCode("Marshalling code for the object might not be available. Use the SizeOf<T> overload instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static int SizeOf(object structure)
		{
			ArgumentNullException.ThrowIfNull(structure, "structure");
			return Marshal.SizeOfHelper((RuntimeType)structure.GetType(), true);
		}

		// Token: 0x06006EC2 RID: 28354 RVA: 0x0010B0AC File Offset: 0x001092AC
		public static int SizeOf<[Nullable(2)] T>(T structure)
		{
			ArgumentNullException.ThrowIfNull(structure, "structure");
			return Marshal.SizeOfHelper((RuntimeType)structure.GetType(), true);
		}

		// Token: 0x06006EC3 RID: 28355 RVA: 0x0010B0D8 File Offset: 0x001092D8
		[RequiresDynamicCode("Marshalling code for the object might not be available. Use the SizeOf<T> overload instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static int SizeOf(Type t)
		{
			ArgumentNullException.ThrowIfNull(t, "t");
			RuntimeType runtimeType = t as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeType, "t");
			}
			if (runtimeType.IsGenericType)
			{
				throw new ArgumentException(SR.Argument_NeedNonGenericType, "t");
			}
			return Marshal.SizeOfHelper(runtimeType, true);
		}

		// Token: 0x06006EC4 RID: 28356 RVA: 0x0010B127 File Offset: 0x00109327
		[NullableContext(2)]
		public static int SizeOf<T>()
		{
			RuntimeType runtimeType = (RuntimeType)typeof(T);
			if (runtimeType.IsGenericType)
			{
				throw new ArgumentException(SR.Argument_NeedNonGenericType, "T");
			}
			return Marshal.SizeOfHelper(runtimeType, true);
		}

		// Token: 0x06006EC5 RID: 28357 RVA: 0x0010B158 File Offset: 0x00109358
		public unsafe static int QueryInterface(IntPtr pUnk, in Guid iid, out IntPtr ppv)
		{
			ArgumentNullException.ThrowIfNull(pUnk, "pUnk");
			fixed (Guid* ptr = &iid)
			{
				Guid* ptr2 = ptr;
				fixed (IntPtr* ptr3 = &ppv)
				{
					IntPtr* ptr4 = ptr3;
					method <<<NULL>>> = *(*pUnk);
					pUnk;
					ptr2;
					ptr4;
					int result = <<<NULL>>>;
					calli();
					return result;
				}
			}
		}

		// Token: 0x06006EC6 RID: 28358 RVA: 0x0010B18C File Offset: 0x0010938C
		public unsafe static int AddRef(IntPtr pUnk)
		{
			ArgumentNullException.ThrowIfNull(pUnk, "pUnk");
			method <<<NULL>>> = *(*pUnk + (IntPtr)sizeof(void*));
			pUnk;
			int result = <<<NULL>>>;
			calli();
			return result;
		}

		// Token: 0x06006EC7 RID: 28359 RVA: 0x0010B1B8 File Offset: 0x001093B8
		public unsafe static int Release(IntPtr pUnk)
		{
			ArgumentNullException.ThrowIfNull(pUnk, "pUnk");
			method <<<NULL>>> = *(*pUnk + (IntPtr)2 * (IntPtr)sizeof(void*));
			pUnk;
			int result = <<<NULL>>>;
			calli();
			return result;
		}

		// Token: 0x06006EC8 RID: 28360 RVA: 0x0010B1E5 File Offset: 0x001093E5
		[EditorBrowsable(EditorBrowsableState.Never)]
		public unsafe static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index)
		{
			ArgumentNullException.ThrowIfNull(arr, "arr");
			return (byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetArrayDataReference(arr)) + (ulong)((UIntPtr)index * (UIntPtr)((IntPtr)arr.GetElementSize()));
		}

		// Token: 0x06006EC9 RID: 28361 RVA: 0x0010B20A File Offset: 0x0010940A
		public unsafe static IntPtr UnsafeAddrOfPinnedArrayElement<[Nullable(2)] T>(T[] arr, int index)
		{
			ArgumentNullException.ThrowIfNull(arr, "arr");
			return (byte*)Unsafe.AsPointer<T>(MemoryMarshal.GetArrayDataReference<T>(arr)) + (ulong)((UIntPtr)index * (UIntPtr)((IntPtr)sizeof(T)));
		}

		// Token: 0x06006ECA RID: 28362 RVA: 0x0010B22F File Offset: 0x0010942F
		public static IntPtr OffsetOf<[Nullable(2)] T>(string fieldName)
		{
			return Marshal.OffsetOf(typeof(T), fieldName);
		}

		// Token: 0x06006ECB RID: 28363 RVA: 0x0010B241 File Offset: 0x00109441
		public static void Copy(int[] source, int startIndex, IntPtr destination, int length)
		{
			Marshal.CopyToNative<int>(source, startIndex, destination, length);
		}

		// Token: 0x06006ECC RID: 28364 RVA: 0x0010B24C File Offset: 0x0010944C
		public static void Copy(char[] source, int startIndex, IntPtr destination, int length)
		{
			Marshal.CopyToNative<char>(source, startIndex, destination, length);
		}

		// Token: 0x06006ECD RID: 28365 RVA: 0x0010B257 File Offset: 0x00109457
		public static void Copy(short[] source, int startIndex, IntPtr destination, int length)
		{
			Marshal.CopyToNative<short>(source, startIndex, destination, length);
		}

		// Token: 0x06006ECE RID: 28366 RVA: 0x0010B262 File Offset: 0x00109462
		public static void Copy(long[] source, int startIndex, IntPtr destination, int length)
		{
			Marshal.CopyToNative<long>(source, startIndex, destination, length);
		}

		// Token: 0x06006ECF RID: 28367 RVA: 0x0010B26D File Offset: 0x0010946D
		public static void Copy(float[] source, int startIndex, IntPtr destination, int length)
		{
			Marshal.CopyToNative<float>(source, startIndex, destination, length);
		}

		// Token: 0x06006ED0 RID: 28368 RVA: 0x0010B278 File Offset: 0x00109478
		public static void Copy(double[] source, int startIndex, IntPtr destination, int length)
		{
			Marshal.CopyToNative<double>(source, startIndex, destination, length);
		}

		// Token: 0x06006ED1 RID: 28369 RVA: 0x0010B283 File Offset: 0x00109483
		public static void Copy(byte[] source, int startIndex, IntPtr destination, int length)
		{
			Marshal.CopyToNative<byte>(source, startIndex, destination, length);
		}

		// Token: 0x06006ED2 RID: 28370 RVA: 0x0010B28E File Offset: 0x0010948E
		public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length)
		{
			Marshal.CopyToNative<IntPtr>(source, startIndex, destination, length);
		}

		// Token: 0x06006ED3 RID: 28371 RVA: 0x0010B29C File Offset: 0x0010949C
		private static void CopyToNative<T>(T[] source, int startIndex, IntPtr destination, int length)
		{
			ArgumentNullException.ThrowIfNull(source, "source");
			ArgumentNullException.ThrowIfNull(destination, "destination");
			new Span<T>(source, startIndex, length).CopyTo(new Span<T>(destination, length));
		}

		// Token: 0x06006ED4 RID: 28372 RVA: 0x0010B2D6 File Offset: 0x001094D6
		public static void Copy(IntPtr source, int[] destination, int startIndex, int length)
		{
			Marshal.CopyToManaged<int>(source, destination, startIndex, length);
		}

		// Token: 0x06006ED5 RID: 28373 RVA: 0x0010B2E1 File Offset: 0x001094E1
		public static void Copy(IntPtr source, char[] destination, int startIndex, int length)
		{
			Marshal.CopyToManaged<char>(source, destination, startIndex, length);
		}

		// Token: 0x06006ED6 RID: 28374 RVA: 0x0010B2EC File Offset: 0x001094EC
		public static void Copy(IntPtr source, short[] destination, int startIndex, int length)
		{
			Marshal.CopyToManaged<short>(source, destination, startIndex, length);
		}

		// Token: 0x06006ED7 RID: 28375 RVA: 0x0010B2F7 File Offset: 0x001094F7
		public static void Copy(IntPtr source, long[] destination, int startIndex, int length)
		{
			Marshal.CopyToManaged<long>(source, destination, startIndex, length);
		}

		// Token: 0x06006ED8 RID: 28376 RVA: 0x0010B302 File Offset: 0x00109502
		public static void Copy(IntPtr source, float[] destination, int startIndex, int length)
		{
			Marshal.CopyToManaged<float>(source, destination, startIndex, length);
		}

		// Token: 0x06006ED9 RID: 28377 RVA: 0x0010B30D File Offset: 0x0010950D
		public static void Copy(IntPtr source, double[] destination, int startIndex, int length)
		{
			Marshal.CopyToManaged<double>(source, destination, startIndex, length);
		}

		// Token: 0x06006EDA RID: 28378 RVA: 0x0010B318 File Offset: 0x00109518
		public static void Copy(IntPtr source, byte[] destination, int startIndex, int length)
		{
			Marshal.CopyToManaged<byte>(source, destination, startIndex, length);
		}

		// Token: 0x06006EDB RID: 28379 RVA: 0x0010B323 File Offset: 0x00109523
		public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length)
		{
			Marshal.CopyToManaged<IntPtr>(source, destination, startIndex, length);
		}

		// Token: 0x06006EDC RID: 28380 RVA: 0x0010B330 File Offset: 0x00109530
		private static void CopyToManaged<T>(IntPtr source, T[] destination, int startIndex, int length)
		{
			ArgumentNullException.ThrowIfNull(destination, "destination");
			ArgumentNullException.ThrowIfNull(source, "source");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(startIndex, "startIndex");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			new Span<T>(source, length).CopyTo(new Span<T>(destination, startIndex, length));
		}

		// Token: 0x06006EDD RID: 28381 RVA: 0x0010B380 File Offset: 0x00109580
		public unsafe static byte ReadByte(IntPtr ptr, int ofs)
		{
			byte result;
			try
			{
				result = *(ptr + (IntPtr)ofs);
			}
			catch (NullReferenceException)
			{
				throw new AccessViolationException();
			}
			return result;
		}

		// Token: 0x06006EDE RID: 28382 RVA: 0x0010B3AC File Offset: 0x001095AC
		public static byte ReadByte(IntPtr ptr)
		{
			return Marshal.ReadByte(ptr, 0);
		}

		// Token: 0x06006EDF RID: 28383 RVA: 0x0010B3B8 File Offset: 0x001095B8
		public unsafe static short ReadInt16(IntPtr ptr, int ofs)
		{
			short result;
			try
			{
				byte* ptr2 = ptr + (IntPtr)ofs;
				if ((ptr2 & 1) == 0)
				{
					result = *(short*)ptr2;
				}
				else
				{
					result = Unsafe.ReadUnaligned<short>((void*)ptr2);
				}
			}
			catch (NullReferenceException)
			{
				throw new AccessViolationException();
			}
			return result;
		}

		// Token: 0x06006EE0 RID: 28384 RVA: 0x0010B3F8 File Offset: 0x001095F8
		public static short ReadInt16(IntPtr ptr)
		{
			return Marshal.ReadInt16(ptr, 0);
		}

		// Token: 0x06006EE1 RID: 28385 RVA: 0x0010B404 File Offset: 0x00109604
		public unsafe static int ReadInt32(IntPtr ptr, int ofs)
		{
			int result;
			try
			{
				byte* ptr2 = ptr + (IntPtr)ofs;
				if ((ptr2 & 3) == 0)
				{
					result = *(int*)ptr2;
				}
				else
				{
					result = Unsafe.ReadUnaligned<int>((void*)ptr2);
				}
			}
			catch (NullReferenceException)
			{
				throw new AccessViolationException();
			}
			return result;
		}

		// Token: 0x06006EE2 RID: 28386 RVA: 0x0010B444 File Offset: 0x00109644
		public static int ReadInt32(IntPtr ptr)
		{
			return Marshal.ReadInt32(ptr, 0);
		}

		// Token: 0x06006EE3 RID: 28387 RVA: 0x0010B44D File Offset: 0x0010964D
		[RequiresDynamicCode("Marshalling code for the object might not be available")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("ReadIntPtr(Object, Int32) may be unavailable in future releases.")]
		public static IntPtr ReadIntPtr(object ptr, int ofs)
		{
			return (IntPtr)Marshal.ReadInt64(ptr, ofs);
		}

		// Token: 0x06006EE4 RID: 28388 RVA: 0x0010B457 File Offset: 0x00109657
		public static IntPtr ReadIntPtr(IntPtr ptr, int ofs)
		{
			return (IntPtr)Marshal.ReadInt64(ptr, ofs);
		}

		// Token: 0x06006EE5 RID: 28389 RVA: 0x0010B461 File Offset: 0x00109661
		public static IntPtr ReadIntPtr(IntPtr ptr)
		{
			return Marshal.ReadIntPtr(ptr, 0);
		}

		// Token: 0x06006EE6 RID: 28390 RVA: 0x0010B46C File Offset: 0x0010966C
		public unsafe static long ReadInt64(IntPtr ptr, int ofs)
		{
			long result;
			try
			{
				byte* ptr2 = ptr + (IntPtr)ofs;
				if ((ptr2 & 7) == 0)
				{
					result = *(long*)ptr2;
				}
				else
				{
					result = Unsafe.ReadUnaligned<long>((void*)ptr2);
				}
			}
			catch (NullReferenceException)
			{
				throw new AccessViolationException();
			}
			return result;
		}

		// Token: 0x06006EE7 RID: 28391 RVA: 0x0010B4AC File Offset: 0x001096AC
		public static long ReadInt64(IntPtr ptr)
		{
			return Marshal.ReadInt64(ptr, 0);
		}

		// Token: 0x06006EE8 RID: 28392 RVA: 0x0010B4B8 File Offset: 0x001096B8
		public unsafe static void WriteByte(IntPtr ptr, int ofs, byte val)
		{
			try
			{
				*(ptr + (IntPtr)ofs) = val;
			}
			catch (NullReferenceException)
			{
				throw new AccessViolationException();
			}
		}

		// Token: 0x06006EE9 RID: 28393 RVA: 0x0010B4E4 File Offset: 0x001096E4
		public static void WriteByte(IntPtr ptr, byte val)
		{
			Marshal.WriteByte(ptr, 0, val);
		}

		// Token: 0x06006EEA RID: 28394 RVA: 0x0010B4F0 File Offset: 0x001096F0
		public unsafe static void WriteInt16(IntPtr ptr, int ofs, short val)
		{
			try
			{
				byte* ptr2 = ptr + (IntPtr)ofs;
				if ((ptr2 & 1) == 0)
				{
					*(short*)ptr2 = val;
				}
				else
				{
					Unsafe.WriteUnaligned<short>((void*)ptr2, val);
				}
			}
			catch (NullReferenceException)
			{
				throw new AccessViolationException();
			}
		}

		// Token: 0x06006EEB RID: 28395 RVA: 0x0010B52C File Offset: 0x0010972C
		public static void WriteInt16(IntPtr ptr, short val)
		{
			Marshal.WriteInt16(ptr, 0, val);
		}

		// Token: 0x06006EEC RID: 28396 RVA: 0x0010B536 File Offset: 0x00109736
		public static void WriteInt16(IntPtr ptr, int ofs, char val)
		{
			Marshal.WriteInt16(ptr, ofs, (short)val);
		}

		// Token: 0x06006EED RID: 28397 RVA: 0x0010B541 File Offset: 0x00109741
		[RequiresDynamicCode("Marshalling code for the object might not be available")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("WriteInt16(Object, Int32, Char) may be unavailable in future releases.")]
		public static void WriteInt16([In] [Out] object ptr, int ofs, char val)
		{
			Marshal.WriteInt16(ptr, ofs, (short)val);
		}

		// Token: 0x06006EEE RID: 28398 RVA: 0x0010B54C File Offset: 0x0010974C
		public static void WriteInt16(IntPtr ptr, char val)
		{
			Marshal.WriteInt16(ptr, 0, (short)val);
		}

		// Token: 0x06006EEF RID: 28399 RVA: 0x0010B558 File Offset: 0x00109758
		public unsafe static void WriteInt32(IntPtr ptr, int ofs, int val)
		{
			try
			{
				byte* ptr2 = ptr + (IntPtr)ofs;
				if ((ptr2 & 3) == 0)
				{
					*(int*)ptr2 = val;
				}
				else
				{
					Unsafe.WriteUnaligned<int>((void*)ptr2, val);
				}
			}
			catch (NullReferenceException)
			{
				throw new AccessViolationException();
			}
		}

		// Token: 0x06006EF0 RID: 28400 RVA: 0x0010B594 File Offset: 0x00109794
		public static void WriteInt32(IntPtr ptr, int val)
		{
			Marshal.WriteInt32(ptr, 0, val);
		}

		// Token: 0x06006EF1 RID: 28401 RVA: 0x0010B59E File Offset: 0x0010979E
		public static void WriteIntPtr(IntPtr ptr, int ofs, IntPtr val)
		{
			Marshal.WriteInt64(ptr, ofs, (long)val);
		}

		// Token: 0x06006EF2 RID: 28402 RVA: 0x0010B5A9 File Offset: 0x001097A9
		[RequiresDynamicCode("Marshalling code for the object might not be available")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("WriteIntPtr(Object, Int32, IntPtr) may be unavailable in future releases.")]
		public static void WriteIntPtr(object ptr, int ofs, IntPtr val)
		{
			Marshal.WriteInt64(ptr, ofs, (long)val);
		}

		// Token: 0x06006EF3 RID: 28403 RVA: 0x0010B5B4 File Offset: 0x001097B4
		public static void WriteIntPtr(IntPtr ptr, IntPtr val)
		{
			Marshal.WriteIntPtr(ptr, 0, val);
		}

		// Token: 0x06006EF4 RID: 28404 RVA: 0x0010B5C0 File Offset: 0x001097C0
		public unsafe static void WriteInt64(IntPtr ptr, int ofs, long val)
		{
			try
			{
				byte* ptr2 = ptr + (IntPtr)ofs;
				if ((ptr2 & 7) == 0)
				{
					*(long*)ptr2 = val;
				}
				else
				{
					Unsafe.WriteUnaligned<long>((void*)ptr2, val);
				}
			}
			catch (NullReferenceException)
			{
				throw new AccessViolationException();
			}
		}

		// Token: 0x06006EF5 RID: 28405 RVA: 0x0010B5FC File Offset: 0x001097FC
		public static void WriteInt64(IntPtr ptr, long val)
		{
			Marshal.WriteInt64(ptr, 0, val);
		}

		// Token: 0x06006EF6 RID: 28406 RVA: 0x0010B606 File Offset: 0x00109806
		public static void Prelink(MethodInfo m)
		{
			ArgumentNullException.ThrowIfNull(m, "m");
			Marshal.PrelinkCore(m);
		}

		// Token: 0x06006EF7 RID: 28407 RVA: 0x0010B61C File Offset: 0x0010981C
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern", Justification = "This only needs to prelink methods that are actually used")]
		public static void PrelinkAll(Type c)
		{
			ArgumentNullException.ThrowIfNull(c, "c");
			MethodInfo[] methods = c.GetMethods();
			for (int i = 0; i < methods.Length; i++)
			{
				Marshal.Prelink(methods[i]);
			}
		}

		// Token: 0x06006EF8 RID: 28408 RVA: 0x0010B651 File Offset: 0x00109851
		[UnconditionalSuppressMessage("AotAnalysis", "IL3050:AotUnfriendlyApi", Justification = "AOT compilers can see the T.")]
		public static void StructureToPtr<[Nullable(2)] T>([DisallowNull] T structure, IntPtr ptr, bool fDeleteOld)
		{
			Marshal.StructureToPtr(structure, ptr, fDeleteOld);
		}

		// Token: 0x06006EF9 RID: 28409 RVA: 0x0010B660 File Offset: 0x00109860
		[RequiresDynamicCode("Marshalling code for the object might not be available")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[return: Nullable(2)]
		public static object PtrToStructure(IntPtr ptr, [DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)] Type structureType)
		{
			ArgumentNullException.ThrowIfNull(structureType, "structureType");
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			if (structureType.IsGenericType)
			{
				throw new ArgumentException(SR.Argument_NeedNonGenericType, "structureType");
			}
			if (!(structureType is RuntimeType))
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeType, "structureType");
			}
			object obj = Activator.CreateInstance(structureType, true);
			Marshal.PtrToStructureHelper(ptr, obj, true);
			return obj;
		}

		// Token: 0x06006EFA RID: 28410 RVA: 0x0010B6C3 File Offset: 0x001098C3
		[RequiresDynamicCode("Marshalling code for the object might not be available")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void PtrToStructure(IntPtr ptr, object structure)
		{
			ArgumentNullException.ThrowIfNull(ptr, "ptr");
			ArgumentNullException.ThrowIfNull(structure, "structure");
			Marshal.PtrToStructureHelper(ptr, structure, false);
		}

		// Token: 0x06006EFB RID: 28411 RVA: 0x0010B6E4 File Offset: 0x001098E4
		public static void PtrToStructure<[Nullable(2)] T>(IntPtr ptr, [DisallowNull] T structure)
		{
			ArgumentNullException.ThrowIfNull(ptr, "ptr");
			object obj = structure;
			ArgumentNullException.ThrowIfNull(obj, "structure");
			Marshal.PtrToStructureHelper(ptr, obj, false);
		}

		// Token: 0x06006EFC RID: 28412 RVA: 0x0010B718 File Offset: 0x00109918
		[NullableContext(2)]
		public static T PtrToStructure<[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)] T>(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return (T)((object)null);
			}
			Type typeFromHandle = typeof(T);
			if (typeFromHandle.IsGenericType)
			{
				throw new ArgumentException(SR.Argument_NeedNonGenericType, "T");
			}
			object obj = Activator.CreateInstance(typeFromHandle, true);
			Marshal.PtrToStructureHelper(ptr, obj, true);
			return (T)((object)obj);
		}

		// Token: 0x06006EFD RID: 28413 RVA: 0x0010B76B File Offset: 0x0010996B
		[NullableContext(2)]
		[UnconditionalSuppressMessage("AotAnalysis", "IL3050:AotUnfriendlyApi", Justification = "AOT compilers can see the T.")]
		public static void DestroyStructure<T>(IntPtr ptr)
		{
			Marshal.DestroyStructure(ptr, typeof(T));
		}

		// Token: 0x06006EFE RID: 28414 RVA: 0x0010B77D File Offset: 0x0010997D
		[RequiresAssemblyFiles("Windows only assigns HINSTANCE to assemblies loaded from disk. This API will return -1 for modules without a file on disk.")]
		public static IntPtr GetHINSTANCE(Module m)
		{
			ArgumentNullException.ThrowIfNull(m, "m");
			return (IntPtr)(-1);
		}

		// Token: 0x06006EFF RID: 28415 RVA: 0x0010B78C File Offset: 0x0010998C
		[NullableContext(2)]
		public static Exception GetExceptionForHR(int errorCode)
		{
			return Marshal.GetExceptionForHR(errorCode, IntPtr.Zero);
		}

		// Token: 0x06006F00 RID: 28416 RVA: 0x0010B799 File Offset: 0x00109999
		[NullableContext(2)]
		public static Exception GetExceptionForHR(int errorCode, IntPtr errorInfo)
		{
			if (errorCode >= 0)
			{
				return null;
			}
			return Marshal.GetExceptionForHRInternal(errorCode, errorInfo);
		}

		// Token: 0x06006F01 RID: 28417 RVA: 0x0010B7A8 File Offset: 0x001099A8
		private static Exception GetExceptionForHRInternal(int errorCode, IntPtr errorInfo)
		{
			if (errorCode <= -2147024690)
			{
				if (errorCode <= -2147024891)
				{
					if (errorCode <= -2147467261)
					{
						if (errorCode != -2147483629)
						{
							if (errorCode == -2147475171)
							{
								return new AmbiguousMatchException();
							}
							switch (errorCode)
							{
							case -2147467263:
								return new NotImplementedException();
							case -2147467262:
								return new InvalidCastException();
							case -2147467261:
								return new NullReferenceException();
							default:
								goto IL_521;
							}
						}
					}
					else if (errorCode <= -2147352558)
					{
						if (errorCode == -2147352562)
						{
							return new TargetParameterCountException();
						}
						if (errorCode != -2147352558)
						{
							goto IL_521;
						}
						return new DivideByZeroException();
					}
					else
					{
						if (errorCode == -2147287037)
						{
							goto IL_4FA;
						}
						switch (errorCode)
						{
						case -2147024894:
							return new FileNotFoundException();
						case -2147024893:
							return new DirectoryNotFoundException();
						case -2147024892:
							goto IL_507;
						case -2147024891:
							return new UnauthorizedAccessException();
						default:
							goto IL_521;
						}
					}
				}
				else if (errorCode <= -2147024858)
				{
					if (errorCode <= -2147024882)
					{
						if (errorCode == -2147024885)
						{
							return new BadImageFormatException();
						}
						if (errorCode != -2147024882)
						{
							goto IL_521;
						}
						return new OutOfMemoryException();
					}
					else
					{
						if (errorCode - -2147024864 <= 1)
						{
							goto IL_507;
						}
						if (errorCode != -2147024858)
						{
							goto IL_521;
						}
						return new EndOfStreamException();
					}
				}
				else if (errorCode <= -2147024786)
				{
					if (errorCode == -2147024809)
					{
						return new ArgumentException();
					}
					if (errorCode != -2147024786)
					{
						goto IL_521;
					}
					goto IL_507;
				}
				else
				{
					if (errorCode == -2147024703)
					{
						return new BadImageFormatException();
					}
					if (errorCode != -2147024690)
					{
						goto IL_521;
					}
					return new PathTooLongException();
				}
			}
			else if (errorCode <= -2146828212)
			{
				if (errorCode <= -2147023890)
				{
					if (errorCode == -2147024362)
					{
						return new ArithmeticException();
					}
					if (errorCode == -2147023895)
					{
						return new StackOverflowException();
					}
					if (errorCode - -2147023891 > 1)
					{
						goto IL_521;
					}
					goto IL_507;
				}
				else if (errorCode <= -2147023503)
				{
					if (errorCode != -2147023782 && errorCode != -2147023503)
					{
						goto IL_521;
					}
					goto IL_507;
				}
				else
				{
					if (errorCode == -2146828235)
					{
						return new FileNotFoundException
						{
							HResult = errorCode
						};
					}
					if (errorCode != -2146828212)
					{
						goto IL_521;
					}
					goto IL_4FA;
				}
			}
			else if (errorCode <= -2146234297)
			{
				if (errorCode <= -2146234346)
				{
					if (errorCode == -2146234349)
					{
						return new TypeUnloadedException();
					}
					if (errorCode != -2146234346)
					{
						goto IL_521;
					}
					goto IL_507;
				}
				else
				{
					if (errorCode != -2146234304 && errorCode != -2146234297)
					{
						goto IL_521;
					}
					goto IL_507;
				}
			}
			else if (errorCode <= -2146232968)
			{
				switch (errorCode)
				{
				case -2146233088:
					return new Exception();
				case -2146233087:
					return new SystemException();
				case -2146233086:
					return new ArgumentOutOfRangeException();
				case -2146233085:
					return new ArrayTypeMismatchException();
				case -2146233084:
				case -2146233083:
				case -2146233077:
				case -2146233074:
				case -2146233073:
				case -2146233061:
				case -2146233060:
				case -2146233059:
				case -2146233058:
				case -2146233057:
				case -2146233055:
				case -2146233050:
				case -2146233049:
				case -2146233046:
				case -2146233045:
				case -2146233044:
				case -2146233043:
				case -2146233042:
				case -2146233041:
				case -2146233037:
				case -2146233034:
				case -2146233032:
				case -2146233028:
				case -2146233027:
				case -2146233025:
				case -2146233024:
				case -2146233022:
					goto IL_521;
				case -2146233082:
					return new ExecutionEngineException();
				case -2146233081:
					return new FieldAccessException();
				case -2146233080:
					return new IndexOutOfRangeException();
				case -2146233079:
					return new InvalidOperationException();
				case -2146233078:
					return new SecurityException();
				case -2146233076:
					return new SerializationException();
				case -2146233075:
					return new VerificationException();
				case -2146233072:
					return new MethodAccessException();
				case -2146233071:
					return new MissingFieldException();
				case -2146233070:
					return new MissingMemberException();
				case -2146233069:
					return new MissingMethodException();
				case -2146233068:
					return new MulticastNotSupportedException();
				case -2146233067:
					return new NotSupportedException();
				case -2146233066:
					return new OverflowException();
				case -2146233065:
					return new RankException();
				case -2146233064:
					return new SynchronizationLockException();
				case -2146233063:
					return new ThreadInterruptedException();
				case -2146233062:
					return new MemberAccessException();
				case -2146233056:
					return new ThreadStateException();
				case -2146233054:
					return new TypeLoadException();
				case -2146233053:
					return new EntryPointNotFoundException();
				case -2146233052:
					return new DllNotFoundException();
				case -2146233051:
					return new ThreadStartException();
				case -2146233048:
					return new NotFiniteNumberException();
				case -2146233047:
					return new DuplicateWaitObjectException();
				case -2146233040:
					return new ThreadAbortException();
				case -2146233039:
					return new InvalidOleVariantTypeException();
				case -2146233038:
					return new MissingManifestResourceException();
				case -2146233036:
					return new TypeInitializationException(null);
				case -2146233035:
					return new MarshalDirectiveException();
				case -2146233033:
					return new FormatException();
				case -2146233031:
					return new PlatformNotSupportedException();
				case -2146233030:
					return new InvalidProgramException();
				case -2146233029:
					return new OperationCanceledException();
				case -2146233026:
					return new MissingMethodException();
				case -2146233023:
					return new DataMisalignedException();
				case -2146233021:
					return new TypeAccessException();
				default:
					if (errorCode != -2146232968)
					{
						goto IL_521;
					}
					return new InsufficientExecutionStackException();
				}
			}
			else
			{
				switch (errorCode)
				{
				case -2146232832:
					return new ApplicationException();
				case -2146232831:
					return new InvalidFilterCriteriaException();
				case -2146232830:
					return new MissingMethodException();
				case -2146232829:
					return new TargetException();
				case -2146232828:
					return new MissingMethodException();
				case -2146232827:
					return new CustomAttributeFormatException();
				default:
					switch (errorCode)
					{
					case -2146232800:
						return new IOException();
					case -2146232799:
						return new FileLoadException();
					case -2146232798:
						break;
					default:
						goto IL_521;
					}
					break;
				}
			}
			return new ObjectDisposedException(null);
			IL_4FA:
			return new DirectoryNotFoundException
			{
				HResult = errorCode
			};
			IL_507:
			return new FileLoadException
			{
				HResult = errorCode
			};
			IL_521:
			return new COMException(null, errorCode);
		}

		// Token: 0x06006F02 RID: 28418 RVA: 0x0010BCDD File Offset: 0x00109EDD
		public static void ThrowExceptionForHR(int errorCode)
		{
			if (errorCode < 0)
			{
				throw Marshal.GetExceptionForHR(errorCode);
			}
		}

		// Token: 0x06006F03 RID: 28419 RVA: 0x0010BCEA File Offset: 0x00109EEA
		public static void ThrowExceptionForHR(int errorCode, IntPtr errorInfo)
		{
			if (errorCode < 0)
			{
				throw Marshal.GetExceptionForHR(errorCode, errorInfo);
			}
		}

		// Token: 0x06006F04 RID: 28420 RVA: 0x0010BCF8 File Offset: 0x00109EF8
		public static IntPtr SecureStringToBSTR(SecureString s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return s.MarshalToBSTR();
		}

		// Token: 0x06006F05 RID: 28421 RVA: 0x0010BD0A File Offset: 0x00109F0A
		public static IntPtr SecureStringToCoTaskMemAnsi(SecureString s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return s.MarshalToString(false, false);
		}

		// Token: 0x06006F06 RID: 28422 RVA: 0x0010BD1E File Offset: 0x00109F1E
		public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return s.MarshalToString(false, true);
		}

		// Token: 0x06006F07 RID: 28423 RVA: 0x0010BD32 File Offset: 0x00109F32
		public static IntPtr SecureStringToGlobalAllocAnsi(SecureString s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return s.MarshalToString(true, false);
		}

		// Token: 0x06006F08 RID: 28424 RVA: 0x0010BD46 File Offset: 0x00109F46
		public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return s.MarshalToString(true, true);
		}

		// Token: 0x06006F09 RID: 28425 RVA: 0x0010BD5C File Offset: 0x00109F5C
		[NullableContext(2)]
		public static IntPtr StringToHGlobalAnsi(string s)
		{
			if (s == null)
			{
				return IntPtr.Zero;
			}
			long num = (long)(s.Length + 1) * (long)Marshal.SystemMaxDBCSCharSize;
			int num2 = (int)num;
			if ((long)num2 != num)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.s);
			}
			IntPtr intPtr = Marshal.AllocHGlobal((IntPtr)num2);
			Marshal.StringToAnsiString(s, intPtr, num2, false, false);
			return intPtr;
		}

		// Token: 0x06006F0A RID: 28426 RVA: 0x0010BDA8 File Offset: 0x00109FA8
		[NullableContext(2)]
		public unsafe static IntPtr StringToHGlobalUni(string s)
		{
			if (s == null)
			{
				return IntPtr.Zero;
			}
			int num = (s.Length + 1) * 2;
			if (num < s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.s);
			}
			IntPtr intPtr = Marshal.AllocHGlobal((IntPtr)num);
			s.CopyTo(new Span<char>(intPtr, s.Length));
			*(intPtr + (IntPtr)s.Length * 2) = 0;
			return intPtr;
		}

		// Token: 0x06006F0B RID: 28427 RVA: 0x0010BE00 File Offset: 0x0010A000
		[NullableContext(2)]
		public unsafe static IntPtr StringToCoTaskMemUni(string s)
		{
			if (s == null)
			{
				return IntPtr.Zero;
			}
			int num = (s.Length + 1) * 2;
			if (num < s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.s);
			}
			IntPtr intPtr = Marshal.AllocCoTaskMem(num);
			s.CopyTo(new Span<char>(intPtr, s.Length));
			*(intPtr + (IntPtr)s.Length * 2) = 0;
			return intPtr;
		}

		// Token: 0x06006F0C RID: 28428 RVA: 0x0010BE58 File Offset: 0x0010A058
		[NullableContext(2)]
		public unsafe static IntPtr StringToCoTaskMemUTF8(string s)
		{
			if (s == null)
			{
				return IntPtr.Zero;
			}
			int maxByteCount = Encoding.UTF8.GetMaxByteCount(s.Length);
			byte* ptr;
			IntPtr result = ptr = Marshal.AllocCoTaskMem(checked(maxByteCount + 1));
			int bytes = Encoding.UTF8.GetBytes(s, new Span<byte>((void*)ptr, maxByteCount));
			ptr[bytes] = 0;
			return result;
		}

		// Token: 0x06006F0D RID: 28429 RVA: 0x0010BEA8 File Offset: 0x0010A0A8
		[NullableContext(2)]
		public static IntPtr StringToCoTaskMemAnsi(string s)
		{
			if (s == null)
			{
				return IntPtr.Zero;
			}
			long num = (long)(s.Length + 1) * (long)Marshal.SystemMaxDBCSCharSize;
			int num2 = (int)num;
			if ((long)num2 != num)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.s);
			}
			IntPtr intPtr = Marshal.AllocCoTaskMem(num2);
			Marshal.StringToAnsiString(s, intPtr, num2, false, false);
			return intPtr;
		}

		// Token: 0x06006F0E RID: 28430 RVA: 0x0010BEF1 File Offset: 0x0010A0F1
		public static Guid GenerateGuidForType(Type type)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			if (!(type is RuntimeType))
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeType, "type");
			}
			return type.GUID;
		}

		// Token: 0x06006F0F RID: 28431 RVA: 0x0010BF1C File Offset: 0x0010A11C
		[return: Nullable(2)]
		public static string GenerateProgIdForType(Type type)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			if (type.IsImport)
			{
				throw new ArgumentException(SR.Argument_TypeMustNotBeComImport, "type");
			}
			if (type.IsGenericType)
			{
				throw new ArgumentException(SR.Argument_NeedNonGenericType, "type");
			}
			ProgIdAttribute customAttribute = type.GetCustomAttribute<ProgIdAttribute>();
			if (customAttribute != null)
			{
				return customAttribute.Value ?? string.Empty;
			}
			return type.FullName;
		}

		// Token: 0x06006F10 RID: 28432 RVA: 0x0010BF84 File Offset: 0x0010A184
		[RequiresDynamicCode("Marshalling code for the delegate might not be available. Use the GetDelegateForFunctionPointer<TDelegate> overload instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static Delegate GetDelegateForFunctionPointer(IntPtr ptr, Type t)
		{
			ArgumentNullException.ThrowIfNull(t, "t");
			ArgumentNullException.ThrowIfNull(ptr, "ptr");
			RuntimeType runtimeType = t as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeType, "t");
			}
			if (runtimeType.IsGenericType)
			{
				throw new ArgumentException(SR.Argument_NeedNonGenericType, "t");
			}
			if (runtimeType.BaseType != typeof(MulticastDelegate) && runtimeType != typeof(MulticastDelegate))
			{
				throw new ArgumentException(SR.Arg_MustBeDelegate, "t");
			}
			return Marshal.GetDelegateForFunctionPointerInternal(ptr, runtimeType);
		}

		// Token: 0x06006F11 RID: 28433 RVA: 0x0010C01C File Offset: 0x0010A21C
		public static TDelegate GetDelegateForFunctionPointer<[Nullable(2)] TDelegate>(IntPtr ptr)
		{
			ArgumentNullException.ThrowIfNull(ptr, "ptr");
			RuntimeType runtimeType = (RuntimeType)typeof(TDelegate);
			if (runtimeType.IsGenericType)
			{
				throw new ArgumentException(SR.Argument_NeedNonGenericType, "TDelegate");
			}
			if (runtimeType.BaseType != typeof(MulticastDelegate) && runtimeType != typeof(MulticastDelegate))
			{
				throw new ArgumentException(SR.Arg_MustBeDelegate, "TDelegate");
			}
			return (TDelegate)((object)Marshal.GetDelegateForFunctionPointerInternal(ptr, runtimeType));
		}

		// Token: 0x06006F12 RID: 28434 RVA: 0x0010C0A1 File Offset: 0x0010A2A1
		[RequiresDynamicCode("Marshalling code for the delegate might not be available. Use the GetFunctionPointerForDelegate<TDelegate> overload instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static IntPtr GetFunctionPointerForDelegate(Delegate d)
		{
			ArgumentNullException.ThrowIfNull(d, "d");
			return Marshal.GetFunctionPointerForDelegateInternal(d);
		}

		// Token: 0x06006F13 RID: 28435 RVA: 0x0010C0B4 File Offset: 0x0010A2B4
		[UnconditionalSuppressMessage("AotAnalysis", "IL3050:AotUnfriendlyApi", Justification = "AOT compilers can see the T.")]
		public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d)
		{
			return Marshal.GetFunctionPointerForDelegate((Delegate)((object)d));
		}

		// Token: 0x06006F14 RID: 28436 RVA: 0x0010C0C8 File Offset: 0x0010A2C8
		public static int GetHRForLastWin32Error()
		{
			int lastPInvokeError = Marshal.GetLastPInvokeError();
			if (((long)lastPInvokeError & (long)((ulong)-2147483648)) == (long)((ulong)-2147483648))
			{
				return lastPInvokeError;
			}
			return (lastPInvokeError & 65535) | -2147024896;
		}

		// Token: 0x06006F15 RID: 28437 RVA: 0x0010C0FB File Offset: 0x0010A2FB
		public static void ZeroFreeBSTR(IntPtr s)
		{
			if (s == IntPtr.Zero)
			{
				return;
			}
			NativeMemory.Clear(s, (UIntPtr)Marshal.SysStringByteLen(s));
			Marshal.FreeBSTR(s);
		}

		// Token: 0x06006F16 RID: 28438 RVA: 0x0010C119 File Offset: 0x0010A319
		public static void ZeroFreeCoTaskMemAnsi(IntPtr s)
		{
			Marshal.ZeroFreeCoTaskMemUTF8(s);
		}

		// Token: 0x06006F17 RID: 28439 RVA: 0x0010C121 File Offset: 0x0010A321
		public static void ZeroFreeCoTaskMemUnicode(IntPtr s)
		{
			if (s == IntPtr.Zero)
			{
				return;
			}
			NativeMemory.Clear(s, (UIntPtr)((IntPtr)string.wcslen(s) * (IntPtr)2));
			Marshal.FreeCoTaskMem(s);
		}

		// Token: 0x06006F18 RID: 28440 RVA: 0x0010C142 File Offset: 0x0010A342
		public static void ZeroFreeCoTaskMemUTF8(IntPtr s)
		{
			if (s == IntPtr.Zero)
			{
				return;
			}
			NativeMemory.Clear(s, (UIntPtr)((IntPtr)string.strlen(s)));
			Marshal.FreeCoTaskMem(s);
		}

		// Token: 0x06006F19 RID: 28441 RVA: 0x0010C160 File Offset: 0x0010A360
		public static void ZeroFreeGlobalAllocAnsi(IntPtr s)
		{
			if (s == IntPtr.Zero)
			{
				return;
			}
			NativeMemory.Clear(s, (UIntPtr)((IntPtr)string.strlen(s)));
			Marshal.FreeHGlobal(s);
		}

		// Token: 0x06006F1A RID: 28442 RVA: 0x0010C17E File Offset: 0x0010A37E
		public static void ZeroFreeGlobalAllocUnicode(IntPtr s)
		{
			if (s == IntPtr.Zero)
			{
				return;
			}
			NativeMemory.Clear(s, (UIntPtr)((IntPtr)string.wcslen(s) * (IntPtr)2));
			Marshal.FreeHGlobal(s);
		}

		// Token: 0x06006F1B RID: 28443 RVA: 0x0010C1A0 File Offset: 0x0010A3A0
		[NullableContext(2)]
		public static IntPtr StringToBSTR(string s)
		{
			if (s == null)
			{
				return IntPtr.Zero;
			}
			IntPtr intPtr = Marshal.AllocBSTR(s.Length);
			s.CopyTo(new Span<char>(intPtr, s.Length));
			return intPtr;
		}

		// Token: 0x06006F1C RID: 28444 RVA: 0x0010C1D5 File Offset: 0x0010A3D5
		public static string PtrToStringBSTR(IntPtr ptr)
		{
			ArgumentNullException.ThrowIfNull(ptr, "ptr");
			return Marshal.PtrToStringUni(ptr, (int)(Marshal.SysStringByteLen(ptr) / 2U));
		}

		// Token: 0x06006F1D RID: 28445 RVA: 0x0010C1F0 File Offset: 0x0010A3F0
		internal unsafe static uint SysStringByteLen(IntPtr s)
		{
			return *(s - 4);
		}

		// Token: 0x06006F1E RID: 28446 RVA: 0x0010C1F6 File Offset: 0x0010A3F6
		[NullableContext(2)]
		[SupportedOSPlatform("windows")]
		public static Type GetTypeFromCLSID(Guid clsid)
		{
			return Marshal.GetTypeFromCLSID(clsid, null, false);
		}

		// Token: 0x06006F1F RID: 28447 RVA: 0x0010C200 File Offset: 0x0010A400
		public static void InitHandle(SafeHandle safeHandle, IntPtr handle)
		{
			safeHandle.SetHandle(handle);
		}

		// Token: 0x06006F20 RID: 28448 RVA: 0x0010C209 File Offset: 0x0010A409
		public static int GetLastWin32Error()
		{
			return Marshal.GetLastPInvokeError();
		}

		// Token: 0x06006F21 RID: 28449 RVA: 0x0010C210 File Offset: 0x0010A410
		public static string GetLastPInvokeErrorMessage()
		{
			return Marshal.GetPInvokeErrorMessage(Marshal.GetLastPInvokeError());
		}

		// Token: 0x06006F22 RID: 28450 RVA: 0x0010C21C File Offset: 0x0010A41C
		[NullableContext(2)]
		public static string PtrToStringAuto(IntPtr ptr, int len)
		{
			return Marshal.PtrToStringUni(ptr, len);
		}

		// Token: 0x06006F23 RID: 28451 RVA: 0x0010C225 File Offset: 0x0010A425
		[NullableContext(2)]
		public static string PtrToStringAuto(IntPtr ptr)
		{
			return Marshal.PtrToStringUni(ptr);
		}

		// Token: 0x06006F24 RID: 28452 RVA: 0x0010C22D File Offset: 0x0010A42D
		[NullableContext(2)]
		public static IntPtr StringToHGlobalAuto(string s)
		{
			return Marshal.StringToHGlobalUni(s);
		}

		// Token: 0x06006F25 RID: 28453 RVA: 0x0010C235 File Offset: 0x0010A435
		[NullableContext(2)]
		public static IntPtr StringToCoTaskMemAuto(string s)
		{
			return Marshal.StringToCoTaskMemUni(s);
		}

		// Token: 0x06006F26 RID: 28454 RVA: 0x0010C240 File Offset: 0x0010A440
		private unsafe static int GetSystemMaxDBCSCharSize()
		{
			Interop.Kernel32.CPINFO cpinfo = default(Interop.Kernel32.CPINFO);
			if (Interop.Kernel32.GetCPInfo(0U, &cpinfo) == Interop.BOOL.FALSE)
			{
				return 2;
			}
			return cpinfo.MaxCharSize;
		}

		// Token: 0x06006F27 RID: 28455 RVA: 0x0010C268 File Offset: 0x0010A468
		private static bool IsNullOrWin32Atom(IntPtr ptr)
		{
			long num = (long)ptr;
			return (num & -65536L) == 0L;
		}

		// Token: 0x06006F28 RID: 28456 RVA: 0x0010C284 File Offset: 0x0010A484
		internal unsafe static int StringToAnsiString(string s, byte* buffer, int bufferLength, bool bestFit = false, bool throwOnUnmappableChar = false)
		{
			uint dwFlags = bestFit ? 0U : 1024U;
			Interop.BOOL @bool = Interop.BOOL.FALSE;
			char* ptr;
			if (s == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = s.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			char* lpWideCharStr = ptr;
			int num = Interop.Kernel32.WideCharToMultiByte(0U, dwFlags, lpWideCharStr, s.Length, buffer, bufferLength, null, throwOnUnmappableChar ? (&@bool) : null);
			char* ptr2 = null;
			if (@bool != Interop.BOOL.FALSE)
			{
				throw new ArgumentException(SR.Interop_Marshal_Unmappable_Char);
			}
			buffer[num] = 0;
			return num;
		}

		// Token: 0x06006F29 RID: 28457 RVA: 0x0010C2E8 File Offset: 0x0010A4E8
		internal unsafe static int GetAnsiStringByteCount(ReadOnlySpan<char> chars)
		{
			int num;
			if (chars.Length == 0)
			{
				num = 0;
			}
			else
			{
				fixed (char* pinnableReference = chars.GetPinnableReference())
				{
					char* lpWideCharStr = pinnableReference;
					num = Interop.Kernel32.WideCharToMultiByte(0U, 1024U, lpWideCharStr, chars.Length, null, 0, null, null);
					if (num <= 0)
					{
						throw new ArgumentException();
					}
				}
			}
			return checked(num + 1);
		}

		// Token: 0x06006F2A RID: 28458 RVA: 0x0010C338 File Offset: 0x0010A538
		internal unsafe static void GetAnsiStringBytes(ReadOnlySpan<char> chars, Span<byte> bytes)
		{
			int num;
			if (chars.Length == 0)
			{
				num = 0;
			}
			else
			{
				fixed (char* pinnableReference = chars.GetPinnableReference())
				{
					char* lpWideCharStr = pinnableReference;
					fixed (byte* pinnableReference2 = bytes.GetPinnableReference())
					{
						byte* lpMultiByteStr = pinnableReference2;
						num = Interop.Kernel32.WideCharToMultiByte(0U, 1024U, lpWideCharStr, chars.Length, lpMultiByteStr, bytes.Length, null, null);
						if (num <= 0)
						{
							throw new ArgumentException();
						}
					}
				}
			}
			*bytes[num] = 0;
		}

		// Token: 0x06006F2B RID: 28459 RVA: 0x0010C3A5 File Offset: 0x0010A5A5
		public unsafe static IntPtr AllocHGlobal(IntPtr cb)
		{
			void* ptr = Interop.Kernel32.LocalAlloc((UIntPtr)cb);
			if (ptr == null)
			{
				throw new OutOfMemoryException();
			}
			return ptr;
		}

		// Token: 0x06006F2C RID: 28460 RVA: 0x0010C3B8 File Offset: 0x0010A5B8
		public static void FreeHGlobal(IntPtr hglobal)
		{
			if (!Marshal.IsNullOrWin32Atom(hglobal))
			{
				Interop.Kernel32.LocalFree(hglobal);
			}
		}

		// Token: 0x06006F2D RID: 28461 RVA: 0x0010C3C9 File Offset: 0x0010A5C9
		public unsafe static IntPtr ReAllocHGlobal(IntPtr pv, IntPtr cb)
		{
			if (pv == IntPtr.Zero)
			{
				return Marshal.AllocHGlobal(cb);
			}
			void* ptr = Interop.Kernel32.LocalReAlloc(pv, (UIntPtr)cb);
			if (ptr == null)
			{
				throw new OutOfMemoryException();
			}
			return ptr;
		}

		// Token: 0x06006F2E RID: 28462 RVA: 0x0010C3EC File Offset: 0x0010A5EC
		public static IntPtr AllocCoTaskMem(int cb)
		{
			IntPtr intPtr = Interop.Ole32.CoTaskMemAlloc((UIntPtr)cb);
			if (intPtr == IntPtr.Zero)
			{
				throw new OutOfMemoryException();
			}
			return intPtr;
		}

		// Token: 0x06006F2F RID: 28463 RVA: 0x0010C403 File Offset: 0x0010A603
		public static void FreeCoTaskMem(IntPtr ptr)
		{
			if (!Marshal.IsNullOrWin32Atom(ptr))
			{
				Interop.Ole32.CoTaskMemFree(ptr);
			}
		}

		// Token: 0x06006F30 RID: 28464 RVA: 0x0010C413 File Offset: 0x0010A613
		public static IntPtr ReAllocCoTaskMem(IntPtr pv, int cb)
		{
			IntPtr intPtr = Interop.Ole32.CoTaskMemRealloc(pv, (UIntPtr)cb);
			if (intPtr == IntPtr.Zero && cb != 0)
			{
				throw new OutOfMemoryException();
			}
			return intPtr;
		}

		// Token: 0x06006F31 RID: 28465 RVA: 0x0010C42E File Offset: 0x0010A62E
		public static int GetLastSystemError()
		{
			return Interop.Kernel32.GetLastError();
		}

		// Token: 0x06006F32 RID: 28466 RVA: 0x0010C435 File Offset: 0x0010A635
		public static void SetLastSystemError(int error)
		{
			Interop.Kernel32.SetLastError(error);
		}

		// Token: 0x06006F33 RID: 28467 RVA: 0x0010C43D File Offset: 0x0010A63D
		public static string GetPInvokeErrorMessage(int error)
		{
			return Interop.Kernel32.GetMessage(error);
		}

		// Token: 0x06006F34 RID: 28468 RVA: 0x0010C445 File Offset: 0x0010A645
		internal static IntPtr AllocBSTR(int length)
		{
			IntPtr intPtr = Interop.OleAut32.SysAllocStringLen(IntPtr.Zero, (uint)length);
			if (intPtr == IntPtr.Zero)
			{
				throw new OutOfMemoryException();
			}
			return intPtr;
		}

		// Token: 0x06006F35 RID: 28469 RVA: 0x0010C460 File Offset: 0x0010A660
		internal static IntPtr AllocBSTRByteLen(uint length)
		{
			IntPtr intPtr = Interop.OleAut32.SysAllocStringByteLen(null, length);
			if (intPtr == IntPtr.Zero)
			{
				throw new OutOfMemoryException();
			}
			return intPtr;
		}

		// Token: 0x06006F36 RID: 28470 RVA: 0x0010C477 File Offset: 0x0010A677
		public static void FreeBSTR(IntPtr ptr)
		{
			if (!Marshal.IsNullOrWin32Atom(ptr))
			{
				Interop.OleAut32.SysFreeString(ptr);
			}
		}

		// Token: 0x06006F37 RID: 28471 RVA: 0x0010C488 File Offset: 0x0010A688
		internal static Type GetTypeFromProgID(string progID, string server, bool throwOnError)
		{
			ArgumentNullException.ThrowIfNull(progID, "progID");
			Guid clsid;
			int num = Interop.Ole32.CLSIDFromProgID(progID, out clsid);
			if (num >= 0)
			{
				return Marshal.GetTypeFromCLSID(clsid, server, throwOnError);
			}
			if (throwOnError)
			{
				throw Marshal.GetExceptionForHR(num, new IntPtr(-1));
			}
			return null;
		}

		// Token: 0x06006F38 RID: 28472 RVA: 0x0010C4C7 File Offset: 0x0010A6C7
		[NullableContext(2)]
		public static int GetHRForException(Exception e)
		{
			if (e == null)
			{
				return 0;
			}
			return e.HResult;
		}

		// Token: 0x06006F39 RID: 28473 RVA: 0x00007B65 File Offset: 0x00005D65
		public static bool AreComObjectsAvailableForCleanup()
		{
			return false;
		}

		// Token: 0x06006F3A RID: 28474 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static IntPtr CreateAggregatedObject(IntPtr pOuter, object o)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F3B RID: 28475 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[RequiresUnreferencedCode("Built-in COM support is not trim compatible", Url = "https://aka.ms/dotnet-illink/com")]
		[SupportedOSPlatform("windows")]
		public static object BindToMoniker(string monikerName)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F3C RID: 28476 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public static void CleanupUnusedObjectsInCurrentContext()
		{
		}

		// Token: 0x06006F3D RID: 28477 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		public static IntPtr CreateAggregatedObject<T>(IntPtr pOuter, T o)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F3E RID: 28478 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[NullableContext(2)]
		[SupportedOSPlatform("windows")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[return: NotNullIfNotNull("o")]
		public static object CreateWrapperOfType(object o, [Nullable(1)] Type t)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F3F RID: 28479 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[NullableContext(2)]
		[SupportedOSPlatform("windows")]
		[return: Nullable(1)]
		public static TWrapper CreateWrapperOfType<T, TWrapper>(T o)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F40 RID: 28480 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		public static void ChangeWrapperHandleStrength(object otp, bool fIsWeak)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F41 RID: 28481 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		public static int FinalReleaseComObject(object o)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F42 RID: 28482 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static IntPtr GetComInterfaceForObject(object o, Type T)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F43 RID: 28483 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static IntPtr GetComInterfaceForObject(object o, Type T, CustomQueryInterfaceMode mode)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F44 RID: 28484 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[NullableContext(2)]
		[SupportedOSPlatform("windows")]
		public static IntPtr GetComInterfaceForObject<T, TInterface>([Nullable(1)] [DisallowNull] T o)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F45 RID: 28485 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		[return: Nullable(2)]
		public static object GetComObjectData(object obj, object key)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F46 RID: 28486 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		public static IntPtr GetIDispatchForObject(object o)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F47 RID: 28487 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		public static IntPtr GetIUnknownForObject(object o)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F48 RID: 28488 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[NullableContext(2)]
		[SupportedOSPlatform("windows")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void GetNativeVariantForObject(object obj, IntPtr pDstNativeVariant)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F49 RID: 28489 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[NullableContext(2)]
		[SupportedOSPlatform("windows")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void GetNativeVariantForObject<T>(T obj, IntPtr pDstNativeVariant)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F4A RID: 28490 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		public static object GetTypedObjectForIUnknown(IntPtr pUnk, Type t)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F4B RID: 28491 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		public static object GetObjectForIUnknown(IntPtr pUnk)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F4C RID: 28492 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[NullableContext(2)]
		[SupportedOSPlatform("windows")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static object GetObjectForNativeVariant(IntPtr pSrcNativeVariant)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F4D RID: 28493 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[NullableContext(2)]
		[SupportedOSPlatform("windows")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static T GetObjectForNativeVariant<T>(IntPtr pSrcNativeVariant)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F4E RID: 28494 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public static object[] GetObjectsForNativeVariants(IntPtr aSrcNativeVariant, int cVars)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F4F RID: 28495 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static T[] GetObjectsForNativeVariants<[Nullable(2)] T>(IntPtr aSrcNativeVariant, int cVars)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F50 RID: 28496 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		public static int GetStartComSlot(Type t)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F51 RID: 28497 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		public static int GetEndComSlot(Type t)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F52 RID: 28498 RVA: 0x0010C4E0 File Offset: 0x0010A6E0
		internal static Type GetTypeFromCLSID(Guid clsid, string server, bool throwOnError)
		{
			if (throwOnError)
			{
				throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
			}
			return null;
		}

		// Token: 0x06006F53 RID: 28499 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		public static string GetTypeInfoName(ITypeInfo typeInfo)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F54 RID: 28500 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		public static object GetUniqueObjectForIUnknown(IntPtr unknown)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F55 RID: 28501 RVA: 0x0010C4F1 File Offset: 0x0010A6F1
		public static bool IsComObject(object o)
		{
			ArgumentNullException.ThrowIfNull(o, "o");
			return false;
		}

		// Token: 0x06006F56 RID: 28502 RVA: 0x0010C4FF File Offset: 0x0010A6FF
		public static bool IsTypeVisibleFromCom(Type t)
		{
			ArgumentNullException.ThrowIfNull(t, "t");
			return false;
		}

		// Token: 0x06006F57 RID: 28503 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		public static int ReleaseComObject(object o)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x06006F58 RID: 28504 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[SupportedOSPlatform("windows")]
		public static bool SetComObjectData(object obj, object key, [Nullable(2)] object data)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x04001211 RID: 4625
		private static Dictionary<ValueTuple<Type, string>, ICustomMarshaler> MarshalerInstanceCache;

		// Token: 0x04001212 RID: 4626
		public static readonly int SystemDefaultCharSize = 2;

		// Token: 0x04001213 RID: 4627
		public static readonly int SystemMaxDBCSCharSize = Marshal.GetSystemMaxDBCSCharSize();

		// Token: 0x020005A0 RID: 1440
		private sealed class MarshalerInstanceKeyComparer : IEqualityComparer<ValueTuple<Type, string>>
		{
			// Token: 0x06006F5A RID: 28506 RVA: 0x0010C51F File Offset: 0x0010A71F
			public bool Equals(ValueTuple<Type, string> lhs, ValueTuple<Type, string> rhs)
			{
				return lhs.CompareTo(rhs) == 0;
			}

			// Token: 0x06006F5B RID: 28507 RVA: 0x0010C52C File Offset: 0x0010A72C
			public int GetHashCode(ValueTuple<Type, string> key)
			{
				return key.GetHashCode();
			}
		}
	}
}
