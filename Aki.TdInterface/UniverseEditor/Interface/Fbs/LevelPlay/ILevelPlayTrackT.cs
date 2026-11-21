using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004984 RID: 18820
	public class ILevelPlayTrackT
	{
		// Token: 0x170083AA RID: 33706
		// (get) Token: 0x0601C142 RID: 115010 RVA: 0x003F8044 File Offset: 0x003F6244
		// (set) Token: 0x0601C143 RID: 115011 RVA: 0x003F804C File Offset: 0x003F624C
		public int TrackRadius { get; set; }

		// Token: 0x170083AB RID: 33707
		// (get) Token: 0x0601C144 RID: 115012 RVA: 0x003F8055 File Offset: 0x003F6255
		// (set) Token: 0x0601C145 RID: 115013 RVA: 0x003F805D File Offset: 0x003F625D
		public int TrackPriority { get; set; }

		// Token: 0x170083AC RID: 33708
		// (get) Token: 0x0601C146 RID: 115014 RVA: 0x003F8066 File Offset: 0x003F6266
		// (set) Token: 0x0601C147 RID: 115015 RVA: 0x003F806E File Offset: 0x003F626E
		public int RangeEntity { get; set; }

		// Token: 0x170083AD RID: 33709
		// (get) Token: 0x0601C148 RID: 115016 RVA: 0x003F8077 File Offset: 0x003F6277
		// (set) Token: 0x0601C149 RID: 115017 RVA: 0x003F807F File Offset: 0x003F627F
		public byte NullMask { get; set; }

		// Token: 0x0601C14A RID: 115018 RVA: 0x003F8088 File Offset: 0x003F6288
		public ILevelPlayTrackT()
		{
			this.TrackRadius = 0;
			this.TrackPriority = 0;
			this.RangeEntity = 0;
			this.NullMask = 0;
		}
	}
}
