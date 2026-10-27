using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063AF RID: 25519
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EMowingBuffIntroduceQualityBackground : IEquatable<EMowingBuffIntroduceQualityBackground>
	{
		// Token: 0x06040336 RID: 262966 RVA: 0x00F8B411 File Offset: 0x00F89611
		private EMowingBuffIntroduceQualityBackground(string value)
		{
			this._Value = value;
		}

		// Token: 0x06040337 RID: 262967 RVA: 0x00F8B41A File Offset: 0x00F8961A
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06040338 RID: 262968 RVA: 0x00F8B422 File Offset: 0x00F89622
		public bool Equals(EMowingBuffIntroduceQualityBackground other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06040339 RID: 262969 RVA: 0x00F8B438 File Offset: 0x00F89638
		public override bool Equals(object obj)
		{
			if (obj is EMowingBuffIntroduceQualityBackground)
			{
				EMowingBuffIntroduceQualityBackground other = (EMowingBuffIntroduceQualityBackground)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0604033A RID: 262970 RVA: 0x00F8B45D File Offset: 0x00F8965D
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0604033B RID: 262971 RVA: 0x00F8B470 File Offset: 0x00F89670
		public static bool operator ==(EMowingBuffIntroduceQualityBackground left, EMowingBuffIntroduceQualityBackground right)
		{
			return left.Equals(right);
		}

		// Token: 0x0604033C RID: 262972 RVA: 0x00F8B47A File Offset: 0x00F8967A
		public static bool operator !=(EMowingBuffIntroduceQualityBackground left, EMowingBuffIntroduceQualityBackground right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040216EE RID: 136942
		private readonly string _Value;

		// Token: 0x040216EF RID: 136943
		public static readonly EMowingBuffIntroduceQualityBackground Gold = new EMowingBuffIntroduceQualityBackground("T_MowingQualityGold");

		// Token: 0x040216F0 RID: 136944
		public static readonly EMowingBuffIntroduceQualityBackground Purple = new EMowingBuffIntroduceQualityBackground("T_MowingQualityPurple");

		// Token: 0x040216F1 RID: 136945
		public static readonly EMowingBuffIntroduceQualityBackground Blue = new EMowingBuffIntroduceQualityBackground("T_MowingQualityBlue");
	}
}
