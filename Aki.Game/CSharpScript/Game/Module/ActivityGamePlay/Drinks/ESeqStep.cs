using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityGamePlay.Drinks
{
	// Token: 0x02005881 RID: 22657
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct ESeqStep : IEquatable<ESeqStep>
	{
		// Token: 0x06037D4E RID: 228686 RVA: 0x00F9D19C File Offset: 0x00F9B39C
		private ESeqStep(string value)
		{
			this._Value = value;
		}

		// Token: 0x06037D4F RID: 228687 RVA: 0x00F9D1A5 File Offset: 0x00F9B3A5
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06037D50 RID: 228688 RVA: 0x00F9D1AD File Offset: 0x00F9B3AD
		public bool Equals(ESeqStep other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06037D51 RID: 228689 RVA: 0x00F9D1C0 File Offset: 0x00F9B3C0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is ESeqStep)
			{
				ESeqStep other = (ESeqStep)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06037D52 RID: 228690 RVA: 0x00F9D1E5 File Offset: 0x00F9B3E5
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06037D53 RID: 228691 RVA: 0x00F9D1F8 File Offset: 0x00F9B3F8
		public static bool operator ==(ESeqStep left, ESeqStep right)
		{
			return left.Equals(right);
		}

		// Token: 0x06037D54 RID: 228692 RVA: 0x00F9D202 File Offset: 0x00F9B402
		public static bool operator !=(ESeqStep left, ESeqStep right)
		{
			return !left.Equals(right);
		}

		// Token: 0x06037D55 RID: 228693 RVA: 0x00F9D20F File Offset: 0x00F9B40F
		public static implicit operator string(ESeqStep step)
		{
			return step._Value;
		}

		// Token: 0x0401D765 RID: 120677
		private readonly string _Value;

		// Token: 0x0401D766 RID: 120678
		public static readonly ESeqStep Begin = new ESeqStep("A");

		// Token: 0x0401D767 RID: 120679
		public static readonly ESeqStep DrinksStart = new ESeqStep("B");

		// Token: 0x0401D768 RID: 120680
		public static readonly ESeqStep DrinkQTE1End = new ESeqStep("C");

		// Token: 0x0401D769 RID: 120681
		public static readonly ESeqStep DrinkQTE2End = new ESeqStep("D");

		// Token: 0x0401D76A RID: 120682
		public static readonly ESeqStep DrinkQTE3End = new ESeqStep("E");

		// Token: 0x0401D76B RID: 120683
		public static readonly ESeqStep BatchingEnd = new ESeqStep("F");

		// Token: 0x0401D76C RID: 120684
		public static readonly ESeqStep ShakeEnd = new ESeqStep("G");

		// Token: 0x0401D76D RID: 120685
		public static readonly ESeqStep ShowEnd = new ESeqStep("H");
	}
}
