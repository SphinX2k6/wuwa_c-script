using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063F6 RID: 25590
	public static class IClientSetSeasonStateConfig_UnionVerify
	{
		// Token: 0x0602C454 RID: 181332 RVA: 0x006137A0 File Offset: 0x006119A0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IClientSetSeasonStateConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISwitchSeasonVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILoopSeasonChangeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
