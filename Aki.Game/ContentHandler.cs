using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DD9 RID: 7641
[NullableContext(1)]
[Nullable(0)]
public class ContentHandler<[Nullable(0)] T> : IContentHandler<T>, IContentHandler where T : RoleFavorContentDataBase
{
	// Token: 0x06012E8F RID: 77455 RVA: 0x0058AD81 File Offset: 0x00588F81
	public ContentHandler(Action<T> showItem, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] Action<T, RoleFavorContentItem> playContent)
	{
		this.ShowItemAction = showItem;
		this.PlayContentAction = playContent;
	}

	// Token: 0x06012E90 RID: 77456 RVA: 0x0058AD97 File Offset: 0x00588F97
	public void ShowItem(T contentData)
	{
		this.ShowItemAction(contentData);
	}

	// Token: 0x06012E91 RID: 77457 RVA: 0x0058ADA5 File Offset: 0x00588FA5
	public void PlayContent(T contentData, RoleFavorContentItem roleFavorContentItem)
	{
		Action<T, RoleFavorContentItem> playContentAction = this.PlayContentAction;
		if (playContentAction == null)
		{
			return;
		}
		playContentAction(contentData, roleFavorContentItem);
	}

	// Token: 0x06012E92 RID: 77458 RVA: 0x0058ADB9 File Offset: 0x00588FB9
	void IContentHandler.ShowItem(RoleFavorContentDataBase contentData)
	{
		this.ShowItem((T)((object)contentData));
	}

	// Token: 0x06012E93 RID: 77459 RVA: 0x0058ADC7 File Offset: 0x00588FC7
	void IContentHandler.PlayContent(RoleFavorContentDataBase contentData, RoleFavorContentItem roleFavorContentItem)
	{
		this.PlayContent((T)((object)contentData), roleFavorContentItem);
	}

	// Token: 0x0400A2EB RID: 41707
	private Action<T> ShowItemAction;

	// Token: 0x0400A2EC RID: 41708
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<T, RoleFavorContentItem> PlayContentAction;
}
