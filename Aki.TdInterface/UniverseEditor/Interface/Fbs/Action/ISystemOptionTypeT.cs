using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A5C RID: 31324
	public class ISystemOptionTypeT
	{
		// Token: 0x1700E57E RID: 58750
		// (get) Token: 0x06037361 RID: 226145 RVA: 0x0075FFCF File Offset: 0x0075E1CF
		// (set) Token: 0x06037362 RID: 226146 RVA: 0x0075FFD7 File Offset: 0x0075E1D7
		public ESystemOptionType Type { get; set; }

		// Token: 0x1700E57F RID: 58751
		// (get) Token: 0x06037363 RID: 226147 RVA: 0x0075FFE0 File Offset: 0x0075E1E0
		// (set) Token: 0x06037364 RID: 226148 RVA: 0x0075FFE8 File Offset: 0x0075E1E8
		public List<ISystemOptionT> SystemOptions { get; set; }

		// Token: 0x1700E580 RID: 58752
		// (get) Token: 0x06037365 RID: 226149 RVA: 0x0075FFF1 File Offset: 0x0075E1F1
		// (set) Token: 0x06037366 RID: 226150 RVA: 0x0075FFF9 File Offset: 0x0075E1F9
		public bool KeepPreTalkItem { get; set; }

		// Token: 0x1700E581 RID: 58753
		// (get) Token: 0x06037367 RID: 226151 RVA: 0x00760002 File Offset: 0x0075E202
		// (set) Token: 0x06037368 RID: 226152 RVA: 0x0076000A File Offset: 0x0075E20A
		public byte NullMask { get; set; }

		// Token: 0x06037369 RID: 226153 RVA: 0x00760013 File Offset: 0x0075E213
		public ISystemOptionTypeT()
		{
			this.Type = ESystemOptionType.RogueRandomEvent;
			this.SystemOptions = null;
			this.KeepPreTalkItem = false;
			this.NullMask = 0;
		}
	}
}
