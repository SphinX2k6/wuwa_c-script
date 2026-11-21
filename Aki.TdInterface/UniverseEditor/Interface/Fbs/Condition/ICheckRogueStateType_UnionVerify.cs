using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005003 RID: 20483
	public static class ICheckRogueStateType_UnionVerify
	{
		// Token: 0x0601FF70 RID: 130928 RVA: 0x0046FCC8 File Offset: 0x0046DEC8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICheckRogueStateTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICheckRogueTalentVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICheckRogueMiracleCreationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
