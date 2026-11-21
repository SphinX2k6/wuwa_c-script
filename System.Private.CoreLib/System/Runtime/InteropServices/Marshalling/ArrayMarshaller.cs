using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.Marshalling
{
	// Token: 0x0200060B RID: 1547
	[CLSCompliant(false)]
	[CustomMarshaller(typeof(CustomMarshallerAttribute.GenericPlaceholder[]), MarshalMode.Default, typeof(ArrayMarshaller<, >))]
	[CustomMarshaller(typeof(CustomMarshallerAttribute.GenericPlaceholder[]), MarshalMode.ManagedToUnmanagedIn, typeof(ArrayMarshaller<, >.ManagedToUnmanagedIn))]
	[ContiguousCollectionMarshaller]
	public static class ArrayMarshaller<[Nullable(2)] T, [IsUnmanaged] TUnmanagedElement> where TUnmanagedElement : struct, ValueType
	{
		// Token: 0x060071CD RID: 29133 RVA: 0x00110A5A File Offset: 0x0010EC5A
		public unsafe static TUnmanagedElement* AllocateContainerForUnmanagedElements([Nullable(new byte[]
		{
			2,
			1
		})] T[] managed, out int numElements)
		{
			if (managed == null)
			{
				numElements = 0;
				return null;
			}
			numElements = managed.Length;
			return Marshal.AllocCoTaskMem(Math.Max(checked(sizeof(TUnmanagedElement) * numElements), 1));
		}

		// Token: 0x060071CE RID: 29134 RVA: 0x00110A7E File Offset: 0x0010EC7E
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static ReadOnlySpan<T> GetManagedValuesSource([Nullable(new byte[]
		{
			2,
			1
		})] T[] managed)
		{
			return managed;
		}

		// Token: 0x060071CF RID: 29135 RVA: 0x00110A86 File Offset: 0x0010EC86
		public unsafe static Span<TUnmanagedElement> GetUnmanagedValuesDestination(TUnmanagedElement* unmanaged, int numElements)
		{
			return new Span<TUnmanagedElement>((void*)unmanaged, numElements);
		}

		// Token: 0x060071D0 RID: 29136 RVA: 0x00110A8F File Offset: 0x0010EC8F
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public unsafe static T[] AllocateContainerForManagedElements(TUnmanagedElement* unmanaged, int numElements)
		{
			if (unmanaged == null)
			{
				return null;
			}
			return new T[numElements];
		}

		// Token: 0x060071D1 RID: 29137 RVA: 0x00110A9E File Offset: 0x0010EC9E
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> GetManagedValuesDestination([Nullable(new byte[]
		{
			2,
			1
		})] T[] managed)
		{
			return managed;
		}

		// Token: 0x060071D2 RID: 29138 RVA: 0x00110AA6 File Offset: 0x0010ECA6
		public unsafe static ReadOnlySpan<TUnmanagedElement> GetUnmanagedValuesSource(TUnmanagedElement* unmanagedValue, int numElements)
		{
			return new ReadOnlySpan<TUnmanagedElement>((void*)unmanagedValue, numElements);
		}

		// Token: 0x060071D3 RID: 29139 RVA: 0x001109AC File Offset: 0x0010EBAC
		public unsafe static void Free(TUnmanagedElement* unmanaged)
		{
			Marshal.FreeCoTaskMem(unmanaged);
		}

		// Token: 0x0200060C RID: 1548
		[CompilerFeatureRequired("RefStructs")]
		public ref struct ManagedToUnmanagedIn
		{
			// Token: 0x17000E07 RID: 3591
			// (get) Token: 0x060071D4 RID: 29140 RVA: 0x00110AAF File Offset: 0x0010ECAF
			public static int BufferSize { get; } = 512 / sizeof(TUnmanagedElement);

			// Token: 0x060071D5 RID: 29141 RVA: 0x00110AB8 File Offset: 0x0010ECB8
			public unsafe void FromManaged([Nullable(new byte[]
			{
				2,
				1
			})] T[] array, Span<TUnmanagedElement> buffer)
			{
				this._allocatedMemory = null;
				if (array == null)
				{
					this._managedArray = null;
					this._span = default(Span<TUnmanagedElement>);
					return;
				}
				this._managedArray = array;
				if (array.Length <= buffer.Length)
				{
					this._span = buffer.Slice(0, array.Length);
					return;
				}
				int num = Math.Max(checked(array.Length * sizeof(TUnmanagedElement)), 1);
				this._allocatedMemory = (TUnmanagedElement*)NativeMemory.Alloc((UIntPtr)((IntPtr)num));
				this._span = new Span<TUnmanagedElement>((void*)this._allocatedMemory, array.Length);
			}

			// Token: 0x060071D6 RID: 29142 RVA: 0x00110B3B File Offset: 0x0010ED3B
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			public ReadOnlySpan<T> GetManagedValuesSource()
			{
				return this._managedArray;
			}

			// Token: 0x060071D7 RID: 29143 RVA: 0x00110B48 File Offset: 0x0010ED48
			public Span<TUnmanagedElement> GetUnmanagedValuesDestination()
			{
				return this._span;
			}

			// Token: 0x060071D8 RID: 29144 RVA: 0x00110B50 File Offset: 0x0010ED50
			public ref TUnmanagedElement GetPinnableReference()
			{
				return MemoryMarshal.GetReference<TUnmanagedElement>(this._span);
			}

			// Token: 0x060071D9 RID: 29145 RVA: 0x00110B5D File Offset: 0x0010ED5D
			public unsafe TUnmanagedElement* ToUnmanaged()
			{
				return (TUnmanagedElement*)Unsafe.AsPointer<TUnmanagedElement>(this.GetPinnableReference());
			}

			// Token: 0x060071DA RID: 29146 RVA: 0x00110B6A File Offset: 0x0010ED6A
			public unsafe void Free()
			{
				NativeMemory.Free((void*)this._allocatedMemory);
			}

			// Token: 0x060071DB RID: 29147 RVA: 0x00110B77 File Offset: 0x0010ED77
			[NullableContext(1)]
			public static ref T GetPinnableReference([Nullable(new byte[]
			{
				2,
				1
			})] T[] array)
			{
				if (array == null)
				{
					return Unsafe.NullRef<T>();
				}
				return MemoryMarshal.GetArrayDataReference<T>(array);
			}

			// Token: 0x04001343 RID: 4931
			private T[] _managedArray;

			// Token: 0x04001344 RID: 4932
			private unsafe TUnmanagedElement* _allocatedMemory;

			// Token: 0x04001345 RID: 4933
			private Span<TUnmanagedElement> _span;
		}
	}
}
