using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02005F87 RID: 24455
	public interface IGuaranteePreloadParams
	{
		// Token: 0x17006EF5 RID: 28405
		// (get) Token: 0x0603ACAE RID: 240814
		// (set) Token: 0x0603ACAF RID: 240815
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
