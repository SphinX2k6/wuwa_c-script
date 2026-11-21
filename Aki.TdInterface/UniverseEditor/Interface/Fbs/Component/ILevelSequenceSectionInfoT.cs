using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A78 RID: 23160
	public class ILevelSequenceSectionInfoT
	{
		// Token: 0x1700A8AD RID: 43181
		// (get) Token: 0x06025F07 RID: 155399 RVA: 0x00533A3D File Offset: 0x00531C3D
		// (set) Token: 0x06025F08 RID: 155400 RVA: 0x00533A45 File Offset: 0x00531C45
		public ELevelSequenceSectionType Type { get; set; }

		// Token: 0x1700A8AE RID: 43182
		// (get) Token: 0x06025F09 RID: 155401 RVA: 0x00533A4E File Offset: 0x00531C4E
		// (set) Token: 0x06025F0A RID: 155402 RVA: 0x00533A56 File Offset: 0x00531C56
		public string Key { get; set; }

		// Token: 0x1700A8AF RID: 43183
		// (get) Token: 0x06025F0B RID: 155403 RVA: 0x00533A5F File Offset: 0x00531C5F
		// (set) Token: 0x06025F0C RID: 155404 RVA: 0x00533A67 File Offset: 0x00531C67
		public int FrameId { get; set; }

		// Token: 0x1700A8B0 RID: 43184
		// (get) Token: 0x06025F0D RID: 155405 RVA: 0x00533A70 File Offset: 0x00531C70
		// (set) Token: 0x06025F0E RID: 155406 RVA: 0x00533A78 File Offset: 0x00531C78
		public string State { get; set; }

		// Token: 0x1700A8B1 RID: 43185
		// (get) Token: 0x06025F0F RID: 155407 RVA: 0x00533A81 File Offset: 0x00531C81
		// (set) Token: 0x06025F10 RID: 155408 RVA: 0x00533A89 File Offset: 0x00531C89
		public List<string> LoopStates { get; set; }

		// Token: 0x1700A8B2 RID: 43186
		// (get) Token: 0x06025F11 RID: 155409 RVA: 0x00533A92 File Offset: 0x00531C92
		// (set) Token: 0x06025F12 RID: 155410 RVA: 0x00533A9A File Offset: 0x00531C9A
		public List<IActionInfoT> ActionList { get; set; }

		// Token: 0x1700A8B3 RID: 43187
		// (get) Token: 0x06025F13 RID: 155411 RVA: 0x00533AA3 File Offset: 0x00531CA3
		// (set) Token: 0x06025F14 RID: 155412 RVA: 0x00533AAB File Offset: 0x00531CAB
		public byte NullMask { get; set; }

		// Token: 0x06025F15 RID: 155413 RVA: 0x00533AB4 File Offset: 0x00531CB4
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
