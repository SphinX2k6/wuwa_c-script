using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F16 RID: 20246
	public static class ICheckHoldingHandsCharacterType_UnionVerify
	{
		// Token: 0x0601F74A RID: 128842 RVA: 0x00461298 File Offset: 0x0045F498
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICheckHoldingHandsCharacterTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICheckIsPlayerHoldingHandsVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICheckIsEntityHoldingHandsVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
