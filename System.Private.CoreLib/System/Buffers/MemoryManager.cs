using System;
using System.Runtime.CompilerServices;

namespace System.Buffers
{
	// Token: 0x02000347 RID: 839
	public abstract class MemoryManager<[Nullable(2)] T> : IMemoryOwner<T>, IDisposable, IPinnable
	{
		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06003AAE RID: 15022 RVA: 0x000C3588 File Offset: 0x000C1788
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public virtual Memory<T> Memory
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return new Memory<T>(this, this.GetSpan().Length);
			}
		}

		// Token: 0x06003AAF RID: 15023
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public abstract Span<T> GetSpan();

		// Token: 0x06003AB0 RID: 15024
		public abstract MemoryHandle Pin(int elementIndex = 0);

		// Token: 0x06003AB1 RID: 15025
		public abstract void Unpin();

		// Token: 0x06003AB2 RID: 15026 RVA: 0x000C35A9 File Offset: 0x000C17A9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected Memory<T> CreateMemory(int length)
		{
			return new Memory<T>(this, length);
		}

		// Token: 0x06003AB3 RID: 15027 RVA: 0x000C35B2 File Offset: 0x000C17B2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected Memory<T> CreateMemory(int start, int length)
		{
			return new Memory<T>(this, start, length);
		}

		// Token: 0x06003AB4 RID: 15028 RVA: 0x000C35BC File Offset: 0x000C17BC
		protected internal virtual bool TryGetArray([Nullable(new byte[]
		{
			0,
			1
		})] out ArraySegment<T> segment)
		{
			segment = default(ArraySegment<T>);
			return false;
		}

		// Token: 0x06003AB5 RID: 15029 RVA: 0x000C35C6 File Offset: 0x000C17C6
		void IDisposable.Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06003AB6 RID: 15030
		protected abstract void Dispose(bool disposing);
	}
}
