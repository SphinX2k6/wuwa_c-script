using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000102 RID: 258
public class StateMachine<[Nullable(1)] TObject, TState> where TObject : class where TState : struct, Enum
{
	// Token: 0x170000FB RID: 251
	// (get) Token: 0x060009B0 RID: 2480 RVA: 0x000318F8 File Offset: 0x0002FAF8
	public TState? CurrentState
	{
		get
		{
			return new TState?((this.CurrentNode != null) ? this.CurrentNode.State : default(TState));
		}
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x00031928 File Offset: 0x0002FB28
	[NullableContext(1)]
	public StateMachine(TObject owner, [Nullable(new byte[]
	{
		2,
		0,
		0
	})] Action<TState, TState> onSwitchState = null)
	{
		this.Owner = owner;
		this.OnSwitchState = onSwitchState;
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x0003194C File Offset: 0x0002FB4C
	public bool Start(TState state)
	{
		if (this.CurrentNode != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.StateMachine;
			ELogAuthor author = ELogAuthor.HCS;
			string message = "状态机重复启动";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", state);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.CurrentNode = this.GetState(state);
		if (this.CurrentNode == null)
		{
			return false;
		}
		this.CurrentNode.Start();
		if (this.OnSwitchState != null)
		{
			this.OnSwitchState(state, state);
		}
		return true;
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x000319C8 File Offset: 0x0002FBC8
	public void Destroy()
	{
		foreach (StateBase<TObject, TState> stateBase in this.StateMap.Values)
		{
			stateBase.Destroy();
		}
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x00031A20 File Offset: 0x0002FC20
	public bool Switch(TState state)
	{
		if (this.CurrentNode == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.StateMachine;
			ELogAuthor author = ELogAuthor.HCS;
			string message = "状态机没有开始";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", state);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		StateBase<TObject, TState> state2 = this.GetState(state);
		if (state2 == null)
		{
			return false;
		}
		if (EqualityComparer<TState>.Default.Equals(state, this.CurrentNode.State))
		{
			if (!this.CurrentNode.CanReEnter())
			{
				return false;
			}
			this.CurrentNode.ReEnter();
			return true;
		}
		else
		{
			TState state3 = this.CurrentNode.State;
			if (!state2.CanChangeFrom(state3))
			{
				return false;
			}
			this.CurrentNode.Exit(state);
			this.CurrentNode = state2;
			this.CurrentNode.Enter(state3);
			if (this.OnSwitchState != null)
			{
				this.OnSwitchState(state3, state);
			}
			return true;
		}
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x00031AF0 File Offset: 0x0002FCF0
	public void Update(float delta)
	{
		if (this.CurrentNode != null)
		{
			this.CurrentNode.Update(delta);
		}
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x00031B08 File Offset: 0x0002FD08
	public void AddState<T>(TState state, [Nullable(2)] IEntityArgs args = null) where T : StateBase<TObject, TState>
	{
		if (this.StateMap.ContainsKey(state))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.StateMachine;
			ELogAuthor author = ELogAuthor.HCS;
			string message = "状态重复添加";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", state);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		T t = Activator.CreateInstance(typeof(T), new object[]
		{
			this.Owner,
			state,
			this
		}) as T;
		this.StateMap[state] = t;
		t.Create(args);
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x00031BAC File Offset: 0x0002FDAC
	[return: Nullable(new byte[]
	{
		2,
		1,
		0
	})]
	public StateBase<TObject, TState> GetState(TState state)
	{
		StateBase<TObject, TState> result;
		if (this.StateMap.TryGetValue(state, out result))
		{
			return result;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.StateMachine;
		ELogAuthor author = ELogAuthor.HCS;
		string message = "状态不存在";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", state);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x04000665 RID: 1637
	[Nullable(1)]
	public readonly TObject Owner;

	// Token: 0x04000666 RID: 1638
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1,
		0
	})]
	private readonly Dictionary<TState, StateBase<TObject, TState>> StateMap = new Dictionary<TState, StateBase<TObject, TState>>();

	// Token: 0x04000667 RID: 1639
	[Nullable(new byte[]
	{
		2,
		1,
		0
	})]
	private StateBase<TObject, TState> CurrentNode;

	// Token: 0x04000668 RID: 1640
	[Nullable(new byte[]
	{
		2,
		0,
		0
	})]
	private readonly Action<TState, TState> OnSwitchState;

	// Token: 0x04000669 RID: 1641
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat Stat0 = Stat.Create("StateMachine.Stat0", "", "");

	// Token: 0x0400066A RID: 1642
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat Stat1 = Stat.Create("StateMachine.Stat1", "", "");

	// Token: 0x0400066B RID: 1643
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat Stat2 = Stat.Create("StateMachine.Stat2", "", "");

	// Token: 0x0400066C RID: 1644
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat Stat3 = Stat.Create("StateMachine.Stat3", "", "");
}
