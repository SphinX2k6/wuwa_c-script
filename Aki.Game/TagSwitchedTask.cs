using System;
using System.Runtime.CompilerServices;

// Token: 0x02003274 RID: 12916
public class TagSwitchedTask : ITagTask
{
	// Token: 0x0601BF11 RID: 114449 RVA: 0x007C1C0D File Offset: 0x007BFE0D
	[NullableContext(1)]
	public void StartTask(int tagId, BaseTagComponent.TTagSwitchedCallback callback, BaseTagComponent tagComponent, [Nullable(2)] Stat callbackStat = null)
	{
		this.TagId = tagId;
		this.Callback = callback;
		this.TagComponent = tagComponent;
		BaseTagComponent tagComponent2 = this.TagComponent;
		if (tagComponent2 == null)
		{
			return;
		}
		tagComponent2.AddTagAddOrRemoveListener(this.TagId, callback, callbackStat);
	}

	// Token: 0x0601BF12 RID: 114450 RVA: 0x007C1C3D File Offset: 0x007BFE3D
	public void EndTask()
	{
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent == null)
		{
			return;
		}
		tagComponent.RemoveTagAddOrRemoveListener(this.TagId, this.Callback);
	}

	// Token: 0x0400DCBF RID: 56511
	private int TagId;

	// Token: 0x0400DCC0 RID: 56512
	[Nullable(2)]
	private BaseTagComponent.TTagSwitchedCallback Callback;

	// Token: 0x0400DCC1 RID: 56513
	[Nullable(2)]
	private BaseTagComponent TagComponent;
}
