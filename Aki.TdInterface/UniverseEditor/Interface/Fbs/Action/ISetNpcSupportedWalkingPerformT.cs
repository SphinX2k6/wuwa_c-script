using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007041 RID: 28737
	public class ISetNpcSupportedWalkingPerformT
	{
		// Token: 0x1700D56A RID: 54634
		// (get) Token: 0x06032D7E RID: 208254 RVA: 0x006DBA5D File Offset: 0x006D9C5D
		// (set) Token: 0x06032D7F RID: 208255 RVA: 0x006DBA65 File Offset: 0x006D9C65
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700D56B RID: 54635
		// (get) Token: 0x06032D80 RID: 208256 RVA: 0x006DBA6E File Offset: 0x006D9C6E
		// (set) Token: 0x06032D81 RID: 208257 RVA: 0x006DBA76 File Offset: 0x006D9C76
		public IPlayerInitiatorT Initiator { get; set; }

		// Token: 0x1700D56C RID: 54636
		// (get) Token: 0x06032D82 RID: 208258 RVA: 0x006DBA7F File Offset: 0x006D9C7F
		// (set) Token: 0x06032D83 RID: 208259 RVA: 0x006DBA87 File Offset: 0x006D9C87
		public int Target { get; set; }

		// Token: 0x06032D84 RID: 208260 RVA: 0x006DBA90 File Offset: 0x006D9C90
		public ISetNpcSupportedWalkingPerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Initiator = null;
			this.Target = 0;
		}
	}
}
