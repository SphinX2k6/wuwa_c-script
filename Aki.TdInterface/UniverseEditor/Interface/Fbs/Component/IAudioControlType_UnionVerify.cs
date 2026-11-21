using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053FF RID: 21503
	public static class IAudioControlType_UnionVerify
	{
		// Token: 0x06021A06 RID: 137734 RVA: 0x004A2D94 File Offset: 0x004A0F94
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
