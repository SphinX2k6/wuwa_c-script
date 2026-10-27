using System;
using System.Runtime.CompilerServices;

// Token: 0x02001061 RID: 4193
[NullableContext(1)]
public interface IGuessJokerTipsData
{
	// Token: 0x170008C4 RID: 2244
	// (get) Token: 0x06006BD0 RID: 27600
	// (set) Token: 0x06006BD1 RID: 27601
	string TextId { get; set; }

	// Token: 0x170008C5 RID: 2245
	// (get) Token: 0x06006BD2 RID: 27602
	// (set) Token: 0x06006BD3 RID: 27603
	[Nullable(new byte[]
	{
		2,
		1
	})]
	string[] TextParam { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }
}
