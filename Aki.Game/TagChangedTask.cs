using System;
using System.Runtime.CompilerServices;

// Token: 0x02003275 RID: 12917
public class TagChangedTask : ITagTask
{
	// Token: 0x0601BF14 RID: 114452 RVA: 0x007C1C63 File Offset: 0x007BFE63
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

	// Token: 0x0601BF15 RID: 114453 RVA: 0x007C1C98 File Offset: 0x007BFE98
	public void EndTask()
	{
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent == null)
		{
			return;
		}
		tagComponent.RemoveTagChangedListener(this.TagId, this.Callback);
	}

	// Token: 0x0400DCC2 RID: 56514
	private int TagId;

	// Token: 0x0400DCC3 RID: 56515
	[Nullable(2)]
	private BaseTagComponent.TTagChangedCallback Callback;

	// Token: 0x0400DCC4 RID: 56516
	[Nullable(2)]
	private BaseTagComponent TagComponent;
}
