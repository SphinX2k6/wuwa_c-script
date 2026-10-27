using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007275 RID: 29301
	public class ISwitchTrailChainEffectStateT
	{
		// Token: 0x1700D969 RID: 55657
		// (get) Token: 0x06033FD3 RID: 212947 RVA: 0x006FDD3D File Offset: 0x006FBF3D
		// (set) Token: 0x06033FD4 RID: 212948 RVA: 0x006FDD45 File Offset: 0x006FBF45
		public ESwitchEffectStateEffectType Type { get; set; }

		// Token: 0x1700D96A RID: 55658
		// (get) Token: 0x06033FD5 RID: 212949 RVA: 0x006FDD4E File Offset: 0x006FBF4E
		// (set) Token: 0x06033FD6 RID: 212950 RVA: 0x006FDD56 File Offset: 0x006FBF56
		public int Count { get; set; }

		// Token: 0x1700D96B RID: 55659
		// (get) Token: 0x06033FD7 RID: 212951 RVA: 0x006FDD5F File Offset: 0x006FBF5F
		// (set) Token: 0x06033FD8 RID: 212952 RVA: 0x006FDD67 File Offset: 0x006FBF67
		public TPos2Union Pos { get; set; }

		// Token: 0x06033FD9 RID: 212953 RVA: 0x006FDD70 File Offset: 0x006FBF70
		public ISwitchTrailChainEffectStateT()
		{
			this.Type = ESwitchEffectStateEffectType.ScreenEffect;
			this.Count = 0;
			this.Pos = null;
		}
	}
}
