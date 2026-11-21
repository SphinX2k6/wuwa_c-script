using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000102 RID: 258
public class StateMachine<[Nullable(1)] TObject, TState> where TObject : class where TState : struct, Enum
{
	// Token: 0x1700010D RID: 269
	// (get) Token: 0x06000A01 RID: 2561 RVA: 0x00032254 File Offset: 0x00030454
	public TState? CurrentState
	{
		get
		{
			return new TState?((this.CurrentNode != null) ? this.CurrentNode.State : default(TState));
		}
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x00032284 File Offset: 0x00030484
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

	// Token: 0x06000A03 RID: 2563 RVA: 0x000322A8 File Offset: 0x000304A8
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

	// Token: 0x06000A04 RID: 2564 RVA: 0x00032324 File Offset: 0x00030524
	public void Destroy()
	{
		foreach (StateBase<TObject, TState> stateBase in this.StateMap.Values)
		{
			stateBase.Destroy();
		}
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x0003237C File Offset: 0x0003057C
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

	// Token: 0x06000A06 RID: 2566 RVA: 0x0003244C File Offset: 0x0003064C
	public void Update(float delta)
	{
		if (this.CurrentNode != null)
		{
			this.CurrentNode.Update(delta);
		}
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x00032464 File Offset: 0x00030664
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

	// Token: 0x06000A08 RID: 2568 RVA: 0x00032508 File Offset: 0x00030708
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

	// Token: 0x04000670 RID: 1648
	[Nullable(1)]
	public readonly TObject Owner;

	// Token: 0x04000671 RID: 1649
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1,
		0
	})]
	private readonly Dictionary<TState, StateBase<TObject, TState>> StateMap = new Dictionary<TState, StateBase<TObject, TState>>();

	// Token: 0x04000672 RID: 1650
	[Nullable(new byte[]
	{
		2,
		1,
		0
	})]
	private StateBase<TObject, TState> CurrentNode;

	// Token: 0x04000673 RID: 1651
	[Nullable(new byte[]
	{
		2,
		0,
		0
	})]
	private readonly Action<TState, TState> OnSwitchState;

	// Token: 0x04000674 RID: 1652
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat Stat0 = Stat.Create("StateMachine.Stat0", "", "");

	// Token: 0x04000675 RID: 1653
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat Stat1 = Stat.Create("StateMachine.Stat1", "", "");

	// Token: 0x04000676 RID: 1654
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat Stat2 = Stat.Create("StateMachine.Stat2", "", "");

	// Token: 0x04000677 RID: 1655
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat Stat3 = Stat.Create("StateMachine.Stat3", "", "");
}
