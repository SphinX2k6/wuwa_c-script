using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076FB RID: 30459
	public static class ISceneUiSubtitleTextBase_UnionVerify
	{
		// Token: 0x0603571A RID: 218906 RVA: 0x0072ACB8 File Offset: 0x00728EB8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISceneUiSubtitleTextBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISceneUiSubtitleTextFlowVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISceneUiSubtitleTextKeyVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
