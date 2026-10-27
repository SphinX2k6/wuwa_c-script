using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200675C RID: 26460
	[NullableContext(2)]
	public interface IDangoBrawlBattleAction
	{
		// Token: 0x17009675 RID: 38517
		// (get) Token: 0x06042193 RID: 270739
		// (set) Token: 0x06042194 RID: 270740
		int TimeMs { get; set; }

		// Token: 0x17009676 RID: 38518
		// (get) Token: 0x06042195 RID: 270741
		// (set) Token: 0x06042196 RID: 270742
		int ActionGroupUid { get; set; }

		// Token: 0x17009677 RID: 38519
		// (get) Token: 0x06042197 RID: 270743
		// (set) Token: 0x06042198 RID: 270744
		DangoBrawlFightActionSkillCastInfo SkillCast { get; set; }

		// Token: 0x17009678 RID: 38520
		// (get) Token: 0x06042199 RID: 270745
		// (set) Token: 0x0604219A RID: 270746
		DangoBrawlFightActionFatigueDamageInfo FatigueDamage { get; set; }

		// Token: 0x17009679 RID: 38521
		// (get) Token: 0x0604219B RID: 270747
		// (set) Token: 0x0604219C RID: 270748
		DangoBrawlFightActionBuffChangeInfo BuffChange { get; set; }

		// Token: 0x1700967A RID: 38522
		// (get) Token: 0x0604219D RID: 270749
		// (set) Token: 0x0604219E RID: 270750
		DangoBrawlFightActionBuffRemoveInfo BuffRemove { get; set; }

		// Token: 0x1700967B RID: 38523
		// (get) Token: 0x0604219F RID: 270751
		// (set) Token: 0x060421A0 RID: 270752
		DangoBrawlFightActionAttrChangeInfo AttrChange { get; set; }

		// Token: 0x1700967C RID: 38524
		// (get) Token: 0x060421A1 RID: 270753
		// (set) Token: 0x060421A2 RID: 270754
		DangoBrawlFightActionDeathInfo Death { get; set; }

		// Token: 0x1700967D RID: 38525
		// (get) Token: 0x060421A3 RID: 270755
		// (set) Token: 0x060421A4 RID: 270756
		DangoBrawlFightActionBuffTickInfo BuffTick { get; set; }

		// Token: 0x1700967E RID: 38526
		// (get) Token: 0x060421A5 RID: 270757
		// (set) Token: 0x060421A6 RID: 270758
		DangoBrawlFightActionHealInfo Heal { get; set; }

		// Token: 0x1700967F RID: 38527
		// (get) Token: 0x060421A7 RID: 270759
		// (set) Token: 0x060421A8 RID: 270760
		DangoBrawlFightActionReflectDamageInfo ReflectDamage { get; set; }

		// Token: 0x17009680 RID: 38528
		// (get) Token: 0x060421A9 RID: 270761
		// (set) Token: 0x060421AA RID: 270762
		DangoBrawlFightActionWeaponStopInfo WeaponStop { get; set; }

		// Token: 0x17009681 RID: 38529
		// (get) Token: 0x060421AB RID: 270763
		// (set) Token: 0x060421AC RID: 270764
		DangoBrawlFightActionShieldAddInfo ShieldAdd { get; set; }

		// Token: 0x17009682 RID: 38530
		// (get) Token: 0x060421AD RID: 270765
		// (set) Token: 0x060421AE RID: 270766
		DangoBrawlFightActionLifestealInfo Lifesteal { get; set; }

		// Token: 0x17009683 RID: 38531
		// (get) Token: 0x060421AF RID: 270767
		// (set) Token: 0x060421B0 RID: 270768
		DangoBrawlFightActionEffectShowInfo EffectShow { get; set; }

		// Token: 0x17009684 RID: 38532
		// (get) Token: 0x060421B1 RID: 270769
		// (set) Token: 0x060421B2 RID: 270770
		DangoBrawlFightActionInitWeaponCdInfo InitWeaponCd { get; set; }
	}
}
