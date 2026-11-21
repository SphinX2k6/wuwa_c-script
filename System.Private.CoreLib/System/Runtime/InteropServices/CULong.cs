using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005C2 RID: 1474
	[CLSCompliant(false)]
	[Intrinsic]
	public readonly struct CULong : IEquatable<CULong>
	{
		// Token: 0x06007004 RID: 28676 RVA: 0x0010D8CF File Offset: 0x0010BACF
		public CULong(uint value)
		{
			this._value = value;
		}

		// Token: 0x06007005 RID: 28677 RVA: 0x0010D8D8 File Offset: 0x0010BAD8
		public CULong(UIntPtr value)
		{
			this._value = checked((uint)value);
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06007006 RID: 28678 RVA: 0x0010D8E2 File Offset: 0x0010BAE2
		public UIntPtr Value
		{
			get
			{
				return (UIntPtr)this._value;
			}
		}

		// Token: 0x06007007 RID: 28679 RVA: 0x0010D8EC File Offset: 0x0010BAEC
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object o)
		{
			if (o is CULong)
			{
				CULong other = (CULong)o;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06007008 RID: 28680 RVA: 0x0010D911 File Offset: 0x0010BB11
		public bool Equals(CULong other)
		{
			return this._value == other._value;
		}

		// Token: 0x06007009 RID: 28681 RVA: 0x0010D921 File Offset: 0x0010BB21
		public override int GetHashCode()
		{
			return this._value.GetHashCode();
		}

		// Token: 0x0600700A RID: 28682 RVA: 0x0010D92E File Offset: 0x0010BB2E
		[NullableContext(1)]
		public override string ToString()
		{
			return this._value.ToString();
		}

		// Token: 0x0400127D RID: 4733
		private readonly uint _value;
	}
}
