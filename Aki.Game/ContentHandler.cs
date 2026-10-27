using System;
using System.Runtime.CompilerServices;

// Token: 0x0200285E RID: 10334
[NullableContext(1)]
[Nullable(0)]
public class ContentHandler<[Nullable(0)] T> : IContentHandler<T>, IContentHandler where T : RoleFavorContentDataBase
{
	// Token: 0x06015491 RID: 87185 RVA: 0x00560025 File Offset: 0x0055E225
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

	// Token: 0x06015492 RID: 87186 RVA: 0x0056003B File Offset: 0x0055E23B
	public void ShowItem(T contentData)
	{
		this.ShowItemAction(contentData);
	}

	// Token: 0x06015493 RID: 87187 RVA: 0x00560049 File Offset: 0x0055E249
	public void PlayContent(T contentData, RoleFavorContentItem roleFavorContentItem)
	{
		Action<T, RoleFavorContentItem> playContentAction = this.PlayContentAction;
		if (playContentAction == null)
		{
			return;
		}
		playContentAction(contentData, roleFavorContentItem);
	}

	// Token: 0x06015494 RID: 87188 RVA: 0x0056005D File Offset: 0x0055E25D
	void IContentHandler.ShowItem(RoleFavorContentDataBase contentData)
	{
		this.ShowItem((T)((object)contentData));
	}

	// Token: 0x06015495 RID: 87189 RVA: 0x0056006B File Offset: 0x0055E26B
	void IContentHandler.PlayContent(RoleFavorContentDataBase contentData, RoleFavorContentItem roleFavorContentItem)
	{
		this.PlayContent((T)((object)contentData), roleFavorContentItem);
	}

	// Token: 0x04009F02 RID: 40706
	private Action<T> ShowItemAction;

	// Token: 0x04009F03 RID: 40707
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<T, RoleFavorContentItem> PlayContentAction;
}
