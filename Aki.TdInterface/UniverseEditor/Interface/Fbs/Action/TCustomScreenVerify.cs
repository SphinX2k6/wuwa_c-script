using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EAB RID: 32427
	public static class TCustomScreenVerify
	{
		// Token: 0x0603A8C2 RID: 239810 RVA: 0x007E12C4 File Offset: 0x007DF4C4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICustomScreenBackgroundImageVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICustomScreenLoadingVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICustomScreenSpineVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
