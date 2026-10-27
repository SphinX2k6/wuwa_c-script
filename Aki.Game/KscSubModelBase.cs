using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E89 RID: 3721
[NullableContext(1)]
[Nullable(0)]
public class KscSubModelBase
{
	// Token: 0x06005B1D RID: 23325 RVA: 0x0010A3A7 File Offset: 0x001085A7
	public virtual string GetSkillDtPath()
	{
		return "";
	}

	// Token: 0x06005B1E RID: 23326 RVA: 0x0010A3AE File Offset: 0x001085AE
	public virtual string GetEntityDtPath()
	{
		return "";
	}

	// Token: 0x06005B1F RID: 23327 RVA: 0x0010A3B5 File Offset: 0x001085B5
	public bool Init()
	{
		return this.OnInit();
	}

	// Token: 0x06005B20 RID: 23328 RVA: 0x0010A3C0 File Offset: 0x001085C0
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

	// Token: 0x06005B21 RID: 23329 RVA: 0x0010A425 File Offset: 0x00108625
	protected virtual bool OnInit()
	{
		return true;
	}

	// Token: 0x06005B22 RID: 23330 RVA: 0x0010A428 File Offset: 0x00108628
	protected virtual bool OnClear()
	{
		return true;
	}

	// Token: 0x170006A8 RID: 1704
	// (get) Token: 0x06005B23 RID: 23331 RVA: 0x0010A42B File Offset: 0x0010862B
	public EKscGameplayType GameplayType
	{
		get
		{
			return this.KscGameplayType;
		}
	}

	// Token: 0x06005B24 RID: 23332 RVA: 0x0010A433 File Offset: 0x00108633
	public void SetLogicProxy(long creatureId, int kscEntityId)
	{
		this.LogicProxy[creatureId] = kscEntityId;
	}

	// Token: 0x06005B25 RID: 23333 RVA: 0x0010A444 File Offset: 0x00108644
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

	// Token: 0x06005B26 RID: 23334 RVA: 0x0010A490 File Offset: 0x00108690
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

	// Token: 0x06005B27 RID: 23335 RVA: 0x0010A4C9 File Offset: 0x001086C9
	public bool RemoveLogicProxy(long creatureId)
	{
		return this.LogicProxy.Remove(creatureId);
	}

	// Token: 0x06005B28 RID: 23336 RVA: 0x0010A4D7 File Offset: 0x001086D7
	public List<long> GetAllEntityIds()
	{
		return new List<long>(this.LogicProxy.Keys);
	}

	// Token: 0x06005B29 RID: 23337 RVA: 0x0010A4EC File Offset: 0x001086EC
	public long GetEntityCreatureId(int kscEntityId)
	{
		KscEntityHandle kscEntityHandle;
		if (this.KscEntities.TryGetValue(kscEntityId, out kscEntityHandle) && kscEntityHandle != null && kscEntityHandle.Valid)
		{
			return kscEntityHandle.CreatureDataId;
		}
		return 0L;
	}

	// Token: 0x06005B2A RID: 23338 RVA: 0x0010A520 File Offset: 0x00108720
	public string GetEntityPathById(int id)
	{
		ValueTuple<FKSCEntityTableRow, string> valueTuple;
		if (this.EntityDataDt.TryGetValue(id, out valueTuple))
		{
			return valueTuple.Item2;
		}
		return null;
	}

	// Token: 0x06005B2B RID: 23339 RVA: 0x0010A548 File Offset: 0x00108748
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

	// Token: 0x06005B2C RID: 23340 RVA: 0x0010A658 File Offset: 0x00108858
	public bool IsMapLoadOrWorldDone()
	{
		return this.KscInitState == EKscInitState.MapLoad || this.KscInitState == EKscInitState.WorldDone;
	}

	// Token: 0x06005B2D RID: 23341 RVA: 0x0010A66E File Offset: 0x0010886E
	public virtual bool IsCreatureIdValid(int creatureId)
	{
		return false;
	}

	// Token: 0x04002991 RID: 10641
	public EKscGameplayType KscGameplayType;

	// Token: 0x04002992 RID: 10642
	public readonly Dictionary<int, KSCBaseProperty> PropertyConfigs = new Dictionary<int, KSCBaseProperty>();

	// Token: 0x04002993 RID: 10643
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	public readonly Dictionary<int, ValueTuple<FKSCSkillTableRow, string>> SkillDataDt = new Dictionary<int, ValueTuple<FKSCSkillTableRow, string>>();

	// Token: 0x04002994 RID: 10644
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	public readonly Dictionary<int, ValueTuple<FKSCEntityTableRow, string>> EntityDataDt = new Dictionary<int, ValueTuple<FKSCEntityTableRow, string>>();

	// Token: 0x04002995 RID: 10645
	private readonly Dictionary<long, int> LogicProxy = new Dictionary<long, int>();

	// Token: 0x04002996 RID: 10646
	public readonly UiAsyncTaskManager EntityProcessMgr = new UiAsyncTaskManager();

	// Token: 0x04002997 RID: 10647
	public Dictionary<int, KscEntityHandle> KscEntities = new Dictionary<int, KscEntityHandle>();

	// Token: 0x04002998 RID: 10648
	public Dictionary<int, FKSCDamage> DamageIds = new Dictionary<int, FKSCDamage>();

	// Token: 0x04002999 RID: 10649
	[Nullable(2)]
	public UKuroFastCollisionAlgorithm KfcAlgorithm;

	// Token: 0x0400299A RID: 10650
	public AKSC_Entity KscPlayerEntity;

	// Token: 0x0400299B RID: 10651
	public long KscPlayerCreatureDataId;

	// Token: 0x0400299C RID: 10652
	public int KscPlayerEntityId;

	// Token: 0x0400299D RID: 10653
	public KscHeadStateData KscPlayerHeadStateData;

	// Token: 0x0400299E RID: 10654
	public float NextPlayerHpSyncTime;

	// Token: 0x0400299F RID: 10655
	public bool IsHpModify;

	// Token: 0x040029A0 RID: 10656
	public EKscInitState KscInitState;
}
