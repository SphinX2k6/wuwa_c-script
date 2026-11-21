using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Collections.Generic
{
	// Token: 0x020009DF RID: 2527
	internal abstract class RandomizedStringEqualityComparer : EqualityComparer<string>, IInternalStringEqualityComparer, IEqualityComparer<string>
	{
		// Token: 0x060093D6 RID: 37846 RVA: 0x001710C0 File Offset: 0x0016F2C0
		private unsafe RandomizedStringEqualityComparer(IEqualityComparer<string> underlyingComparer)
		{
			this._underlyingComparer = underlyingComparer;
			fixed (RandomizedStringEqualityComparer.MarvinSeed* ptr = &this._seed)
			{
				Interop.GetRandomBytes((byte*)ptr, sizeof(RandomizedStringEqualityComparer.MarvinSeed));
			}
		}

		// Token: 0x060093D7 RID: 37847 RVA: 0x001710F1 File Offset: 0x0016F2F1
		internal static RandomizedStringEqualityComparer Create(IEqualityComparer<string> underlyingComparer, bool ignoreCase)
		{
			if (!ignoreCase)
			{
				return new RandomizedStringEqualityComparer.OrdinalComparer(underlyingComparer);
			}
			return new RandomizedStringEqualityComparer.OrdinalIgnoreCaseComparer(underlyingComparer);
		}

		// Token: 0x060093D8 RID: 37848 RVA: 0x00171103 File Offset: 0x0016F303
		public IEqualityComparer<string> GetUnderlyingEqualityComparer()
		{
			return this._underlyingComparer;
		}

		// Token: 0x040022AE RID: 8878
		private readonly RandomizedStringEqualityComparer.MarvinSeed _seed;

		// Token: 0x040022AF RID: 8879
		private readonly IEqualityComparer<string> _underlyingComparer;

		// Token: 0x020009E0 RID: 2528
		private struct MarvinSeed
		{
			// Token: 0x040022B0 RID: 8880
			internal uint p0;

			// Token: 0x040022B1 RID: 8881
			internal uint p1;
		}

		// Token: 0x020009E1 RID: 2529
		private sealed class OrdinalComparer : RandomizedStringEqualityComparer, IAlternateEqualityComparer<ReadOnlySpan<char>, string>
		{
			// Token: 0x060093D9 RID: 37849 RVA: 0x0017110B File Offset: 0x0016F30B
			internal OrdinalComparer(IEqualityComparer<string> wrappedComparer) : base(wrappedComparer)
			{
			}

			// Token: 0x060093DA RID: 37850 RVA: 0x000664B5 File Offset: 0x000646B5
			string IAlternateEqualityComparer<ReadOnlySpan<char>, string>.Create(ReadOnlySpan<char> span)
			{
				return span.ToString();
			}

			// Token: 0x060093DB RID: 37851 RVA: 0x000666FD File Offset: 0x000648FD
			public override bool Equals(string x, string y)
			{
				return string.Equals(x, y);
			}

			// Token: 0x060093DC RID: 37852 RVA: 0x00066717 File Offset: 0x00064917
			bool IAlternateEqualityComparer<ReadOnlySpan<char>, string>.Equals(ReadOnlySpan<char> alternate, string other)
			{
				return (!alternate.IsEmpty || other != null) && alternate.SequenceEqual(other);
			}

			// Token: 0x060093DD RID: 37853 RVA: 0x00171114 File Offset: 0x0016F314
			public override int GetHashCode(string obj)
			{
				if (obj == null)
				{
					return 0;
				}
				return Marvin.ComputeHash32(Unsafe.As<char, byte>(obj.GetRawStringData()), (uint)(obj.Length * 2), this._seed.p0, this._seed.p1);
			}

			// Token: 0x060093DE RID: 37854 RVA: 0x00171149 File Offset: 0x0016F349
			int IAlternateEqualityComparer<ReadOnlySpan<char>, string>.GetHashCode(ReadOnlySpan<char> alternate)
			{
				return Marvin.ComputeHash32(Unsafe.As<char, byte>(MemoryMarshal.GetReference<char>(alternate)), (uint)(alternate.Length * 2), this._seed.p0, this._seed.p1);
			}
		}

		// Token: 0x020009E2 RID: 2530
		private sealed class OrdinalIgnoreCaseComparer : RandomizedStringEqualityComparer, IAlternateEqualityComparer<ReadOnlySpan<char>, string>
		{
			// Token: 0x060093DF RID: 37855 RVA: 0x0017110B File Offset: 0x0016F30B
			internal OrdinalIgnoreCaseComparer(IEqualityComparer<string> wrappedComparer) : base(wrappedComparer)
			{
			}

			// Token: 0x060093E0 RID: 37856 RVA: 0x000664B5 File Offset: 0x000646B5
			string IAlternateEqualityComparer<ReadOnlySpan<char>, string>.Create(ReadOnlySpan<char> span)
			{
				return span.ToString();
			}

			// Token: 0x060093E1 RID: 37857 RVA: 0x0017117A File Offset: 0x0016F37A
			public override bool Equals(string x, string y)
			{
				return string.EqualsOrdinalIgnoreCase(x, y);
			}

			// Token: 0x060093E2 RID: 37858 RVA: 0x000667E5 File Offset: 0x000649E5
			bool IAlternateEqualityComparer<ReadOnlySpan<char>, string>.Equals(ReadOnlySpan<char> alternate, string other)
			{
				return (!alternate.IsEmpty || other != null) && alternate.EqualsOrdinalIgnoreCase(other);
			}

			// Token: 0x060093E3 RID: 37859 RVA: 0x00171183 File Offset: 0x0016F383
			public override int GetHashCode(string obj)
			{
				if (obj == null)
				{
					return 0;
				}
				return Marvin.ComputeHash32OrdinalIgnoreCase(obj.GetRawStringData(), obj.Length, this._seed.p0, this._seed.p1);
			}

			// Token: 0x060093E4 RID: 37860 RVA: 0x001711B1 File Offset: 0x0016F3B1
			int IAlternateEqualityComparer<ReadOnlySpan<char>, string>.GetHashCode(ReadOnlySpan<char> alternate)
			{
				return Marvin.ComputeHash32OrdinalIgnoreCase(MemoryMarshal.GetReference<char>(alternate), alternate.Length, this._seed.p0, this._seed.p1);
			}
		}
	}
}
