using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056AD RID: 22189
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlBattleAction : IDangoBrawlBattleAction
	{
		// Token: 0x170069C6 RID: 27078
		// (get) Token: 0x06036D09 RID: 224521 RVA: 0x00F4B3FA File Offset: 0x00F495FA
		// (set) Token: 0x06036D0A RID: 224522 RVA: 0x00F4B402 File Offset: 0x00F49602
		public int TimeMs { get; set; }

		// Token: 0x170069C7 RID: 27079
		// (get) Token: 0x06036D0B RID: 224523 RVA: 0x00F4B40B File Offset: 0x00F4960B
		// (set) Token: 0x06036D0C RID: 224524 RVA: 0x00F4B413 File Offset: 0x00F49613
		public int ActionGroupUid { get; set; }

		// Token: 0x170069C8 RID: 27080
		// (get) Token: 0x06036D0D RID: 224525 RVA: 0x00F4B41C File Offset: 0x00F4961C
		// (set) Token: 0x06036D0E RID: 224526 RVA: 0x00F4B424 File Offset: 0x00F49624
		public DangoBrawlFightActionSkillCastInfo SkillCast { get; set; }

		// Token: 0x170069C9 RID: 27081
		// (get) Token: 0x06036D0F RID: 224527 RVA: 0x00F4B42D File Offset: 0x00F4962D
		// (set) Token: 0x06036D10 RID: 224528 RVA: 0x00F4B435 File Offset: 0x00F49635
		public DangoBrawlFightActionFatigueDamageInfo FatigueDamage { get; set; }

		// Token: 0x170069CA RID: 27082
		// (get) Token: 0x06036D11 RID: 224529 RVA: 0x00F4B43E File Offset: 0x00F4963E
		// (set) Token: 0x06036D12 RID: 224530 RVA: 0x00F4B446 File Offset: 0x00F49646
		public DangoBrawlFightActionBuffChangeInfo BuffChange { get; set; }

		// Token: 0x170069CB RID: 27083
		// (get) Token: 0x06036D13 RID: 224531 RVA: 0x00F4B44F File Offset: 0x00F4964F
		// (set) Token: 0x06036D14 RID: 224532 RVA: 0x00F4B457 File Offset: 0x00F49657
		public DangoBrawlFightActionBuffRemoveInfo BuffRemove { get; set; }

		// Token: 0x170069CC RID: 27084
		// (get) Token: 0x06036D15 RID: 224533 RVA: 0x00F4B460 File Offset: 0x00F49660
		// (set) Token: 0x06036D16 RID: 224534 RVA: 0x00F4B468 File Offset: 0x00F49668
		public DangoBrawlFightActionAttrChangeInfo AttrChange { get; set; }

		// Token: 0x170069CD RID: 27085
		// (get) Token: 0x06036D17 RID: 224535 RVA: 0x00F4B471 File Offset: 0x00F49671
		// (set) Token: 0x06036D18 RID: 224536 RVA: 0x00F4B479 File Offset: 0x00F49679
		public DangoBrawlFightActionDeathInfo Death { get; set; }

		// Token: 0x170069CE RID: 27086
		// (get) Token: 0x06036D19 RID: 224537 RVA: 0x00F4B482 File Offset: 0x00F49682
		// (set) Token: 0x06036D1A RID: 224538 RVA: 0x00F4B48A File Offset: 0x00F4968A
		public DangoBrawlFightActionBuffTickInfo BuffTick { get; set; }

		// Token: 0x170069CF RID: 27087
		// (get) Token: 0x06036D1B RID: 224539 RVA: 0x00F4B493 File Offset: 0x00F49693
		// (set) Token: 0x06036D1C RID: 224540 RVA: 0x00F4B49B File Offset: 0x00F4969B
		public DangoBrawlFightActionHealInfo Heal { get; set; }

		// Token: 0x170069D0 RID: 27088
		// (get) Token: 0x06036D1D RID: 224541 RVA: 0x00F4B4A4 File Offset: 0x00F496A4
		// (set) Token: 0x06036D1E RID: 224542 RVA: 0x00F4B4AC File Offset: 0x00F496AC
		public DangoBrawlFightActionReflectDamageInfo ReflectDamage { get; set; }

		// Token: 0x170069D1 RID: 27089
		// (get) Token: 0x06036D1F RID: 224543 RVA: 0x00F4B4B5 File Offset: 0x00F496B5
		// (set) Token: 0x06036D20 RID: 224544 RVA: 0x00F4B4BD File Offset: 0x00F496BD
		public DangoBrawlFightActionWeaponStopInfo WeaponStop { get; set; }

		// Token: 0x170069D2 RID: 27090
		// (get) Token: 0x06036D21 RID: 224545 RVA: 0x00F4B4C6 File Offset: 0x00F496C6
		// (set) Token: 0x06036D22 RID: 224546 RVA: 0x00F4B4CE File Offset: 0x00F496CE
		public DangoBrawlFightActionShieldAddInfo ShieldAdd { get; set; }

		// Token: 0x170069D3 RID: 27091
		// (get) Token: 0x06036D23 RID: 224547 RVA: 0x00F4B4D7 File Offset: 0x00F496D7
		// (set) Token: 0x06036D24 RID: 224548 RVA: 0x00F4B4DF File Offset: 0x00F496DF
		public DangoBrawlFightActionLifestealInfo Lifesteal { get; set; }

		// Token: 0x170069D4 RID: 27092
		// (get) Token: 0x06036D25 RID: 224549 RVA: 0x00F4B4E8 File Offset: 0x00F496E8
		// (set) Token: 0x06036D26 RID: 224550 RVA: 0x00F4B4F0 File Offset: 0x00F496F0
		public DangoBrawlFightActionEffectShowInfo EffectShow { get; set; }

		// Token: 0x170069D5 RID: 27093
		// (get) Token: 0x06036D27 RID: 224551 RVA: 0x00F4B4F9 File Offset: 0x00F496F9
		// (set) Token: 0x06036D28 RID: 224552 RVA: 0x00F4B501 File Offset: 0x00F49701
		public DangoBrawlFightActionInitWeaponCdInfo InitWeaponCd { get; set; }
	}
}
