using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062A2 RID: 25250
	public static class TNpcStandbyShowOptionVerify
	{
		// Token: 0x0602AF14 RID: 175892 RVA: 0x005DBE54 File Offset: 0x005DA054
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
