using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02006E07 RID: 28167
	public interface IGuaranteePreloadParams
	{
		// Token: 0x170099F2 RID: 39410
		// (get) Token: 0x06044B48 RID: 281416
		// (set) Token: 0x06044B49 RID: 281417
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<string> Mp4Names { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
