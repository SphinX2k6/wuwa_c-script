using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C29 RID: 15401
	public class ILaserTipsActorT
	{
		// Token: 0x17006A09 RID: 27145
		// (get) Token: 0x0601541B RID: 87067 RVA: 0x00313DCA File Offset: 0x00311FCA
		// (set) Token: 0x0601541C RID: 87068 RVA: 0x00313DD2 File Offset: 0x00311FD2
		public ETipsActorType Type { get; set; }

		// Token: 0x17006A0A RID: 27146
		// (get) Token: 0x0601541D RID: 87069 RVA: 0x00313DDB File Offset: 0x00311FDB
		// (set) Token: 0x0601541E RID: 87070 RVA: 0x00313DE3 File Offset: 0x00311FE3
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006A0B RID: 27147
		// (get) Token: 0x0601541F RID: 87071 RVA: 0x00313DEC File Offset: 0x00311FEC
		// (set) Token: 0x06015420 RID: 87072 RVA: 0x00313DF4 File Offset: 0x00311FF4
		public float Radius { get; set; }

		// Token: 0x17006A0C RID: 27148
		// (get) Token: 0x06015421 RID: 87073 RVA: 0x00313DFD File Offset: 0x00311FFD
		// (set) Token: 0x06015422 RID: 87074 RVA: 0x00313E05 File Offset: 0x00312005
		public float Height { get; set; }

		// Token: 0x17006A0D RID: 27149
		// (get) Token: 0x06015423 RID: 87075 RVA: 0x00313E0E File Offset: 0x0031200E
		// (set) Token: 0x06015424 RID: 87076 RVA: 0x00313E16 File Offset: 0x00312016
		public byte NullMask { get; set; }

		// Token: 0x06015425 RID: 87077 RVA: 0x00313E1F File Offset: 0x0031201F
		public ILaserTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Radius = 0f;
			this.Height = 0f;
			this.NullMask = 0;
		}
	}
}
