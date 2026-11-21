using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072A4 RID: 29348
	public class IMoveToEntityT
	{
		// Token: 0x1700D71A RID: 55066
		// (get) Token: 0x06033252 RID: 209490 RVA: 0x006E6A69 File Offset: 0x006E4C69
		// (set) Token: 0x06033253 RID: 209491 RVA: 0x006E6A71 File Offset: 0x006E4C71
		public EMoveSceneItemType Type { get; set; }

		// Token: 0x1700D71B RID: 55067
		// (get) Token: 0x06033254 RID: 209492 RVA: 0x006E6A7A File Offset: 0x006E4C7A
		// (set) Token: 0x06033255 RID: 209493 RVA: 0x006E6A82 File Offset: 0x006E4C82
		public int EntityId { get; set; }

		// Token: 0x1700D71C RID: 55068
		// (get) Token: 0x06033256 RID: 209494 RVA: 0x006E6A8B File Offset: 0x006E4C8B
		// (set) Token: 0x06033257 RID: 209495 RVA: 0x006E6A93 File Offset: 0x006E4C93
		public TMoveToPointTypeUnion MoveMotion { get; set; }

		// Token: 0x06033258 RID: 209496 RVA: 0x006E6A9C File Offset: 0x006E4C9C
		public IMoveToEntityT()
		{
			this.Type = EMoveSceneItemType.MoveToPoint;
			this.EntityId = 0;
			this.MoveMotion = null;
		}
	}
}
