using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004736 RID: 18230
	public static class TInformationViewVerify
	{
		// Token: 0x0601AD98 RID: 109976 RVA: 0x003CFA78 File Offset: 0x003CDC78
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBossRushBuffInfoViewVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDangoAbyssInformationViewVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILevelPlayInformationViewVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
