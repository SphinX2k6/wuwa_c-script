using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075E4 RID: 30180
	public static class IRemovePreloadResourceCharacterType_UnionVerify
	{
		// Token: 0x06034F1D RID: 216861 RVA: 0x0071D220 File Offset: 0x0071B420
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
