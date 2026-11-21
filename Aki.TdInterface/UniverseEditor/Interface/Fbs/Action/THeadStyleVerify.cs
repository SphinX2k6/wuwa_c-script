using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EFC RID: 32508
	public static class THeadStyleVerify
	{
		// Token: 0x0603AA4A RID: 240202 RVA: 0x007E368C File Offset: 0x007E188C
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
