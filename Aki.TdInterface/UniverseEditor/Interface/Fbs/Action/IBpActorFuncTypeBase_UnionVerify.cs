using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006223 RID: 25123
	public static class IBpActorFuncTypeBase_UnionVerify
	{
		// Token: 0x0602B4E1 RID: 177377 RVA: 0x005F6AF4 File Offset: 0x005F4CF4
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
