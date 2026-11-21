using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C45 RID: 27717
	public class IDisableCharacterSectionalSkillOptionT
	{
		// Token: 0x1700CB21 RID: 52001
		// (get) Token: 0x0602FB42 RID: 195394 RVA: 0x0067F4C6 File Offset: 0x0067D6C6
		// (set) Token: 0x0602FB43 RID: 195395 RVA: 0x0067F4CE File Offset: 0x0067D6CE
		public bool DisableJump { get; set; }

		// Token: 0x1700CB22 RID: 52002
		// (get) Token: 0x0602FB44 RID: 195396 RVA: 0x0067F4D7 File Offset: 0x0067D6D7
		// (set) Token: 0x0602FB45 RID: 195397 RVA: 0x0067F4DF File Offset: 0x0067D6DF
		public bool DisableShowClimb { get; set; }

		// Token: 0x1700CB23 RID: 52003
		// (get) Token: 0x0602FB46 RID: 195398 RVA: 0x0067F4E8 File Offset: 0x0067D6E8
		// (set) Token: 0x0602FB47 RID: 195399 RVA: 0x0067F4F0 File Offset: 0x0067D6F0
		public bool DisableAttack { get; set; }

		// Token: 0x1700CB24 RID: 52004
		// (get) Token: 0x0602FB48 RID: 195400 RVA: 0x0067F4F9 File Offset: 0x0067D6F9
		// (set) Token: 0x0602FB49 RID: 195401 RVA: 0x0067F501 File Offset: 0x0067D701
		public bool DisableDodge { get; set; }

		// Token: 0x1700CB25 RID: 52005
		// (get) Token: 0x0602FB4A RID: 195402 RVA: 0x0067F50A File Offset: 0x0067D70A
		// (set) Token: 0x0602FB4B RID: 195403 RVA: 0x0067F512 File Offset: 0x0067D712
		public bool DisableSkill1 { get; set; }

		// Token: 0x1700CB26 RID: 52006
		// (get) Token: 0x0602FB4C RID: 195404 RVA: 0x0067F51B File Offset: 0x0067D71B
		// (set) Token: 0x0602FB4D RID: 195405 RVA: 0x0067F523 File Offset: 0x0067D723
		public bool DisableUltimateSkill { get; set; }

		// Token: 0x1700CB27 RID: 52007
		// (get) Token: 0x0602FB4E RID: 195406 RVA: 0x0067F52C File Offset: 0x0067D72C
		// (set) Token: 0x0602FB4F RID: 195407 RVA: 0x0067F534 File Offset: 0x0067D734
		public bool DisableExploreInput { get; set; }

		// Token: 0x1700CB28 RID: 52008
		// (get) Token: 0x0602FB50 RID: 195408 RVA: 0x0067F53D File Offset: 0x0067D73D
		// (set) Token: 0x0602FB51 RID: 195409 RVA: 0x0067F545 File Offset: 0x0067D745
		public bool DisableSwitchRole1 { get; set; }

		// Token: 0x1700CB29 RID: 52009
		// (get) Token: 0x0602FB52 RID: 195410 RVA: 0x0067F54E File Offset: 0x0067D74E
		// (set) Token: 0x0602FB53 RID: 195411 RVA: 0x0067F556 File Offset: 0x0067D756
		public bool DisableSwitchRole2 { get; set; }

		// Token: 0x1700CB2A RID: 52010
		// (get) Token: 0x0602FB54 RID: 195412 RVA: 0x0067F55F File Offset: 0x0067D75F
		// (set) Token: 0x0602FB55 RID: 195413 RVA: 0x0067F567 File Offset: 0x0067D767
		public bool DisableSwitchRole3 { get; set; }

		// Token: 0x1700CB2B RID: 52011
		// (get) Token: 0x0602FB56 RID: 195414 RVA: 0x0067F570 File Offset: 0x0067D770
		// (set) Token: 0x0602FB57 RID: 195415 RVA: 0x0067F578 File Offset: 0x0067D778
		public bool DisableLock { get; set; }

		// Token: 0x1700CB2C RID: 52012
		// (get) Token: 0x0602FB58 RID: 195416 RVA: 0x0067F581 File Offset: 0x0067D781
		// (set) Token: 0x0602FB59 RID: 195417 RVA: 0x0067F589 File Offset: 0x0067D789
		public bool DisableAim { get; set; }

		// Token: 0x1700CB2D RID: 52013
		// (get) Token: 0x0602FB5A RID: 195418 RVA: 0x0067F592 File Offset: 0x0067D792
		// (set) Token: 0x0602FB5B RID: 195419 RVA: 0x0067F59A File Offset: 0x0067D79A
		public ushort NullMask { get; set; }

		// Token: 0x0602FB5C RID: 195420 RVA: 0x0067F5A4 File Offset: 0x0067D7A4
		public IDisableCharacterSectionalSkillOptionT()
		{
			this.DisableJump = false;
			this.DisableShowClimb = false;
			this.DisableAttack = false;
			this.DisableDodge = false;
			this.DisableSkill1 = false;
			this.DisableUltimateSkill = false;
			this.DisableExploreInput = false;
			this.DisableSwitchRole1 = false;
			this.DisableSwitchRole2 = false;
			this.DisableSwitchRole3 = false;
			this.DisableLock = false;
			this.DisableAim = false;
			this.NullMask = 0;
		}
	}
}
