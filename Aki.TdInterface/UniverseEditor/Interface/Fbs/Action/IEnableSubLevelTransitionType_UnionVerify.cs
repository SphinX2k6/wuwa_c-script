using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200668F RID: 26255
	public static class IEnableSubLevelTransitionType_UnionVerify
	{
		// Token: 0x0602DA10 RID: 186896 RVA: 0x0063ED10 File Offset: 0x0063CF10
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IEnableSubLevelTransitionWithSceneCaptureVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IEnableSubLevelTransitionTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
