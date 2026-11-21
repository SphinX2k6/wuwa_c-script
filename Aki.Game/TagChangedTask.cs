using System;
using System.Runtime.CompilerServices;

// Token: 0x020027E4 RID: 10212
public class TagChangedTask : ITagTask
{
	// Token: 0x06019AF7 RID: 105207 RVA: 0x007E909B File Offset: 0x007E729B
	[NullableContext(1)]
	public void StartTask(int tagId, BaseTagComponent.TTagChangedCallback callback, BaseTagComponent tagComponent, [Nullable(2)] Stat callbackStat = null)
	{
		this.TagId = tagId;
		this.Callback = callback;
		this.TagComponent = tagComponent;
		BaseTagComponent tagComponent2 = this.TagComponent;
		if (tagComponent2 == null)
		{
			return;
		}
		tagComponent2.AddTagChangedListener(this.TagId, this.Callback, callbackStat);
	}

	// Token: 0x06019AF8 RID: 105208 RVA: 0x007E90D0 File Offset: 0x007E72D0
	public void EndTask()
	{
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent == null)
		{
			return;
		}
		tagComponent.RemoveTagChangedListener(this.TagId, this.Callback);
	}

	// Token: 0x0400E161 RID: 57697
	private int TagId;

	// Token: 0x0400E162 RID: 57698
	[Nullable(2)]
	private BaseTagComponent.TTagChangedCallback Callback;

	// Token: 0x0400E163 RID: 57699
	[Nullable(2)]
	private BaseTagComponent TagComponent;
}
