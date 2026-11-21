using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200033E RID: 830
[NullableContext(1)]
[Nullable(0)]
public class KscSubModelBase
{
	// Token: 0x06002EB4 RID: 11956 RVA: 0x0011203F File Offset: 0x0011023F
	public virtual string GetSkillDtPath()
	{
		return "";
	}

	// Token: 0x06002EB5 RID: 11957 RVA: 0x00112046 File Offset: 0x00110246
	public virtual string GetEntityDtPath()
	{
		return "";
	}

	// Token: 0x06002EB6 RID: 11958 RVA: 0x0011204D File Offset: 0x0011024D
	public bool Init()
	{
		return this.OnInit();
	}

	// Token: 0x06002EB7 RID: 11959 RVA: 0x00112058 File Offset: 0x00110258
	public bool Clear()
	{
		this.PropertyConfigs.Clear();
		this.SkillDataDt.Clear();
		this.EntityDataDt.Clear();
		this.LogicProxy.Clear();
		this.KscEntities.Clear();
		this.DamageIds.Clear();
		this.SetKscPlayerEntity(null, 0L);
		this.KscInitState = EKscInitState.None;
		return this.OnClear();
	}

	// Token: 0x06002EB8 RID: 11960 RVA: 0x001120BD File Offset: 0x001102BD
	protected virtual bool OnInit()
	{
		return true;
	}

	// Token: 0x06002EB9 RID: 11961 RVA: 0x001120C0 File Offset: 0x001102C0
	protected virtual bool OnClear()
	{
		return true;
	}

	// Token: 0x170006CC RID: 1740
	// (get) Token: 0x06002EBA RID: 11962 RVA: 0x001120C3 File Offset: 0x001102C3
	public EKscGameplayType GameplayType
	{
		get
		{
			return this.KscGameplayType;
		}
	}

	// Token: 0x06002EBB RID: 11963 RVA: 0x001120CB File Offset: 0x001102CB
	public void SetLogicProxy(long creatureId, int kscEntityId)
	{
		this.LogicProxy[creatureId] = kscEntityId;
	}

	// Token: 0x06002EBC RID: 11964 RVA: 0x001120DC File Offset: 0x001102DC
	public int? GetLogicProxy(long creatureId)
	{
		if (this.LogicProxy == null || this.LogicProxy.Count == 0)
		{
			return null;
		}
		int value;
		if (!this.LogicProxy.TryGetValue(creatureId, out value))
		{
			return null;
		}
		return new int?(value);
	}

