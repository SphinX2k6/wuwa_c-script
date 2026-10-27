using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;

// Token: 0x020021EB RID: 8683
public abstract class MarkItemViewPoolBase
{
	// Token: 0x06010E5F RID: 69215 RVA: 0x0041CBE8 File Offset: 0x0041ADE8
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

	// Token: 0x06010E60 RID: 69216 RVA: 0x0041CC34 File Offset: 0x0041AE34
	[NullableContext(1)]
	public void Recycle(MarkPanelBase poolObj)
	{
		MarkPoolHandle item = new MarkPoolHandle
		{
			RecycleTimeStamp = Time.Instance.ServerTimeStamp,
			Obj = poolObj
		};
		this.Handles.Add(item);
	}

	// Token: 0x06010E61 RID: 69217 RVA: 0x0041CC6A File Offset: 0x0041AE6A
	public void Tick()
	{
		this.OnTick();
	}

	// Token: 0x06010E62 RID: 69218 RVA: 0x0041CC72 File Offset: 0x0041AE72
	protected virtual void OnTick()
	{
	}

	// Token: 0x06010E63 RID: 69219 RVA: 0x0041CC74 File Offset: 0x0041AE74
	public void Dispose()
	{
		this.OnDispose();
	}

	// Token: 0x06010E64 RID: 69220 RVA: 0x0041CC7C File Offset: 0x0041AE7C
	protected virtual void OnDispose()
	{
	}

	// Token: 0x04008073 RID: 32883
	[Nullable(1)]
	protected readonly List<IMarkPoolHandle> Handles = new List<IMarkPoolHandle>();
}
