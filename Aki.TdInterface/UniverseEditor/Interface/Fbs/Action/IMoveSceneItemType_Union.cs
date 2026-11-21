using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072A0 RID: 29344
	public enum IMoveSceneItemType_Union : byte
	{
		// Token: 0x04012328 RID: 74536
		NONE,
		// Token: 0x04012329 RID: 74537
		IMoveSceneItemType,
		// Token: 0x0401232A RID: 74538
		IMoveToPoint,
		// Token: 0x0401232B RID: 74539
		ICycleMoveToPoints,
		// Token: 0x0401232C RID: 74540
		IMoveToRelativePosition,
		// Token: 0x0401232D RID: 74541
		IMoveToEntity
	}
}
