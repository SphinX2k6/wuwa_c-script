using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x02005401 RID: 21505
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EMoonChasingGuideInDelegation : IEquatable<EMoonChasingGuideInDelegation>
	{
		// Token: 0x06035714 RID: 218900 RVA: 0x00EEC888 File Offset: 0x00EEAA88
		private EMoonChasingGuideInDelegation(string value)
		{
			this._Value = value;
		}

		// Token: 0x06035715 RID: 218901 RVA: 0x00EEC891 File Offset: 0x00EEAA91
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06035716 RID: 218902 RVA: 0x00EEC899 File Offset: 0x00EEAA99
		public bool Equals(EMoonChasingGuideInDelegation other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06035717 RID: 218903 RVA: 0x00EEC8AC File Offset: 0x00EEAAAC
		public override bool Equals(object obj)
		{
			if (obj is EMoonChasingGuideInDelegation)
			{
				EMoonChasingGuideInDelegation other = (EMoonChasingGuideInDelegation)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06035718 RID: 218904 RVA: 0x00EEC8D1 File Offset: 0x00EEAAD1
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06035719 RID: 218905 RVA: 0x00EEC8E4 File Offset: 0x00EEAAE4
		public static bool operator ==(EMoonChasingGuideInDelegation left, EMoonChasingGuideInDelegation right)
		{
			return left.Equals(right);
		}

		// Token: 0x0603571A RID: 218906 RVA: 0x00EEC8EE File Offset: 0x00EEAAEE
		public static bool operator !=(EMoonChasingGuideInDelegation left, EMoonChasingGuideInDelegation right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401C2EE RID: 115438
		private readonly string _Value;

		// Token: 0x0401C2EF RID: 115439
		public static readonly EMoonChasingGuideInDelegation Role = new EMoonChasingGuideInDelegation("0");

		// Token: 0x0401C2F0 RID: 115440
		public static readonly EMoonChasingGuideInDelegation Confirm = new EMoonChasingGuideInDelegation("1");

		// Token: 0x0401C2F1 RID: 115441
		public static readonly EMoonChasingGuideInDelegation RoleItem = new EMoonChasingGuideInDelegation("2");

		// Token: 0x0401C2F2 RID: 115442
		public static readonly EMoonChasingGuideInDelegation Recommend = new EMoonChasingGuideInDelegation("3");

		// Token: 0x0401C2F3 RID: 115443
		public static readonly EMoonChasingGuideInDelegation TeamAttr = new EMoonChasingGuideInDelegation("4");

		// Token: 0x0401C2F4 RID: 115444
		public static readonly EMoonChasingGuideInDelegation EditTeam = new EMoonChasingGuideInDelegation("EditTeam");
	}
}
