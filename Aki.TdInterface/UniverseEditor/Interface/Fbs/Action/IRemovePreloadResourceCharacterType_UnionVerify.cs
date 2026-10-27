using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E63 RID: 28259
	public static class IRemovePreloadResourceCharacterType_UnionVerify
	{
		// Token: 0x06031EF5 RID: 204533 RVA: 0x006C1720 File Offset: 0x006BF920
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRemovePreloadResourceCharacterTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRemovePreloadResourceTrialCharacterVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRemovePreloadFlowsVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRemovePreloadResourcePhantomCharacterVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IRemovePreloadLinkResourceVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
