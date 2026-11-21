using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A48 RID: 31304
	public static class ISwitchSubLevels_UnionVerify
	{
		// Token: 0x060372BB RID: 225979 RVA: 0x0075EBF0 File Offset: 0x0075CDF0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISwitchSubLevelsVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISwitchSubLevelsDirectlyVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPreloadSubLevelsVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISwitchPermissionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
