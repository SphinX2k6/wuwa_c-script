using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x02004870 RID: 18544
	public static class TMatchRoleOptionVerify
	{
		// Token: 0x0601B6A8 RID: 112296 RVA: 0x003E17E4 File Offset: 0x003DF9E4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMatchAssistCharacterRoleVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMatchPhantomRoleVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMatchPlayerRoleVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
