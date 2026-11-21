using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200100F RID: 4111
public abstract class FloroRanchFsmBase<TType, TState> where TType : struct where TState : FloroRanchStateBase
{
	// Token: 0x0600A37D RID: 41853 RVA: 0x002FF21F File Offset: 0x002FD41F
	public void Init()
	{
		this.InitStateInstance();
	}

	// Token: 0x0600A37E RID: 41854 RVA: 0x002FF227 File Offset: 0x002FD427
	public void Tick(float deltaTime)
	{
		if (this.CurrentState != null)
		{
			this.CurrentState.Tick(deltaTime);
		}
	}

	// Token: 0x0600A37F RID: 41855 RVA: 0x002FF248 File Offset: 0x002FD448
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

	// Token: 0x0600A380 RID: 41856 RVA: 0x002FF2A0 File Offset: 0x002FD4A0
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

	// Token: 0x0600A381 RID: 41857 RVA: 0x002FF30C File Offset: 0x002FD50C
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

	// Token: 0x0600A382 RID: 41858 RVA: 0x002FF36C File Offset: 0x002FD56C
	public TType GetCurrentStateType()
	{
		return this.CurrentStateType;
	}

	// Token: 0x0600A383 RID: 41859 RVA: 0x002FF374 File Offset: 0x002FD574
	[NullableContext(2)]
	public TState GetCurrentState()
	{
		return this.CurrentState;
	}

	// Token: 0x0600A384 RID: 41860
	protected abstract void InitStateInstance();

	// Token: 0x0600A385 RID: 41861
	protected abstract bool CheckCanChangeState(TType curStateType, TType nextStateType);

	// Token: 0x0400603A RID: 24634
	[Nullable(2)]
	protected TState CurrentState;

	// Token: 0x0400603B RID: 24635
	protected TType CurrentStateType;

	// Token: 0x0400603C RID: 24636
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	protected Dictionary<TType, TState> StateMap = new Dictionary<TType, TState>();
}
