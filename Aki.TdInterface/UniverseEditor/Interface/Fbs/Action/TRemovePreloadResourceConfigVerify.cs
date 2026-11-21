using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F93 RID: 32659
	public static class TRemovePreloadResourceConfigVerify
	{
		// Token: 0x0603ADA0 RID: 241056 RVA: 0x007E8A84 File Offset: 0x007E6C84
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRemovePreloadFlowsVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRemovePreloadLinkResourceVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRemovePreloadResourcePhantomCharacterVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRemovePreloadResourceTrialCharacterVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
