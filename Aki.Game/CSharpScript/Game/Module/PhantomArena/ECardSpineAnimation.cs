using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040DB RID: 16603
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct ECardSpineAnimation : IEquatable<ECardSpineAnimation>
	{
		// Token: 0x0602A02D RID: 172077 RVA: 0x00BE13F4 File Offset: 0x00BDF5F4
		private ECardSpineAnimation(string value)
		{
			this._Value = value;
		}

		// Token: 0x0602A02E RID: 172078 RVA: 0x00BE13FD File Offset: 0x00BDF5FD
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0602A02F RID: 172079 RVA: 0x00BE1405 File Offset: 0x00BDF605
		public bool Equals(ECardSpineAnimation other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x0602A030 RID: 172080 RVA: 0x00BE1418 File Offset: 0x00BDF618
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is ECardSpineAnimation)
			{
				ECardSpineAnimation other = (ECardSpineAnimation)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602A031 RID: 172081 RVA: 0x00BE143D File Offset: 0x00BDF63D
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0602A032 RID: 172082 RVA: 0x00BE1450 File Offset: 0x00BDF650
		public static bool operator ==(ECardSpineAnimation left, ECardSpineAnimation right)
		{
			return left.Equals(right);
		}

		// Token: 0x0602A033 RID: 172083 RVA: 0x00BE145A File Offset: 0x00BDF65A
		public static bool operator !=(ECardSpineAnimation left, ECardSpineAnimation right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04016E52 RID: 93778
		private readonly string _Value;

		// Token: 0x04016E53 RID: 93779
		public static readonly ECardSpineAnimation Start = new ECardSpineAnimation("start");

		// Token: 0x04016E54 RID: 93780
		public static readonly ECardSpineAnimation Idle = new ECardSpineAnimation("idle");
	}
}
