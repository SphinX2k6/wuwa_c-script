using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.Marshalling
{
	// Token: 0x02000627 RID: 1575
	[CLSCompliant(false)]
	[CustomMarshaller(typeof(Span<>), MarshalMode.Default, typeof(SpanMarshaller<, >))]
	[CustomMarshaller(typeof(Span<>), MarshalMode.ManagedToUnmanagedIn, typeof(SpanMarshaller<, >.ManagedToUnmanagedIn))]
	[ContiguousCollectionMarshaller]
	public static class SpanMarshaller<[Nullable(2)] T, [IsUnmanaged] TUnmanagedElement> where TUnmanagedElement : struct, ValueType
	{
		// Token: 0x0600722C RID: 29228 RVA: 0x00111F34 File Offset: 0x00110134
		public unsafe static TUnmanagedElement* AllocateContainerForUnmanagedElements([Nullable(new byte[]
		{
			0,
			1
		})] Span<T> managed, out int numElements)
		{
			if (Unsafe.IsNullRef<T>(MemoryMarshal.GetReference<T>(managed)))
			{
				numElements = 0;
				return null;
			}
			numElements = managed.Length;
			return Marshal.AllocCoTaskMem(Math.Max(checked(sizeof(TUnmanagedElement) * numElements), 1));
		}

		// Token: 0x0600722D RID: 29229 RVA: 0x00111F66 File Offset: 0x00110166
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static ReadOnlySpan<T> GetManagedValuesSource([Nullable(new byte[]
		{
			0,
			1
		})] Span<T> managed)
		{
			return managed;
		}

		// Token: 0x0600722E RID: 29230 RVA: 0x00110A86 File Offset: 0x0010EC86
		public unsafe static Span<TUnmanagedElement> GetUnmanagedValuesDestination(TUnmanagedElement* unmanaged, int numElements)
		{
			return new Span<TUnmanagedElement>((void*)unmanaged, numElements);
		}

		// Token: 0x0600722F RID: 29231 RVA: 0x00111F6E File Offset: 0x0011016E
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Span<T> AllocateContainerForManagedElements(TUnmanagedElement* unmanaged, int numElements)
		{
			if (unmanaged == null)
			{
				return null;
			}
			return new T[numElements];
		}

		// Token: 0x06007230 RID: 29232 RVA: 0x00007B62 File Offset: 0x00005D62
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> GetManagedValuesDestination([Nullable(new byte[]
		{
			0,
			1
		})] Span<T> managed)
		{
			return managed;
		}

		// Token: 0x06007231 RID: 29233 RVA: 0x00110AA6 File Offset: 0x0010ECA6
		public unsafe static ReadOnlySpan<TUnmanagedElement> GetUnmanagedValuesSource(TUnmanagedElement* unmanaged, int numElements)
		{
			return new ReadOnlySpan<TUnmanagedElement>((void*)unmanaged, numElements);
		}

		// Token: 0x06007232 RID: 29234 RVA: 0x001109AC File Offset: 0x0010EBAC
		public unsafe static void Free(TUnmanagedElement* unmanaged)
		{
			Marshal.FreeCoTaskMem(unmanaged);
		}

		// Token: 0x02000628 RID: 1576
		[CompilerFeatureRequired("RefStructs")]
		public ref struct ManagedToUnmanagedIn
		{
			// Token: 0x17000E15 RID: 3605
			// (get) Token: 0x06007233 RID: 29235 RVA: 0x00111F87 File Offset: 0x00110187
			public static int BufferSize { get; } = 512 / sizeof(TUnmanagedElement);

			// Token: 0x06007234 RID: 29236 RVA: 0x00111F90 File Offset: 0x00110190
			public unsafe void FromManaged([Nullable(new byte[]
			{
				0,
				1
			})] Span<T> managed, Span<TUnmanagedElement> buffer)
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

			// Token: 0x06007235 RID: 29237 RVA: 0x0011202C File Offset: 0x0011022C
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			public ReadOnlySpan<T> GetManagedValuesSource()
			{
				return this._managedArray;
			}

			// Token: 0x06007236 RID: 29238 RVA: 0x00112039 File Offset: 0x00110239
			public Span<TUnmanagedElement> GetUnmanagedValuesDestination()
			{
				return this._span;
			}

			// Token: 0x06007237 RID: 29239 RVA: 0x00112041 File Offset: 0x00110241
			public ref TUnmanagedElement GetPinnableReference()
			{
				return MemoryMarshal.GetReference<TUnmanagedElement>(this._span);
			}

			// Token: 0x06007238 RID: 29240 RVA: 0x0011204E File Offset: 0x0011024E
			public unsafe TUnmanagedElement* ToUnmanaged()
			{
				return (TUnmanagedElement*)Unsafe.AsPointer<TUnmanagedElement>(this.GetPinnableReference());
			}

			// Token: 0x06007239 RID: 29241 RVA: 0x0011205B File Offset: 0x0011025B
			public unsafe void Free()
			{
				NativeMemory.Free((void*)this._allocatedMemory);
			}

			// Token: 0x0600723A RID: 29242 RVA: 0x00112068 File Offset: 0x00110268
			[NullableContext(1)]
			public static ref T GetPinnableReference([Nullable(new byte[]
			{
				0,
				1
			})] Span<T> managed)
			{
				return MemoryMarshal.GetReference<T>(managed);
			}

			// Token: 0x0400139C RID: 5020
			private Span<T> _managedArray;

			// Token: 0x0400139D RID: 5021
			private unsafe TUnmanagedElement* _allocatedMemory;

			// Token: 0x0400139E RID: 5022
			private Span<TUnmanagedElement> _span;
		}
	}
}
