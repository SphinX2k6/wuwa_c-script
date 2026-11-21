using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020007B6 RID: 1974
[NullableContext(1)]
[Nullable(0)]
internal class ViewStateManager
{
	// Token: 0x06005A6A RID: 23146 RVA: 0x001D54CD File Offset: 0x001D36CD
	public ViewStateManager()
	{
		this.CurrentStateInternal = EBusinessSkipDefine.MainView;
		this.PushStateStack.Push(this.CurrentStateInternal);
	}

	// Token: 0x06005A6B RID: 23147 RVA: 0x001D5504 File Offset: 0x001D3704
	[NullableContext(2)]
	public void RegisterViewState(EBusinessSkipDefine state, Action exitFunc, Delegate enterFunc)
	{
		ViewStateData value = new ViewStateData(state, exitFunc, enterFunc);
		this.StateMap[state] = value;
	}

	// Token: 0x06005A6C RID: 23148 RVA: 0x001D5528 File Offset: 0x001D3728
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

	// Token: 0x06005A6D RID: 23149 RVA: 0x001D55B8 File Offset: 0x001D37B8
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

	// Token: 0x06005A6E RID: 23150 RVA: 0x001D565C File Offset: 0x001D385C
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

	// Token: 0x17000BA9 RID: 2985
	// (get) Token: 0x06005A6F RID: 23151 RVA: 0x001D56F0 File Offset: 0x001D38F0
	public EBusinessSkipDefine CurrentState
	{
		get
		{
			return this.CurrentStateInternal;
		}
	}

	// Token: 0x04003CDC RID: 15580
	private readonly global::Stack<EBusinessSkipDefine> PushStateStack = new global::Stack<EBusinessSkipDefine>();

	// Token: 0x04003CDD RID: 15581
	private EBusinessSkipDefine CurrentStateInternal;

	// Token: 0x04003CDE RID: 15582
	private readonly Dictionary<EBusinessSkipDefine, ViewStateData> StateMap = new Dictionary<EBusinessSkipDefine, ViewStateData>();
}
