using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.InstanceDungeon.Define;

// Token: 0x020010AD RID: 4269
[NullableContext(2)]
[Nullable(0)]
public class BattleRoleSlotData
{
	// Token: 0x0600A930 RID: 43312 RVA: 0x0031C6FE File Offset: 0x0031A8FE
	public BattleRoleSlotData(int position)
	{
		this.PositionInternal = position;
	}

	// Token: 0x0600A931 RID: 43313 RVA: 0x0031C70D File Offset: 0x0031A90D
	[NullableContext(1)]
	public void SetRoleData(BattleRoleData battleRoleData)
	{
		this.RoleDataInternal = battleRoleData;
	}

	// Token: 0x0600A932 RID: 43314 RVA: 0x0031C718 File Offset: 0x0031A918
	[NullableContext(1)]
	public void SetRoleDataByPrewarInfo(PrewarFormationData prewarFormationData)
	{
		if (this.RoleDataInternal == null)
		{
			this.RoleDataInternal = new BattleRoleData();
		}
		this.RoleDataInternal.Init(prewarFormationData.GetPlayerId(), prewarFormationData.GetConfigId(), prewarFormationData.GetSkinId(), new int?(prewarFormationData.GetOnlineNumber()), prewarFormationData.GetPlayerName(), prewarFormationData.GetLevel(), prewarFormationData.IsSelf(), prewarFormationData.GetIsReady());
		this.RoleDataInternal.ThirdPartyOnlineId = prewarFormationData.GetPlayerOnlineId();
	}

	// Token: 0x0600A933 RID: 43315 RVA: 0x0031C789 File Offset: 0x0031A989
	public void ResetRoleData()
	{
		this.RoleDataInternal = null;
	}

	// Token: 0x170011B4 RID: 4532
	// (get) Token: 0x0600A934 RID: 43316 RVA: 0x0031C792 File Offset: 0x0031A992
	public BattleRoleData RoleData
	{
		get
		{
			return this.RoleDataInternal;
		}
	}

	// Token: 0x170011B5 RID: 4533
	// (get) Token: 0x0600A935 RID: 43317 RVA: 0x0031C79C File Offset: 0x0031A99C
	public int? RoleConfigId
	{
		get
		{
			BattleRoleData roleDataInternal = this.RoleDataInternal;
			if (roleDataInternal == null)
			{
				return null;
			}
			return new int?(roleDataInternal.ConfigId);
		}
	}

	// Token: 0x170011B6 RID: 4534
	// (get) Token: 0x0600A936 RID: 43318 RVA: 0x0031C7C7 File Offset: 0x0031A9C7
	public bool HasRole
	{
		get
		{
			return this.RoleDataInternal != null;
		}
	}

	// Token: 0x170011B7 RID: 4535
	// (get) Token: 0x0600A937 RID: 43319 RVA: 0x0031C7D2 File Offset: 0x0031A9D2
	public int Position
	{
		get
		{
			return this.PositionInternal;
		}
	}

	// Token: 0x170011B8 RID: 4536
	// (get) Token: 0x0600A938 RID: 43320 RVA: 0x0031C7DC File Offset: 0x0031A9DC
	public bool IsProhibit
	{
		get
		{
			BattleTeamModel instance = BattleTeamModel.Instance;
			if (instance.Context.IsMultiInstanceDungeon)
			{
				return false;
			}
			if (instance.IsLeaderSelf)
			{
				int maxLimitRoleCount = instance.Context.MaxLimitRoleCount;
				return maxLimitRoleCount != 0 && this.PositionInternal > maxLimitRoleCount;
			}
			return !this.HasRole || !this.RoleDataInternal.IsSelf;
		}
	}

	// Token: 0x170011B9 RID: 4537
	// (get) Token: 0x0600A939 RID: 43321 RVA: 0x0031C839 File Offset: 0x0031AA39
	public bool CanEditRoleSlot
	{
		get
		{
			if (this.IsProhibit)
			{
				return false;
			}
			if (this.HasRole)
			{
				return this.RoleDataInternal.IsSelf;
			}
			return BattleTeamModel.Instance.IsLeaderSelf;
		}
	}

	// Token: 0x04006268 RID: 25192
	private readonly int PositionInternal;

	// Token: 0x04006269 RID: 25193
	private BattleRoleData RoleDataInternal;
}
