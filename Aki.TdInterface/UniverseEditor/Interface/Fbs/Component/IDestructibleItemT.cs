using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055ED RID: 21997
	public class IDestructibleItemT
	{
		// Token: 0x17009D96 RID: 40342
		// (get) Token: 0x06023099 RID: 143513 RVA: 0x004D2D31 File Offset: 0x004D0F31
		// (set) Token: 0x0602309A RID: 143514 RVA: 0x004D2D39 File Offset: 0x004D0F39
		public bool Disabled { get; set; }

		// Token: 0x17009D97 RID: 40343
		// (get) Token: 0x0602309B RID: 143515 RVA: 0x004D2D42 File Offset: 0x004D0F42
		// (set) Token: 0x0602309C RID: 143516 RVA: 0x004D2D4A File Offset: 0x004D0F4A
		public THitBulletTypeUnion HitBullet { get; set; }

		// Token: 0x17009D98 RID: 40344
		// (get) Token: 0x0602309D RID: 143517 RVA: 0x004D2D53 File Offset: 0x004D0F53
		// (set) Token: 0x0602309E RID: 143518 RVA: 0x004D2D5B File Offset: 0x004D0F5B
		public IHitTimeScaleRatioT AttackerHitTimeScaleRatio { get; set; }

		// Token: 0x17009D99 RID: 40345
		// (get) Token: 0x0602309F RID: 143519 RVA: 0x004D2D64 File Offset: 0x004D0F64
		// (set) Token: 0x060230A0 RID: 143520 RVA: 0x004D2D6C File Offset: 0x004D0F6C
		public IHitTimeScaleRatioT VictimHitTimeScaleRatio { get; set; }

		// Token: 0x17009D9A RID: 40346
		// (get) Token: 0x060230A1 RID: 143521 RVA: 0x004D2D75 File Offset: 0x004D0F75
		// (set) Token: 0x060230A2 RID: 143522 RVA: 0x004D2D7D File Offset: 0x004D0F7D
		public List<IAimPartT> AimParts { get; set; }

		// Token: 0x17009D9B RID: 40347
		// (get) Token: 0x060230A3 RID: 143523 RVA: 0x004D2D86 File Offset: 0x004D0F86
		// (set) Token: 0x060230A4 RID: 143524 RVA: 0x004D2D8E File Offset: 0x004D0F8E
		public int DurabilityId { get; set; }

		// Token: 0x17009D9C RID: 40348
		// (get) Token: 0x060230A5 RID: 143525 RVA: 0x004D2D97 File Offset: 0x004D0F97
		// (set) Token: 0x060230A6 RID: 143526 RVA: 0x004D2D9F File Offset: 0x004D0F9F
		public int Durability { get; set; }

		// Token: 0x17009D9D RID: 40349
		// (get) Token: 0x060230A7 RID: 143527 RVA: 0x004D2DA8 File Offset: 0x004D0FA8
		// (set) Token: 0x060230A8 RID: 143528 RVA: 0x004D2DB0 File Offset: 0x004D0FB0
		public IDurabilityWornT DurabilityWorn { get; set; }

		// Token: 0x17009D9E RID: 40350
		// (get) Token: 0x060230A9 RID: 143529 RVA: 0x004D2DB9 File Offset: 0x004D0FB9
		// (set) Token: 0x060230AA RID: 143530 RVA: 0x004D2DC1 File Offset: 0x004D0FC1
		public IDurabilityStateConfigT DurabilityStateConfig { get; set; }

		// Token: 0x17009D9F RID: 40351
		// (get) Token: 0x060230AB RID: 143531 RVA: 0x004D2DCA File Offset: 0x004D0FCA
		// (set) Token: 0x060230AC RID: 143532 RVA: 0x004D2DD2 File Offset: 0x004D0FD2
		public IVectorInfoT HitPoint { get; set; }

		// Token: 0x17009DA0 RID: 40352
		// (get) Token: 0x060230AD RID: 143533 RVA: 0x004D2DDB File Offset: 0x004D0FDB
		// (set) Token: 0x060230AE RID: 143534 RVA: 0x004D2DE3 File Offset: 0x004D0FE3
		public List<IActionInfoT> DestructionActions { get; set; }

		// Token: 0x17009DA1 RID: 40353
		// (get) Token: 0x060230AF RID: 143535 RVA: 0x004D2DEC File Offset: 0x004D0FEC
		// (set) Token: 0x060230B0 RID: 143536 RVA: 0x004D2DF4 File Offset: 0x004D0FF4
		public ISkillDamageT SkillDamage { get; set; }

		// Token: 0x17009DA2 RID: 40354
		// (get) Token: 0x060230B1 RID: 143537 RVA: 0x004D2DFD File Offset: 0x004D0FFD
		// (set) Token: 0x060230B2 RID: 143538 RVA: 0x004D2E05 File Offset: 0x004D1005
		public IElementDamageT ElementDamage { get; set; }

		// Token: 0x17009DA3 RID: 40355
		// (get) Token: 0x060230B3 RID: 143539 RVA: 0x004D2E0E File Offset: 0x004D100E
		// (set) Token: 0x060230B4 RID: 143540 RVA: 0x004D2E16 File Offset: 0x004D1016
		public IWeaponDamageT WeaponDamage { get; set; }

		// Token: 0x17009DA4 RID: 40356
		// (get) Token: 0x060230B5 RID: 143541 RVA: 0x004D2E1F File Offset: 0x004D101F
		// (set) Token: 0x060230B6 RID: 143542 RVA: 0x004D2E27 File Offset: 0x004D1027
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x17009DA5 RID: 40357
		// (get) Token: 0x060230B7 RID: 143543 RVA: 0x004D2E30 File Offset: 0x004D1030
		// (set) Token: 0x060230B8 RID: 143544 RVA: 0x004D2E38 File Offset: 0x004D1038
		public byte NullMask { get; set; }

		// Token: 0x060230B9 RID: 143545 RVA: 0x004D2E44 File Offset: 0x004D1044
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
