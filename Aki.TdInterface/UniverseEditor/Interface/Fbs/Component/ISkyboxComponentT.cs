using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F28 RID: 24360
	public class ISkyboxComponentT
	{
		// Token: 0x1700B44B RID: 46155
		// (get) Token: 0x06028E8C RID: 167564 RVA: 0x00596F2C File Offset: 0x0059512C
		// (set) Token: 0x06028E8D RID: 167565 RVA: 0x00596F34 File Offset: 0x00595134
		public bool Disabled { get; set; }

		// Token: 0x1700B44C RID: 46156
		// (get) Token: 0x06028E8E RID: 167566 RVA: 0x00596F3D File Offset: 0x0059513D
		// (set) Token: 0x06028E8F RID: 167567 RVA: 0x00596F45 File Offset: 0x00595145
		public string WeatherDataAsset { get; set; }

		// Token: 0x1700B44D RID: 46157
		// (get) Token: 0x06028E90 RID: 167568 RVA: 0x00596F4E File Offset: 0x0059514E
		// (set) Token: 0x06028E91 RID: 167569 RVA: 0x00596F56 File Offset: 0x00595156
		public string PPTODDataAsset { get; set; }

		// Token: 0x1700B44E RID: 46158
		// (get) Token: 0x06028E92 RID: 167570 RVA: 0x00596F5F File Offset: 0x0059515F
		// (set) Token: 0x06028E93 RID: 167571 RVA: 0x00596F67 File Offset: 0x00595167
		public int SkyboxSetting { get; set; }

		// Token: 0x1700B44F RID: 46159
		// (get) Token: 0x06028E94 RID: 167572 RVA: 0x00596F70 File Offset: 0x00595170
		// (set) Token: 0x06028E95 RID: 167573 RVA: 0x00596F78 File Offset: 0x00595178
		public float FadeTime { get; set; }

		// Token: 0x1700B450 RID: 46160
		// (get) Token: 0x06028E96 RID: 167574 RVA: 0x00596F81 File Offset: 0x00595181
		// (set) Token: 0x06028E97 RID: 167575 RVA: 0x00596F89 File Offset: 0x00595189
		public float Priority { get; set; }

		// Token: 0x1700B451 RID: 46161
		// (get) Token: 0x06028E98 RID: 167576 RVA: 0x00596F92 File Offset: 0x00595192
		// (set) Token: 0x06028E99 RID: 167577 RVA: 0x00596F9A File Offset: 0x0059519A
		public TTriggerModeUnion TriggerMode { get; set; }

		// Token: 0x1700B452 RID: 46162
		// (get) Token: 0x06028E9A RID: 167578 RVA: 0x00596FA3 File Offset: 0x005951A3
		// (set) Token: 0x06028E9B RID: 167579 RVA: 0x00596FAB File Offset: 0x005951AB
		public byte NullMask { get; set; }

		// Token: 0x06028E9C RID: 167580 RVA: 0x00596FB4 File Offset: 0x005951B4
		public ISkyboxComponentT()
		{
			this.Disabled = false;
			this.WeatherDataAsset = null;
			this.PPTODDataAsset = null;
			this.SkyboxSetting = 0;
			this.FadeTime = 0f;
			this.Priority = 0f;
			this.TriggerMode = null;
			this.NullMask = 0;
		}
	}
}
