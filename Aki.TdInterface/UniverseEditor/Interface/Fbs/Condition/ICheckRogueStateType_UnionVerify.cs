using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B1C RID: 19228
	public static class ICheckRogueStateType_UnionVerify
	{
		// Token: 0x0601E3E5 RID: 123877 RVA: 0x0043D51C File Offset: 0x0043B71C
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
