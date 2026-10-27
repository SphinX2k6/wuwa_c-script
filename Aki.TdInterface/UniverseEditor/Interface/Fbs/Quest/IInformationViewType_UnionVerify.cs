using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EB3 RID: 16051
	public static class IInformationViewType_UnionVerify
	{
		// Token: 0x06016AB4 RID: 92852 RVA: 0x00345E04 File Offset: 0x00344004
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IInformationViewTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILevelPlayInformationViewVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBossRushBuffInfoViewVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IDangoAbyssInformationViewVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
