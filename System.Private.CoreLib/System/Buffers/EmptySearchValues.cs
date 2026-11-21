using System;

namespace System.Buffers
{
	// Token: 0x02000379 RID: 889
	internal sealed class EmptySearchValues<T> : SearchValues<T> where T : IEquatable<T>
	{
		// Token: 0x06003BDC RID: 15324 RVA: 0x000C7305 File Offset: 0x000C5505
		internal override T[] GetValues()
		{
			return Array.Empty<T>();
		}

		// Token: 0x06003BDD RID: 15325 RVA: 0x00007B65 File Offset: 0x00005D65
		internal override bool ContainsCore(T value)
		{
			return false;
		}

		// Token: 0x06003BDE RID: 15326 RVA: 0x0003F19A File Offset: 0x0003D39A
		internal override int IndexOfAny(ReadOnlySpan<T> span)
		{
			return -1;
		}

		// Token: 0x06003BDF RID: 15327 RVA: 0x000C730C File Offset: 0x000C550C
		internal override int IndexOfAnyExcept(ReadOnlySpan<T> span)
		{
			if (!span.IsEmpty)
			{
				return 0;
			}
			return -1;
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x0003F19A File Offset: 0x0003D39A
		internal override int LastIndexOfAny(ReadOnlySpan<T> span)
		{
			return -1;
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x000C731A File Offset: 0x000C551A
		internal override int LastIndexOfAnyExcept(ReadOnlySpan<T> span)
		{
			return span.Length - 1;
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x0003F19A File Offset: 0x0003D39A
		internal override int IndexOfAnyMultiString(ReadOnlySpan<char> span)
		{
			return -1;
		}
	}
}
