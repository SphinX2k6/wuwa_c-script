using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x02006482 RID: 25730
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EMoonChasingGuideInBusinessMain : IEquatable<EMoonChasingGuideInBusinessMain>
	{
		// Token: 0x06040A48 RID: 264776 RVA: 0x00FA57B9 File Offset: 0x00FA39B9
		private EMoonChasingGuideInBusinessMain(string value)
		{
			this._Value = value;
		}

		// Token: 0x06040A49 RID: 264777 RVA: 0x00FA57C2 File Offset: 0x00FA39C2
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06040A4A RID: 264778 RVA: 0x00FA57CA File Offset: 0x00FA39CA
		public bool Equals(EMoonChasingGuideInBusinessMain other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06040A4B RID: 264779 RVA: 0x00FA57E0 File Offset: 0x00FA39E0
		public override bool Equals(object obj)
		{
			if (obj is EMoonChasingGuideInBusinessMain)
			{
				EMoonChasingGuideInBusinessMain other = (EMoonChasingGuideInBusinessMain)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06040A4C RID: 264780 RVA: 0x00FA5805 File Offset: 0x00FA3A05
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06040A4D RID: 264781 RVA: 0x00FA5818 File Offset: 0x00FA3A18
		public static bool operator ==(EMoonChasingGuideInBusinessMain left, EMoonChasingGuideInBusinessMain right)
		{
			return left.Equals(right);
		}

		// Token: 0x06040A4E RID: 264782 RVA: 0x00FA5822 File Offset: 0x00FA3A22
		public static bool operator !=(EMoonChasingGuideInBusinessMain left, EMoonChasingGuideInBusinessMain right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040219BB RID: 137659
		private readonly string _Value;

		// Token: 0x040219BC RID: 137660
		public static readonly EMoonChasingGuideInBusinessMain Delegation = new EMoonChasingGuideInBusinessMain("Delegation");
	}
}
