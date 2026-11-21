using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;

// Token: 0x02001430 RID: 5168
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
[TickController(0)]
public class IdlePerformController : ControllerBase
{
	// Token: 0x0600CDB6 RID: 52662 RVA: 0x003D387C File Offset: 0x003D1A7C
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		return base.OnInit();
	}

	// Token: 0x0600CDB7 RID: 52663 RVA: 0x003D38A0 File Offset: 0x003D1AA0
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		this.UnbindPlayerEvents(this.CurrentPlayerHandle);
		this.CurrentPlayerHandle = null;
		return true;
	}

	// Token: 0x0600CDB8 RID: 52664 RVA: 0x003D38D4 File Offset: 0x003D1AD4
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

	// Token: 0x0600CDB9 RID: 52665 RVA: 0x003D3944 File Offset: 0x003D1B44
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

	// Token: 0x0600CDBA RID: 52666 RVA: 0x003D3980 File Offset: 0x003D1B80
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

	// Token: 0x0600CDBB RID: 52667 RVA: 0x003D3A0C File Offset: 0x003D1C0C
	private void BindPlayerEvents(EntityHandle handle)
	{
		WorldEntity entity = handle.Entity;
		EventSystem.Instance.AddWithTarget<ERemoveEntityType, EntityHandle>(handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		EventSystem.Instance.AddWithTarget<int, int, bool>(entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseSkill));
		EventSystem.Instance.AddWithTarget<global::HitInformation, HitContext>(entity, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.OnBeHit));
		EventSystem.Instance.AddWithTarget<global::ECharMoveState, global::ECharMoveState>(entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.OnUnifiedMoveStateChanged));
	}

	// Token: 0x0600CDBC RID: 52668 RVA: 0x003D3A90 File Offset: 0x003D1C90
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

	// Token: 0x0600CDBD RID: 52669 RVA: 0x003D3B3C File Offset: 0x003D1D3C
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

	// Token: 0x0600CDBE RID: 52670 RVA: 0x003D3BE5 File Offset: 0x003D1DE5
	private void OnUseSkill(int charId, int skillId, bool isAutonomousProxy)
	{
		IdlePerformModel instance = IdlePerformModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.ResetIdleTime();
	}

	// Token: 0x0600CDBF RID: 52671 RVA: 0x003D3BF6 File Offset: 0x003D1DF6
	private void OnBeHit(global::HitInformation hitData, HitContext _)
	{
		IdlePerformModel instance = IdlePerformModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.ResetIdleTime();
	}

	// Token: 0x0600CDC0 RID: 52672 RVA: 0x003D3C07 File Offset: 0x003D1E07
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

	// Token: 0x17001363 RID: 4963
	// (get) Token: 0x0600CDC1 RID: 52673 RVA: 0x003D3C26 File Offset: 0x003D1E26
	public static IdlePerformController Instance
	{
		get
		{
			return IdlePerformController._Instance;
		}
	}

	// Token: 0x0600CDC2 RID: 52674 RVA: 0x003D3C2D File Offset: 0x003D1E2D
	public static IdlePerformController GetOrCreateInstance()
	{
		if (IdlePerformController._Instance == null)
		{
			IdlePerformController.CreateInstance();
		}
		return IdlePerformController._Instance;
	}

	// Token: 0x0600CDC3 RID: 52675 RVA: 0x003D3C41 File Offset: 0x003D1E41
	public static bool CreateInstance()
	{
		if (IdlePerformController._Instance != null)
		{
			return true;
		}
		IdlePerformController._Instance = new IdlePerformController();
		return true;
	}

	// Token: 0x0600CDC4 RID: 52676 RVA: 0x003D3C57 File Offset: 0x003D1E57
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CDC5 RID: 52677 RVA: 0x003D3C59 File Offset: 0x003D1E59
	public static void ResetStaticDefaultValue()
	{
		IdlePerformController._Instance = null;
	}

	// Token: 0x0600CDC6 RID: 52678 RVA: 0x003D3C61 File Offset: 0x003D1E61
	static IdlePerformController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(IdlePerformController.CreateStaticDefaultValue), new Action(IdlePerformController.ResetStaticDefaultValue));
	}

	// Token: 0x04007539 RID: 30009
	[Nullable(2)]
	private EntityHandle CurrentPlayerHandle;

	// Token: 0x0400753A RID: 30010
	private readonly HashSet<global::ECharMoveState> StopIdleMoveStates = new HashSet<global::ECharMoveState>
	{
		global::ECharMoveState.Stand,
		global::ECharMoveState.Walk,
		global::ECharMoveState.WalkStop,
		global::ECharMoveState.RunStop,
		global::ECharMoveState.SprintStop
	};

	// Token: 0x0400753B RID: 30011
	[Nullable(2)]
	private static IdlePerformController _Instance;
}
