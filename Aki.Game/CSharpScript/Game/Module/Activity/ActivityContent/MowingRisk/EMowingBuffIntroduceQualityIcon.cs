using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063B0 RID: 25520
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EMowingBuffIntroduceQualityIcon : IEquatable<EMowingBuffIntroduceQualityIcon>
	{
		// Token: 0x0604033E RID: 262974 RVA: 0x00F8B4B6 File Offset: 0x00F896B6
		private EMowingBuffIntroduceQualityIcon(string value)
		{
			this._Value = value;
		}

		// Token: 0x0604033F RID: 262975 RVA: 0x00F8B4BF File Offset: 0x00F896BF
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06040340 RID: 262976 RVA: 0x00F8B4C7 File Offset: 0x00F896C7
		public bool Equals(EMowingBuffIntroduceQualityIcon other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06040341 RID: 262977 RVA: 0x00F8B4DC File Offset: 0x00F896DC
		public override bool Equals(object obj)
		{
			if (obj is EMowingBuffIntroduceQualityIcon)
			{
				EMowingBuffIntroduceQualityIcon other = (EMowingBuffIntroduceQualityIcon)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06040342 RID: 262978 RVA: 0x00F8B501 File Offset: 0x00F89701
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06040343 RID: 262979 RVA: 0x00F8B514 File Offset: 0x00F89714
		public static bool operator ==(EMowingBuffIntroduceQualityIcon left, EMowingBuffIntroduceQualityIcon right)
		{
			return left.Equals(right);
		}

		// Token: 0x06040344 RID: 262980 RVA: 0x00F8B51E File Offset: 0x00F8971E
		public static bool operator !=(EMowingBuffIntroduceQualityIcon left, EMowingBuffIntroduceQualityIcon right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040216F2 RID: 136946
		private readonly string _Value;

		// Token: 0x040216F3 RID: 136947
		public static readonly EMowingBuffIntroduceQualityIcon Gold = new EMowingBuffIntroduceQualityIcon("SP_QualityGlodA");

		// Token: 0x040216F4 RID: 136948
		public static readonly EMowingBuffIntroduceQualityIcon Purple = new EMowingBuffIntroduceQualityIcon("SP_QualityPurpleA");

		// Token: 0x040216F5 RID: 136949
		public static readonly EMowingBuffIntroduceQualityIcon Blue = new EMowingBuffIntroduceQualityIcon("SP_QualityBlueA");
	}
}
