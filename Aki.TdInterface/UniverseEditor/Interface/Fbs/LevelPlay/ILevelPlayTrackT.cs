using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200451C RID: 17692
	public class ILevelPlayTrackT
	{
		// Token: 0x17007D69 RID: 32105
		// (get) Token: 0x0601A96D RID: 108909 RVA: 0x003CBDA8 File Offset: 0x003C9FA8
		// (set) Token: 0x0601A96E RID: 108910 RVA: 0x003CBDB0 File Offset: 0x003C9FB0
		public int TrackRadius { get; set; }

		// Token: 0x17007D6A RID: 32106
		// (get) Token: 0x0601A96F RID: 108911 RVA: 0x003CBDB9 File Offset: 0x003C9FB9
		// (set) Token: 0x0601A970 RID: 108912 RVA: 0x003CBDC1 File Offset: 0x003C9FC1
		public int TrackPriority { get; set; }

		// Token: 0x17007D6B RID: 32107
		// (get) Token: 0x0601A971 RID: 108913 RVA: 0x003CBDCA File Offset: 0x003C9FCA
		// (set) Token: 0x0601A972 RID: 108914 RVA: 0x003CBDD2 File Offset: 0x003C9FD2
		public int RangeEntity { get; set; }

		// Token: 0x17007D6C RID: 32108
		// (get) Token: 0x0601A973 RID: 108915 RVA: 0x003CBDDB File Offset: 0x003C9FDB
		// (set) Token: 0x0601A974 RID: 108916 RVA: 0x003CBDE3 File Offset: 0x003C9FE3
		public byte NullMask { get; set; }

		// Token: 0x0601A975 RID: 108917 RVA: 0x003CBDEC File Offset: 0x003C9FEC
		public ILevelPlayTrackT()
		{
			this.TrackRadius = 0;
			this.TrackPriority = 0;
			this.RangeEntity = 0;
			this.NullMask = 0;
		}
	}
}
