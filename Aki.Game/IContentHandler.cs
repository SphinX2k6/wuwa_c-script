using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DD6 RID: 7638
[NullableContext(1)]
public interface IContentHandler
{
	// Token: 0x06012E8A RID: 77450
	void ShowItem(RoleFavorContentDataBase contentData);

	// Token: 0x06012E8B RID: 77451
	void PlayContent(RoleFavorContentDataBase contentData, RoleFavorContentItem roleFavorContentItem);
}
