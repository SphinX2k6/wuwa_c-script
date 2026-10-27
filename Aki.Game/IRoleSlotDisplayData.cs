using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001BE4 RID: 7140
public class IRoleSlotDisplayData
{
	// Token: 0x04006167 RID: 24935
	public int ConfigId;

	// Token: 0x04006168 RID: 24936
	public int SkinId;

	// Token: 0x04006169 RID: 24937
	public int Level;

	// Token: 0x0400616A RID: 24938
	[Nullable(1)]
	public string Name = "";

	// Token: 0x0400616B RID: 24939
	public int OnlineIndex;

	// Token: 0x0400616C RID: 24940
	public int PlayerId;

	// Token: 0x0400616D RID: 24941
	[Nullable(1)]
	public string ThirdPartyOnlineId = "";

	// Token: 0x0400616E RID: 24942
	public bool CanUseSpecialTrialRole;

	// Token: 0x0400616F RID: 24943
	public bool IsDead;

	// Token: 0x04006170 RID: 24944
	public bool IsTrialRole;

	// Token: 0x04006171 RID: 24945
	public bool IsSelf;

	// Token: 0x04006172 RID: 24946
	public bool IsMultiContext;

	// Token: 0x04006173 RID: 24947
	public bool IsThirdPartyVisible;

	// Token: 0x04006174 RID: 24948
	[Nullable(2)]
	public IRoleSlotDisplayData.WeeklyRogueData WeeklyRogue;

	// Token: 0x04006175 RID: 24949
	[Nullable(2)]
	public IRoleSlotDisplayData.TowerCostData TowerCost;

	// Token: 0x04006176 RID: 24950
	[Nullable(2)]
	public IRoleSlotDisplayData.SkillBranchData SkillBranch;

	// Token: 0x04006177 RID: 24951
	[Nullable(2)]
	public IRoleSlotDisplayData.PrepareData Prepare;

	// Token: 0x04006178 RID: 24952
	[Nullable(2)]
	public FormationRoleEquip Equip;

	// Token: 0x0200818F RID: 33167
	public class WeeklyRogueData
	{
		// Token: 0x0402A460 RID: 173152
		public bool IsRecommendRole;
	}

	// Token: 0x02008190 RID: 33168
	public class TowerCostData
	{
		// Token: 0x0402A461 RID: 173153
		public int CurrentCost;

		// Token: 0x0402A462 RID: 173154
		public int NeedCost;

		// Token: 0x0402A463 RID: 173155
		public bool IsHaveChallenge;
	}

	// Token: 0x02008191 RID: 33169
	public class SkillBranchData
	{
		// Token: 0x0402A464 RID: 173156
		public bool IsMulti;

		// Token: 0x0402A465 RID: 173157
		public bool IsSelf;

		// Token: 0x0402A466 RID: 173158
		public bool IsHiddenByInstSubType;

		// Token: 0x0402A467 RID: 173159
		public int ActiveBranchIndex;
	}

	// Token: 0x02008192 RID: 33170
	public class PrepareData
	{
		// Token: 0x0402A468 RID: 173160
		public bool IsRoleConflict;

		// Token: 0x0402A469 RID: 173161
		public bool ShouldSuppressByGameplay;

		// Token: 0x0402A46A RID: 173162
		public EMatchPlayerUiState? PlayerUiState;

		// Token: 0x0402A46B RID: 173163
		public bool IsHost;
	}
}
