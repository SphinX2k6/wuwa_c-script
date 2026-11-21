using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.Marshalling
{
	// Token: 0x0200061D RID: 1565
	[CLSCompliant(false)]
	[CustomMarshaller(typeof(CustomMarshallerAttribute.GenericPlaceholder*[]), MarshalMode.Default, typeof(PointerArrayMarshaller<, >))]
	[CustomMarshaller(typeof(CustomMarshallerAttribute.GenericPlaceholder*[]), MarshalMode.ManagedToUnmanagedIn, typeof(PointerArrayMarshaller<, >.ManagedToUnmanagedIn))]
	[ContiguousCollectionMarshaller]
	public unsafe static class PointerArrayMarshaller<[IsUnmanaged] T, [IsUnmanaged] TUnmanagedElement> where T : struct, ValueType where TUnmanagedElement : struct, ValueType
	{
		// Token: 0x060071FE RID: 29182 RVA: 0x00110A5A File Offset: 0x0010EC5A
		public unsafe static TUnmanagedElement* AllocateContainerForUnmanagedElements([Nullable(new byte[]
		{
			2,
			0,
			0
		})] T*[] managed, out int numElements)
		{
			if (managed == null)
			{
				numElements = 0;
				return null;
			}
			numElements = managed.Length;
			return Marshal.AllocCoTaskMem(Math.Max(checked(sizeof(TUnmanagedElement) * numElements), 1));
		}

		// Token: 0x060071FF RID: 29183 RVA: 0x00111B38 File Offset: 0x0010FD38
		public unsafe static ReadOnlySpan<IntPtr> GetManagedValuesSource([Nullable(new byte[]
		{
			2,
			0,
			0
		})] T*[] managed)
		{
			return Unsafe.As<IntPtr[]>(managed);
		}

		// Token: 0x06007200 RID: 29184 RVA: 0x00110A86 File Offset: 0x0010EC86
		public unsafe static Span<TUnmanagedElement> GetUnmanagedValuesDestination(TUnmanagedElement* unmanaged, int numElements)
		{
			return new Span<TUnmanagedElement>((void*)unmanaged, numElements);
		}

		// Token: 0x06007201 RID: 29185 RVA: 0x00111B45 File Offset: 0x0010FD45
		[return: Nullable(new byte[]
		{
			2,
			0,
			0
		})]
		public unsafe static T*[] AllocateContainerForManagedElements(TUnmanagedElement* unmanaged, int numElements)
		{
			if (unmanaged == null)
			{
				return null;
			}
			return new T*[numElements];
		}

		// Token: 0x06007202 RID: 29186 RVA: 0x00111B54 File Offset: 0x0010FD54
		public unsafe static Span<IntPtr> GetManagedValuesDestination([Nullable(new byte[]
		{
			2,
			0,
			0
		})] T*[] managed)
		{
			return Unsafe.As<IntPtr[]>(managed);
		}

		// Token: 0x06007203 RID: 29187 RVA: 0x00110AA6 File Offset: 0x0010ECA6
		public unsafe static ReadOnlySpan<TUnmanagedElement> GetUnmanagedValuesSource(TUnmanagedElement* unmanagedValue, int numElements)
		{
			return new ReadOnlySpan<TUnmanagedElement>((void*)unmanagedValue, numElements);
		}

		// Token: 0x06007204 RID: 29188 RVA: 0x001109AC File Offset: 0x0010EBAC
		public unsafe static void Free(TUnmanagedElement* unmanaged)
		{
			Marshal.FreeCoTaskMem(unmanaged);
		}

		// Token: 0x0200061E RID: 1566
		[CompilerFeatureRequired("RefStructs")]
		public ref struct ManagedToUnmanagedIn
		{
			// Token: 0x17000E13 RID: 3603
			// (get) Token: 0x06007205 RID: 29189 RVA: 0x00111B61 File Offset: 0x0010FD61
			public static int BufferSize
			{
				get
				{
					return 512 / sizeof(TUnmanagedElement);
				}
			}

			// Token: 0x06007206 RID: 29190 RVA: 0x00111B70 File Offset: 0x0010FD70
			public unsafe void FromManaged([Nullable(new byte[]
			{
				2,
				0,
				0
			})] T*[] array, Span<TUnmanagedElement> buffer)
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

			// Token: 0x06007207 RID: 29191 RVA: 0x00111BF3 File Offset: 0x0010FDF3
			public ReadOnlySpan<IntPtr> GetManagedValuesSource()
			{
				return Unsafe.As<IntPtr[]>(this._managedArray);
			}

			// Token: 0x06007208 RID: 29192 RVA: 0x00111C05 File Offset: 0x0010FE05
			public Span<TUnmanagedElement> GetUnmanagedValuesDestination()
			{
				return this._span;
			}

			// Token: 0x06007209 RID: 29193 RVA: 0x00111C0D File Offset: 0x0010FE0D
			public ref TUnmanagedElement GetPinnableReference()
			{
				return MemoryMarshal.GetReference<TUnmanagedElement>(this._span);
			}

			// Token: 0x0600720A RID: 29194 RVA: 0x00111C1A File Offset: 0x0010FE1A
			public unsafe TUnmanagedElement* ToUnmanaged()
			{
				return (TUnmanagedElement*)Unsafe.AsPointer<TUnmanagedElement>(this.GetPinnableReference());
			}

			// Token: 0x0600720B RID: 29195 RVA: 0x00111C27 File Offset: 0x0010FE27
			public unsafe void Free()
			{
				NativeMemory.Free((void*)this._allocatedMemory);
			}

			// Token: 0x0600720C RID: 29196 RVA: 0x00111C34 File Offset: 0x0010FE34
			public unsafe static ref byte GetPinnableReference([Nullable(new byte[]
			{
				2,
				0,
				0
			})] T*[] array)
			{
				if (array == null)
				{
					return Unsafe.NullRef<byte>();
				}
				return MemoryMarshal.GetArrayDataReference(array);
			}

			// Token: 0x04001388 RID: 5000
			private unsafe T*[] _managedArray;

			// Token: 0x04001389 RID: 5001
			private unsafe TUnmanagedElement* _allocatedMemory;

			// Token: 0x0400138A RID: 5002
			private Span<TUnmanagedElement> _span;
		}
	}
}
