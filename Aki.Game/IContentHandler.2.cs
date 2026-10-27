using System;
using System.Runtime.CompilerServices;

// Token: 0x0200285C RID: 10332
[NullableContext(1)]
public interface IContentHandler<[Nullable(0)] T> : IContentHandler where T : RoleFavorContentDataBase
{
	// Token: 0x0601548E RID: 87182
	void ShowItem(T contentData);

	// Token: 0x0601548F RID: 87183
	void PlayContent(T contentData, RoleFavorContentItem roleFavorContentItem);
}
