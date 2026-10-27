using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001B50 RID: 6992
public abstract class FloroRanchFsmBase<TType, TState> where TType : struct where TState : FloroRanchStateBase
{
	// Token: 0x0600CF6C RID: 53100 RVA: 0x002F4147 File Offset: 0x002F2347
	public void Init()
	{
		this.InitStateInstance();
	}

	// Token: 0x0600CF6D RID: 53101 RVA: 0x002F414F File Offset: 0x002F234F
	public void Tick(float deltaTime)
	{
		if (this.CurrentState != null)
		{
			this.CurrentState.Tick(deltaTime);
		}
	}

	// Token: 0x0600CF6E RID: 53102 RVA: 0x002F4170 File Offset: 0x002F2370
	protected void RegisterState(TType type, [Nullable(1)] TState state)
	{
		if (this.StateMap.ContainsKey(type))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchFsmBase 注册状态失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("stateType", type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.StateMap.Add(type, state);
	}

	// Token: 0x0600CF6F RID: 53103 RVA: 0x002F41C8 File Offset: 0x002F23C8
	public void ChangeState(TType stateType)
	{
		if (!this.CheckCanChangeState(this.CurrentStateType, stateType))
		{
			return;
		}
		TState stateInstance = this.GetStateInstance(stateType);
		if (stateInstance == null)
		{
			return;
		}
		if (this.CurrentState != null)
		{
			this.CurrentState.Exit();
		}
		this.CurrentStateType = stateType;
		this.CurrentState = stateInstance;
		this.CurrentState.Enter();
	}

	// Token: 0x0600CF70 RID: 53104 RVA: 0x002F4234 File Offset: 0x002F2434
	[return: Nullable(2)]
	private TState GetStateInstance(TType stateType)
	{
		if (!this.StateMap.ContainsKey(stateType))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchStageFsm 获取状态实例失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("stateType", stateType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return default(TState);
		}
		return this.StateMap[stateType];
	}

	// Token: 0x0600CF71 RID: 53105 RVA: 0x002F4294 File Offset: 0x002F2494
	public TType GetCurrentStateType()
	{
		return this.CurrentStateType;
	}

	// Token: 0x0600CF72 RID: 53106 RVA: 0x002F429C File Offset: 0x002F249C
	[NullableContext(2)]
	public TState GetCurrentState()
	{
		return this.CurrentState;
	}

	// Token: 0x0600CF73 RID: 53107
	protected abstract void InitStateInstance();

	// Token: 0x0600CF74 RID: 53108
	protected abstract bool CheckCanChangeState(TType curStateType, TType nextStateType);

	// Token: 0x04005F6B RID: 24427
	[Nullable(2)]
	protected TState CurrentState;

	// Token: 0x04005F6C RID: 24428
	protected TType CurrentStateType;

	// Token: 0x04005F6D RID: 24429
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	protected Dictionary<TType, TState> StateMap = new Dictionary<TType, TState>();
}
