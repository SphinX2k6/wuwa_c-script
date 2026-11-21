using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C08 RID: 23560
	public static class INpcStandbyShowMode_UnionVerify
	{
		// Token: 0x06026EDD RID: 159453 RVA: 0x0055430C File Offset: 0x0055250C
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