	// Token: 0x06002EBD RID: 11965 RVA: 0x00112128 File Offset: 0x00110328
	public KscEntityHandle GetKscEntityHandle(long creatureId)
	{
		int? logicProxy = this.GetLogicProxy(creatureId);
		if (logicProxy == null)
		{
			return null;
		}
		KscEntityHandle result;
		if (!this.KscEntities.TryGetValue(logicProxy.Value, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06002EBE RID: 11966 RVA: 0x00112161 File Offset: 0x00110361
	public bool RemoveLogicProxy(long creatureId)
	{
		return this.LogicProxy.Remove(creatureId);
	}

	// Token: 0x06002EBF RID: 11967 RVA: 0x0011216F File Offset: 0x0011036F
	public List<long> GetAllEntityIds()
	{
		return new List<long>(this.LogicProxy.Keys);
	}

	// Token: 0x06002EC0 RID: 11968 RVA: 0x00112184 File Offset: 0x00110384
	public long GetEntityCreatureId(int kscEntityId)
	{
		KscEntityHandle kscEntityHandle;
		if (this.KscEntities.TryGetValue(kscEntityId, out kscEntityHandle) && kscEntityHandle != null && kscEntityHandle.Valid)
		{
			return kscEntityHandle.CreatureDataId;
		}
		return 0L;
	}

	// Token: 0x06002EC1 RID: 11969 RVA: 0x001121B8 File Offset: 0x001103B8
	public string GetEntityPathById(int id)
	{
		ValueTuple<FKSCEntityTableRow, string> valueTuple;
		if (this.EntityDataDt.TryGetValue(id, out valueTuple))
		{
			return valueTuple.Item2;
		}
		return null;
	}

	// Token: 0x06002EC2 RID: 11970 RVA: 0x001121E0 File Offset: 0x001103E0
	public void SetKscPlayerEntity(AKSC_Entity kscPlayerEntity, long creatureDataId)
	{
		this.KscPlayerEntity = kscPlayerEntity;
		this.NextPlayerHpSyncTime = 0f;
		this.IsHpModify = false;
		if (kscPlayerEntity == null)
		{
			this.KscPlayerEntityId = 0;
			this.KscPlayerCreatureDataId = 0L;
			this.KscPlayerHeadStateData = null;
			EventSystem.Instance.Emit(EEventName.OnKscPlayerHpChanged);
			return;
		}
		this.KscPlayerEntityId = kscPlayerEntity.EntityId_;
		this.KscPlayerCreatureDataId = creatureDataId;
		this.KscPlayerHeadStateData = new KscHeadStateData();
		this.KscPlayerHeadStateData.EntityId = this.KscPlayerEntityId;
		UKSC_SkillComp skillComp = kscPlayerEntity.GetSkillComp();
		TMap<EKSC_AttrType, int> tmap;
		if (skillComp == null)
		{
			tmap = null;
		}
		else
		{
			UKSC_AttrSet attrSet_ = skillComp.AttrSet_;
			tmap = ((attrSet_ != null) ? attrSet_.Attrs_ : null);
		}
		TMap<EKSC_AttrType, int> tmap2 = tmap;
		if (tmap2 != null)
		{
			this.KscPlayerHeadStateData.MaxHp = tmap2.GetValueOrDefault(EKSC_AttrType.LifeMax, 0);
			this.KscPlayerHeadStateData.Hp = tmap2.GetValueOrDefault(EKSC_AttrType.Life, 0);
			this.KscPlayerHeadStateData.Shield = tmap2.GetValueOrDefault(EKSC_AttrType.Shield, 0);
		}
		else
		{
			this.KscPlayerHeadStateData.MaxHp = 0;
			this.KscPlayerHeadStateData.Hp = 0;
			this.KscPlayerHeadStateData.Shield = 0;
		}
		EventSystem.Instance.Emit(EEventName.OnKscPlayerHpChanged);
	}

	// Token: 0x06002EC3 RID: 11971 RVA: 0x001122F0 File Offset: 0x001104F0
	public bool IsMapLoadOrWorldDone()
	{
		return this.KscInitState == EKscInitState.MapLoad || this.KscInitState == EKscInitState.WorldDone;
	}

	// Token: 0x06002EC4 RID: 11972 RVA: 0x00112306 File Offset: 0x00110506
	public virtual bool IsCreatureIdValid(int creatureId)
	{
		return false;
	}

	// Token: 0x04002A2C RID: 10796
	public EKscGameplayType KscGameplayType;

	// Token: 0x04002A2D RID: 10797
	public readonly Dictionary<int, KSCBaseProperty> PropertyConfigs = new Dictionary<int, KSCBaseProperty>();

	// Token: 0x04002A2E RID: 10798
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	public readonly Dictionary<int, ValueTuple<FKSCSkillTableRow, string>> SkillDataDt = new Dictionary<int, ValueTuple<FKSCSkillTableRow, string>>();

	// Token: 0x04002A2F RID: 10799
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	public readonly Dictionary<int, ValueTuple<FKSCEntityTableRow, string>> EntityDataDt = new Dictionary<int, ValueTuple<FKSCEntityTableRow, string>>();

	// Token: 0x04002A30 RID: 10800
	private readonly Dictionary<long, int> LogicProxy = new Dictionary<long, int>();

	// Token: 0x04002A31 RID: 10801
	public readonly UiAsyncTaskManager EntityProcessMgr = new UiAsyncTaskManager();

	// Token: 0x04002A32 RID: 10802
	public Dictionary<int, KscEntityHandle> KscEntities = new Dictionary<int, KscEntityHandle>();

	// Token: 0x04002A33 RID: 10803
	public Dictionary<int, FKSCDamage> DamageIds = new Dictionary<int, FKSCDamage>();

	// Token: 0x04002A34 RID: 10804
	[Nullable(2)]
	public UKuroFastCollisionAlgorithm KfcAlgorithm;

	// Token: 0x04002A35 RID: 10805
	public AKSC_Entity KscPlayerEntity;

	// Token: 0x04002A36 RID: 10806
	public long KscPlayerCreatureDataId;

	// Token: 0x04002A37 RID: 10807
	public int KscPlayerEntityId;

	// Token: 0x04002A38 RID: 10808
	public KscHeadStateData KscPlayerHeadStateData;

	// Token: 0x04002A39 RID: 10809
	public float NextPlayerHpSyncTime;

	// Token: 0x04002A3A RID: 10810
	public bool IsHpModify;

	// Token: 0x04002A3B RID: 10811
	public EKscInitState KscInitState;
}
