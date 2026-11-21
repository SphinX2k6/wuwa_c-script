using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067C2 RID: 26562
	public static class IAdjustFixedLookAtTargetBase_UnionVerify
	{
		// Token: 0x0602D3FE RID: 185342 RVA: 0x00631270 File Offset: 0x0062F470
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IAdjustFixedLookAtTargetRangeEntityVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAdjustFixedLookAtTargetBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
