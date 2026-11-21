using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FCA RID: 4042
[NullableContext(1)]
public interface IFloroRanchCardOrToyData
{
	// Token: 0x17001156 RID: 4438
	// (get) Token: 0x0600A196 RID: 41366
	int Id { get; }

	// Token: 0x0600A197 RID: 41367
	string GetName();

	// Token: 0x17001157 RID: 4439
	// (get) Token: 0x0600A198 RID: 41368
	string Name { get; }

	// Token: 0x17001158 RID: 4440
	// (get) Token: 0x0600A199 RID: 41369
	string Desc { get; }

	// Token: 0x0600A19A RID: 41370
	int GetRarity();

	// Token: 0x0600A19B RID: 41371
	string GetIcon();
}
