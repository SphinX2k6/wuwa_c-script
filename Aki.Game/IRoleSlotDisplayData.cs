using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020010A3 RID: 4259
public class IRoleSlotDisplayData
{
	// Token: 0x04006236 RID: 25142
	public int ConfigId;

	// Token: 0x04006237 RID: 25143
	public int SkinId;

	// Token: 0x04006238 RID: 25144
	public int Level;

	// Token: 0x04006239 RID: 25145
	[Nullable(1)]
	public string Name = "";

	// Token: 0x0400623A RID: 25146
	public int OnlineIndex;

	// Token: 0x0400623B RID: 25147
	public int PlayerId;

	// Token: 0x0400623C RID: 25148
	[Nullable(1)]
	public string ThirdPartyOnlineId = "";

	// Token: 0x0400623D RID: 25149
	public bool CanUseSpecialTrialRole;

	// Token: 0x0400623E RID: 25150
	public bool IsDead;

	// Token: 0x0400623F RID: 25151
	public bool IsTrialRole;

	// Token: 0x04006240 RID: 25152
	public bool IsSelf;

	// Token: 0x04006241 RID: 25153
	public bool IsMultiContext;

	// Token: 0x04006242 RID: 25154
	public bool IsThirdPartyVisible;

	// Token: 0x04006243 RID: 25155
	[Nullable(2)]
	public IRoleSlotDisplayData.WeeklyRogueData WeeklyRogue;

	// Token: 0x04006244 RID: 25156
	[Nullable(2)]
	public IRoleSlotDisplayData.TowerCostData TowerCost;

	// Token: 0x04006245 RID: 25157
	[Nullable(2)]
	public IRoleSlotDisplayData.SkillBranchData SkillBranch;

	// Token: 0x04006246 RID: 25158
	[Nullable(2)]
	public IRoleSlotDisplayData.PrepareData Prepare;

	// Token: 0x04006247 RID: 25159
	[Nullable(2)]
	public FormationRoleEquip Equip;

	// Token: 0x0200731D RID: 29469
	public class WeeklyRogueData
	{
		// Token: 0x04025794 RID: 153492
		public bool IsRecommendRole;
	}

	// Token: 0x0200731E RID: 29470
	public class TowerCostData
	{
		// Token: 0x04025795 RID: 153493
		public int CurrentCost;

		// Token: 0x04025796 RID: 153494
		public int NeedCost;

		// Token: 0x04025797 RID: 153495
		public bool IsHaveChallenge;
	}

	// Token: 0x0200731F RID: 29471
	public class SkillBranchData
	{
		// Token: 0x04025798 RID: 153496
		public bool IsMulti;

		// Token: 0x04025799 RID: 153497
		public bool IsSelf;

		// Token: 0x0402579A RID: 153498
		public bool IsHiddenByInstSubType;

		// Token: 0x0402579B RID: 153499
		public int ActiveBranchIndex;
	}

	// Token: 0x02007320 RID: 29472
	public class PrepareData
	{
		// Token: 0x0402579C RID: 153500
		public bool IsRoleConflict;

		// Token: 0x0402579D RID: 153501
		public bool ShouldSuppressByGameplay;

		// Token: 0x0402579E RID: 153502
		public EMatchPlayerUiState? PlayerUiState;

		// Token: 0x0402579F RID: 153503
		public bool IsHost;
	}
}
