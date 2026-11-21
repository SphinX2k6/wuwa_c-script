using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072AD RID: 29357
	public class IMoveToRelativePositionT
	{
		// Token: 0x1700D72F RID: 55087
		// (get) Token: 0x060332A8 RID: 209576 RVA: 0x006E76AD File Offset: 0x006E58AD
		// (set) Token: 0x060332A9 RID: 209577 RVA: 0x006E76B5 File Offset: 0x006E58B5
		public EMoveSceneItemType Type { get; set; }

		// Token: 0x1700D730 RID: 55088
		// (get) Token: 0x060332AA RID: 209578 RVA: 0x006E76BE File Offset: 0x006E58BE
		// (set) Token: 0x060332AB RID: 209579 RVA: 0x006E76C6 File Offset: 0x006E58C6
		public IVectorInfoT Point { get; set; }

		// Token: 0x1700D731 RID: 55089
		// (get) Token: 0x060332AC RID: 209580 RVA: 0x006E76CF File Offset: 0x006E58CF
		// (set) Token: 0x060332AD RID: 209581 RVA: 0x006E76D7 File Offset: 0x006E58D7
		public TMoveToPointTypeUnion MoveMotion { get; set; }

		// Token: 0x060332AE RID: 209582 RVA: 0x006E76E0 File Offset: 0x006E58E0
		public IMoveToRelativePositionT()
		{
			this.Type = EMoveSceneItemType.MoveToPoint;
			this.Point = null;
			this.MoveMotion = null;
		}
	}
}
