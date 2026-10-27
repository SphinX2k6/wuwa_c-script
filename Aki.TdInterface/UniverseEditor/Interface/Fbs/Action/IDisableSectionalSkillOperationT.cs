using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065F2 RID: 26098
	public class IDisableSectionalSkillOperationT
	{
		// Token: 0x1700C1E2 RID: 49634
		// (get) Token: 0x0602D4D3 RID: 185555 RVA: 0x006358A7 File Offset: 0x00633AA7
		// (set) Token: 0x0602D4D4 RID: 185556 RVA: 0x006358AF File Offset: 0x00633AAF
		public ESkillOperationType Type { get; set; }

		// Token: 0x1700C1E3 RID: 49635
		// (get) Token: 0x0602D4D5 RID: 185557 RVA: 0x006358B8 File Offset: 0x00633AB8
		// (set) Token: 0x0602D4D6 RID: 185558 RVA: 0x006358C0 File Offset: 0x00633AC0
		public EDisplayModeInSkillOp DisplayMode { get; set; }

		// Token: 0x1700C1E4 RID: 49636
		// (get) Token: 0x0602D4D7 RID: 185559 RVA: 0x006358C9 File Offset: 0x00633AC9
		// (set) Token: 0x0602D4D8 RID: 185560 RVA: 0x006358D1 File Offset: 0x00633AD1
		public IDisableExploreSkillT DisableExploreSkill { get; set; }

		// Token: 0x1700C1E5 RID: 49637
		// (get) Token: 0x0602D4D9 RID: 185561 RVA: 0x006358DA File Offset: 0x00633ADA
		// (set) Token: 0x0602D4DA RID: 185562 RVA: 0x006358E2 File Offset: 0x00633AE2
		public bool DisableSkillWheel { get; set; }

		// Token: 0x1700C1E6 RID: 49638
		// (get) Token: 0x0602D4DB RID: 185563 RVA: 0x006358EB File Offset: 0x00633AEB
		// (set) Token: 0x0602D4DC RID: 185564 RVA: 0x006358F3 File Offset: 0x00633AF3
		public IDisableBattleSkillOptionsT DisableBattleSkill { get; set; }

		// Token: 0x1700C1E7 RID: 49639
		// (get) Token: 0x0602D4DD RID: 185565 RVA: 0x006358FC File Offset: 0x00633AFC
		// (set) Token: 0x0602D4DE RID: 185566 RVA: 0x00635904 File Offset: 0x00633B04
		public bool DisableSwitchRole { get; set; }

		// Token: 0x1700C1E8 RID: 49640
		// (get) Token: 0x0602D4DF RID: 185567 RVA: 0x0063590D File Offset: 0x00633B0D
		// (set) Token: 0x0602D4E0 RID: 185568 RVA: 0x00635915 File Offset: 0x00633B15
		public ETeamDisplayModeInSkillOp TeamDisplayMode { get; set; }

		// Token: 0x1700C1E9 RID: 49641
		// (get) Token: 0x0602D4E1 RID: 185569 RVA: 0x0063591E File Offset: 0x00633B1E
		// (set) Token: 0x0602D4E2 RID: 185570 RVA: 0x00635926 File Offset: 0x00633B26
		public byte NullMask { get; set; }

		// Token: 0x0602D4E3 RID: 185571 RVA: 0x0063592F File Offset: 0x00633B2F
		public IDisableSectionalSkillOperationT()
		{
			this.Type = ESkillOperationType.Enable;
			this.DisplayMode = EDisplayModeInSkillOp.Ashen;
			this.DisableExploreSkill = null;
			this.DisableSkillWheel = false;
			this.DisableBattleSkill = null;
			this.DisableSwitchRole = false;
			this.TeamDisplayMode = ETeamDisplayModeInSkillOp.Normal;
			this.NullMask = 0;
		}
	}
}
