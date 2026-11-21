using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005834 RID: 22580
	public static class IFoxJumpInteractPointRelationType_UnionVerify
	{
		// Token: 0x060248DC RID: 149724 RVA: 0x00505A74 File Offset: 0x00503C74
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
