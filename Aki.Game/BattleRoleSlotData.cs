using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.InstanceDungeon.Define;

// Token: 0x02001BEE RID: 7150
[NullableContext(2)]
[Nullable(0)]
public class BattleRoleSlotData
{
	// Token: 0x0600D51D RID: 54557 RVA: 0x003114BA File Offset: 0x0030F6BA
	public BattleRoleSlotData(int position)
	{
		this.PositionInternal = position;
	}

	// Token: 0x0600D51E RID: 54558 RVA: 0x003114C9 File Offset: 0x0030F6C9
	[NullableContext(1)]
	public void SetRoleData(BattleRoleData battleRoleData)
	{
		this.RoleDataInternal = battleRoleData;
	}

	// Token: 0x0600D51F RID: 54559 RVA: 0x003114D4 File Offset: 0x0030F6D4
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

	// Token: 0x0600D520 RID: 54560 RVA: 0x00311545 File Offset: 0x0030F745
	public void ResetRoleData()
	{
		this.RoleDataInternal = null;
	}

	// Token: 0x1700118F RID: 4495
	// (get) Token: 0x0600D521 RID: 54561 RVA: 0x0031154E File Offset: 0x0030F74E
	public BattleRoleData RoleData
	{
		get
		{
			return this.RoleDataInternal;
		}
	}

	// Token: 0x17001190 RID: 4496
	// (get) Token: 0x0600D522 RID: 54562 RVA: 0x00311558 File Offset: 0x0030F758
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

	// Token: 0x17001191 RID: 4497
	// (get) Token: 0x0600D523 RID: 54563 RVA: 0x00311583 File Offset: 0x0030F783
	public bool HasRole
	{
		get
		{
			return this.RoleDataInternal != null;
		}
	}

	// Token: 0x17001192 RID: 4498
	// (get) Token: 0x0600D524 RID: 54564 RVA: 0x0031158E File Offset: 0x0030F78E
	public int Position
	{
		get
		{
			return this.PositionInternal;
		}
	}

	// Token: 0x17001193 RID: 4499
	// (get) Token: 0x0600D525 RID: 54565 RVA: 0x00311598 File Offset: 0x0030F798
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

	// Token: 0x17001194 RID: 4500
	// (get) Token: 0x0600D526 RID: 54566 RVA: 0x003115F5 File Offset: 0x0030F7F5
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

	// Token: 0x04006199 RID: 24985
	private readonly int PositionInternal;

	// Token: 0x0400619A RID: 24986
	private BattleRoleData RoleDataInternal;
}
