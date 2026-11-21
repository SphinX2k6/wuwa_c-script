using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A23 RID: 31267
	public class ISwitchDataLayersT
	{
		// Token: 0x1700E51A RID: 58650
		// (get) Token: 0x0603718A RID: 225674 RVA: 0x0075CBF7 File Offset: 0x0075ADF7
		// (set) Token: 0x0603718B RID: 225675 RVA: 0x0075CBFF File Offset: 0x0075ADFF
		public List<int> LoadDataLayers { get; set; }

		// Token: 0x1700E51B RID: 58651
		// (get) Token: 0x0603718C RID: 225676 RVA: 0x0075CC08 File Offset: 0x0075AE08
		// (set) Token: 0x0603718D RID: 225677 RVA: 0x0075CC10 File Offset: 0x0075AE10
		public List<int> UnloadDataLayers { get; set; }

		// Token: 0x1700E51C RID: 58652
		// (get) Token: 0x0603718E RID: 225678 RVA: 0x0075CC19 File Offset: 0x0075AE19
		// (set) Token: 0x0603718F RID: 225679 RVA: 0x0075CC21 File Offset: 0x0075AE21
		public ISwitchDataLayersTransitionWithSequenceT TransitionOption { get; set; }

		// Token: 0x1700E51D RID: 58653
		// (get) Token: 0x06037190 RID: 225680 RVA: 0x0075CC2A File Offset: 0x0075AE2A
		// (set) Token: 0x06037191 RID: 225681 RVA: 0x0075CC32 File Offset: 0x0075AE32
		public string MaterialDataForLoadedLayers { get; set; }

		// Token: 0x1700E51E RID: 58654
		// (get) Token: 0x06037192 RID: 225682 RVA: 0x0075CC3B File Offset: 0x0075AE3B
		// (set) Token: 0x06037193 RID: 225683 RVA: 0x0075CC43 File Offset: 0x0075AE43
		public string MaterialDataForUnloadLayers { get; set; }

		// Token: 0x06037194 RID: 225684 RVA: 0x0075CC4C File Offset: 0x0075AE4C
		public ISwitchDataLayersT()
		{
			this.LoadDataLayers = null;
			this.UnloadDataLayers = null;
			this.TransitionOption = null;
			this.MaterialDataForLoadedLayers = null;
			this.MaterialDataForUnloadLayers = null;
		}
	}
}
