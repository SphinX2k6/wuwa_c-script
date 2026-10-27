using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007764 RID: 30564
	public static class TPromptStyleVerify
	{
		// Token: 0x06037847 RID: 227399 RVA: 0x00783828 File Offset: 0x00781A28
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPromptStyleBattleVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPromptStyleBattle2Verify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPromptStyleDefaultVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPromptStylePhotoVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
