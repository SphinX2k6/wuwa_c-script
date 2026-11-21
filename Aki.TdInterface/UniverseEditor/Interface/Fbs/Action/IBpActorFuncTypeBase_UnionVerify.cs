using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006894 RID: 26772
	public static class IBpActorFuncTypeBase_UnionVerify
	{
		// Token: 0x0602DC42 RID: 187458 RVA: 0x006418FC File Offset: 0x0063FAFC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBpActorFuncTypeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICarPaintChangeBpActorFuncVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBrokenBridgeEffectInMobileBpActorFuncVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
