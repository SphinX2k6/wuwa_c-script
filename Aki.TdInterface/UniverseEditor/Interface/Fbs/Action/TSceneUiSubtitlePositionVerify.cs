using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FA8 RID: 32680
	public static class TSceneUiSubtitlePositionVerify
	{
		// Token: 0x0603ADF6 RID: 241142 RVA: 0x007E91D8 File Offset: 0x007E73D8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISceneUiSubtitlePositionEntityVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISceneUiSubtitlePositionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
