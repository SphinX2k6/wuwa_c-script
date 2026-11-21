using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FEA RID: 32746
	public static class TSubScreenModeVerify
	{
		// Token: 0x0603AF28 RID: 241448 RVA: 0x007EAD58 File Offset: 0x007E8F58
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISubScreenModeAdjustVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISubScreenModeExitVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISubScreenModeInitVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
