using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005E2 RID: 1506
	public static class NativeMemory
	{
		// Token: 0x06007059 RID: 28761 RVA: 0x0010DD7C File Offset: 0x0010BF7C
		[CLSCompliant(false)]
		public unsafe static void* Alloc(UIntPtr elementCount, UIntPtr elementSize)
		{
			return NativeMemory.Alloc(NativeMemory.GetByteCount(elementCount, elementSize));
		}

		// Token: 0x0600705A RID: 28762 RVA: 0x0010DD8A File Offset: 0x0010BF8A
		[CLSCompliant(false)]
		public unsafe static void* AllocZeroed(UIntPtr byteCount)
		{
			return NativeMemory.AllocZeroed(byteCount, (UIntPtr)((IntPtr)1));
		}

		// Token: 0x0600705B RID: 28763 RVA: 0x0010DD94 File Offset: 0x0010BF94
		[CLSCompliant(false)]
		public unsafe static void Clear(void* ptr, UIntPtr byteCount)
		{
			SpanHelpers.ClearWithoutReferences(ref *(byte*)ptr, byteCount);
		}

		// Token: 0x0600705C RID: 28764 RVA: 0x0010DD9D File Offset: 0x0010BF9D
		[CLSCompliant(false)]
		public unsafe static void Copy(void* source, void* destination, UIntPtr byteCount)
		{
			SpanHelpers.Memmove(ref *(byte*)destination, ref *(byte*)source, byteCount);
		}

		// Token: 0x0600705D RID: 28765 RVA: 0x0010DDA7 File Offset: 0x0010BFA7
		[CLSCompliant(false)]
		public unsafe static void Fill(void* ptr, UIntPtr byteCount, byte value)
		{
			SpanHelpers.Fill<byte>(ref *(byte*)ptr, byteCount, value);
		}

		// Token: 0x0600705E RID: 28766 RVA: 0x0010DDB4 File Offset: 0x0010BFB4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static UIntPtr GetByteCount(UIntPtr elementCount, UIntPtr elementSize)
		{
			UIntPtr uintPtr = (UIntPtr)((IntPtr)1 << (4 * 8 & 8 * 8 - 1));
			if ((elementSize < uintPtr && elementCount < uintPtr) || elementSize <= (UIntPtr)((IntPtr)0) || UIntPtr.MaxValue / elementSize >= elementCount)
			{
				return elementCount * elementSize;
			}
			return UIntPtr.MaxValue;
		}

		// Token: 0x0600705F RID: 28767 RVA: 0x0010DDF6 File Offset: 0x0010BFF6
		[CLSCompliant(false)]
		public unsafe static void* AlignedAlloc(UIntPtr byteCount, UIntPtr alignment)
		{
			if (!BitOperations.IsPow2(alignment))
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_AlignmentMustBePow2);
			}
			void* ptr = Interop.Ucrtbase._aligned_malloc((byteCount != 0) ? byteCount : ((UIntPtr)((IntPtr)1)), alignment);
			if (ptr == null)
			{
				ThrowHelper.ThrowOutOfMemoryException();
			}
			return ptr;
		}

		// Token: 0x06007060 RID: 28768 RVA: 0x0010DE1F File Offset: 0x0010C01F
		[CLSCompliant(false)]
		public unsafe static void AlignedFree(void* ptr)
		{
			if (ptr != null)
			{
				Interop.Ucrtbase._aligned_free(ptr);
			}
		}

		// Token: 0x06007061 RID: 28769 RVA: 0x0010DE2C File Offset: 0x0010C02C
		[CLSCompliant(false)]
		public unsafe static void* AlignedRealloc(void* ptr, UIntPtr byteCount, UIntPtr alignment)
		{
			if (!BitOperations.IsPow2(alignment))
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_AlignmentMustBePow2);
			}
			void* ptr2 = Interop.Ucrtbase._aligned_realloc(ptr, (byteCount != 0) ? byteCount : ((UIntPtr)((IntPtr)1)), alignment);
			if (ptr2 == null)
			{
				ThrowHelper.ThrowOutOfMemoryException();
			}
			return ptr2;
		}

		// Token: 0x06007062 RID: 28770 RVA: 0x0010DE56 File Offset: 0x0010C056
		[CLSCompliant(false)]
		public unsafe static void* Alloc(UIntPtr byteCount)
		{
			void* ptr = Interop.Ucrtbase.malloc(byteCount);
			if (ptr == null)
			{
				ThrowHelper.ThrowOutOfMemoryException();
			}
			return ptr;
		}

		// Token: 0x06007063 RID: 28771 RVA: 0x0010DE68 File Offset: 0x0010C068
		[CLSCompliant(false)]
		public unsafe static void* AllocZeroed(UIntPtr elementCount, UIntPtr elementSize)
		{
			void* ptr = Interop.Ucrtbase.calloc(elementCount, elementSize);
			if (ptr == null)
			{
				ThrowHelper.ThrowOutOfMemoryException();
			}
			return ptr;
		}

		// Token: 0x06007064 RID: 28772 RVA: 0x0010DE7B File Offset: 0x0010C07B
		[CLSCompliant(false)]
		public unsafe static void Free(void* ptr)
		{
			if (ptr != null)
			{
				Interop.Ucrtbase.free(ptr);
			}
		}

		// Token: 0x06007065 RID: 28773 RVA: 0x0010DE88 File Offset: 0x0010C088
		[CLSCompliant(false)]
		public unsafe static void* Realloc(void* ptr, UIntPtr byteCount)
		{
			void* ptr2 = Interop.Ucrtbase.realloc(ptr, (byteCount != 0) ? byteCount : ((UIntPtr)((IntPtr)1)));
			if (ptr2 == null)
			{
				ThrowHelper.ThrowOutOfMemoryException();
			}
			return ptr2;
		}
	}
}
