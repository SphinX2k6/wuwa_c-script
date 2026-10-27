using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E62 RID: 15970
	public static class IFlipperConditionStepBase_UnionVerify
	{
		// Token: 0x060167B7 RID: 92087 RVA: 0x0033FFF8 File Offset: 0x0033E1F8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFlipperConditionStepFightVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IFlipperConditionStepBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
