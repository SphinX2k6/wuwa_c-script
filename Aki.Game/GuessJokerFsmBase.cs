using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200103E RID: 4158
[NullableContext(1)]
[Nullable(0)]
public abstract class GuessJokerFsmBase<[Nullable(2)] TType, [Nullable(0)] TState> where TState : GuessJokerStageBase
{
	// Token: 0x06006AB3 RID: 27315 RVA: 0x001579E2 File Offset: 0x00155BE2
	public void Init()
	{
		this.InitStateInstance();
	}

	// Token: 0x06006AB4 RID: 27316 RVA: 0x001579EA File Offset: 0x00155BEA
	public void Tick(float deltaTime)
	{
		if (this.CurrentState != null)
		{
			this.CurrentState.Tick(deltaTime);
		}
	}

	// Token: 0x06006AB5 RID: 27317 RVA: 0x00157A0C File Offset: 0x00155C0C
	protected void RegisterState(TType type, TState state)
	{
		if (this.StateMap.ContainsKey(type))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GuessJokerCard;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "GuessJokerFsmBase 注册状态失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("stateType", type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.StateMap[type] = state;
	}

	// Token: 0x06006AB6 RID: 27318 RVA: 0x00157A64 File Offset: 0x00155C64
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

	// Token: 0x06006AB7 RID: 27319 RVA: 0x00157AD0 File Offset: 0x00155CD0
	[return: Nullable(2)]
	private TState GetStateInstance(TType stateType)
	{
		TState result;
		if (!this.StateMap.TryGetValue(stateType, out result))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GuessJokerCard;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "GuessJokerFsmBase 获取状态实例失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("stateType", stateType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return default(TState);
		}
		return result;
	}

	// Token: 0x06006AB8 RID: 27320 RVA: 0x00157B27 File Offset: 0x00155D27
	public TType GetCurrentStateType()
	{
		return this.CurrentStateType;
	}

	// Token: 0x06006AB9 RID: 27321 RVA: 0x00157B2F File Offset: 0x00155D2F
	[NullableContext(2)]
	public TState GetCurrentState()
	{
		return this.CurrentState;
	}

	// Token: 0x06006ABA RID: 27322
	protected abstract void InitStateInstance();

	// Token: 0x06006ABB RID: 27323
	protected abstract bool CheckCanChangeState(TType curStateType, TType nextStateType);

	// Token: 0x04003130 RID: 12592
	[Nullable(2)]
	protected TState CurrentState;

	// Token: 0x04003131 RID: 12593
	protected TType CurrentStateType;

	// Token: 0x04003132 RID: 12594
	protected Dictionary<TType, TState> StateMap = new Dictionary<TType, TState>();
}
