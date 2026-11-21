using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020004F2 RID: 1266
[NullableContext(1)]
[Nullable(0)]
public abstract class GuessJokerFsmBase<[Nullable(2)] TType, [Nullable(0)] TState> where TState : GuessJokerStageBase
{
	// Token: 0x06003E48 RID: 15944 RVA: 0x0016030A File Offset: 0x0015E50A
	public void Init()
	{
		this.InitStateInstance();
	}

	// Token: 0x06003E49 RID: 15945 RVA: 0x00160312 File Offset: 0x0015E512
	public void Tick(float deltaTime)
	{
		if (this.CurrentState != null)
		{
			this.CurrentState.Tick(deltaTime);
		}
	}

	// Token: 0x06003E4A RID: 15946 RVA: 0x00160334 File Offset: 0x0015E534
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

	// Token: 0x06003E4B RID: 15947 RVA: 0x0016038C File Offset: 0x0015E58C
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

	// Token: 0x06003E4C RID: 15948 RVA: 0x001603F8 File Offset: 0x0015E5F8
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

	// Token: 0x06003E4D RID: 15949 RVA: 0x0016044F File Offset: 0x0015E64F
	public TType GetCurrentStateType()
	{
		return this.CurrentStateType;
	}

	// Token: 0x06003E4E RID: 15950 RVA: 0x00160457 File Offset: 0x0015E657
	[NullableContext(2)]
	public TState GetCurrentState()
	{
		return this.CurrentState;
	}

	// Token: 0x06003E4F RID: 15951
	protected abstract void InitStateInstance();

	// Token: 0x06003E50 RID: 15952
	protected abstract bool CheckCanChangeState(TType curStateType, TType nextStateType);

	// Token: 0x040031C9 RID: 12745
	[Nullable(2)]
	protected TState CurrentState;

	// Token: 0x040031CA RID: 12746
	protected TType CurrentStateType;

	// Token: 0x040031CB RID: 12747
	protected Dictionary<TType, TState> StateMap = new Dictionary<TType, TState>();
}
