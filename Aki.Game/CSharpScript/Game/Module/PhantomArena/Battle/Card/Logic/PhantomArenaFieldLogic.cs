using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Card.Logic
{
	// Token: 0x02004292 RID: 17042
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaFieldLogic : PhantomArenaCardLogic
	{
		// Token: 0x0602B218 RID: 176664 RVA: 0x00C1F8CF File Offset: 0x00C1DACF
		public PhantomArenaFieldLogic(PhantomArenaCard card, PhantomArenaBattleProxy viewProxy) : base(card, viewProxy)
		{
		}

		// Token: 0x0602B219 RID: 176665 RVA: 0x00C1F8D9 File Offset: 0x00C1DAD9
		public override Tuple<bool, EPhantomCardSettingFailReason> CheckFunctionalSettingCondition(PhantomArenaCard oldCard)
		{
			if (oldCard != null)
			{
				return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.ExistCard);
			}
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(true, EPhantomCardSettingFailReason.None);
		}

		// Token: 0x0602B21A RID: 176666 RVA: 0x00C1F8F5 File Offset: 0x00C1DAF5
		public override Tuple<bool, EPhantomCardSettingFailReason> CheckMonsterSettingCondition(PhantomArenaCard oldCard)
		{
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.FieldCantDragToMonster);
		}

		// Token: 0x0602B21B RID: 176667 RVA: 0x00C1F902 File Offset: 0x00C1DB02
		protected override Tuple<bool, EPhantomCardSettingFailReason> OnCheckRecycleSettingConditionFromHead()
		{
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.FieldCantDragToRecycle);
		}

		// Token: 0x0602B21C RID: 176668 RVA: 0x00C1F90F File Offset: 0x00C1DB0F
		protected override Tuple<bool, EPhantomCardSettingFailReason> OnCheckRecycleSettingConditionFromFunctional()
		{
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.FieldCantDragToRecycle);
		}
	}
}
