using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054F2 RID: 21746
	public class ILevelSequenceSectionInfoT
	{
		// Token: 0x1700A073 RID: 41075
		// (get) Token: 0x06023E4D RID: 147021 RVA: 0x004F6919 File Offset: 0x004F4B19
		// (set) Token: 0x06023E4E RID: 147022 RVA: 0x004F6921 File Offset: 0x004F4B21
		public ELevelSequenceSectionType Type { get; set; }

		// Token: 0x1700A074 RID: 41076
		// (get) Token: 0x06023E4F RID: 147023 RVA: 0x004F692A File Offset: 0x004F4B2A
		// (set) Token: 0x06023E50 RID: 147024 RVA: 0x004F6932 File Offset: 0x004F4B32
		public string Key { get; set; }

		// Token: 0x1700A075 RID: 41077
		// (get) Token: 0x06023E51 RID: 147025 RVA: 0x004F693B File Offset: 0x004F4B3B
		// (set) Token: 0x06023E52 RID: 147026 RVA: 0x004F6943 File Offset: 0x004F4B43
		public int FrameId { get; set; }

		// Token: 0x1700A076 RID: 41078
		// (get) Token: 0x06023E53 RID: 147027 RVA: 0x004F694C File Offset: 0x004F4B4C
		// (set) Token: 0x06023E54 RID: 147028 RVA: 0x004F6954 File Offset: 0x004F4B54
		public string State { get; set; }

		// Token: 0x1700A077 RID: 41079
		// (get) Token: 0x06023E55 RID: 147029 RVA: 0x004F695D File Offset: 0x004F4B5D
		// (set) Token: 0x06023E56 RID: 147030 RVA: 0x004F6965 File Offset: 0x004F4B65
		public List<string> LoopStates { get; set; }

		// Token: 0x1700A078 RID: 41080
		// (get) Token: 0x06023E57 RID: 147031 RVA: 0x004F696E File Offset: 0x004F4B6E
		// (set) Token: 0x06023E58 RID: 147032 RVA: 0x004F6976 File Offset: 0x004F4B76
		public List<IActionInfoT> ActionList { get; set; }

		// Token: 0x1700A079 RID: 41081
		// (get) Token: 0x06023E59 RID: 147033 RVA: 0x004F697F File Offset: 0x004F4B7F
		// (set) Token: 0x06023E5A RID: 147034 RVA: 0x004F6987 File Offset: 0x004F4B87
		public byte NullMask { get; set; }

		// Token: 0x06023E5B RID: 147035 RVA: 0x004F6990 File Offset: 0x004F4B90
		public ILevelSequenceSectionInfoT()
		{
			this.Type = ELevelSequenceSectionType.Mark;
			this.Key = null;
			this.FrameId = 0;
			this.State = null;
			this.LoopStates = null;
			this.ActionList = null;
			this.NullMask = 0;
		}
	}
}
