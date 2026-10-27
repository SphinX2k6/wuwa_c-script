using System;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;

// Token: 0x020021EC RID: 8684
public class MarkPanelPool : MarkItemViewPoolBase
{
	// Token: 0x06010E66 RID: 69222 RVA: 0x0041CC94 File Offset: 0x0041AE94
	protected override void OnTick()
	{
		for (int i = this.Handles.Count - 1; i >= 0; i--)
		{
			IMarkPoolHandle markPoolHandle = this.Handles[i];
			if (Time.Instance.ServerTimeStamp - markPoolHandle.RecycleTimeStamp > 10000.0)
			{
				MarkPanelBase obj = markPoolHandle.Obj;
				if (obj != null)
				{
					obj.RecycleToPool();
				}
				this.Handles.RemoveAt(i);
			}
		}
	}

	// Token: 0x06010E67 RID: 69223 RVA: 0x0041CD00 File Offset: 0x0041AF00
	protected override void OnDispose()
	{
		foreach (IMarkPoolHandle markPoolHandle in this.Handles)
		{
			MarkPanelBase obj = markPoolHandle.Obj;
			if (obj != null)
			{
				obj.RecycleToPool();
			}
		}
		this.Handles.Clear();
	}

	// Token: 0x04008074 RID: 32884
	public const int MAX_PANEL_HANDLE_CACHE_TIME = 10000;
}
