using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040CC RID: 16588
	public static class IRoleTowerChallengeTitleTypeBase_UnionVerify
	{
		// Token: 0x060182B3 RID: 98995 RVA: 0x0037B73C File Offset: 0x0037993C
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
