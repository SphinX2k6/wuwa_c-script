using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200430A RID: 17162
	public static class TRoleTowerChallengeTitleTypeVerify
	{
		// Token: 0x06019742 RID: 104258 RVA: 0x003A5ECC File Offset: 0x003A40CC
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
