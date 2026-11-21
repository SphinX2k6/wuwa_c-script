using System;
using System.Runtime.CompilerServices;

// Token: 0x02000515 RID: 1301
[NullableContext(1)]
public interface IGuessJokerTipsData
{
	// Token: 0x170008E4 RID: 2276
	// (get) Token: 0x06003F65 RID: 16229
	// (set) Token: 0x06003F66 RID: 16230
	string TextId { get; set; }

	// Token: 0x170008E5 RID: 2277
	// (get) Token: 0x06003F67 RID: 16231
	// (set) Token: 0x06003F68 RID: 16232
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
