using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C83 RID: 23683
	public static class IPasserbyNpcGenerateTypeBase_UnionVerify
	{
		// Token: 0x06027498 RID: 160920 RVA: 0x005614D0 File Offset: 0x0055F6D0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPasserbyNpcRandomStandGenerateVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPasserbyNpcGenerateTypeBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
