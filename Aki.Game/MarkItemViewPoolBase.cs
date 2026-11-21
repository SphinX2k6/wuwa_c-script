using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;

// Token: 0x020016CF RID: 5839
[NullableContext(1)]
[Nullable(0)]
public abstract class MarkItemViewPoolBase
{
	// Token: 0x0600E2F1 RID: 58097 RVA: 0x00429520 File Offset: 0x00427720
	[NullableContext(0)]
	[return: Nullable(2)]
	public T Get<T>() where T : MarkPanelBase
	{
		if (this.Handles.Count > 0)
		{
			IMarkPoolHandle markPoolHandle = this.Handles[0];
			this.Handles.RemoveAt(0);
			return markPoolHandle.Obj as T;
		}
		return default(T);
	}

	// Token: 0x0600E2F2 RID: 58098 RVA: 0x0042956C File Offset: 0x0042776C
	public void Recycle(MarkPanelBase poolObj)
	{
		MarkPoolHandle item = new MarkPoolHandle
		{
			RecycleTimeStamp = Time.Instance.ServerTimeStamp,
			Obj = poolObj
		};
		this.Handles.Add(item);
	}

	// Token: 0x0600E2F3 RID: 58099 RVA: 0x004295A2 File Offset: 0x004277A2
	public void Tick()
	{
		this.OnTick();
	}

	// Token: 0x0600E2F4 RID: 58100 RVA: 0x004295AA File Offset: 0x004277AA
	protected virtual void OnTick()
	{
	}

	// Token: 0x0600E2F5 RID: 58101 RVA: 0x004295AC File Offset: 0x004277AC
	public void Dispose()
	{
		this.OnDispose();
	}

	// Token: 0x0600E2F6 RID: 58102 RVA: 0x004295B4 File Offset: 0x004277B4
	public void CollectViews(List<MarkPanelBase> result)
	{
		foreach (IMarkPoolHandle markPoolHandle in this.Handles)
		{
			result.Add(markPoolHandle.Obj);
		}
	}

	// Token: 0x0600E2F7 RID: 58103 RVA: 0x0042960C File Offset: 0x0042780C
	protected virtual void OnDispose()
	{
	}

	// Token: 0x040081B1 RID: 33201
	protected readonly List<IMarkPoolHandle> Handles = new List<IMarkPoolHandle>();
}
