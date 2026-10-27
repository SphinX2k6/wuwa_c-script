using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x02006486 RID: 25734
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EMoonChasingGuideInBusinessHelper : IEquatable<EMoonChasingGuideInBusinessHelper>
	{
		// Token: 0x06040A58 RID: 264792 RVA: 0x00FA591B File Offset: 0x00FA3B1B
		private EMoonChasingGuideInBusinessHelper(string value)
		{
			this._Value = value;
		}

		// Token: 0x06040A59 RID: 264793 RVA: 0x00FA5924 File Offset: 0x00FA3B24
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06040A5A RID: 264794 RVA: 0x00FA592C File Offset: 0x00FA3B2C
		public bool Equals(EMoonChasingGuideInBusinessHelper other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06040A5B RID: 264795 RVA: 0x00FA5940 File Offset: 0x00FA3B40
		public override bool Equals(object obj)
		{
			if (obj is EMoonChasingGuideInBusinessHelper)
			{
				EMoonChasingGuideInBusinessHelper other = (EMoonChasingGuideInBusinessHelper)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06040A5C RID: 264796 RVA: 0x00FA5965 File Offset: 0x00FA3B65
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06040A5D RID: 264797 RVA: 0x00FA5978 File Offset: 0x00FA3B78
		public static bool operator ==(EMoonChasingGuideInBusinessHelper left, EMoonChasingGuideInBusinessHelper right)
		{
			return left.Equals(right);
		}

		// Token: 0x06040A5E RID: 264798 RVA: 0x00FA5982 File Offset: 0x00FA3B82
		public static bool operator !=(EMoonChasingGuideInBusinessHelper left, EMoonChasingGuideInBusinessHelper right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040219CB RID: 137675
		private readonly string _Value;

		// Token: 0x040219CC RID: 137676
		public static readonly EMoonChasingGuideInBusinessHelper Helper = new EMoonChasingGuideInBusinessHelper("Helper");

		// Token: 0x040219CD RID: 137677
		public static readonly EMoonChasingGuideInBusinessHelper HelperFirst = new EMoonChasingGuideInBusinessHelper("HelperFirst");

		// Token: 0x040219CE RID: 137678
		public static readonly EMoonChasingGuideInBusinessHelper Interactive = new EMoonChasingGuideInBusinessHelper("Interactive");
	}
}
