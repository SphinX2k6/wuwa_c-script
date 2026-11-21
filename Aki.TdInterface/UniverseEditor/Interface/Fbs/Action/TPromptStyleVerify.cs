using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F90 RID: 32656
	public static class TPromptStyleVerify
	{
		// Token: 0x0603AD90 RID: 241040 RVA: 0x007E88F8 File Offset: 0x007E6AF8
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
