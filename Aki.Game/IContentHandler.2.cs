using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DD7 RID: 7639
[NullableContext(1)]
public interface IContentHandler<[Nullable(0)] T> : IContentHandler where T : RoleFavorContentDataBase
{
	// Token: 0x06012E8C RID: 77452
	void ShowItem(T contentData);

	// Token: 0x06012E8D RID: 77453
	void PlayContent(T contentData, RoleFavorContentItem roleFavorContentItem);
}
