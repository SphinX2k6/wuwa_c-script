using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F6C RID: 28524
	public class IHandBookRollbackEmojiOptionT
	{
		// Token: 0x1700D0F8 RID: 53496
		// (get) Token: 0x060315F8 RID: 202232 RVA: 0x006B231F File Offset: 0x006B051F
		// (set) Token: 0x060315F9 RID: 202233 RVA: 0x006B2327 File Offset: 0x006B0527
		public EHandBookProgressType Type { get; set; }

		// Token: 0x1700D0F9 RID: 53497
		// (get) Token: 0x060315FA RID: 202234 RVA: 0x006B2330 File Offset: 0x006B0530
		// (set) Token: 0x060315FB RID: 202235 RVA: 0x006B2338 File Offset: 0x006B0538
		public List<int> EmojiIds { get; set; }

		// Token: 0x060315FC RID: 202236 RVA: 0x006B2341 File Offset: 0x006B0541
		public IHandBookRollbackEmojiOptionT()
		{
			this.Type = EHandBookProgressType.GrantEmoji;
			this.EmojiIds = null;
		}
	}
}
