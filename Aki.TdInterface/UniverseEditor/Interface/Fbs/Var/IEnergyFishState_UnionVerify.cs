using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E82 RID: 16002
	public static class IEnergyFishState_UnionVerify
	{
		// Token: 0x06015967 RID: 88423 RVA: 0x0031C804 File Offset: 0x0031AA04
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEnergyFishStateVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEnergyFishSplineStateVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEnergyFishFollowStateVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
