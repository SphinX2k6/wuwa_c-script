using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B5A RID: 27482
	public enum IMoveSceneItemType_Union : byte
	{
		// Token: 0x040113FF RID: 70655
		NONE,
		// Token: 0x04011400 RID: 70656
		IMoveSceneItemType,
		// Token: 0x04011401 RID: 70657
		IMoveToPoint,
		// Token: 0x04011402 RID: 70658
		ICycleMoveToPoints,
		// Token: 0x04011403 RID: 70659
		IMoveToRelativePosition,
		// Token: 0x04011404 RID: 70660
		IMoveToEntity
	}
}
