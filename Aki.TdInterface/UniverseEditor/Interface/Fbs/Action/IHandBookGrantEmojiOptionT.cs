using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F60 RID: 28512
	public class IHandBookGrantEmojiOptionT
	{
		// Token: 0x1700D0EB RID: 53483
		// (get) Token: 0x060315A4 RID: 202148 RVA: 0x006B1A3B File Offset: 0x006AFC3B
		// (set) Token: 0x060315A5 RID: 202149 RVA: 0x006B1A43 File Offset: 0x006AFC43
		public EHandBookProgressType Type { get; set; }

		// Token: 0x1700D0EC RID: 53484
		// (get) Token: 0x060315A6 RID: 202150 RVA: 0x006B1A4C File Offset: 0x006AFC4C
		// (set) Token: 0x060315A7 RID: 202151 RVA: 0x006B1A54 File Offset: 0x006AFC54
		public List<int> EmojiIds { get; set; }

		// Token: 0x060315A8 RID: 202152 RVA: 0x006B1A5D File Offset: 0x006AFC5D
		public IHandBookGrantEmojiOptionT()
		{
			this.Type = EHandBookProgressType.GrantEmoji;
			this.EmojiIds = null;
		}
	}
}
