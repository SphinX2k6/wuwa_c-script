using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007461 RID: 29793
	public static class IPlayEffect2_UnionVerify
	{
		// Token: 0x0603428E RID: 213646 RVA: 0x007070E8 File Offset: 0x007052E8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPlayEffect2Verify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPlayCommonEffectVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPlayScreenEffectVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISwitchEffectStateVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPlayDissolveEffectVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IPlayMpcEffectVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
