using System;
using System.Runtime.CompilerServices;

// Token: 0x020027E3 RID: 10211
public class TagSwitchedTask : ITagTask
{
	// Token: 0x06019AF4 RID: 105204 RVA: 0x007E9045 File Offset: 0x007E7245
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

	// Token: 0x06019AF5 RID: 105205 RVA: 0x007E9075 File Offset: 0x007E7275
	public void EndTask()
	{
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent == null)
		{
			return;
		}
		tagComponent.RemoveTagAddOrRemoveListener(this.TagId, this.Callback);
	}

	// Token: 0x0400E15E RID: 57694
	private int TagId;

	// Token: 0x0400E15F RID: 57695
	[Nullable(2)]
	private BaseTagComponent.TTagSwitchedCallback Callback;

	// Token: 0x0400E160 RID: 57696
	[Nullable(2)]
	private BaseTagComponent TagComponent;
}
