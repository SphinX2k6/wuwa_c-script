using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.Marshalling
{
	// Token: 0x0200061F RID: 1567
	[CLSCompliant(false)]
	[CustomMarshaller(typeof(ReadOnlySpan<>), MarshalMode.ManagedToUnmanagedIn, typeof(ReadOnlySpanMarshaller<, >.ManagedToUnmanagedIn))]
	[CustomMarshaller(typeof(ReadOnlySpan<>), MarshalMode.ManagedToUnmanagedOut, typeof(ReadOnlySpanMarshaller<, >.ManagedToUnmanagedOut))]
	[CustomMarshaller(typeof(ReadOnlySpan<>), MarshalMode.UnmanagedToManagedOut, typeof(ReadOnlySpanMarshaller<, >.UnmanagedToManagedOut))]
	[ContiguousCollectionMarshaller]
	public static class ReadOnlySpanMarshaller<[Nullable(2)] T, [IsUnmanaged] TUnmanagedElement> where TUnmanagedElement : struct, ValueType
	{
		// Token: 0x02000620 RID: 1568
		public static class UnmanagedToManagedOut
		{
			// Token: 0x0600720D RID: 29197 RVA: 0x00111C45 File Offset: 0x0010FE45
			public unsafe static TUnmanagedElement* AllocateContainerForUnmanagedElements([Nullable(new byte[]
			{
				0,
				1
			})] ReadOnlySpan<T> managed, out int numElements)
			{
				if (Unsafe.IsNullRef<T>(MemoryMarshal.GetReference<T>(managed)))
				{
					numElements = 0;
					return null;
				}
				numElements = managed.Length;
				return Marshal.AllocCoTaskMem(Math.Max(checked(sizeof(TUnmanagedElement) * numElements), 1));
			}

			// Token: 0x0600720E RID: 29198 RVA: 0x00007B62 File Offset: 0x00005D62
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			public static ReadOnlySpan<T> GetManagedValuesSource([Nullable(new byte[]
			{
				0,
				1
			})] ReadOnlySpan<T> managed)
			{
				return managed;
			}

			// Token: 0x0600720F RID: 29199 RVA: 0x00110A86 File Offset: 0x0010EC86
			public unsafe static Span<TUnmanagedElement> GetUnmanagedValuesDestination(TUnmanagedElement* unmanaged, int numElements)
			{
				return new Span<TUnmanagedElement>((void*)unmanaged, numElements);
			}
		}

		// Token: 0x02000621 RID: 1569
		[CompilerFeatureRequired("RefStructs")]
		public ref struct ManagedToUnmanagedIn
		{
			// Token: 0x17000E14 RID: 3604
			// (get) Token: 0x06007210 RID: 29200 RVA: 0x00111C77 File Offset: 0x0010FE77
			public static int BufferSize { get; } = 512 / sizeof(TUnmanagedElement);

			// Token: 0x06007211 RID: 29201 RVA: 0x00111C80 File Offset: 0x0010FE80
			public unsafe void FromManaged([Nullable(new byte[]
			{
				0,
				1
			})] ReadOnlySpan<T> managed, Span<TUnmanagedElement> buffer)
			{
				this._allocatedMemory = null;
				if (Unsafe.IsNullRef<T>(MemoryMarshal.GetReference<T>(managed)))
				{
					this._managedArray = null;
					this._span = default(Span<TUnmanagedElement>);
					return;
				}
				this._managedArray = managed;
				if (managed.Length <= buffer.Length)
				{
					this._span = buffer.Slice(0, managed.Length);
					return;
				}
				int num = checked(managed.Length * sizeof(TUnmanagedElement));
				this._allocatedMemory = (TUnmanagedElement*)NativeMemory.Alloc((UIntPtr)((IntPtr)num));
				this._span = new Span<TUnmanagedElement>((void*)this._allocatedMemory, managed.Length);
			}

			// Token: 0x06007212 RID: 29202 RVA: 0x00111D1C File Offset: 0x0010FF1C
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			public ReadOnlySpan<T> GetManagedValuesSource()
			{
				return this._managedArray;
			}

			// Token: 0x06007213 RID: 29203 RVA: 0x00111D24 File Offset: 0x0010FF24
			public Span<TUnmanagedElement> GetUnmanagedValuesDestination()
			{
				return this._span;
			}

			// Token: 0x06007214 RID: 29204 RVA: 0x00111D2C File Offset: 0x0010FF2C
			public ref TUnmanagedElement GetPinnableReference()
			{
				return MemoryMarshal.GetReference<TUnmanagedElement>(this._span);
			}

			// Token: 0x06007215 RID: 29205 RVA: 0x00111D39 File Offset: 0x0010FF39
			public unsafe TUnmanagedElement* ToUnmanaged()
			{
				return (TUnmanagedElement*)Unsafe.AsPointer<TUnmanagedElement>(this.GetPinnableReference());
			}

			// Token: 0x06007216 RID: 29206 RVA: 0x00111D46 File Offset: 0x0010FF46
			public unsafe void Free()
			{
				NativeMemory.Free((void*)this._allocatedMemory);
			}

			// Token: 0x06007217 RID: 29207 RVA: 0x00111D53 File Offset: 0x0010FF53
			[NullableContext(1)]
			public static ref T GetPinnableReference([Nullable(new byte[]
			{
				0,
				1
			})] ReadOnlySpan<T> managed)
			{
				return MemoryMarshal.GetReference<T>(managed);
			}

			// Token: 0x0400138C RID: 5004
			private ReadOnlySpan<T> _managedArray;

			// Token: 0x0400138D RID: 5005
			private unsafe TUnmanagedElement* _allocatedMemory;

			// Token: 0x0400138E RID: 5006
			private Span<TUnmanagedElement> _span;
		}

		// Token: 0x02000622 RID: 1570
		public struct ManagedToUnmanagedOut
		{
			// Token: 0x06007219 RID: 29209 RVA: 0x00111D6E File Offset: 0x0010FF6E
			public unsafe void FromUnmanaged(TUnmanagedElement* unmanaged)
			{
				this._unmanagedArray = unmanaged;
			}

			// Token: 0x0600721A RID: 29210 RVA: 0x00111D77 File Offset: 0x0010FF77
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			public ReadOnlySpan<T> ToManaged()
			{
				return new ReadOnlySpan<T>(this._managedValues);
			}

			// Token: 0x0600721B RID: 29211 RVA: 0x00111D84 File Offset: 0x0010FF84
			public unsafe ReadOnlySpan<TUnmanagedElement> GetUnmanagedValuesSource(int numElements)
			{
				return new ReadOnlySpan<TUnmanagedElement>((void*)this._unmanagedArray, numElements);
			}

			// Token: 0x0600721C RID: 29212 RVA: 0x00111D92 File Offset: 0x0010FF92
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			public Span<T> GetManagedValuesDestination(int numElements)
			{
				this._managedValues = new T[numElements];
				return this._managedValues;
			}

			// Token: 0x0600721D RID: 29213 RVA: 0x00111DAB File Offset: 0x0010FFAB
			public void Free()
			{
				Marshal.FreeCoTaskMem(this._unmanagedArray);
			}

			// Token: 0x0400138F RID: 5007
			private unsafe TUnmanagedElement* _unmanagedArray;

			// Token: 0x04001390 RID: 5008
			private T[] _managedValues;
		}
	}
}
