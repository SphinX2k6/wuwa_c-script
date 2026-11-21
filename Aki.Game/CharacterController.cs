using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200238D RID: 9101
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class CharacterController : ControllerBase
{
	// Token: 0x170022F4 RID: 8948
	// (get) Token: 0x06016740 RID: 91968 RVA: 0x006913CC File Offset: 0x0068F5CC
	protected override bool IsTickEvenPausedInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06016741 RID: 91969 RVA: 0x006913CF File Offset: 0x0068F5CF
	protected override bool OnInit()
	{
		this.LastDate = new DateTime?(DateTime.Now);
		return true;
	}

	// Token: 0x06016742 RID: 91970 RVA: 0x006913E2 File Offset: 0x0068F5E2
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

	// Token: 0x06016743 RID: 91971 RVA: 0x00691408 File Offset: 0x0068F608
	private UniTask TestMessage()
	{
		CharacterController.<TestMessage>d__6 <TestMessage>d__;
		<TestMessage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TestMessage>d__.<>4__this = this;
		<TestMessage>d__.<>1__state = -1;
		<TestMessage>d__.<>t__builder.Start<CharacterController.<TestMessage>d__6>(ref <TestMessage>d__);
		return <TestMessage>d__.<>t__builder.Task;
	}

	// Token: 0x06016744 RID: 91972 RVA: 0x0069144B File Offset: 0x0068F64B
	private bool IsQueueEmpty()
	{
		return this.IsEmpty();
	}

	// Token: 0x06016745 RID: 91973 RVA: 0x00691453 File Offset: 0x0068F653
	private void ConsumeQueue()
	{
		this.AwakeEntity();
	}

	// Token: 0x06016746 RID: 91974 RVA: 0x0069145B File Offset: 0x0068F65B
	public bool InitData<[Nullable(0)] T>(EntityHandle handle, T entity, [Nullable(2)] IEntityArgs args = null) where T : Entity
	{
		if (!EntitySystem.Instance.InitData(entity, args))
		{
			CharacterModel.Instance.ClearHandle(handle);
			return false;
		}
		return true;
	}

	// Token: 0x06016747 RID: 91975 RVA: 0x0069147E File Offset: 0x0068F67E
	public bool Respawn<[Nullable(0)] T>(EntityHandle handle, T entity, int priority = 0, [Nullable(2)] IEntityArgs args = null) where T : Entity
	{
		if (!EntitySystem.Instance.Respawn(entity, true, priority, args))
		{
			CharacterModel.Instance.ClearHandle(handle);
			return false;
		}
		return true;
	}

	// Token: 0x06016748 RID: 91976 RVA: 0x006914A4 File Offset: 0x0068F6A4
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

	// Token: 0x06016749 RID: 91977 RVA: 0x006915C8 File Offset: 0x0068F7C8
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

	// Token: 0x0601674A RID: 91978 RVA: 0x00691740 File Offset: 0x0068F940
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

	// Token: 0x0601674B RID: 91979 RVA: 0x006918BC File Offset: 0x0068FABC
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

	// Token: 0x0601674C RID: 91980 RVA: 0x006918F4 File Offset: 0x0068FAF4
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
		return EntitySystem.Instance.Destroy(entity);
	}

	// Token: 0x0601674D RID: 91981 RVA: 0x0069198C File Offset: 0x0068FB8C
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
		if (!EntitySystem.Instance.DeSpawn(entity))
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

	// Token: 0x0601674E RID: 91982 RVA: 0x00691A6C File Offset: 0x0068FC6C
	[return: Nullable(2)]
	public EntityHandle CreateEntity(BigInteger componentsKey, CreateEntityData createData)
	{
		WorldEntity entity = CharacterModel.Instance.EntityPool.Create(componentsKey);
		if (!EntitySystem.Instance.CreateExternal(entity, createData.Priority, new EntityArgs<CreateEntityData>(createData)))
		{
			return null;
		}
		return CharacterModel.Instance.CreateHandle(entity);
	}

	// Token: 0x0601674F RID: 91983 RVA: 0x00691AB8 File Offset: 0x0068FCB8
	[NullableContext(2)]
	public EntityHandle SpawnEntity(BigInteger componentsKey)
	{
		WorldEntity worldEntity = CharacterModel.Instance.EntityPool.Get(componentsKey);
		if (worldEntity == null)
		{
			return null;
		}
		if (!ObjectSystem.Instance.CreateExternal(worldEntity))
		{
			return null;
		}
		return CharacterModel.Instance.CreateHandle(worldEntity);
	}

	// Token: 0x06016750 RID: 91984 RVA: 0x00691AF8 File Offset: 0x0068FCF8
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

	// Token: 0x06016751 RID: 91985 RVA: 0x00691B34 File Offset: 0x0068FD34
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

	// Token: 0x06016752 RID: 91986 RVA: 0x00691B7C File Offset: 0x0068FD7C
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

	// Token: 0x06016753 RID: 91987 RVA: 0x00691BC0 File Offset: 0x0068FDC0
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

	// Token: 0x06016754 RID: 91988 RVA: 0x00691BF4 File Offset: 0x0068FDF4
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

	// Token: 0x06016755 RID: 91989 RVA: 0x00691C28 File Offset: 0x0068FE28
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

	// Token: 0x06016756 RID: 91990 RVA: 0x00691C60 File Offset: 0x0068FE60
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

	// Token: 0x06016757 RID: 91991 RVA: 0x00691C78 File Offset: 0x0068FE78
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

	// Token: 0x06016758 RID: 91992 RVA: 0x00691C97 File Offset: 0x0068FE97
	public Entity GetEntityByUeTsBaseCharacter(TsBaseCharacter @char)
	{
		return @char.CharacterActorComponent.Entity;
	}

	// Token: 0x06016759 RID: 91993 RVA: 0x00691CA4 File Offset: 0x0068FEA4
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

	// Token: 0x0601675A RID: 91994 RVA: 0x00691D54 File Offset: 0x0068FF54
	private bool IsEmpty()
	{
		return this.StartItem == null && CharacterModel.Instance.AwakeQueue.Size == 0;
	}

	// Token: 0x0601675B RID: 91995 RVA: 0x00691D78 File Offset: 0x0068FF78
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

	// Token: 0x0601675C RID: 91996 RVA: 0x00691E04 File Offset: 0x00690004
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

	// Token: 0x0601675D RID: 91997 RVA: 0x00691E54 File Offset: 0x00690054
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

	// Token: 0x0601675E RID: 91998 RVA: 0x00691EC0 File Offset: 0x006900C0
	public void EnterSelfCenteredMode(ESelfCenteredMode mode, float timeDilation, float duration = -1f)
	{
		CharacterModel.Instance.EnterSelfCenteredMode(mode, timeDilation, duration);
	}

	// Token: 0x0601675F RID: 91999 RVA: 0x00691ECF File Offset: 0x006900CF
	public void ExitSelfCenteredMode(ESelfCenteredMode mode)
	{
		CharacterModel.Instance.ExitSelfCenteredMode(mode);
	}

	// Token: 0x06016760 RID: 92000 RVA: 0x00691EDC File Offset: 0x006900DC
	public void ExitSkillSelfCenteredMode()
	{
		CharacterModel.Instance.ExitSkillSelfCenteredMode();
	}

	// Token: 0x06016761 RID: 92001 RVA: 0x00691EE8 File Offset: 0x006900E8
	public void ExitAllSelfCenteredMode()
	{
		CharacterModel.Instance.ExitAllSelfCenteredMode();
	}

	// Token: 0x06016762 RID: 92002 RVA: 0x00691EF4 File Offset: 0x006900F4
	public bool IsSelfCenteredModeEnabled(ESelfCenteredMode mode)
	{
		return CharacterModel.Instance.IsSelfCenteredModeEnabled(mode);
	}

	// Token: 0x170022F5 RID: 8949
	// (get) Token: 0x06016763 RID: 92003 RVA: 0x00691F01 File Offset: 0x00690101
	public static CharacterController Instance
	{
		get
		{
			return CharacterController._Instance;
		}
	}

	// Token: 0x06016764 RID: 92004 RVA: 0x00691F08 File Offset: 0x00690108
	public static CharacterController GetOrCreateInstance()
	{
		if (CharacterController._Instance == null)
		{
			CharacterController.CreateInstance();
		}
		return CharacterController._Instance;
	}

	// Token: 0x06016765 RID: 92005 RVA: 0x00691F1C File Offset: 0x0069011C
	public static bool CreateInstance()
	{
		if (CharacterController._Instance != null)
		{
			return true;
		}
		CharacterController._Instance = new CharacterController();
		return true;
	}

	// Token: 0x06016766 RID: 92006 RVA: 0x00691F32 File Offset: 0x00690132
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016767 RID: 92007 RVA: 0x00691F34 File Offset: 0x00690134
	public static void ResetStaticDefaultValue()
	{
		CharacterController._Instance = null;
	}

	// Token: 0x06016768 RID: 92008 RVA: 0x00691F3C File Offset: 0x0069013C
	static CharacterController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterController.CreateStaticDefaultValue), new Action(CharacterController.ResetStaticDefaultValue));
	}

	// Token: 0x0400BE73 RID: 48755
	[Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	private ValueTuple<EntityHandle, Func<bool>, Func<bool>>? StartItem;

	// Token: 0x0400BE74 RID: 48756
	private DateTime? LastDate;

	// Token: 0x0400BE75 RID: 48757
	[Nullable(2)]
	private static CharacterController _Instance;
}
