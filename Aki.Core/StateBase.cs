using System;
using System.Runtime.CompilerServices;

// Token: 0x02000101 RID: 257
public abstract class StateBase<[Nullable(1)] TObject, TState> where TObject : class where TState : struct, Enum
{
	// Token: 0x0600099E RID: 2462 RVA: 0x00031870 File Offset: 0x0002FA70
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

	// Token: 0x0600099F RID: 2463 RVA: 0x0003188D File Offset: 0x0002FA8D
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

	// Token: 0x060009A0 RID: 2464 RVA: 0x000318A1 File Offset: 0x0002FAA1
	[NullableContext(2)]
	public void Create(IEntityArgs args = null)
	{
		this.OnCreate(args);
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x000318AA File Offset: 0x0002FAAA
	public void Start()
	{
		this.OnStart();
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x000318B2 File Offset: 0x0002FAB2
	public void Update(float delta)
	{
		this.OnUpdate(delta);
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x000318BB File Offset: 0x0002FABB
	public void Enter(TState lastState)
	{
		this.OnEnter(new TState?(lastState));
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x000318C9 File Offset: 0x0002FAC9
	public void ReEnter()
	{
		this.OnReEnter();
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x000318D1 File Offset: 0x0002FAD1
	public void Exit(TState nextState)
	{
		this.OnExit(nextState);
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x000318DA File Offset: 0x0002FADA
	public void Destroy()
	{
		this.OnDestroy();
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x000318E2 File Offset: 0x0002FAE2
	public virtual bool CanReEnter()
	{
		return false;
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x000318E5 File Offset: 0x0002FAE5
	public virtual bool CanChangeFrom(TState fromState)
	{
		return true;
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x000318E8 File Offset: 0x0002FAE8
	[NullableContext(2)]
	protected virtual void OnCreate(IEntityArgs args = null)
	{
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x000318EA File Offset: 0x0002FAEA
	protected virtual void OnStart()
	{
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x000318EC File Offset: 0x0002FAEC
	protected virtual void OnUpdate(float delta)
	{
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x000318EE File Offset: 0x0002FAEE
	protected virtual void OnEnter(TState? lastState)
	{
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x000318F0 File Offset: 0x0002FAF0
	protected virtual void OnReEnter()
	{
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x000318F2 File Offset: 0x0002FAF2
	protected virtual void OnExit(TState nextState)
	{
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x000318F4 File Offset: 0x0002FAF4
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x04000662 RID: 1634
	[Nullable(1)]
	public readonly TObject Owner;

	// Token: 0x04000663 RID: 1635
	public readonly TState State;

	// Token: 0x04000664 RID: 1636
	[Nullable(new byte[]
	{
		2,
		1,
		0
	})]
	protected StateMachine<TObject, TState> StateMachine;
}
