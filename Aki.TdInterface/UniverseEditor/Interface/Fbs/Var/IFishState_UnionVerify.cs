using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E9A RID: 16026
	public static class IFishState_UnionVerify
	{
		// Token: 0x06015A59 RID: 88665 RVA: 0x0031E530 File Offset: 0x0031C730
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFishStateVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFishIdleStateVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFishFollowStateVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFishSplinePatrolStateVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IFishDestroyStateVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
