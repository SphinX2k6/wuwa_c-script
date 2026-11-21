using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007545 RID: 30021
	public static class IPromptStyleBase_UnionVerify
	{
		// Token: 0x06034A58 RID: 215640 RVA: 0x007153A0 File Offset: 0x007135A0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPromptStyleBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPromptStyleDefaultVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPromptStylePhotoVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPromptStyleBattleVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPromptStyleBattle2Verify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
