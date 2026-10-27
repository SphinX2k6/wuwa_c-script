using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CEC RID: 27884
	public static class IPlayEffect2_UnionVerify
	{
		// Token: 0x060312BA RID: 201402 RVA: 0x006ABE78 File Offset: 0x006AA078
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
