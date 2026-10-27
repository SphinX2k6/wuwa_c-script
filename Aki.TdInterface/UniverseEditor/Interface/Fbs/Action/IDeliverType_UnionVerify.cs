using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200657B RID: 25979
	public static class IDeliverType_UnionVerify
	{
		// Token: 0x0602D113 RID: 184595 RVA: 0x0062EEB8 File Offset: 0x0062D0B8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IItemCellIndependentDeliverTypeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDeliverTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
