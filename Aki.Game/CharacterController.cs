using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002E31 RID: 11825
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class CharacterController : ControllerBase
{
	// Token: 0x17002281 RID: 8833
	// (get) Token: 0x06018E73 RID: 102003 RVA: 0x0066B4DC File Offset: 0x006696DC
	protected override bool IsTickEvenPausedInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06018E74 RID: 102004 RVA: 0x0066B4DF File Offset: 0x006696DF
	protected override bool OnInit()
	{
		this.LastDate = new DateTime?(DateTime.Now);
		return true;
	}

	// Token: 0x06018E75 RID: 102005 RVA: 0x0066B4F2 File Offset: 0x006696F2
	protected override void OnTick(float deltaTime)
	{
		if (!this.IsQueueEmpty())
		{
			this.ConsumeQueue();
		}
		if (Net.Instance.IsFinishLogin())
		{
			this.TestMessage();
		}
	}

	// Token: 0x06018E76 RID: 102006 RVA: 0x0066B518 File Offset: 0x00669718
	private UniTask TestMessage()
	{
		CharacterController.<TestMessage>d__6 <TestMessage>d__;
		<TestMessage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TestMessage>d__.<>4__this = this;
		<TestMessage>d__.<>1__state = -1;
		<TestMessage>d__.<>t__builder.Start<CharacterController.<TestMessage>d__6>(ref <TestMessage>d__);
		return <TestMessage>d__.<>t__builder.Task;
	}

	// Token: 0x06018E77 RID: 102007 RVA: 0x0066B55B File Offset: 0x0066975B
	private bool IsQueueEmpty()
	{
		return this.IsEmpty();
	}

	// Token: 0x06018E78 RID: 102008 RVA: 0x0066B563 File Offset: 0x00669763
	private void ConsumeQueue()
	{
		this.AwakeEntity();
	}

	// Token: 0x06018E79 RID: 102009 RVA: 0x0066B56B File Offset: 0x0066976B
	public bool InitData<[Nullable(0)] T>(EntityHandle handle, T entity, [Nullable(2)] IEntityArgs args = null) where T : Entity
	{
		if (!EntitySystem.Instance.InitData<T>(entity, args))
		{
			CharacterModel.Instance.ClearHandle(handle);
			return false;
		}
		return true;
	}

	// Token: 0x06018E7A RID: 102010 RVA: 0x0066B589 File Offset: 0x00669789
	public bool Respawn<[Nullable(0)] T>(EntityHandle handle, T entity, int priority = 0, [Nullable(2)] IEntityArgs args = null) where T : Entity
	{
		if (!EntitySystem.Instance.Respawn<T>(entity, true, priority, args))
		{
			CharacterModel.Instance.ClearHandle(handle);
			return false;
		}
		return true;
	}

	// Token: 0x06018E7B RID: 102011 RVA: 0x0066B5AC File Offset: 0x006697AC
	public unsafe void AddEntityToAwakeQueue(EntityHandle handle, Action<bool> callback)
	{
		CharacterController.<>c__DisplayClass11_0 CS$<>8__locals1 = new CharacterController.<>c__DisplayClass11_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.handle = handle;
		CS$<>8__locals1.callback = callback;
		if (CreatureModel.Instance.EnableEntityLog)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[实体生命周期:创建实体] 进入唤醒队列";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", CS$<>8__locals1.handle.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CreatureDataId", CS$<>8__locals1.handle.CreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PbDataId", CS$<>8__locals1.handle.PbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Priority", CS$<>8__locals1.handle.Priority);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
		CS$<>8__locals1.initSuccess = false;
		CharacterModel.Instance.PushAwakeHandler(CS$<>8__locals1.handle, new Func<bool>(CS$<>8__locals1.<AddEntityToAwakeQueue>g__initHandle|0), new Func<bool>(CS$<>8__locals1.<AddEntityToAwakeQueue>g__startHandle|1));
	}

	// Token: 0x06018E7C RID: 102012 RVA: 0x0066B6D0 File Offset: 0x006698D0
	public unsafe bool InitEntity(EntityHandle handle)
	{
		if (!handle.Valid)
		{
			return false;
		}
		Entity entity = handle.Entity;
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		if (component.GetRemoveState())
		{
			return false;
		}
		if (!EntitySystem.Instance.Init(entity))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[实体生命周期:创建实体] 实体执行Init失败，创建实体失败。";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", handle.CreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", handle.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PbDataId", component.GetPbDataId());
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			EventSystem.Instance.Emit<long>(EEventName.CreateEntityFail, handle.CreatureDataId);
			return false;
		}
		if (CreatureModel.Instance.EnableEntityLog)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "[实体生命周期:创建实体] 实体执行Init成功";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CreatureDataId", handle.CreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityId", handle.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("PbDataId", component.GetPbDataId());
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}
		return true;
	}

	// Token: 0x06018E7D RID: 102013 RVA: 0x0066B848 File Offset: 0x00669A48
	public unsafe bool StartEntity(EntityHandle handle)
	{
		if (!handle.Valid)
		{
			return false;
		}
		CreatureDataComponent component = handle.Entity.GetComponent<CreatureDataComponent>();
		if (component.GetRemoveState())
		{
			return false;
		}
		Entity entity = handle.Entity;
		if (!EntitySystem.Instance.Start(entity))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[实体生命周期:创建实体] 实体执行Start失败，创建实体失败。";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", handle.CreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", handle.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PbDataId", component.GetPbDataId());
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			EventSystem.Instance.Emit<long>(EEventName.CreateEntityFail, handle.CreatureDataId);
			return false;
		}
		if (CreatureModel.Instance.EnableEntityLog)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "[实体生命周期:创建实体] 实体执行Start成功";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CreatureDataId", handle.CreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityId", handle.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("PbDataId", component.GetPbDataId());
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}
		return true;
	}

	// Token: 0x06018E7E RID: 102014 RVA: 0x0066B9C4 File Offset: 0x00669BC4
	public void ActivateEntity(EntityHandle handle)
	{
		if (!handle.Valid)
		{
			return;
		}
		Entity entity = handle.Entity;
		EntitySystem.Instance.Activate(entity);
		entity.SetTimeDilation(Time.Instance.TimeDilation);
	}

	// Token: 0x06018E7F RID: 102015 RVA: 0x0066B9FC File Offset: 0x00669BFC
	[NullableContext(2)]
	public bool Destroy(EntityHandle handle)
	{
		if (handle == null || !handle.Valid)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "Destroy的entity无效，可能的原因有:1、创建失败 2、实体重复销毁";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", (handle != null) ? new int?(handle.Id) : null);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		CharacterModel.Instance.ClearHandle(handle);
		WorldEntity entity = handle.Entity;
		handle.Entity = null;
		CharacterModel.Instance.EntityPool.RemoveExternal(entity);
		return EntitySystem.Instance.Destroy<WorldEntity>(entity);
	}

	// Token: 0x06018E80 RID: 102016 RVA: 0x0066BA94 File Offset: 0x00669C94
	[NullableContext(2)]
	public bool DestroyToLru(EntityHandle handle)
	{
		if (handle == null || !handle.Valid)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "Destroy的entity无效，可能的原因有:1、创建失败 2、实体重复销毁";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", (handle != null) ? new int?(handle.Id) : null);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		Entity entity = handle.Entity;
		if (!handle.IsInit)
		{
			return this.Destroy(handle);
		}
		CharacterModel.Instance.ClearHandle(handle);
		WorldEntity worldEntity = handle.Entity;
		handle.Entity = null;
		if (!EntitySystem.Instance.DeSpawn<Entity>(entity))
		{
			CharacterModel.Instance.EntityPool.RemoveExternal(worldEntity);
			return false;
		}
		TTimerAction <>9__1;
		TimerSystem.Instance.Next(delegate(float _)
		{
			TimerSystemInstance instance2 = TimerSystem.Instance;
			TTimerAction action;
			if ((action = <>9__1) == null)
			{
				action = (<>9__1 = delegate(float _)
				{
					CharacterModel.Instance.EntityPool.Put(worldEntity);
				});
			}
			instance2.Next(action, null, null);
		}, null, null);
		return true;
	}

	// Token: 0x06018E81 RID: 102017 RVA: 0x0066BB74 File Offset: 0x00669D74
	[return: Nullable(2)]
	public EntityHandle CreateEntity(BigInteger componentsKey, CreateEntityData createData)
	{
		WorldEntity entity = CharacterModel.Instance.EntityPool.Create(componentsKey);
		if (!EntitySystem.Instance.CreateExternal<WorldEntity>(entity, createData.Priority, new EntityArgs<CreateEntityData>(createData)))
		{
			return null;
		}
		return CharacterModel.Instance.CreateHandle(entity);
	}

	// Token: 0x06018E82 RID: 102018 RVA: 0x0066BBC0 File Offset: 0x00669DC0
	[NullableContext(2)]
	public EntityHandle SpawnEntity(BigInteger componentsKey)
	{
		WorldEntity worldEntity = CharacterModel.Instance.EntityPool.Get(componentsKey);
		if (worldEntity == null)
		{
			return null;
		}
		if (!ObjectSystem.Instance.CreateExternal<WorldEntity>(worldEntity))
		{
			return null;
		}
		return CharacterModel.Instance.CreateHandle(worldEntity);
	}

	// Token: 0x06018E83 RID: 102019 RVA: 0x0066BC00 File Offset: 0x00669E00
	[NullableContext(2)]
	public CharacterActorComponent GetCharacterActorComponent(Entity entity)
	{
		if (entity == null || !entity.Valid)
		{
			return null;
		}
		CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
		if (!component.Valid || component.Actor == null)
		{
			return null;
		}
		return component;
	}

	// Token: 0x06018E84 RID: 102020 RVA: 0x0066BC3C File Offset: 0x00669E3C
	[NullableContext(2)]
	public CharacterActorComponent GetCharacterActorComponentById(int id)
	{
		Entity entity = EntitySystem.Instance.Get(id);
		if (entity == null || !entity.Valid)
		{
			return null;
		}
		CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
		if (component == null || !component.Valid)
		{
			return null;
		}
		return component;
	}

	// Token: 0x06018E85 RID: 102021 RVA: 0x0066BC84 File Offset: 0x00669E84
	[NullableContext(2)]
	public TsBaseCharacter GetCharacter(Entity entity)
	{
		if (entity == null || !entity.Valid)
		{
			return null;
		}
		CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
		if (component != null && component.Valid && component.Actor != null)
		{
			return component.Actor;
		}
		return null;
	}

	// Token: 0x06018E86 RID: 102022 RVA: 0x0066BCC8 File Offset: 0x00669EC8
	[NullableContext(2)]
	public AActor GetActor(EntityHandle entity)
	{
		if (entity == null || !entity.Valid)
		{
			return null;
		}
		BaseActorComponent actorComponent = this.GetActorComponent(entity);
		if (actorComponent != null)
		{
			return actorComponent.Owner;
		}
		return null;
	}

	// Token: 0x06018E87 RID: 102023 RVA: 0x0066BCFC File Offset: 0x00669EFC
	[return: Nullable(2)]
	public AActor GetActorByEntity(Entity entity)
	{
		if (entity == null || !entity.Valid)
		{
			return null;
		}
		BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
		if (component != null)
		{
			return component.Owner;
		}
		return null;
	}

	// Token: 0x06018E88 RID: 102024 RVA: 0x0066BD30 File Offset: 0x00669F30
	[return: Nullable(2)]
	public BaseActorComponent GetActorComponent(EntityHandle handle)
	{
		BaseActorComponent component = handle.Entity.GetComponent<SceneItemActorComponent>();
		if (component == null)
		{
			component = handle.Entity.GetComponent<BaseCharacterComponent>();
		}
		if (component == null)
		{
			component = handle.Entity.GetComponent<VehicleActorComponent>();
		}
		return component;
	}

	// Token: 0x06018E89 RID: 102025 RVA: 0x0066BD68 File Offset: 0x00669F68
	[return: Nullable(2)]
	public TsBaseCharacter GetTsBaseCharacterByEntity(EntityHandle handle)
	{
		CharacterActorComponent component = handle.Entity.GetComponent<CharacterActorComponent>();
		if (component == null)
		{
			return null;
		}
		return component.Actor;
	}

	// Token: 0x06018E8A RID: 102026 RVA: 0x0066BD80 File Offset: 0x00669F80
	[return: Nullable(2)]
	public TsBaseCharacter GetUeTsBaseCharacterByEntity(Entity entity)
	{
		CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
		if (component != null)
		{
			return component.Actor;
		}
		return null;
	}

	// Token: 0x06018E8B RID: 102027 RVA: 0x0066BD9F File Offset: 0x00669F9F
	public Entity GetEntityByUeTsBaseCharacter(TsBaseCharacter @char)
	{
		return @char.CharacterActorComponent.Entity;
	}

	// Token: 0x06018E8C RID: 102028 RVA: 0x0066BDAC File Offset: 0x00669FAC
	public void SetTimeDilation(float timeDilation)
	{
		CreatureModel instance = CreatureModel.Instance;
		foreach (EntityHandle entityHandle in instance.GetAllEntities())
		{
			if (entityHandle.IsInit)
			{
				entityHandle.Entity.SetTimeDilation(timeDilation);
			}
		}
		foreach (EntityHandle entityHandle2 in instance.DelayRemoveContainer.GetAllEntities())
		{
			if (entityHandle2.IsInit)
			{
				entityHandle2.Entity.SetTimeDilation(timeDilation);
			}
		}
	}

	// Token: 0x06018E8D RID: 102029 RVA: 0x0066BE5C File Offset: 0x0066A05C
	private bool IsEmpty()
	{
		return this.StartItem == null && CharacterModel.Instance.AwakeQueue.Size == 0;
	}

	// Token: 0x06018E8E RID: 102030 RVA: 0x0066BE80 File Offset: 0x0066A080
	private void AwakeEntity()
	{
		CharacterModel instance = CharacterModel.Instance;
		if (this.StartItem != null)
		{
			Func<bool> item = this.StartItem.Value.Item3;
			this.StartItem = null;
			if (item())
			{
				return;
			}
		}
		if (instance.AwakeQueue.Size > 0)
		{
			ValueTuple<EntityHandle, Func<bool>, Func<bool>>? startItem = null;
			do
			{
				ValueTuple<EntityHandle, Func<bool>, Func<bool>>? valueTuple;
				startItem = (valueTuple = instance.PopAwakeHandler());
				if (valueTuple == null)
				{
					return;
				}
			}
			while (!startItem.Value.Item2());
			this.StartItem = startItem;
			return;
		}
	}

	// Token: 0x06018E8F RID: 102031 RVA: 0x0066BF0C File Offset: 0x0066A10C
	[NullableContext(2)]
	public void SortItem(EntityHandle handle)
	{
		if (handle == null || !handle.Valid)
		{
			return;
		}
		if ((handle.Entity.Flag & EExecutedFlag.Init) != EExecutedFlag.None)
		{
			return;
		}
		if (handle.Entity.GetComponent<CreatureDataComponent>().GetRemoveState())
		{
			return;
		}
		CharacterModel.Instance.SortItem(handle);
	}

	// Token: 0x06018E90 RID: 102032 RVA: 0x0066BF5C File Offset: 0x0066A15C
	protected override bool OnChangeMode()
	{
		if (!GameModeModel.Instance.IsMulti)
		{
			foreach (EntityHandle entityHandle in CreatureModel.Instance.GetAllEntities())
			{
				CharacterAiComponent component = entityHandle.Entity.GetComponent<CharacterAiComponent>();
				if (component != null)
				{
					component.SwitchControl(true);
				}
			}
		}
		return true;
	}

	// Token: 0x06018E91 RID: 102033 RVA: 0x0066BFC8 File Offset: 0x0066A1C8
	public void EnterSelfCenteredMode(ESelfCenteredMode mode, float timeDilation, float duration = -1f)
	{
		CharacterModel.Instance.EnterSelfCenteredMode(mode, timeDilation, duration);
	}

	// Token: 0x06018E92 RID: 102034 RVA: 0x0066BFD7 File Offset: 0x0066A1D7
	public void ExitSelfCenteredMode(ESelfCenteredMode mode)
	{
		CharacterModel.Instance.ExitSelfCenteredMode(mode);
	}

	// Token: 0x06018E93 RID: 102035 RVA: 0x0066BFE4 File Offset: 0x0066A1E4
	public void ExitSkillSelfCenteredMode()
	{
		CharacterModel.Instance.ExitSkillSelfCenteredMode();
	}

	// Token: 0x06018E94 RID: 102036 RVA: 0x0066BFF0 File Offset: 0x0066A1F0
	public void ExitAllSelfCenteredMode()
	{
		CharacterModel.Instance.ExitAllSelfCenteredMode();
	}

	// Token: 0x06018E95 RID: 102037 RVA: 0x0066BFFC File Offset: 0x0066A1FC
	public bool IsSelfCenteredModeEnabled(ESelfCenteredMode mode)
	{
		return CharacterModel.Instance.IsSelfCenteredModeEnabled(mode);
	}

	// Token: 0x17002282 RID: 8834
	// (get) Token: 0x06018E96 RID: 102038 RVA: 0x0066C009 File Offset: 0x0066A209
	public static CharacterController Instance
	{
		get
		{
			return CharacterController._Instance;
		}
	}

	// Token: 0x06018E97 RID: 102039 RVA: 0x0066C010 File Offset: 0x0066A210
	public static CharacterController GetOrCreateInstance()
	{
		if (CharacterController._Instance == null)
		{
			CharacterController.CreateInstance();
		}
		return CharacterController._Instance;
	}

	// Token: 0x06018E98 RID: 102040 RVA: 0x0066C024 File Offset: 0x0066A224
	public static bool CreateInstance()
	{
		if (CharacterController._Instance != null)
		{
			return true;
		}
		CharacterController._Instance = new CharacterController();
		return true;
	}

	// Token: 0x06018E99 RID: 102041 RVA: 0x0066C03A File Offset: 0x0066A23A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06018E9A RID: 102042 RVA: 0x0066C03C File Offset: 0x0066A23C
	public static void ResetStaticDefaultValue()
	{
		CharacterController._Instance = null;
	}

	// Token: 0x06018E9B RID: 102043 RVA: 0x0066C044 File Offset: 0x0066A244
	static CharacterController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterController.CreateStaticDefaultValue), new Action(CharacterController.ResetStaticDefaultValue));
	}

	// Token: 0x0400BAE5 RID: 47845
	[Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	private ValueTuple<EntityHandle, Func<bool>, Func<bool>>? StartItem;

	// Token: 0x0400BAE6 RID: 47846
	private DateTime? LastDate;

	// Token: 0x0400BAE7 RID: 47847
	[Nullable(2)]
	private static CharacterController _Instance;
}
