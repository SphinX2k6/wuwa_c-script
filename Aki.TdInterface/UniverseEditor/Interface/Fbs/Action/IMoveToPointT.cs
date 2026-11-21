using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072A7 RID: 29351
	public class IMoveToPointT
	{
		// Token: 0x1700D722 RID: 55074
		// (get) Token: 0x06033272 RID: 209522 RVA: 0x006E6F53 File Offset: 0x006E5153
		// (set) Token: 0x06033273 RID: 209523 RVA: 0x006E6F5B File Offset: 0x006E515B
		public EMoveSceneItemType Type { get; set; }

		// Token: 0x1700D723 RID: 55075
		// (get) Token: 0x06033274 RID: 209524 RVA: 0x006E6F64 File Offset: 0x006E5164
		// (set) Token: 0x06033275 RID: 209525 RVA: 0x006E6F6C File Offset: 0x006E516C
		public IVectorInfoT Point { get; set; }

		// Token: 0x1700D724 RID: 55076
		// (get) Token: 0x06033276 RID: 209526 RVA: 0x006E6F75 File Offset: 0x006E5175
		// (set) Token: 0x06033277 RID: 209527 RVA: 0x006E6F7D File Offset: 0x006E517D
		public float Time { get; set; }

		// Token: 0x1700D725 RID: 55077
		// (get) Token: 0x06033278 RID: 209528 RVA: 0x006E6F86 File Offset: 0x006E5186
		// (set) Token: 0x06033279 RID: 209529 RVA: 0x006E6F8E File Offset: 0x006E518E
		public TMoveToPointTypeUnion MoveMotion { get; set; }

		// Token: 0x0603327A RID: 209530 RVA: 0x006E6F97 File Offset: 0x006E5197
		public IMoveToPointT()
		{
			this.Type = EMoveSceneItemType.MoveToPoint;
			this.Point = null;
			this.Time = 0f;
			this.MoveMotion = null;
		}
	}
}
