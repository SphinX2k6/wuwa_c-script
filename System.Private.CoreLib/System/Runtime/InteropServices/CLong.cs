using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005B1 RID: 1457
	[CLSCompliant(false)]
	[Intrinsic]
	public readonly struct CLong : IEquatable<CLong>
	{
		// Token: 0x06006FC8 RID: 28616 RVA: 0x0010D432 File Offset: 0x0010B632
		public CLong(int value)
		{
			this._value = value;
		}

		// Token: 0x06006FC9 RID: 28617 RVA: 0x0010D43B File Offset: 0x0010B63B
		public CLong(IntPtr value)
		{
			this._value = checked((int)value);
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06006FCA RID: 28618 RVA: 0x0010D445 File Offset: 0x0010B645
		public IntPtr Value
		{
			get
			{
				return (IntPtr)this._value;
			}
		}

		// Token: 0x06006FCB RID: 28619 RVA: 0x0010D450 File Offset: 0x0010B650
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object o)
		{
			if (o is CLong)
			{
				CLong other = (CLong)o;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06006FCC RID: 28620 RVA: 0x0010D475 File Offset: 0x0010B675
		public bool Equals(CLong other)
		{
			return this._value == other._value;
		}

		// Token: 0x06006FCD RID: 28621 RVA: 0x0010D485 File Offset: 0x0010B685
		public override int GetHashCode()
		{
			return this._value.GetHashCode();
		}

		// Token: 0x06006FCE RID: 28622 RVA: 0x0010D492 File Offset: 0x0010B692
		[NullableContext(1)]
		public override string ToString()
		{
			return this._value.ToString();
		}

		// Token: 0x0400125E RID: 4702
		private readonly int _value;
	}
}
