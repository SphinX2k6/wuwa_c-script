using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x02005240 RID: 21056
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EPhantomBattleHeadAnim : IEquatable<EPhantomBattleHeadAnim>
	{
		// Token: 0x06035C95 RID: 220309 RVA: 0x00CB9FEC File Offset: 0x00CB81EC
		private EPhantomBattleHeadAnim(string value)
		{
			this._Value = value;
		}

		// Token: 0x06035C96 RID: 220310 RVA: 0x00CB9FF5 File Offset: 0x00CB81F5
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06035C97 RID: 220311 RVA: 0x00CB9FFD File Offset: 0x00CB81FD
		public bool Equals(EPhantomBattleHeadAnim other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06035C98 RID: 220312 RVA: 0x00CBA010 File Offset: 0x00CB8210
		public override bool Equals(object obj)
		{
			if (obj is EPhantomBattleHeadAnim)
			{
				EPhantomBattleHeadAnim other = (EPhantomBattleHeadAnim)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06035C99 RID: 220313 RVA: 0x00CBA035 File Offset: 0x00CB8235
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06035C9A RID: 220314 RVA: 0x00CBA048 File Offset: 0x00CB8248
		public static bool operator ==(EPhantomBattleHeadAnim left, EPhantomBattleHeadAnim right)
		{
			return left.Equals(right);
		}

		// Token: 0x06035C9B RID: 220315 RVA: 0x00CBA052 File Offset: 0x00CB8252
		public static bool operator !=(EPhantomBattleHeadAnim left, EPhantomBattleHeadAnim right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401C84E RID: 116814
		private readonly string _Value;

		// Token: 0x0401C84F RID: 116815
		public static readonly EPhantomBattleHeadAnim FactorMeShow = new EPhantomBattleHeadAnim("LightShowRight");

		// Token: 0x0401C850 RID: 116816
		public static readonly EPhantomBattleHeadAnim FactorOtherShow = new EPhantomBattleHeadAnim("LightShowLeft");

		// Token: 0x0401C851 RID: 116817
		public static readonly EPhantomBattleHeadAnim DamageAccumulate = new EPhantomBattleHeadAnim("DamageAccumulate");

		// Token: 0x0401C852 RID: 116818
		public static readonly EPhantomBattleHeadAnim Damage = new EPhantomBattleHeadAnim("Damage");

		// Token: 0x0401C853 RID: 116819
		public static readonly EPhantomBattleHeadAnim DamageNPC = new EPhantomBattleHeadAnim("DamageNPC");

		// Token: 0x0401C854 RID: 116820
		public static readonly EPhantomBattleHeadAnim Kill = new EPhantomBattleHeadAnim("Kill");

		// Token: 0x0401C855 RID: 116821
		public static readonly EPhantomBattleHeadAnim Hit = new EPhantomBattleHeadAnim("Hit");
	}
}
