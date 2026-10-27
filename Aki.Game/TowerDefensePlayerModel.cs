using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.KuroSimpleCombat;
using UnrealEngine;

// Token: 0x02000ED4 RID: 3796
[NullableContext(2)]
[Nullable(0)]
public class TowerDefensePlayerModel
{
	// Token: 0x1700073F RID: 1855
	// (get) Token: 0x06005EAB RID: 24235 RVA: 0x00119A0C File Offset: 0x00117C0C
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

	// Token: 0x17000740 RID: 1856
	// (get) Token: 0x06005EAC RID: 24236 RVA: 0x00119AB0 File Offset: 0x00117CB0
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

	// Token: 0x17000741 RID: 1857
	// (get) Token: 0x06005EAD RID: 24237 RVA: 0x00119B70 File Offset: 0x00117D70
	public bool PossessedFollowerEnabled
	{
		get
		{
			Entity possessedFollowerEntity = this.PossessedFollowerEntity;
			return possessedFollowerEntity != null && !possessedFollowerEntity.HasDisableKey(EEntityDisableKey.SetEntityEnable);
		}
	}

	// Token: 0x17000742 RID: 1858
	// (get) Token: 0x06005EAE RID: 24238 RVA: 0x00119B93 File Offset: 0x00117D93
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

	// Token: 0x06005EAF RID: 24239 RVA: 0x00119BB4 File Offset: 0x00117DB4
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

	// Token: 0x04002AE9 RID: 10985
	public static readonly int PlayerEntityKey = 1001;

	// Token: 0x04002AEA RID: 10986
	public static readonly int FollowerEntityKey = 1002;

	// Token: 0x04002AEB RID: 10987
	public bool TowerDefenseWorldDone;

	// Token: 0x04002AEC RID: 10988
	public bool HasInitKSCEntity;

	// Token: 0x04002AED RID: 10989
	public EntityHandle PendingRoleHandle;

	// Token: 0x04002AEE RID: 10990
	public KscEntityHandle PossessedPlayerHandle;

	// Token: 0x04002AEF RID: 10991
	public long? PendingFollowerCreatureId;

	// Token: 0x04002AF0 RID: 10992
	public int[] PendingFollowers;

	// Token: 0x04002AF1 RID: 10993
	public KscEntityHandle PossessedFollowerHandle;

	// Token: 0x04002AF2 RID: 10994
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, TowerDefenseFollowerProxy> PossessedFollowerProxies;

	// Token: 0x04002AF3 RID: 10995
	public int? CurrentFollowerProxyId;

	// Token: 0x04002AF4 RID: 10996
	public bool CurrentFollowerEnable;

	// Token: 0x04002AF5 RID: 10997
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, TDPlayerDefine.ISkill> AllSkillId2SkillData;

	// Token: 0x04002AF6 RID: 10998
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Dictionary<EKSC_OperateType, List<TDPlayerDefine.ISkill>> BindFollowerSkills;

	// Token: 0x04002AF7 RID: 10999
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, TDPlayerDefine.ISkill> SkillId2SkillData;

	// Token: 0x04002AF8 RID: 11000
	public TDPlayerDefine.ISkill ChargeSkill;

	// Token: 0x04002AF9 RID: 11001
	public bool LastSkillChargeFull;

	// Token: 0x04002AFA RID: 11002
	public int ChargeCueHandle;

	// Token: 0x04002AFB RID: 11003
	public List<int> FollowCueHandle;

	// Token: 0x04002AFC RID: 11004
	public List<int> FollowerCdCueHandle;

	// Token: 0x04002AFD RID: 11005
	public TDPlayerDefine.EFollowerState FollowerState;

	// Token: 0x04002AFE RID: 11006
	public string PsFeedbackId;

	// Token: 0x04002AFF RID: 11007
	public bool IsInAutoCast;

	// Token: 0x04002B00 RID: 11008
	public bool IsInCharge;

	// Token: 0x04002B01 RID: 11009
	public bool IsInFollowerInit;
}
