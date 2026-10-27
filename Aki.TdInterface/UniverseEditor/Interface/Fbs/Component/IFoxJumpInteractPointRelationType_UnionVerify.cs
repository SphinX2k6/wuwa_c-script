using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052C9 RID: 21193
	public static class IFoxJumpInteractPointRelationType_UnionVerify
	{
		// Token: 0x06022918 RID: 141592 RVA: 0x004CA978 File Offset: 0x004C8B78
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFoxJumpInteractPointRelationTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFoxJumpPositionOnThisEntityVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFoxJumpPositionOnPathDrivenSpawnedActorVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
