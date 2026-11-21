using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001C88 RID: 7304
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class RoleTowerConfig : ConfigBase
{
	// Token: 0x060121FA RID: 74234 RVA: 0x005571C0 File Offset: 0x005553C0
	public RoleTowerParam? GetParamByActivityId(int actId)
	{
		return ConfigRoleTowerParamByActivityId.GetConfig(actId, true);
	}

	// Token: 0x060121FB RID: 74235 RVA: 0x005571C9 File Offset: 0x005553C9
	public RoleTowerLevelGroup? GetGroupById(int id)
	{
		return ConfigRoleTowerLevelGroupById.GetConfig(id, true);
	}

	// Token: 0x060121FC RID: 74236 RVA: 0x005571D2 File Offset: 0x005553D2
	public IReadOnlyList<RoleTowerLevelGroup> GetGroupsByActivityId(int actId)
	{
		return ConfigRoleTowerLevelGroupByActivityId.GetConfigList(actId, true);
	}

	// Token: 0x060121FD RID: 74237 RVA: 0x005571DB File Offset: 0x005553DB
	public IReadOnlyList<RoleTowerLevelGroup> GetAllGroups()
	{
		return ConfigRoleTowerLevelGroupAll.GetConfigList(true);
	}

	// Token: 0x060121FE RID: 74238 RVA: 0x005571E3 File Offset: 0x005553E3
	public RoleTowerLevel? GetLevelById(int id)
	{
		return ConfigRoleTowerLevelById.GetConfig(id, true);
	}

	// Token: 0x060121FF RID: 74239 RVA: 0x005571EC File Offset: 0x005553EC
	public IReadOnlyList<RoleTowerLevel> GetLevelsByGroup(int groupId)
	{
		return ConfigRoleTowerLevelByGroupId.GetConfigList(groupId, true);
	}

	// Token: 0x06012200 RID: 74240 RVA: 0x005571F5 File Offset: 0x005553F5
	public IReadOnlyList<RoleTowerLevel> GetAllLevels()
	{
		return ConfigRoleTowerLevelAll.GetConfigList(true);
	}

	// Token: 0x06012201 RID: 74241 RVA: 0x005571FD File Offset: 0x005553FD
	public RoleTowerStage? GetStageById(int id)
	{
		return ConfigRoleTowerStageById.GetConfig(id, true);
	}

	// Token: 0x06012202 RID: 74242 RVA: 0x00557206 File Offset: 0x00555406
	public IReadOnlyList<RoleTowerStage> GetAllStages()
	{
		return ConfigRoleTowerStageAll.GetConfigList(true);
	}

	// Token: 0x06012203 RID: 74243 RVA: 0x00557210 File Offset: 0x00555410
	public int GetFloorStageSeq(int floorId)
	{
		RoleTowerFloor? roleTowerFloor;
		int id = (this.GetFloorById(floorId) != null) ? roleTowerFloor.GetValueOrDefault().Stage : 0;
		if (this.GetStageById(id) == null)
		{
			return 0;
		}
		RoleTowerStage? roleTowerStage;
		return roleTowerStage.GetValueOrDefault().Stage;
	}

	// Token: 0x06012204 RID: 74244 RVA: 0x00557264 File Offset: 0x00555464
	public int GetFloorStageId(int floorId)
	{
		if (this.GetFloorById(floorId) == null)
		{
			return 0;
		}
		RoleTowerFloor? roleTowerFloor;
		return roleTowerFloor.GetValueOrDefault().Stage;
	}

	// Token: 0x06012205 RID: 74245 RVA: 0x00557293 File Offset: 0x00555493
	public RoleTowerFloor? GetFloorById(int id)
	{
		return ConfigRoleTowerFloorById.GetConfig(id, true);
	}

	// Token: 0x06012206 RID: 74246 RVA: 0x0055729C File Offset: 0x0055549C
	public RoleTowerFloor? GetFloorByBranch(int branchId)
	{
		return ConfigRoleTowerFloorByBranch.GetConfig(branchId, true);
	}

	// Token: 0x06012207 RID: 74247 RVA: 0x005572A8 File Offset: 0x005554A8
	public IReadOnlyList<RoleTowerFloor> GetFloorsByLevel(int levelId)
	{
		RoleTowerLevel? levelById = this.GetLevelById(levelId);
		if (levelById == null || levelById.Value.FloorGroupId <= 0)
		{
			return null;
		}
		return ConfigRoleTowerFloorByFloorGroupId.GetConfigList(levelById.Value.FloorGroupId, true);
	}

	// Token: 0x06012208 RID: 74248 RVA: 0x005572EF File Offset: 0x005554EF
	public RoleTowerWave? GetWaveById(int id)
	{
		return ConfigRoleTowerWaveById.GetConfig(id, true);
	}

	// Token: 0x06012209 RID: 74249 RVA: 0x005572F8 File Offset: 0x005554F8
	public IReadOnlyList<RoleTowerWave> GetWavesByFloor(int floorId)
	{
		return ConfigRoleTowerWaveByFloorId.GetConfigList(floorId, true);
	}

	// Token: 0x0601220A RID: 74250 RVA: 0x00557301 File Offset: 0x00555501
	public RoleTowerBranch? GetBranchById(int id)
	{
		return ConfigRoleTowerBranchById.GetConfig(id, true);
	}

	// Token: 0x0601220B RID: 74251 RVA: 0x0055730A File Offset: 0x0055550A
	public IReadOnlyList<RoleTowerBranch> GetAllBranches()
	{
		return ConfigRoleTowerBranchAll.GetConfigList(true);
	}

	// Token: 0x0601220C RID: 74252 RVA: 0x00557312 File Offset: 0x00555512
	public RoleTowerToken? GetTokenById(int id)
	{
		return ConfigRoleTowerTokenById.GetConfig(id, true);
	}

	// Token: 0x0601220D RID: 74253 RVA: 0x0055731B File Offset: 0x0055551B
	public IReadOnlyList<RoleTowerToken> GetTokensByActivityId(int actId)
	{
		return ConfigRoleTowerTokenByActivityId.GetConfigList(actId, true);
	}

	// Token: 0x0601220E RID: 74254 RVA: 0x00557324 File Offset: 0x00555524
	public RoleTowerTokenType? GetTokenTypeById(int id)
	{
		return ConfigRoleTowerTokenTypeById.GetConfig(id, true);
	}

	// Token: 0x0601220F RID: 74255 RVA: 0x0055732D File Offset: 0x0055552D
	public IReadOnlyList<RoleTowerTokenType> GetAllTokenTypes()
	{
		return ConfigRoleTowerTokenTypeAll.GetConfigList(true);
	}

	// Token: 0x06012210 RID: 74256 RVA: 0x00557335 File Offset: 0x00555535
	public RoleTowerTokenZone? GetTokenZoneById(int id)
	{
		return ConfigRoleTowerTokenZoneById.GetConfig(id, true);
	}

	// Token: 0x06012211 RID: 74257 RVA: 0x0055733E File Offset: 0x0055553E
	public IReadOnlyList<RoleTowerTokenZone> GetTokenZonesByActivityId(int actId)
	{
		return ConfigRoleTowerTokenZoneByActivityId.GetConfigList(actId, true);
	}

	// Token: 0x06012212 RID: 74258 RVA: 0x00557347 File Offset: 0x00555547
	public RoleTowerRewardTab? GetRewardTabById(int id)
	{
		return ConfigRoleTowerRewardTabById.GetConfig(id, true);
	}

	// Token: 0x06012213 RID: 74259 RVA: 0x00557350 File Offset: 0x00555550
	public IReadOnlyList<RoleTowerRewardTab> GetRewardTabsByActivityId(int actId)
	{
		return ConfigRoleTowerRewardTabByActivityId.GetConfigList(actId, true);
	}

	// Token: 0x06012214 RID: 74260 RVA: 0x00557359 File Offset: 0x00555559
	public RoleTowerReward? GetRewardById(int id)
	{
		return ConfigRoleTowerRewardById.GetConfig(id, true);
	}

	// Token: 0x06012215 RID: 74261 RVA: 0x00557362 File Offset: 0x00555562
	public IReadOnlyList<RoleTowerReward> GetRewardsByActivityId(int actId)
	{
		return ConfigRoleTowerRewardByActivityId.GetConfigList(actId, true);
	}

	// Token: 0x06012216 RID: 74262 RVA: 0x0055736B File Offset: 0x0055556B
	public IReadOnlyList<RoleTowerReward> GetRewardsByTab(int tabId)
	{
		return ConfigRoleTowerRewardByTabId.GetConfigList(tabId, true);
	}

	// Token: 0x06012217 RID: 74263 RVA: 0x00557374 File Offset: 0x00555574
	public RoleTowerScoreReward? GetScoreRewardById(int id)
	{
		return ConfigRoleTowerScoreRewardById.GetConfig(id, true);
	}

	// Token: 0x06012218 RID: 74264 RVA: 0x0055737D File Offset: 0x0055557D
	public IReadOnlyList<RoleTowerScoreReward> GetScoreRewardsByActivityId(int actId)
	{
		return ConfigRoleTowerScoreRewardByActivityId.GetConfigList(actId, true);
	}

	// Token: 0x06012219 RID: 74265 RVA: 0x00557386 File Offset: 0x00555586
	public RoleTowerStarGroup? GetStarGroupById(int id)
	{
		return ConfigRoleTowerStarGroupById.GetConfig(id, true);
	}

	// Token: 0x0601221A RID: 74266 RVA: 0x0055738F File Offset: 0x0055558F
	public IReadOnlyList<RoleTowerStarGroup> GetAllStarGroups()
	{
		return ConfigRoleTowerStarGroupAll.GetConfigList(true);
	}

	// Token: 0x0601221B RID: 74267 RVA: 0x00557397 File Offset: 0x00555597
	public RoleTowerStar? GetStarById(int id)
	{
		return ConfigRoleTowerStarById.GetConfig(id, true);
	}

	// Token: 0x0601221C RID: 74268 RVA: 0x005573A0 File Offset: 0x005555A0
	public IReadOnlyList<RoleTowerStar> GetStarsByGroup(int groupId)
	{
		return ConfigRoleTowerStarByGroupId.GetConfigList(groupId, true);
	}

	// Token: 0x0601221D RID: 74269 RVA: 0x005573A9 File Offset: 0x005555A9
	public RoleTowerEchoLevel? GetEchoLevelById(int id)
	{
		return ConfigRoleTowerEchoLevelById.GetConfig(id, true);
	}

	// Token: 0x0601221E RID: 74270 RVA: 0x005573B2 File Offset: 0x005555B2
	public IReadOnlyList<RoleTowerEchoLevel> GetEchoLevelsByActivityId(int actId)
	{
		return ConfigRoleTowerEchoLevelByActivityId.GetConfigList(actId, true);
	}

	// Token: 0x0601221F RID: 74271 RVA: 0x005573BC File Offset: 0x005555BC
	public RoleTowerRole? GetRoleByRoleId(int roleId)
	{
		if (roleId > 0)
		{
			return ConfigRoleTowerRoleByRoleId.GetConfig(roleId, true);
		}
		return null;
	}

	// Token: 0x17001B5D RID: 7005
	// (get) Token: 0x06012220 RID: 74272 RVA: 0x005573DE File Offset: 0x005555DE
	[Nullable(1)]
	public static RoleTowerConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return RoleTowerConfig._Instance;
		}
	}

	// Token: 0x06012221 RID: 74273 RVA: 0x005573E5 File Offset: 0x005555E5
	[NullableContext(1)]
	public static RoleTowerConfig GetOrCreateInstance()
	{
		if (RoleTowerConfig._Instance == null)
		{
			RoleTowerConfig.CreateInstance();
		}
		return RoleTowerConfig._Instance;
	}

	// Token: 0x06012222 RID: 74274 RVA: 0x005573F9 File Offset: 0x005555F9
	public static bool CreateInstance()
	{
		if (RoleTowerConfig._Instance != null)
		{
			return true;
		}
		RoleTowerConfig._Instance = new RoleTowerConfig();
		return true;
	}

	// Token: 0x06012223 RID: 74275 RVA: 0x0055740F File Offset: 0x0055560F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012224 RID: 74276 RVA: 0x00557411 File Offset: 0x00555611
	public static void ResetStaticDefaultValue()
	{
		RoleTowerConfig._Instance = null;
	}

	// Token: 0x06012225 RID: 74277 RVA: 0x00557419 File Offset: 0x00555619
	static RoleTowerConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleTowerConfig.CreateStaticDefaultValue), new Action(RoleTowerConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04009E1B RID: 40475
	private static RoleTowerConfig _Instance;
}
