using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005107 RID: 20743
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EPhantomCardSettingFailReason : IEquatable<EPhantomCardSettingFailReason>
	{
		// Token: 0x0603512C RID: 217388 RVA: 0x00C93E24 File Offset: 0x00C92024
		private EPhantomCardSettingFailReason(string value)
		{
			this._Value = value;
		}

		// Token: 0x0603512D RID: 217389 RVA: 0x00C93E2D File Offset: 0x00C9202D
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0603512E RID: 217390 RVA: 0x00C93E35 File Offset: 0x00C92035
		public bool Equals(EPhantomCardSettingFailReason other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x0603512F RID: 217391 RVA: 0x00C93E48 File Offset: 0x00C92048
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

		// Token: 0x06035130 RID: 217392 RVA: 0x00C93E6D File Offset: 0x00C9206D
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06035131 RID: 217393 RVA: 0x00C93E80 File Offset: 0x00C92080
		public static bool operator ==(EPhantomCardSettingFailReason left, EPhantomCardSettingFailReason right)
		{
			return left.Equals(right);
		}

		// Token: 0x06035132 RID: 217394 RVA: 0x00C93E8A File Offset: 0x00C9208A
		public static bool operator !=(EPhantomCardSettingFailReason left, EPhantomCardSettingFailReason right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401C3F7 RID: 115703
		private readonly string _Value;

		// Token: 0x0401C3F8 RID: 115704
		public static readonly EPhantomCardSettingFailReason None = new EPhantomCardSettingFailReason("");

		// Token: 0x0401C3F9 RID: 115705
		public static readonly EPhantomCardSettingFailReason CardLock = new EPhantomCardSettingFailReason("");

		// Token: 0x0401C3FA RID: 115706
		public static readonly EPhantomCardSettingFailReason CantDragToRecycle = new EPhantomCardSettingFailReason("PhantomBattle_1047");

		// Token: 0x0401C3FB RID: 115707
		public static readonly EPhantomCardSettingFailReason SettingLimit = new EPhantomCardSettingFailReason("PhantomBattle_1048");

		// Token: 0x0401C3FC RID: 115708
		public static readonly EPhantomCardSettingFailReason EvolveNumLimit = new EPhantomCardSettingFailReason("PhantomBattle_1049");

		// Token: 0x0401C3FD RID: 115709
		public static readonly EPhantomCardSettingFailReason EvolveOneCostLimit = new EPhantomCardSettingFailReason("PhantomBattle_1050");

		// Token: 0x0401C3FE RID: 115710
		public static readonly EPhantomCardSettingFailReason NotEnoughCost = new EPhantomCardSettingFailReason("PhantomBattle_1051");

		// Token: 0x0401C3FF RID: 115711
		public static readonly EPhantomCardSettingFailReason EvolveThreeCostLimit = new EPhantomCardSettingFailReason("PhantomBattle_1062");

		// Token: 0x0401C400 RID: 115712
		public static readonly EPhantomCardSettingFailReason NotHasActiveSkill = new EPhantomCardSettingFailReason("PhantomBattle_1064");

		// Token: 0x0401C401 RID: 115713
		public static readonly EPhantomCardSettingFailReason FourCostCantEvolve = new EPhantomCardSettingFailReason("PhantomBattle_1126");

		// Token: 0x0401C402 RID: 115714
		public static readonly EPhantomCardSettingFailReason FourCostCantBeEvolved = new EPhantomCardSettingFailReason("PhantomBattle_1127");

		// Token: 0x0401C403 RID: 115715
		public static readonly EPhantomCardSettingFailReason OneCostCantEvolveOther = new EPhantomCardSettingFailReason("PhantomBattle_1130");

		// Token: 0x0401C404 RID: 115716
		public static readonly EPhantomCardSettingFailReason ThreeCostCantEvolveOther = new EPhantomCardSettingFailReason("PhantomBattle_1128");

		// Token: 0x0401C405 RID: 115717
		public static readonly EPhantomCardSettingFailReason CantDragMonsterToFunctional = new EPhantomCardSettingFailReason("PhantomBattle_1065");

		// Token: 0x0401C406 RID: 115718
		public static readonly EPhantomCardSettingFailReason CantDragMonsterByThreeCost = new EPhantomCardSettingFailReason("PhantomBattle_1066");

		// Token: 0x0401C407 RID: 115719
		public static readonly EPhantomCardSettingFailReason ExistCard = new EPhantomCardSettingFailReason("");

		// Token: 0x0401C408 RID: 115720
		public static readonly EPhantomCardSettingFailReason FieldCantDragToMonster = new EPhantomCardSettingFailReason("PhantomBattle_1134");

		// Token: 0x0401C409 RID: 115721
		public static readonly EPhantomCardSettingFailReason FieldCantDragToRecycle = new EPhantomCardSettingFailReason("PhantomBattle_1135");

		// Token: 0x0401C40A RID: 115722
		public static readonly EPhantomCardSettingFailReason ToolCantDragToFunctional = new EPhantomCardSettingFailReason("PhantomBattle_1180");

		// Token: 0x0401C40B RID: 115723
		public static readonly EPhantomCardSettingFailReason ToolCantEvolve = new EPhantomCardSettingFailReason("PhantomBattle_1181");

		// Token: 0x0401C40C RID: 115724
		public static readonly EPhantomCardSettingFailReason WaitBattleSlotIndex = new EPhantomCardSettingFailReason("");
	}
}
