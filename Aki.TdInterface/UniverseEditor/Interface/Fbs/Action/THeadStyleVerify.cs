using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076E8 RID: 30440
	public static class THeadStyleVerify
	{
		// Token: 0x0603757D RID: 226685 RVA: 0x0077F180 File Offset: 0x0077D380
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IHeadStyleMonsterDisplayVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHeadStyleNormalVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHeadStyleVoiceOnlyVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IHeadStyleWarningVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IHeadStyleWeakSignalVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
