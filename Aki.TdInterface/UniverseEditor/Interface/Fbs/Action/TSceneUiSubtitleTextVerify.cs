using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FAE RID: 32686
	public static class TSceneUiSubtitleTextVerify
	{
		// Token: 0x0603AE0E RID: 241166 RVA: 0x007E93D0 File Offset: 0x007E75D0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISceneUiSubtitleTextKeyVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISceneUiSubtitleTextFlowVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
