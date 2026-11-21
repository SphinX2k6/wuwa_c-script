using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.KuroSimpleCombat;
using UnrealEngine;

// Token: 0x02000389 RID: 905
[NullableContext(2)]
[Nullable(0)]
public class TowerDefensePlayerModel
{
	// Token: 0x17000763 RID: 1891
	// (get) Token: 0x06003242 RID: 12866 RVA: 0x001216EC File Offset: 0x0011F8EC
	public AKSC_Entity_AssistMachine PossessedFollowerKscEntity
	{
		get
		{
			KscEntityHandle possessedFollowerHandle = this.PossessedFollowerHandle;
			if (possessedFollowerHandle == null || !possessedFollowerHandle.Valid)
			{
				KscLog.EModule flag = KscLog.EModule.Common;
				ELogAuthor author = ELogAuthor.PZ;
				UObject kscWorld = KscEnv.Instance.KscWorld;
				string log = "塔防跟随物异常";
				string item = "possessed player";
				KscEntityHandle possessedPlayerHandle = this.PossessedPlayerHandle;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (possessedPlayerHandle != null) ? possessedPlayerHandle.KscEntity : null);
				KscLog.Warn(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			AKSC_Entity_AssistMachine aksc_Entity_AssistMachine = this.PossessedFollowerHandle.KscEntity as AKSC_Entity_AssistMachine;
			if (aksc_Entity_AssistMachine == null)
			{
				KscLog.EModule flag2 = KscLog.EModule.Common;
				ELogAuthor author2 = ELogAuthor.PZ;
				UObject kscWorld2 = KscEnv.Instance.KscWorld;
				string log2 = "塔防跟随物类型异常";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("possessed follower", aksc_Entity_AssistMachine);
				KscLog.Warn(flag2, author2, kscWorld2, log2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return null;
			}
			return aksc_Entity_AssistMachine;
		}
	}

	// Token: 0x17000764 RID: 1892
	// (get) Token: 0x06003243 RID: 12867 RVA: 0x00121790 File Offset: 0x0011F990
	public Entity PossessedFollowerEntity
	{
		get
		{
			KscEntityHandle possessedFollowerHandle = this.PossessedFollowerHandle;
			long? num = (possessedFollowerHandle != null) ? new long?(possessedFollowerHandle.CreatureDataId) : null;
			if (num == null || num.Value == 0L)
			{
				KscLog.EModule flag = KscLog.EModule.Common;
				ELogAuthor author = ELogAuthor.PZ;
				UObject kscWorld = KscEnv.Instance.KscWorld;
				string log = "塔防跟随物实体异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("creature Id", num);
				KscLog.Warn(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			EntityHandle entity = CreatureModel.Instance.GetEntity(num.Value);
			if (entity == null)
			{
				KscLog.EModule flag2 = KscLog.EModule.Common;
				ELogAuthor author2 = ELogAuthor.PZ;
				UObject kscWorld2 = KscEnv.Instance.KscWorld;
				string log2 = "塔防跟随物实体异常";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("creature Id", num);
				KscLog.Warn(flag2, author2, kscWorld2, log2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return null;
			}
			return entity.Entity;
		}
	}

	// Token: 0x17000765 RID: 1893
	// (get) Token: 0x06003244 RID: 12868 RVA: 0x00121850 File Offset: 0x0011FA50
	public bool PossessedFollowerEnabled
	{
		get
		{
			Entity possessedFollowerEntity = this.PossessedFollowerEntity;
			return possessedFollowerEntity != null && !possessedFollowerEntity.HasDisableKey(EEntityDisableKey.SetEntityEnable);
		}
	}

	// Token: 0x17000766 RID: 1894
	// (get) Token: 0x06003245 RID: 12869 RVA: 0x00121873 File Offset: 0x0011FA73
	public AActor PossessedFollowerActor
	{
		get
		{
			Entity possessedFollowerEntity = this.PossessedFollowerEntity;
			CharacterActorComponent characterActorComponent = (possessedFollowerEntity != null) ? possessedFollowerEntity.GetComponent<CharacterActorComponent>() : null;
			if (characterActorComponent == null)
			{
				return null;
			}
			return characterActorComponent.Actor;
		}
	}

	// Token: 0x06003246 RID: 12870 RVA: 0x00121894 File Offset: 0x0011FA94
	public bool OnStop()
	{
		this.PendingRoleHandle = null;
		this.PossessedPlayerHandle = null;
		this.PendingFollowerCreatureId = null;
		this.PendingFollowers = null;
		this.PossessedFollowerHandle = null;
		this.PossessedFollowerProxies = null;
		this.CurrentFollowerProxyId = null;
		this.CurrentFollowerEnable = false;
		this.BindFollowerSkills = null;
		this.SkillId2SkillData = null;
		this.ChargeSkill = null;
		this.LastSkillChargeFull = false;
		this.ChargeCueHandle = 0;
		this.FollowCueHandle = null;
		this.IsInAutoCast = false;
		this.IsInCharge = false;
		this.FollowerCdCueHandle = null;
		this.FollowerState = TDPlayerDefine.EFollowerState.None;
		this.PsFeedbackId = null;
		this.TowerDefenseWorldDone = false;
		this.HasInitKSCEntity = false;
		this.AllSkillId2SkillData = null;
		this.IsInFollowerInit = false;
		return true;
	}

	// Token: 0x04002B84 RID: 11140
	public static readonly int PlayerEntityKey = 1001;

	// Token: 0x04002B85 RID: 11141
	public static readonly int FollowerEntityKey = 1002;

	// Token: 0x04002B86 RID: 11142
	public bool TowerDefenseWorldDone;

	// Token: 0x04002B87 RID: 11143
	public bool HasInitKSCEntity;

	// Token: 0x04002B88 RID: 11144
	public EntityHandle PendingRoleHandle;

	// Token: 0x04002B89 RID: 11145
	public KscEntityHandle PossessedPlayerHandle;

	// Token: 0x04002B8A RID: 11146
	public long? PendingFollowerCreatureId;

	// Token: 0x04002B8B RID: 11147
	public int[] PendingFollowers;

	// Token: 0x04002B8C RID: 11148
	public KscEntityHandle PossessedFollowerHandle;

	// Token: 0x04002B8D RID: 11149
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, TowerDefenseFollowerProxy> PossessedFollowerProxies;

	// Token: 0x04002B8E RID: 11150
	public int? CurrentFollowerProxyId;

	// Token: 0x04002B8F RID: 11151
	public bool CurrentFollowerEnable;

	// Token: 0x04002B90 RID: 11152
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, TDPlayerDefine.ISkill> AllSkillId2SkillData;

	// Token: 0x04002B91 RID: 11153
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Dictionary<EKSC_OperateType, List<TDPlayerDefine.ISkill>> BindFollowerSkills;

	// Token: 0x04002B92 RID: 11154
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, TDPlayerDefine.ISkill> SkillId2SkillData;

	// Token: 0x04002B93 RID: 11155
	public TDPlayerDefine.ISkill ChargeSkill;

	// Token: 0x04002B94 RID: 11156
	public bool LastSkillChargeFull;

	// Token: 0x04002B95 RID: 11157
	public int ChargeCueHandle;

	// Token: 0x04002B96 RID: 11158
	public List<int> FollowCueHandle;

	// Token: 0x04002B97 RID: 11159
	public List<int> FollowerCdCueHandle;

	// Token: 0x04002B98 RID: 11160
	public TDPlayerDefine.EFollowerState FollowerState;

	// Token: 0x04002B99 RID: 11161
	public string PsFeedbackId;

	// Token: 0x04002B9A RID: 11162
	public bool IsInAutoCast;

	// Token: 0x04002B9B RID: 11163
	public bool IsInCharge;

	// Token: 0x04002B9C RID: 11164
	public bool IsInFollowerInit;
}
