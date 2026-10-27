using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x02006483 RID: 25731
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EMoonChasingGuideInDelegation : IEquatable<EMoonChasingGuideInDelegation>
	{
		// Token: 0x06040A50 RID: 264784 RVA: 0x00FA5840 File Offset: 0x00FA3A40
		private EMoonChasingGuideInDelegation(string value)
		{
			this._Value = value;
		}

		// Token: 0x06040A51 RID: 264785 RVA: 0x00FA5849 File Offset: 0x00FA3A49
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06040A52 RID: 264786 RVA: 0x00FA5851 File Offset: 0x00FA3A51
		public bool Equals(EMoonChasingGuideInDelegation other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06040A53 RID: 264787 RVA: 0x00FA5864 File Offset: 0x00FA3A64
		public override bool Equals(object obj)
		{
			if (obj is EMoonChasingGuideInDelegation)
			{
				EMoonChasingGuideInDelegation other = (EMoonChasingGuideInDelegation)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06040A54 RID: 264788 RVA: 0x00FA5889 File Offset: 0x00FA3A89
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06040A55 RID: 264789 RVA: 0x00FA589C File Offset: 0x00FA3A9C
		public static bool operator ==(EMoonChasingGuideInDelegation left, EMoonChasingGuideInDelegation right)
		{
			return left.Equals(right);
		}

		// Token: 0x06040A56 RID: 264790 RVA: 0x00FA58A6 File Offset: 0x00FA3AA6
		public static bool operator !=(EMoonChasingGuideInDelegation left, EMoonChasingGuideInDelegation right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040219BD RID: 137661
		private readonly string _Value;

		// Token: 0x040219BE RID: 137662
		public static readonly EMoonChasingGuideInDelegation Role = new EMoonChasingGuideInDelegation("0");

		// Token: 0x040219BF RID: 137663
		public static readonly EMoonChasingGuideInDelegation Confirm = new EMoonChasingGuideInDelegation("1");

		// Token: 0x040219C0 RID: 137664
		public static readonly EMoonChasingGuideInDelegation RoleItem = new EMoonChasingGuideInDelegation("2");

		// Token: 0x040219C1 RID: 137665
		public static readonly EMoonChasingGuideInDelegation Recommend = new EMoonChasingGuideInDelegation("3");

		// Token: 0x040219C2 RID: 137666
		public static readonly EMoonChasingGuideInDelegation TeamAttr = new EMoonChasingGuideInDelegation("4");

		// Token: 0x040219C3 RID: 137667
		public static readonly EMoonChasingGuideInDelegation EditTeam = new EMoonChasingGuideInDelegation("EditTeam");
	}
}
