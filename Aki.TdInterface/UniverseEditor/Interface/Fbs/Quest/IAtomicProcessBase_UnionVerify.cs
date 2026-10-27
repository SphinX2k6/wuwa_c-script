using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D1E RID: 15646
	public static class IAtomicProcessBase_UnionVerify
	{
		// Token: 0x06015972 RID: 88434 RVA: 0x0031E1B0 File Offset: 0x0031C3B0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IAtomicProcessStoveCoreFallVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAtomicProcessBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
