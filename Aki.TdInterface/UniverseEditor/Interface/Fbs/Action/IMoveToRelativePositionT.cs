using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B67 RID: 27495
	public class IMoveToRelativePositionT
	{
		// Token: 0x1700CC4A RID: 52298
		// (get) Token: 0x06030451 RID: 197713 RVA: 0x0068F0F1 File Offset: 0x0068D2F1
		// (set) Token: 0x06030452 RID: 197714 RVA: 0x0068F0F9 File Offset: 0x0068D2F9
		public EMoveSceneItemType Type { get; set; }

		// Token: 0x1700CC4B RID: 52299
		// (get) Token: 0x06030453 RID: 197715 RVA: 0x0068F102 File Offset: 0x0068D302
		// (set) Token: 0x06030454 RID: 197716 RVA: 0x0068F10A File Offset: 0x0068D30A
		public IVectorInfoT Point { get; set; }

		// Token: 0x1700CC4C RID: 52300
		// (get) Token: 0x06030455 RID: 197717 RVA: 0x0068F113 File Offset: 0x0068D313
		// (set) Token: 0x06030456 RID: 197718 RVA: 0x0068F11B File Offset: 0x0068D31B
		public TMoveToPointTypeUnion MoveMotion { get; set; }

		// Token: 0x06030457 RID: 197719 RVA: 0x0068F124 File Offset: 0x0068D324
		public IMoveToRelativePositionT()
		{
			this.Type = EMoveSceneItemType.MoveToPoint;
			this.Point = null;
			this.MoveMotion = null;
		}
	}
}
