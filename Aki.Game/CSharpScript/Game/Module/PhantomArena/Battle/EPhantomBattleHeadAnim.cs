using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x02004210 RID: 16912
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EPhantomBattleHeadAnim : IEquatable<EPhantomBattleHeadAnim>
	{
		// Token: 0x0602AB90 RID: 174992 RVA: 0x00C0762C File Offset: 0x00C0582C
		private EPhantomBattleHeadAnim(string value)
		{
			this._Value = value;
		}

		// Token: 0x0602AB91 RID: 174993 RVA: 0x00C07635 File Offset: 0x00C05835
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0602AB92 RID: 174994 RVA: 0x00C0763D File Offset: 0x00C0583D
		public bool Equals(EPhantomBattleHeadAnim other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x0602AB93 RID: 174995 RVA: 0x00C07650 File Offset: 0x00C05850
		public override bool Equals(object obj)
		{
			if (obj is EPhantomBattleHeadAnim)
			{
				EPhantomBattleHeadAnim other = (EPhantomBattleHeadAnim)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602AB94 RID: 174996 RVA: 0x00C07675 File Offset: 0x00C05875
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0602AB95 RID: 174997 RVA: 0x00C07688 File Offset: 0x00C05888
		public static bool operator ==(EPhantomBattleHeadAnim left, EPhantomBattleHeadAnim right)
		{
			return left.Equals(right);
		}

		// Token: 0x0602AB96 RID: 174998 RVA: 0x00C07692 File Offset: 0x00C05892
		public static bool operator !=(EPhantomBattleHeadAnim left, EPhantomBattleHeadAnim right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04017283 RID: 94851
		private readonly string _Value;

		// Token: 0x04017284 RID: 94852
		public static readonly EPhantomBattleHeadAnim FactorMeShow = new EPhantomBattleHeadAnim("LightShowRight");

		// Token: 0x04017285 RID: 94853
		public static readonly EPhantomBattleHeadAnim FactorOtherShow = new EPhantomBattleHeadAnim("LightShowLeft");

		// Token: 0x04017286 RID: 94854
		public static readonly EPhantomBattleHeadAnim DamageAccumulate = new EPhantomBattleHeadAnim("DamageAccumulate");

		// Token: 0x04017287 RID: 94855
		public static readonly EPhantomBattleHeadAnim Damage = new EPhantomBattleHeadAnim("Damage");

		// Token: 0x04017288 RID: 94856
		public static readonly EPhantomBattleHeadAnim DamageNPC = new EPhantomBattleHeadAnim("DamageNPC");

		// Token: 0x04017289 RID: 94857
		public static readonly EPhantomBattleHeadAnim Kill = new EPhantomBattleHeadAnim("Kill");

		// Token: 0x0401728A RID: 94858
		public static readonly EPhantomBattleHeadAnim Hit = new EPhantomBattleHeadAnim("Hit");
	}
}
