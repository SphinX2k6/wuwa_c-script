using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076E0 RID: 30432
	public static class ISceneUiSubtitleOperationBase_UnionVerify
	{
		// Token: 0x0603564C RID: 218700 RVA: 0x007294D4 File Offset: 0x007276D4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISceneUiSubtitleOperationBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISpawnSceneUiSubtitleVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRemoveSceneUiSubtitleVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
