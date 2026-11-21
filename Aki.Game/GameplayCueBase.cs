using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200250A RID: 9482
[NullableContext(1)]
[Nullable(0)]
public abstract class GameplayCueBase
{
	// Token: 0x17002479 RID: 9337
	// (get) Token: 0x06017750 RID: 96080 RVA: 0x006EB7A3 File Offset: 0x006E99A3
	// (set) Token: 0x06017751 RID: 96081 RVA: 0x006EB7AB File Offset: 0x006E99AB
	public GameplayCueParam InitCueParam { get; set; }

	// Token: 0x1700247A RID: 9338
	// (get) Token: 0x06017752 RID: 96082 RVA: 0x006EB7B4 File Offset: 0x006E99B4
	public int Handle
	{
		get
		{
			return this.HandleInternal;
		}
	}

	// Token: 0x06017753 RID: 96083 RVA: 0x006EB7BC File Offset: 0x006E99BC
	protected virtual void OnInit()
	{
	}

	// Token: 0x06017754 RID: 96084 RVA: 0x006EB7BE File Offset: 0x006E99BE
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x06017755 RID: 96085 RVA: 0x006EB7C0 File Offset: 0x006E99C0
	protected virtual void OnAfterTick(float delta)
	{
	}

	// Token: 0x06017756 RID: 96086 RVA: 0x006EB7C2 File Offset: 0x006E99C2
	protected virtual void OnCreate()
	{
	}

	// Token: 0x06017757 RID: 96087 RVA: 0x006EB7C4 File Offset: 0x006E99C4
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x06017758 RID: 96088 RVA: 0x006EB7C6 File Offset: 0x006E99C6
	public virtual void OnEnable()
	{
	}

	// Token: 0x06017759 RID: 96089 RVA: 0x006EB7C8 File Offset: 0x006E99C8
	public virtual void OnGameplayCueEffectOverride(IGameplayCueEffectOverride @override)
	{
	}

	// Token: 0x0601775A RID: 96090 RVA: 0x006EB7CA File Offset: 0x006E99CA
	public virtual void OnDisable()
	{
	}

	// Token: 0x0601775B RID: 96091 RVA: 0x006EB7CC File Offset: 0x006E99CC
	protected virtual void OnChangeBuffHandle(int oldHandle, int cueHandleId)
	{
	}

	// Token: 0x0601775C RID: 96092 RVA: 0x006EB7CE File Offset: 0x006E99CE
	public virtual void OnChangeRole(EntityHandle newEntityHandle)
	{
		this.EntityHandle = newEntityHandle;
		this.ActorInternal = newEntityHandle.Entity.GetComponent<CharacterActorComponent>().Actor;
	}

	// Token: 0x0601775D RID: 96093 RVA: 0x006EB7ED File Offset: 0x006E99ED
	public static bool IsSingleInstance()
	{
		return true;
	}

	// Token: 0x0601775E RID: 96094 RVA: 0x006EB7F0 File Offset: 0x006E99F0
	public static GameplayCueBase Spawn(Func<GameplayCueBase> Spawner, in GameplayCueParam param)
	{
		GameplayCueBase gameplayCueBase = Spawner();
		gameplayCueBase.CueConfig = param.CueConfig;
		gameplayCueBase.EntityHandle = param.EntityHandle;
		gameplayCueBase.ActorInternal = (param.EntityHandle.Entity.GetComponent<BaseActorComponent>().Owner as ABaseCharacter);
		gameplayCueBase.CueComp = param.CueComp;
		gameplayCueBase.IsInstant = param.Instant;
		gameplayCueBase.BeginCallback = param.BeginCallback;
		gameplayCueBase.EndCallback = param.EndCallback;
		gameplayCueBase.Instigator = param.Instigator;
		if (param.Buff != null)
		{
			gameplayCueBase.BuffHandleId = param.Buff.Handle;
			gameplayCueBase.BuffId = new long?(param.Buff.Id);
		}
		gameplayCueBase.InitCueParam = param;
		gameplayCueBase.OnInit();
		gameplayCueBase.Create();
		return gameplayCueBase;
	}

	// Token: 0x0601775F RID: 96095 RVA: 0x006EB8C0 File Offset: 0x006E9AC0
	private void Create()
	{
		if (this.IsActive)
		{
			return;
		}
		this.IsActive = true;
		this.OnCreate();
		EventSystem.Instance.EmitWithTarget<bool, long>(this.EntityHandle, EEventName.CharGameplayCueChanged, true, this.CueConfig.Id);
	}

