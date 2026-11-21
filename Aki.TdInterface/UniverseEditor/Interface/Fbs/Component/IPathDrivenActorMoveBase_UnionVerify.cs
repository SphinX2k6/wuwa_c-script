using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CE3 RID: 23779
	public static class IPathDrivenActorMoveBase_UnionVerify
	{
		// Token: 0x0602779C RID: 161692 RVA: 0x00566EA0 File Offset: 0x005650A0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPathDrivenActorSplineMoveVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPathDrivenActorMoveBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
