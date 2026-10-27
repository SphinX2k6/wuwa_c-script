using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056F4 RID: 22260
	public static class IPathDrivenActorMoveBase_UnionVerify
	{
		// Token: 0x06025335 RID: 152373 RVA: 0x00522454 File Offset: 0x00520654
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
