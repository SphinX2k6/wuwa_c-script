using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058F0 RID: 22768
	public static class ISceneTextTypeBase_UnionVerify
	{
		// Token: 0x06026749 RID: 157513 RVA: 0x0054C798 File Offset: 0x0054A998
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISceneTextTypeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISceneTextSubtitleWithVoiceVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISceneTextGuideUiVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