	// Token: 0x06017760 RID: 96096 RVA: 0x006EB8F7 File Offset: 0x006E9AF7
	public void Destroy()
	{
		if (!this.IsActive)
		{
			return;
		}
		this.IsActive = false;
		this.OnDestroy();
		EventSystem.Instance.EmitWithTarget<bool, long>(this.EntityHandle, EEventName.CharGameplayCueChanged, false, this.CueConfig.Id);
	}

	// Token: 0x06017761 RID: 96097 RVA: 0x006EB92E File Offset: 0x006E9B2E
	public void Tick(float delta)
	{
		if (this.IsActive)
		{
			this.OnTick(delta);
		}
	}

	// Token: 0x06017762 RID: 96098 RVA: 0x006EB93F File Offset: 0x006E9B3F
	public void AfterTick(float delta)
	{
		if (!this.IsActive)
		{
			return;
		}
		this.OnAfterTick(delta);
	}

	// Token: 0x06017763 RID: 96099 RVA: 0x006EB951 File Offset: 0x006E9B51
	public void Add(long cueHandleId, int buffHandleId = 0)
	{
		this.CueHandleIds.Add(cueHandleId);
	}

	// Token: 0x06017764 RID: 96100 RVA: 0x006EB960 File Offset: 0x006E9B60
	public void Remove(long cueHandleId)
	{
		this.CueHandleIds.Remove(cueHandleId);
	}

	// Token: 0x06017765 RID: 96101 RVA: 0x006EB970 File Offset: 0x006E9B70
	public void ChangeBuffHandle(int newBuffHandle)
	{
		if (this.BuffHandleId != newBuffHandle)
		{
			int buffHandleId = this.BuffHandleId;
			this.BuffHandleId = newBuffHandle;
			this.OnChangeBuffHandle(buffHandleId, newBuffHandle);
		}
	}

	// Token: 0x06017766 RID: 96102 RVA: 0x006EB99C File Offset: 0x006E9B9C
	public bool IsActorValid()
	{
		return this.ActorInternal != null && this.ActorInternal.IsValid();
	}

	// Token: 0x06017767 RID: 96103 RVA: 0x006EB9B4 File Offset: 0x006E9BB4
	protected string GetPath()
	{
		string text = null;
		WorldEntity entity = this.EntityHandle.Entity;
		BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
		if (baseActorComponent != null)
		{
			text = baseActorComponent.GetReplaceEffect(this.CueConfig.Path);
		}
		return text ?? this.CueConfig.Path;
	}

	// Token: 0x06017768 RID: 96104 RVA: 0x006EBA00 File Offset: 0x006E9C00
	protected BaseActorComponent GetActorComponent()
	{
		if (this.EntityHandle.EntityType == 10)
		{
			return (this.ActorInternal as TsBaseVehicle).VehicleActorComponent;
		}
		return (this.ActorInternal as TsBaseCharacter).CharacterActorComponent;
	}

	// Token: 0x06017769 RID: 96105 RVA: 0x006EBA34 File Offset: 0x006E9C34
	[NullableContext(2)]
	protected CharRenderingComponent GetCharRenderingComponent()
	{
		TsBaseCharacter tsBaseCharacter = this.ActorInternal as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			return tsBaseCharacter.CharRenderingComponent;
		}
		TsBaseVehicle tsBaseVehicle = this.ActorInternal as TsBaseVehicle;
		if (tsBaseVehicle != null)
		{
			return tsBaseVehicle.CharRenderingComponent;
		}
		return null;
	}

	// Token: 0x0400C781 RID: 51073
	public long? BuffId;

	// Token: 0x0400C782 RID: 51074
	public int BuffHandleId;

	// Token: 0x0400C783 RID: 51075
	public HashSet<long> CueHandleIds = new HashSet<long>();

	// Token: 0x0400C784 RID: 51076
	public bool IsActive;

	// Token: 0x0400C786 RID: 51078
	private int HandleInternal;

	// Token: 0x0400C787 RID: 51079
	public GameplayCue CueConfig;

	// Token: 0x0400C788 RID: 51080
	public EntityHandle EntityHandle;

	// Token: 0x0400C789 RID: 51081
	protected ABaseCharacter ActorInternal;

	// Token: 0x0400C78A RID: 51082
	protected BaseGameplayCueComponent CueComp;

	// Token: 0x0400C78B RID: 51083
	protected bool IsInstant;

	// Token: 0x0400C78C RID: 51084
	[Nullable(2)]
	protected Action BeginCallback;

	// Token: 0x0400C78D RID: 51085
	[Nullable(2)]
	protected Action EndCallback;

	// Token: 0x0400C78E RID: 51086
	[Nullable(2)]
	protected EntityHandle Instigator;
}
