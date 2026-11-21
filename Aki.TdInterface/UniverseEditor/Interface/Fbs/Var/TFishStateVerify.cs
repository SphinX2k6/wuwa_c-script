using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F57 RID: 16215
	public static class TFishStateVerify
	{
		// Token: 0x060160EA RID: 90346 RVA: 0x0032AA0C File Offset: 0x00328C0C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFishDestroyStateVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFishFollowStateVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFishIdleStateVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFishSplinePatrolStateVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
