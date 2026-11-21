using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200450D RID: 17677
	public static class IRoleTowerChallengeTitleTypeBase_UnionVerify
	{
		// Token: 0x06019954 RID: 104788 RVA: 0x003A568C File Offset: 0x003A388C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRoleTowerChallengeTitleTypeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRoleTowerChallengeTitleKillProgressVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRoleTowerChallengeTitlePhantomExpVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRoleTowerChallengeTitleCurrentFloorVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
