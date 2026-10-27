using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004ED0 RID: 20176
	public static class IAudioControlType_UnionVerify
	{
		// Token: 0x0601FCC2 RID: 130242 RVA: 0x0046CFC4 File Offset: 0x0046B1C4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAudioControlTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IGramophoneAudioControlVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITrafficAudioControlVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
