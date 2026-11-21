using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000071 RID: 113
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public abstract class Array : ICloneable, IList, ICollection, IEnumerable, IStructuralComparable, IStructuralEquatable
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000228 RID: 552 RVA: 0x000069B0 File Offset: 0x00004BB0
		public int Length
		{
			[Intrinsic]
			get
			{
				return this.Length;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000229 RID: 553 RVA: 0x000069B8 File Offset: 0x00004BB8
		internal UIntPtr NativeLength
		{
			get
			{
				return (UIntPtr)Unsafe.As<Array.RawData>(this).Count;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600022A RID: 554 RVA: 0x000069C8 File Offset: 0x00004BC8
		public long LongLength
		{
			get
			{
				long num = (long)this.GetLength(0);
				for (int i = 1; i < this.Rank; i++)
				{
					num *= (long)this.GetLength(i);
				}
				return num;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600022B RID: 555 RVA: 0x000069FB File Offset: 0x00004BFB
		public int Rank
		{
			[Intrinsic]
			get
			{
				return this.Rank;
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00006A04 File Offset: 0x00004C04
		public static void Clear(Array array)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			ref byte arrayDataReference = ref MemoryMarshal.GetArrayDataReference(array);
			UIntPtr uintPtr = array.NativeLength * (UIntPtr)array.GetElementSize();
			if (RuntimeHelpers.ObjectHasReferences(array))
			{
				SpanHelpers.ClearWithReferences(Unsafe.As<byte, IntPtr>(ref arrayDataReference), uintPtr / (UIntPtr)8);
				return;
			}
			SpanHelpers.ClearWithoutReferences(ref arrayDataReference, uintPtr);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00006A54 File Offset: 0x00004C54
		public static void Clear(Array array, int index, int length)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			int lowerBound = array.GetLowerBound(0);
			int elementSize = array.GetElementSize();
			UIntPtr nativeLength = array.NativeLength;
			int num = index - lowerBound;
			if (index < lowerBound || num < 0 || length < 0 || (UIntPtr)(num + length) > nativeLength)
			{
				ThrowHelper.ThrowIndexOutOfRangeException();
			}
			ref byte ptr = ref Unsafe.AddByteOffset<byte>(MemoryMarshal.GetArrayDataReference(array), (UIntPtr)num * (UIntPtr)((IntPtr)elementSize));
			UIntPtr uintPtr = (UIntPtr)length * (UIntPtr)((IntPtr)elementSize);
			if (RuntimeHelpers.ObjectHasReferences(array))
			{
				SpanHelpers.ClearWithReferences(Unsafe.As<byte, IntPtr>(ref ptr), uintPtr / (UIntPtr)8);
				return;
			}
			SpanHelpers.ClearWithoutReferences(ref ptr, uintPtr);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00006ADC File Offset: 0x00004CDC
		public static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
		{
			Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length, true);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00006AEA File Offset: 0x00004CEA
		public static void Copy(Array sourceArray, Array destinationArray, int length)
		{
			ArgumentNullException.ThrowIfNull(sourceArray, "sourceArray");
			ArgumentNullException.ThrowIfNull(destinationArray, "destinationArray");
			Array.Copy(sourceArray, sourceArray.GetLowerBound(0), destinationArray, destinationArray.GetLowerBound(0), length);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00006B18 File Offset: 0x00004D18
		public static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
		{
			Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length, false);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00006B28 File Offset: 0x00004D28
		private static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length, bool reliable)
		{
			ArgumentNullException.ThrowIfNull(sourceArray, "sourceArray");
			ArgumentNullException.ThrowIfNull(destinationArray, "destinationArray");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			if (sourceArray.Rank != destinationArray.Rank)
			{
				throw new RankException(SR.Rank_MultiDimNotSupported);
			}
			if (sourceIndex < 0)
			{
				throw new ArgumentOutOfRangeException("sourceIndex", SR.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (destinationIndex < 0)
			{
				throw new ArgumentOutOfRangeException("destinationIndex", SR.ArgumentOutOfRange_NeedNonNegNum);
			}
			Array array = sourceArray;
			Array array2 = destinationArray;
			if (Array.FastCopy(ObjectHandleOnStack.Create<Array>(ref array), sourceIndex, ObjectHandleOnStack.Create<Array>(ref array2), destinationIndex, length))
			{
				return;
			}
			Array.CopySlow(sourceArray, sourceIndex, destinationArray, destinationIndex, length, reliable);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00006BC4 File Offset: 0x00004DC4
		private static void CopySlow(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length, bool reliable)
		{
			int num = sourceIndex - sourceArray.GetLowerBound(0);
			int num2 = destinationIndex - destinationArray.GetLowerBound(0);
			if (num < 0)
			{
				throw new ArgumentOutOfRangeException("sourceIndex", SR.ArgumentOutOfRange_ArrayLB);
			}
			if (num2 < 0)
			{
				throw new ArgumentOutOfRangeException("destinationIndex", SR.ArgumentOutOfRange_ArrayLB);
			}
			if (num > sourceArray.Length - length)
			{
				throw new ArgumentException(SR.Arg_LongerThanSrcArray, "sourceArray");
			}
			if (num2 > destinationArray.Length - length)
			{
				throw new ArgumentException(SR.Arg_LongerThanDestArray, "destinationArray");
			}
			Type type = sourceArray.GetType().GetElementType();
			Type type2 = destinationArray.GetType().GetElementType();
			Type type3 = type2;
			bool flag = type2.IsValueType && Nullable.GetUnderlyingType(type2) == null;
			bool isEnum = type.IsEnum;
			bool isEnum2 = type2.IsEnum;
			if (isEnum)
			{
				type = Enum.GetUnderlyingType(type);
			}
			if (isEnum2)
			{
				type2 = Enum.GetUnderlyingType(type2);
			}
			if (reliable)
			{
				if (!type2.Equals(type) && (!type2.IsPrimitive || !type.IsPrimitive || !Array.CanChangePrimitive(ObjectHandleOnStack.Create<Type>(ref type2), ObjectHandleOnStack.Create<Type>(ref type), true)))
				{
					throw new ArrayTypeMismatchException(SR.ArrayTypeMismatch_CantAssignType);
				}
			}
			else if (!Array.CanAssignArrayElement(type, type2))
			{
				throw new ArrayTypeMismatchException(SR.ArrayTypeMismatch_CantAssignType);
			}
			Array array = sourceArray;
			ObjectHandleOnStack arr = ObjectHandleOnStack.Create<Array>(ref array);
			Array array2 = destinationArray;
			ObjectHandleOnStack arr2 = ObjectHandleOnStack.Create<Array>(ref array2);
			object obj = null;
			ObjectHandleOnStack objectHandleOnStack = ObjectHandleOnStack.Create<object>(ref obj);
			if (sourceArray != destinationArray || num > num2)
			{
				for (int i = 0; i < length; i++)
				{
					Array.GetValueImpl(arr, objectHandleOnStack, num + i);
					if (flag && (obj == null || (type == typeof(object) && !type3.IsAssignableFrom(obj.GetType()))))
					{
						throw new InvalidCastException(SR.InvalidCast_DownCastArrayElement);
					}
					try
					{
						Array.SetValueRelaxedImpl(arr2, objectHandleOnStack, num2 + i);
					}
					catch (ArgumentException)
					{
						throw Array.CreateArrayTypeMismatchException();
					}
				}
				return;
			}
			for (int j = length - 1; j >= 0; j--)
			{
				Array.GetValueImpl(arr, objectHandleOnStack, num + j);
				try
				{
					Array.SetValueRelaxedImpl(arr2, objectHandleOnStack, num2 + j);
				}
				catch (ArgumentException)
				{
					throw Array.CreateArrayTypeMismatchException();
				}
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00006DD8 File Offset: 0x00004FD8
		private static ArrayTypeMismatchException CreateArrayTypeMismatchException()
		{
			return new ArrayTypeMismatchException();
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00006DE0 File Offset: 0x00004FE0
		private static bool CanAssignArrayElement(Type source, Type target)
		{
			if (!target.IsValueType && !target.IsPointer)
			{
				if (!source.IsValueType && !source.IsPointer)
				{
					return source.IsInterface || target.IsInterface || source.IsAssignableFrom(target) || target.IsAssignableFrom(source);
				}
				return !source.IsPointer && target.IsAssignableFrom(source);
			}
			else
			{
				if (source.IsEquivalentTo(target))
				{
					return true;
				}
				if (source.IsPointer && target.IsPointer)
				{
					return target.IsAssignableFrom(source);
				}
				if (source.IsPrimitive && target.IsPrimitive)
				{
					return Array.CanChangePrimitive(ObjectHandleOnStack.Create<Type>(ref source), ObjectHandleOnStack.Create<Type>(ref target), false);
				}
				return !source.IsValueType && !source.IsPointer && !target.IsPointer && source.IsAssignableFrom(target);
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00006EB0 File Offset: 0x000050B0
		private unsafe static Array InternalCreate(RuntimeType elementType, int rank, int* lengths, int* lowerBounds)
		{
			Array result = null;
			Array.InternalCreate(ref result, elementType._impl.Value, rank, lengths, lowerBounds);
			GC.KeepAlive(elementType);
			return result;
		}

		// Token: 0x06000236 RID: 566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void InternalCreate(ref Array result, IntPtr elementType, int rank, int* lengths, int* lowerBounds);

		// Token: 0x06000237 RID: 567 RVA: 0x00006EDB File Offset: 0x000050DB
		private unsafe static Array InternalCreateFromArrayType(Type arrayType, int rank, int* pLengths, int* pLowerBounds)
		{
			return Array.InternalCreate(arrayType.GetElementType() as RuntimeType, rank, pLengths, pLowerBounds);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00006EF0 File Offset: 0x000050F0
		private IntPtr GetFlattenedIndex(int rawIndex)
		{
			int num = rawIndex - this.GetLowerBound(0);
			int length = this.GetLength(0);
			if (num >= length)
			{
				ThrowHelper.ThrowIndexOutOfRangeException();
			}
			return (IntPtr)num;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00006F18 File Offset: 0x00005118
		private unsafe IntPtr GetFlattenedIndex(ReadOnlySpan<int> indices)
		{
			IntPtr intPtr = (IntPtr)0;
			for (int i = 0; i < indices.Length; i++)
			{
				int num = *indices[i] - this.GetLowerBound(i);
				int length = this.GetLength(i);
				if (num >= length)
				{
					ThrowHelper.ThrowIndexOutOfRangeException();
				}
				intPtr = (IntPtr)length * intPtr + (IntPtr)num;
			}
			return intPtr;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00006F68 File Offset: 0x00005168
		internal object InternalGetValue(IntPtr index)
		{
			if (base.GetType().GetElementType().IsPointer)
			{
				throw new NotSupportedException(SR.NotSupported_Type);
			}
			Array array = this;
			object result = null;
			Array.GetValueImpl(ObjectHandleOnStack.Create<Array>(ref array), ObjectHandleOnStack.Create<object>(ref result), (int)index);
			return result;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00006FAC File Offset: 0x000051AC
		internal void InternalSetValue(object value, IntPtr index)
		{
			if (base.GetType().GetElementType().IsPointer)
			{
				throw new NotSupportedException(SR.NotSupported_Type);
			}
			Array array = this;
			Array.SetValueImpl(ObjectHandleOnStack.Create<Array>(ref array), ObjectHandleOnStack.Create<object>(ref value), (int)index);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00006FF0 File Offset: 0x000051F0
		public void Initialize()
		{
			object obj = this;
			Array.InitializeInternal(ObjectHandleOnStack.Create<object>(ref obj));
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000700B File Offset: 0x0000520B
		public int GetUpperBound(int dimension)
		{
			return this.GetLowerBound(dimension) + this.GetLength(dimension) - 1;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00007020 File Offset: 0x00005220
		internal CorElementType GetCorElementTypeOfElementType()
		{
			object obj = this;
			return Array.GetCorElementTypeOfElementTypeInternal(ObjectHandleOnStack.Create<object>(ref obj));
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000703C File Offset: 0x0000523C
		private bool IsValueOfElementType(object value)
		{
			object obj = this;
			return Array.IsValueOfElementTypeInternal(ObjectHandleOnStack.Create<object>(ref obj), ObjectHandleOnStack.Create<object>(ref value));
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00007060 File Offset: 0x00005260
		[Intrinsic]
		public int GetLength(int dimension)
		{
			object obj = this;
			return Array.GetLengthInternal(ObjectHandleOnStack.Create<object>(ref obj), dimension);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000707C File Offset: 0x0000527C
		[Intrinsic]
		public int GetLowerBound(int dimension)
		{
			object obj = this;
			return Array.GetLowerBoundInternal(ObjectHandleOnStack.Create<object>(ref obj), dimension);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00007098 File Offset: 0x00005298
		[Intrinsic]
		internal int GetElementSize()
		{
			return this.GetElementSize();
		}

		// Token: 0x06000243 RID: 579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern CorElementType GetCorElementTypeOfElementTypeInternal(ObjectHandleOnStack arr);

		// Token: 0x06000244 RID: 580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsValueOfElementTypeInternal(ObjectHandleOnStack arr, ObjectHandleOnStack obj);

		// Token: 0x06000245 RID: 581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool CanChangePrimitive(ObjectHandleOnStack srcType, ObjectHandleOnStack dstType, bool reliable);

		// Token: 0x06000246 RID: 582
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool FastCopy(ObjectHandleOnStack source, int source_idx, ObjectHandleOnStack dest, int dest_idx, int length);

		// Token: 0x06000247 RID: 583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetLengthInternal(ObjectHandleOnStack arr, int dimension);

		// Token: 0x06000248 RID: 584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetLowerBoundInternal(ObjectHandleOnStack arr, int dimension);

		// Token: 0x06000249 RID: 585
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetGenericValue_icall<T>(ObjectHandleOnStack self, int pos, out T value);

		// Token: 0x0600024A RID: 586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetValueImpl(ObjectHandleOnStack arr, ObjectHandleOnStack res, int pos);

		// Token: 0x0600024B RID: 587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetGenericValue_icall<T>(ObjectHandleOnStack arr, int pos, ref T value);

		// Token: 0x0600024C RID: 588 RVA: 0x000070A0 File Offset: 0x000052A0
		[Intrinsic]
		private void GetGenericValueImpl<T>(int pos, out T value)
		{
			Array array = this;
			Array.GetGenericValue_icall<T>(ObjectHandleOnStack.Create<Array>(ref array), pos, out value);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000070C0 File Offset: 0x000052C0
		[Intrinsic]
		private void SetGenericValueImpl<T>(int pos, ref T value)
		{
			Array array = this;
			Array.SetGenericValue_icall<T>(ObjectHandleOnStack.Create<Array>(ref array), pos, ref value);
		}

		// Token: 0x0600024E RID: 590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetValueImpl(ObjectHandleOnStack arr, ObjectHandleOnStack value, int pos);

		// Token: 0x0600024F RID: 591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitializeInternal(ObjectHandleOnStack arr);

		// Token: 0x06000250 RID: 592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetValueRelaxedImpl(ObjectHandleOnStack arr, ObjectHandleOnStack value, int pos);

		// Token: 0x06000251 RID: 593 RVA: 0x000069B0 File Offset: 0x00004BB0
		internal int InternalArray__ICollection_get_Count()
		{
			return this.Length;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000070DD File Offset: 0x000052DD
		internal bool InternalArray__ICollection_get_IsReadOnly()
		{
			return true;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000070E0 File Offset: 0x000052E0
		internal IEnumerator<T> InternalArray__IEnumerable_GetEnumerator<T>()
		{
			int length = this.Length;
			if (length != 0)
			{
				return new SZGenericArrayEnumerator<T>(Unsafe.As<T[]>(this), length);
			}
			return SZGenericArrayEnumerator<T>.Empty;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00007109 File Offset: 0x00005309
		internal void InternalArray__ICollection_Clear()
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00007111 File Offset: 0x00005311
		internal void InternalArray__ICollection_Add<T>(T _)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_FixedSizeCollection);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000711A File Offset: 0x0000531A
		internal bool InternalArray__ICollection_Remove<T>(T _)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_FixedSizeCollection);
			return false;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00007124 File Offset: 0x00005324
		internal bool InternalArray__ICollection_Contains<T>(T item)
		{
			return Array.IndexOf<T>((T[])this, item, 0, this.Length) >= 0;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000713F File Offset: 0x0000533F
		internal void InternalArray__ICollection_CopyTo<T>(T[] array, int arrayIndex)
		{
			Array.Copy(this, this.GetLowerBound(0), array, arrayIndex, this.Length);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00007158 File Offset: 0x00005358
		internal T InternalArray__IReadOnlyList_get_Item<T>(int index)
		{
			if (index >= this.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
			}
			T result;
			this.GetGenericValueImpl<T>(index, out result);
			return result;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000069B0 File Offset: 0x00004BB0
		internal int InternalArray__IReadOnlyCollection_get_Count()
		{
			return this.Length;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00007111 File Offset: 0x00005311
		internal void InternalArray__Insert<T>(int _, T _1)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_FixedSizeCollection);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00007111 File Offset: 0x00005311
		internal void InternalArray__RemoveAt(int _)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_FixedSizeCollection);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000717D File Offset: 0x0000537D
		internal int InternalArray__IndexOf<T>(T item)
		{
			return Array.IndexOf<T>((T[])this, item, 0, this.Length);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00007194 File Offset: 0x00005394
		internal T InternalArray__get_Item<T>(int index)
		{
			if (index >= this.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
			}
			T result;
			this.GetGenericValueImpl<T>(index, out result);
			return result;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000071BC File Offset: 0x000053BC
		internal void InternalArray__set_Item<T>(int index, T item)
		{
			if (index >= this.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
			}
			object[] array = this as object[];
			if (array != null)
			{
				array[index] = item;
				return;
			}
			this.SetGenericValueImpl<T>(index, ref item);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00005ACC File Offset: 0x00003CCC
		private protected Array()
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000071F4 File Offset: 0x000053F4
		public static ReadOnlyCollection<T> AsReadOnly<[Nullable(2)] T>(T[] array)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (array.Length != 0)
			{
				return new ReadOnlyCollection<T>(array);
			}
			return ReadOnlyCollection<T>.Empty;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00007210 File Offset: 0x00005410
		[NullableContext(2)]
		public static void Resize<T>([Nullable(new byte[]
		{
			2,
			1
		})] [NotNull] ref T[] array, int newSize)
		{
			if (newSize < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.newSize, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			T[] array2 = array;
			if (array2 == null)
			{
				array = new T[newSize];
				return;
			}
			if (array2.Length != newSize)
			{
				T[] array3 = new T[newSize];
				Buffer.Memmove<T>(MemoryMarshal.GetArrayDataReference<T>(array3), MemoryMarshal.GetArrayDataReference<T>(array2), (UIntPtr)Math.Min(newSize, array2.Length));
				array = array3;
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00007264 File Offset: 0x00005464
		[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
		public unsafe static Array CreateInstance(Type elementType, int length)
		{
			ArgumentNullException.ThrowIfNull(elementType, "elementType");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			RuntimeType runtimeType = elementType.UnderlyingSystemType as RuntimeType;
			if (runtimeType == null)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_MustBeType, ExceptionArgument.elementType);
			}
			return Array.InternalCreate(runtimeType, 1, &length, null);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000072A4 File Offset: 0x000054A4
		[UnconditionalSuppressMessage("AotAnalysis", "IL3050:RequiresDynamicCode", Justification = "MDArrays of Rank != 1 can be created because they don't implement generic interfaces.")]
		public unsafe static Array CreateInstance(Type elementType, int length1, int length2)
		{
			ArgumentNullException.ThrowIfNull(elementType, "elementType");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length1, "length1");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length2, "length2");
			RuntimeType runtimeType = elementType.UnderlyingSystemType as RuntimeType;
			if (runtimeType == null)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_MustBeType, ExceptionArgument.elementType);
			}
			IntPtr intPtr = stackalloc byte[(UIntPtr)8];
			*intPtr = length1;
			*(intPtr + 4) = length2;
			int* lengths = intPtr;
			return Array.InternalCreate(runtimeType, 2, lengths, null);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00007308 File Offset: 0x00005508
		[UnconditionalSuppressMessage("AotAnalysis", "IL3050:RequiresDynamicCode", Justification = "MDArrays of Rank != 1 can be created because they don't implement generic interfaces.")]
		public unsafe static Array CreateInstance(Type elementType, int length1, int length2, int length3)
		{
			ArgumentNullException.ThrowIfNull(elementType, "elementType");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length1, "length1");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length2, "length2");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length3, "length3");
			RuntimeType runtimeType = elementType.UnderlyingSystemType as RuntimeType;
			if (runtimeType == null)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_MustBeType, ExceptionArgument.elementType);
			}
			IntPtr intPtr = stackalloc byte[(UIntPtr)12];
			*intPtr = length1;
			*(intPtr + 4) = length2;
			*(intPtr + (IntPtr)2 * 4) = length3;
			int* lengths = intPtr;
			return Array.InternalCreate(runtimeType, 3, lengths, null);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00007380 File Offset: 0x00005580
		[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
		public unsafe static Array CreateInstance(Type elementType, params int[] lengths)
		{
			ArgumentNullException.ThrowIfNull(elementType, "elementType");
			ArgumentNullException.ThrowIfNull(lengths, "lengths");
			if (lengths.Length == 0)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NeedAtLeast1Rank);
			}
			RuntimeType runtimeType = elementType.UnderlyingSystemType as RuntimeType;
			if (runtimeType == null)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_MustBeType, ExceptionArgument.elementType);
			}
			for (int i = 0; i < lengths.Length; i++)
			{
				if (lengths[i] < 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.lengths, i, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
				}
			}
			fixed (int* ptr = &lengths[0])
			{
				int* lengths2 = ptr;
				return Array.InternalCreate(runtimeType, lengths.Length, lengths2, null);
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00007404 File Offset: 0x00005604
		[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
		public unsafe static Array CreateInstance(Type elementType, int[] lengths, int[] lowerBounds)
		{
			ArgumentNullException.ThrowIfNull(elementType, "elementType");
			ArgumentNullException.ThrowIfNull(lengths, "lengths");
			ArgumentNullException.ThrowIfNull(lowerBounds, "lowerBounds");
			if (lengths.Length != lowerBounds.Length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RanksAndBounds);
			}
			if (lengths.Length == 0)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NeedAtLeast1Rank);
			}
			RuntimeType runtimeType = elementType.UnderlyingSystemType as RuntimeType;
			if (runtimeType == null)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_MustBeType, ExceptionArgument.elementType);
			}
			for (int i = 0; i < lengths.Length; i++)
			{
				if (lengths[i] < 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.lengths, i, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
				}
			}
			fixed (int* ptr = &lengths[0])
			{
				int* lengths2 = ptr;
				fixed (int* ptr2 = &lowerBounds[0])
				{
					int* lowerBounds2 = ptr2;
					return Array.InternalCreate(runtimeType, lengths.Length, lengths2, lowerBounds2);
				}
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000074B0 File Offset: 0x000056B0
		[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
		public static Array CreateInstance(Type elementType, params long[] lengths)
		{
			ArgumentNullException.ThrowIfNull(lengths, "lengths");
			int[] array = new int[lengths.Length];
			for (int i = 0; i < lengths.Length; i++)
			{
				long num = lengths[i];
				int num2 = (int)num;
				if (num != (long)num2)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.len, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
				}
				array[i] = num2;
			}
			return Array.CreateInstance(elementType, array);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00007500 File Offset: 0x00005700
		public unsafe static Array CreateInstanceFromArrayType(Type arrayType, int length)
		{
			ArgumentNullException.ThrowIfNull(arrayType, "arrayType");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			RuntimeType runtimeType = arrayType as RuntimeType;
			if (runtimeType == null)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_MustBeType, ExceptionArgument.arrayType);
			}
			if (!runtimeType.IsArray)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_HasToBeArrayClass, ExceptionArgument.arrayType);
			}
			if (runtimeType.GetArrayRank() != 1)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported, ExceptionArgument.arrayType);
			}
			return Array.InternalCreateFromArrayType(runtimeType, 1, &length, null);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000756C File Offset: 0x0000576C
		public unsafe static Array CreateInstanceFromArrayType(Type arrayType, params int[] lengths)
		{
			ArgumentNullException.ThrowIfNull(arrayType, "arrayType");
			ArgumentNullException.ThrowIfNull(lengths, "lengths");
			RuntimeType runtimeType = arrayType as RuntimeType;
			if (runtimeType == null)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_MustBeType, ExceptionArgument.arrayType);
			}
			if (!runtimeType.IsArray)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_HasToBeArrayClass, ExceptionArgument.arrayType);
			}
			if (runtimeType.GetArrayRank() != lengths.Length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankIndices);
			}
			for (int i = 0; i < lengths.Length; i++)
			{
				if (lengths[i] < 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.lengths, i, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
				}
			}
			fixed (int* ptr = &lengths[0])
			{
				int* pLengths = ptr;
				return Array.InternalCreateFromArrayType(runtimeType, lengths.Length, pLengths, null);
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00007600 File Offset: 0x00005800
		public unsafe static Array CreateInstanceFromArrayType(Type arrayType, int[] lengths, int[] lowerBounds)
		{
			ArgumentNullException.ThrowIfNull(arrayType, "arrayType");
			ArgumentNullException.ThrowIfNull(lengths, "lengths");
			ArgumentNullException.ThrowIfNull(lowerBounds, "lowerBounds");
			if (lengths.Length != lowerBounds.Length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RanksAndBounds);
			}
			RuntimeType runtimeType = arrayType as RuntimeType;
			if (runtimeType == null)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_MustBeType, ExceptionArgument.arrayType);
			}
			if (!runtimeType.IsArray)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_HasToBeArrayClass, ExceptionArgument.arrayType);
			}
			if (runtimeType.GetArrayRank() != lengths.Length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankIndices);
			}
			if (lowerBounds[0] != 0 && runtimeType.IsSZArray)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
			}
			for (int i = 0; i < lengths.Length; i++)
			{
				if (lengths[i] < 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.lengths, i, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
				}
			}
			fixed (int* ptr = &lengths[0])
			{
				int* pLengths = ptr;
				fixed (int* ptr2 = &lowerBounds[0])
				{
					int* pLowerBounds = ptr2;
					return Array.InternalCreateFromArrayType(runtimeType, lengths.Length, pLengths, pLowerBounds);
				}
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000076D0 File Offset: 0x000058D0
		public static void Copy(Array sourceArray, Array destinationArray, long length)
		{
			int num = (int)length;
			if (length != (long)num)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.length, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
			}
			Array.Copy(sourceArray, destinationArray, num);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000076F8 File Offset: 0x000058F8
		public static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length)
		{
			int num = (int)sourceIndex;
			int num2 = (int)destinationIndex;
			int num3 = (int)length;
			if (sourceIndex != (long)num)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.sourceIndex, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
			}
			if (destinationIndex != (long)num2)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.destinationIndex, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
			}
			if (length != (long)num3)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.length, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
			}
			Array.Copy(sourceArray, num, destinationArray, num2, num3);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00007744 File Offset: 0x00005944
		[return: Nullable(2)]
		public object GetValue(params int[] indices)
		{
			if (indices == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.indices);
			}
			if (this.Rank != indices.Length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankIndices);
			}
			return this.InternalGetValue(this.GetFlattenedIndex(indices));
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00007774 File Offset: 0x00005974
		[NullableContext(2)]
		public object GetValue(int index)
		{
			if (this.Rank != 1)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_Need1DArray);
			}
			return this.InternalGetValue(this.GetFlattenedIndex(index));
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00007794 File Offset: 0x00005994
		[NullableContext(2)]
		public unsafe object GetValue(int index1, int index2)
		{
			if (this.Rank != 2)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_Need2DArray);
			}
			<>y__InlineArray2<int> <>y__InlineArray = default(<>y__InlineArray2<int>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<int>, int>(ref <>y__InlineArray, 0) = index1;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<int>, int>(ref <>y__InlineArray, 1) = index2;
			return this.InternalGetValue(this.GetFlattenedIndex(<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<int>, int>(<>y__InlineArray, 2)));
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000077E4 File Offset: 0x000059E4
		[NullableContext(2)]
		public unsafe object GetValue(int index1, int index2, int index3)
		{
			if (this.Rank != 3)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_Need3DArray);
			}
			<>y__InlineArray3<int> <>y__InlineArray = default(<>y__InlineArray3<int>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<int>, int>(ref <>y__InlineArray, 0) = index1;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<int>, int>(ref <>y__InlineArray, 1) = index2;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<int>, int>(ref <>y__InlineArray, 2) = index3;
			return this.InternalGetValue(this.GetFlattenedIndex(<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<int>, int>(<>y__InlineArray, 3)));
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000783B File Offset: 0x00005A3B
		[NullableContext(2)]
		public void SetValue(object value, int index)
		{
			if (this.Rank != 1)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_Need1DArray);
			}
			this.InternalSetValue(value, this.GetFlattenedIndex(index));
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000785C File Offset: 0x00005A5C
		[NullableContext(2)]
		public unsafe void SetValue(object value, int index1, int index2)
		{
			if (this.Rank != 2)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_Need2DArray);
			}
			<>y__InlineArray2<int> <>y__InlineArray = default(<>y__InlineArray2<int>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<int>, int>(ref <>y__InlineArray, 0) = index1;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<int>, int>(ref <>y__InlineArray, 1) = index2;
			this.InternalSetValue(value, this.GetFlattenedIndex(<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<int>, int>(<>y__InlineArray, 2)));
		}

		// Token: 0x06000274 RID: 628 RVA: 0x000078AC File Offset: 0x00005AAC
		[NullableContext(2)]
		public unsafe void SetValue(object value, int index1, int index2, int index3)
		{
			if (this.Rank != 3)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_Need3DArray);
			}
			<>y__InlineArray3<int> <>y__InlineArray = default(<>y__InlineArray3<int>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<int>, int>(ref <>y__InlineArray, 0) = index1;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<int>, int>(ref <>y__InlineArray, 1) = index2;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<int>, int>(ref <>y__InlineArray, 2) = index3;
			this.InternalSetValue(value, this.GetFlattenedIndex(<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<int>, int>(<>y__InlineArray, 3)));
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00007905 File Offset: 0x00005B05
		public void SetValue([Nullable(2)] object value, params int[] indices)
		{
			if (indices == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.indices);
			}
			if (this.Rank != indices.Length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankIndices);
			}
			this.InternalSetValue(value, this.GetFlattenedIndex(indices));
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00007938 File Offset: 0x00005B38
		[NullableContext(2)]
		public object GetValue(long index)
		{
			int num = (int)index;
			if (index != (long)num)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
			}
			return this.GetValue(num);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00007960 File Offset: 0x00005B60
		[NullableContext(2)]
		public object GetValue(long index1, long index2)
		{
			int num = (int)index1;
			int num2 = (int)index2;
			if (index1 != (long)num)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index1, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
			}
			if (index2 != (long)num2)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index2, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
			}
			return this.GetValue(num, num2);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00007998 File Offset: 0x00005B98
		[NullableContext(2)]
		public object GetValue(long index1, long index2, long index3)
		{
			int num = (int)index1;
			int num2 = (int)index2;
			int num3 = (int)index3;
			if (index1 != (long)num)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index1, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
			}
			if (index2 != (long)num2)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index2, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
			}
			if (index3 != (long)num3)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index3, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
			}
			return this.GetValue(num, num2, num3);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000079E4 File Offset: 0x00005BE4
		[return: Nullable(2)]
		public object GetValue(params long[] indices)
		{
			if (indices == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.indices);
			}
			if (this.Rank != indices.Length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankIndices);
			}
			int[] array = new int[indices.Length];
			for (int i = 0; i < indices.Length; i++)
			{
				long num = indices[i];
				int num2 = (int)num;
				if (num != (long)num2)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
				}
				array[i] = num2;
			}
			return this.GetValue(array);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00007A44 File Offset: 0x00005C44
		[NullableContext(2)]
		public void SetValue(object value, long index)
		{
			int num = (int)index;
			if (index != (long)num)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
			}
			this.SetValue(value, num);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00007A6C File Offset: 0x00005C6C
		[NullableContext(2)]
		public void SetValue(object value, long index1, long index2)
		{
			int num = (int)index1;
			int num2 = (int)index2;
			if (index1 != (long)num)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index1, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
			}
			if (index2 != (long)num2)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index2, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
			}
			this.SetValue(value, num, num2);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00007AA4 File Offset: 0x00005CA4
		[NullableContext(2)]
		public void SetValue(object value, long index1, long index2, long index3)
		{
			int num = (int)index1;
			int num2 = (int)index2;
			int num3 = (int)index3;
			if (index1 != (long)num)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index1, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
			}
			if (index2 != (long)num2)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index2, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
			}
			if (index3 != (long)num3)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index3, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
			}
			this.SetValue(value, num, num2, num3);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00007AF0 File Offset: 0x00005CF0
		public void SetValue([Nullable(2)] object value, params long[] indices)
		{
			if (indices == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.indices);
			}
			if (this.Rank != indices.Length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankIndices);
			}
			int[] array = new int[indices.Length];
			for (int i = 0; i < indices.Length; i++)
			{
				long num = indices[i];
				int num2 = (int)num;
				if (num != (long)num2)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
				}
				array[i] = num2;
			}
			this.SetValue(value, array);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00007B4F File Offset: 0x00005D4F
		private static int GetMedian(int low, int hi)
		{
			return low + (hi - low >> 1);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00007B58 File Offset: 0x00005D58
		public long GetLongLength(int dimension)
		{
			return (long)this.GetLength(dimension);
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000280 RID: 640 RVA: 0x000069B0 File Offset: 0x00004BB0
		int ICollection.Count
		{
			get
			{
				return this.Length;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00007B62 File Offset: 0x00005D62
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00007B65 File Offset: 0x00005D65
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000283 RID: 643 RVA: 0x000070DD File Offset: 0x000052DD
		public bool IsFixedSize
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00007B65 File Offset: 0x00005D65
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700001A RID: 26
		[Nullable(2)]
		object IList.this[int index]
		{
			get
			{
				return this.GetValue(index);
			}
			set
			{
				this.SetValue(value, index);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000711A File Offset: 0x0000531A
		int IList.Add(object value)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_FixedSizeCollection);
			return 0;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00007B7B File Offset: 0x00005D7B
		bool IList.Contains(object value)
		{
			return Array.IndexOf(this, value) >= this.GetLowerBound(0);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00007B90 File Offset: 0x00005D90
		void IList.Clear()
		{
			Array.Clear(this);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00007B98 File Offset: 0x00005D98
		int IList.IndexOf(object value)
		{
			return Array.IndexOf(this, value);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00007111 File Offset: 0x00005311
		void IList.Insert(int index, object value)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_FixedSizeCollection);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00007111 File Offset: 0x00005311
		void IList.Remove(object value)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_FixedSizeCollection);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00007111 File Offset: 0x00005311
		void IList.RemoveAt(int index)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_FixedSizeCollection);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00007BA1 File Offset: 0x00005DA1
		[Intrinsic]
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00007BAC File Offset: 0x00005DAC
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Array array = other as Array;
			if (array == null || this.Length != array.Length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.ArgumentException_OtherNotArrayOfCorrectLength, ExceptionArgument.other);
			}
			int num = 0;
			int num2 = 0;
			while (num < array.Length && num2 == 0)
			{
				object value = this.GetValue(num);
				object value2 = array.GetValue(num);
				num2 = comparer.Compare(value, value2);
				num++;
			}
			return num2;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00007C14 File Offset: 0x00005E14
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			if (this == other)
			{
				return true;
			}
			Array array = other as Array;
			if (array == null || array.Length != this.Length)
			{
				return false;
			}
			for (int i = 0; i < array.Length; i++)
			{
				object value = this.GetValue(i);
				object value2 = array.GetValue(i);
				if (!comparer.Equals(value, value2))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00007C74 File Offset: 0x00005E74
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			if (comparer == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.comparer);
			}
			HashCode hashCode = default(HashCode);
			for (int i = (this.Length >= 8) ? (this.Length - 8) : 0; i < this.Length; i++)
			{
				hashCode.Add<int>(comparer.GetHashCode(this.GetValue(i)));
			}
			return hashCode.ToHashCode();
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00007CD2 File Offset: 0x00005ED2
		public static int BinarySearch(Array array, [Nullable(2)] object value)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			return Array.BinarySearch(array, array.GetLowerBound(0), array.Length, value, null);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00007CF2 File Offset: 0x00005EF2
		public static int BinarySearch(Array array, int index, int length, [Nullable(2)] object value)
		{
			return Array.BinarySearch(array, index, length, value, null);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00007CFE File Offset: 0x00005EFE
		[NullableContext(2)]
		public static int BinarySearch([Nullable(1)] Array array, object value, IComparer comparer)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			return Array.BinarySearch(array, array.GetLowerBound(0), array.Length, value, comparer);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00007D20 File Offset: 0x00005F20
		[NullableContext(2)]
		public static int BinarySearch([Nullable(1)] Array array, int index, int length, object value, IComparer comparer)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			int lowerBound = array.GetLowerBound(0);
			if (index < lowerBound)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (length < 0)
			{
				ThrowHelper.ThrowLengthArgumentOutOfRange_ArgumentOutOfRange_NeedNonNegNum();
			}
			if (array.Length - (index - lowerBound) < length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			if (array.Rank != 1)
			{
				ThrowHelper.ThrowRankException(ExceptionResource.Rank_MultiDimNotSupported);
			}
			if (comparer == null)
			{
				comparer = Comparer.Default;
			}
			int i = index;
			int num = index + length - 1;
			object[] array2 = array as object[];
			if (array2 != null)
			{
				while (i <= num)
				{
					int median = Array.GetMedian(i, num);
					int num2;
					try
					{
						num2 = comparer.Compare(array2[median], value);
					}
					catch (Exception e)
					{
						ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_IComparerFailed, e);
						return 0;
					}
					if (num2 == 0)
					{
						return median;
					}
					if (num2 < 0)
					{
						i = median + 1;
					}
					else
					{
						num = median - 1;
					}
				}
				return ~i;
			}
			if (comparer == Comparer.Default)
			{
				CorElementType corElementTypeOfElementType = array.GetCorElementTypeOfElementType();
				if (corElementTypeOfElementType.IsPrimitiveType())
				{
					if (value == null)
					{
						return ~index;
					}
					if (array.IsValueOfElementType(value))
					{
						int adjustedIndex = index - lowerBound;
						int num3 = -1;
						switch (corElementTypeOfElementType)
						{
						case CorElementType.ELEMENT_TYPE_BOOLEAN:
						case CorElementType.ELEMENT_TYPE_U1:
							num3 = Array.<BinarySearch>g__GenericBinarySearch|123_0<byte>(array, adjustedIndex, length, value);
							break;
						case CorElementType.ELEMENT_TYPE_CHAR:
						case CorElementType.ELEMENT_TYPE_U2:
							num3 = Array.<BinarySearch>g__GenericBinarySearch|123_0<ushort>(array, adjustedIndex, length, value);
							break;
						case CorElementType.ELEMENT_TYPE_I1:
							num3 = Array.<BinarySearch>g__GenericBinarySearch|123_0<sbyte>(array, adjustedIndex, length, value);
							break;
						case CorElementType.ELEMENT_TYPE_I2:
							num3 = Array.<BinarySearch>g__GenericBinarySearch|123_0<short>(array, adjustedIndex, length, value);
							break;
						case CorElementType.ELEMENT_TYPE_I4:
							num3 = Array.<BinarySearch>g__GenericBinarySearch|123_0<int>(array, adjustedIndex, length, value);
							break;
						case CorElementType.ELEMENT_TYPE_U4:
							num3 = Array.<BinarySearch>g__GenericBinarySearch|123_0<uint>(array, adjustedIndex, length, value);
							break;
						case CorElementType.ELEMENT_TYPE_I8:
						case CorElementType.ELEMENT_TYPE_I:
							num3 = Array.<BinarySearch>g__GenericBinarySearch|123_0<long>(array, adjustedIndex, length, value);
							break;
						case CorElementType.ELEMENT_TYPE_U8:
						case CorElementType.ELEMENT_TYPE_U:
							num3 = Array.<BinarySearch>g__GenericBinarySearch|123_0<ulong>(array, adjustedIndex, length, value);
							break;
						case CorElementType.ELEMENT_TYPE_R4:
							num3 = Array.<BinarySearch>g__GenericBinarySearch|123_0<float>(array, adjustedIndex, length, value);
							break;
						case CorElementType.ELEMENT_TYPE_R8:
							num3 = Array.<BinarySearch>g__GenericBinarySearch|123_0<double>(array, adjustedIndex, length, value);
							break;
						}
						if (num3 < 0)
						{
							return ~(index + ~num3);
						}
						return index + num3;
					}
				}
			}
			while (i <= num)
			{
				int median2 = Array.GetMedian(i, num);
				int num4;
				try
				{
					num4 = comparer.Compare(array.GetValue(median2), value);
				}
				catch (Exception e2)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_IComparerFailed, e2);
					return 0;
				}
				if (num4 == 0)
				{
					return median2;
				}
				if (num4 < 0)
				{
					i = median2 + 1;
				}
				else
				{
					num = median2 - 1;
				}
			}
			return ~i;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00007F8C File Offset: 0x0000618C
		public static int BinarySearch<[Nullable(2)] T>(T[] array, T value)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			return Array.BinarySearch<T>(array, 0, array.Length, value, null);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00007FA3 File Offset: 0x000061A3
		public static int BinarySearch<[Nullable(2)] T>(T[] array, T value, [Nullable(new byte[]
		{
			2,
			1
		})] IComparer<T> comparer)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			return Array.BinarySearch<T>(array, 0, array.Length, value, comparer);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00007FBA File Offset: 0x000061BA
		public static int BinarySearch<[Nullable(2)] T>(T[] array, int index, int length, T value)
		{
			return Array.BinarySearch<T>(array, index, length, value, null);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00007FC6 File Offset: 0x000061C6
		public static int BinarySearch<[Nullable(2)] T>(T[] array, int index, int length, T value, [Nullable(new byte[]
		{
			2,
			1
		})] IComparer<T> comparer)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (length < 0)
			{
				ThrowHelper.ThrowLengthArgumentOutOfRange_ArgumentOutOfRange_NeedNonNegNum();
			}
			if (array.Length - index < length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			return ArraySortHelper<T>.Default.BinarySearch(array, index, length, value, comparer);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00008004 File Offset: 0x00006204
		public static TOutput[] ConvertAll<[Nullable(2)] TInput, [Nullable(2)] TOutput>(TInput[] array, Converter<TInput, TOutput> converter)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (converter == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.converter);
			}
			TOutput[] array2 = new TOutput[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = converter(array[i]);
			}
			return array2;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00008050 File Offset: 0x00006250
		public void CopyTo(Array array, int index)
		{
			if (array != null && array.Rank != 1)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
			}
			Array.Copy(this, this.GetLowerBound(0), array, index, this.Length);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000807C File Offset: 0x0000627C
		public void CopyTo(Array array, long index)
		{
			int num = (int)index;
			if (index != (long)num)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported);
			}
			this.CopyTo(array, num);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000080A2 File Offset: 0x000062A2
		public static T[] Empty<[Nullable(2)] T>()
		{
			return Array.EmptyArray<T>.Value;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000080A9 File Offset: 0x000062A9
		public static bool Exists<[Nullable(2)] T>(T[] array, Predicate<T> match)
		{
			return Array.FindIndex<T>(array, match) != -1;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000080B8 File Offset: 0x000062B8
		public static void Fill<[Nullable(2)] T>(T[] array, T value)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (!typeof(T).IsValueType && array.GetType() != typeof(T[]))
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = value;
				}
				return;
			}
			new Span<T>(array).Fill(value);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000811C File Offset: 0x0000631C
		public static void Fill<[Nullable(2)] T>(T[] array, T value, int startIndex, int count)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (startIndex > array.Length)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLessOrEqual();
			}
			if (count > array.Length - startIndex)
			{
				ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count();
			}
			if (!typeof(T).IsValueType && array.GetType() != typeof(T[]))
			{
				for (int i = startIndex; i < startIndex + count; i++)
				{
					array[i] = value;
				}
				return;
			}
			new Span<T>(Unsafe.Add<T>(MemoryMarshal.GetArrayDataReference<T>(array), (IntPtr)((UIntPtr)startIndex)), count).Fill(value);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000081A8 File Offset: 0x000063A8
		[return: Nullable(2)]
		public static T Find<[Nullable(2)] T>(T[] array, Predicate<T> match)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (match(array[i]))
				{
					return array[i];
				}
			}
			return default(T);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000081F8 File Offset: 0x000063F8
		public static T[] FindAll<[Nullable(2)] T>(T[] array, Predicate<T> match)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			List<T> list = new List<T>();
			for (int i = 0; i < array.Length; i++)
			{
				if (match(array[i]))
				{
					list.Add(array[i]);
				}
			}
			return list.ToArray();
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000824E File Offset: 0x0000644E
		public static int FindIndex<[Nullable(2)] T>(T[] array, Predicate<T> match)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			return Array.FindIndex<T>(array, 0, array.Length, match);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00008264 File Offset: 0x00006464
		public static int FindIndex<[Nullable(2)] T>(T[] array, int startIndex, Predicate<T> match)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			return Array.FindIndex<T>(array, startIndex, array.Length - startIndex, match);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000827C File Offset: 0x0000647C
		public static int FindIndex<[Nullable(2)] T>(T[] array, int startIndex, int count, Predicate<T> match)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (startIndex < 0 || startIndex > array.Length)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLessOrEqual();
			}
			if (count < 0 || startIndex > array.Length - count)
			{
				ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count();
			}
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			int num = startIndex + count;
			for (int i = startIndex; i < num; i++)
			{
				if (match(array[i]))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000082E0 File Offset: 0x000064E0
		[return: Nullable(2)]
		public static T FindLast<[Nullable(2)] T>(T[] array, Predicate<T> match)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			for (int i = array.Length - 1; i >= 0; i--)
			{
				if (match(array[i]))
				{
					return array[i];
				}
			}
			return default(T);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00008330 File Offset: 0x00006530
		public static int FindLastIndex<[Nullable(2)] T>(T[] array, Predicate<T> match)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			return Array.FindLastIndex<T>(array, array.Length - 1, array.Length, match);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000834A File Offset: 0x0000654A
		public static int FindLastIndex<[Nullable(2)] T>(T[] array, int startIndex, Predicate<T> match)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			return Array.FindLastIndex<T>(array, startIndex, startIndex + 1, match);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00008360 File Offset: 0x00006560
		public static int FindLastIndex<[Nullable(2)] T>(T[] array, int startIndex, int count, Predicate<T> match)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			if (array.Length == 0)
			{
				if (startIndex != -1)
				{
					ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLess();
				}
			}
			else if (startIndex < 0 || startIndex >= array.Length)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLess();
			}
			if (count < 0 || startIndex - count + 1 < 0)
			{
				ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count();
			}
			int num = startIndex - count;
			for (int i = startIndex; i > num; i--)
			{
				if (match(array[i]))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000083D4 File Offset: 0x000065D4
		public static void ForEach<[Nullable(2)] T>(T[] array, Action<T> action)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (action == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.action);
			}
			for (int i = 0; i < array.Length; i++)
			{
				action(array[i]);
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000840F File Offset: 0x0000660F
		public static int IndexOf(Array array, [Nullable(2)] object value)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			return Array.IndexOf(array, value, array.GetLowerBound(0), array.Length);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00008430 File Offset: 0x00006630
		public static int IndexOf(Array array, [Nullable(2)] object value, int startIndex)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			int lowerBound = array.GetLowerBound(0);
			return Array.IndexOf(array, value, startIndex, array.Length - startIndex + lowerBound);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00008460 File Offset: 0x00006660
		public static int IndexOf(Array array, [Nullable(2)] object value, int startIndex, int count)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (array.Rank != 1)
			{
				ThrowHelper.ThrowRankException(ExceptionResource.Rank_MultiDimNotSupported);
			}
			int lowerBound = array.GetLowerBound(0);
			if (startIndex < lowerBound || startIndex > array.Length + lowerBound)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLessOrEqual();
			}
			if (count < 0 || count > array.Length - startIndex + lowerBound)
			{
				ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count();
			}
			int num = startIndex + count;
			object[] array2 = array as object[];
			if (array2 != null)
			{
				if (value == null)
				{
					for (int i = startIndex; i < num; i++)
					{
						if (array2[i] == null)
						{
							return i;
						}
					}
				}
				else
				{
					for (int j = startIndex; j < num; j++)
					{
						object obj = array2[j];
						if (obj != null && obj.Equals(value))
						{
							return j;
						}
					}
				}
				return -1;
			}
			CorElementType corElementTypeOfElementType = array.GetCorElementTypeOfElementType();
			if (corElementTypeOfElementType.IsPrimitiveType())
			{
				if (value == null)
				{
					return lowerBound - 1;
				}
				if (array.IsValueOfElementType(value))
				{
					int adjustedIndex = startIndex - lowerBound;
					int num2 = -1;
					switch (corElementTypeOfElementType)
					{
					case CorElementType.ELEMENT_TYPE_BOOLEAN:
					case CorElementType.ELEMENT_TYPE_I1:
					case CorElementType.ELEMENT_TYPE_U1:
						num2 = Array.<IndexOf>g__GenericIndexOf|148_0<byte>(array, value, adjustedIndex, count);
						break;
					case CorElementType.ELEMENT_TYPE_CHAR:
					case CorElementType.ELEMENT_TYPE_I2:
					case CorElementType.ELEMENT_TYPE_U2:
						num2 = Array.<IndexOf>g__GenericIndexOf|148_0<char>(array, value, adjustedIndex, count);
						break;
					case CorElementType.ELEMENT_TYPE_I4:
					case CorElementType.ELEMENT_TYPE_U4:
						num2 = Array.<IndexOf>g__GenericIndexOf|148_0<int>(array, value, adjustedIndex, count);
						break;
					case CorElementType.ELEMENT_TYPE_I8:
					case CorElementType.ELEMENT_TYPE_U8:
					case CorElementType.ELEMENT_TYPE_I:
					case CorElementType.ELEMENT_TYPE_U:
						num2 = Array.<IndexOf>g__GenericIndexOf|148_0<long>(array, value, adjustedIndex, count);
						break;
					case CorElementType.ELEMENT_TYPE_R4:
						num2 = Array.<IndexOf>g__GenericIndexOf|148_0<float>(array, value, adjustedIndex, count);
						break;
					case CorElementType.ELEMENT_TYPE_R8:
						num2 = Array.<IndexOf>g__GenericIndexOf|148_0<double>(array, value, adjustedIndex, count);
						break;
					}
					return ((num2 >= 0) ? startIndex : lowerBound) + num2;
				}
			}
			for (int k = startIndex; k < num; k++)
			{
				object value2 = array.GetValue(k);
				if (value2 == null)
				{
					if (value == null)
					{
						return k;
					}
				}
				else if (value2.Equals(value))
				{
					return k;
				}
			}
			return lowerBound - 1;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00008637 File Offset: 0x00006837
		public static int IndexOf<[Nullable(2)] T>(T[] array, T value)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			return Array.IndexOf<T>(array, value, 0, array.Length);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000864D File Offset: 0x0000684D
		public static int IndexOf<[Nullable(2)] T>(T[] array, T value, int startIndex)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			return Array.IndexOf<T>(array, value, startIndex, array.Length - startIndex);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00008668 File Offset: 0x00006868
		public unsafe static int IndexOf<[Nullable(2)] T>(T[] array, T value, int startIndex, int count)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (startIndex > array.Length)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLessOrEqual();
			}
			if (count > array.Length - startIndex)
			{
				ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count();
			}
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					int num = SpanHelpers.IndexOfValueType<byte>(Unsafe.Add<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetArrayDataReference<T>(array)), startIndex), *Unsafe.As<T, byte>(ref value), count);
					return ((num >= 0) ? startIndex : 0) + num;
				}
				if (sizeof(T) == 2)
				{
					int num2 = SpanHelpers.IndexOfValueType<short>(Unsafe.Add<short>(Unsafe.As<T, short>(MemoryMarshal.GetArrayDataReference<T>(array)), startIndex), *Unsafe.As<T, short>(ref value), count);
					return ((num2 >= 0) ? startIndex : 0) + num2;
				}
				if (sizeof(T) == 4)
				{
					int num3 = SpanHelpers.IndexOfValueType<int>(Unsafe.Add<int>(Unsafe.As<T, int>(MemoryMarshal.GetArrayDataReference<T>(array)), startIndex), *Unsafe.As<T, int>(ref value), count);
					return ((num3 >= 0) ? startIndex : 0) + num3;
				}
				if (sizeof(T) == 8)
				{
					int num4 = SpanHelpers.IndexOfValueType<long>(Unsafe.Add<long>(Unsafe.As<T, long>(MemoryMarshal.GetArrayDataReference<T>(array)), startIndex), *Unsafe.As<T, long>(ref value), count);
					return ((num4 >= 0) ? startIndex : 0) + num4;
				}
			}
			return EqualityComparer<T>.Default.IndexOf(array, value, startIndex, count);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00008780 File Offset: 0x00006980
		public static int LastIndexOf(Array array, [Nullable(2)] object value)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			int lowerBound = array.GetLowerBound(0);
			return Array.LastIndexOf(array, value, array.Length - 1 + lowerBound, array.Length);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000087B8 File Offset: 0x000069B8
		public static int LastIndexOf(Array array, [Nullable(2)] object value, int startIndex)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			int lowerBound = array.GetLowerBound(0);
			return Array.LastIndexOf(array, value, startIndex, startIndex + 1 - lowerBound);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000087E4 File Offset: 0x000069E4
		public static int LastIndexOf(Array array, [Nullable(2)] object value, int startIndex, int count)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			int lowerBound = array.GetLowerBound(0);
			if (array.Length == 0)
			{
				return lowerBound - 1;
			}
			if (startIndex < lowerBound || startIndex >= array.Length + lowerBound)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLess();
			}
			if (count < 0)
			{
				ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count();
			}
			if (count > startIndex - lowerBound + 1)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.endIndex, ExceptionResource.ArgumentOutOfRange_EndIndexStartIndex);
			}
			if (array.Rank != 1)
			{
				ThrowHelper.ThrowRankException(ExceptionResource.Rank_MultiDimNotSupported);
			}
			int num = startIndex - count + 1;
			object[] array2 = array as object[];
			if (array2 != null)
			{
				if (value == null)
				{
					for (int i = startIndex; i >= num; i--)
					{
						if (array2[i] == null)
						{
							return i;
						}
					}
				}
				else
				{
					for (int j = startIndex; j >= num; j--)
					{
						object obj = array2[j];
						if (obj != null && obj.Equals(value))
						{
							return j;
						}
					}
				}
				return -1;
			}
			CorElementType corElementTypeOfElementType = array.GetCorElementTypeOfElementType();
			if (corElementTypeOfElementType.IsPrimitiveType())
			{
				if (value == null)
				{
					return lowerBound - 1;
				}
				if (array.IsValueOfElementType(value))
				{
					int adjustedIndex = num - lowerBound;
					int num2 = -1;
					switch (corElementTypeOfElementType)
					{
					case CorElementType.ELEMENT_TYPE_BOOLEAN:
					case CorElementType.ELEMENT_TYPE_I1:
					case CorElementType.ELEMENT_TYPE_U1:
						num2 = Array.<LastIndexOf>g__GenericLastIndexOf|154_0<byte>(array, value, adjustedIndex, count);
						break;
					case CorElementType.ELEMENT_TYPE_CHAR:
					case CorElementType.ELEMENT_TYPE_I2:
					case CorElementType.ELEMENT_TYPE_U2:
						num2 = Array.<LastIndexOf>g__GenericLastIndexOf|154_0<char>(array, value, adjustedIndex, count);
						break;
					case CorElementType.ELEMENT_TYPE_I4:
					case CorElementType.ELEMENT_TYPE_U4:
						num2 = Array.<LastIndexOf>g__GenericLastIndexOf|154_0<int>(array, value, adjustedIndex, count);
						break;
					case CorElementType.ELEMENT_TYPE_I8:
					case CorElementType.ELEMENT_TYPE_U8:
					case CorElementType.ELEMENT_TYPE_I:
					case CorElementType.ELEMENT_TYPE_U:
						num2 = Array.<LastIndexOf>g__GenericLastIndexOf|154_0<long>(array, value, adjustedIndex, count);
						break;
					case CorElementType.ELEMENT_TYPE_R4:
						num2 = Array.<LastIndexOf>g__GenericLastIndexOf|154_0<float>(array, value, adjustedIndex, count);
						break;
					case CorElementType.ELEMENT_TYPE_R8:
						num2 = Array.<LastIndexOf>g__GenericLastIndexOf|154_0<double>(array, value, adjustedIndex, count);
						break;
					}
					return ((num2 >= 0) ? num : lowerBound) + num2;
				}
			}
			for (int k = startIndex; k >= num; k--)
			{
				object value2 = array.GetValue(k);
				if (value2 == null)
				{
					if (value == null)
					{
						return k;
					}
				}
				else if (value2.Equals(value))
				{
					return k;
				}
			}
			return lowerBound - 1;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000089CD File Offset: 0x00006BCD
		public static int LastIndexOf<[Nullable(2)] T>(T[] array, T value)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			return Array.LastIndexOf<T>(array, value, array.Length - 1, array.Length);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000089E7 File Offset: 0x00006BE7
		public static int LastIndexOf<[Nullable(2)] T>(T[] array, T value, int startIndex)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			return Array.LastIndexOf<T>(array, value, startIndex, (array.Length == 0) ? 0 : (startIndex + 1));
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00008A04 File Offset: 0x00006C04
		public unsafe static int LastIndexOf<[Nullable(2)] T>(T[] array, T value, int startIndex, int count)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (array.Length == 0)
			{
				if (startIndex != -1 && startIndex != 0)
				{
					ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLess();
				}
				if (count != 0)
				{
					ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count();
				}
				return -1;
			}
			if (startIndex >= array.Length)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLess();
			}
			if (count < 0 || startIndex - count + 1 < 0)
			{
				ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count();
			}
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					int num = startIndex - count + 1;
					int num2 = SpanHelpers.LastIndexOfValueType<byte>(Unsafe.Add<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetArrayDataReference<T>(array)), num), *Unsafe.As<T, byte>(ref value), count);
					return ((num2 >= 0) ? num : 0) + num2;
				}
				if (sizeof(T) == 2)
				{
					int num3 = startIndex - count + 1;
					int num4 = SpanHelpers.LastIndexOfValueType<short>(Unsafe.Add<short>(Unsafe.As<T, short>(MemoryMarshal.GetArrayDataReference<T>(array)), num3), *Unsafe.As<T, short>(ref value), count);
					return ((num4 >= 0) ? num3 : 0) + num4;
				}
				if (sizeof(T) == 4)
				{
					int num5 = startIndex - count + 1;
					int num6 = SpanHelpers.LastIndexOfValueType<int>(Unsafe.Add<int>(Unsafe.As<T, int>(MemoryMarshal.GetArrayDataReference<T>(array)), num5), *Unsafe.As<T, int>(ref value), count);
					return ((num6 >= 0) ? num5 : 0) + num6;
				}
				if (sizeof(T) == 8)
				{
					int num7 = startIndex - count + 1;
					int num8 = SpanHelpers.LastIndexOfValueType<long>(Unsafe.Add<long>(Unsafe.As<T, long>(MemoryMarshal.GetArrayDataReference<T>(array)), num7), *Unsafe.As<T, long>(ref value), count);
					return ((num8 >= 0) ? num7 : 0) + num8;
				}
			}
			return EqualityComparer<T>.Default.LastIndexOf(array, value, startIndex, count);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00008B5C File Offset: 0x00006D5C
		public static void Reverse(Array array)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			Array.Reverse(array, array.GetLowerBound(0), array.Length);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00008B7C File Offset: 0x00006D7C
		public static void Reverse(Array array, int index, int length)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			int lowerBound = array.GetLowerBound(0);
			if (index < lowerBound)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (length < 0)
			{
				ThrowHelper.ThrowLengthArgumentOutOfRange_ArgumentOutOfRange_NeedNonNegNum();
			}
			if (array.Length - (index - lowerBound) < length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			if (array.Rank != 1)
			{
				ThrowHelper.ThrowRankException(ExceptionResource.Rank_MultiDimNotSupported);
			}
			if (length <= 1)
			{
				return;
			}
			int adjustedIndex = index - lowerBound;
			switch (array.GetCorElementTypeOfElementType())
			{
			case CorElementType.ELEMENT_TYPE_BOOLEAN:
			case CorElementType.ELEMENT_TYPE_I1:
			case CorElementType.ELEMENT_TYPE_U1:
				Array.UnsafeArrayAsSpan<byte>(array, adjustedIndex, length).Reverse<byte>();
				return;
			case CorElementType.ELEMENT_TYPE_CHAR:
			case CorElementType.ELEMENT_TYPE_I2:
			case CorElementType.ELEMENT_TYPE_U2:
				Array.UnsafeArrayAsSpan<short>(array, adjustedIndex, length).Reverse<short>();
				return;
			case CorElementType.ELEMENT_TYPE_I4:
			case CorElementType.ELEMENT_TYPE_U4:
			case CorElementType.ELEMENT_TYPE_R4:
				Array.UnsafeArrayAsSpan<int>(array, adjustedIndex, length).Reverse<int>();
				return;
			case CorElementType.ELEMENT_TYPE_I8:
			case CorElementType.ELEMENT_TYPE_U8:
			case CorElementType.ELEMENT_TYPE_R8:
			case CorElementType.ELEMENT_TYPE_I:
			case CorElementType.ELEMENT_TYPE_U:
				Array.UnsafeArrayAsSpan<long>(array, adjustedIndex, length).Reverse<long>();
				return;
			case CorElementType.ELEMENT_TYPE_ARRAY:
			case CorElementType.ELEMENT_TYPE_OBJECT:
			case CorElementType.ELEMENT_TYPE_SZARRAY:
				Array.UnsafeArrayAsSpan<object>(array, adjustedIndex, length).Reverse<object>();
				return;
			}
			int i = index;
			int num = index + length - 1;
			while (i < num)
			{
				object value = array.GetValue(i);
				array.SetValue(array.GetValue(num), i);
				array.SetValue(value, num);
				i++;
				num--;
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00008CD8 File Offset: 0x00006ED8
		public static void Reverse<[Nullable(2)] T>(T[] array)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (array.Length > 1)
			{
				SpanHelpers.Reverse<T>(MemoryMarshal.GetArrayDataReference<T>(array), (UIntPtr)((IntPtr)array.Length));
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00008CF8 File Offset: 0x00006EF8
		public static void Reverse<[Nullable(2)] T>(T[] array, int index, int length)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (length < 0)
			{
				ThrowHelper.ThrowLengthArgumentOutOfRange_ArgumentOutOfRange_NeedNonNegNum();
			}
			if (array.Length - index < length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			if (length <= 1)
			{
				return;
			}
			SpanHelpers.Reverse<T>(Unsafe.Add<T>(MemoryMarshal.GetArrayDataReference<T>(array), index), (UIntPtr)((IntPtr)length));
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00008D47 File Offset: 0x00006F47
		public static void Sort(Array array)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			Array.Sort(array, null, array.GetLowerBound(0), array.Length, null);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00008D67 File Offset: 0x00006F67
		public static void Sort(Array keys, [Nullable(2)] Array items)
		{
			if (keys == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.keys);
			}
			Array.Sort(keys, items, keys.GetLowerBound(0), keys.Length, null);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00008D88 File Offset: 0x00006F88
		public static void Sort(Array array, int index, int length)
		{
			Array.Sort(array, null, index, length, null);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00008D94 File Offset: 0x00006F94
		public static void Sort(Array keys, [Nullable(2)] Array items, int index, int length)
		{
			Array.Sort(keys, items, index, length, null);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00008DA0 File Offset: 0x00006FA0
		public static void Sort(Array array, [Nullable(2)] IComparer comparer)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			Array.Sort(array, null, array.GetLowerBound(0), array.Length, comparer);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00008DC0 File Offset: 0x00006FC0
		[NullableContext(2)]
		public static void Sort([Nullable(1)] Array keys, Array items, IComparer comparer)
		{
			if (keys == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.keys);
			}
			Array.Sort(keys, items, keys.GetLowerBound(0), keys.Length, comparer);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00008DE1 File Offset: 0x00006FE1
		public static void Sort(Array array, int index, int length, [Nullable(2)] IComparer comparer)
		{
			Array.Sort(array, null, index, length, comparer);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00008DF0 File Offset: 0x00006FF0
		[NullableContext(2)]
		public static void Sort([Nullable(1)] Array keys, Array items, int index, int length, IComparer comparer)
		{
			if (keys == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.keys);
			}
			if (keys.Rank != 1 || (items != null && items.Rank != 1))
			{
				ThrowHelper.ThrowRankException(ExceptionResource.Rank_MultiDimNotSupported);
			}
			int lowerBound = keys.GetLowerBound(0);
			if (items != null && lowerBound != items.GetLowerBound(0))
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_LowerBoundsMustMatch);
			}
			if (index < lowerBound)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (length < 0)
			{
				ThrowHelper.ThrowLengthArgumentOutOfRange_ArgumentOutOfRange_NeedNonNegNum();
			}
			if (keys.Length - (index - lowerBound) < length || (items != null && index - lowerBound > items.Length - length))
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			if (length <= 1)
			{
				return;
			}
			if (comparer == null)
			{
				comparer = Comparer.Default;
			}
			object[] array = keys as object[];
			if (array != null)
			{
				object[] array2 = items as object[];
				if (items == null || array2 != null)
				{
					new Array.SorterObjectArray(array, array2, comparer).Sort(index, length);
					return;
				}
			}
			if (comparer == Comparer.Default)
			{
				CorElementType corElementTypeOfElementType = keys.GetCorElementTypeOfElementType();
				if (items == null || items.GetCorElementTypeOfElementType() == corElementTypeOfElementType)
				{
					int adjustedIndex = index - lowerBound;
					switch (corElementTypeOfElementType)
					{
					case CorElementType.ELEMENT_TYPE_BOOLEAN:
					case CorElementType.ELEMENT_TYPE_U1:
						Array.<Sort>g__GenericSort|169_0<byte>(keys, items, adjustedIndex, length);
						return;
					case CorElementType.ELEMENT_TYPE_CHAR:
					case CorElementType.ELEMENT_TYPE_U2:
						Array.<Sort>g__GenericSort|169_0<ushort>(keys, items, adjustedIndex, length);
						return;
					case CorElementType.ELEMENT_TYPE_I1:
						Array.<Sort>g__GenericSort|169_0<sbyte>(keys, items, adjustedIndex, length);
						return;
					case CorElementType.ELEMENT_TYPE_I2:
						Array.<Sort>g__GenericSort|169_0<short>(keys, items, adjustedIndex, length);
						return;
					case CorElementType.ELEMENT_TYPE_I4:
						Array.<Sort>g__GenericSort|169_0<int>(keys, items, adjustedIndex, length);
						return;
					case CorElementType.ELEMENT_TYPE_U4:
						Array.<Sort>g__GenericSort|169_0<uint>(keys, items, adjustedIndex, length);
						return;
					case CorElementType.ELEMENT_TYPE_I8:
					case CorElementType.ELEMENT_TYPE_I:
						Array.<Sort>g__GenericSort|169_0<long>(keys, items, adjustedIndex, length);
						return;
					case CorElementType.ELEMENT_TYPE_U8:
					case CorElementType.ELEMENT_TYPE_U:
						Array.<Sort>g__GenericSort|169_0<ulong>(keys, items, adjustedIndex, length);
						return;
					case CorElementType.ELEMENT_TYPE_R4:
						Array.<Sort>g__GenericSort|169_0<float>(keys, items, adjustedIndex, length);
						return;
					case CorElementType.ELEMENT_TYPE_R8:
						Array.<Sort>g__GenericSort|169_0<double>(keys, items, adjustedIndex, length);
						return;
					}
				}
			}
			new Array.SorterGenericArray(keys, items, comparer).Sort(index, length);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00008FC8 File Offset: 0x000071C8
		public static void Sort<[Nullable(2)] T>(T[] array)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (array.Length > 1)
			{
				Span<T> keys = new Span<T>(MemoryMarshal.GetArrayDataReference<T>(array), array.Length);
				ArraySortHelper<T>.Default.Sort(keys, null);
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00008FFF File Offset: 0x000071FF
		[NullableContext(2)]
		public static void Sort<TKey, TValue>([Nullable(1)] TKey[] keys, [Nullable(new byte[]
		{
			2,
			1
		})] TValue[] items)
		{
			if (keys == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.keys);
			}
			Array.Sort<TKey, TValue>(keys, items, 0, keys.Length, null);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00009017 File Offset: 0x00007217
		public static void Sort<[Nullable(2)] T>(T[] array, int index, int length)
		{
			Array.Sort<T>(array, index, length, null);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00009022 File Offset: 0x00007222
		[NullableContext(2)]
		public static void Sort<TKey, TValue>([Nullable(1)] TKey[] keys, [Nullable(new byte[]
		{
			2,
			1
		})] TValue[] items, int index, int length)
		{
			Array.Sort<TKey, TValue>(keys, items, index, length, null);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000902E File Offset: 0x0000722E
		public static void Sort<[Nullable(2)] T>(T[] array, [Nullable(new byte[]
		{
			2,
			1
		})] IComparer<T> comparer)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			Array.Sort<T>(array, 0, array.Length, comparer);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00009044 File Offset: 0x00007244
		[NullableContext(2)]
		public static void Sort<TKey, TValue>([Nullable(1)] TKey[] keys, [Nullable(new byte[]
		{
			2,
			1
		})] TValue[] items, [Nullable(new byte[]
		{
			2,
			1
		})] IComparer<TKey> comparer)
		{
			if (keys == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.keys);
			}
			Array.Sort<TKey, TValue>(keys, items, 0, keys.Length, comparer);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000905C File Offset: 0x0000725C
		public static void Sort<[Nullable(2)] T>(T[] array, int index, int length, [Nullable(new byte[]
		{
			2,
			1
		})] IComparer<T> comparer)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (length < 0)
			{
				ThrowHelper.ThrowLengthArgumentOutOfRange_ArgumentOutOfRange_NeedNonNegNum();
			}
			if (array.Length - index < length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			if (length > 1)
			{
				Span<T> keys = new Span<T>(Unsafe.Add<T>(MemoryMarshal.GetArrayDataReference<T>(array), index), length);
				ArraySortHelper<T>.Default.Sort(keys, comparer);
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000090B8 File Offset: 0x000072B8
		[NullableContext(2)]
		public static void Sort<TKey, TValue>([Nullable(1)] TKey[] keys, [Nullable(new byte[]
		{
			2,
			1
		})] TValue[] items, int index, int length, [Nullable(new byte[]
		{
			2,
			1
		})] IComparer<TKey> comparer)
		{
			if (keys == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.keys);
			}
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (length < 0)
			{
				ThrowHelper.ThrowLengthArgumentOutOfRange_ArgumentOutOfRange_NeedNonNegNum();
			}
			if (keys.Length - index < length || (items != null && index > items.Length - length))
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			if (length > 1)
			{
				if (items == null)
				{
					Array.Sort<TKey>(keys, index, length, comparer);
					return;
				}
				Span<TKey> keys2 = new Span<TKey>(Unsafe.Add<TKey>(MemoryMarshal.GetArrayDataReference<TKey>(keys), index), length);
				Span<TValue> values = new Span<TValue>(Unsafe.Add<TValue>(MemoryMarshal.GetArrayDataReference<TValue>(items), index), length);
				ArraySortHelper<TKey, TValue>.Default.Sort(keys2, values, comparer);
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00009141 File Offset: 0x00007341
		public static void Sort<[Nullable(2)] T>(T[] array, Comparison<T> comparison)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (comparison == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.comparison);
			}
			ArraySortHelper<T>.Sort(new Span<T>(MemoryMarshal.GetArrayDataReference<T>(array), array.Length), comparison);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000916C File Offset: 0x0000736C
		public static bool TrueForAll<[Nullable(2)] T>(T[] array, Predicate<T> match)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (!match(array[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060002CD RID: 717 RVA: 0x000091AC File Offset: 0x000073AC
		public static int MaxLength
		{
			get
			{
				return 2147483591;
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000091B4 File Offset: 0x000073B4
		private static Span<T> UnsafeArrayAsSpan<T>(Array array, int adjustedIndex, int length)
		{
			return new Span<T>(Unsafe.As<byte, T>(MemoryMarshal.GetArrayDataReference(array)), array.Length).Slice(adjustedIndex, length);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000091E1 File Offset: 0x000073E1
		public IEnumerator GetEnumerator()
		{
			return new ArrayEnumerator(this);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000091E9 File Offset: 0x000073E9
		[CompilerGenerated]
		internal unsafe static int <BinarySearch>g__GenericBinarySearch|123_0<T>(Array array, int adjustedIndex, int length, object value) where T : struct, IComparable<T>
		{
			return Array.UnsafeArrayAsSpan<T>(array, adjustedIndex, length).BinarySearch(*Unsafe.As<byte, T>(value.GetRawData()));
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00009208 File Offset: 0x00007408
		[CompilerGenerated]
		internal unsafe static int <IndexOf>g__GenericIndexOf|148_0<T>(Array array, object value, int adjustedIndex, int length) where T : struct, IEquatable<T>
		{
			return Array.UnsafeArrayAsSpan<T>(array, adjustedIndex, length).IndexOf(*Unsafe.As<byte, T>(value.GetRawData()));
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00009227 File Offset: 0x00007427
		[CompilerGenerated]
		internal unsafe static int <LastIndexOf>g__GenericLastIndexOf|154_0<T>(Array array, object value, int adjustedIndex, int length) where T : struct, IEquatable<T>
		{
			return Array.UnsafeArrayAsSpan<T>(array, adjustedIndex, length).LastIndexOf(*Unsafe.As<byte, T>(value.GetRawData()));
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00009248 File Offset: 0x00007448
		[CompilerGenerated]
		internal static void <Sort>g__GenericSort|169_0<T>(Array keys, Array items, int adjustedIndex, int length) where T : struct
		{
			Span<T> span = Array.UnsafeArrayAsSpan<T>(keys, adjustedIndex, length);
			if (items != null)
			{
				span.Sort(Array.UnsafeArrayAsSpan<T>(items, adjustedIndex, length));
				return;
			}
			span.Sort<T>();
		}

		// Token: 0x02000072 RID: 114
		[StructLayout(LayoutKind.Sequential)]
		internal sealed class RawData
		{
			// Token: 0x040001E4 RID: 484
			public IntPtr Bounds;

			// Token: 0x040001E5 RID: 485
			public uint Count;

			// Token: 0x040001E6 RID: 486
			private uint _Pad;

			// Token: 0x040001E7 RID: 487
			public byte Data;
		}

		// Token: 0x02000073 RID: 115
		private static class EmptyArray<T>
		{
			// Token: 0x040001E8 RID: 488
			internal static readonly T[] Value = new T[0];
		}

		// Token: 0x02000074 RID: 116
		private readonly struct SorterObjectArray
		{
			// Token: 0x060002D5 RID: 725 RVA: 0x00009283 File Offset: 0x00007483
			internal SorterObjectArray(object[] keys, object[] items, IComparer comparer)
			{
				this.keys = keys;
				this.items = items;
				this.comparer = comparer;
			}

			// Token: 0x060002D6 RID: 726 RVA: 0x0000929C File Offset: 0x0000749C
			internal void SwapIfGreater(int a, int b)
			{
				if (a != b && this.comparer.Compare(this.keys[a], this.keys[b]) > 0)
				{
					object obj = this.keys[a];
					this.keys[a] = this.keys[b];
					this.keys[b] = obj;
					if (this.items != null)
					{
						object obj2 = this.items[a];
						this.items[a] = this.items[b];
						this.items[b] = obj2;
					}
				}
			}

			// Token: 0x060002D7 RID: 727 RVA: 0x00009318 File Offset: 0x00007518
			private void Swap(int i, int j)
			{
				object obj = this.keys[i];
				this.keys[i] = this.keys[j];
				this.keys[j] = obj;
				if (this.items != null)
				{
					object obj2 = this.items[i];
					this.items[i] = this.items[j];
					this.items[j] = obj2;
				}
			}

			// Token: 0x060002D8 RID: 728 RVA: 0x00009371 File Offset: 0x00007571
			internal void Sort(int left, int length)
			{
				this.IntrospectiveSort(left, length);
			}

			// Token: 0x060002D9 RID: 729 RVA: 0x0000937C File Offset: 0x0000757C
			private void IntrospectiveSort(int left, int length)
			{
				if (length < 2)
				{
					return;
				}
				try
				{
					this.IntroSort(left, length + left - 1, 2 * (BitOperations.Log2((uint)length) + 1));
				}
				catch (IndexOutOfRangeException)
				{
					ThrowHelper.ThrowArgumentException_BadComparer(this.comparer);
				}
				catch (Exception e)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_IComparerFailed, e);
				}
			}

			// Token: 0x060002DA RID: 730 RVA: 0x000093DC File Offset: 0x000075DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void IntroSort(int lo, int hi, int depthLimit)
			{
				while (hi > lo)
				{
					int num = hi - lo + 1;
					if (num <= 16)
					{
						if (num == 2)
						{
							this.SwapIfGreater(lo, hi);
							return;
						}
						if (num == 3)
						{
							this.SwapIfGreater(lo, hi - 1);
							this.SwapIfGreater(lo, hi);
							this.SwapIfGreater(hi - 1, hi);
							return;
						}
						this.InsertionSort(lo, hi);
						return;
					}
					else
					{
						if (depthLimit == 0)
						{
							this.Heapsort(lo, hi);
							return;
						}
						depthLimit--;
						int num2 = this.PickPivotAndPartition(lo, hi);
						this.IntroSort(num2 + 1, hi, depthLimit);
						hi = num2 - 1;
					}
				}
			}

			// Token: 0x060002DB RID: 731 RVA: 0x0000945C File Offset: 0x0000765C
			private int PickPivotAndPartition(int lo, int hi)
			{
				int num = lo + (hi - lo) / 2;
				this.SwapIfGreater(lo, num);
				this.SwapIfGreater(lo, hi);
				this.SwapIfGreater(num, hi);
				object obj = this.keys[num];
				this.Swap(num, hi - 1);
				int i = lo;
				int num2 = hi - 1;
				while (i < num2)
				{
					while (this.comparer.Compare(this.keys[++i], obj) < 0)
					{
					}
					while (this.comparer.Compare(obj, this.keys[--num2]) < 0)
					{
					}
					if (i >= num2)
					{
						break;
					}
					this.Swap(i, num2);
				}
				if (i != hi - 1)
				{
					this.Swap(i, hi - 1);
				}
				return i;
			}

			// Token: 0x060002DC RID: 732 RVA: 0x000094FC File Offset: 0x000076FC
			private void Heapsort(int lo, int hi)
			{
				int num = hi - lo + 1;
				for (int i = num / 2; i >= 1; i--)
				{
					this.DownHeap(i, num, lo);
				}
				for (int j = num; j > 1; j--)
				{
					this.Swap(lo, lo + j - 1);
					this.DownHeap(1, j - 1, lo);
				}
			}

			// Token: 0x060002DD RID: 733 RVA: 0x0000954C File Offset: 0x0000774C
			private void DownHeap(int i, int n, int lo)
			{
				object obj = this.keys[lo + i - 1];
				object[] array = this.items;
				object obj2 = (array != null) ? array[lo + i - 1] : null;
				while (i <= n / 2)
				{
					int num = 2 * i;
					if (num < n && this.comparer.Compare(this.keys[lo + num - 1], this.keys[lo + num]) < 0)
					{
						num++;
					}
					if (this.comparer.Compare(obj, this.keys[lo + num - 1]) >= 0)
					{
						break;
					}
					this.keys[lo + i - 1] = this.keys[lo + num - 1];
					if (this.items != null)
					{
						this.items[lo + i - 1] = this.items[lo + num - 1];
					}
					i = num;
				}
				this.keys[lo + i - 1] = obj;
				if (this.items != null)
				{
					this.items[lo + i - 1] = obj2;
				}
			}

			// Token: 0x060002DE RID: 734 RVA: 0x00009630 File Offset: 0x00007830
			private void InsertionSort(int lo, int hi)
			{
				for (int i = lo; i < hi; i++)
				{
					int num = i;
					object obj = this.keys[i + 1];
					object[] array = this.items;
					object obj2 = (array != null) ? array[i + 1] : null;
					while (num >= lo && this.comparer.Compare(obj, this.keys[num]) < 0)
					{
						this.keys[num + 1] = this.keys[num];
						if (this.items != null)
						{
							this.items[num + 1] = this.items[num];
						}
						num--;
					}
					this.keys[num + 1] = obj;
					if (this.items != null)
					{
						this.items[num + 1] = obj2;
					}
				}
			}

			// Token: 0x040001E9 RID: 489
			private readonly object[] keys;

			// Token: 0x040001EA RID: 490
			private readonly object[] items;

			// Token: 0x040001EB RID: 491
			private readonly IComparer comparer;
		}

		// Token: 0x02000075 RID: 117
		private readonly struct SorterGenericArray
		{
			// Token: 0x060002DF RID: 735 RVA: 0x000096D9 File Offset: 0x000078D9
			internal SorterGenericArray(Array keys, Array items, IComparer comparer)
			{
				this.keys = keys;
				this.items = items;
				this.comparer = comparer;
			}

			// Token: 0x060002E0 RID: 736 RVA: 0x000096F0 File Offset: 0x000078F0
			internal void SwapIfGreater(int a, int b)
			{
				if (a != b && this.comparer.Compare(this.keys.GetValue(a), this.keys.GetValue(b)) > 0)
				{
					object value = this.keys.GetValue(a);
					this.keys.SetValue(this.keys.GetValue(b), a);
					this.keys.SetValue(value, b);
					if (this.items != null)
					{
						object value2 = this.items.GetValue(a);
						this.items.SetValue(this.items.GetValue(b), a);
						this.items.SetValue(value2, b);
					}
				}
			}

			// Token: 0x060002E1 RID: 737 RVA: 0x00009798 File Offset: 0x00007998
			private void Swap(int i, int j)
			{
				object value = this.keys.GetValue(i);
				this.keys.SetValue(this.keys.GetValue(j), i);
				this.keys.SetValue(value, j);
				if (this.items != null)
				{
					object value2 = this.items.GetValue(i);
					this.items.SetValue(this.items.GetValue(j), i);
					this.items.SetValue(value2, j);
				}
			}

			// Token: 0x060002E2 RID: 738 RVA: 0x00009811 File Offset: 0x00007A11
			internal void Sort(int left, int length)
			{
				this.IntrospectiveSort(left, length);
			}

			// Token: 0x060002E3 RID: 739 RVA: 0x0000981C File Offset: 0x00007A1C
			private void IntrospectiveSort(int left, int length)
			{
				if (length < 2)
				{
					return;
				}
				try
				{
					this.IntroSort(left, length + left - 1, 2 * (BitOperations.Log2((uint)length) + 1));
				}
				catch (IndexOutOfRangeException)
				{
					ThrowHelper.ThrowArgumentException_BadComparer(this.comparer);
				}
				catch (Exception e)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_IComparerFailed, e);
				}
			}

			// Token: 0x060002E4 RID: 740 RVA: 0x0000987C File Offset: 0x00007A7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void IntroSort(int lo, int hi, int depthLimit)
			{
				while (hi > lo)
				{
					int num = hi - lo + 1;
					if (num <= 16)
					{
						if (num == 2)
						{
							this.SwapIfGreater(lo, hi);
							return;
						}
						if (num == 3)
						{
							this.SwapIfGreater(lo, hi - 1);
							this.SwapIfGreater(lo, hi);
							this.SwapIfGreater(hi - 1, hi);
							return;
						}
						this.InsertionSort(lo, hi);
						return;
					}
					else
					{
						if (depthLimit == 0)
						{
							this.Heapsort(lo, hi);
							return;
						}
						depthLimit--;
						int num2 = this.PickPivotAndPartition(lo, hi);
						this.IntroSort(num2 + 1, hi, depthLimit);
						hi = num2 - 1;
					}
				}
			}

			// Token: 0x060002E5 RID: 741 RVA: 0x000098FC File Offset: 0x00007AFC
			private int PickPivotAndPartition(int lo, int hi)
			{
				int num = lo + (hi - lo) / 2;
				this.SwapIfGreater(lo, num);
				this.SwapIfGreater(lo, hi);
				this.SwapIfGreater(num, hi);
				object value = this.keys.GetValue(num);
				this.Swap(num, hi - 1);
				int i = lo;
				int num2 = hi - 1;
				while (i < num2)
				{
					while (this.comparer.Compare(this.keys.GetValue(++i), value) < 0)
					{
					}
					while (this.comparer.Compare(value, this.keys.GetValue(--num2)) < 0)
					{
					}
					if (i >= num2)
					{
						break;
					}
					this.Swap(i, num2);
				}
				if (i != hi - 1)
				{
					this.Swap(i, hi - 1);
				}
				return i;
			}

			// Token: 0x060002E6 RID: 742 RVA: 0x000099A8 File Offset: 0x00007BA8
			private void Heapsort(int lo, int hi)
			{
				int num = hi - lo + 1;
				for (int i = num / 2; i >= 1; i--)
				{
					this.DownHeap(i, num, lo);
				}
				for (int j = num; j > 1; j--)
				{
					this.Swap(lo, lo + j - 1);
					this.DownHeap(1, j - 1, lo);
				}
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x000099F8 File Offset: 0x00007BF8
			private void DownHeap(int i, int n, int lo)
			{
				object value = this.keys.GetValue(lo + i - 1);
				Array array = this.items;
				object value2 = (array != null) ? array.GetValue(lo + i - 1) : null;
				while (i <= n / 2)
				{
					int num = 2 * i;
					if (num < n && this.comparer.Compare(this.keys.GetValue(lo + num - 1), this.keys.GetValue(lo + num)) < 0)
					{
						num++;
					}
					if (this.comparer.Compare(value, this.keys.GetValue(lo + num - 1)) >= 0)
					{
						break;
					}
					this.keys.SetValue(this.keys.GetValue(lo + num - 1), lo + i - 1);
					Array array2 = this.items;
					if (array2 != null)
					{
						array2.SetValue(this.items.GetValue(lo + num - 1), lo + i - 1);
					}
					i = num;
				}
				this.keys.SetValue(value, lo + i - 1);
				Array array3 = this.items;
				if (array3 == null)
				{
					return;
				}
				array3.SetValue(value2, lo + i - 1);
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x00009B04 File Offset: 0x00007D04
			private void InsertionSort(int lo, int hi)
			{
				for (int i = lo; i < hi; i++)
				{
					int num = i;
					object value = this.keys.GetValue(i + 1);
					Array array = this.items;
					object value2 = (array != null) ? array.GetValue(i + 1) : null;
					while (num >= lo && this.comparer.Compare(value, this.keys.GetValue(num)) < 0)
					{
						this.keys.SetValue(this.keys.GetValue(num), num + 1);
						Array array2 = this.items;
						if (array2 != null)
						{
							array2.SetValue(this.items.GetValue(num), num + 1);
						}
						num--;
					}
					this.keys.SetValue(value, num + 1);
					Array array3 = this.items;
					if (array3 != null)
					{
						array3.SetValue(value2, num + 1);
					}
				}
			}

			// Token: 0x040001EC RID: 492
			private readonly Array keys;

			// Token: 0x040001ED RID: 493
			private readonly Array items;

			// Token: 0x040001EE RID: 494
			private readonly IComparer comparer;
		}
	}
}
