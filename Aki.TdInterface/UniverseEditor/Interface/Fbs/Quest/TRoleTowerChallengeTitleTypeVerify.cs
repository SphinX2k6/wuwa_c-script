using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004769 RID: 18281
	public static class TRoleTowerChallengeTitleTypeVerify
	{
		// Token: 0x0601AEC4 RID: 110276 RVA: 0x003D17FC File Offset: 0x003CF9FC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRoleTowerChallengeTitleCurrentFloorVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRoleTowerChallengeTitleKillProgressVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRoleTowerChallengeTitlePhantomExpVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
