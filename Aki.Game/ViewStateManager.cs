using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001302 RID: 4866
[NullableContext(1)]
[Nullable(0)]
internal class ViewStateManager
{
	// Token: 0x060086CF RID: 34511 RVA: 0x001CC661 File Offset: 0x001CA861
	public ViewStateManager()
	{
		this.CurrentStateInternal = EBusinessSkipDefine.MainView;
		this.PushStateStack.Push(this.CurrentStateInternal);
	}

	// Token: 0x060086D0 RID: 34512 RVA: 0x001CC698 File Offset: 0x001CA898
	[NullableContext(2)]
	public void RegisterViewState(EBusinessSkipDefine state, Action exitFunc, Delegate enterFunc)
	{
		ViewStateData value = new ViewStateData(state, exitFunc, enterFunc);
		this.StateMap[state] = value;
	}

	// Token: 0x060086D1 RID: 34513 RVA: 0x001CC6BC File Offset: 0x001CA8BC
	public void SwitchToState(EBusinessSkipDefine state, params object[] params_)
	{
		this.PushStateStack.Push(state);
		ViewStateData viewStateData;
		if (this.StateMap.TryGetValue(this.CurrentStateInternal, out viewStateData))
		{
			Action exitFunc = viewStateData.ExitFunc;
			if (exitFunc != null)
			{
				exitFunc();
			}
		}
		this.CurrentStateInternal = state;
		ViewStateData viewStateData2;
		if (this.StateMap.TryGetValue(this.CurrentStateInternal, out viewStateData2))
		{
			viewStateData2.Params = params_;
			Action<object[]> action = viewStateData2.EnterFunc as Action<object[]>;
			if (action != null)
			{
				action(params_);
				return;
			}
			Action action2 = viewStateData2.EnterFunc as Action;
			if (action2 != null)
			{
				action2();
			}
		}
	}

	// Token: 0x060086D2 RID: 34514 RVA: 0x001CC74C File Offset: 0x001CA94C
	public void BackToState(EBusinessSkipDefine state)
	{
		if (this.CurrentStateInternal == state)
		{
			return;
		}
		while (this.PushStateStack.Peek() != state)
		{
			EBusinessSkipDefine key = this.PushStateStack.Pop();
			ViewStateData viewStateData;
			if (this.StateMap.TryGetValue(key, out viewStateData))
			{
				Action exitFunc = viewStateData.ExitFunc;
				if (exitFunc != null)
				{
					exitFunc();
				}
			}
		}
		this.CurrentStateInternal = state;
		ViewStateData viewStateData2;
		if (this.StateMap.TryGetValue(this.CurrentStateInternal, out viewStateData2))
		{
			Action<object[]> action = viewStateData2.EnterFunc as Action<object[]>;
			if (action != null)
			{
				action(viewStateData2.Params);
				return;
			}
			Action action2 = viewStateData2.EnterFunc as Action;
			if (action2 != null)
			{
				action2();
			}
		}
	}

	// Token: 0x060086D3 RID: 34515 RVA: 0x001CC7F0 File Offset: 0x001CA9F0
	public void BackToLastState()
	{
		EBusinessSkipDefine key = this.PushStateStack.Pop();
		ViewStateData viewStateData;
		if (this.StateMap.TryGetValue(key, out viewStateData))
		{
			Action exitFunc = viewStateData.ExitFunc;
			if (exitFunc != null)
			{
				exitFunc();
			}
		}
		this.CurrentStateInternal = this.PushStateStack.Peek();
		ViewStateData viewStateData2;
		if (this.StateMap.TryGetValue(this.CurrentStateInternal, out viewStateData2))
		{
			Action<object[]> action = viewStateData2.EnterFunc as Action<object[]>;
			if (action != null)
			{
				action(viewStateData2.Params);
				return;
			}
			Action action2 = viewStateData2.EnterFunc as Action;
			if (action2 != null)
			{
				action2();
			}
		}
	}

	// Token: 0x17000B89 RID: 2953
	// (get) Token: 0x060086D4 RID: 34516 RVA: 0x001CC884 File Offset: 0x001CAA84
	public EBusinessSkipDefine CurrentState
	{
		get
		{
			return this.CurrentStateInternal;
		}
	}

	// Token: 0x04003C44 RID: 15428
	private readonly global::Stack<EBusinessSkipDefine> PushStateStack = new global::Stack<EBusinessSkipDefine>();

	// Token: 0x04003C45 RID: 15429
	private EBusinessSkipDefine CurrentStateInternal;

	// Token: 0x04003C46 RID: 15430
	private readonly Dictionary<EBusinessSkipDefine, ViewStateData> StateMap = new Dictionary<EBusinessSkipDefine, ViewStateData>();
}
