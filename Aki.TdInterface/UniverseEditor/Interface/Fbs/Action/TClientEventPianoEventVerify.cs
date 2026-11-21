using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E81 RID: 32385
	public static class TClientEventPianoEventVerify
	{
		// Token: 0x0603A7A6 RID: 239526 RVA: 0x007DF278 File Offset: 0x007DD478
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IClientEventPianoUpdateSubtitleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IClientEventPianoSwitchPhaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
