using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x0200486D RID: 18541
	public static class IMatchRoleType_UnionVerify
	{
		// Token: 0x0601B69A RID: 112282 RVA: 0x003E168C File Offset: 0x003DF88C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMatchRoleTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMatchPlayerRoleVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMatchPhantomRoleVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IMatchAssistCharacterRoleVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
