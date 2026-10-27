using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x02006478 RID: 25720
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct ESpineAnimation : IEquatable<ESpineAnimation>
	{
		// Token: 0x06040A15 RID: 264725 RVA: 0x00FA5630 File Offset: 0x00FA3830
		private ESpineAnimation(string value)
		{
			this._Value = value;
		}

		// Token: 0x06040A16 RID: 264726 RVA: 0x00FA5639 File Offset: 0x00FA3839
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06040A17 RID: 264727 RVA: 0x00FA5641 File Offset: 0x00FA3841
		public bool Equals(ESpineAnimation other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06040A18 RID: 264728 RVA: 0x00FA5654 File Offset: 0x00FA3854
		public override bool Equals(object obj)
		{
			if (obj is ESpineAnimation)
			{
				ESpineAnimation other = (ESpineAnimation)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06040A19 RID: 264729 RVA: 0x00FA5679 File Offset: 0x00FA3879
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06040A1A RID: 264730 RVA: 0x00FA568C File Offset: 0x00FA388C
		public static bool operator ==(ESpineAnimation left, ESpineAnimation right)
		{
			return left.Equals(right);
		}

		// Token: 0x06040A1B RID: 264731 RVA: 0x00FA5696 File Offset: 0x00FA3896
		public static bool operator !=(ESpineAnimation left, ESpineAnimation right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040219A1 RID: 137633
		private readonly string _Value;

		// Token: 0x040219A2 RID: 137634
		public static readonly ESpineAnimation Idle = new ESpineAnimation("idle");

		// Token: 0x040219A3 RID: 137635
		public static readonly ESpineAnimation Success = new ESpineAnimation("happy");

		// Token: 0x040219A4 RID: 137636
		public static readonly ESpineAnimation Fail = new ESpineAnimation("fail");

		// Token: 0x040219A5 RID: 137637
		public static readonly ESpineAnimation Working = new ESpineAnimation("working");
	}
}
