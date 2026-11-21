using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02005F88 RID: 24456
	public class GuaranteePreloadParams : ActionParams, IGuaranteePreloadParams
	{
		// Token: 0x17006EF6 RID: 28406
		// (get) Token: 0x0603ACB0 RID: 240816 RVA: 0x0109F7B5 File Offset: 0x0109D9B5
		// (set) Token: 0x0603ACB1 RID: 240817 RVA: 0x0109F7BD File Offset: 0x0109D9BD
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> Mp4Names { [return: Nullable(new byte[]
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
