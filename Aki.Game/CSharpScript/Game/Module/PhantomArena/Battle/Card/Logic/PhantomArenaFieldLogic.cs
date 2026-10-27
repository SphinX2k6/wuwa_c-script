using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Card.Logic
{
	// Token: 0x020052C2 RID: 21186
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaFieldLogic : PhantomArenaCardLogic
	{
		// Token: 0x0603631D RID: 221981 RVA: 0x00CD21A7 File Offset: 0x00CD03A7
		public PhantomArenaFieldLogic(PhantomArenaCard card, PhantomArenaBattleProxy viewProxy) : base(card, viewProxy)
		{
		}

		// Token: 0x0603631E RID: 221982 RVA: 0x00CD21B1 File Offset: 0x00CD03B1
		public override Tuple<bool, EPhantomCardSettingFailReason> CheckFunctionalSettingCondition(PhantomArenaCard oldCard)
		{
			if (oldCard != null)
			{
				return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.ExistCard);
			}
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(true, EPhantomCardSettingFailReason.None);
		}

		// Token: 0x0603631F RID: 221983 RVA: 0x00CD21CD File Offset: 0x00CD03CD
		public override Tuple<bool, EPhantomCardSettingFailReason> CheckMonsterSettingCondition(PhantomArenaCard oldCard)
		{
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.FieldCantDragToMonster);
		}

		// Token: 0x06036320 RID: 221984 RVA: 0x00CD21DA File Offset: 0x00CD03DA
		protected override Tuple<bool, EPhantomCardSettingFailReason> OnCheckRecycleSettingConditionFromHead()
		{
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.FieldCantDragToRecycle);
		}

		// Token: 0x06036321 RID: 221985 RVA: 0x00CD21E7 File Offset: 0x00CD03E7
		protected override Tuple<bool, EPhantomCardSettingFailReason> OnCheckRecycleSettingConditionFromFunctional()
		{
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.FieldCantDragToRecycle);
		}
	}
}
