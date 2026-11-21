using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FAB RID: 32683
	public static class TSceneUiSubtitleStyleVerify
	{
		// Token: 0x0603AE02 RID: 241154 RVA: 0x007E92D4 File Offset: 0x007E74D4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISceneUiSubtitleScatterVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISceneUiSubtitleAppearVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
