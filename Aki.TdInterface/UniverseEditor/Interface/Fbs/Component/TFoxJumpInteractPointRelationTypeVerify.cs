using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C29 RID: 23593
	public static class TFoxJumpInteractPointRelationTypeVerify
	{
		// Token: 0x06028752 RID: 165714 RVA: 0x00591318 File Offset: 0x0058F518
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFoxJumpPositionOnThisEntityVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IFoxJumpPositionOnPathDrivenSpawnedActorVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
