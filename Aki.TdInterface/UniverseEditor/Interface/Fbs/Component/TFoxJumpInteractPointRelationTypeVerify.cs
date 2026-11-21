using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006248 RID: 25160
	public static class TFoxJumpInteractPointRelationTypeVerify
	{
		// Token: 0x0602AD44 RID: 175428 RVA: 0x005D92A8 File Offset: 0x005D74A8
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
