using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A50 RID: 19024
	public static class ICheckHoldingHandsCharacterType_UnionVerify
	{
		// Token: 0x0601DCA7 RID: 122023 RVA: 0x0043010C File Offset: 0x0042E30C
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
