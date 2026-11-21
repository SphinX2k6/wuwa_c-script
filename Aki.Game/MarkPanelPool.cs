using System;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;

// Token: 0x020016D0 RID: 5840
public class MarkPanelPool : MarkItemViewPoolBase
{
	// Token: 0x0600E2F9 RID: 58105 RVA: 0x00429624 File Offset: 0x00427824
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

	// Token: 0x0600E2FA RID: 58106 RVA: 0x00429690 File Offset: 0x00427890
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

	// Token: 0x040081B2 RID: 33202
	public const int MAX_PANEL_HANDLE_CACHE_TIME = 10000;
}
