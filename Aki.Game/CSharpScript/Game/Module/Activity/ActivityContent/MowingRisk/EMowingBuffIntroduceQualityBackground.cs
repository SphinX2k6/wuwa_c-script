using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x0200532D RID: 21293
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EMowingBuffIntroduceQualityBackground : IEquatable<EMowingBuffIntroduceQualityBackground>
	{
		// Token: 0x06034FF7 RID: 217079 RVA: 0x00ED23A9 File Offset: 0x00ED05A9
		private EMowingBuffIntroduceQualityBackground(string value)
		{
			this._Value = value;
		}

		// Token: 0x06034FF8 RID: 217080 RVA: 0x00ED23B2 File Offset: 0x00ED05B2
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06034FF9 RID: 217081 RVA: 0x00ED23BA File Offset: 0x00ED05BA
		public bool Equals(EMowingBuffIntroduceQualityBackground other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06034FFA RID: 217082 RVA: 0x00ED23D0 File Offset: 0x00ED05D0
		public override bool Equals(object obj)
		{
			if (obj is EMowingBuffIntroduceQualityBackground)
			{
				EMowingBuffIntroduceQualityBackground other = (EMowingBuffIntroduceQualityBackground)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06034FFB RID: 217083 RVA: 0x00ED23F5 File Offset: 0x00ED05F5
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06034FFC RID: 217084 RVA: 0x00ED2408 File Offset: 0x00ED0608
		public static bool operator ==(EMowingBuffIntroduceQualityBackground left, EMowingBuffIntroduceQualityBackground right)
		{
			return left.Equals(right);
		}

		// Token: 0x06034FFD RID: 217085 RVA: 0x00ED2412 File Offset: 0x00ED0612
		public static bool operator !=(EMowingBuffIntroduceQualityBackground left, EMowingBuffIntroduceQualityBackground right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401C01D RID: 114717
		private readonly string _Value;

		// Token: 0x0401C01E RID: 114718
		public static readonly EMowingBuffIntroduceQualityBackground Gold = new EMowingBuffIntroduceQualityBackground("T_MowingQualityGold");

		// Token: 0x0401C01F RID: 114719
		public static readonly EMowingBuffIntroduceQualityBackground Purple = new EMowingBuffIntroduceQualityBackground("T_MowingQualityPurple");

		// Token: 0x0401C020 RID: 114720
		public static readonly EMowingBuffIntroduceQualityBackground Blue = new EMowingBuffIntroduceQualityBackground("T_MowingQualityBlue");
	}
}
