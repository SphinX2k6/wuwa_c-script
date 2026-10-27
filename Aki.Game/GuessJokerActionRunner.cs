using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200102B RID: 4139
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerActionRunner<[Nullable(0)] T> where T : GuessJokerActionBase
{
	// Token: 0x06006A38 RID: 27192 RVA: 0x00155019 File Offset: 0x00153219
	public void PushAction(T action)
	{
		this.Queue.Add(action);
	}

	// Token: 0x06006A39 RID: 27193 RVA: 0x00155028 File Offset: 0x00153228
	public void PushActions(IReadOnlyList<T> actions)
	{
		foreach (T item in actions)
		{
			this.Queue.Add(item);
		}
	}

	// Token: 0x06006A3A RID: 27194 RVA: 0x00155078 File Offset: 0x00153278
	public void Tick(float delta)
	{
		if (this.CurrentAction == null)
		{
			this.CurrentAction = this.GetNextAction();
			if (this.CurrentAction != null)
			{
				this.CurrentAction.Start();
			}
		}
		if (this.CurrentAction != null)
		{
			this.CurrentAction.Tick(delta);
			if (this.CurrentAction.IsDone())
			{
				this.OnActionDone(this.CurrentAction);
				this.CurrentAction.Finish();
				this.CurrentAction = default(T);
			}
		}
		this.OnTick(delta);
	}

	// Token: 0x06006A3B RID: 27195 RVA: 0x0015511A File Offset: 0x0015331A
	public void Destroy()
	{
		this.OnDestroy();
		if (this.CurrentAction != null)
		{
			this.CurrentAction.Finish();
		}
		this.Queue.Clear();
		this.CurrentAction = default(T);
	}

	// Token: 0x06006A3C RID: 27196 RVA: 0x00155158 File Offset: 0x00153358
	[NullableContext(2)]
	protected T GetNextAction()
	{
		if (this.Queue.Count == 0)
		{
			return default(T);
		}
		T result = this.Queue[0];
		this.Queue.RemoveAt(0);
		return result;
	}

	// Token: 0x06006A3D RID: 27197 RVA: 0x00155194 File Offset: 0x00153394
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x06006A3E RID: 27198 RVA: 0x00155196 File Offset: 0x00153396
	protected virtual void OnActionDone(T action)
	{
	}

	// Token: 0x06006A3F RID: 27199 RVA: 0x00155198 File Offset: 0x00153398
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x040030F4 RID: 12532
	protected readonly List<T> Queue = new List<T>();

	// Token: 0x040030F5 RID: 12533
	[Nullable(2)]
	protected T CurrentAction;
}
