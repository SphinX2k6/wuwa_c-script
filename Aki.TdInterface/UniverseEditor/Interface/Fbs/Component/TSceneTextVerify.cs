using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CA4 RID: 23716
	public static class TSceneTextVerify
	{
		// Token: 0x060289C2 RID: 166338 RVA: 0x00594D54 File Offset: 0x00592F54
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISceneTextSubtitleWithVoiceVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISceneTextGuideUiVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
