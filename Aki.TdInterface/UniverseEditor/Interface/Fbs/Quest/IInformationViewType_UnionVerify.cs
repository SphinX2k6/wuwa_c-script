using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042F1 RID: 17137
	public static class IInformationViewType_UnionVerify
	{
		// Token: 0x06018101 RID: 98561 RVA: 0x0036ED8C File Offset: 0x0036CF8C
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
