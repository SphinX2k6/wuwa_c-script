using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DCA RID: 28106
	public static class IPromptStyleBase_UnionVerify
	{
		// Token: 0x06031A5C RID: 203356 RVA: 0x006B9CB8 File Offset: 0x006B7EB8
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
