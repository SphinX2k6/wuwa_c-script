using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200703E RID: 28734
	public class ISetNpcHuggingBearPerformT
	{
		// Token: 0x1700D562 RID: 54626
		// (get) Token: 0x06032D62 RID: 208226 RVA: 0x006DB71F File Offset: 0x006D991F
		// (set) Token: 0x06032D63 RID: 208227 RVA: 0x006DB727 File Offset: 0x006D9927
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700D563 RID: 54627
		// (get) Token: 0x06032D64 RID: 208228 RVA: 0x006DB730 File Offset: 0x006D9930
		// (set) Token: 0x06032D65 RID: 208229 RVA: 0x006DB738 File Offset: 0x006D9938
		public IPlayerInitiatorT Initiator { get; set; }

		// Token: 0x1700D564 RID: 54628
		// (get) Token: 0x06032D66 RID: 208230 RVA: 0x006DB741 File Offset: 0x006D9941
		// (set) Token: 0x06032D67 RID: 208231 RVA: 0x006DB749 File Offset: 0x006D9949
		public int Target { get; set; }

		// Token: 0x1700D565 RID: 54629
		// (get) Token: 0x06032D68 RID: 208232 RVA: 0x006DB752 File Offset: 0x006D9952
		// (set) Token: 0x06032D69 RID: 208233 RVA: 0x006DB75A File Offset: 0x006D995A
		public ENpcGroupPerformNpcType NpcType { get; set; }

		// Token: 0x06032D6A RID: 208234 RVA: 0x006DB763 File Offset: 0x006D9963
		public ISetNpcHuggingBearPerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Initiator = null;
			this.Target = 0;
			this.NpcType = ENpcGroupPerformNpcType.LevelBCommonMale;
		}
	}
}
