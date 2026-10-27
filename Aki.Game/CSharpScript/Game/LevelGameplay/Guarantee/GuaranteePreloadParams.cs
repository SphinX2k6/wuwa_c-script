using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02006E08 RID: 28168
	public class GuaranteePreloadParams : ActionParams, IGuaranteePreloadParams
	{
		// Token: 0x170099F3 RID: 39411
		// (get) Token: 0x06044B4A RID: 281418 RVA: 0x010F53F5 File Offset: 0x010F35F5
		// (set) Token: 0x06044B4B RID: 281419 RVA: 0x010F53FD File Offset: 0x010F35FD
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
