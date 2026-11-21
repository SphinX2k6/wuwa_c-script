using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x020053F6 RID: 21494
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct ESpineAnimation : IEquatable<ESpineAnimation>
	{
		// Token: 0x060356D9 RID: 218841 RVA: 0x00EEC678 File Offset: 0x00EEA878
		private ESpineAnimation(string value)
		{
			this._Value = value;
		}

		// Token: 0x060356DA RID: 218842 RVA: 0x00EEC681 File Offset: 0x00EEA881
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x060356DB RID: 218843 RVA: 0x00EEC689 File Offset: 0x00EEA889
		public bool Equals(ESpineAnimation other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x060356DC RID: 218844 RVA: 0x00EEC69C File Offset: 0x00EEA89C
		public override bool Equals(object obj)
		{
			if (obj is ESpineAnimation)
			{
				ESpineAnimation other = (ESpineAnimation)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060356DD RID: 218845 RVA: 0x00EEC6C1 File Offset: 0x00EEA8C1
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x060356DE RID: 218846 RVA: 0x00EEC6D4 File Offset: 0x00EEA8D4
		public static bool operator ==(ESpineAnimation left, ESpineAnimation right)
		{
			return left.Equals(right);
		}

		// Token: 0x060356DF RID: 218847 RVA: 0x00EEC6DE File Offset: 0x00EEA8DE
		public static bool operator !=(ESpineAnimation left, ESpineAnimation right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401C2D2 RID: 115410
		private readonly string _Value;

		// Token: 0x0401C2D3 RID: 115411
		public static readonly ESpineAnimation Idle = new ESpineAnimation("idle");

		// Token: 0x0401C2D4 RID: 115412
		public static readonly ESpineAnimation Success = new ESpineAnimation("happy");

		// Token: 0x0401C2D5 RID: 115413
		public static readonly ESpineAnimation Fail = new ESpineAnimation("fail");

		// Token: 0x0401C2D6 RID: 115414
		public static readonly ESpineAnimation Working = new ESpineAnimation("working");
	}
}
