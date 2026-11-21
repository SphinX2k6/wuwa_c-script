using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056AC RID: 22188
	[NullableContext(2)]
	public interface IDangoBrawlBattleAction
	{
		// Token: 0x170069B6 RID: 27062
		// (get) Token: 0x06036CE9 RID: 224489
		// (set) Token: 0x06036CEA RID: 224490
		int TimeMs { get; set; }

		// Token: 0x170069B7 RID: 27063
		// (get) Token: 0x06036CEB RID: 224491
		// (set) Token: 0x06036CEC RID: 224492
		int ActionGroupUid { get; set; }

		// Token: 0x170069B8 RID: 27064
		// (get) Token: 0x06036CED RID: 224493
		// (set) Token: 0x06036CEE RID: 224494
		DangoBrawlFightActionSkillCastInfo SkillCast { get; set; }

		// Token: 0x170069B9 RID: 27065
		// (get) Token: 0x06036CEF RID: 224495
		// (set) Token: 0x06036CF0 RID: 224496
		DangoBrawlFightActionFatigueDamageInfo FatigueDamage { get; set; }

		// Token: 0x170069BA RID: 27066
		// (get) Token: 0x06036CF1 RID: 224497
		// (set) Token: 0x06036CF2 RID: 224498
		DangoBrawlFightActionBuffChangeInfo BuffChange { get; set; }

		// Token: 0x170069BB RID: 27067
		// (get) Token: 0x06036CF3 RID: 224499
		// (set) Token: 0x06036CF4 RID: 224500
		DangoBrawlFightActionBuffRemoveInfo BuffRemove { get; set; }

		// Token: 0x170069BC RID: 27068
		// (get) Token: 0x06036CF5 RID: 224501
		// (set) Token: 0x06036CF6 RID: 224502
		DangoBrawlFightActionAttrChangeInfo AttrChange { get; set; }

		// Token: 0x170069BD RID: 27069
		// (get) Token: 0x06036CF7 RID: 224503
		// (set) Token: 0x06036CF8 RID: 224504
		DangoBrawlFightActionDeathInfo Death { get; set; }

		// Token: 0x170069BE RID: 27070
		// (get) Token: 0x06036CF9 RID: 224505
		// (set) Token: 0x06036CFA RID: 224506
		DangoBrawlFightActionBuffTickInfo BuffTick { get; set; }

		// Token: 0x170069BF RID: 27071
		// (get) Token: 0x06036CFB RID: 224507
		// (set) Token: 0x06036CFC RID: 224508
		DangoBrawlFightActionHealInfo Heal { get; set; }

		// Token: 0x170069C0 RID: 27072
		// (get) Token: 0x06036CFD RID: 224509
		// (set) Token: 0x06036CFE RID: 224510
		DangoBrawlFightActionReflectDamageInfo ReflectDamage { get; set; }

		// Token: 0x170069C1 RID: 27073
		// (get) Token: 0x06036CFF RID: 224511
		// (set) Token: 0x06036D00 RID: 224512
		DangoBrawlFightActionWeaponStopInfo WeaponStop { get; set; }

		// Token: 0x170069C2 RID: 27074
		// (get) Token: 0x06036D01 RID: 224513
		// (set) Token: 0x06036D02 RID: 224514
		DangoBrawlFightActionShieldAddInfo ShieldAdd { get; set; }

		// Token: 0x170069C3 RID: 27075
		// (get) Token: 0x06036D03 RID: 224515
		// (set) Token: 0x06036D04 RID: 224516
		DangoBrawlFightActionLifestealInfo Lifesteal { get; set; }

		// Token: 0x170069C4 RID: 27076
		// (get) Token: 0x06036D05 RID: 224517
		// (set) Token: 0x06036D06 RID: 224518
		DangoBrawlFightActionEffectShowInfo EffectShow { get; set; }

		// Token: 0x170069C5 RID: 27077
		// (get) Token: 0x06036D07 RID: 224519
		// (set) Token: 0x06036D08 RID: 224520
		DangoBrawlFightActionInitWeaponCdInfo InitWeaponCd { get; set; }
	}
}
