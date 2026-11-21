using System;
using System.Runtime.CompilerServices;

// Token: 0x02000101 RID: 257
public abstract class StateBase<[Nullable(1)] TObject, TState> where TObject : class where TState : struct, Enum
{
	// Token: 0x060009EF RID: 2543 RVA: 0x000321CC File Offset: 0x000303CC
	public StateBase([Nullable(1)] TObject owner, TState state, [Nullable(new byte[]
	{
		2,
		1,
		0
	})] StateMachine<TObject, TState> stateMachine)
	{
		this.Owner = owner;
		this.State = state;
		this.StateMachine = stateMachine;
	}

	// Token: 0x060009F0 RID: 2544 RVA: 0x000321E9 File Offset: 0x000303E9
	[return: Nullable(new byte[]
	{
		2,
		1,
		0
	})]
	public StateBase<TObject, TState> GetState(TState state)
	{
		StateMachine<TObject, TState> stateMachine = this.StateMachine;
		if (stateMachine == null)
		{
			return null;
		}
		return stateMachine.GetState(state);
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x000321FD File Offset: 0x000303FD
	[NullableContext(2)]
	public void Create(IEntityArgs args = null)
	{
		this.OnCreate(args);
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x00032206 File Offset: 0x00030406
	public void Start()
	{
		this.OnStart();
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x0003220E File Offset: 0x0003040E
	public void Update(float delta)
	{
		this.OnUpdate(delta);
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x00032217 File Offset: 0x00030417
	public void Enter(TState lastState)
	{
		this.OnEnter(new TState?(lastState));
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x00032225 File Offset: 0x00030425
	public void ReEnter()
	{
		this.OnReEnter();
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x0003222D File Offset: 0x0003042D
	public void Exit(TState nextState)
	{
		this.OnExit(nextState);
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x00032236 File Offset: 0x00030436
	public void Destroy()
	{
		this.OnDestroy();
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x0003223E File Offset: 0x0003043E
	public virtual bool CanReEnter()
	{
		return false;
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x00032241 File Offset: 0x00030441
	public virtual bool CanChangeFrom(TState fromState)
	{
		return true;
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x00032244 File Offset: 0x00030444
	[NullableContext(2)]
	protected virtual void OnCreate(IEntityArgs args = null)
	{
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x00032246 File Offset: 0x00030446
	protected virtual void OnStart()
	{
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x00032248 File Offset: 0x00030448
	protected virtual void OnUpdate(float delta)
	{
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x0003224A File Offset: 0x0003044A
	protected virtual void OnEnter(TState? lastState)
	{
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x0003224C File Offset: 0x0003044C
	protected virtual void OnReEnter()
	{
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x0003224E File Offset: 0x0003044E
	protected virtual void OnExit(TState nextState)
	{
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x00032250 File Offset: 0x00030450
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x0400066D RID: 1645
	[Nullable(1)]
	public readonly TObject Owner;

	// Token: 0x0400066E RID: 1646
	public readonly TState State;

	// Token: 0x0400066F RID: 1647
	[Nullable(new byte[]
	{
		2,
		1,
		0
	})]
	protected StateMachine<TObject, TState> StateMachine;
}
