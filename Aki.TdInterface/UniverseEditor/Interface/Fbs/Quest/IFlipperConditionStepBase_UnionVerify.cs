using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200429D RID: 17053
	public static class IFlipperConditionStepBase_UnionVerify
	{
		// Token: 0x06017DDE RID: 97758 RVA: 0x00368B28 File Offset: 0x00366D28
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
