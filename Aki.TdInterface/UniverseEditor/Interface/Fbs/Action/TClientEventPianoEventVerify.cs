using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007673 RID: 30323
	public static class TClientEventPianoEventVerify
	{
		// Token: 0x06037301 RID: 226049 RVA: 0x0077B17C File Offset: 0x0077937C
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
