using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007287 RID: 29319
	public class ISystemOptionTypeT
	{
		// Token: 0x1700D985 RID: 55685
		// (get) Token: 0x0603405F RID: 213087 RVA: 0x006FEC6F File Offset: 0x006FCE6F
		// (set) Token: 0x06034060 RID: 213088 RVA: 0x006FEC77 File Offset: 0x006FCE77
		public ESystemOptionType Type { get; set; }

		// Token: 0x1700D986 RID: 55686
		// (get) Token: 0x06034061 RID: 213089 RVA: 0x006FEC80 File Offset: 0x006FCE80
		// (set) Token: 0x06034062 RID: 213090 RVA: 0x006FEC88 File Offset: 0x006FCE88
		public List<ISystemOptionT> SystemOptions { get; set; }

		// Token: 0x1700D987 RID: 55687
		// (get) Token: 0x06034063 RID: 213091 RVA: 0x006FEC91 File Offset: 0x006FCE91
		// (set) Token: 0x06034064 RID: 213092 RVA: 0x006FEC99 File Offset: 0x006FCE99
		public bool KeepPreTalkItem { get; set; }

		// Token: 0x1700D988 RID: 55688
		// (get) Token: 0x06034065 RID: 213093 RVA: 0x006FECA2 File Offset: 0x006FCEA2
		// (set) Token: 0x06034066 RID: 213094 RVA: 0x006FECAA File Offset: 0x006FCEAA
		public byte NullMask { get; set; }

		// Token: 0x06034067 RID: 213095 RVA: 0x006FECB3 File Offset: 0x006FCEB3
		public ISystemOptionTypeT()
		{
			this.Type = ESystemOptionType.RogueRandomEvent;
			this.SystemOptions = null;
			this.KeepPreTalkItem = false;
			this.NullMask = 0;
		}
	}
}
