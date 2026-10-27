using System;
using System.Runtime.CompilerServices;

// Token: 0x0200285D RID: 10333
public static class ContentHandlerFactory
{
	// Token: 0x06015490 RID: 87184 RVA: 0x0056001C File Offset: 0x0055E21C
	[NullableContext(1)]
	public static IContentHandler<T> CreateContentHandler<[Nullable(0)] T>(Action<T> showItem, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] Action<T, RoleFavorContentItem> playContent = null) where T : RoleFavorContentDataBase
	{
		return new ContentHandler<T>(showItem, playContent);
	}
}
