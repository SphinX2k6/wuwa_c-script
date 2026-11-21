using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DD8 RID: 7640
public static class ContentHandlerFactory
{
	// Token: 0x06012E8E RID: 77454 RVA: 0x0058AD78 File Offset: 0x00588F78
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
