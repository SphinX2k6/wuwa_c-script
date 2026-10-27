using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063A5 RID: 25509
	public static class IClientEventPianoEvent_UnionVerify
	{
		// Token: 0x0602C212 RID: 180754 RVA: 0x0060F85C File Offset: 0x0060DA5C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IClientEventPianoEventVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IClientEventPianoUpdateSubtitleVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IClientEventPianoSwitchPhaseVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
