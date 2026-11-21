using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040D7 RID: 16599
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EPhantomCardSettingFailReason : IEquatable<EPhantomCardSettingFailReason>
	{
		// Token: 0x0602A025 RID: 172069 RVA: 0x00BE1238 File Offset: 0x00BDF438
		private EPhantomCardSettingFailReason(string value)
		{
			this._Value = value;
		}

		// Token: 0x0602A026 RID: 172070 RVA: 0x00BE1241 File Offset: 0x00BDF441
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0602A027 RID: 172071 RVA: 0x00BE1249 File Offset: 0x00BDF449
		public bool Equals(EPhantomCardSettingFailReason other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x0602A028 RID: 172072 RVA: 0x00BE125C File Offset: 0x00BDF45C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is EPhantomCardSettingFailReason)
			{
				EPhantomCardSettingFailReason other = (EPhantomCardSettingFailReason)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602A029 RID: 172073 RVA: 0x00BE1281 File Offset: 0x00BDF481
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0602A02A RID: 172074 RVA: 0x00BE1294 File Offset: 0x00BDF494
		public static bool operator ==(EPhantomCardSettingFailReason left, EPhantomCardSettingFailReason right)
		{
			return left.Equals(right);
		}

		// Token: 0x0602A02B RID: 172075 RVA: 0x00BE129E File Offset: 0x00BDF49E
		public static bool operator !=(EPhantomCardSettingFailReason left, EPhantomCardSettingFailReason right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04016E2C RID: 93740
		private readonly string _Value;

		// Token: 0x04016E2D RID: 93741
		public static readonly EPhantomCardSettingFailReason None = new EPhantomCardSettingFailReason("");

		// Token: 0x04016E2E RID: 93742
		public static readonly EPhantomCardSettingFailReason CardLock = new EPhantomCardSettingFailReason("");

		// Token: 0x04016E2F RID: 93743
		public static readonly EPhantomCardSettingFailReason CantDragToRecycle = new EPhantomCardSettingFailReason("PhantomBattle_1047");

		// Token: 0x04016E30 RID: 93744
		public static readonly EPhantomCardSettingFailReason SettingLimit = new EPhantomCardSettingFailReason("PhantomBattle_1048");

		// Token: 0x04016E31 RID: 93745
		public static readonly EPhantomCardSettingFailReason EvolveNumLimit = new EPhantomCardSettingFailReason("PhantomBattle_1049");

		// Token: 0x04016E32 RID: 93746
		public static readonly EPhantomCardSettingFailReason EvolveOneCostLimit = new EPhantomCardSettingFailReason("PhantomBattle_1050");

		// Token: 0x04016E33 RID: 93747
		public static readonly EPhantomCardSettingFailReason NotEnoughCost = new EPhantomCardSettingFailReason("PhantomBattle_1051");

		// Token: 0x04016E34 RID: 93748
		public static readonly EPhantomCardSettingFailReason EvolveThreeCostLimit = new EPhantomCardSettingFailReason("PhantomBattle_1062");

		// Token: 0x04016E35 RID: 93749
		public static readonly EPhantomCardSettingFailReason NotHasActiveSkill = new EPhantomCardSettingFailReason("PhantomBattle_1064");

		// Token: 0x04016E36 RID: 93750
		public static readonly EPhantomCardSettingFailReason FourCostCantEvolve = new EPhantomCardSettingFailReason("PhantomBattle_1126");

		// Token: 0x04016E37 RID: 93751
		public static readonly EPhantomCardSettingFailReason FourCostCantBeEvolved = new EPhantomCardSettingFailReason("PhantomBattle_1127");

		// Token: 0x04016E38 RID: 93752
		public static readonly EPhantomCardSettingFailReason OneCostCantEvolveOther = new EPhantomCardSettingFailReason("PhantomBattle_1130");

		// Token: 0x04016E39 RID: 93753
		public static readonly EPhantomCardSettingFailReason ThreeCostCantEvolveOther = new EPhantomCardSettingFailReason("PhantomBattle_1128");

		// Token: 0x04016E3A RID: 93754
		public static readonly EPhantomCardSettingFailReason CantDragMonsterToFunctional = new EPhantomCardSettingFailReason("PhantomBattle_1065");

		// Token: 0x04016E3B RID: 93755
		public static readonly EPhantomCardSettingFailReason CantDragMonsterByThreeCost = new EPhantomCardSettingFailReason("PhantomBattle_1066");

		// Token: 0x04016E3C RID: 93756
		public static readonly EPhantomCardSettingFailReason ExistCard = new EPhantomCardSettingFailReason("");

		// Token: 0x04016E3D RID: 93757
		public static readonly EPhantomCardSettingFailReason FieldCantDragToMonster = new EPhantomCardSettingFailReason("PhantomBattle_1134");

		// Token: 0x04016E3E RID: 93758
		public static readonly EPhantomCardSettingFailReason FieldCantDragToRecycle = new EPhantomCardSettingFailReason("PhantomBattle_1135");

		// Token: 0x04016E3F RID: 93759
		public static readonly EPhantomCardSettingFailReason ToolCantDragToFunctional = new EPhantomCardSettingFailReason("PhantomBattle_1180");

		// Token: 0x04016E40 RID: 93760
		public static readonly EPhantomCardSettingFailReason ToolCantEvolve = new EPhantomCardSettingFailReason("PhantomBattle_1181");

		// Token: 0x04016E41 RID: 93761
		public static readonly EPhantomCardSettingFailReason WaitBattleSlotIndex = new EPhantomCardSettingFailReason("");
	}
}
