using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062D5 RID: 25301
	public static class TSceneTextVerify
	{
		// Token: 0x0602B00A RID: 176138 RVA: 0x005DD4C8 File Offset: 0x005DB6C8
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
