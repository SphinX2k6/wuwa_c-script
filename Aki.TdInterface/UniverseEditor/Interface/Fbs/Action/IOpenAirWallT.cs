using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007356 RID: 29526
	public class IOpenAirWallT
	{
		// Token: 0x1700D880 RID: 55424
		// (get) Token: 0x06033832 RID: 210994 RVA: 0x006F14B4 File Offset: 0x006EF6B4
		// (set) Token: 0x06033833 RID: 210995 RVA: 0x006F14BC File Offset: 0x006EF6BC
		public EToggleAirWall Type { get; set; }

		// Token: 0x1700D881 RID: 55425
		// (get) Token: 0x06033834 RID: 210996 RVA: 0x006F14C5 File Offset: 0x006EF6C5
		// (set) Token: 0x06033835 RID: 210997 RVA: 0x006F14CD File Offset: 0x006EF6CD
		public string HitEffectData { get; set; }

		// Token: 0x1700D882 RID: 55426
		// (get) Token: 0x06033836 RID: 210998 RVA: 0x006F14D6 File Offset: 0x006EF6D6
		// (set) Token: 0x06033837 RID: 210999 RVA: 0x006F14DE File Offset: 0x006EF6DE
		public float HitCd { get; set; }

		// Token: 0x1700D883 RID: 55427
		// (get) Token: 0x06033838 RID: 211000 RVA: 0x006F14E7 File Offset: 0x006EF6E7
		// (set) Token: 0x06033839 RID: 211001 RVA: 0x006F14EF File Offset: 0x006EF6EF
		public string AirWallEffectData { get; set; }

		// Token: 0x1700D884 RID: 55428
		// (get) Token: 0x0603383A RID: 211002 RVA: 0x006F14F8 File Offset: 0x006EF6F8
		// (set) Token: 0x0603383B RID: 211003 RVA: 0x006F1500 File Offset: 0x006EF700
		public string VectorArrayAirWallEffectData { get; set; }

		// Token: 0x1700D885 RID: 55429
		// (get) Token: 0x0603383C RID: 211004 RVA: 0x006F1509 File Offset: 0x006EF709
		// (set) Token: 0x0603383D RID: 211005 RVA: 0x006F1511 File Offset: 0x006EF711
		public int AirWallEffectSplineEntityId { get; set; }

		// Token: 0x1700D886 RID: 55430
		// (get) Token: 0x0603383E RID: 211006 RVA: 0x006F151A File Offset: 0x006EF71A
		// (set) Token: 0x0603383F RID: 211007 RVA: 0x006F1522 File Offset: 0x006EF722
		public float AirWallEffectHeight { get; set; }

		// Token: 0x1700D887 RID: 55431
		// (get) Token: 0x06033840 RID: 211008 RVA: 0x006F152B File Offset: 0x006EF72B
		// (set) Token: 0x06033841 RID: 211009 RVA: 0x006F1533 File Offset: 0x006EF733
		public float AirWallEffectThickness { get; set; }

		// Token: 0x1700D888 RID: 55432
		// (get) Token: 0x06033842 RID: 211010 RVA: 0x006F153C File Offset: 0x006EF73C
		// (set) Token: 0x06033843 RID: 211011 RVA: 0x006F1544 File Offset: 0x006EF744
		public EAirWallCollisionPreset CollisionPreset { get; set; }

		// Token: 0x1700D889 RID: 55433
		// (get) Token: 0x06033844 RID: 211012 RVA: 0x006F154D File Offset: 0x006EF74D
		// (set) Token: 0x06033845 RID: 211013 RVA: 0x006F1555 File Offset: 0x006EF755
		public byte NullMask { get; set; }

		// Token: 0x06033846 RID: 211014 RVA: 0x006F1560 File Offset: 0x006EF760
		public IOpenAirWallT()
		{
			this.Type = EToggleAirWall.Open;
			this.HitEffectData = null;
			this.HitCd = 0f;
			this.AirWallEffectData = null;
			this.VectorArrayAirWallEffectData = null;
			this.AirWallEffectSplineEntityId = 0;
			this.AirWallEffectHeight = 0f;
			this.AirWallEffectThickness = 0f;
			this.CollisionPreset = EAirWallCollisionPreset.Normal;
			this.NullMask = 0;
		}
	}
}
