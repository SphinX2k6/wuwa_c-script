using System;
using System.Runtime.CompilerServices;

// Token: 0x0200285B RID: 10331
[NullableContext(1)]
public interface IContentHandler
{
	// Token: 0x0601548C RID: 87180
	void ShowItem(RoleFavorContentDataBase contentData);

	// Token: 0x0601548D RID: 87181
	void PlayContent(RoleFavorContentDataBase contentData, RoleFavorContentItem roleFavorContentItem);
}
