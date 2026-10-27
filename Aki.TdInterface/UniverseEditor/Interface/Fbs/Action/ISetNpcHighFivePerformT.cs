using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200703B RID: 28731
	public class ISetNpcHighFivePerformT
	{
		// Token: 0x1700D559 RID: 54617
		// (get) Token: 0x06032D44 RID: 208196 RVA: 0x006DB37F File Offset: 0x006D957F
		// (set) Token: 0x06032D45 RID: 208197 RVA: 0x006DB387 File Offset: 0x006D9587
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700D55A RID: 54618
		// (get) Token: 0x06032D46 RID: 208198 RVA: 0x006DB390 File Offset: 0x006D9590
		// (set) Token: 0x06032D47 RID: 208199 RVA: 0x006DB398 File Offset: 0x006D9598
		public IPlayerInitiatorT Initiator { get; set; }

		// Token: 0x1700D55B RID: 54619
		// (get) Token: 0x06032D48 RID: 208200 RVA: 0x006DB3A1 File Offset: 0x006D95A1
		// (set) Token: 0x06032D49 RID: 208201 RVA: 0x006DB3A9 File Offset: 0x006D95A9
		public int Target { get; set; }

		// Token: 0x1700D55C RID: 54620
		// (get) Token: 0x06032D4A RID: 208202 RVA: 0x006DB3B2 File Offset: 0x006D95B2
		// (set) Token: 0x06032D4B RID: 208203 RVA: 0x006DB3BA File Offset: 0x006D95BA
		public ENpcGroupPerformNpcType NpcType { get; set; }

		// Token: 0x06032D4C RID: 208204 RVA: 0x006DB3C3 File Offset: 0x006D95C3
		public ISetNpcHighFivePerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Initiator = null;
			this.Target = 0;
			this.NpcType = ENpcGroupPerformNpcType.LevelBCommonMale;
		}
	}
}
