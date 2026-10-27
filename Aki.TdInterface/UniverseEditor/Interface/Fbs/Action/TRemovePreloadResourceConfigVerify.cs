using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007767 RID: 30567
	public static class TRemovePreloadResourceConfigVerify
	{
		// Token: 0x06037857 RID: 227415 RVA: 0x007839B4 File Offset: 0x00781BB4
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
