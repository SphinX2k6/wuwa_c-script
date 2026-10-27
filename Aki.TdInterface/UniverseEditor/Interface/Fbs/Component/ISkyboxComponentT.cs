using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200591B RID: 22811
	public class ISkyboxComponentT
	{
		// Token: 0x1700AB17 RID: 43799
		// (get) Token: 0x06026922 RID: 157986 RVA: 0x005502C0 File Offset: 0x0054E4C0
		// (set) Token: 0x06026923 RID: 157987 RVA: 0x005502C8 File Offset: 0x0054E4C8
		public bool Disabled { get; set; }

		// Token: 0x1700AB18 RID: 43800
		// (get) Token: 0x06026924 RID: 157988 RVA: 0x005502D1 File Offset: 0x0054E4D1
		// (set) Token: 0x06026925 RID: 157989 RVA: 0x005502D9 File Offset: 0x0054E4D9
		public string WeatherDataAsset { get; set; }

		// Token: 0x1700AB19 RID: 43801
		// (get) Token: 0x06026926 RID: 157990 RVA: 0x005502E2 File Offset: 0x0054E4E2
		// (set) Token: 0x06026927 RID: 157991 RVA: 0x005502EA File Offset: 0x0054E4EA
		public string PPTODDataAsset { get; set; }

		// Token: 0x1700AB1A RID: 43802
		// (get) Token: 0x06026928 RID: 157992 RVA: 0x005502F3 File Offset: 0x0054E4F3
		// (set) Token: 0x06026929 RID: 157993 RVA: 0x005502FB File Offset: 0x0054E4FB
		public int SkyboxSetting { get; set; }

		// Token: 0x1700AB1B RID: 43803
		// (get) Token: 0x0602692A RID: 157994 RVA: 0x00550304 File Offset: 0x0054E504
		// (set) Token: 0x0602692B RID: 157995 RVA: 0x0055030C File Offset: 0x0054E50C
		public float FadeTime { get; set; }

		// Token: 0x1700AB1C RID: 43804
		// (get) Token: 0x0602692C RID: 157996 RVA: 0x00550315 File Offset: 0x0054E515
		// (set) Token: 0x0602692D RID: 157997 RVA: 0x0055031D File Offset: 0x0054E51D
		public float Priority { get; set; }

		// Token: 0x1700AB1D RID: 43805
		// (get) Token: 0x0602692E RID: 157998 RVA: 0x00550326 File Offset: 0x0054E526
		// (set) Token: 0x0602692F RID: 157999 RVA: 0x0055032E File Offset: 0x0054E52E
		public TTriggerModeUnion TriggerMode { get; set; }

		// Token: 0x1700AB1E RID: 43806
		// (get) Token: 0x06026930 RID: 158000 RVA: 0x00550337 File Offset: 0x0054E537
		// (set) Token: 0x06026931 RID: 158001 RVA: 0x0055033F File Offset: 0x0054E53F
		public byte NullMask { get; set; }

		// Token: 0x06026932 RID: 158002 RVA: 0x00550348 File Offset: 0x0054E548
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
