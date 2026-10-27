using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002FB6 RID: 12214
[NullableContext(1)]
[Nullable(0)]
public abstract class GameplayCueBase
{
	// Token: 0x170023B7 RID: 9143
	// (get) Token: 0x06019E3F RID: 106047 RVA: 0x006C4EF7 File Offset: 0x006C30F7
	// (set) Token: 0x06019E40 RID: 106048 RVA: 0x006C4EFF File Offset: 0x006C30FF
	public GameplayCueParam InitCueParam { get; set; }

	// Token: 0x170023B8 RID: 9144
	// (get) Token: 0x06019E41 RID: 106049 RVA: 0x006C4F08 File Offset: 0x006C3108
	public int Handle
	{
		get
		{
			return this.HandleInternal;
		}
	}

	// Token: 0x06019E42 RID: 106050 RVA: 0x006C4F10 File Offset: 0x006C3110
	protected virtual void OnInit()
	{
	}

	// Token: 0x06019E43 RID: 106051 RVA: 0x006C4F12 File Offset: 0x006C3112
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x06019E44 RID: 106052 RVA: 0x006C4F14 File Offset: 0x006C3114
	protected virtual void OnAfterTick(float delta)
	{
	}

	// Token: 0x06019E45 RID: 106053 RVA: 0x006C4F16 File Offset: 0x006C3116
	protected virtual void OnCreate()
	{
	}

	// Token: 0x06019E46 RID: 106054 RVA: 0x006C4F18 File Offset: 0x006C3118
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x06019E47 RID: 106055 RVA: 0x006C4F1A File Offset: 0x006C311A
	public virtual void OnEnable()
	{
	}

	// Token: 0x06019E48 RID: 106056 RVA: 0x006C4F1C File Offset: 0x006C311C
	public virtual void OnGameplayCueEffectOverride(IGameplayCueEffectOverride @override)
	{
	}

	// Token: 0x06019E49 RID: 106057 RVA: 0x006C4F1E File Offset: 0x006C311E
	public virtual void OnDisable()
	{
	}

	// Token: 0x06019E4A RID: 106058 RVA: 0x006C4F20 File Offset: 0x006C3120
	protected virtual void OnChangeBuffHandle(int oldHandle, int cueHandleId)
	{
	}

	// Token: 0x06019E4B RID: 106059 RVA: 0x006C4F22 File Offset: 0x006C3122
	public virtual void OnChangeRole(EntityHandle newEntityHandle)
	{
		this.EntityHandle = newEntityHandle;
		this.ActorInternal = newEntityHandle.Entity.GetComponent<CharacterActorComponent>().Actor;
	}

	// Token: 0x06019E4C RID: 106060 RVA: 0x006C4F41 File Offset: 0x006C3141
	public static bool IsSingleInstance()
	{
		return true;
	}

	// Token: 0x06019E4D RID: 106061 RVA: 0x006C4F44 File Offset: 0x006C3144
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

	// Token: 0x06019E4E RID: 106062 RVA: 0x006C5014 File Offset: 0x006C3214
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

	// Token: 0x06019E4F RID: 106063 RVA: 0x006C504B File Offset: 0x006C324B
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

	// Token: 0x06019E50 RID: 106064 RVA: 0x006C5082 File Offset: 0x006C3282
	public void Tick(float delta)
	{
		if (this.IsActive)
		{
			this.OnTick(delta);
		}
	}

	// Token: 0x06019E51 RID: 106065 RVA: 0x006C5093 File Offset: 0x006C3293
	public void AfterTick(float delta)
	{
		if (!this.IsActive)
		{
			return;
		}
		this.OnAfterTick(delta);
	}

	// Token: 0x06019E52 RID: 106066 RVA: 0x006C50A5 File Offset: 0x006C32A5
	public void Add(long cueHandleId, int buffHandleId = 0)
	{
		this.CueHandleIds.Add(cueHandleId);
	}

	// Token: 0x06019E53 RID: 106067 RVA: 0x006C50B4 File Offset: 0x006C32B4
	public void Remove(long cueHandleId)
	{
		this.CueHandleIds.Remove(cueHandleId);
	}

	// Token: 0x06019E54 RID: 106068 RVA: 0x006C50C4 File Offset: 0x006C32C4
	public void ChangeBuffHandle(int newBuffHandle)
	{
		if (this.BuffHandleId != newBuffHandle)
		{
			int buffHandleId = this.BuffHandleId;
			this.BuffHandleId = newBuffHandle;
			this.OnChangeBuffHandle(buffHandleId, newBuffHandle);
		}
	}

	// Token: 0x06019E55 RID: 106069 RVA: 0x006C50F0 File Offset: 0x006C32F0
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

	// Token: 0x06019E56 RID: 106070 RVA: 0x006C513C File Offset: 0x006C333C
	protected BaseActorComponent GetActorComponent()
	{
		if (this.EntityHandle.EntityType == 10)
		{
			return (this.ActorInternal as TsBaseVehicle).VehicleActorComponent;
		}
		return (this.ActorInternal as TsBaseCharacter).CharacterActorComponent;
	}

	// Token: 0x06019E57 RID: 106071 RVA: 0x006C5170 File Offset: 0x006C3370
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

	// Token: 0x0400C3D8 RID: 50136
	public long? BuffId;

	// Token: 0x0400C3D9 RID: 50137
	public int BuffHandleId;

	// Token: 0x0400C3DA RID: 50138
	public HashSet<long> CueHandleIds = new HashSet<long>();

	// Token: 0x0400C3DB RID: 50139
	public bool IsActive;

	// Token: 0x0400C3DD RID: 50141
	private int HandleInternal;

	// Token: 0x0400C3DE RID: 50142
	public GameplayCue CueConfig;

	// Token: 0x0400C3DF RID: 50143
	public EntityHandle EntityHandle;

	// Token: 0x0400C3E0 RID: 50144
	protected ABaseCharacter ActorInternal;

	// Token: 0x0400C3E1 RID: 50145
	protected BaseGameplayCueComponent CueComp;

	// Token: 0x0400C3E2 RID: 50146
	protected bool IsInstant;

	// Token: 0x0400C3E3 RID: 50147
	[Nullable(2)]
	protected Action BeginCallback;

	// Token: 0x0400C3E4 RID: 50148
	[Nullable(2)]
	protected Action EndCallback;

	// Token: 0x0400C3E5 RID: 50149
	[Nullable(2)]
	protected EntityHandle Instigator;
}
