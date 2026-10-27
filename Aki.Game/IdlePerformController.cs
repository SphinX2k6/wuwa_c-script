using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;

// Token: 0x02001F6E RID: 8046
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
[TickController(0)]
public class IdlePerformController : ControllerBase
{
	// Token: 0x0600F997 RID: 63895 RVA: 0x003C7D90 File Offset: 0x003C5F90
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		return base.OnInit();
	}

	// Token: 0x0600F998 RID: 63896 RVA: 0x003C7DB4 File Offset: 0x003C5FB4
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		this.UnbindPlayerEvents(this.CurrentPlayerHandle);
		this.CurrentPlayerHandle = null;
		return true;
	}

	// Token: 0x0600F999 RID: 63897 RVA: 0x003C7DE8 File Offset: 0x003C5FE8
	protected override void OnTick(float delta)
	{
		EntityHandle currentPlayerHandle = this.CurrentPlayerHandle;
		if (currentPlayerHandle == null || !currentPlayerHandle.Valid)
		{
			return;
		}
		CharacterActorComponent component = currentPlayerHandle.Entity.GetComponent<CharacterActorComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		IdlePerformModel.Instance.OnTick(delta);
		if (component.InputDirectProxy.SizeSquared2D() > 1E-08)
		{
			IdlePerformModel.Instance.ResetIdleTime();
		}
	}

	// Token: 0x0600F99A RID: 63898 RVA: 0x003C7E58 File Offset: 0x003C6058
	public void ClearIdle()
	{
		Log.Instance.Info(ELogModule.Controller, ELogAuthor.ZJL, "[IdlePerform] 外部主动清空闲置时长", default(ReadOnlySpan<ValueTuple<string, object>>));
		IdlePerformModel instance = IdlePerformModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.ResetIdleTime();
	}

	// Token: 0x0600F99B RID: 63899 RVA: 0x003C7E94 File Offset: 0x003C6094
	[NullableContext(2)]
	private void UnbindPlayerEvents(EntityHandle handle)
	{
		if (handle == null)
		{
			return;
		}
		EventSystem.Instance.RemoveWithTarget<ERemoveEntityType, EntityHandle>(handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		WorldEntity entity = handle.Entity;
		if (entity == null)
		{
			return;
		}
		EventSystem.Instance.RemoveWithTarget<int, int, bool>(entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseSkill));
		EventSystem.Instance.RemoveWithTarget<global::HitInformation, HitContext>(entity, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.OnBeHit));
		EventSystem.Instance.RemoveWithTarget<global::ECharMoveState, global::ECharMoveState>(entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.OnUnifiedMoveStateChanged));
	}

	// Token: 0x0600F99C RID: 63900 RVA: 0x003C7F20 File Offset: 0x003C6120
	private void BindPlayerEvents(EntityHandle handle)
	{
		WorldEntity entity = handle.Entity;
		EventSystem.Instance.AddWithTarget<ERemoveEntityType, EntityHandle>(handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		EventSystem.Instance.AddWithTarget<int, int, bool>(entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseSkill));
		EventSystem.Instance.AddWithTarget<global::HitInformation, HitContext>(entity, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.OnBeHit));
		EventSystem.Instance.AddWithTarget<global::ECharMoveState, global::ECharMoveState>(entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.OnUnifiedMoveStateChanged));
	}

	// Token: 0x0600F99D RID: 63901 RVA: 0x003C7FA4 File Offset: 0x003C61A4
	private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		this.UnbindPlayerEvents(this.CurrentPlayerHandle);
		this.CurrentPlayerHandle = null;
		IdlePerformModel instance = IdlePerformModel.Instance;
		if (instance != null)
		{
			instance.ResetIdleTime();
		}
		if (newEntity == null || !newEntity.Valid)
		{
			return;
		}
		CharacterActorComponent component = newEntity.Entity.GetComponent<CharacterActorComponent>();
		if (component == null || !component.Valid || !component.IsAutonomousProxy)
		{
			return;
		}
		this.CurrentPlayerHandle = newEntity;
		this.BindPlayerEvents(newEntity);
		Log instance2 = Log.Instance;
		ELogModule module = ELogModule.Controller;
		ELogAuthor author = ELogAuthor.ZJL;
		string message = "[IdlePerform] 绑定本地受控玩家闲置事件";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", newEntity.Id);
		instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600F99E RID: 63902 RVA: 0x003C8050 File Offset: 0x003C6250
	private unsafe void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle removedEntity)
	{
		EntityHandle currentPlayerHandle = this.CurrentPlayerHandle;
		if (currentPlayerHandle == null || currentPlayerHandle.Id != removedEntity.Id)
		{
			return;
		}
		this.UnbindPlayerEvents(removedEntity);
		this.CurrentPlayerHandle = null;
		IdlePerformModel instance = IdlePerformModel.Instance;
		if (instance != null)
		{
			instance.ResetIdleTime();
		}
		Log instance2 = Log.Instance;
		ELogModule module = ELogModule.Controller;
		ELogAuthor author = ELogAuthor.ZJL;
		string message = "[IdlePerform] 本地受控玩家实体移除，解绑闲置事件";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", removedEntity.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RemoveType", removeType);
		instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x0600F99F RID: 63903 RVA: 0x003C80F9 File Offset: 0x003C62F9
	private void OnUseSkill(int charId, int skillId, bool isAutonomousProxy)
	{
		IdlePerformModel instance = IdlePerformModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.ResetIdleTime();
	}

	// Token: 0x0600F9A0 RID: 63904 RVA: 0x003C810A File Offset: 0x003C630A
	private void OnBeHit(global::HitInformation hitData, HitContext _)
	{
		IdlePerformModel instance = IdlePerformModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.ResetIdleTime();
	}

	// Token: 0x0600F9A1 RID: 63905 RVA: 0x003C811B File Offset: 0x003C631B
	private void OnUnifiedMoveStateChanged(global::ECharMoveState oldMoveState, global::ECharMoveState newMoveState)
	{
		if (!this.StopIdleMoveStates.Contains(newMoveState))
		{
			IdlePerformModel instance = IdlePerformModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ResetIdleTime();
		}
	}

	// Token: 0x17001339 RID: 4921
	// (get) Token: 0x0600F9A2 RID: 63906 RVA: 0x003C813A File Offset: 0x003C633A
	public static IdlePerformController Instance
	{
		get
		{
			return IdlePerformController._Instance;
		}
	}

	// Token: 0x0600F9A3 RID: 63907 RVA: 0x003C8141 File Offset: 0x003C6341
	public static IdlePerformController GetOrCreateInstance()
	{
		if (IdlePerformController._Instance == null)
		{
			IdlePerformController.CreateInstance();
		}
		return IdlePerformController._Instance;
	}

	// Token: 0x0600F9A4 RID: 63908 RVA: 0x003C8155 File Offset: 0x003C6355
	public static bool CreateInstance()
	{
		if (IdlePerformController._Instance != null)
		{
			return true;
		}
		IdlePerformController._Instance = new IdlePerformController();
		return true;
	}

	// Token: 0x0600F9A5 RID: 63909 RVA: 0x003C816B File Offset: 0x003C636B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F9A6 RID: 63910 RVA: 0x003C816D File Offset: 0x003C636D
	public static void ResetStaticDefaultValue()
	{
		IdlePerformController._Instance = null;
	}

	// Token: 0x0600F9A7 RID: 63911 RVA: 0x003C8175 File Offset: 0x003C6375
	static IdlePerformController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(IdlePerformController.CreateStaticDefaultValue), new Action(IdlePerformController.ResetStaticDefaultValue));
	}

	// Token: 0x04007458 RID: 29784
	[Nullable(2)]
	private EntityHandle CurrentPlayerHandle;

	// Token: 0x04007459 RID: 29785
	private readonly HashSet<global::ECharMoveState> StopIdleMoveStates = new HashSet<global::ECharMoveState>
	{
		global::ECharMoveState.Stand,
		global::ECharMoveState.Walk,
		global::ECharMoveState.WalkStop,
		global::ECharMoveState.RunStop,
		global::ECharMoveState.SprintStop
	};

	// Token: 0x0400745A RID: 29786
	[Nullable(2)]
	private static IdlePerformController _Instance;
}
