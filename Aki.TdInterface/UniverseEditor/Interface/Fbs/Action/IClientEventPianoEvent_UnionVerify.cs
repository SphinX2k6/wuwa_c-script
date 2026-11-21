using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A16 RID: 27158
	public static class IClientEventPianoEvent_UnionVerify
	{
		// Token: 0x0602E974 RID: 190836 RVA: 0x0065A894 File Offset: 0x00658A94
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
