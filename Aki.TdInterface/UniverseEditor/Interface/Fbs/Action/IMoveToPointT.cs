using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B61 RID: 27489
	public class IMoveToPointT
	{
		// Token: 0x1700CC3D RID: 52285
		// (get) Token: 0x0603041B RID: 197659 RVA: 0x0068E997 File Offset: 0x0068CB97
		// (set) Token: 0x0603041C RID: 197660 RVA: 0x0068E99F File Offset: 0x0068CB9F
		public EMoveSceneItemType Type { get; set; }

		// Token: 0x1700CC3E RID: 52286
		// (get) Token: 0x0603041D RID: 197661 RVA: 0x0068E9A8 File Offset: 0x0068CBA8
		// (set) Token: 0x0603041E RID: 197662 RVA: 0x0068E9B0 File Offset: 0x0068CBB0
		public IVectorInfoT Point { get; set; }

		// Token: 0x1700CC3F RID: 52287
		// (get) Token: 0x0603041F RID: 197663 RVA: 0x0068E9B9 File Offset: 0x0068CBB9
		// (set) Token: 0x06030420 RID: 197664 RVA: 0x0068E9C1 File Offset: 0x0068CBC1
		public float Time { get; set; }

		// Token: 0x1700CC40 RID: 52288
		// (get) Token: 0x06030421 RID: 197665 RVA: 0x0068E9CA File Offset: 0x0068CBCA
		// (set) Token: 0x06030422 RID: 197666 RVA: 0x0068E9D2 File Offset: 0x0068CBD2
		public TMoveToPointTypeUnion MoveMotion { get; set; }

		// Token: 0x06030423 RID: 197667 RVA: 0x0068E9DB File Offset: 0x0068CBDB
		public IMoveToPointT()
		{
			this.Type = EMoveSceneItemType.MoveToPoint;
			this.Point = null;
			this.Time = 0f;
			this.MoveMotion = null;
		}
	}
}
