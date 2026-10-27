using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056F0 RID: 22256
	public class IPathDrivenActorMoveBaseT
	{
		// Token: 0x1700A5AF RID: 42415
		// (get) Token: 0x06025326 RID: 152358 RVA: 0x00522346 File Offset: 0x00520546
		// (set) Token: 0x06025327 RID: 152359 RVA: 0x0052234E File Offset: 0x0052054E
		public EPathDrivenActorMoveType Type { get; set; }

		// Token: 0x06025328 RID: 152360 RVA: 0x00522357 File Offset: 0x00520557
		public IPathDrivenActorMoveBaseT()
		{
			this.Type = EPathDrivenActorMoveType.Spline;
		}
	}
}
