using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200675D RID: 26461
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlBattleAction : IDangoBrawlBattleAction
	{
		// Token: 0x17009685 RID: 38533
		// (get) Token: 0x060421B3 RID: 270771 RVA: 0x0100A016 File Offset: 0x01008216
		// (set) Token: 0x060421B4 RID: 270772 RVA: 0x0100A01E File Offset: 0x0100821E
		public int TimeMs { get; set; }

		// Token: 0x17009686 RID: 38534
		// (get) Token: 0x060421B5 RID: 270773 RVA: 0x0100A027 File Offset: 0x01008227
		// (set) Token: 0x060421B6 RID: 270774 RVA: 0x0100A02F File Offset: 0x0100822F
		public int ActionGroupUid { get; set; }

		// Token: 0x17009687 RID: 38535
		// (get) Token: 0x060421B7 RID: 270775 RVA: 0x0100A038 File Offset: 0x01008238
		// (set) Token: 0x060421B8 RID: 270776 RVA: 0x0100A040 File Offset: 0x01008240
		public DangoBrawlFightActionSkillCastInfo SkillCast { get; set; }

		// Token: 0x17009688 RID: 38536
		// (get) Token: 0x060421B9 RID: 270777 RVA: 0x0100A049 File Offset: 0x01008249
		// (set) Token: 0x060421BA RID: 270778 RVA: 0x0100A051 File Offset: 0x01008251
		public DangoBrawlFightActionFatigueDamageInfo FatigueDamage { get; set; }

		// Token: 0x17009689 RID: 38537
		// (get) Token: 0x060421BB RID: 270779 RVA: 0x0100A05A File Offset: 0x0100825A
		// (set) Token: 0x060421BC RID: 270780 RVA: 0x0100A062 File Offset: 0x01008262
		public DangoBrawlFightActionBuffChangeInfo BuffChange { get; set; }

		// Token: 0x1700968A RID: 38538
		// (get) Token: 0x060421BD RID: 270781 RVA: 0x0100A06B File Offset: 0x0100826B
		// (set) Token: 0x060421BE RID: 270782 RVA: 0x0100A073 File Offset: 0x01008273
		public DangoBrawlFightActionBuffRemoveInfo BuffRemove { get; set; }

		// Token: 0x1700968B RID: 38539
		// (get) Token: 0x060421BF RID: 270783 RVA: 0x0100A07C File Offset: 0x0100827C
		// (set) Token: 0x060421C0 RID: 270784 RVA: 0x0100A084 File Offset: 0x01008284
		public DangoBrawlFightActionAttrChangeInfo AttrChange { get; set; }

		// Token: 0x1700968C RID: 38540
		// (get) Token: 0x060421C1 RID: 270785 RVA: 0x0100A08D File Offset: 0x0100828D
		// (set) Token: 0x060421C2 RID: 270786 RVA: 0x0100A095 File Offset: 0x01008295
		public DangoBrawlFightActionDeathInfo Death { get; set; }

		// Token: 0x1700968D RID: 38541
		// (get) Token: 0x060421C3 RID: 270787 RVA: 0x0100A09E File Offset: 0x0100829E
		// (set) Token: 0x060421C4 RID: 270788 RVA: 0x0100A0A6 File Offset: 0x010082A6
		public DangoBrawlFightActionBuffTickInfo BuffTick { get; set; }

		// Token: 0x1700968E RID: 38542
		// (get) Token: 0x060421C5 RID: 270789 RVA: 0x0100A0AF File Offset: 0x010082AF
		// (set) Token: 0x060421C6 RID: 270790 RVA: 0x0100A0B7 File Offset: 0x010082B7
		public DangoBrawlFightActionHealInfo Heal { get; set; }

		// Token: 0x1700968F RID: 38543
		// (get) Token: 0x060421C7 RID: 270791 RVA: 0x0100A0C0 File Offset: 0x010082C0
		// (set) Token: 0x060421C8 RID: 270792 RVA: 0x0100A0C8 File Offset: 0x010082C8
		public DangoBrawlFightActionReflectDamageInfo ReflectDamage { get; set; }

		// Token: 0x17009690 RID: 38544
		// (get) Token: 0x060421C9 RID: 270793 RVA: 0x0100A0D1 File Offset: 0x010082D1
		// (set) Token: 0x060421CA RID: 270794 RVA: 0x0100A0D9 File Offset: 0x010082D9
		public DangoBrawlFightActionWeaponStopInfo WeaponStop { get; set; }

		// Token: 0x17009691 RID: 38545
		// (get) Token: 0x060421CB RID: 270795 RVA: 0x0100A0E2 File Offset: 0x010082E2
		// (set) Token: 0x060421CC RID: 270796 RVA: 0x0100A0EA File Offset: 0x010082EA
		public DangoBrawlFightActionShieldAddInfo ShieldAdd { get; set; }

		// Token: 0x17009692 RID: 38546
		// (get) Token: 0x060421CD RID: 270797 RVA: 0x0100A0F3 File Offset: 0x010082F3
		// (set) Token: 0x060421CE RID: 270798 RVA: 0x0100A0FB File Offset: 0x010082FB
		public DangoBrawlFightActionLifestealInfo Lifesteal { get; set; }

		// Token: 0x17009693 RID: 38547
		// (get) Token: 0x060421CF RID: 270799 RVA: 0x0100A104 File Offset: 0x01008304
		// (set) Token: 0x060421D0 RID: 270800 RVA: 0x0100A10C File Offset: 0x0100830C
		public DangoBrawlFightActionEffectShowInfo EffectShow { get; set; }

		// Token: 0x17009694 RID: 38548
		// (get) Token: 0x060421D1 RID: 270801 RVA: 0x0100A115 File Offset: 0x01008315
		// (set) Token: 0x060421D2 RID: 270802 RVA: 0x0100A11D File Offset: 0x0100831D
		public DangoBrawlFightActionInitWeaponCdInfo InitWeaponCd { get; set; }
	}
}
