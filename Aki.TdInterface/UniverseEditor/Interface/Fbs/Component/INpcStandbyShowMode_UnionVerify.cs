using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005667 RID: 22119
	public static class INpcStandbyShowMode_UnionVerify
	{
		// Token: 0x06024CA4 RID: 150692 RVA: 0x00513770 File Offset: 0x00511970
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INpcStandbyShowModeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INpcStandbyShowFinitelyVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = INpcStandbyShowLooplyVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = INpcStandbySitVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
