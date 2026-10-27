using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BF2 RID: 27634
	public class IOpenAirWallT
	{
		// Token: 0x1700CD73 RID: 52595
		// (get) Token: 0x06030914 RID: 198932 RVA: 0x00697B4E File Offset: 0x00695D4E
		// (set) Token: 0x06030915 RID: 198933 RVA: 0x00697B56 File Offset: 0x00695D56
		public EToggleAirWall Type { get; set; }

		// Token: 0x1700CD74 RID: 52596
		// (get) Token: 0x06030916 RID: 198934 RVA: 0x00697B5F File Offset: 0x00695D5F
		// (set) Token: 0x06030917 RID: 198935 RVA: 0x00697B67 File Offset: 0x00695D67
		public string HitEffectData { get; set; }

		// Token: 0x1700CD75 RID: 52597
		// (get) Token: 0x06030918 RID: 198936 RVA: 0x00697B70 File Offset: 0x00695D70
		// (set) Token: 0x06030919 RID: 198937 RVA: 0x00697B78 File Offset: 0x00695D78
		public float HitCd { get; set; }

		// Token: 0x1700CD76 RID: 52598
		// (get) Token: 0x0603091A RID: 198938 RVA: 0x00697B81 File Offset: 0x00695D81
		// (set) Token: 0x0603091B RID: 198939 RVA: 0x00697B89 File Offset: 0x00695D89
		public string AirWallEffectData { get; set; }

		// Token: 0x1700CD77 RID: 52599
		// (get) Token: 0x0603091C RID: 198940 RVA: 0x00697B92 File Offset: 0x00695D92
		// (set) Token: 0x0603091D RID: 198941 RVA: 0x00697B9A File Offset: 0x00695D9A
		public string VectorArrayAirWallEffectData { get; set; }

		// Token: 0x1700CD78 RID: 52600
		// (get) Token: 0x0603091E RID: 198942 RVA: 0x00697BA3 File Offset: 0x00695DA3
		// (set) Token: 0x0603091F RID: 198943 RVA: 0x00697BAB File Offset: 0x00695DAB
		public float AirWallEffectHeight { get; set; }

		// Token: 0x1700CD79 RID: 52601
		// (get) Token: 0x06030920 RID: 198944 RVA: 0x00697BB4 File Offset: 0x00695DB4
		// (set) Token: 0x06030921 RID: 198945 RVA: 0x00697BBC File Offset: 0x00695DBC
		public float AirWallEffectThickness { get; set; }

		// Token: 0x1700CD7A RID: 52602
		// (get) Token: 0x06030922 RID: 198946 RVA: 0x00697BC5 File Offset: 0x00695DC5
		// (set) Token: 0x06030923 RID: 198947 RVA: 0x00697BCD File Offset: 0x00695DCD
		public EAirWallCollisionPreset CollisionPreset { get; set; }

		// Token: 0x1700CD7B RID: 52603
		// (get) Token: 0x06030924 RID: 198948 RVA: 0x00697BD6 File Offset: 0x00695DD6
		// (set) Token: 0x06030925 RID: 198949 RVA: 0x00697BDE File Offset: 0x00695DDE
		public byte NullMask { get; set; }

		// Token: 0x06030926 RID: 198950 RVA: 0x00697BE8 File Offset: 0x00695DE8
		public IOpenAirWallT()
		{
			this.Type = EToggleAirWall.Open;
			this.HitEffectData = null;
			this.HitCd = 0f;
			this.AirWallEffectData = null;
			this.VectorArrayAirWallEffectData = null;
			this.AirWallEffectHeight = 0f;
			this.AirWallEffectThickness = 0f;
			this.CollisionPreset = EAirWallCollisionPreset.Normal;
			this.NullMask = 0;
		}
	}
}
