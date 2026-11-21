using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F8E RID: 28558
	public static class IHeadStyle_UnionVerify
	{
		// Token: 0x060316DB RID: 202459 RVA: 0x006B3800 File Offset: 0x006B1A00
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IHeadStyleVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHeadStyleNormalVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHeadStyleVoiceOnlyVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IHeadStyleWeakSignalVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IHeadStyleWarningVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IHeadStyleMonsterDisplayVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
