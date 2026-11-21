using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F7D RID: 32637
	public static class TPlayEffect2TypeVerify
	{
		// Token: 0x0603AD2C RID: 240940 RVA: 0x007E7F28 File Offset: 0x007E6128
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPlayCommonEffectVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPlayDissolveEffectVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPlayMpcEffectVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPlayScreenEffectVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ISwitchEffectStateVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
