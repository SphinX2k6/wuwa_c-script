using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C7A RID: 23674
	public static class TNpcStandbyShowOptionVerify
	{
		// Token: 0x060288F2 RID: 166130 RVA: 0x00593A10 File Offset: 0x00591C10
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INpcStandbyShowFinitelyVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INpcStandbyShowLooplyVerify.Verify(verifier, tablePos);
				break;
			case 3:
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
