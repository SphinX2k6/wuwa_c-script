using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C6B RID: 23659
	public static class IPasserbyNpcExitIntervalBase_UnionVerify
	{
		// Token: 0x06027402 RID: 160770 RVA: 0x005606A4 File Offset: 0x0055E8A4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPasserbyNpcPerNpcRandomExitIntervalVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPasserbyNpcExitIntervalBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
