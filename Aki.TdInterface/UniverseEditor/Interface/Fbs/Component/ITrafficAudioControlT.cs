using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AC1 RID: 23233
	public class ITrafficAudioControlT
	{
		// Token: 0x1700AEFB RID: 44795
		// (get) Token: 0x0602797E RID: 162174 RVA: 0x00571FDF File Offset: 0x005701DF
		// (set) Token: 0x0602797F RID: 162175 RVA: 0x00571FE7 File Offset: 0x005701E7
		public EAudioControlType Type { get; set; }

		// Token: 0x1700AEFC RID: 44796
		// (get) Token: 0x06027980 RID: 162176 RVA: 0x00571FF0 File Offset: 0x005701F0
		// (set) Token: 0x06027981 RID: 162177 RVA: 0x00571FF8 File Offset: 0x005701F8
		public string EngineAudio { get; set; }

		// Token: 0x1700AEFD RID: 44797
		// (get) Token: 0x06027982 RID: 162178 RVA: 0x00572001 File Offset: 0x00570201
		// (set) Token: 0x06027983 RID: 162179 RVA: 0x00572009 File Offset: 0x00570209
		public string BrakingAudio { get; set; }

		// Token: 0x1700AEFE RID: 44798
		// (get) Token: 0x06027984 RID: 162180 RVA: 0x00572012 File Offset: 0x00570212
		// (set) Token: 0x06027985 RID: 162181 RVA: 0x0057201A File Offset: 0x0057021A
		public string BrakingShortAudio { get; set; }

		// Token: 0x1700AEFF RID: 44799
		// (get) Token: 0x06027986 RID: 162182 RVA: 0x00572023 File Offset: 0x00570223
		// (set) Token: 0x06027987 RID: 162183 RVA: 0x0057202B File Offset: 0x0057022B
		public string HornAudio { get; set; }

		// Token: 0x06027988 RID: 162184 RVA: 0x00572034 File Offset: 0x00570234
		public ITrafficAudioControlT()
		{
			this.Type = EAudioControlType.Gramophone;
			this.EngineAudio = null;
			this.BrakingAudio = null;
			this.BrakingShortAudio = null;
			this.HornAudio = null;
		}
	}
}
