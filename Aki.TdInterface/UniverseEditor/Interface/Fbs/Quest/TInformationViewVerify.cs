using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042D7 RID: 17111
	public static class TInformationViewVerify
	{
		// Token: 0x06019616 RID: 103958 RVA: 0x003A4148 File Offset: 0x003A2348
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
