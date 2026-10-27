using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005088 RID: 20616
	public class IDestructibleItemT
	{
		// Token: 0x170095A9 RID: 38313
		// (get) Token: 0x06021145 RID: 135493 RVA: 0x00498DA5 File Offset: 0x00496FA5
		// (set) Token: 0x06021146 RID: 135494 RVA: 0x00498DAD File Offset: 0x00496FAD
		public bool Disabled { get; set; }

		// Token: 0x170095AA RID: 38314
		// (get) Token: 0x06021147 RID: 135495 RVA: 0x00498DB6 File Offset: 0x00496FB6
		// (set) Token: 0x06021148 RID: 135496 RVA: 0x00498DBE File Offset: 0x00496FBE
		public THitBulletTypeUnion HitBullet { get; set; }

		// Token: 0x170095AB RID: 38315
		// (get) Token: 0x06021149 RID: 135497 RVA: 0x00498DC7 File Offset: 0x00496FC7
		// (set) Token: 0x0602114A RID: 135498 RVA: 0x00498DCF File Offset: 0x00496FCF
		public IHitTimeScaleRatioT AttackerHitTimeScaleRatio { get; set; }

		// Token: 0x170095AC RID: 38316
		// (get) Token: 0x0602114B RID: 135499 RVA: 0x00498DD8 File Offset: 0x00496FD8
		// (set) Token: 0x0602114C RID: 135500 RVA: 0x00498DE0 File Offset: 0x00496FE0
		public IHitTimeScaleRatioT VictimHitTimeScaleRatio { get; set; }

		// Token: 0x170095AD RID: 38317
		// (get) Token: 0x0602114D RID: 135501 RVA: 0x00498DE9 File Offset: 0x00496FE9
		// (set) Token: 0x0602114E RID: 135502 RVA: 0x00498DF1 File Offset: 0x00496FF1
		public List<IAimPartT> AimParts { get; set; }

		// Token: 0x170095AE RID: 38318
		// (get) Token: 0x0602114F RID: 135503 RVA: 0x00498DFA File Offset: 0x00496FFA
		// (set) Token: 0x06021150 RID: 135504 RVA: 0x00498E02 File Offset: 0x00497002
		public int DurabilityId { get; set; }

		// Token: 0x170095AF RID: 38319
		// (get) Token: 0x06021151 RID: 135505 RVA: 0x00498E0B File Offset: 0x0049700B
		// (set) Token: 0x06021152 RID: 135506 RVA: 0x00498E13 File Offset: 0x00497013
		public int Durability { get; set; }

		// Token: 0x170095B0 RID: 38320
		// (get) Token: 0x06021153 RID: 135507 RVA: 0x00498E1C File Offset: 0x0049701C
		// (set) Token: 0x06021154 RID: 135508 RVA: 0x00498E24 File Offset: 0x00497024
		public IDurabilityWornT DurabilityWorn { get; set; }

		// Token: 0x170095B1 RID: 38321
		// (get) Token: 0x06021155 RID: 135509 RVA: 0x00498E2D File Offset: 0x0049702D
		// (set) Token: 0x06021156 RID: 135510 RVA: 0x00498E35 File Offset: 0x00497035
		public IDurabilityStateConfigT DurabilityStateConfig { get; set; }

		// Token: 0x170095B2 RID: 38322
		// (get) Token: 0x06021157 RID: 135511 RVA: 0x00498E3E File Offset: 0x0049703E
		// (set) Token: 0x06021158 RID: 135512 RVA: 0x00498E46 File Offset: 0x00497046
		public IVectorInfoT HitPoint { get; set; }

		// Token: 0x170095B3 RID: 38323
		// (get) Token: 0x06021159 RID: 135513 RVA: 0x00498E4F File Offset: 0x0049704F
		// (set) Token: 0x0602115A RID: 135514 RVA: 0x00498E57 File Offset: 0x00497057
		public List<IActionInfoT> DestructionActions { get; set; }

		// Token: 0x170095B4 RID: 38324
		// (get) Token: 0x0602115B RID: 135515 RVA: 0x00498E60 File Offset: 0x00497060
		// (set) Token: 0x0602115C RID: 135516 RVA: 0x00498E68 File Offset: 0x00497068
		public ISkillDamageT SkillDamage { get; set; }

		// Token: 0x170095B5 RID: 38325
		// (get) Token: 0x0602115D RID: 135517 RVA: 0x00498E71 File Offset: 0x00497071
		// (set) Token: 0x0602115E RID: 135518 RVA: 0x00498E79 File Offset: 0x00497079
		public IElementDamageT ElementDamage { get; set; }

		// Token: 0x170095B6 RID: 38326
		// (get) Token: 0x0602115F RID: 135519 RVA: 0x00498E82 File Offset: 0x00497082
		// (set) Token: 0x06021160 RID: 135520 RVA: 0x00498E8A File Offset: 0x0049708A
		public IWeaponDamageT WeaponDamage { get; set; }

		// Token: 0x170095B7 RID: 38327
		// (get) Token: 0x06021161 RID: 135521 RVA: 0x00498E93 File Offset: 0x00497093
		// (set) Token: 0x06021162 RID: 135522 RVA: 0x00498E9B File Offset: 0x0049709B
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x170095B8 RID: 38328
		// (get) Token: 0x06021163 RID: 135523 RVA: 0x00498EA4 File Offset: 0x004970A4
		// (set) Token: 0x06021164 RID: 135524 RVA: 0x00498EAC File Offset: 0x004970AC
		public byte NullMask { get; set; }

		// Token: 0x06021165 RID: 135525 RVA: 0x00498EB8 File Offset: 0x004970B8
		public IDestructibleItemT()
		{
			this.Disabled = false;
			this.HitBullet = null;
			this.AttackerHitTimeScaleRatio = null;
			this.VictimHitTimeScaleRatio = null;
			this.AimParts = null;
			this.DurabilityId = 0;
			this.Durability = 0;
			this.DurabilityWorn = null;
			this.DurabilityStateConfig = null;
			this.HitPoint = null;
			this.DestructionActions = null;
			this.SkillDamage = null;
			this.ElementDamage = null;
			this.WeaponDamage = null;
			this.MatchRoleOption = null;
			this.NullMask = 0;
		}
	}
}
