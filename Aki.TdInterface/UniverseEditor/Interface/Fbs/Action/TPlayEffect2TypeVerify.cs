using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007754 RID: 30548
	public static class TPlayEffect2TypeVerify
	{
		// Token: 0x060377EF RID: 227311 RVA: 0x00782F54 File Offset: 0x00781154
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
