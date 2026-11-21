using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004936 RID: 18742
	public class IFixedDateTimeRefreshT
	{
		// Token: 0x17008293 RID: 33427
		// (get) Token: 0x0601BD0D RID: 113933 RVA: 0x003EE574 File Offset: 0x003EC774
		// (set) Token: 0x0601BD0E RID: 113934 RVA: 0x003EE57C File Offset: 0x003EC77C
		public ELevelPlayRefreshType Type { get; set; }

		// Token: 0x17008294 RID: 33428
		// (get) Token: 0x0601BD0F RID: 113935 RVA: 0x003EE585 File Offset: 0x003EC785
		// (set) Token: 0x0601BD10 RID: 113936 RVA: 0x003EE58D File Offset: 0x003EC78D
		public ELevelPlayInteractResetTime UpdateType { get; set; }

		// Token: 0x0601BD11 RID: 113937 RVA: 0x003EE596 File Offset: 0x003EC796
		public IFixedDateTimeRefreshT()
		{
			this.Type = ELevelPlayRefreshType.None;
			this.UpdateType = ELevelPlayInteractResetTime.Weekly;
		}
	}
}
