using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020004DF RID: 1247
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerActionRunner<[Nullable(0)] T> where T : GuessJokerActionBase
{
	// Token: 0x06003DCD RID: 15821 RVA: 0x0015D941 File Offset: 0x0015BB41
	public void PushAction(T action)
	{
		this.Queue.Add(action);
	}

	// Token: 0x06003DCE RID: 15822 RVA: 0x0015D950 File Offset: 0x0015BB50
	public void PushActions(IReadOnlyList<T> actions)
	{
		foreach (T item in actions)
		{
			this.Queue.Add(item);
		}
	}

	// Token: 0x06003DCF RID: 15823 RVA: 0x0015D9A0 File Offset: 0x0015BBA0
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

	// Token: 0x06003DD0 RID: 15824 RVA: 0x0015DA42 File Offset: 0x0015BC42
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

	// Token: 0x06003DD1 RID: 15825 RVA: 0x0015DA80 File Offset: 0x0015BC80
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

	// Token: 0x06003DD2 RID: 15826 RVA: 0x0015DABC File Offset: 0x0015BCBC
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x06003DD3 RID: 15827 RVA: 0x0015DABE File Offset: 0x0015BCBE
	protected virtual void OnActionDone(T action)
	{
	}

	// Token: 0x06003DD4 RID: 15828 RVA: 0x0015DAC0 File Offset: 0x0015BCC0
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x0400318D RID: 12685
	protected readonly List<T> Queue = new List<T>();

	// Token: 0x0400318E RID: 12686
	[Nullable(2)]
	protected T CurrentAction;
}
