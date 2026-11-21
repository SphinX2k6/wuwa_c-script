using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D09 RID: 27913
	public static class IEnableSubLevelTransitionType_UnionVerify
	{
		// Token: 0x0603022D RID: 197165 RVA: 0x0068BFC4 File Offset: 0x0068A1C4
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
